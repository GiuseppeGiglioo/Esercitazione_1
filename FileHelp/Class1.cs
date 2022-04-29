using System;
using System.IO;

namespace FileHelp



{
    public class FileHelp
    {
         private readonly Path;
            public FileHelp(string path)
        {
            Path = path;
        }

        public void AddValues (EmpityCatalog RiempC)
        {
            var result = $"{ RiempC.IDprod};{ RiempC.NameProdotto}; {RiempC.Quantità}";

            using (var stream = new StreamWriter( Path, true))
            {
               stream.WriteLine(result);
            }
        }
        public void ReadAllvalues()
        {
            var value = new List<EmpityCatalog>();

            using(var stream = new StreamReader(Path))
            {
                var header = "IDprod; NameProdotto; Quantità";
                var PrimaRiga = stream.ReadLine();
                if (!PrimaRiga.Equals(header))
                    throw new Exception("File non consono al Catalogo")

                 while(!stream.EndOfStream)
                {
                    var row= stream.ReadLine();
                    var spiltt = row.Split(";");


                    var RiempC = new EmpityCatalog
                    {
                        IDprod = spiltt[0],
                        NameProdotto = spiltt[1], 
                         Quantità = spiltt[2]

                    };
                    value.Add(RiempC);
                }
            }
        }

    }
} 