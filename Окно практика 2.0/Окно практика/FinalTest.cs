using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Окно_практика
{
    public partial class FinalTest : Form
    {
        int[] generation = new int[40];
        int kaunt;
        int flag_3 = 1;
        int tru;
        int anser;
        int summ_tru;

        public FinalTest()
        {
            InitializeComponent();
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            while(flag_3==1)
            {
				Hide();
                Меню_для_студента newForm = new Меню_для_студента();
                newForm.Show();
                flag_3 = 0;
            }           
        }

        private void FinalTest_Load(object sender, EventArgs e)
        {

        }

        private void FinalTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            while(flag_3==1)
            {
                Rate.Text = "0";
                CountMistake.Text = "0";

            int[] rrand = new int[10];
            int flag_1 = 0;
            int j, k;
            int prov;
            kaunt = 0;
                summ_tru = 0;


            Random rnd = new Random();
            int arra_1;
            int arra_2;

            int[] array = new int[8];
            int count = 0;

            XmlDocument xDooc = new XmlDocument();
            xDooc.Load("testing.xml");
            XmlElement xRooot = xDooc.DocumentElement;
            

            foreach (XmlNode xnode in xRooot)
            {
                if (xnode.Name == "cycles")
                {
                    foreach (XmlNode childcycles in xnode.ChildNodes)
                        count++;
                    array[0] = count;
                }
                else if (xnode.Name == "arrays")
                {
                    foreach (XmlNode childarrays in xnode.ChildNodes)
                        count++;
                    array[1] = count;
                }
                else if (xnode.Name == "lines")
                {
                    foreach (XmlNode childlines in xnode.ChildNodes)
                        count++;
                    array[2] = count;
                }
                else if (xnode.Name == "recursion")
                {
                    foreach (XmlNode childrecursion in xnode.ChildNodes)
                        count++;
                    array[3] = count;
                }
                else if (xnode.Name == "struct")
                {
                    foreach (XmlNode childstruct in xnode.ChildNodes)
                        count++;
                    array[4] = count;
                }
                else if (xnode.Name == "file")
                {
                    foreach (XmlNode childfile in xnode.ChildNodes)
                        count++;
                    array[5] = count;
                }

                else if (xnode.Name == "addresses_and_pointers")
                {
                    foreach (XmlNode childaddresses_and_pointers in xnode.ChildNodes)
                        count++;
                    array[6] = count;
                }
                else
                {
                    foreach (XmlNode childdynamic_memory in xnode.ChildNodes)
                        count++;
                    array[7] = count;
                }
                count = 0;
            }

            arra_1 = 1;
            arra_2 = array[0];
            flag_1 = 0;
            for (int i = 0; i < 5; i++)
            {
                rrand[i] = rnd.Next(arra_1, arra_2);
            }
            do
            {
                j = 1; k = 0;
                prov = 0;
                for (int i = 0; i < 5; i++)
                {
                    j = 1 + k;
                    while (j < 5)
                    {
                        if (rrand[i] == rrand[j])
                        {
                            rrand[i] = rnd.Next(arra_1, arra_2);
                        }
                        j++;
                    }
                    k++;
                }

                j = 1; k = 0;
                for (int i = 0; i < 5; i++)
                {
                    j = 1 + k;
                    while (j < 5)
                    {
                        if (rrand[i] != rrand[j])
                        {
                            prov++;
                        }
                        j++;
                    }
                    k++;
                }
                if (prov == 10) flag_1 = 1;
            } while (flag_1 != 1);
            j = 0;
            for (int i = 0; i <= 32; i += 8)
            {
                generation[i] = rrand[j];
                j++;
            }

            arra_1 = 1 + array[0];
            arra_2 = array[0] + array[1];
            flag_1 = 0;
            for (int i = 0; i < 5; i++)
            {
                rrand[i] = rnd.Next(arra_1, arra_2);
            }
            do
            {
                j = 1; k = 0;
                prov = 0;
                for (int i = 0; i < 5; i++)
                {
                    j = 1 + k;
                    while (j < 5)
                    {
                        if (rrand[i] == rrand[j])
                        {
                            rrand[i] = rnd.Next(arra_1, arra_2);
                        }
                        j++;
                    }
                    k++;
                }

                j = 1; k = 0;
                for (int i = 0; i < 5; i++)
                {
                    j = 1 + k;
                    while (j < 5)
                    {
                        if (rrand[i] != rrand[j])
                        {
                            prov++;
                        }
                        j++;
                    }
                    k++;
                }
                if (prov == 10) flag_1 = 1;
            } while (flag_1 != 1);
            j = 0;
            for (int i = 1; i <= 33; i += 8)
            {
                generation[i] = rrand[j];
                j++;
            }

            arra_1 = 1 + array[0] + array[1];
            arra_2 = array[0] + array[1] + array[2];
            flag_1 = 0;
            for (int i = 0; i < 5; i++)
            {
                rrand[i] = rnd.Next(arra_1, arra_2);
            }
            do
            {
                j = 1; k = 0;
                prov = 0;
                for (int i = 0; i < 5; i++)
                {
                    j = 1 + k;
                    while (j < 5)
                    {
                        if (rrand[i] == rrand[j])
                        {
                            rrand[i] = rnd.Next(arra_1, arra_2);
                        }
                        j++;
                    }
                    k++;
                }

                j = 1; k = 0;
                for (int i = 0; i < 5; i++)
                {
                    j = 1 + k;
                    while (j < 5)
                    {
                        if (rrand[i] != rrand[j])
                        {
                            prov++;
                        }
                        j++;
                    }
                    k++;
                }
                if (prov == 10) flag_1 = 1;
            } while (flag_1 != 1);
            j = 0;
            for (int i = 2; i <= 34; i += 8)
            {
                generation[i] = rrand[j];
                j++;
            }

            arra_1 = 1 + array[0] + array[1] + array[2];
            arra_2 = array[0] + array[1] + array[2] + array[3];
            flag_1 = 0;
            for (int i = 0; i < 5; i++)
            {
                rrand[i] = rnd.Next(arra_1, arra_2);
            }
            do
            {
                j = 1; k = 0;
                prov = 0;
                for (int i = 0; i < 5; i++)
                {
                    j = 1 + k;
                    while (j < 5)
                    {
                        if (rrand[i] == rrand[j])
                        {
                            rrand[i] = rnd.Next(arra_1, arra_2);
                        }
                        j++;
                    }
                    k++;
                }

                j = 1; k = 0;
                for (int i = 0; i < 5; i++)
                {
                    j = 1 + k;
                    while (j < 5)
                    {
                        if (rrand[i] != rrand[j])
                        {
                            prov++;
                        }
                        j++;
                    }
                    k++;
                }
                if (prov == 10) flag_1 = 1;
            } while (flag_1 != 1);
            j = 0;
            for (int i = 3; i <= 35; i += 8)
            {
                generation[i] = rrand[j];
                j++;
            }

            arra_1 = 1 + array[0] + array[1] + array[2] + array[3];
            arra_2 = array[0] + array[1] + array[2] + array[3] + array[4];
            flag_1 = 0;
            for (int i = 0; i < 5; i++)
            {
                rrand[i] = rnd.Next(arra_1, arra_2);
            }
            do
            {
                j = 1; k = 0;
                prov = 0;
                for (int i = 0; i < 5; i++)
                {
                    j = 1 + k;
                    while (j < 5)
                    {
                        if (rrand[i] == rrand[j])
                        {
                            rrand[i] = rnd.Next(arra_1, arra_2);
                        }
                        j++;
                    }
                    k++;
                }

                j = 1; k = 0;
                for (int i = 0; i < 5; i++)
                {
                    j = 1 + k;
                    while (j < 5)
                    {
                        if (rrand[i] != rrand[j])
                        {
                            prov++;
                        }
                        j++;
                    }
                    k++;
                }
                if (prov == 10) flag_1 = 1;
            } while (flag_1 != 1);
            j = 0;
            for (int i = 4; i <= 36; i += 8)
            {
                generation[i] = rrand[j];
                j++;
            }

            arra_1 = 1 + array[0] + array[1] + array[2] + array[3] + array[4];
            arra_2 = array[0] + array[1] + array[2] + array[3] + array[4] + array[5];
            flag_1 = 0;
            for (int i = 0; i < 5; i++)
            {
                rrand[i] = rnd.Next(arra_1, arra_2);
            }
            do
            {
                j = 1; k = 0;
                prov = 0;
                for (int i = 0; i < 5; i++)
                {
                    j = 1 + k;
                    while (j < 5)
                    {
                        if (rrand[i] == rrand[j])
                        {
                            rrand[i] = rnd.Next(arra_1, arra_2);
                        }
                        j++;
                    }
                    k++;
                }

                j = 1; k = 0;
                for (int i = 0; i < 5; i++)
                {
                    j = 1 + k;
                    while (j < 5)
                    {
                        if (rrand[i] != rrand[j])
                        {
                            prov++;
                        }
                        j++;
                    }
                    k++;
                }
                if (prov == 10) flag_1 = 1;
            } while (flag_1 != 1);
            j = 0;
            for (int i = 5; i <= 37; i += 8)
            {
                generation[i] = rrand[j];
                j++;
            }

            arra_1 = 1 + array[0] + array[1] + array[2] + array[3] + array[4] + array[5];
            arra_2 = array[0] + array[1] + array[2] + array[3] + array[4] + array[5] + array[6];
            flag_1 = 0;
            for (int i = 0; i < 5; i++)
            {
                rrand[i] = rnd.Next(arra_1, arra_2);
            }
            do
            {
                j = 1; k = 0;
                prov = 0;
                for (int i = 0; i < 5; i++)
                {
                    j = 1 + k;
                    while (j < 5)
                    {
                        if (rrand[i] == rrand[j])
                        {
                            rrand[i] = rnd.Next(arra_1, arra_2);
                        }
                        j++;
                    }
                    k++;
                }

                j = 1; k = 0;
                for (int i = 0; i < 5; i++)
                {
                    j = 1 + k;
                    while (j < 5)
                    {
                        if (rrand[i] != rrand[j])
                        {
                            prov++;
                        }
                        j++;
                    }
                    k++;
                }
                if (prov == 10) flag_1 = 1;
            } while (flag_1 != 1);
            j = 0;
            for (int i = 6; i <= 38; i += 8)
            {
                generation[i] = rrand[j];
                j++;
            }

            arra_1 = 1 + array[0] + array[1] + array[2] + array[3] + array[4] + array[5] + array[6];
            arra_2 = array[0] + array[1] + array[2] + array[3] + array[4] + array[5] + array[6] + array[7];
            flag_1 = 0;
            for (int i = 0; i < 5; i++)
            {
                rrand[i] = rnd.Next(arra_1, arra_2);
            }
            do
            {
                j = 1; k = 0;
                prov = 0;
                for (int i = 0; i < 5; i++)
                {
                    j = 1 + k;
                    while (j < 5)
                    {
                        if (rrand[i] == rrand[j])
                        {
                            rrand[i] = rnd.Next(arra_1, arra_2);
                        }
                        j++;
                    }
                    k++;
                }

                j = 1; k = 0;
                for (int i = 0; i < 5; i++)
                {
                    j = 1 + k;
                    while (j < 5)
                    {
                        if (rrand[i] != rrand[j])
                        {
                            prov++;
                        }
                        j++;
                    }
                    k++;
                }
                if (prov == 10) flag_1 = 1;
            } while (flag_1 != 1);
            j = 0;
            for (int i = 7; i <= 39; i += 8)
            {
                generation[i] = rrand[j];
                j++;
            }

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("testing.xml");
            XmlElement xRoot = xDoc.DocumentElement;

                for (kaunt = 0; kaunt < 1; kaunt++)
                {
                    foreach (XmlNode xnode in xRoot)
                    {
                        if (xnode.Name == "cycles")
                        {
                            foreach (XmlNode childcycles in xnode.ChildNodes)
                            {
                                if (childcycles.Attributes.Count > 0)
                                {
                                    XmlNode attr = childcycles.Attributes.GetNamedItem("id");

                                    int atrib;
                                    atrib = Convert.ToInt32(attr.Value);
                                    if (atrib == generation[kaunt])
                                    {
                                        if (childcycles.Name == "question")
                                        {
                                            foreach (XmlNode childquestion in childcycles.ChildNodes)
                                            {
                                                if (childquestion.Name == "quest")
                                                {
                                                    Question1.Text = childquestion.InnerText;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    flag_3 = 0;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Answer1.Checked)
                anser = 1;
            if (Answer2.Checked)
                anser = 2;
            if (Answer3.Checked)
                anser = 3;
            if (Answer4.Checked)
                anser = 4;

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("testing.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            
            if(kaunt<40)
            {
                if ((kaunt == 8) || (kaunt == 16) || (kaunt == 24) || (kaunt == 32))
                {
                    foreach (XmlNode xnode in xRoot)
                    {
                        if (xnode.Name == "cycles")
                        {
                            foreach (XmlNode childcycles in xnode.ChildNodes)
                            {
                                if (childcycles.Attributes.Count > 0)
                                {
                                    XmlNode attr = childcycles.Attributes.GetNamedItem("id");

                                    int atrib;
                                    atrib = Convert.ToInt32(attr.Value);
                                    if (atrib == generation[kaunt])
                                    {
                                        if (childcycles.Name == "question")
                                        {
                                            foreach (XmlNode childquestion in childcycles.ChildNodes)
                                            {
                                                if (childquestion.Name == "quest")
                                                {
                                                    Question1.Text = childquestion.InnerText;
                                                }
                                                if (childquestion.Name == "true")
                                                {
                                                    tru = Convert.ToInt32(childquestion.InnerText);
                                                    if (anser == tru)
                                                    {
                                                        summ_tru += 1;
                                                    }                                                   
                                                }
                                            }                                           
                                        }
                                    }
                                }
                            }
                        }
                    }
                    kaunt += 1;
                }
                else if ((kaunt == 1) || (kaunt == 9) || (kaunt == 17) || (kaunt == 25) || (kaunt == 33))
                {
                    foreach (XmlNode xnode in xRoot)
                    {
                        if (xnode.Name == "arrays")
                        {
                            foreach (XmlNode childarrays in xnode.ChildNodes)
                            {
                                if (childarrays.Attributes.Count > 0)
                                {
                                    XmlNode attr = childarrays.Attributes.GetNamedItem("id");
                                    int atrib;

                                    atrib = Convert.ToInt32(attr.Value);
                                    if (atrib == generation[kaunt])
                                    {
                                        if (childarrays.Name == "question")
                                        {
                                            foreach (XmlNode childquestion in childarrays.ChildNodes)
                                            {
                                                if (childquestion.Name == "quest")
                                                {
                                                    Question1.Text = childquestion.InnerText;
                                                }
                                                if (childquestion.Name == "true")
                                                {
                                                    tru = Convert.ToInt32(childquestion.InnerText);
                                                    if (anser == tru)
                                                    {
                                                        summ_tru += 1;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    kaunt += 1;
                }
                else if ((kaunt == 2) || (kaunt == 10) || (kaunt == 18) || (kaunt == 26) || (kaunt == 34))
                {
                    foreach (XmlNode xnode in xRoot)
                    {
                        if (xnode.Name == "lines")
                        {
                            foreach (XmlNode childlines in xnode.ChildNodes)
                            {
                                if (childlines.Attributes.Count > 0)
                                {
                                    XmlNode attr = childlines.Attributes.GetNamedItem("id");
                                    int atrib;
                                    atrib = Convert.ToInt32(attr.Value);
                                    if (atrib == generation[kaunt])
                                    {
                                        if (childlines.Name == "question")
                                        {
                                            foreach (XmlNode childquestion in childlines.ChildNodes)
                                            {
                                                if (childquestion.Name == "quest")
                                                {
                                                    Question1.Text = childquestion.InnerText;
                                                }
                                                if (childquestion.Name == "true")
                                                {
                                                    tru = Convert.ToInt32(childquestion.InnerText);
                                                    if (anser == tru)
                                                    {
                                                        summ_tru += 1;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    kaunt += 1;
                }
                else if ((kaunt == 3) || (kaunt == 11) || (kaunt == 19) || (kaunt == 27) || (kaunt == 35))
                {
                    foreach (XmlNode xnode in xRoot)
                    {
                        if (xnode.Name == "recursion")
                        {
                            foreach (XmlNode childrecursion in xnode.ChildNodes)
                            {
                                if (childrecursion.Attributes.Count > 0)
                                {
                                    XmlNode attr = childrecursion.Attributes.GetNamedItem("id");
                                    int atrib;
                                    atrib = Convert.ToInt32(attr.Value);
                                    if (atrib == generation[kaunt])
                                    {
                                        if (childrecursion.Name == "question")
                                        {
                                            foreach (XmlNode childquestion in childrecursion.ChildNodes)
                                            {
                                                if (childquestion.Name == "quest")
                                                {
                                                    Question1.Text = childquestion.InnerText;
                                                }
                                                if (childquestion.Name == "true")
                                                {
                                                    tru = Convert.ToInt32(childquestion.InnerText);
                                                    if (anser == tru)
                                                    {
                                                        summ_tru += 1;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    kaunt += 1;
                }
                else if ((kaunt == 4) || (kaunt == 12) || (kaunt == 20) || (kaunt == 28) || (kaunt == 36))
                {
                    foreach (XmlNode xnode in xRoot)
                    {
                        if (xnode.Name == "struct")
                        {
                            foreach (XmlNode childstruct in xnode.ChildNodes)
                            {
                                if (childstruct.Attributes.Count > 0)
                                {
                                    XmlNode attr = childstruct.Attributes.GetNamedItem("id");
                                    int atrib;
                                    atrib = Convert.ToInt32(attr.Value);
                                    if (atrib == generation[kaunt])
                                    {
                                        if (childstruct.Name == "question")
                                        {
                                            foreach (XmlNode childquestion in childstruct.ChildNodes)
                                            {
                                                if (childquestion.Name == "quest")
                                                {
                                                    Question1.Text = childquestion.InnerText;
                                                }
                                                if (childquestion.Name == "true")
                                                {
                                                    tru = Convert.ToInt32(childquestion.InnerText);
                                                    if (anser == tru)
                                                    {
                                                        summ_tru += 1;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    kaunt += 1;
                }
                else if ((kaunt == 5) || (kaunt == 13) || (kaunt == 21) || (kaunt == 29) || (kaunt == 37))
                {
                    foreach (XmlNode xnode in xRoot)
                    {
                        if (xnode.Name == "file")
                        {
                            foreach (XmlNode childfile in xnode.ChildNodes)
                            {
                                if (childfile.Attributes.Count > 0)
                                {
                                    XmlNode attr = childfile.Attributes.GetNamedItem("id");
                                    int atrib;
                                    atrib = Convert.ToInt32(attr.Value);
                                    if (atrib == generation[kaunt])
                                    {
                                        if (childfile.Name == "question")
                                        {
                                            foreach (XmlNode childquestion in childfile.ChildNodes)
                                            {
                                                if (childquestion.Name == "quest")
                                                {
                                                    Question1.Text = childquestion.InnerText;
                                                }
                                                if (childquestion.Name == "true")
                                                {
                                                    tru = Convert.ToInt32(childquestion.InnerText);
                                                    if (anser == tru)
                                                    {
                                                        summ_tru += 1;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    kaunt += 1;
                }
                else if ((kaunt == 6) || (kaunt == 14) || (kaunt == 22) || (kaunt == 30) || (kaunt == 38))
                {
                    foreach (XmlNode xnode in xRoot)
                    {
                        if (xnode.Name == "addresses_and_pointers")
                        {
                            foreach (XmlNode childaddresses_and_pointers in xnode.ChildNodes)
                            {
                                if (childaddresses_and_pointers.Attributes.Count > 0)
                                {
                                    XmlNode attr = childaddresses_and_pointers.Attributes.GetNamedItem("id");
                                    int atrib;
                                    atrib = Convert.ToInt32(attr.Value);
                                    if (atrib == generation[kaunt])
                                    {
                                        if (childaddresses_and_pointers.Name == "question")
                                        {
                                            foreach (XmlNode childquestion in childaddresses_and_pointers.ChildNodes)
                                            {
                                                if (childquestion.Name == "quest")
                                                {
                                                    Question1.Text = childquestion.InnerText;
                                                }
                                                if (childquestion.Name == "true")
                                                {
                                                    tru = Convert.ToInt32(childquestion.InnerText);
                                                    if (anser == tru)
                                                    {
                                                        summ_tru += 1;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    kaunt += 1;
                }
                else if ((kaunt == 7) || (kaunt == 15) || (kaunt == 23) || (kaunt == 31) || (kaunt == 39))
                {
                    foreach (XmlNode xnode in xRoot)
                    {
                        if (xnode.Name == "dynamic_memory")
                        {
                            foreach (XmlNode childdynamic_memory in xnode.ChildNodes)
                            {
                                if (childdynamic_memory.Attributes.Count > 0)
                                {
                                    XmlNode attr = childdynamic_memory.Attributes.GetNamedItem("id");
                                    int atrib;
                                    atrib = Convert.ToInt32(attr.Value);
                                    if (atrib == generation[kaunt])
                                    {
                                        if (childdynamic_memory.Name == "question")
                                        {
                                            foreach (XmlNode childquestion in childdynamic_memory.ChildNodes)
                                            {
                                                if (childquestion.Name == "quest")
                                                {
                                                    Question1.Text = childquestion.InnerText;
                                                }
                                                if (childquestion.Name == "true")
                                                {
                                                    tru = Convert.ToInt32(childquestion.InnerText);
                                                    if (anser == tru)
                                                    {
                                                        summ_tru += 1;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    kaunt += 1;
                }
            }
            else if (kaunt==40)
            {
                flag_3 = 1;
                Rate_Click(sender, e);
                CountMistake_Click(sender, e);
                Question1_Click(sender, e);
            }
        }

        private void Rate_Click(object sender, EventArgs e)
        {
            if ((summ_tru >= 1) && (summ_tru <=8 ))
            {
                Rate.Text = "1";
            }
            else if ((summ_tru >= 9) && (summ_tru <= 16))
            {
                Rate.Text = "2";
            }
            else if ((summ_tru >= 17) && (summ_tru <= 24))
            {
                Rate.Text = "3";
            }
            else if ((summ_tru >= 25) && (summ_tru <= 32))
            {
                Rate.Text = "4";
            }
            else if ((summ_tru >= 33) && (summ_tru <= 40))
            {
                Rate.Text = "5";
            }
			
			Test.UploadMarkFromTest(Rate.Text, true);			
		}

        private void CountMistake_Click(object sender, EventArgs e)
        {
            CountMistake.Text = Convert.ToString(40 - summ_tru);
        }

        private void Question1_Click(object sender, EventArgs e)
        {
            Question1.Text = "Вы прошли тест";
        }
    }
}
