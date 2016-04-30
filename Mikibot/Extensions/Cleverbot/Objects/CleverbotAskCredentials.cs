﻿namespace Miki.Extensions.Cleverbot
{
    internal class CleverbotAskCredentials
    {
        public string user;
        public string key;
        public string nick;
        public string text;

        public CleverbotAskCredentials(string _user, string _key, string _nick, string _text)
        {
            user = _user;
            key = _key;
            nick = _nick;
            text = _text;
        }
    }
}