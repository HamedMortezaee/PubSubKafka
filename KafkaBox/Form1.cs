using KafkaNet;
using KafkaNet.Model;
using System.Text;
using System.Threading;

namespace KafkaBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_publish_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_kafka_ddress.Text) || string.IsNullOrEmpty(txt_topic_publish.Text))
            {
                MessageBox.Show("اطلاعات آدرس یا تاپیک اجباری می باشد");
                return;
            }
            Uri uri = new Uri(txt_kafka_ddress.Text);
            string topic = txt_topic_publish.Text;

            string payload = richtxt_publish.Text;
            var sendMessage = new Thread(() =>
            {
                KafkaNet.Protocol.Message msg = new KafkaNet.Protocol.Message(payload);
                var options = new KafkaOptions(uri);
                var router = new BrokerRouter(options);
                var client = new Producer(router);
                client.SendMessageAsync(topic, new List<KafkaNet.Protocol.Message> { msg }).Wait();
            });
            sendMessage.Start();
        }

        private void btn_subscribe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_kafka_ddress.Text) || string.IsNullOrEmpty(txt_topic_subscribe.Text))
            {
                MessageBox.Show("اطلاعات آدرس یا تاپیک اجباری می باشد");
                return;
            }


            Task.Run(() =>
            {
                Uri uri = new Uri(txt_kafka_ddress.Text);
                string topicName = txt_topic_subscribe.Text;
                var options = new KafkaOptions(uri);
                var brokerRouter = new BrokerRouter(options);
                var consumer = new Consumer(new ConsumerOptions(topicName, brokerRouter));
                foreach (var msg in consumer.Consume())
                {
                    SetText(Encoding.UTF8.GetString(msg.Value));
                }
            });

        }

        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.

            if (this.listBox_subscribe.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.listBox_subscribe.Items.Add(text);
            }
        }

    }
}