﻿using Confluent.Kafka;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ELK.Logstach_Kafka
{
    public class ConfulentKafka
    {

        /// <summary>
        /// 发送事件
        /// </summary>
        /// <param name="event"></param>
        public static async Task Produce(string brokerlist, string topicname, string content)
        {

            string brokerList = brokerlist;
            string topicName = topicname;

            var config = new ProducerConfig { BootstrapServers = brokerList };

            using (var producer = new ProducerBuilder<string, string>(config).Build())
            {
                Console.WriteLine("\n-----------------------------------------------------------------------");
                Console.WriteLine($"Producer {producer.Name} producing on topic {topicName}.");
                Console.WriteLine("-----------------------------------------------------------------------");
                try
                {
                    var deliveryReport = await producer.ProduceAsync(
                        topicName, new Message<string, string> { Key = content, Value = content });

                    Console.WriteLine($"delivered to: {deliveryReport.TopicPartitionOffset}");
                }
                catch (ProduceException<string, string> e)
                {
                    Console.WriteLine($"failed to deliver message: {e.Message} [{e.Error.Code}]");
                }
            }
        }
    }
}
