﻿using System.IO;
using BuildNotification.Runtime.Authorization;
using UnityEngine;

namespace BuildNotification.Runtime
{
    public static class PathService
    {
        public static string ServiceInfoDataPath { get; }
        public const string JsonExtension = "json";
        public const string JsonExtensionWithDot = ".json";
        public const string JsonFileType = "application/json";

        static PathService()
        {
            ServiceInfoDataPath = Path.Combine(Application.persistentDataPath,
                $"{nameof(ServiceInfoData)}{JsonExtensionWithDot}");
        }
    }
}