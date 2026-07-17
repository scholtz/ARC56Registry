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

namespace Arc56.Generated.algorandfoundation.puya_ts.Arc4BoolAlgo_b51dc0de
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXJjNEJvb2xBbGdvIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7Ik9iamVjdDdENjE1MjM2IjpbeyJuYW1lIjoiZXhpc3RzIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJleHBpcmVkIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJoYXNDb29sZG93biIsInR5cGUiOiJib29sIn0seyJuYW1lIjoib25Db29sZG93biIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiaGFzTWV0aG9kUmVzdHJpY3Rpb25zIiwidHlwZSI6ImJvb2wifV0sIk9iamVjdENCMjY3RUYzIjpbeyJuYW1lIjoidXNlUm91bmRzIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJsYXN0VmFsaWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiY29vbGRvd24iLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibGFzdENhbGxlZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJleGlzdHMiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6Imhhc01ldGhvZFJlc3RyaWN0aW9ucyIsInR5cGUiOiJib29sIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InRlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKGJvb2wsdWludDY0LHVpbnQ2NCx1aW50NjQsYm9vbCxib29sKSIsInN0cnVjdCI6Ik9iamVjdENCMjY3RUYzIiwibmFtZSI6InAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGJvb2wsYm9vbCxib29sLGJvb2wsYm9vbCkiLCJzdHJ1Y3QiOiJPYmplY3Q3RDYxNTIzNiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNTBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgT2JqZWN0Q0IyNjdFRjMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzFpYjI5c0xtRnNaMjh1ZEhNNk5Bb2dJQ0FnTHk4Z1kyeGhjM01nUVhKak5FSnZiMnhCYkdkdklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRRFVLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR0l3WkRKaFpUYzFJQzh2SUcxbGRHaHZaQ0FpZEdWemRDZ29ZbTl2YkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeGliMjlzTEdKdmIyd3BLU2hpYjI5c0xHSnZiMndzWW05dmJDeGliMjlzTEdKdmIyd3BJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOTBaWE4wWDNKdmRYUmxRRE1LSUNBZ0lHVnljZ29LYldGcGJsOTBaWE4wWDNKdmRYUmxRRE02Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxaWIyOXNMbUZzWjI4dWRITTZOUzB4T1FvZ0lDQWdMeThnZEdWemRDaDdDaUFnSUNBdkx5QWdJSFZ6WlZKdmRXNWtjeXdLSUNBZ0lDOHZJQ0FnYkdGemRGWmhiR2xrTEFvZ0lDQWdMeThnSUNCamIyOXNaRzkzYml3S0lDQWdJQzh2SUNBZ2JHRnpkRU5oYkd4bFpDd0tJQ0FnSUM4dklDQWdaWGhwYzNSekxBb2dJQ0FnTHk4Z0lDQm9ZWE5OWlhSb2IyUlNaWE4wY21samRHbHZibk1zQ2lBZ0lDQXZMeUI5T2lCN0NpQWdJQ0F2THlBZ0lIVnpaVkp2ZFc1a2N6b2dZbTl2YkdWaGJnb2dJQ0FnTHk4Z0lDQnNZWE4wVm1Gc2FXUTZJSFZwYm5RMk5Bb2dJQ0FnTHk4Z0lDQmpiMjlzWkc5M2Jqb2dkV2x1ZERZMENpQWdJQ0F2THlBZ0lHeGhjM1JEWVd4c1pXUTZJSFZwYm5RMk5Bb2dJQ0FnTHk4Z0lDQmxlR2x6ZEhNNklHSnZiMnhsWVc0S0lDQWdJQzh2SUNBZ2FHRnpUV1YwYUc5a1VtVnpkSEpwWTNScGIyNXpPaUJpYjI5c1pXRnVDaUFnSUNBdkx5QjlLU0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnWWlCMFpYTjBDZ3B0WVdsdVgxOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlVBMU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRZbTl2YkM1aGJHZHZMblJ6T2pRS0lDQWdJQzh2SUdOc1lYTnpJRUZ5WXpSQ2IyOXNRV3huYnlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0FtSmdvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdFltOXZiQzVoYkdkdkxuUnpPanBCY21NMFFtOXZiRUZzWjI4dWRHVnpkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25SbGMzUTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzFpYjI5c0xtRnNaMjh1ZEhNNk5TMHhPUW9nSUNBZ0x5OGdkR1Z6ZENoN0NpQWdJQ0F2THlBZ0lIVnpaVkp2ZFc1a2N5d0tJQ0FnSUM4dklDQWdiR0Z6ZEZaaGJHbGtMQW9nSUNBZ0x5OGdJQ0JqYjI5c1pHOTNiaXdLSUNBZ0lDOHZJQ0FnYkdGemRFTmhiR3hsWkN3S0lDQWdJQzh2SUNBZ1pYaHBjM1J6TEFvZ0lDQWdMeThnSUNCb1lYTk5aWFJvYjJSU1pYTjBjbWxqZEdsdmJuTXNDaUFnSUNBdkx5QjlPaUI3Q2lBZ0lDQXZMeUFnSUhWelpWSnZkVzVrY3pvZ1ltOXZiR1ZoYmdvZ0lDQWdMeThnSUNCc1lYTjBWbUZzYVdRNklIVnBiblEyTkFvZ0lDQWdMeThnSUNCamIyOXNaRzkzYmpvZ2RXbHVkRFkwQ2lBZ0lDQXZMeUFnSUd4aGMzUkRZV3hzWldRNklIVnBiblEyTkFvZ0lDQWdMeThnSUNCbGVHbHpkSE02SUdKdmIyeGxZVzRLSUNBZ0lDOHZJQ0FnYUdGelRXVjBhRzlrVW1WemRISnBZM1JwYjI1ek9pQmliMjlzWldGdUNpQWdJQ0F2THlCOUtTQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F5TmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdUMkpxWldOMFEwSXlOamRGUmpNS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaHBiblFnT1FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdScFp5QXhDaUFnSUNCd2RYTm9hVzUwSURFM0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ01qQXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJSEIxYzJocGJuUWdNakF4Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExXSnZiMnd1WVd4bmJ5NTBjem95TUFvZ0lDQWdMeThnWTI5dWMzUWdaWEJ2WTJoU1pXWWdQU0IxYzJWU2IzVnVaSE1nUHlCSGJHOWlZV3d1Y205MWJtUWdPaUJIYkc5aVlXd3ViR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0JpZWlCMFpYTjBYM1JsY201aGNubGZabUZzYzJWQU13b2dJQ0FnWjJ4dlltRnNJRkp2ZFc1a0NncDBaWE4wWDNSbGNtNWhjbmxmYldWeVoyVkFORG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFdKdmIyd3VZV3huYnk1MGN6b3lOQW9nSUNBZ0x5OGdaWGh3YVhKbFpEb2daWEJ2WTJoU1pXWWdQaUJzWVhOMFZtRnNhV1FzQ2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUEyQ2lBZ0lDQStDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzFpYjI5c0xtRnNaMjh1ZEhNNk1qVUtJQ0FnSUM4dklHaGhjME52YjJ4a2IzZHVPaUJqYjI5c1pHOTNiaUErSURBc0NpQWdJQ0JrYVdjZ05Rb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnUGdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdFltOXZiQzVoYkdkdkxuUnpPakkyQ2lBZ0lDQXZMeUJ2YmtOdmIyeGtiM2R1T2lCbGNHOWphRkpsWmlBdElHeGhjM1JEWVd4c1pXUWdQQ0JqYjI5c1pHOTNiaXdLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWkdsbklEWUtJQ0FnSUMwS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1BBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRZbTl2YkM1aGJHZHZMblJ6T2pJeUxUSTRDaUFnSUNBdkx5QnlaWFIxY200Z2V3b2dJQ0FnTHk4Z0lDQmxlR2x6ZEhNc0NpQWdJQ0F2THlBZ0lHVjRjR2x5WldRNklHVndiMk5vVW1WbUlENGdiR0Z6ZEZaaGJHbGtMQW9nSUNBZ0x5OGdJQ0JvWVhORGIyOXNaRzkzYmpvZ1kyOXZiR1J2ZDI0Z1BpQXdMQW9nSUNBZ0x5OGdJQ0J2YmtOdmIyeGtiM2R1T2lCbGNHOWphRkpsWmlBdElHeGhjM1JEWVd4c1pXUWdQQ0JqYjI5c1pHOTNiaXdLSUNBZ0lDOHZJQ0FnYUdGelRXVjBhRzlrVW1WemRISnBZM1JwYjI1ekxBb2dJQ0FnTHk4Z2ZRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JrYVdjZ05nb2dJQ0FnYzJWMFltbDBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQnpaWFJpYVhRS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUhCMWMyaHBiblFnTXdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lIQjFjMmhwYm5RZ05Bb2dJQ0FnWkdsbklESUtJQ0FnSUhObGRHSnBkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0WW05dmJDNWhiR2R2TG5Sek9qVXRNVGtLSUNBZ0lDOHZJSFJsYzNRb2V3b2dJQ0FnTHk4Z0lDQjFjMlZTYjNWdVpITXNDaUFnSUNBdkx5QWdJR3hoYzNSV1lXeHBaQ3dLSUNBZ0lDOHZJQ0FnWTI5dmJHUnZkMjRzQ2lBZ0lDQXZMeUFnSUd4aGMzUkRZV3hzWldRc0NpQWdJQ0F2THlBZ0lHVjRhWE4wY3l3S0lDQWdJQzh2SUNBZ2FHRnpUV1YwYUc5a1VtVnpkSEpwWTNScGIyNXpMQW9nSUNBZ0x5OGdmVG9nZXdvZ0lDQWdMeThnSUNCMWMyVlNiM1Z1WkhNNklHSnZiMnhsWVc0S0lDQWdJQzh2SUNBZ2JHRnpkRlpoYkdsa09pQjFhVzUwTmpRS0lDQWdJQzh2SUNBZ1kyOXZiR1J2ZDI0NklIVnBiblEyTkFvZ0lDQWdMeThnSUNCc1lYTjBRMkZzYkdWa09pQjFhVzUwTmpRS0lDQWdJQzh2SUNBZ1pYaHBjM1J6T2lCaWIyOXNaV0Z1Q2lBZ0lDQXZMeUFnSUdoaGMwMWxkR2h2WkZKbGMzUnlhV04wYVc5dWN6b2dZbTl2YkdWaGJnb2dJQ0FnTHk4Z2ZTa2dld29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3AwWlhOMFgzUmxjbTVoY25sZlptRnNjMlZBTXpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExXSnZiMnd1WVd4bmJ5NTBjem95TUFvZ0lDQWdMeThnWTI5dWMzUWdaWEJ2WTJoU1pXWWdQU0IxYzJWU2IzVnVaSE1nUHlCSGJHOWlZV3d1Y205MWJtUWdPaUJIYkc5aVlXd3ViR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0JuYkc5aVlXd2dUR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0JpSUhSbGMzUmZkR1Z5Ym1GeWVWOXRaWEpuWlVBMENnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFDQUFFeEcwRUFHSUFFc05LdWRUWWFBSTRCQUFFQU1Sa1VNUmdRUkVJQUNERVpGREVZRkJCRE5ob0JTUldCR2hKRVNTSlRTd0VqVzA0Q1N3R0JDVnRPQWtzQmdSRmJUZ0pMQVlISUFWTk9Ba3lCeVFGVFRFRUFPaklHU1VzR0RVc0ZTVTRDSWcxUEEwc0dDVThERElBQkFDSkxCbFFqVHdSVWdRSlBBMVNCQTA4Q1ZJRUVTd0pVZ0FRVkgzeDFURkN3STBNeUIwTC93dz09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
