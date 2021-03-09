using System.Collections.Generic;

namespace PartyInvites.Models
{
    public static class Repository  //holds GuestResponse objects
    {
        private static List<GuestResponse> responses = new List<GuestResponse>();
                //responses is a filed (becaue it has = new)
                //static: means its a class field caled through its class
        public static IEnumerable<GuestResponse> Responses => responses;
                //Responses is a class property  (=> is an implementation)
                //responses is a private field
        public static void AddResponse(GuestResponse response)
        {
            responses.Add(response);
        }
    }
}
