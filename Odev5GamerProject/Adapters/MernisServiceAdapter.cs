using Odev5GamerProjectt.Abstract;
using Odev5GamerProjectt.Entity;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5GamerProjectt.Adapters
{
    class MernisServiceAdapter : IUserValidationService
    {
        public object TCKimlikDogrulaAsync { get; private set; }

        public bool Validate(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(gamer.NationalityId), gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), gamer.DateOfBirth))).Result.Body.TCKimlikNoDogrulaResult; 
           

        }

       
    }
}
