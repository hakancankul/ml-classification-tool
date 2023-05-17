using java.sql;
using sun.swing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using weka.core;
using weka.classifiers.functions;
using weka.classifiers.meta;


namespace dss_project1
{
    public partial class Option2Page : Form
    {
        public Option2Page()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        const int percentSplit = 66;
        static weka.classifiers.Classifier cl_BEST = null;
        static weka.classifiers.Classifier cl_LR = null;        
        static weka.classifiers.Classifier cl_1NN = null;
        static weka.classifiers.Classifier cl_3NN = null;
        static weka.classifiers.Classifier cl_5NN = null;
        static weka.classifiers.Classifier cl_7NN = null;
        static weka.classifiers.Classifier cl_9NN = null;
        static weka.classifiers.Classifier cl_NB = null;
        static weka.classifiers.Classifier cl_LOG = null;
        static weka.classifiers.Classifier cl_J48 = null;
        static weka.classifiers.Classifier cl_RT = null;
        static weka.classifiers.Classifier cl_RF = null;
        static weka.classifiers.Classifier cl_MLP = null;
        static weka.classifiers.Classifier cl_SVM = null;
        static List<TextBox> textboxes = new List<TextBox>();
        static List<ComboBox> comboboxes = new List<ComboBox>();
        static string new_file = "@RELATION new_instance\n";
        static int attribute_number = 0;
        static string accuracyFile = "";

             

        public static double ClassTest_LR(weka.core.Instances insts)
        {
            try
            {
                insts.setClassIndex(insts.numAttributes() - 1);

                cl_LR = new weka.classifiers.functions.LinearRegression();

                weka.filters.Filter myNormalize = new weka.filters.unsupervised.attribute.Normalize();
                myNormalize.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myNormalize);

                weka.filters.Filter myDummyAttr = new weka.filters.unsupervised.attribute.NominalToBinary();
                myDummyAttr.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myDummyAttr);

                weka.filters.Filter myRandom = new weka.filters.unsupervised.instance.Randomize();
                myRandom.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myRandom);

                int trainSize = insts.numInstances() * percentSplit / 100;
                int testSize = insts.numInstances() - trainSize;
                weka.core.Instances train = new weka.core.Instances(insts, 0, trainSize);

                cl_LR.buildClassifier(train);

                int numCorrect = 0;
                for (int i = trainSize; i < insts.numInstances(); i++)
                {
                    weka.core.Instance currentInst = insts.instance(i);
                    double predictedClass = cl_LR.classifyInstance(currentInst);
                    if (predictedClass == insts.instance(i).classValue())
                        numCorrect++;
                }
                return (double)numCorrect / (double)testSize * 100.0;
            }
            catch (java.lang.Exception ex)
            {
                ex.printStackTrace();
                return 0;
            }
        }

        public static double ClassTest_1NN(weka.core.Instances insts)
        {
            try
            {
                insts.setClassIndex(insts.numAttributes() - 1);

                cl_1NN = new weka.classifiers.lazy.IBk(1);                

                weka.filters.Filter myNormalize = new weka.filters.unsupervised.attribute.Normalize();
                myNormalize.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myNormalize);

                weka.filters.Filter myDummyAttr = new weka.filters.unsupervised.attribute.NominalToBinary();
                myDummyAttr.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myDummyAttr);

                weka.filters.Filter myRandom = new weka.filters.unsupervised.instance.Randomize();
                myRandom.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myRandom);

                int trainSize = insts.numInstances() * percentSplit / 100;
                int testSize = insts.numInstances() - trainSize;
                weka.core.Instances train = new weka.core.Instances(insts, 0, trainSize);

                cl_1NN.buildClassifier(train);


                int numCorrect = 0;
                for (int i = trainSize; i < insts.numInstances(); i++)
                {
                    weka.core.Instance currentInst = insts.instance(i);
                    double predictedClass = cl_1NN.classifyInstance(currentInst);
                    if (predictedClass == insts.instance(i).classValue())
                        numCorrect++;
                }
                return (double)numCorrect / (double)testSize * 100.0;
            }
            catch (java.lang.Exception ex)
            {
                ex.printStackTrace();
                return 0;
            }
        }

        public static double ClassTest_3NN(weka.core.Instances insts)
        {
            try
            {
                insts.setClassIndex(insts.numAttributes() - 1);

                cl_3NN = new weka.classifiers.lazy.IBk(3);

                weka.filters.Filter myNormalize = new weka.filters.unsupervised.attribute.Normalize();
                myNormalize.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myNormalize);

                weka.filters.Filter myDummyAttr = new weka.filters.unsupervised.attribute.NominalToBinary();
                myDummyAttr.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myDummyAttr);

                weka.filters.Filter myRandom = new weka.filters.unsupervised.instance.Randomize();
                myRandom.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myRandom);

                int trainSize = insts.numInstances() * percentSplit / 100;
                int testSize = insts.numInstances() - trainSize;
                weka.core.Instances train = new weka.core.Instances(insts, 0, trainSize);

                cl_3NN.buildClassifier(train);


                int numCorrect = 0;
                for (int i = trainSize; i < insts.numInstances(); i++)
                {
                    weka.core.Instance currentInst = insts.instance(i);
                    double predictedClass = cl_3NN.classifyInstance(currentInst);
                    if (predictedClass == insts.instance(i).classValue())
                        numCorrect++;
                }
                return (double)numCorrect / (double)testSize * 100.0;
            }
            catch (java.lang.Exception ex)
            {
                ex.printStackTrace();
                return 0;
            }
        }

        public static double ClassTest_5NN(weka.core.Instances insts)
        {
            try
            {
                insts.setClassIndex(insts.numAttributes() - 1);

                cl_5NN = new weka.classifiers.lazy.IBk(5);

                weka.filters.Filter myNormalize = new weka.filters.unsupervised.attribute.Normalize();
                myNormalize.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myNormalize);

                weka.filters.Filter myDummyAttr = new weka.filters.unsupervised.attribute.NominalToBinary();
                myDummyAttr.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myDummyAttr);

                weka.filters.Filter myRandom = new weka.filters.unsupervised.instance.Randomize();
                myRandom.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myRandom);

                int trainSize = insts.numInstances() * percentSplit / 100;
                int testSize = insts.numInstances() - trainSize;
                weka.core.Instances train = new weka.core.Instances(insts, 0, trainSize);

                cl_5NN.buildClassifier(train);


                int numCorrect = 0;
                for (int i = trainSize; i < insts.numInstances(); i++)
                {
                    weka.core.Instance currentInst = insts.instance(i);
                    double predictedClass = cl_5NN.classifyInstance(currentInst);
                    if (predictedClass == insts.instance(i).classValue())
                        numCorrect++;
                }
                return (double)numCorrect / (double)testSize * 100.0;
            }
            catch (java.lang.Exception ex)
            {
                ex.printStackTrace();
                return 0;
            }
        }

        public static double ClassTest_7NN(weka.core.Instances insts)
        {
            try
            {
                insts.setClassIndex(insts.numAttributes() - 1);

                cl_7NN = new weka.classifiers.lazy.IBk(7);

                weka.filters.Filter myNormalize = new weka.filters.unsupervised.attribute.Normalize();
                myNormalize.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myNormalize);

                weka.filters.Filter myDummyAttr = new weka.filters.unsupervised.attribute.NominalToBinary();
                myDummyAttr.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myDummyAttr);

                weka.filters.Filter myRandom = new weka.filters.unsupervised.instance.Randomize();
                myRandom.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myRandom);

                int trainSize = insts.numInstances() * percentSplit / 100;
                int testSize = insts.numInstances() - trainSize;
                weka.core.Instances train = new weka.core.Instances(insts, 0, trainSize);

                cl_7NN.buildClassifier(train);


                int numCorrect = 0;
                for (int i = trainSize; i < insts.numInstances(); i++)
                {
                    weka.core.Instance currentInst = insts.instance(i);
                    double predictedClass = cl_7NN.classifyInstance(currentInst);
                    if (predictedClass == insts.instance(i).classValue())
                        numCorrect++;
                }
                return (double)numCorrect / (double)testSize * 100.0;
            }
            catch (java.lang.Exception ex)
            {
                ex.printStackTrace();
                return 0;
            }
        }

        public static double ClassTest_9NN(weka.core.Instances insts)
        {
            try
            {
                insts.setClassIndex(insts.numAttributes() - 1);

                cl_9NN = new weka.classifiers.lazy.IBk(9);

                weka.filters.Filter myNormalize = new weka.filters.unsupervised.attribute.Normalize();
                myNormalize.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myNormalize);

                weka.filters.Filter myDummyAttr = new weka.filters.unsupervised.attribute.NominalToBinary();
                myDummyAttr.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myDummyAttr);

                weka.filters.Filter myRandom = new weka.filters.unsupervised.instance.Randomize();
                myRandom.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myRandom);

                int trainSize = insts.numInstances() * percentSplit / 100;
                int testSize = insts.numInstances() - trainSize;
                weka.core.Instances train = new weka.core.Instances(insts, 0, trainSize);

                cl_9NN.buildClassifier(train);


                int numCorrect = 0;
                for (int i = trainSize; i < insts.numInstances(); i++)
                {
                    weka.core.Instance currentInst = insts.instance(i);
                    double predictedClass = cl_9NN.classifyInstance(currentInst);
                    if (predictedClass == insts.instance(i).classValue())
                        numCorrect++;
                }
                return (double)numCorrect / (double)testSize * 100.0;
            }
            catch (java.lang.Exception ex)
            {
                ex.printStackTrace();
                return 0;
            }
        }

        public static double ClassTest_NB(weka.core.Instances insts)
        {
            try
            {
                insts.setClassIndex(insts.numAttributes() - 1);

                cl_NB = new weka.classifiers.bayes.NaiveBayes();

                //discretize
                weka.filters.Filter myDiscretize = new weka.filters.unsupervised.attribute.Discretize();
                myDiscretize.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myDiscretize);

                weka.filters.Filter myRandom = new weka.filters.unsupervised.instance.Randomize();
                myRandom.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myRandom);

                int trainSize = insts.numInstances() * percentSplit / 100;
                int testSize = insts.numInstances() - trainSize;
                weka.core.Instances train = new weka.core.Instances(insts, 0, trainSize);

                cl_NB.buildClassifier(train);


                int numCorrect = 0;
                for (int i = trainSize; i < insts.numInstances(); i++)
                {
                    weka.core.Instance currentInst = insts.instance(i);
                    double predictedClass = cl_NB.classifyInstance(currentInst);
                    if (predictedClass == insts.instance(i).classValue())
                        numCorrect++;
                }
                return (double)numCorrect / (double)testSize * 100.0;
            }
            catch (java.lang.Exception ex)
            {
                ex.printStackTrace();
                return 0;
            }
        }

        public static double ClassTest_LOG(weka.core.Instances insts)
        {
            try
            {
                insts.setClassIndex(insts.numAttributes() - 1);

                cl_LOG = new weka.classifiers.functions.Logistic();

                weka.filters.Filter myNormalize = new weka.filters.unsupervised.attribute.Normalize();
                myNormalize.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myNormalize);

                weka.filters.Filter myDummyAttr = new weka.filters.unsupervised.attribute.NominalToBinary();
                myDummyAttr.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myDummyAttr);

                weka.filters.Filter myRandom = new weka.filters.unsupervised.instance.Randomize();
                myRandom.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myRandom);

                int trainSize = insts.numInstances() * percentSplit / 100;
                int testSize = insts.numInstances() - trainSize;
                weka.core.Instances train = new weka.core.Instances(insts, 0, trainSize);

                cl_LOG.buildClassifier(train);


                int numCorrect = 0;
                for (int i = trainSize; i < insts.numInstances(); i++)
                {
                    weka.core.Instance currentInst = insts.instance(i);
                    double predictedClass = cl_LOG.classifyInstance(currentInst);
                    if (predictedClass == insts.instance(i).classValue())
                        numCorrect++;
                }
                return (double)numCorrect / (double)testSize * 100.0;
            }
            catch (java.lang.Exception ex)
            {
                ex.printStackTrace();
                return 0;
            }
        }

        public static double ClassTest_J48(weka.core.Instances insts)
        {
            try
            {
                insts.setClassIndex(insts.numAttributes() - 1);

                cl_J48 = new weka.classifiers.trees.J48();

                weka.filters.Filter myRandom = new weka.filters.unsupervised.instance.Randomize();
                myRandom.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myRandom);

                int trainSize = insts.numInstances() * percentSplit / 100;
                int testSize = insts.numInstances() - trainSize;
                weka.core.Instances train = new weka.core.Instances(insts, 0, trainSize);

                cl_J48.buildClassifier(train);


                int numCorrect = 0;
                for (int i = trainSize; i < insts.numInstances(); i++)
                {
                    weka.core.Instance currentInst = insts.instance(i);
                    double predictedClass = cl_J48.classifyInstance(currentInst);
                    if (predictedClass == insts.instance(i).classValue())
                        numCorrect++;
                }
                return (double)numCorrect / (double)testSize * 100.0;
            }
            catch (java.lang.Exception ex)
            {
                ex.printStackTrace();
                return 0;
            }
        }

        public static double ClassTest_RF(weka.core.Instances insts)
        {
            try
            {
                insts.setClassIndex(insts.numAttributes() - 1);

                cl_RF = new weka.classifiers.trees.RandomForest();

                weka.filters.Filter myRandom = new weka.filters.unsupervised.instance.Randomize();
                myRandom.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myRandom);

                int trainSize = insts.numInstances() * percentSplit / 100;
                int testSize = insts.numInstances() - trainSize;
                weka.core.Instances train = new weka.core.Instances(insts, 0, trainSize);

                cl_RF.buildClassifier(train);


                int numCorrect = 0;
                for (int i = trainSize; i < insts.numInstances(); i++)
                {
                    weka.core.Instance currentInst = insts.instance(i);
                    double predictedClass = cl_RF.classifyInstance(currentInst);
                    if (predictedClass == insts.instance(i).classValue())
                        numCorrect++;
                }
                return (double)numCorrect / (double)testSize * 100.0;
            }
            catch (java.lang.Exception ex)
            {
                ex.printStackTrace();
                return 0;
            }
        }

        public static double ClassTest_RT(weka.core.Instances insts)
        {
            try
            {
                insts.setClassIndex(insts.numAttributes() - 1);

                cl_RT = new weka.classifiers.trees.RandomTree();

                weka.filters.Filter myRandom = new weka.filters.unsupervised.instance.Randomize();
                myRandom.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myRandom);

                int trainSize = insts.numInstances() * percentSplit / 100;
                int testSize = insts.numInstances() - trainSize;
                weka.core.Instances train = new weka.core.Instances(insts, 0, trainSize);

                cl_RT.buildClassifier(train);


                int numCorrect = 0;
                for (int i = trainSize; i < insts.numInstances(); i++)
                {
                    weka.core.Instance currentInst = insts.instance(i);
                    double predictedClass = cl_RT.classifyInstance(currentInst);
                    if (predictedClass == insts.instance(i).classValue())
                        numCorrect++;
                }
                return (double)numCorrect / (double)testSize * 100.0;
            }
            catch (java.lang.Exception ex)
            {
                ex.printStackTrace();
                return 0;
            }
        }

        public static double ClassTest_MLP(weka.core.Instances insts)
        {
            try
            {
                insts.setClassIndex(insts.numAttributes() - 1);

                cl_MLP = new weka.classifiers.functions.MultilayerPerceptron();

                weka.filters.Filter myNormalize = new weka.filters.unsupervised.attribute.Normalize();
                myNormalize.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myNormalize);

                weka.filters.Filter myDummyAttr = new weka.filters.unsupervised.attribute.NominalToBinary();
                myDummyAttr.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myDummyAttr);

                weka.filters.Filter myRandom = new weka.filters.unsupervised.instance.Randomize();
                myRandom.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myRandom);

                int trainSize = insts.numInstances() * percentSplit / 100;
                int testSize = insts.numInstances() - trainSize;
                weka.core.Instances train = new weka.core.Instances(insts, 0, trainSize);

                cl_MLP.buildClassifier(train);


                int numCorrect = 0;
                for (int i = trainSize; i < insts.numInstances(); i++)
                {
                    weka.core.Instance currentInst = insts.instance(i);
                    double predictedClass = cl_MLP.classifyInstance(currentInst);
                    if (predictedClass == insts.instance(i).classValue())
                        numCorrect++;
                }
                return (double)numCorrect / (double)testSize * 100.0;
            }
            catch (java.lang.Exception ex)
            {
                ex.printStackTrace();
                return 0;
            }
        }

        public static double ClassTest_SVM(weka.core.Instances insts)
        {
            try
            {
                insts.setClassIndex(insts.numAttributes() - 1);

                cl_SVM = new weka.classifiers.functions.SMO();

                weka.filters.Filter myNormalize = new weka.filters.unsupervised.attribute.Normalize();
                myNormalize.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myNormalize);

                weka.filters.Filter myDummyAttr = new weka.filters.unsupervised.attribute.NominalToBinary();
                myDummyAttr.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myDummyAttr);

                weka.filters.Filter myRandom = new weka.filters.unsupervised.instance.Randomize();
                myRandom.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myRandom);

                int trainSize = insts.numInstances() * percentSplit / 100;
                int testSize = insts.numInstances() - trainSize;
                weka.core.Instances train = new weka.core.Instances(insts, 0, trainSize);

                cl_SVM.buildClassifier(train);


                int numCorrect = 0;
                for (int i = trainSize; i < insts.numInstances(); i++)
                {
                    weka.core.Instance currentInst = insts.instance(i);
                    double predictedClass = cl_SVM.classifyInstance(currentInst);
                    if (predictedClass == insts.instance(i).classValue())
                        numCorrect++;
                }
                return (double)numCorrect / (double)testSize * 100.0;
            }
            catch (java.lang.Exception ex)
            {
                ex.printStackTrace();
                return 0;
            }
        }

        private void modelBrowseButton_Click(object sender, EventArgs e)
        {
            string filePath = "";
            string model_file = "";
            string file_name = "";

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


            double max_acc = ClassTest_1NN(insts);
            cl_BEST = cl_1NN;

            insts = insts_temp;
            double temp_acc = ClassTest_3NN(insts);

            if (temp_acc > max_acc)
            {
                max_acc = temp_acc;
                cl_BEST = cl_3NN;

            }

            insts = insts_temp;
            temp_acc = ClassTest_5NN(insts);

            if (temp_acc > max_acc)
            {
                max_acc = temp_acc;
                cl_BEST = cl_5NN;
            }

            insts = insts_temp;
            temp_acc = ClassTest_7NN(insts);

            if (temp_acc > max_acc)
            {
                max_acc = temp_acc;
                cl_BEST = cl_7NN;
            }

            insts = insts_temp;
            temp_acc = ClassTest_9NN(insts);

            if (temp_acc > max_acc)
            {
                max_acc = temp_acc;
                cl_BEST = cl_9NN;
            }

            insts = insts_temp;
            temp_acc = ClassTest_NB(insts);

            if (temp_acc > max_acc)
            {
                max_acc = temp_acc;
                cl_BEST = cl_NB;
            }

            insts = insts_temp;
            temp_acc = ClassTest_J48(insts);

            if (temp_acc > max_acc)
            {
                max_acc = temp_acc;
                cl_BEST = cl_J48;
            }

            insts = insts_temp;
            temp_acc = ClassTest_RT(insts);

            if (temp_acc > max_acc)
            {
                max_acc = temp_acc;
                cl_BEST = cl_RT;
            }

            insts = insts_temp;
            temp_acc = ClassTest_RF(insts);

            if (temp_acc > max_acc)
            {
                max_acc = temp_acc;
                cl_BEST = cl_RF;
            }

            insts = insts_temp;
            temp_acc = ClassTest_MLP(insts);

            if (temp_acc > max_acc)
            {
                max_acc = temp_acc;
                cl_BEST = cl_MLP;
            }

            insts = insts_temp;
            temp_acc = ClassTest_SVM(insts);

            if (temp_acc > max_acc)
            {
                max_acc = temp_acc;
                cl_BEST = cl_SVM;
            }

            insts = insts_temp;
            temp_acc = ClassTest_LOG(insts);

            if (temp_acc > max_acc)
            {
                max_acc = temp_acc;
                cl_BEST = cl_LOG;
            }

            insts = insts_temp;
            temp_acc = ClassTest_LR(insts);

            if (temp_acc > max_acc)
            {
                max_acc = temp_acc;
                cl_BEST = cl_LR;
            }

            




            model_file = file_name.Replace(".arff", "_cl.model");
            weka.core.SerializationHelper.write(model_file, cl_BEST);

            string accuracyFile = "accuracy.txt";
            File.WriteAllText(accuracyFile, max_acc.ToString());

            Label newLabel = new Label();
            newLabel.Text = cl_BEST.GetType().Name + " is the most successfull algorithm for this data set " + "(%" + max_acc.ToString("F2") + ")";
            newLabel.Location = new Point(70, 60);
            newLabel.Size = new Size(450, 15);
            newLabel.Font = new Font("Microsoft Sans Serif", 8);
            this.Controls.Add(newLabel);

            Label newLabel_2 = new Label();
            newLabel_2.Text = "Fill the values for new instance;";
            newLabel_2.Location = new Point(70, 85);
            newLabel_2.Size = new Size(300, 15);
            newLabel_2.Font = new Font("Microsoft Sans Serif", 8);
            this.Controls.Add(newLabel_2);

            Panel newPanel = new Panel();
            newPanel.Location = new Point(70, 105);
            newPanel.Size = new Size(340, num_att * 25);
            newPanel.BackColor = Color.FromArgb(11, 7, 17);
            this.Controls.Add(newPanel);

            Button discoverButton = new Button();
            discoverButton.Text = "Discover";
            discoverButton.FlatAppearance.BorderSize = 0;
            discoverButton.FlatStyle = FlatStyle.Flat;
            discoverButton.BackColor = Color.FromArgb(11, 7, 17);
            discoverButton.Location = new Point(70, num_att * 25 + 115);
            discoverButton.Size = new Size(80, 20);
            discoverButton.Click += new EventHandler(discoverButton_Click);
            this.Controls.Add(discoverButton);




            int labelHeight = 25;
            int att_counter = 0;
            for (int i = 0; i < num_att - 1; i++)
            {
                Label label = new Label();
                label.ForeColor = Color.Gainsboro;
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
            result.Location = new Point(70, attribute_number * 25 + 140);
            result.Size = new Size(400, 400);
            result.Font = new Font("Microsoft Sans Serif", 10);
            this.Controls.Add(result);

        }
         
    }
}
