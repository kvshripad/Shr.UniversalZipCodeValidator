using Shr.ZipCodeValidator.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CountryValidatorGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = string.Empty;

            using (var reader = new StreamReader("postalCodeCSVData.csv"))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    try
                    {
                        var data = line.Split(new List<string> { "\",\"" }.ToArray(), StringSplitOptions.RemoveEmptyEntries);

                        var countryCode = data[0].Replace("\"", "");
                        var regex = data[1].Replace("\"", "");

                        CreateFile(countryCode, regex);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Exception processing line: {line}");
                        Console.WriteLine($"Error: {ex.Message}");
                        Console.WriteLine($"Continueing with next...............");
                        Console.WriteLine(string.Empty);
                    }
                }
            }

            Console.ReadLine();
        }

        private static void CreateFile(string countryCode, string regex)
        {
            var country = MatchCode(countryCode);

            var strBuilder = new StringBuilder()
                .AppendLine("using Shr.ZipCodeValidator.Common;")
                .AppendLine("using Shr.ZipCodeValidator.ValidatorStrategies; ")
                .AppendLine("using System.Collections.Generic; ")
                .AppendLine()
                .AppendLine("namespace Shr.ZipCodeValidator.CountryValidators")
                .AppendLine("{")
                .AppendFormat($"    internal class {countryCode}ZipCodeValidator : BaseZipCodeValidator")
                .AppendLine()
                .AppendLine("    {")
                .AppendFormat($"        public {countryCode}ZipCodeValidator(IValidatorStrategy<List<string>, string> strategy) : base(strategy)")
                .AppendLine()
                .AppendLine("        {")
                .AppendFormat($"            this.Code = CountryCode.{country};")
                .AppendLine()
                .AppendLine("            this.ZipCodePatterns = new List<string>")
                .AppendLine("            {");

            strBuilder.Append($"                @\"^{regex}$\"");

            strBuilder
                .AppendLine()
                .AppendLine("            };")
                .AppendLine("        }")
                .AppendLine("    }")
                .AppendLine("}");

            var filename = string.Format($"{country}ZipCodeValidator.cs");

            try
            {
                using (var writter = new StreamWriter(Path.Combine(@"..\..\CountryValidators\", filename), false))
                {
                    writter.Write(strBuilder.ToString());
                    writter.Close();
                }

                Console.WriteLine($"Created file : {filename}.");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error creating file for {countryCode}. Error: {ex.Message}");
            }
        }

        private static CountryCode MatchCode(string countryCode)
        {
            CountryCode result;
            if(Enum.TryParse(countryCode, out result))
            return result;

            throw new Exception("Country not defined!");
        }
    }
}
