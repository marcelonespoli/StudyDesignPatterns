using AdapterSolution2.Adapter;
using AdapterSolution2.ManufacturerApi;
using System;

namespace AdapterSolution2
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmlConverter = new XmlConverter();

            var adapter = new XmlToJsonAdapter(xmlConverter);
            adapter.ConvertXmlToJson();
        }
    }
}
