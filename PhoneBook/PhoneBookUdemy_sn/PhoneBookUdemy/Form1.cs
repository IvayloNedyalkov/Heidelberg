using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhoneBookUdemy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void phone_book_tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phone_book_tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.phone_book_table' table. You can move, or remove it, as needed.
            this.phone_book_tableTableAdapter.Fill(this.dataSet1.phone_book_table);
            //------disable save and cancel butt-----
            this.save_butt.Enabled = false;
            this.cancel_butt.Enabled = false;
            //---------------------------------------
        }
        private void new_butt_Click_1(object sendar, EventArgs e)
        {
            this.new_butt.Enabled = false;
            this.edit_butt.Enabled = false;
            this.delete_butt.Enabled = false;
            //--------Enable save and cancel butt-----
            this.save_butt.Enabled = true;
            this.cancel_butt.Enabled = true;
            //----------------------------------------
        }
        private void cancel_butt_Click(object sendar, EventArgs e)
        {
            this.save_butt.Enabled = false;
            this.cancel_butt.Enabled = false;

            //--------Enable save and cancel butt-----
            this.new_butt.Enabled = true;
            this.edit_butt.Enabled = true;
            this.delete_butt.Enabled = true;
            //----------------------------------------
        }





    }
}
