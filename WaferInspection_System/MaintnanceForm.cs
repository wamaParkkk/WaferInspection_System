using System;
using System.Reflection;
using System.Windows.Forms;

namespace WaferInspection_System
{
    public partial class MaintnanceForm : Form
    {
        public LoadPortForm m_loadPortForm;
        public TMForm m_TMForm;
        public AlignerForm m_AlignerForm;
        public PMForm m_PMForm;
                
        public MaintnanceForm()
        {
            InitializeComponent();

            m_loadPortForm = new LoadPortForm(this);
            m_loadPortForm.Visible = false;
            Controls.Add(m_loadPortForm);

            m_TMForm = new TMForm(this);
            m_TMForm.Visible = false;
            Controls.Add(m_TMForm);

            m_AlignerForm = new AlignerForm(this);
            m_AlignerForm.Visible = false;
            Controls.Add(m_AlignerForm);

            m_PMForm = new PMForm(this);
            m_PMForm.Visible = false;
            Controls.Add(m_PMForm);
        }

        private void MaintnanceForm_Load(object sender, EventArgs e)
        {            
            if (!m_loadPortForm.Visible)
                m_loadPortForm.Visible = true;

            if (m_TMForm.Visible != false)
                m_TMForm.Visible = false;

            if (m_AlignerForm.Visible != false)
                m_AlignerForm.Visible = false;

            if (m_PMForm.Visible != false)
                m_PMForm.Visible = false;
        }

        private void MaintnanceForm_Activated(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;

            SetDoubleBuffered(m_loadPortForm);
            SetDoubleBuffered(m_TMForm);
            SetDoubleBuffered(m_AlignerForm);
            SetDoubleBuffered(m_PMForm);
        }

        private void SetDoubleBuffered(Control control, bool doubleBuffered = true)
        {
            PropertyInfo propertyInfo = typeof(Control).GetProperty
            (
                "DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic
            );
            propertyInfo.SetValue(control, doubleBuffered, null);
        }

        private void MaintnanceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_loadPortForm.Dispose();
            m_TMForm.Dispose();
            m_AlignerForm.Dispose();
            m_PMForm.Dispose();

            Dispose();            
        }

        private void displayTimer_Tick(object sender, EventArgs e)
        {
            m_loadPortForm.Display();
            m_TMForm.Display();
            m_AlignerForm.Display();
            m_PMForm.Display();
        }        
    }
}
