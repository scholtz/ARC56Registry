using System;
using Algorand;
using Algorand.Algod;
using Algorand.Algod.Model;
using Algorand.Algod.Model.Transactions;
using AVM.ClientGenerator;
using AVM.ClientGenerator.Core;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVM.ClientGenerator.ABI.ARC56;
using Algorand.AVM.ClientGenerator.ABI.ARC56;

namespace Arc56.Generated.tasosbit.distributor.Distributor_c742749c
{


    public class DistributorProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public DistributorProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class SendAssetArgDestinations : AVMObjectType
            {
                public Algorand.Address Field0 { get; set; }

                public ulong Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static SendAssetArgDestinations Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new SendAssetArgDestinations();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is Algorand.Address vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as SendAssetArgDestinations);
                }
                public bool Equals(SendAssetArgDestinations? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(SendAssetArgDestinations left, SendAssetArgDestinations right)
                {
                    return EqualityComparer<SendAssetArgDestinations>.Default.Equals(left, right);
                }
                public static bool operator !=(SendAssetArgDestinations left, SendAssetArgDestinations right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        public async Task Optin(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 171, 105, 11, 105 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Optin_Transactions(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 171, 105, 11, 105 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="destinations"> SendAssetArgDestinations</param>
        public async Task SendAsset(Structs.SendAssetArgDestinations[] destinations, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 127, 138, 150, 120 };
            var destinationsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.SendAssetArgDestinations>(x => Structs.SendAssetArgDestinations.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; destinationsAbi.From(destinations);

            var result = await base.CallApp(new List<object> { abiHandle, destinationsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SendAsset_Transactions(Structs.SendAssetArgDestinations[] destinations, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 127, 138, 150, 120 };
            var destinationsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.SendAssetArgDestinations>(x => Structs.SendAssetArgDestinations.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; destinationsAbi.From(destinations);

            return await base.MakeTransactionList(new List<object> { abiHandle, destinationsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Constructor Bare Action
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.CreateApplication)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 193, 250, 21 };

            var result = await base.CallApp(new List<object> { }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.CreateApplication)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 193, 250, 21 };

            return await base.MakeTransactionList(new List<object> { }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRGlzdHJpYnV0b3IiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiU2VuZEFzc2V0QXJnRGVzdGluYXRpb25zIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6Im9wdGluIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNlbmRBc3NldCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIoYWRkcmVzcyx1aW50NjQpW10iLCJzdHJ1Y3QiOiJTZW5kQXNzZXRBcmdEZXN0aW5hdGlvbnMiLCJuYW1lIjoiZGVzdGluYXRpb25zIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTIyXSwiZXJyb3JNZXNzYWdlIjoiRVJSOklOVkFMSURfR1JPVVBfSU5ERVgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTNdLCJlcnJvck1lc3NhZ2UiOiJFUlI6UFJFVl9OT1RfQVBQX0NBTEwiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDZdLCJlcnJvck1lc3NhZ2UiOiJFUlI6UFJFVl9OT1RfQVNTRVRfWEZFUiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5OV0sImVycm9yTWVzc2FnZSI6IkVSUjpQUkVWX05PVF9TRU5EQVNTRVQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDVdLCJlcnJvck1lc3NhZ2UiOiJFUlI6VU5ERVJTUEVORCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM3XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY1XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCAmJiBjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDAsMjU0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg1XSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggYWNjZXNzIGlzIG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudHVwbGU8YWNjb3VudCx1aW50NjQ+PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjc1XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBhcHBsIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM2LDE1Ml0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgYXhmZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRFFnTkRBS0lDQWdJR0o1ZEdWallteHZZMnNnSW1GdGIzVnVkQ0lnTUhnM1pqaGhPVFkzT0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM1J5YVdKMWRHOXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNakVLSUNBZ0lDOHZJR0Z0YjNWdWRDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJQ2RoYlc5MWJuUW5MQ0JwYm1sMGFXRnNWbUZzZFdVNklEQWdmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUZ0YjNWdWRDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6ZEhKcFluVjBiM0l2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TUFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFUnBjM1J5YVdKMWRHOXlJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURFeENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHMTFjM1FnWW1VZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFlXSTJPVEJpTmprZ0x5OGdiV1YwYUc5a0lDSnZjSFJwYmloMWFXNTBOalFwZG05cFpDSUtJQ0FnSUdKNWRHVmpYekVnTHk4Z2JXVjBhRzlrSUNKelpXNWtRWE56WlhRb0tHRmtaSEpsYzNNc2RXbHVkRFkwS1Z0ZEtYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdmNIUnBiaUJ6Wlc1a1FYTnpaWFFLSUNBZ0lHVnljZ29LYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU1URTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpkSEpwWW5WMGIzSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVScGMzUnlhV0oxZEc5eUlHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHMTFjM1FnWW1VZ1RtOVBjQ0FtSmlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z1kzSmxZWFJwYm1jS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6ZEhKcFluVjBiM0l2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UkdsemRISnBZblYwYjNJdWIzQjBhVzViY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwdmNIUnBiam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE4wY21saWRYUnZjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl6Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdiM0IwYVc0b1lYTnpaWFE2SUVGemMyVjBLU0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBNElDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpkSEpwWW5WMGIzSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOQzB6TUFvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVZWE56WlhSVWNtRnVjMlpsY2loN0NpQWdJQ0F2THlBZ0lDQWdlR1psY2tGemMyVjBPaUJoYzNObGRDNXBaQ3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRkpsWTJWcGRtVnlPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRFRnRiM1Z1ZERvZ01Dd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lDOHZJQ0FnTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpkSEpwWW5WMGIzSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOd29nSUNBZ0x5OGdZWE56WlhSU1pXTmxhWFpsY2pvZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zQ2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNSeWFXSjFkRzl5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpnS0lDQWdJQzh2SUdGemMyVjBRVzF2ZFc1ME9pQXdMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJCYlc5MWJuUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJTWldObGFYWmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQllabVZ5UVhOelpYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTjBjbWxpZFhSdmNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTBMVEk1Q2lBZ0lDQXZMeUJwZEhodUNpQWdJQ0F2THlBZ0lDNWhjM05sZEZSeVlXNXpabVZ5S0hzS0lDQWdJQzh2SUNBZ0lDQjRabVZ5UVhOelpYUTZJR0Z6YzJWMExtbGtMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBVbVZqWldsMlpYSTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFFXMXZkVzUwT2lBd0xBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ2FXNTBZMTh5SUM4dklEUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNSeWFXSjFkRzl5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpRdE16QUtJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG1GemMyVjBWSEpoYm5ObVpYSW9ld29nSUNBZ0x5OGdJQ0FnSUhobVpYSkJjM05sZERvZ1lYTnpaWFF1YVdRc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSU1pXTmxhWFpsY2pvZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJCYlc5MWJuUTZJREFzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0F2THlBZ0lDNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOMGNtbGlkWFJ2Y2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJekNpQWdJQ0F2THlCd2RXSnNhV01nYjNCMGFXNG9ZWE56WlhRNklFRnpjMlYwS1NCN0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNSeWFXSjFkRzl5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tScGMzUnlhV0oxZEc5eUxuTmxibVJCYzNObGRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5sYm1SQmMzTmxkRG9LSUNBZ0lIQjFjMmhpZVhSbGN5QWlJZ29nSUNBZ1pIVndiaUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6ZEhKcFluVjBiM0l2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TXdvZ0lDQWdMeThnY0hWaWJHbGpJSE5sYm1SQmMzTmxkQ2hrWlhOMGFXNWhkR2x2Ym5NNklFUmxjM1JwYm1GMGFXOXVXMTBwSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0c0Z01nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdhVzUwWTE4eklDOHZJRFF3Q2lBZ0lDQXFDaUFnSUNCd2RYTm9hVzUwSURJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnYzNkaGNBb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTBkWEJzWlR4aFkyTnZkVzUwTEhWcGJuUTJORDQrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6ZEhKcFluVjBiM0l2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TkFvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1bmNtOTFjRWx1WkdWNElENGdNQ3dnSjBWU1VqcEpUbFpCVEVsRVgwZFNUMVZRWDBsT1JFVllKeWtLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQmhjM05sY25RZ0x5OGdSVkpTT2tsT1ZrRk1TVVJmUjFKUFZWQmZTVTVFUlZnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOMGNtbGlkWFJ2Y2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNMkNpQWdJQ0F2THlCcFppQW9WSGh1TG1keWIzVndTVzVrWlhnZ1BUMDlJREVwSUhzS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHSjZJSE5sYm1SQmMzTmxkRjlsYkhObFgySnZaSGxBTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNSeWFXSjFkRzl5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpjS0lDQWdJQzh2SUdkMGVHNHVRWE56WlhSVWNtRnVjMlpsY2xSNGJpZ3dLU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYeklnTHk4Z1lYaG1aWElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QmhlR1psY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNSeWFXSjFkRzl5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmprS0lDQWdJQzh2SUhSNWNHVTZJRlJ5WVc1ellXTjBhVzl1Vkhsd1pTNUJjM05sZEZSeVlXNXpabVZ5TEFvZ0lDQWdhVzUwWTE4eUlDOHZJRFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE4wY21saWRYUnZjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalkyTFRjekNpQWdJQ0F2THlCaGMzTmxjblJOWVhSamFDZ0tJQ0FnSUM4dklDQWdaM1I0Ymk1QmMzTmxkRlJ5WVc1elptVnlWSGh1S0RBcExBb2dJQ0FnTHk4Z0lDQjdDaUFnSUNBdkx5QWdJQ0FnZEhsd1pUb2dWSEpoYm5OaFkzUnBiMjVVZVhCbExrRnpjMlYwVkhKaGJuTm1aWElzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJTWldObGFYWmxjam9nUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJSDBzQ2lBZ0lDQXZMeUFnSUNkRlVsSTZVRkpGVmw5T1QxUmZRVk5UUlZSZldFWkZVaWNzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQTlQUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM1J5YVdKMWRHOXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOamNLSUNBZ0lDOHZJR2QwZUc0dVFYTnpaWFJVY21GdWMyWmxjbFI0Ymlnd0tTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemRISnBZblYwYjNJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk5pMDNNd29nSUNBZ0x5OGdZWE56WlhKMFRXRjBZMmdvQ2lBZ0lDQXZMeUFnSUdkMGVHNHVRWE56WlhSVWNtRnVjMlpsY2xSNGJpZ3dLU3dLSUNBZ0lDOHZJQ0FnZXdvZ0lDQWdMeThnSUNBZ0lIUjVjR1U2SUZSeVlXNXpZV04wYVc5dVZIbHdaUzVCYzNObGRGUnlZVzV6Wm1WeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFVtVmpaV2wyWlhJNklFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TEFvZ0lDQWdMeThnSUNCOUxBb2dJQ0FnTHk4Z0lDQW5SVkpTT2xCU1JWWmZUazlVWDBGVFUwVlVYMWhHUlZJbkxBb2dJQ0FnTHk4Z0tRb2dJQ0FnWjNSNGJuTWdRWE56WlhSU1pXTmxhWFpsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNSeWFXSjFkRzl5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpBS0lDQWdJQzh2SUdGemMyVjBVbVZqWldsMlpYSTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTjBjbWxpZFhSdmNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTJMVGN6Q2lBZ0lDQXZMeUJoYzNObGNuUk5ZWFJqYUNnS0lDQWdJQzh2SUNBZ1ozUjRiaTVCYzNObGRGUnlZVzV6Wm1WeVZIaHVLREFwTEFvZ0lDQWdMeThnSUNCN0NpQWdJQ0F2THlBZ0lDQWdkSGx3WlRvZ1ZISmhibk5oWTNScGIyNVVlWEJsTGtGemMyVjBWSEpoYm5ObVpYSXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUlNaV05sYVhabGNqb2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lIMHNDaUFnSUNBdkx5QWdJQ2RGVWxJNlVGSkZWbDlPVDFSZlFWTlRSVlJmV0VaRlVpY3NDaUFnSUNBdkx5QXBDaUFnSUNBOVBRb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRDQXZMeUJGVWxJNlVGSkZWbDlPVDFSZlFWTlRSVlJmV0VaRlVnb0tjMlZ1WkVGemMyVjBYMkZtZEdWeVgybG1YMlZzYzJWQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTjBjbWxpZFhSdmNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXlDaUFnSUNBdkx5QmpiMjV6ZENCaGMzTmxkQ0E5SUdkMGVHNHVRWE56WlhSVWNtRnVjMlpsY2xSNGJpZ3dLUzU0Wm1WeVFYTnpaWFFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh5SUM4dklHRjRabVZ5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlZVzV6WVdOMGFXOXVJSFI1Y0dVZ2FYTWdZWGhtWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm5kSGh1Y3lCWVptVnlRWE56WlhRS0lDQWdJR0oxY25rZ05Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzUnlhV0oxZEc5eUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5ETUtJQ0FnSUM4dklHeGxkQ0IwYjNSaGJFRnRiM1Z1ZERvZ2RXbHVkRFkwSUQwZ01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0oxY25rZ013b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0oxY25rZ05Bb0tjMlZ1WkVGemMyVjBYMlp2Y2w5b1pXRmtaWEpBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOMGNtbGlkWFJ2Y2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRMENpQWdJQ0F2THlCbWIzSWdLR052Ym5OMElGdGhZMk52ZFc1MExDQmhiVzkxYm5SZElHOW1JR1JsYzNScGJtRjBhVzl1Y3lCaGN5QlNaV0ZrYjI1c2VUeEVaWE4wYVc1aGRHbHZibHRkUGlrZ2V3b2dJQ0FnWkdsbklETUtJQ0FnSUdScFp5QXhDaUFnSUNBOENpQWdJQ0JpZWlCelpXNWtRWE56WlhSZllXWjBaWEpmWm05eVFEa0tJQ0FnSUdScFp5QXhDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWkdsbklEUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh6SUM4dklEUXdDaUFnSUNBcUNpQWdJQ0JwYm5Salh6TWdMeThnTkRBS0lDQWdJR1Y0ZEhKaFkzUXpJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJREFnTXpJS0lDQWdJSE4zWVhBS0lDQWdJSEIxYzJocGJuUWdNeklnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpkSEpwWW5WMGIzSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBOUzAxTVFvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVZWE56WlhSVWNtRnVjMlpsY2loN0NpQWdJQ0F2THlBZ0lDQWdlR1psY2tGemMyVjBPaUJoYzNObGRDNXBaQ3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRkpsWTJWcGRtVnlPaUJoWTJOdmRXNTBMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBRVzF2ZFc1ME9pQmhiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNBdkx5QWdJQzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnWkhWd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBRVzF2ZFc1MENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBVbVZqWldsMlpYSUtJQ0FnSUdScFp5QTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGaG1aWEpCYzNObGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzUnlhV0oxZEc5eUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EVXROVEFLSUNBZ0lDOHZJR2wwZUc0S0lDQWdJQzh2SUNBZ0xtRnpjMlYwVkhKaGJuTm1aWElvZXdvZ0lDQWdMeThnSUNBZ0lIaG1aWEpCYzNObGREb2dZWE56WlhRdWFXUXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUlNaV05sYVhabGNqb2dZV05qYjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRFRnRiM1Z1ZERvZ1lXMXZkVzUwTEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnYVc1MFkxOHlJQzh2SURRS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM1J5YVdKMWRHOXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORFV0TlRFS0lDQWdJQzh2SUdsMGVHNEtJQ0FnSUM4dklDQWdMbUZ6YzJWMFZISmhibk5tWlhJb2V3b2dJQ0FnTHk4Z0lDQWdJSGhtWlhKQmMzTmxkRG9nWVhOelpYUXVhV1FzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJTWldObGFYWmxjam9nWVdOamIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRUZ0YjNWdWREb2dZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ0x5OGdJQ0F1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpkSEpwWW5WMGIzSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFNZ29nSUNBZ0x5OGdkRzkwWVd4QmJXOTFiblFnS3owZ1lXMXZkVzUwQ2lBZ0lDQmthV2NnTkFvZ0lDQWdLd29nSUNBZ1luVnllU0EwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5WeWVTQTBDaUFnSUNCaUlITmxibVJCYzNObGRGOW1iM0pmYUdWaFpHVnlRRFVLQ25ObGJtUkJjM05sZEY5aFpuUmxjbDltYjNKQU9Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTjBjbWxpZFhSdmNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTFDaUFnSUNBdkx5QnBaaUFvVkhodUxtZHliM1Z3U1c1a1pYZ2dQVDA5SUVkc2IySmhiQzVuY205MWNGTnBlbVVnTFNBeEtTQjdDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1oyeHZZbUZzSUVkeWIzVndVMmw2WlFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDMEtJQ0FnSUQwOUNpQWdJQ0JpZWlCelpXNWtRWE56WlhSZlpXeHpaVjlpYjJSNVFERXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpkSEpwWW5WMGIzSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFOZ29nSUNBZ0x5OGdZMjl1YzNRZ2FXNXBkR2xoYkVGdGIzVnVkQ0E5SUdkMGVHNHVRWE56WlhSVWNtRnVjMlpsY2xSNGJpZ3dLUzVoYzNObGRFRnRiM1Z1ZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHZDBlRzV6SUVGemMyVjBRVzF2ZFc1MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemRISnBZblYwYjNJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU53b2dJQ0FnTHk4Z1kyOXVjM1FnZEc5MFlXeFRaVzUwT2lCMWFXNTBOalFnUFNCMGIzUmhiRUZ0YjNWdWRDQXJJSFJvYVhNdVlXMXZkVzUwTG5aaGJIVmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzUnlhV0oxZEc5eUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qRUtJQ0FnSUM4dklHRnRiM1Z1ZENBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJyWlhrNklDZGhiVzkxYm5RbkxDQnBibWwwYVdGc1ZtRnNkV1U2SURBZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltRnRiM1Z1ZENJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOMGNtbGlkWFJ2Y2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVM0NpQWdJQ0F2THlCamIyNXpkQ0IwYjNSaGJGTmxiblE2SUhWcGJuUTJOQ0E5SUhSdmRHRnNRVzF2ZFc1MElDc2dkR2hwY3k1aGJXOTFiblF1ZG1Gc2RXVUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0JrYVdjZ05Bb2dJQ0FnS3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNSeWFXSjFkRzl5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRnS0lDQWdJQzh2SUdGemMyVnlkQ2hwYm1sMGFXRnNRVzF2ZFc1MElEMDlQU0IwYjNSaGJGTmxiblFzSUNkRlVsSTZWVTVFUlZKVFVFVk9SQ2NwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFVlNVanBWVGtSRlVsTlFSVTVFQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6ZEhKcFluVjBiM0l2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TVFvZ0lDQWdMeThnWVcxdmRXNTBJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHdGxlVG9nSjJGdGIzVnVkQ2NzSUdsdWFYUnBZV3hXWVd4MVpUb2dNQ0I5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWVcxdmRXNTBJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM1J5YVdKMWRHOXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVGtLSUNBZ0lDOHZJSFJvYVhNdVlXMXZkVzUwTG5aaGJIVmxJRDBnTUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2dwelpXNWtRWE56WlhSZllXWjBaWEpmYVdaZlpXeHpaVUF4TWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOMGNtbGlkWFJ2Y2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNekNpQWdJQ0F2THlCd2RXSnNhV01nYzJWdVpFRnpjMlYwS0dSbGMzUnBibUYwYVc5dWN6b2dSR1Z6ZEdsdVlYUnBiMjViWFNrZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tjMlZ1WkVGemMyVjBYMlZzYzJWZlltOWtlVUF4TVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOMGNtbGlkWFJ2Y2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZeENpQWdJQ0F2THlCMGFHbHpMbUZ0YjNWdWRDNTJZV3gxWlNBOUlIUm9hWE11WVcxdmRXNTBMblpoYkhWbElDc2dkRzkwWVd4QmJXOTFiblFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpkSEpwWW5WMGIzSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNUW9nSUNBZ0x5OGdZVzF2ZFc1MElEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUd0bGVUb2dKMkZ0YjNWdWRDY3NJR2x1YVhScFlXeFdZV3gxWlRvZ01DQjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZVzF2ZFc1MElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzUnlhV0oxZEc5eUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qRUtJQ0FnSUM4dklIUm9hWE11WVcxdmRXNTBMblpoYkhWbElEMGdkR2hwY3k1aGJXOTFiblF1ZG1Gc2RXVWdLeUIwYjNSaGJFRnRiM1Z1ZEFvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lHUnBaeUF6Q2lBZ0lDQXJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpkSEpwWW5WMGIzSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNUW9nSUNBZ0x5OGdZVzF2ZFc1MElEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUd0bGVUb2dKMkZ0YjNWdWRDY3NJR2x1YVhScFlXeFdZV3gxWlRvZ01DQjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZVzF2ZFc1MElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzUnlhV0oxZEc5eUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qRUtJQ0FnSUM4dklIUm9hWE11WVcxdmRXNTBMblpoYkhWbElEMGdkR2hwY3k1aGJXOTFiblF1ZG1Gc2RXVWdLeUIwYjNSaGJFRnRiM1Z1ZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0lnYzJWdVpFRnpjMlYwWDJGbWRHVnlYMmxtWDJWc2MyVkFNVElLQ25ObGJtUkJjM05sZEY5bGJITmxYMkp2WkhsQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTjBjbWxpZFhSdmNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzNDaUFnSUNBdkx5QmpiMjV6ZENCMGVHNGdQU0JuZEhodUxrRndjR3hwWTJGMGFXOXVRMkZzYkZSNGJpaFVlRzR1WjNKdmRYQkpibVJsZUNBdElERXBDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQTJJQzh2SUdGd2NHd0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCaGNIQnNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpkSEpwWW5WMGIzSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzRNUW9nSUNBZ0x5OGdkSGx3WlRvZ1ZISmhibk5oWTNScGIyNVVlWEJsTGtGd2NHeHBZMkYwYVc5dVEyRnNiQ3dLSUNBZ0lIQjFjMmhwYm5RZ05pQXZMeUEyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6ZEhKcFluVjBiM0l2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zT0MwNE5nb2dJQ0FnTHk4Z1lYTnpaWEowVFdGMFkyZ29DaUFnSUNBdkx5QWdJSFI0Yml3S0lDQWdJQzh2SUNBZ2V3b2dJQ0FnTHk4Z0lDQWdJSFI1Y0dVNklGUnlZVzV6WVdOMGFXOXVWSGx3WlM1QmNIQnNhV05oZEdsdmJrTmhiR3dzQ2lBZ0lDQXZMeUFnSUNBZ1lYQndTV1E2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVKWkN3S0lDQWdJQzh2SUNBZ0lDQnZia052YlhCc1pYUnBiMjQ2SUU5dVEyOXRjR3hsZEdWQlkzUnBiMjR1VG05UGNDd0tJQ0FnSUM4dklDQWdmU3dLSUNBZ0lDOHZJQ0FnSjBWU1VqcFFVa1ZXWDA1UFZGOUJVRkJmUTBGTVRDY3NDaUFnSUNBdkx5QXBDaUFnSUNBOVBRb2dJQ0FnWkdsbklERUtJQ0FnSUdkMGVHNXpJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOMGNtbGlkWFJ2Y2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pneUNpQWdJQ0F2THlCaGNIQkpaRG9nUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia2xrTEFvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpkSEpwWW5WMGIzSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNPQzA0TmdvZ0lDQWdMeThnWVhOelpYSjBUV0YwWTJnb0NpQWdJQ0F2THlBZ0lIUjRiaXdLSUNBZ0lDOHZJQ0FnZXdvZ0lDQWdMeThnSUNBZ0lIUjVjR1U2SUZSeVlXNXpZV04wYVc5dVZIbHdaUzVCY0hCc2FXTmhkR2x2YmtOaGJHd3NDaUFnSUNBdkx5QWdJQ0FnWVhCd1NXUTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUpaQ3dLSUNBZ0lDOHZJQ0FnSUNCdmJrTnZiWEJzWlhScGIyNDZJRTl1UTI5dGNHeGxkR1ZCWTNScGIyNHVUbTlQY0N3S0lDQWdJQzh2SUNBZ2ZTd0tJQ0FnSUM4dklDQWdKMFZTVWpwUVVrVldYMDVQVkY5QlVGQmZRMEZNVENjc0NpQWdJQ0F2THlBcENpQWdJQ0E5UFFvZ0lDQWdKaVlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQm5kSGh1Y3lCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJQ1ltQ2lBZ0lDQmhjM05sY25RZ0x5OGdSVkpTT2xCU1JWWmZUazlVWDBGUVVGOURRVXhNQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6ZEhKcFluVjBiM0l2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80TndvZ0lDQWdMeThnWVhOelpYSjBLSFI0Ymk1aGNIQkJjbWR6S0RBcElEMDlQU0J0WlhSb2IyUlRaV3hsWTNSdmNpZ25jMlZ1WkVGemMyVjBLQ2hoWkdSeVpYTnpMSFZwYm5RMk5DbGJYU2wyYjJsa0p5a3NJQ2RGVWxJNlVGSkZWbDlPVDFSZlUwVk9SRUZUVTBWVUp5a0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JuZEhodWMyRnpJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnWW5sMFpXTmZNU0F2THlCdFpYUm9iMlFnSW5ObGJtUkJjM05sZENnb1lXUmtjbVZ6Y3l4MWFXNTBOalFwVzEwcGRtOXBaQ0lLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1JWSlNPbEJTUlZaZlRrOVVYMU5GVGtSQlUxTkZWQW9nSUNBZ1lpQnpaVzVrUVhOelpYUmZZV1owWlhKZmFXWmZaV3h6WlVBMENnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQUVFS0NZQ0JtRnRiM1Z1ZEFSL2lwWjRNUmhBQUFNb0ltY3hHMEVBR0RFWkZFUXhHRVNBQkt0cEMya3BOaG9BamdJQUN3QW9BREVaRkRFWUZCQkVJME0yR2dGSkZZRUlFa1FYc1RJS0lySVNzaFN5RVNTeUVDS3lBYk1qUTRBQVJ3STJHZ0ZIQWlKWlNVNENKUXVCQWdoTUZSSkVNUlpFTVJZakVrRUFoaUk0RUVra0VrUWtFaUk0RkRJS0VoQkVJamdRSkJKRUlqZ1JSUVVpUlFNaVJRUkxBMHNCREVFQU5Fc0JWd0lBU3dSSlRnSWxDeVZZU1ZjQUlFeUJJRnV4U2JJU1RMSVVTd2F5RVNTeUVDS3lBYk5MQkFoRkJDTUlSUVJDLzhReEZqSUVJd2tTUVFBUklqZ1NJaWhsUkVzRUNCSkVLQ0puSTBNaUtHVkVTd01JS0V4blF2L3hNUllqQ1VrNEVFbUJCaEpFZ1FZU1N3RTRHRElJRWhCTEFUZ1pGQkJFSXNJYUtSSkVRdjlrIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MywicGF0Y2giOjIsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
