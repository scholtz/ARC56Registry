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

namespace Arc56.Generated.algorandfoundation.puya_ts.Arc4BoolAlgo_a60981a1
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXJjNEJvb2xBbGdvIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7Ik9iamVjdDdENjE1MjM2IjpbeyJuYW1lIjoiZXhpc3RzIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJleHBpcmVkIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJoYXNDb29sZG93biIsInR5cGUiOiJib29sIn0seyJuYW1lIjoib25Db29sZG93biIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiaGFzTWV0aG9kUmVzdHJpY3Rpb25zIiwidHlwZSI6ImJvb2wifV0sIk9iamVjdENCMjY3RUYzIjpbeyJuYW1lIjoidXNlUm91bmRzIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJsYXN0VmFsaWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiY29vbGRvd24iLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibGFzdENhbGxlZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJleGlzdHMiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6Imhhc01ldGhvZFJlc3RyaWN0aW9ucyIsInR5cGUiOiJib29sIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InRlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKGJvb2wsdWludDY0LHVpbnQ2NCx1aW50NjQsYm9vbCxib29sKSIsInN0cnVjdCI6Ik9iamVjdENCMjY3RUYzIiwibmFtZSI6InAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGJvb2wsYm9vbCxib29sLGJvb2wsYm9vbCkiLCJzdHJ1Y3QiOiJPYmplY3Q3RDYxNTIzNiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMzldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgT2JqZWN0Q0IyNjdFRjMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzFpYjI5c0xtRnNaMjh1ZEhNNk5Bb2dJQ0FnTHk4Z1kyeGhjM01nUVhKak5FSnZiMnhCYkdkdklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRRFVLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR0l3WkRKaFpUYzFJQzh2SUcxbGRHaHZaQ0FpZEdWemRDZ29ZbTl2YkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeGliMjlzTEdKdmIyd3BLU2hpYjI5c0xHSnZiMndzWW05dmJDeGliMjlzTEdKdmIyd3BJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOTBaWE4wWDNKdmRYUmxRRE1LSUNBZ0lHVnljZ29LYldGcGJsOTBaWE4wWDNKdmRYUmxRRE02Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxaWIyOXNMbUZzWjI4dWRITTZOUzB4T1FvZ0lDQWdMeThnZEdWemRDaDdDaUFnSUNBdkx5QWdJSFZ6WlZKdmRXNWtjeXdLSUNBZ0lDOHZJQ0FnYkdGemRGWmhiR2xrTEFvZ0lDQWdMeThnSUNCamIyOXNaRzkzYml3S0lDQWdJQzh2SUNBZ2JHRnpkRU5oYkd4bFpDd0tJQ0FnSUM4dklDQWdaWGhwYzNSekxBb2dJQ0FnTHk4Z0lDQm9ZWE5OWlhSb2IyUlNaWE4wY21samRHbHZibk1zQ2lBZ0lDQXZMeUI5T2lCN0NpQWdJQ0F2THlBZ0lIVnpaVkp2ZFc1a2N6b2dZbTl2YkdWaGJnb2dJQ0FnTHk4Z0lDQnNZWE4wVm1Gc2FXUTZJSFZwYm5RMk5Bb2dJQ0FnTHk4Z0lDQmpiMjlzWkc5M2Jqb2dkV2x1ZERZMENpQWdJQ0F2THlBZ0lHeGhjM1JEWVd4c1pXUTZJSFZwYm5RMk5Bb2dJQ0FnTHk4Z0lDQmxlR2x6ZEhNNklHSnZiMnhsWVc0S0lDQWdJQzh2SUNBZ2FHRnpUV1YwYUc5a1VtVnpkSEpwWTNScGIyNXpPaUJpYjI5c1pXRnVDaUFnSUNBdkx5QjlLU0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNallLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlFOWlhbVZqZEVOQ01qWTNSVVl6Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb2FXNTBJRGtLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnY0hWemFHbHVkQ0F4TndvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdScFp5QXhDaUFnSUNCd2RYTm9hVzUwSURJd01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQndkWE5vYVc1MElESXdNUW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxaWIyOXNMbUZzWjI4dWRITTZNakFLSUNBZ0lDOHZJR052Ym5OMElHVndiMk5vVW1WbUlEMGdkWE5sVW05MWJtUnpJRDhnUjJ4dlltRnNMbkp2ZFc1a0lEb2dSMnh2WW1Gc0xteGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURFd0NpQWdJQ0JuYkc5aVlXd2dVbTkxYm1RS0NtMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQXhNVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFdKdmIyd3VZV3huYnk1MGN6b3lOQW9nSUNBZ0x5OGdaWGh3YVhKbFpEb2daWEJ2WTJoU1pXWWdQaUJzWVhOMFZtRnNhV1FzQ2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnUGdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdFltOXZiQzVoYkdkdkxuUnpPakkxQ2lBZ0lDQXZMeUJvWVhORGIyOXNaRzkzYmpvZ1kyOXZiR1J2ZDI0Z1BpQXdMQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0ErQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxaWIyOXNMbUZzWjI4dWRITTZNallLSUNBZ0lDOHZJRzl1UTI5dmJHUnZkMjQ2SUdWd2IyTm9VbVZtSUMwZ2JHRnpkRU5oYkd4bFpDQThJR052YjJ4a2IzZHVMQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lDMEtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdQQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0WW05dmJDNWhiR2R2TG5Sek9qSXlMVEk0Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdld29nSUNBZ0x5OGdJQ0JsZUdsemRITXNDaUFnSUNBdkx5QWdJR1Y0Y0dseVpXUTZJR1Z3YjJOb1VtVm1JRDRnYkdGemRGWmhiR2xrTEFvZ0lDQWdMeThnSUNCb1lYTkRiMjlzWkc5M2Jqb2dZMjl2YkdSdmQyNGdQaUF3TEFvZ0lDQWdMeThnSUNCdmJrTnZiMnhrYjNkdU9pQmxjRzlqYUZKbFppQXRJR3hoYzNSRFlXeHNaV1FnUENCamIyOXNaRzkzYml3S0lDQWdJQzh2SUNBZ2FHRnpUV1YwYUc5a1VtVnpkSEpwWTNScGIyNXpMQW9nSUNBZ0x5OGdmUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJSE5sZEdKcGRBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ2MyVjBZbWwwQ2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdjMlYwWW1sMENpQWdJQ0J3ZFhOb2FXNTBJRE1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCd2RYTm9hVzUwSURRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxaWIyOXNMbUZzWjI4dWRITTZOUzB4T1FvZ0lDQWdMeThnZEdWemRDaDdDaUFnSUNBdkx5QWdJSFZ6WlZKdmRXNWtjeXdLSUNBZ0lDOHZJQ0FnYkdGemRGWmhiR2xrTEFvZ0lDQWdMeThnSUNCamIyOXNaRzkzYml3S0lDQWdJQzh2SUNBZ2JHRnpkRU5oYkd4bFpDd0tJQ0FnSUM4dklDQWdaWGhwYzNSekxBb2dJQ0FnTHk4Z0lDQm9ZWE5OWlhSb2IyUlNaWE4wY21samRHbHZibk1zQ2lBZ0lDQXZMeUI5T2lCN0NpQWdJQ0F2THlBZ0lIVnpaVkp2ZFc1a2N6b2dZbTl2YkdWaGJnb2dJQ0FnTHk4Z0lDQnNZWE4wVm1Gc2FXUTZJSFZwYm5RMk5Bb2dJQ0FnTHk4Z0lDQmpiMjlzWkc5M2Jqb2dkV2x1ZERZMENpQWdJQ0F2THlBZ0lHeGhjM1JEWVd4c1pXUTZJSFZwYm5RMk5Bb2dJQ0FnTHk4Z0lDQmxlR2x6ZEhNNklHSnZiMnhsWVc0S0lDQWdJQzh2SUNBZ2FHRnpUV1YwYUc5a1VtVnpkSEpwWTNScGIyNXpPaUJpYjI5c1pXRnVDaUFnSUNBdkx5QjlLU0I3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMV0p2YjJ3dVlXeG5ieTUwY3pveU1Bb2dJQ0FnTHk4Z1kyOXVjM1FnWlhCdlkyaFNaV1lnUFNCMWMyVlNiM1Z1WkhNZ1B5QkhiRzlpWVd3dWNtOTFibVFnT2lCSGJHOWlZV3d1YkdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNCbmJHOWlZV3dnVEdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQXhNUW9LYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU5Ub0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMV0p2YjJ3dVlXeG5ieTUwY3pvMENpQWdJQ0F2THlCamJHRnpjeUJCY21NMFFtOXZiRUZzWjI4Z1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnSmlZS0lDQWdJSEpsZEhWeWJnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFDQUFFeEcwRUFoWUFFc05LdWRUWWFBSTRCQUFFQU1Sa1VNUmdRUkRZYUFVa1ZnUm9TUkVraVUwc0JJMXRPQWtzQmdRbGJUZ0pMQVlFUlcwNENTd0dCeUFGVFRnSk1nY2tCVTB4QkFEb3lCa2xQQmcxUEJVbE9BaUlOVHdOUEJnbFBBd3lBQVFBaVR3WlVJMDhFVklFQ1R3TlVnUU5QQWxTQkJFOENWSUFFRlI5OGRVeFFzQ05ETWdkQy84TXhHUlF4R0JRUVF3PT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
