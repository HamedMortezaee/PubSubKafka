using Confluent.Kafka;
using System.Net;
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
            string topic = txt_topic_publish.Text;
            string payload = richtxt_publish.Text;
            Task.Run(async () => {
                await SendOrderRequest(topic, payload);
            });

        }

        private async Task<bool> SendOrderRequest(string topic, string message)
        {
            ProducerConfig config = new ProducerConfig
            {
                BootstrapServers = txt_kafka_ddress.Text,
                ClientId = Dns.GetHostName()
            };

            try
            {
                using (var producer = new ProducerBuilder<Null, string>(config).Build())
                {
                    var result = await producer.ProduceAsync(topic, new Message<Null, string>
                    {
                        Value = message
                    });
                    return await Task.FromResult(true);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occured: {ex.Message}");
            }

            return await Task.FromResult(false);
        }

        private void btn_subscribe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_kafka_ddress.Text) || string.IsNullOrEmpty(txt_topic_subscribe.Text))
            {
                MessageBox.Show("اطلاعات آدرس یا تاپیک اجباری می باشد");
                return;
            }
            Task.Run(() => {
                ConsumerConfig conf = new ConsumerConfig()
                {
                    GroupId = "test_group",
                    BootstrapServers = "10.100.8.220:2004",
                    AutoOffsetReset = AutoOffsetReset.Earliest
                };
                using (var builder = new ConsumerBuilder<Ignore, string>(conf).Build())
                {
                    builder.Subscribe("testtopic");
                    var cancelToken = new CancellationTokenSource();
                    try
                    {
                        while (true)
                        {
                            var consumer = builder.Consume(cancelToken.Token);
                            SetText(consumer.Message.Value);
                            Console.WriteLine($"Message: {consumer.Message.Value} received from {consumer.TopicPartitionOffset}");
                        }
                    }
                    catch (Exception)
                    {
                        builder.Close();
                    }
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