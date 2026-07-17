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

namespace Arc56.Generated.algorandfoundation.puya_ts.Arc4BoolAlgo_b1bffa27
{


    public class Arc4BoolAlgoProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public Arc4BoolAlgoProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Object7D615236 : AVMObjectType
            {
                public bool Exists { get; set; }

                public bool Expired { get; set; }

                public bool HasCooldown { get; set; }

                public bool OnCooldown { get; set; }

                public bool HasMethodRestrictions { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExists = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vExists.From(Exists);
                    ret.AddRange(vExists.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpired = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vExpired.From(Expired);
                    ret.AddRange(vExpired.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHasCooldown = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vHasCooldown.From(HasCooldown);
                    ret.AddRange(vHasCooldown.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOnCooldown = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vOnCooldown.From(OnCooldown);
                    ret.AddRange(vOnCooldown.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHasMethodRestrictions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vHasMethodRestrictions.From(HasMethodRestrictions);
                    ret.AddRange(vHasMethodRestrictions.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Object7D615236 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Object7D615236();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExists = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vExists.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExists = vExists.ToValue();
                    if (valueExists is bool vExistsValue) { ret.Exists = vExistsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpired = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vExpired.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExpired = vExpired.ToValue();
                    if (valueExpired is bool vExpiredValue) { ret.Expired = vExpiredValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHasCooldown = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vHasCooldown.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueHasCooldown = vHasCooldown.ToValue();
                    if (valueHasCooldown is bool vHasCooldownValue) { ret.HasCooldown = vHasCooldownValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOnCooldown = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vOnCooldown.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOnCooldown = vOnCooldown.ToValue();
                    if (valueOnCooldown is bool vOnCooldownValue) { ret.OnCooldown = vOnCooldownValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHasMethodRestrictions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vHasMethodRestrictions.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueHasMethodRestrictions = vHasMethodRestrictions.ToValue();
                    if (valueHasMethodRestrictions is bool vHasMethodRestrictionsValue) { ret.HasMethodRestrictions = vHasMethodRestrictionsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Object7D615236);
                }
                public bool Equals(Object7D615236? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Object7D615236 left, Object7D615236 right)
                {
                    return EqualityComparer<Object7D615236>.Default.Equals(left, right);
                }
                public static bool operator !=(Object7D615236 left, Object7D615236 right)
                {
                    return !(left == right);
                }

            }

            public class ObjectCb267Ef3 : AVMObjectType
            {
                public bool UseRounds { get; set; }

                public ulong LastValid { get; set; }

                public ulong Cooldown { get; set; }

                public ulong LastCalled { get; set; }

                public bool Exists { get; set; }

                public bool HasMethodRestrictions { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUseRounds = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vUseRounds.From(UseRounds);
                    ret.AddRange(vUseRounds.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastValid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLastValid.From(LastValid);
                    ret.AddRange(vLastValid.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCooldown = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCooldown.From(Cooldown);
                    ret.AddRange(vCooldown.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastCalled = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLastCalled.From(LastCalled);
                    ret.AddRange(vLastCalled.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExists = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vExists.From(Exists);
                    ret.AddRange(vExists.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHasMethodRestrictions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vHasMethodRestrictions.From(HasMethodRestrictions);
                    ret.AddRange(vHasMethodRestrictions.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ObjectCb267Ef3 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ObjectCb267Ef3();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUseRounds = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vUseRounds.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueUseRounds = vUseRounds.ToValue();
                    if (valueUseRounds is bool vUseRoundsValue) { ret.UseRounds = vUseRoundsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastValid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLastValid.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLastValid = vLastValid.ToValue();
                    if (valueLastValid is ulong vLastValidValue) { ret.LastValid = vLastValidValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCooldown = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCooldown.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCooldown = vCooldown.ToValue();
                    if (valueCooldown is ulong vCooldownValue) { ret.Cooldown = vCooldownValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastCalled = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLastCalled.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLastCalled = vLastCalled.ToValue();
                    if (valueLastCalled is ulong vLastCalledValue) { ret.LastCalled = vLastCalledValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExists = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vExists.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExists = vExists.ToValue();
                    if (valueExists is bool vExistsValue) { ret.Exists = vExistsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHasMethodRestrictions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vHasMethodRestrictions.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueHasMethodRestrictions = vHasMethodRestrictions.ToValue();
                    if (valueHasMethodRestrictions is bool vHasMethodRestrictionsValue) { ret.HasMethodRestrictions = vHasMethodRestrictionsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ObjectCb267Ef3);
                }
                public bool Equals(ObjectCb267Ef3? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ObjectCb267Ef3 left, ObjectCb267Ef3 right)
                {
                    return EqualityComparer<ObjectCb267Ef3>.Default.Equals(left, right);
                }
                public static bool operator !=(ObjectCb267Ef3 left, ObjectCb267Ef3 right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="p"> ObjectCB267EF3</param>
        public async Task<Structs.Object7D615236> Test(Structs.ObjectCb267Ef3 p, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 176, 210, 174, 117 };

            var result = await base.CallApp(new List<object> { abiHandle, p }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Object7D615236.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> Test_Transactions(Structs.ObjectCb267Ef3 p, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 176, 210, 174, 117 };

            return await base.MakeTransactionList(new List<object> { abiHandle, p }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXJjNEJvb2xBbGdvIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7Ik9iamVjdDdENjE1MjM2IjpbeyJuYW1lIjoiZXhpc3RzIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJleHBpcmVkIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJoYXNDb29sZG93biIsInR5cGUiOiJib29sIn0seyJuYW1lIjoib25Db29sZG93biIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiaGFzTWV0aG9kUmVzdHJpY3Rpb25zIiwidHlwZSI6ImJvb2wifV0sIk9iamVjdENCMjY3RUYzIjpbeyJuYW1lIjoidXNlUm91bmRzIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJsYXN0VmFsaWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiY29vbGRvd24iLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibGFzdENhbGxlZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJleGlzdHMiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6Imhhc01ldGhvZFJlc3RyaWN0aW9ucyIsInR5cGUiOiJib29sIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InRlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKGJvb2wsdWludDY0LHVpbnQ2NCx1aW50NjQsYm9vbCxib29sKSIsInN0cnVjdCI6Ik9iamVjdENCMjY3RUYzIiwibmFtZSI6InAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGJvb2wsYm9vbCxib29sLGJvb2wsYm9vbCkiLCJzdHJ1Y3QiOiJPYmplY3Q3RDYxNTIzNiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbODZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgT2JqZWN0Q0IyNjdFRjMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRGdLSUNBZ0lHSWdiV0ZwYmw5aWJHOWphMEF3Q2dwdFlXbHVYMkpzYjJOclFEQTZDaUFnSUNCaUlHMWhhVzVmWW14dlkydEFNUW9LYldGcGJsOWliRzlqYTBBeE9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRZbTl2YkM1aGJHZHZMblJ6T2pRS0lDQWdJQzh2SUdOc1lYTnpJRUZ5WXpSQ2IyOXNRV3huYnlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdJVDBLSUNBZ0lHSjZJRzFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURVS0lDQWdJR0lnYldGcGJsOWhZbWxmY205MWRHbHVaMEF5Q2dwdFlXbHVYMkZpYVY5eWIzVjBhVzVuUURJNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMWliMjlzTG1Gc1oyOHVkSE02TkFvZ0lDQWdMeThnWTJ4aGMzTWdRWEpqTkVKdmIyeEJiR2R2SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WWpCa01tRmxOelVnTHk4Z2JXVjBhRzlrSUNKMFpYTjBLQ2hpYjI5c0xIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMR0p2YjJ3c1ltOXZiQ2twS0dKdmIyd3NZbTl2YkN4aWIyOXNMR0p2YjJ3c1ltOXZiQ2tpQ2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZmRHVnpkRjl5YjNWMFpVQXpDaUFnSUNCaUlHMWhhVzVmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUEwQ2dwdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFORG9LSUNBZ0lHSWdiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRFlLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBMk9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRZbTl2YkM1aGJHZHZMblJ6T2pRS0lDQWdJQzh2SUdOc1lYTnpJRUZ5WXpSQ2IyOXNRV3huYnlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJR1Z5Y2dvS2JXRnBibDkwWlhOMFgzSnZkWFJsUURNNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMWliMjlzTG1Gc1oyOHVkSE02TlMweE9Rb2dJQ0FnTHk4Z2RHVnpkQ2g3Q2lBZ0lDQXZMeUFnSUhWelpWSnZkVzVrY3l3S0lDQWdJQzh2SUNBZ2JHRnpkRlpoYkdsa0xBb2dJQ0FnTHk4Z0lDQmpiMjlzWkc5M2Jpd0tJQ0FnSUM4dklDQWdiR0Z6ZEVOaGJHeGxaQ3dLSUNBZ0lDOHZJQ0FnWlhocGMzUnpMQW9nSUNBZ0x5OGdJQ0JvWVhOTlpYUm9iMlJTWlhOMGNtbGpkR2x2Ym5Nc0NpQWdJQ0F2THlCOU9pQjdDaUFnSUNBdkx5QWdJSFZ6WlZKdmRXNWtjem9nWW05dmJHVmhiZ29nSUNBZ0x5OGdJQ0JzWVhOMFZtRnNhV1E2SUhWcGJuUTJOQW9nSUNBZ0x5OGdJQ0JqYjI5c1pHOTNiam9nZFdsdWREWTBDaUFnSUNBdkx5QWdJR3hoYzNSRFlXeHNaV1E2SUhWcGJuUTJOQW9nSUNBZ0x5OGdJQ0JsZUdsemRITTZJR0p2YjJ4bFlXNEtJQ0FnSUM4dklDQWdhR0Z6VFdWMGFHOWtVbVZ6ZEhKcFkzUnBiMjV6T2lCaWIyOXNaV0Z1Q2lBZ0lDQXZMeUI5S1NCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z1RtOVBjQW9nSUNBZ1BUMEtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0lUMEtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUdOaGJHeHpkV0lnZEdWemRBb2dJQ0FnWWlCdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFOQW9LYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU5Ub0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMV0p2YjJ3dVlXeG5ieTUwY3pvMENpQWdJQ0F2THlCamJHRnpjeUJCY21NMFFtOXZiRUZzWjI4Z1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z1RtOVBjQW9nSUNBZ1BUMEtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1BUMEtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUdOaGJHeHpkV0lnWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRZbTl2YkM1aGJHZHZMblJ6T2pwQmNtTTBRbTl2YkVGc1oyOHVkR1Z6ZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuUmxjM1E2Q2lBZ0lDQmlJSFJsYzNSZllteHZZMnRBTUFvS2RHVnpkRjlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0WW05dmJDNWhiR2R2TG5Sek9qVXRNVGtLSUNBZ0lDOHZJSFJsYzNRb2V3b2dJQ0FnTHk4Z0lDQjFjMlZTYjNWdVpITXNDaUFnSUNBdkx5QWdJR3hoYzNSV1lXeHBaQ3dLSUNBZ0lDOHZJQ0FnWTI5dmJHUnZkMjRzQ2lBZ0lDQXZMeUFnSUd4aGMzUkRZV3hzWldRc0NpQWdJQ0F2THlBZ0lHVjRhWE4wY3l3S0lDQWdJQzh2SUNBZ2FHRnpUV1YwYUc5a1VtVnpkSEpwWTNScGIyNXpMQW9nSUNBZ0x5OGdmVG9nZXdvZ0lDQWdMeThnSUNCMWMyVlNiM1Z1WkhNNklHSnZiMnhsWVc0S0lDQWdJQzh2SUNBZ2JHRnpkRlpoYkdsa09pQjFhVzUwTmpRS0lDQWdJQzh2SUNBZ1kyOXZiR1J2ZDI0NklIVnBiblEyTkFvZ0lDQWdMeThnSUNCc1lYTjBRMkZzYkdWa09pQjFhVzUwTmpRS0lDQWdJQzh2SUNBZ1pYaHBjM1J6T2lCaWIyOXNaV0Z1Q2lBZ0lDQXZMeUFnSUdoaGMwMWxkR2h2WkZKbGMzUnlhV04wYVc5dWN6b2dZbTl2YkdWaGJnb2dJQ0FnTHk4Z2ZTa2dld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTWpZS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJRTlpYW1WamRFTkNNalkzUlVZekNpQWdJQ0JqWVd4c2MzVmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFdKdmIyd3VZV3huYnk1MGN6bzZRWEpqTkVKdmIyeEJiR2R2TG5SbGMzUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMUNpQWdJQ0IxYm1OdmRtVnlJREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0WW05dmJDNWhiR2R2TG5Sek9qcEJjbU0wUW05dmJFRnNaMjh1ZEdWemRDaHdPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDblJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFdKdmIyd3VZV3huYnk1MGN6bzZRWEpqTkVKdmIyeEJiR2R2TG5SbGMzUTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzFpYjI5c0xtRnNaMjh1ZEhNNk5TMHhPUW9nSUNBZ0x5OGdkR1Z6ZENoN0NpQWdJQ0F2THlBZ0lIVnpaVkp2ZFc1a2N5d0tJQ0FnSUM4dklDQWdiR0Z6ZEZaaGJHbGtMQW9nSUNBZ0x5OGdJQ0JqYjI5c1pHOTNiaXdLSUNBZ0lDOHZJQ0FnYkdGemRFTmhiR3hsWkN3S0lDQWdJQzh2SUNBZ1pYaHBjM1J6TEFvZ0lDQWdMeThnSUNCb1lYTk5aWFJvYjJSU1pYTjBjbWxqZEdsdmJuTXNDaUFnSUNBdkx5QjlPaUI3Q2lBZ0lDQXZMeUFnSUhWelpWSnZkVzVrY3pvZ1ltOXZiR1ZoYmdvZ0lDQWdMeThnSUNCc1lYTjBWbUZzYVdRNklIVnBiblEyTkFvZ0lDQWdMeThnSUNCamIyOXNaRzkzYmpvZ2RXbHVkRFkwQ2lBZ0lDQXZMeUFnSUd4aGMzUkRZV3hzWldRNklIVnBiblEyTkFvZ0lDQWdMeThnSUNCbGVHbHpkSE02SUdKdmIyeGxZVzRLSUNBZ0lDOHZJQ0FnYUdGelRXVjBhRzlrVW1WemRISnBZM1JwYjI1ek9pQmliMjlzWldGdUNpQWdJQ0F2THlCOUtTQjdDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJSEIxYzJoaWVYUmxjeUFpSWdvZ0lDQWdZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxaWIyOXNMbUZzWjI4dWRITTZPa0Z5WXpSQ2IyOXNRV3huYnk1MFpYTjBYMkpzYjJOclFEQUtDblJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFdKdmIyd3VZV3huYnk1MGN6bzZRWEpqTkVKdmIyeEJiR2R2TG5SbGMzUmZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMV0p2YjJ3dVlXeG5ieTUwY3pvMUxURTVDaUFnSUNBdkx5QjBaWE4wS0hzS0lDQWdJQzh2SUNBZ2RYTmxVbTkxYm1SekxBb2dJQ0FnTHk4Z0lDQnNZWE4wVm1Gc2FXUXNDaUFnSUNBdkx5QWdJR052YjJ4a2IzZHVMQW9nSUNBZ0x5OGdJQ0JzWVhOMFEyRnNiR1ZrTEFvZ0lDQWdMeThnSUNCbGVHbHpkSE1zQ2lBZ0lDQXZMeUFnSUdoaGMwMWxkR2h2WkZKbGMzUnlhV04wYVc5dWN5d0tJQ0FnSUM4dklIMDZJSHNLSUNBZ0lDOHZJQ0FnZFhObFVtOTFibVJ6T2lCaWIyOXNaV0Z1Q2lBZ0lDQXZMeUFnSUd4aGMzUldZV3hwWkRvZ2RXbHVkRFkwQ2lBZ0lDQXZMeUFnSUdOdmIyeGtiM2R1T2lCMWFXNTBOalFLSUNBZ0lDOHZJQ0FnYkdGemRFTmhiR3hsWkRvZ2RXbHVkRFkwQ2lBZ0lDQXZMeUFnSUdWNGFYTjBjem9nWW05dmJHVmhiZ29nSUNBZ0x5OGdJQ0JvWVhOTlpYUm9iMlJTWlhOMGNtbGpkR2x2Ym5NNklHSnZiMnhsWVc0S0lDQWdJQzh2SUgwcElIc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JpZEc5cENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSEIxYzJocGJuUWdPUW9nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lIQjFjMmhwYm5RZ01UY0tJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1luUnZhUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCd2RYTm9hVzUwSURJd01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhCMWMyaHBiblFnTWpBeENpQWdJQ0JuWlhSaWFYUUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdFltOXZiQzVoYkdkdkxuUnpPakl3Q2lBZ0lDQXZMeUJqYjI1emRDQmxjRzlqYUZKbFppQTlJSFZ6WlZKdmRXNWtjeUEvSUVkc2IySmhiQzV5YjNWdVpDQTZJRWRzYjJKaGJDNXNZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJR0o2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExXSnZiMnd1WVd4bmJ5NTBjem82UVhKak5FSnZiMnhCYkdkdkxuUmxjM1JmZEdWeWJtRnllVjltWVd4elpVQXlDaUFnSUNCaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMV0p2YjJ3dVlXeG5ieTUwY3pvNlFYSmpORUp2YjJ4QmJHZHZMblJsYzNSZmRHVnlibUZ5ZVY5MGNuVmxRREVLQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExXSnZiMnd1WVd4bmJ5NTBjem82UVhKak5FSnZiMnhCYkdkdkxuUmxjM1JmZEdWeWJtRnllVjkwY25WbFFERTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzFpYjI5c0xtRnNaMjh1ZEhNNk1qQUtJQ0FnSUM4dklHTnZibk4wSUdWd2IyTm9VbVZtSUQwZ2RYTmxVbTkxYm1SeklEOGdSMnh2WW1Gc0xuSnZkVzVrSURvZ1IyeHZZbUZzTG14aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ1oyeHZZbUZzSUZKdmRXNWtDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRZbTl2YkM1aGJHZHZMblJ6T2pwQmNtTTBRbTl2YkVGc1oyOHVkR1Z6ZEY5MFpYSnVZWEo1WDIxbGNtZGxRRE1LQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExXSnZiMnd1WVd4bmJ5NTBjem82UVhKak5FSnZiMnhCYkdkdkxuUmxjM1JmZEdWeWJtRnllVjl0WlhKblpVQXpPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0WW05dmJDNWhiR2R2TG5Sek9qSXdDaUFnSUNBdkx5QmpiMjV6ZENCbGNHOWphRkpsWmlBOUlIVnpaVkp2ZFc1a2N5QS9JRWRzYjJKaGJDNXliM1Z1WkNBNklFZHNiMkpoYkM1c1lYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzFpYjI5c0xtRnNaMjh1ZEhNNk1qUUtJQ0FnSUM4dklHVjRjR2x5WldRNklHVndiMk5vVW1WbUlENGdiR0Z6ZEZaaGJHbGtMQW9nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnUGdvZ0lDQWdZMjkyWlhJZ01Rb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRZbTl2YkM1aGJHZHZMblJ6T2pJMUNpQWdJQ0F2THlCb1lYTkRiMjlzWkc5M2Jqb2dZMjl2YkdSdmQyNGdQaUF3TEFvZ0lDQWdabkpoYldWZlpHbG5JRElLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lENEtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFdKdmIyd3VZV3huYnk1MGN6b3lOZ29nSUNBZ0x5OGdiMjVEYjI5c1pHOTNiam9nWlhCdlkyaFNaV1lnTFNCc1lYTjBRMkZzYkdWa0lEd2dZMjl2YkdSdmQyNHNDaUFnSUNCbWNtRnRaVjlrYVdjZ013b2dJQ0FnTFFvZ0lDQWdQZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0WW05dmJDNWhiR2R2TG5Sek9qSXlMVEk0Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdld29nSUNBZ0x5OGdJQ0JsZUdsemRITXNDaUFnSUNBdkx5QWdJR1Y0Y0dseVpXUTZJR1Z3YjJOb1VtVm1JRDRnYkdGemRGWmhiR2xrTEFvZ0lDQWdMeThnSUNCb1lYTkRiMjlzWkc5M2Jqb2dZMjl2YkdSdmQyNGdQaUF3TEFvZ0lDQWdMeThnSUNCdmJrTnZiMnhrYjNkdU9pQmxjRzlqYUZKbFppQXRJR3hoYzNSRFlXeHNaV1FnUENCamIyOXNaRzkzYml3S0lDQWdJQzh2SUNBZ2FHRnpUV1YwYUc5a1VtVnpkSEpwWTNScGIyNXpMQW9nSUNBZ0x5OGdmUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbWNtRnRaVjlrYVdjZ05Bb2dJQ0FnYzJWMFltbDBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUhCMWMyaHBiblFnTXdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lIQjFjMmhwYm5RZ05Bb2dJQ0FnWm5KaGJXVmZaR2xuSURVS0lDQWdJSE5sZEdKcGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNENpQWdJQ0IxYm1OdmRtVnlJREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnlaWFJ6ZFdJS0NuUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMV0p2YjJ3dVlXeG5ieTUwY3pvNlFYSmpORUp2YjJ4QmJHZHZMblJsYzNSZmRHVnlibUZ5ZVY5bVlXeHpaVUF5T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdFltOXZiQzVoYkdkdkxuUnpPakl3Q2lBZ0lDQXZMeUJqYjI1emRDQmxjRzlqYUZKbFppQTlJSFZ6WlZKdmRXNWtjeUEvSUVkc2IySmhiQzV5YjNWdVpDQTZJRWRzYjJKaGJDNXNZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJR2RzYjJKaGJDQk1ZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxaWIyOXNMbUZzWjI4dWRITTZPa0Z5WXpSQ2IyOXNRV3huYnk1MFpYTjBYM1JsY201aGNubGZiV1Z5WjJWQU13b0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExXSnZiMnd1WVd4bmJ5NTBjem82UVhKak5FSnZiMnhCYkdkdkxsOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlNncElDMCtJSFp2YVdRNkNsOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlRvS0lDQWdJR0lnWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxYMkpzYjJOclFEQUtDbDlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpWOWliRzlqYTBBd09nb2dJQ0FnY21WMGMzVmlDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQmlJRzFoYVc1ZllteHZZMnRBTUFvS2JXRnBibDlpYkc5amEwQXdPZ29nSUNBZ2NIVnphR2x1ZENBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFEQUFFSVFnQUFRZ0FBTVJzaUUwRUFLVUlBQURZYUFJQUVzTkt1ZFU4QmpnRUFCMElBQUVJQUFBQXhHU0lTTVJnaUV4QkVpQUFTUXYvc01Sa2lFakVZSWhJUVJJZ0FsaU5EUWdBQU5ob0JTUldCR2hKRWlBQU1nQVFWSDN4MVR3RlFzQ05EaWdFQmdBQkNBQUNML3lKVGkvOGpKRmdYaS8rQkNTUllGNHYvZ1JFa1dCZUwvNEhJQVZPTC80SEpBVk5QQlVFQVFVSUFBRElHakFCQ0FBQ0xBRW1MQVExT0FZc0NTVTRDSWcxT0E0c0RDUTJBQVFBaWl3UlVJMDhEVklFQ1R3TlVnUU5QQWxTQkJJc0ZWSUFBVHdGUWpBQ0pNZ2VNQUVML3drSUFBSWs9IiwiY2xlYXIiOiJDMElBQUlFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
