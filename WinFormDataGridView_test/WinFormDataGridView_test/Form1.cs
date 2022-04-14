namespace WinFormDataGridView_test
{
    public partial class Form1 : Form
    {
        private Image m_Img_g = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\images\\gball.png");//add at 2017/08/07
        private Image m_Img_r = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\images\\rball.png");//add at 2017/08/07
        private Image m_Img_b = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\images\\bball.png");//add at 2017/08/07
        private Image m_Img_n = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\images\\nball.png");//add at 2017/08/07
        private Image m_Img_o = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\images\\oball.png");//�W�[images�ؿ��U���Ϥ��ƶq
        private Image m_Img_null = null;

        public Form1()
        {
            InitializeComponent();
        }

        void cleandataGridView1()
        {
            try
            {
                //--
                //dataGridView1.ReadOnly = true;//��Ū ���i���
                dataGridView1.RowHeadersVisible = false;//DataGridView �̫e�����ܿ���C�Ҧb��m���b�Y���
                dataGridView1.Rows[0].Selected = false;//����DataGridView���q�{���(�襤)Cell �Ϩ䤣����
                dataGridView1.AllowUserToAddRows = false;//�O�_���\�ϥΪ̷s�W���
                dataGridView1.AllowUserToDeleteRows = false;//�O�_���\�ϥΪ̧R�����
                dataGridView1.AllowUserToOrderColumns = false;//�O�_���\�ϥΪ̽վ�����m
                dataGridView1.AllowUserToResizeRows = false;//�O�_���\�ϥΪ̧��ܦ氪
                dataGridView1.AllowUserToResizeColumns = false;//�O�_���\�ϥΪ̧�����e

                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    dataGridView1.Columns[i].ReadOnly = true;//��@���T��s��
                    dataGridView1.Columns[i].DefaultCellStyle.NullValue = null;//���\��@�Ϥ���šA�����X��
                }

                //�]�m�Ҧ���I����
                dataGridView1.RowsDefaultCellStyle.BackColor = Color.Pink;//Color.White;

                //�]�m�_�Ʀ�I����]�U�бq�s�}�l�^
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.YellowGreen;
                
                //����C����w
                dataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.Red;


                //�N�氪�վ��A�X�ù��W��e��ܪ��椤�Ҧ��椸��]�]�A���Y�椸��^�����e�C
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;

                //���\�����ݩʳ]�w
                dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                dataGridView1.AllowUserToAddRows = false;//�R���ťզC
                dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;//��C���
                //--

                do
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        DataGridViewRow r1 = this.dataGridView1.Rows[i];//���oDataGridView��C���
                        this.dataGridView1.Rows.Remove(r1);//DataGridView�R����C
                    }
                } while (dataGridView1.Rows.Count > 0);

            }
            catch
            {
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cleandataGridView1();

            dataGridView1.Rows.Add(m_Img_b, "�D��@");
            dataGridView1.Rows.Add(m_Img_b, "�D��G");
            dataGridView1.Rows[0].Cells[1].Style.Font = new System.Drawing.Font("Microsoft JhengHei UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridView1.Rows[1].Cells[1].Style.Font = new System.Drawing.Font("Microsoft JhengHei UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            dataGridView1.Rows.Add(m_Img_g, "����Ĥ@");
            dataGridView1.Rows[2].Cells[0].Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Rows.Add(null, "����ĤG01234567890123456789012345678901234567890123456789012345678901234567890123456789");
            //dataGridView1.Rows.Add(null, "����ĤG\n0123456789\n0123456789\n0123456789\n0123456789\n0123456789\n0123456789\n0123456789\n0123456789");
        }

    }
}