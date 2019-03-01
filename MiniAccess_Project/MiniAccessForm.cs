using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using System.IO;
using DAO;

namespace MiniAccess_Project.GUI
{
    public partial class MiniAccessForm : MetroFramework.Forms.MetroForm
    {
        public MiniAccessForm()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            metroComboBoxDataType.Items.Add("Short Text");
            metroComboBoxDataType.Items.Add("Long Text");
            metroComboBoxDataType.Items.Add("Number");
            metroComboBoxDataType.Items.Add("Large Number");
            metroComboBoxDataType.Items.Add("Date/Time");
            metroComboBoxDataType.Items.Add("Currency");
            metroComboBoxDataType.Items.Add("AutoNumber");
            metroComboBoxDataType.Items.Add("Yes/No");            
            metroPanel3.Hide();
            metroPanel4.Hide();
            metroPanel5.Hide();
            metroButtonCreateFake.Hide();
            metroTileHome.Hide();
            metroTileDisplay.Hide();
            metroTileExit.Hide();
        }

        DBEngine dbe = new DBEngine();
        Database myDB;
        TableDef myTB;
        Field myFL;
        Index myInd;
        Relation myRel;        
        private void mbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (mbTheme.SelectedIndex)
            {
                case 0:
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                    break;
                case 1:
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
                    break;
            }
        }
        private void mbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroStyleManager1.Style = (MetroFramework.MetroColorStyle)Convert.ToInt32(mbColor.SelectedIndex);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            mbColor.SelectedIndex = 3;
            mbTheme.SelectedIndex = 0;
            
        }
        private void metroButtonSaveData_Click_1(object sender, EventArgs e)
        {
            if (metroTextBoxName.Text == "")
            {
                MessageBox.Show("You must give a name to your DataBase", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                saveFileDialog1.Filter = "Microsoft Access|*.accdb|All Files|*.*";
                saveFileDialog1.FileName = metroTextBoxName.Text;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveFileDialog1.FileName))
                    {
                        File.Delete(saveFileDialog1.FileName);
                    }
                    myDB = dbe.CreateDatabase(saveFileDialog1.FileName, DAO.LanguageConstants.dbLangGeneral);
                    Path.GetFullPath(saveFileDialog1.FileName);
                    metroButtonCreateFake.Show();
                }
            }
        }
        private void metroButtonCreateFake_Click(object sender, EventArgs e)
        {
            metroTextBoxName.Focus();

            if (metroTextBoxName.Text == "")
            {
                MessageBox.Show("You must give a name to your DataBase", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                metroPanel2.Hide();
                metroPanel3.Show();
            }
        }
        private void metroButtonCreateTable_Click(object sender, EventArgs e)
        {
            myDB = dbe.OpenDatabase(saveFileDialog1.FileName);

            if (metroTextBoxTableName.Text == "")
            {
                MessageBox.Show("You must give a name to your Table", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                myTB = myDB.CreateTableDef(metroTextBoxTableName.Text);
                myFL = myTB.CreateField("Ref" + metroTextBoxTableName.Text, DAO.DataTypeEnum.dbLong);
                myFL.Attributes = (int)DAO.FieldAttributeEnum.dbAutoIncrField;
                myTB.Fields.Append(myFL);
                myInd = myTB.CreateIndex("primaryKey");
                myFL = myInd.CreateField("Ref" + metroTextBoxTableName.Text);
                ((IndexFields)(myInd.Fields)).Append(myFL);
                myInd.Primary = true;
                myTB.Indexes.Append(myInd);
                int n = metroGrid1.Rows.Add();
                metroGrid1.Rows[n].Cells[0].Value = "Ref" + metroTextBoxTableName.Text;
                metroGrid1.Rows[n].Cells[1].Value = "AutoNumber";             
                metroButtonCreateTable.Enabled = false;
                metroButtonRelation.Enabled = false;
            }
        }

        private void metroButtonCreateField_Click(object sender, EventArgs e)
        {
            if (metroComboBoxDataType.Text == "")
            {
                MessageBox.Show("You must select a DataType for the field", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CreateField(metroTextBoxFieldName, metroComboBoxDataType);
                myTB.Fields.Append(myFL);
                int n = metroGrid1.Rows.Add();
                metroGrid1.Rows[n].Cells[0].Value = metroTextBoxFieldName.Text;
                metroGrid1.Rows[n].Cells[1].Value = Convert.ToString(metroComboBoxDataType.SelectedItem);
                metroButtonSaveTable.Enabled = true;
            }
        }
        private void CreateField(MetroTextBox metroTextBoxFieldName, ComboBox metroComboBoxDataType)
        {
            string typedata = metroComboBoxDataType.Text;

            switch (typedata)
            {
                case "Short Text":
                    {
                        myFL = myTB.CreateField(metroTextBoxFieldName.Text, DAO.DataTypeEnum.dbText);
                    }
                    break;
                case "Long Text":
                    {
                        myFL = myTB.CreateField(metroTextBoxFieldName.Text, DAO.DataTypeEnum.dbText);
                    }
                    break;
                case "Number":
                    {
                        myFL = myTB.CreateField(metroTextBoxFieldName.Text, DAO.DataTypeEnum.dbInteger);
                    }
                    break;
                case "Large Number":
                    {
                        myFL = myTB.CreateField(metroTextBoxFieldName.Text, DAO.DataTypeEnum.dbLong);
                    }
                    break;
                case "Date/Time":
                    {
                        myFL = myTB.CreateField(metroTextBoxFieldName.Text, DAO.DataTypeEnum.dbDate);
                    }
                    break;
                case "Currency":
                    {
                        myFL = myTB.CreateField(metroTextBoxFieldName.Text, DAO.DataTypeEnum.dbCurrency);
                    }
                    break;
                case "AutoNumber":
                    {
                        myFL = myTB.CreateField(metroTextBoxFieldName.Text, DAO.DataTypeEnum.dbInteger);
                        myFL.Attributes = Convert.ToInt32(DAO.FieldAttributeEnum.dbAutoIncrField);
                    }
                    break;
                case "Yes/No":
                    {
                        myFL = myTB.CreateField(metroTextBoxFieldName.Text, DAO.DataTypeEnum.dbBoolean);
                    }
                    break;
            }
        }
        private void metroButtonSaveTable_Click(object sender, EventArgs e)
        {          
            myDB.TableDefs.Append(myTB);
            metroTextBoxTableName.Clear();
            metroTextBoxTableName.Focus();
            metroTextBoxFieldName.Clear();
            metroComboBoxDataType.SelectedIndex = -1;
            metroGrid1.Rows.Clear();
            metroButtonCreateTable.Enabled = true;
            metroButtonRelation.Enabled = true;
            MessageBox.Show(myTB.Name + " has been created successfully", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information);              
        }
        private void metroButtonRelation_Click(object sender, EventArgs e)
        {
            metroButtonCreateTable.Enabled = false;
            metroButtonCreateField.Enabled = false;
            metroButtonRelation.Enabled = false;

            for (int t = 0; t < myDB.TableDefs.Count; t++)
            {
                if (myDB.TableDefs[t].Attributes == 0)
                {
                    metroComboBoxTabla1.Items.Add(myDB.TableDefs[t].Name);
                }
            }
            metroPanel4.Show();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroComboBoxIndex2.Items.Clear();
            for (int t = 0; t < myDB.TableDefs.Count; t++)
            {
                if (myDB.TableDefs[t].Attributes == 0)
                {
                    metroComboBoxTabla2.Items.Remove(myDB.TableDefs[metroComboBoxTabla1.Text].Name);
                    metroComboBoxTabla2.Items.Add(myDB.TableDefs[t].Name);
                }
            }
            metroComboBoxIndex1.Items.Clear();
            for (int f = 0; f < myDB.TableDefs[metroComboBoxTabla1.SelectedItem].Fields.Count; f++)
            {
                metroComboBoxIndex1.Items.Add(myDB.OpenTable(metroComboBoxTabla1.Text).Fields[f].Name);
            }
            metroComboBoxIndex1.Show();
        }
        private void metroComboBoxTabla2_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroComboBoxIndex2.Items.Clear();

            for (int f = 0; f < myDB.TableDefs[metroComboBoxTabla2.SelectedItem].Fields.Count; f++)
            {
                metroComboBoxIndex2.Items.Add(myDB.OpenTable(metroComboBoxTabla2.Text).Fields[f].Name);
            }
            metroComboBoxIndex2.Show();
        }
        private void metroButtonCreateRelations_Click(object sender, EventArgs e)
        {
            myDB.Close();
            myDB = dbe.OpenDatabase(saveFileDialog1.FileName);
            myRel = myDB.CreateRelation(metroComboBoxTabla1.Text + metroComboBoxTabla2.Text, metroComboBoxTabla1.Text, metroComboBoxTabla2.Text);
            myFL = myRel.CreateField(metroComboBoxIndex1.Text);
            myFL.ForeignName = metroComboBoxIndex2.Text;
            myRel.Fields.Append(myFL);
            myDB.Relations.Append(myRel);
            MessageBox.Show(myRel.Name + " was created with succes", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            metroComboBoxTabla1.Items.Clear();
            metroComboBoxTabla2.Items.Clear();
            metroComboBoxIndex1.Items.Clear();
            metroComboBoxIndex2.Items.Clear();
            myDB.Close();
            metroTileHome.Show();
            metroTileDisplay.Show();
            metroTileExit.Show();

        }
        private void metroTileHome_Click(object sender, EventArgs e)
        {
            metroPanel2.Show();
            metroPanel3.Hide();
            metroPanel4.Hide();
            metroPanel5.Hide();
            metroTextBoxName.Clear();
            metroTextBoxName.Focus();
            listBoxDisplay.Items.Clear();
            metroTileHome.Hide();
            metroTileDisplay.Hide();
            metroTileExit.Hide();
            metroTileExit.Show();
        }       
        private void metroTileDisplay_Click(object sender, EventArgs e)
        {
            metroPanel2.Hide();
            metroPanel3.Hide();
            metroPanel4.Hide();
            metroPanel5.Show();
            metroButtonCreateFake.Hide();
        }
        private void metroButtonDisplay_Click(object sender, EventArgs e)
        {
            {
                myDB = dbe.OpenDatabase(saveFileDialog1.FileName);

                listBoxDisplay.Items.Add("The Database : " + myDB.Name);

                for (int t = 0; t < myDB.TableDefs.Count; t++)
                {
                    if (myDB.TableDefs[t].Attributes == 0)
                    {
                        listBoxDisplay.Items.Add(" - Table: " + myDB.TableDefs[t].Name);

                        for (int f = 0; f < myDB.TableDefs[t].Fields.Count; f++)
                        {
                            listBoxDisplay.Items.Add("\t Field : " + myDB.TableDefs[t].Fields[f].Name);
                        }
                        for (int i = 0; i < myDB.TableDefs[t].Indexes.Count; i++)
                        {
                            listBoxDisplay.Items.Add("\t Index : " + myDB.TableDefs[t].Indexes[i].Name);
                            for (int f = 0; f < ((IndexFields)(myDB.TableDefs[t].Indexes[i].Fields)).Count; f++)
                            {
                                listBoxDisplay.Items.Add("\t\t Index Fields : " + ((Field)(((IndexFields)(myDB.TableDefs[t].Indexes[i].Fields))[f])).Name);
                            }
                        }
                    }
                }
                for (int r = 0; r < myDB.Relations.Count; r++)
                {
                    listBoxDisplay.Items.Add(" - Relation : " + myDB.Relations[r].Name);
                    listBoxDisplay.Items.Add("\t Primary Table : " + myDB.Relations[r].Table);
                    listBoxDisplay.Items.Add("\t Foreign Table : " + myDB.Relations[r].ForeignTable);
                    for (int f = 0; f < myDB.Relations[r].Fields.Count; f++)
                    {
                        listBoxDisplay.Items.Add("\t\t Primary Fields : " + myDB.Relations[r].Fields[f].Name);
                        listBoxDisplay.Items.Add("\t\t Foreign Fields : " + myDB.Relations[r].Fields[f].ForeignName);
                    }
                }
                myDB.Close();
                metroTileHome.Enabled = true;
            }
        }

        private void metroTileExit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure to exit the application?", "Confirmation",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

