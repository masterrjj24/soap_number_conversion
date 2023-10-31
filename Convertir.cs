namespace EjemploWS.CSD
{
    public class Convertir
    {
        public async Task<string> Numero2Letras(ulong Numero)
        {
            string ls_words;

            //Declare an enum value. [First value start in ZERO]
            ConversionNumerica.NumberConversionSoapTypeClient.EndpointConfiguration li_endpoint_choice = ConversionNumerica.NumberConversionSoapTypeClient.EndpointConfiguration.NumberConversionSoap; // Cero value

            // Instanciamos un objeto indicando cual url remota solicitar
            ConversionNumerica.NumberConversionSoapTypeClient oConvNum = new(li_endpoint_choice);

            // call remote soap service
            var remoteResponse = await oConvNum.NumberToWordsAsync(Numero); // retorna NumberToWordsResponse

            // From remoteResponse get Body.NumberToWordsResult
            ls_words = remoteResponse.Body.NumberToWordsResult;
                        
            return ls_words; // from 10 returns "TEN"
        }
    }
}
