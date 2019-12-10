using System;
using System.Windows.Forms;

namespace Log4netDemo
{
    public partial class Log4netDemoForm : Form
    {
        //申明log4net日志记录对象
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));

        //Form初始化
        public Log4netDemoForm()
        {
            InitializeComponent();
        }

        //记录日志按钮点击事件
        private void button_LogInfo_Click(object sender, EventArgs e)
        {
            LogContent logContent = new LogContent();
            
            logContent.ErrorDescription= "点击了记录日志按钮,向数据库中插入了一条记录";

            Exception ex = new Exception(logContent.ErrorDescription);

            log.Error(logContent,ex);
        }
    }
}
