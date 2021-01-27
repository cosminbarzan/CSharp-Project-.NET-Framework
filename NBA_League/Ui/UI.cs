using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NBA_League.Model.Validator;
using NBA_League.Service;
using NBA_League.Model;

namespace NBA_League.Ui
{
    class UI
    {
        private ServiceEchipa serviceEchipa;
        private ServiceJucator serviceJucator;
        private ServiceMeci serviceMeci;
        private ServiceJucatorActiv serviceJucatorActiv;

        public UI(ServiceEchipa serviceEchipa, ServiceJucator serviceJucator, ServiceMeci serviceMeci, ServiceJucatorActiv serviceJucatorActiv)
        {
            this.serviceEchipa = serviceEchipa;
            this.serviceJucator = serviceJucator;
            this.serviceMeci = serviceMeci;
            this.serviceJucatorActiv = serviceJucatorActiv;
        }

        public void JucatoriEchipe()
        {
            Console.Write("Introduceti id-ul echipei: ");

            String id = Console.ReadLine();
            if(serviceEchipa.FindOne(id) == null)
            {
                Console.WriteLine("Echipa inexistenta!");
            }
            else
            {
                var jucatori = serviceJucator.JucatoriEchipe(serviceJucator.FindAll(), id);

                Console.WriteLine();

                foreach(Jucator jucator in jucatori)
                    Console.WriteLine(jucator);
            }
        }

        public void JucatoriActivi()
        {
            Console.Write("Introduceti id-ul echipei: ");
            String idEchipa = Console.ReadLine();

            Console.Write("Introduceti id-ul meciului: ");
            String idMeci = Console.ReadLine();

            if(serviceEchipa.FindOne(idEchipa) == null || serviceMeci.FindOne(idMeci) == null)
                Console.WriteLine("Echipa sau meci inexistent!");
            else
            {
                var jucatoriActivi = serviceJucatorActiv.JucatoriActivi(idEchipa, idMeci, serviceJucator);

                if(jucatoriActivi.Count() == 0)
                    Console.WriteLine("Echipa nu a jucat in acest meci!");
                else
                {
                    Console.WriteLine();

                    foreach (JucatorActiv jucatorActiv in jucatoriActivi)
                    {
                        Console.WriteLine($"{serviceJucator.FindOne(jucatorActiv.ID.Item1).Nume} | {jucatorActiv.ID.Item2} | Puncte {jucatorActiv.NrPuncte} | {jucatorActiv.Tip}");
                    }
                }
            }
        }

        public void MeciuriPerioada()
        {
            Console.Write("Introduceti data de inceput(zi/luna/an): ");
            DateTime dataInceput = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Introduceti data de sfarsit(zi/luna/an): ");
            DateTime dataSfarsit = Convert.ToDateTime(Console.ReadLine());

            var meciuri = serviceMeci.MeciuriPerioada(dataInceput, dataSfarsit);

            if (meciuri.Count() == 0)
                Console.WriteLine("Nu s-au jucat meciuri in aceasta perioada!");
            else
            {
                Console.WriteLine();

                foreach (Meci meci in meciuri)
                {
                    Console.WriteLine($"{meci.ID} | {serviceEchipa.FindOne(meci.IdEchipa1).Nume} - {serviceEchipa.FindOne(meci.IdEchipa2).Nume} | {meci.Data.ToString("d/M/yyyy", System.Globalization.CultureInfo.InvariantCulture)}");
                }
            }         
        }

        public void ScorMeci()
        {
            Console.Write("Introduceti id-ul meciului: ");

            String idMeci = Console.ReadLine();
            Meci meci = serviceMeci.FindOne(idMeci);

            if(meci == null)
                Console.WriteLine("Meci inexistent!");
            else
            {
                Tuple<int, int> scor;
                scor = serviceJucatorActiv.ScorMeci(meci, serviceJucator);

                Console.WriteLine();

                Console.WriteLine(serviceEchipa.FindOne(meci.IdEchipa1).Nume + " - " + serviceEchipa.FindOne(meci.IdEchipa2).Nume + " : " + scor.Item1 + " - " + scor.Item2);
            }
        }

        public void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("0 - Exit");
            Console.WriteLine("1 - Jucatorii unei echipe");
            Console.WriteLine("2 - Jucatorii activi ai unei echipe de la un meci");
            Console.WriteLine("3 - Meciurile dintr-o perioada");
            Console.WriteLine("4 - Scorul unui meci");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();
            Console.Write("Introduceti o comanda: ");
        }


        public void Run()
        {
            while (true)
            {
                PrintMenu();
                try
                {
                    int cmd = Convert.ToInt32(Console.ReadLine());

                    switch (cmd)
                    {
                        case 0:
                            return;
                        case 1:
                            JucatoriEchipe();
                            break;
                        case 2:
                            JucatoriActivi();
                            break;
                        case 3:
                            MeciuriPerioada();
                            break;
                        case 4:
                            ScorMeci();
                            break;
                    }
                }
                catch(ValidationException ve)
                {
                    Console.WriteLine(ve);
                }
                catch(FormatException fe)
                {
                    Console.WriteLine("Data invalida! Introduceti data in formatul specificat!");
                }
            }
        }
    }
}
