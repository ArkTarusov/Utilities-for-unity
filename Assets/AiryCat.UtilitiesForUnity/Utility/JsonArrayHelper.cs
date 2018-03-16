﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace AiryCat.UtilitiesForUnity.Utility
{
    public static class JsonArrayHelper
    {
        public static IList<T> FromJson<T>(string json)
        {
            var wrapper = JsonUtility.FromJson<Wrapper<T>>(json);
            return wrapper.Items;
        }

        public static string ToJson<T>(IList<T> array)
        {
            var wrapper = new Wrapper<T> {Items = array};
            return JsonUtility.ToJson(wrapper);
        }

        public static string ToJson<T>(IList<T> array, bool prettyPrint)
        {
            var wrapper = new Wrapper<T> {Items = array};
            return JsonUtility.ToJson(wrapper, prettyPrint);
        }

        [Serializable]
        private class Wrapper<T>
        {
            public IList<T> Items;
        }
    }
}