using Duende.IdentityServer.Models;

namespace IdentityServer.Api.Config
{
    /*Этот класс определяет, какие клиенты могут подключаться к нашему IdentityServer 
     * и как именно они будут аутентифицироваться. В IdentityServer клиент — 
     * это приложение, которое будет запрашивать токены у IdentityServer, 
     * чтобы получить доступ к защищённым ресурсам (например, API).
     */
    public static class Clients
    {
        public static IEnumerable<Client> Get =>
            new[] {
                new Client
                {
                    ClientId = "client", // Идентификатор клиента, используемый для его идентификации
                    AllowedGrantTypes = GrantTypes.ClientCredentials, // Тип гранта, который клиент может использовать
                    ClientSecrets = { new Secret("secret".Sha256()) }, // Секрет клиента, который будет использоваться для аутентификации
                    AllowedScopes = { "api1" } // Список областей доступа, которые этот клиент может запрашивать
                }
            };
    }
}
