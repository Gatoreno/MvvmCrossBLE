﻿using System;
using System.Collections.Generic;
using Android.Bluetooth;
//using Android.Bluetooth;
 
namespace BLEPractice.Abstractions.Interfaces.BLE_Interfaces
{
    public interface IBLEReciver
    {
        IEnumerable<BluetoothDevice> RegisteredBluetoothDevices();
        public void ScanForUnregisteredDevices();
        public void StopScanForUnregisteredDevices();
    }
}
