using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text.Json;
using Newtonsoft.Json;

namespace jsonDeserialize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            String jsonString = @"{ 'Date': '2019-08-01T00:00:00-07:00',
  'TemperatureCelsius': '25',
  'Summary': 'Hot',
  'DatesAvailable': [
    '2019-08-01T00:00:00-07:00',
    '2019-08-02T00:00:00-07:00'
  ],
  'TemperatureRanges': {
    'Cold': {
      'High': 20,
      'Low': -10
    },
    'Hot': {
      'High': 60,
      'Low': 20
    }
  },
  'SummaryWords': [
    'Cool',
    'Windy',
    'Humid'
  ]
    }";
            Temperatures temp = JsonConvert.DeserializeObject<Temperatures>(jsonString);
            Console.WriteLine(temp.Date);


            for (int i = 0; i < temp.DatesAvailable.Length; i++)
            {
                Console.WriteLine(temp.DatesAvailable[i]);
            }



            for (int j = 0; j < temp.SummaryWords.Length; j++)
            {
                Console.WriteLine(temp.SummaryWords[j]);
            }


            Console.WriteLine(temp.TemperatureRanges.Cold.High);

        }
    }


}
