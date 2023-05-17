using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using weka.core;
using weka.classifiers;
using System.Xml.Serialization;

namespace dss_project1
{
    public partial class Option1Page : Form
    {
        static weka.classifiers.Classifier cl_BEST = null;
        static List<TextBox> textboxes = new List<TextBox>();
        static List<ComboBox> comboboxes = new List<ComboBox>();
        static string new_file = "@RELATION new_instance\n";
        static string model_file = "";
        static string file_name = "";
        static int attribute_number;
        public Option1Page()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modelBrowseButton_Click(object sender, EventArgs e)
        {
            string filePath = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\Desktop";
            openFileDialog.Filter = "MODEL files (*.model)|*.model|All files (*.*)|*.*";
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                modelPath.Text = filePath;
            }

            string[] temp = filePath.Split('/');
            model_file = temp[temp.Length - 1];
        }

        private void datasetBrowseButton_Click(object sender, EventArgs e)
        {
            string filePath = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\Desktop";
            openFileDialog.Filter = "ARFF files (*.arff)|*.arff|All files (*.*)|*.*";
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                datasetPath.Text = filePath;
            }

            weka.core.Instances insts = new weka.core.Instances(new java.io.FileReader(filePath));
            weka.core.Instances insts_temp = new weka.core.Instances(new java.io.FileReader(filePath));
            insts.setClassIndex(insts.numAttributes() - 1);

            string[] temp = filePath.Split('/');
            file_name = temp[temp.Length - 1];

            int num_att = insts_temp.numAttributes();
            attribute_number = num_att;

            for (int i = 0; i < num_att; i++)
            {
                new_file += "@ATTRIBUTE " + insts_temp.attribute(i).name() + " ";
                if (insts_temp.attribute(i).isNumeric())
                {
                    new_file += "REAL\n";
                }
                else
                {
                    new_file += "{";
                    int sub_types_num = insts_temp.attribute(i).numValues();

                    for (int j = 0; j < sub_types_num; j++)
                    {
                        new_file += "'" + insts_temp.attribute(i).value(j) + "',";
                    }

                    new_file = new_file.Substring(0, new_file.Length - 1) + "}\n";
                }
            }

            new_file += "@DATA\n";


            cl_BEST = (weka.classifiers.Classifier)weka.core.SerializationHelper.read(model_file);
            double acc = getAccuracy();



            Label newLabel = new Label();
            newLabel.Text = cl_BEST.GetType().Name + " is the most successfull algorithm for this data set " + "(%" + acc.ToString("F2") + ")";
            newLabel.Location = new Point(70, 95);
            newLabel.Size = new Size(450, 15);
            newLabel.Font = new Font("Microsoft Sans Serif", 8);
            this.Controls.Add(newLabel);

            Label newLabel_2 = new Label();
            newLabel_2.Text = "Fill the values for new instance;";
            newLabel_2.Location = new Point(70, 120);
            newLabel_2.Size = new Size(300, 15);
            newLabel_2.Font = new Font("Microsoft Sans Serif", 8);
            this.Controls.Add(newLabel_2);

            Panel newPanel = new Panel();
            newPanel.Location = new Point(70, 140);            
            newPanel.Size = new Size(340, num_att * 25);
            newPanel.BackColor = Color.FromArgb(11, 7, 17);
            this.Controls.Add(newPanel);

            Button discoverButton = new Button();
            discoverButton.Text = "Discover";
            discoverButton.FlatAppearance.BorderSize = 0;
            discoverButton.FlatStyle = FlatStyle.Flat;
            discoverButton.BackColor = Color.FromArgb(11, 7, 17);
            discoverButton.Location = new Point(70, num_att * 25 + 150);
            discoverButton.Size = new Size(80, 20);
            discoverButton.Click += new EventHandler(discoverButton_Click);
            this.Controls.Add(discoverButton);


            int labelHeight = 25;
            int att_counter = 0;
            for (int i = 0; i < num_att - 1; i++)
            {
                Label label = new Label();
                string attribute = insts_temp.attribute(i).name();
                attribute = attribute.Substring(0, 1).ToUpper() + attribute.Substring(1);
                label.Text = attribute + ":";
                label.Location = new Point(24, 20 + i * labelHeight);
                label.Size = new Size(150, 15);
                newPanel.Controls.Add(label);



                if (insts_temp.attribute(i).isNumeric())
                {
                    TextBox textBox = new TextBox();
                    textBox.Name = att_counter.ToString();
                    textBox.Location = new Point(200, 20 + i * labelHeight);
                    textBox.Size = new Size(30, 15);
                    textBox.BackColor = Color.White;
                    newPanel.Controls.Add(textBox);
                    textboxes.Add(textBox);
                    att_counter++;

                }
                else
                {
                    ComboBox comboBox = new ComboBox();
                    comboBox.Name = att_counter.ToString();
                    comboBox.Location = new Point(200, 20 + i * labelHeight);
                    comboBox.Size = new Size(100, 15);
                    int typesNum = insts_temp.attribute(i).numValues();

                    for (int j = 0; j < typesNum; j++)
                    {

                        comboBox.Items.Add(insts_temp.attribute(i).value(j));
                    }

                    newPanel.Controls.Add(comboBox);
                    comboboxes.Add(comboBox);
                    att_counter++;
                }
            }
        }

        private void discoverButton_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < textboxes.Count; i++)
            {
                if (String.IsNullOrEmpty(textboxes[i].Text))
                {
                    MessageBox.Show("Please enter a value in the textbox.");
                    return;
                }
            }
            for (int i = 0; i < comboboxes.Count; i++)
            {
                if (String.IsNullOrEmpty(comboboxes[i].Text))
                {
                    MessageBox.Show("Please enter a value in the textbox.");
                    return;
                }
            }

            int textboxSize = textboxes.Count;
            int comboboxSize = comboboxes.Count;
            int total = textboxSize + comboboxSize;


            for (int i = 0; i < total; i++)
            {
                for (int j = 0; j < textboxes.Count; j++)
                {
                    if (i == int.Parse(textboxes[j].Name))
                    {
                        string att = textboxes[j].Text;
                        new_file += att + ",";

                    }

                }
                for (int k = 0; k < comboboxes.Count; k++)
                {
                    if (i == int.Parse(comboboxes[k].Name))
                    {
                        string SelectedItem = comboboxes[k].SelectedItem.ToString();
                        new_file += SelectedItem + ",";

                    }

                }
            }

            new_file += "?";

            StreamWriter sw_new_inst = new StreamWriter("new_instance.arff");
            sw_new_inst.Write(new_file);
            sw_new_inst.Close();



            weka.core.Instances new_insts = new weka.core.Instances(new java.io.FileReader("new_instance.arff"));
            new_insts.setClassIndex(new_insts.numAttributes() - 1);

            if (cl_BEST.GetType().FullName.ToString() == "weka.classifiers.lazy.IBk" ||
                cl_BEST.GetType().FullName.ToString() == "weka.classifiers.functions.MultilayerPerceptron" ||
                cl_BEST.GetType().FullName.ToString() == "weka.classifiers.functions.SMO" ||
                cl_BEST.GetType().FullName.ToString() == "weka.classifiers.functions.Logistic")
            {
                weka.filters.Filter myNormalize = new weka.filters.unsupervised.attribute.Normalize();
                myNormalize.setInputFormat(new_insts);
                new_insts = weka.filters.Filter.useFilter(new_insts, myNormalize);

                weka.filters.Filter myDummyAttr = new weka.filters.unsupervised.attribute.NominalToBinary();
                myDummyAttr.setInputFormat(new_insts);
                new_insts = weka.filters.Filter.useFilter(new_insts, myDummyAttr);
            }
            else if (cl_BEST.GetType().FullName.ToString() == "weka.classifiers.bayes.NaiveBayes")
            {
                weka.filters.Filter myDiscretize = new weka.filters.unsupervised.attribute.Discretize();
                myDiscretize.setInputFormat(new_insts);
                new_insts = weka.filters.Filter.useFilter(new_insts, myDiscretize);
            }

            double predictedClass = cl_BEST.classifyInstance(new_insts.instance(0));
            Label result = new Label();
            result.Text = "RESULT: " + new_insts.classAttribute().value(Convert.ToInt32(predictedClass));
            result.Location = new Point(70, attribute_number * 25 + 175);
            result.Size = new Size(400, 400);
            result.Font = new Font("Microsoft Sans Serif", 10);
            this.Controls.Add(result);

        }

        private double getAccuracy()
        {
            try
            {

                string accuracyFile = "accuracy.txt";
                string accuracyString = File.ReadAllText(accuracyFile);
                double accuracy = Convert.ToDouble(accuracyString);
                return accuracy;

            }
            catch (java.lang.Exception ex)
            {
                ex.printStackTrace();
                return 0;
            }
        }


    }
}
