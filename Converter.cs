using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HTMLBlockGenerator
{
    public class Converter
    {
        
        public string[] Convert(string[] _values, string[] _template)
        {
            List<string> values = _values.ToList();
            List<string> template = _template.ToList();
            List<string> output = new List<string>();

            var variables = values[0].Split(';');
            values = values.Where(s => !string.IsNullOrWhiteSpace(s)).Distinct().ToList();
            List<string> generatedBlock = new List<string>();
            foreach (var item in values.Skip(1))
            {
                generatedBlock.Clear();
                generatedBlock.AddRange(template);
                var data  = item.Split(';');
                for(int i = 0; i < template.Count; i++)
                {
                    for (int d = 0; d < variables.Length; d++) {
                        generatedBlock[i] = generatedBlock[i].Replace(variables[d], data[d] );
                       }
                }
                output.AddRange(generatedBlock);
            }
            return output.ToArray();
        }

    }
}
