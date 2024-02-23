﻿namespace PartyInvites.Models
{
    public static class Repository
    {
        private static List<GuestResponse> _response = new ();

        public static IEnumerable<GuestResponse> responses => _response;

        public static void AddResponse(GuestResponse response)
        {
            Console.WriteLine(response);
            _response.Add(response);
        }
    }
}
