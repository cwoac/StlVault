﻿using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace StlVault.Services
{
    internal interface IPreviewBuilder
    {
        Task<byte[]> GetPreviewImageDataAsync(Mesh mesh, Vector3? objRotation);
    }
}