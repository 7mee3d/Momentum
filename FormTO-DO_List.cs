using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace To_Do_List_Project
{
    public partial class FormTO_DO_List : Form
    {
        public FormTO_DO_List()
        {
            InitializeComponent();
            checkedListBoxTasks.ItemCheck += checkedListBoxTasks_ItemCheck;
            notifyIconSaveTODOListINFile.BalloonTipClicked += notifyIconSaveTODOListINFile_BalloonTipClickedAsync;
            notifyIconSaveTODOListINFile.Text = "Momentum";


        }
        //Main Variables Program 
        static ushort numberToDoList = 1;
        int numberPedding = 0;
        int numberCompleted = 0;

        private void fixedMoveAndResizeForm()
        {
            int xWidth = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            int yHeight = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;

            this.Location = new Point(xWidth, yHeight);

            this.Size = new Size(1239, 733);
        }

        private bool isExsitsAlreadyTask (string nameTask)
        {
            /* Way one 
            foreach(Control outSideControl in this.Controls)
            {
                foreach(Control insideControl in outSideControl.Controls)
                {
                    if(insideControl is CheckedListBox CLBT)
                    {
                        foreach (var item in CLBT.Items )
                            if(item.ToString() == nameTask )
                            return true;
                    }
                }
            }
            return false;*/

            // Way two 
            for(int counter = 0; counter <checkedListBoxTasks.Items.Count; counter++)
            {
                if (checkedListBoxTasks.Items[counter].ToString() == nameTask)
                    return true; 
            }

            return false; 

        }
     
        private bool isEmptyString (string text )
        {
            return (text == ""); 
        }
      
        private void MeAddAnyTaskInTheCheckedListBox (string nameTask )
        {
            checkedListBoxTasks.Items.Add(nameTask);
            
        }
    
        private void MeMakeTheTextBoxEmptyAndFouces(object sender)
        {

            TextBox objTextBox = (sender as TextBox);

            objTextBox.Text = "";
            objTextBox.Focus();
        }
       
        private void MeAddTheTaskAfterAllCheckListBox(string task )

        {
            if (isEmptyString(task))
            {
                if (MessageBox.Show("Please Sir , Write the Task Becosue the task is empty", "Note This task", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    MeMakeTheTextBoxEmptyAndFouces(textBoxTitleNameTask);
                }
            }
            else if (isExsitsAlreadyTask(task))
            {
                if (MessageBox.Show($"Please Sir , The Task {task} Already Exists Write the Task Not Already Exsits in the List Task", "Note This task", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    MeMakeTheTextBoxEmptyAndFouces(textBoxTitleNameTask);
                }

            }
            else
            {
                MeAddAnyTaskInTheCheckedListBox(task);
                MeMakeTheTextBoxEmptyAndFouces(textBoxTitleNameTask);
                numberPedding++;
                labelPenddingTasks.Text = Convert.ToString(numberPedding);

            }
        }

        private bool MeNonSelectedItemToRemove(int indexItem)
        {
            return (indexItem == -1); 
        }

        private void MeRemoveItemSelected (int indexItem)
        {
         
                if (MeNonSelectedItemToRemove(indexItem))
                {
                    MessageBox.Show($"Please Sir , Select to Any Task To Be Remove", "Note This task", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    checkedListBoxTasks.Items.RemoveAt(indexItem);
                numberPedding--;
                labelPenddingTasks.Text = Convert.ToString(numberPedding);
            }
            
        }

     private void RemoveAllItems(ref CheckedListBox sender )
        {

            if(!isEmptyCheckListBox(sender))
            {
                /*
                for(int counter = sender.Items.Count - 1 ; counter >=0; counter--)
                {
                    sender.Items.RemoveAt(counter);
                }*/

                sender.Items.Clear();
            }else
            {
                MessageBox.Show("The TO-DO List Already Empty", "Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

           
        }

        private bool isNonChekedOneItem (int indexItem )
        {
            return (indexItem == -1);

        }

        /* private void setAllTasksNONEnableAfterClickCheckAll(object sender)

         {
            // CheckedListBox CLB = (sender as CheckedListBox);

             foreach(Control outterControls in this.Controls)
             {
                 if(outterControls is CheckedListBox CLB)
                 {
                     foreach (Control innerControls in CLB.Controls)
                     {
                         if(innerControls is CheckBox CB )
                             CB.Enabled = false; 
                     }
                 }
             }

         }*/
        private void setAllItemsChecked(object sender)

        {
            CheckedListBox CLB = (sender as CheckedListBox);
            if (!isEmptyCheckListBox(CLB)) { 
                for (int counter = 0; counter < CLB.Items.Count; counter++)
                {
                    if (isNonChekedOneItem(CLB.Items.IndexOf(CLB.GetItemChecked(counter)))) {

                        CLB.SetItemChecked(counter, true);
                       

                    }
                }
            }
            else
            {
                MessageBox.Show("The TO-DO List Already Empty", "Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void setAllItemsUnChecked(object sender)

        {
            CheckedListBox CLB = (sender as CheckedListBox);
            if(!isEmptyCheckListBox(CLB)){ 
            for (int counter = 0; counter < CLB.Items.Count; counter++)
            {
                if (isNonChekedOneItem(CLB.Items.IndexOf(CLB.GetItemChecked(counter))))
                {
                    CLB.SetItemChecked(counter, false);
                        
                        
                    }
            } }
             else
            {
                MessageBox.Show("The TO-DO List Already Empty", "Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private bool isEmptyCheckListBox(object sender )
        {
            CheckedListBox CLB = (sender as CheckedListBox);
            return (CLB.Items.Count == 0 ); 
        }

        private void HeaderSaveFileTextTODOList(ref string informationTODO_ListTasks) 
        {
            informationTODO_ListTasks += Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            informationTODO_ListTasks += Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            informationTODO_ListTasks += "  |-----------------------------------/\\ Tasks TO-DO List \\/-------------------------------------|" + Environment.NewLine;
            informationTODO_ListTasks += "  |                                                                                              |" + Environment.NewLine;
            informationTODO_ListTasks += "  |                       N.O TO-DO List : " + Convert.ToString(numberToDoList++) + "                                                     |" + Environment.NewLine;
            informationTODO_ListTasks += "  |                       Date Time Save TO-DO List " + DateTime.Now.ToString() + "                         |" + Environment.NewLine;
            informationTODO_ListTasks += "  |                                                                                              |" + Environment.NewLine;

            informationTODO_ListTasks += "  |----------------------------------------------------------------------------------------------|" + Environment.NewLine;
            informationTODO_ListTasks += "  |                                                                                              |" + Environment.NewLine;
            informationTODO_ListTasks += "  |                                                                                              |" + Environment.NewLine;
            informationTODO_ListTasks += "  |                                                                                              |" + Environment.NewLine;
            informationTODO_ListTasks += "  |                                       Name Task Checked                                      |" + Environment.NewLine;
            informationTODO_ListTasks += "  |----------------------------------------------------------------------------------------------|" + Environment.NewLine;
        }

        private void MiddleHeaderSaveFileTextTODOList(ref string informationTODO_ListTasks)
        {
            informationTODO_ListTasks += "  |                                                                                              |" + Environment.NewLine;
            informationTODO_ListTasks += "  |----------------------------------------------------------------------------------------------|" + Environment.NewLine;

            informationTODO_ListTasks += Environment.NewLine + Environment.NewLine;
            informationTODO_ListTasks += "  |----------------------------------------------------------------------------------------------|" + Environment.NewLine;
            informationTODO_ListTasks += "  |                                      Name Task UnChecked                                     |" + Environment.NewLine;
            informationTODO_ListTasks += "  |----------------------------------------------------------------------------------------------|" + Environment.NewLine;
            informationTODO_ListTasks += "  |                                                                                              |" + Environment.NewLine;
        }
     
        private void FooterHeaderSaveFileTextTODOList(ref string informationTODO_ListTasks)
        { 
            informationTODO_ListTasks += "  |                                                                                              |" + Environment.NewLine;
            informationTODO_ListTasks += "  |----------------------------------------------------------------------------------------------|" + Environment.NewLine;
          }
    
        private string linesTXTInformationTasksTODOList(object sender)
        {
            CheckedListBox CLB =  sender as CheckedListBox; 
            string informationTODO_ListTasks = "";
            ushort countCheckedTask = 1; 
            ushort countUNCheckedTask = 1;


            HeaderSaveFileTextTODOList(ref informationTODO_ListTasks);

            for (int counter = 0 ; counter < CLB.Items.Count; counter++)
            {
                if (CLB.GetItemChecked(counter)) 
                {
                    string itemName = CLB.Items[counter].ToString(); 
                    informationTODO_ListTasks +=$"  | {countCheckedTask++}- " + string.Format(" {0, -88} | ", itemName) + Environment.NewLine;
                }

            }
            MiddleHeaderSaveFileTextTODOList(ref informationTODO_ListTasks);

            for (int counter2 = 0; counter2 < CLB.Items.Count; counter2++)
            {
                if (!CLB.GetItemChecked(counter2))
                {
                    string itemName = CLB.Items[counter2].ToString();
                    informationTODO_ListTasks += $"  | {countUNCheckedTask++}- " + string.Format(" {0, -88} | ", itemName) + Environment.NewLine;
                }
            }
            FooterHeaderSaveFileTextTODOList(ref informationTODO_ListTasks);


            return informationTODO_ListTasks;
        }
       
        private  void notfityIconSaveTODOListInTheFile ()
        {
            notifyIconSaveTODOListINFile.ShowBalloonTip(500, $"Notification Momentum{Environment.NewLine+Environment.NewLine}", "Done Save This TO-DO List..", ToolTipIcon.Info);
      
        }

        private string EmptylinesTXTInformationTasksTODOList(object sender)
        {
            CheckedListBox CLB = sender as CheckedListBox;
            string informationTODO_ListTasks = "";

            if (CLB.Items.Count == 0 )
            {
                HeaderSaveFileTextTODOList(ref informationTODO_ListTasks);
                informationTODO_ListTasks += "  |                                                                                              |" + Environment.NewLine;
                informationTODO_ListTasks += "  |                                       Empty TO-DO List                                       |" + Environment.NewLine;
                informationTODO_ListTasks += "  |                                                                                              |" + Environment.NewLine;

                MiddleHeaderSaveFileTextTODOList(ref informationTODO_ListTasks);
                informationTODO_ListTasks += "  |                                                                                              |" + Environment.NewLine;
                informationTODO_ListTasks += "  |                                       Empty TO-DO List                                       |" + Environment.NewLine;


                FooterHeaderSaveFileTextTODOList(ref informationTODO_ListTasks);


            }
            return informationTODO_ListTasks;
        }
    
        private void newTODOListResetAllSetting(object sender)

        {

            CheckedListBox CLB = (sender as CheckedListBox);
          
            numberPedding = 0;
            numberCompleted = 0;
            labelPenddingTasks.Text = Convert.ToString(numberPedding);
            labelCompleteNumberTasks.Text = Convert.ToString(numberCompleted);

            CLB.Items.Clear(); 

        }
        
        private void SaveTasksInFile (object sender)
        {
            CheckedListBox CLT = (sender as CheckedListBox);

            System.IO.StreamWriter SW = new System.IO.StreamWriter("InformationTO_DOList.txt" , true );
            if (!isEmptyCheckListBox(checkedListBoxTasks))
                SW.WriteLine(linesTXTInformationTasksTODOList(CLT));

            else SW.WriteLine(EmptylinesTXTInformationTasksTODOList(CLT));


            SW.Close(); 
        }
      
        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            string task = textBoxTitleNameTask.Text;

            MeAddTheTaskAfterAllCheckListBox(task);
            
        }

        private void buttonRemoveTask_Click(object sender, EventArgs e)
        {
            MeRemoveItemSelected(checkedListBoxTasks.SelectedIndex);
           
        }

        private void buttonCheckedAllTasks_Click(object sender, EventArgs e)
        {
            setAllItemsChecked(checkedListBoxTasks);
            (checkedListBoxTasks).Enabled = false ;
   


        }

        private void buttonUnCheckedAllTasks_Click(object sender, EventArgs e)
        {
            setAllItemsUnChecked(checkedListBoxTasks);
            (checkedListBoxTasks).Enabled = true;
            numberCompleted = 0;
            labelCompleteNumberTasks.Text = numberCompleted.ToString();
            numberPedding = checkedListBoxTasks.Items.Count;
            labelPenddingTasks.Text = numberPedding.ToString();
        }

        private void buttonSaveAllTasksTODOListInFile_Click(object sender, EventArgs e)
        {

            SaveTasksInFile(checkedListBoxTasks);
            MessageBox.Show("The TO-DO List Is Saved in the File ", "Note Save TO-DO List", MessageBoxButtons.OK, MessageBoxIcon.Information);

            notfityIconSaveTODOListInTheFile();

        }

        private void buttonRemoveAllTask_Click(object sender, EventArgs e)
        {
            RemoveAllItems(ref checkedListBoxTasks);
            numberPedding = 0 ;
            labelPenddingTasks.Text = Convert.ToString(numberPedding);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close(); 
        }

        private async void checkedListBoxTasks_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            if (e.NewValue == CheckState.Checked) // لو المستخدم عمل Check
            { 
                    
                        numberCompleted++;
                        numberPedding--;

                        labelCompleteNumberTasks.Text = numberCompleted.ToString();
                        labelPenddingTasks.Text = numberPedding.ToString();


            }

            if (e.NewValue == CheckState.Unchecked) // لو المستخدم عمل Check
            {

            
               
                    numberCompleted--;
                    numberPedding++;

                    labelCompleteNumberTasks.Text = numberCompleted.ToString();
                    labelPenddingTasks.Text = numberPedding.ToString();


            }

        }

        private void pictureBoxResetAlSettings_Click(object sender, EventArgs e)
        {
            newTODOListResetAllSetting(checkedListBoxTasks);
        }

        private void FormTO_DO_List_Move(object sender, EventArgs e)
        {
            fixedMoveAndResizeForm();
        }

        private void FormTO_DO_List_Resize(object sender, EventArgs e)
        {
            fixedMoveAndResizeForm();

        }

        private async void notifyIconSaveTODOListINFile_BalloonTipClickedAsync(object sender, EventArgs e)
        {

            await Task.Delay(1000);
            System.Diagnostics.Process.Start("InformationTO_DOList.txt");
        }
    }
}
