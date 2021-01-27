using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NBA_League.Model;
using NBA_League.Model.Validator;
using NBA_League.Repository;
using NBA_League.Service;
using NBA_League.Ui;

using System.Configuration;

namespace NBA_League
{
    class Program
    {
        static void Main(string[] args)
        {
            String echipeFileName = ConfigurationManager.AppSettings["echipeFileName"];
            String eleviFileName = ConfigurationManager.AppSettings["eleviFileName"];
            String jucatoriFileName = ConfigurationManager.AppSettings["jucatoriFileName"];
            String meciuriFileName = ConfigurationManager.AppSettings["meciuriFileName"];
            String jucatoriActiviFileName = ConfigurationManager.AppSettings["jucatoriActiviFileName"];

            IValidator<Echipa> validatorEchipa = new EchipaValidator();
            IValidator<Elev> validatorElev = new ElevValidator();
            IValidator<Jucator> validatorJucator = new JucatorValidator();
            IValidator<Meci> validatorMeci = new MeciValidator();
            IValidator<JucatorActiv> validatorJucatorActiv = new JucatorActivValidator();

            IRepository<String, Echipa> repoEchipa = new EchipaInFileRepository(validatorEchipa, echipeFileName);
            IRepository<String, Elev> repoElev = new ElevInFileRepository(validatorElev, eleviFileName);
            IRepository<String, Jucator> repoJucator = new JucatorInFileRepository(validatorJucator, jucatoriFileName);
            IRepository<String, Meci> repoMeci = new MeciInFileRepository(validatorMeci, meciuriFileName);
            IRepository<Tuple<String, String>, JucatorActiv> repoJucatorActiv = new JucatorActivInFileRepository(validatorJucatorActiv, jucatoriActiviFileName);

            ServiceEchipa serviceEchipa = new ServiceEchipa(repoEchipa);
            ServiceElev serviceElev = new ServiceElev(repoElev);
            ServiceJucator serviceJucator = new ServiceJucator(repoJucator);
            ServiceMeci serviceMeci = new ServiceMeci(repoMeci);
            ServiceJucatorActiv serviceJucatorActiv = new ServiceJucatorActiv(repoJucatorActiv);

            
            UI Ui = new UI(serviceEchipa, serviceJucator, serviceMeci, serviceJucatorActiv);

            Ui.Run();

            //List<Echipa> echipe = serviceEchipa.FindAll();

            //foreach (Echipa echipa in echipe)
            //    Console.WriteLine(echipa);

            //Console.WriteLine();

            //List<Elev> elevi = serviceElev.FindAll();

            //foreach (Elev elev in elevi)
            //    Console.WriteLine(elev);

            //Console.WriteLine();

            //List<Jucator> jucatori = serviceJucator.FindAll();

            //foreach (Jucator jucator in jucatori)
            //    Console.WriteLine(jucator);

            //Console.WriteLine();

            //List<Meci> meciuri = serviceMeci.FindAll();

            //foreach (Meci meci in meciuri)
            //    Console.WriteLine(meci);

            //Console.WriteLine();

            //List<JucatorActiv> jucatoriA = serviceJucatorActiv.FindAll();

            //foreach (JucatorActiv jucatorActiv in jucatoriA)
            //    Console.WriteLine(jucatorActiv);
        }
    }
}
