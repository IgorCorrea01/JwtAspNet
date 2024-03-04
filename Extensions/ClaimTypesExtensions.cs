using System.Security.Claims;

namespace JwtAspNet.Extensions
{
    public static class ClaimTypesExtensions
    {
        public static int Id(this ClaimsPrincipal user)
        {
            try
            {
                var id = user.Claims.FirstOrDefault(x => x.Type == "id").Value;
                return int.Parse(id);
            }
            catch
            {
                return 0;
            }
        }

        public static string Name(this ClaimsPrincipal user)
        {
            try
            {
                var name = user.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name).Value;
                return name;
            }
            catch
            {
                return string.Empty;
            }
        }

        public static string Email(this ClaimsPrincipal user)
        {
            try
            {
                var email = user.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Email).Value;
                return email;
            }
            catch
            {
                return string.Empty;
            }
        }

        public static string GivenName(this ClaimsPrincipal user)
        {
            try
            {
                var givenName = user.Claims.FirstOrDefault(x => x.Type == ClaimTypes.GivenName).Value;
                return givenName;
            }
            catch
            {
                return string.Empty;
            }
        }

        public static string Image(this ClaimsPrincipal user)
        {
            try
            {
                var image = user.Claims.FirstOrDefault(x => x.Type == "image").Value;
                return image;
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
