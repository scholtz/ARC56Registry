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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXJjNEJvb2xBbGdvIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7Ik9iamVjdDdENjE1MjM2IjpbeyJuYW1lIjoiZXhpc3RzIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJleHBpcmVkIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJoYXNDb29sZG93biIsInR5cGUiOiJib29sIn0seyJuYW1lIjoib25Db29sZG93biIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiaGFzTWV0aG9kUmVzdHJpY3Rpb25zIiwidHlwZSI6ImJvb2wifV0sIk9iamVjdENCMjY3RUYzIjpbeyJuYW1lIjoidXNlUm91bmRzIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJsYXN0VmFsaWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiY29vbGRvd24iLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibGFzdENhbGxlZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJleGlzdHMiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6Imhhc01ldGhvZFJlc3RyaWN0aW9ucyIsInR5cGUiOiJib29sIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InRlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKGJvb2wsdWludDY0LHVpbnQ2NCx1aW50NjQsYm9vbCxib29sKSIsInN0cnVjdCI6Ik9iamVjdENCMjY3RUYzIiwibmFtZSI6InAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGJvb2wsYm9vbCxib29sLGJvb2wsYm9vbCkiLCJzdHJ1Y3QiOiJPYmplY3Q3RDYxNTIzNiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNDNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgT2JqZWN0Q0IyNjdFRjMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpSUtJQ0FnSUdSMWNHNGdOQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0WW05dmJDNWhiR2R2TG5Sek9qUUtJQ0FnSUM4dklHTnNZWE56SUVGeVl6UkNiMjlzUVd4bmJ5QmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUExQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhpTUdReVlXVTNOU0F2THlCdFpYUm9iMlFnSW5SbGMzUW9LR0p2YjJ3c2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNZbTl2YkN4aWIyOXNLU2tvWW05dmJDeGliMjlzTEdKdmIyd3NZbTl2YkN4aWIyOXNLU0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZkR1Z6ZEY5eWIzVjBaVUF6Q2lBZ0lDQmxjbklLQ20xaGFXNWZkR1Z6ZEY5eWIzVjBaVUF6T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdFltOXZiQzVoYkdkdkxuUnpPalV0TVRrS0lDQWdJQzh2SUhSbGMzUW9ld29nSUNBZ0x5OGdJQ0IxYzJWU2IzVnVaSE1zQ2lBZ0lDQXZMeUFnSUd4aGMzUldZV3hwWkN3S0lDQWdJQzh2SUNBZ1kyOXZiR1J2ZDI0c0NpQWdJQ0F2THlBZ0lHeGhjM1JEWVd4c1pXUXNDaUFnSUNBdkx5QWdJR1Y0YVhOMGN5d0tJQ0FnSUM4dklDQWdhR0Z6VFdWMGFHOWtVbVZ6ZEhKcFkzUnBiMjV6TEFvZ0lDQWdMeThnZlRvZ2V3b2dJQ0FnTHk4Z0lDQjFjMlZTYjNWdVpITTZJR0p2YjJ4bFlXNEtJQ0FnSUM4dklDQWdiR0Z6ZEZaaGJHbGtPaUIxYVc1ME5qUUtJQ0FnSUM4dklDQWdZMjl2YkdSdmQyNDZJSFZwYm5RMk5Bb2dJQ0FnTHk4Z0lDQnNZWE4wUTJGc2JHVmtPaUIxYVc1ME5qUUtJQ0FnSUM4dklDQWdaWGhwYzNSek9pQmliMjlzWldGdUNpQWdJQ0F2THlBZ0lHaGhjMDFsZEdodlpGSmxjM1J5YVdOMGFXOXVjem9nWW05dmJHVmhiZ29nSUNBZ0x5OGdmU2tnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJREkyQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQlBZbXBsWTNSRFFqSTJOMFZHTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmlkWEo1SURNS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb2FXNTBJRGtLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmlkWEo1SURjS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb2FXNTBJREUzQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdZblZ5ZVNBMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnY0hWemFHbHVkQ0F5TURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWW5WeWVTQTJDaUFnSUNCemQyRndDaUFnSUNCd2RYTm9hVzUwSURJd01Rb2dJQ0FnWjJWMFltbDBDaUFnSUNCaWRYSjVJRFFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFdKdmIyd3VZV3huYnk1MGN6b3lNQW9nSUNBZ0x5OGdZMjl1YzNRZ1pYQnZZMmhTWldZZ1BTQjFjMlZTYjNWdVpITWdQeUJIYkc5aVlXd3VjbTkxYm1RZ09pQkhiRzlpWVd3dWJHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQmllaUJ0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTVRBS0lDQWdJR2RzYjJKaGJDQlNiM1Z1WkFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFERXhPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0WW05dmJDNWhiR2R2TG5Sek9qSTBDaUFnSUNBdkx5QmxlSEJwY21Wa09pQmxjRzlqYUZKbFppQStJR3hoYzNSV1lXeHBaQ3dLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRElLSUNBZ0lENEtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMV0p2YjJ3dVlXeG5ieTUwY3pveU5Rb2dJQ0FnTHk4Z2FHRnpRMjl2YkdSdmQyNDZJR052YjJ4a2IzZHVJRDRnTUN3S0lDQWdJR1JwWnlBMkNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0ErQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxaWIyOXNMbUZzWjI4dWRITTZNallLSUNBZ0lDOHZJRzl1UTI5dmJHUnZkMjQ2SUdWd2IyTm9VbVZtSUMwZ2JHRnpkRU5oYkd4bFpDQThJR052YjJ4a2IzZHVMQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JrYVdjZ05Rb2dJQ0FnTFFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNBOENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMWliMjlzTG1Gc1oyOHVkSE02TWpJdE1qZ0tJQ0FnSUM4dklISmxkSFZ5YmlCN0NpQWdJQ0F2THlBZ0lHVjRhWE4wY3l3S0lDQWdJQzh2SUNBZ1pYaHdhWEpsWkRvZ1pYQnZZMmhTWldZZ1BpQnNZWE4wVm1Gc2FXUXNDaUFnSUNBdkx5QWdJR2hoYzBOdmIyeGtiM2R1T2lCamIyOXNaRzkzYmlBK0lEQXNDaUFnSUNBdkx5QWdJRzl1UTI5dmJHUnZkMjQ2SUdWd2IyTm9VbVZtSUMwZ2JHRnpkRU5oYkd4bFpDQThJR052YjJ4a2IzZHVMQW9nSUNBZ0x5OGdJQ0JvWVhOTlpYUm9iMlJTWlhOMGNtbGpkR2x2Ym5Nc0NpQWdJQ0F2THlCOUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1JwWnlBNENpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lITmxkR0pwZEFvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSE5sZEdKcGRBb2dJQ0FnY0hWemFHbHVkQ0F6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGRHSnBkQW9nSUNBZ2NIVnphR2x1ZENBMENpQWdJQ0JrYVdjZ05Bb2dJQ0FnYzJWMFltbDBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzFpYjI5c0xtRnNaMjh1ZEhNNk5TMHhPUW9nSUNBZ0x5OGdkR1Z6ZENoN0NpQWdJQ0F2THlBZ0lIVnpaVkp2ZFc1a2N5d0tJQ0FnSUM4dklDQWdiR0Z6ZEZaaGJHbGtMQW9nSUNBZ0x5OGdJQ0JqYjI5c1pHOTNiaXdLSUNBZ0lDOHZJQ0FnYkdGemRFTmhiR3hsWkN3S0lDQWdJQzh2SUNBZ1pYaHBjM1J6TEFvZ0lDQWdMeThnSUNCb1lYTk5aWFJvYjJSU1pYTjBjbWxqZEdsdmJuTXNDaUFnSUNBdkx5QjlPaUI3Q2lBZ0lDQXZMeUFnSUhWelpWSnZkVzVrY3pvZ1ltOXZiR1ZoYmdvZ0lDQWdMeThnSUNCc1lYTjBWbUZzYVdRNklIVnBiblEyTkFvZ0lDQWdMeThnSUNCamIyOXNaRzkzYmpvZ2RXbHVkRFkwQ2lBZ0lDQXZMeUFnSUd4aGMzUkRZV3hzWldRNklIVnBiblEyTkFvZ0lDQWdMeThnSUNCbGVHbHpkSE02SUdKdmIyeGxZVzRLSUNBZ0lDOHZJQ0FnYUdGelRXVjBhRzlrVW1WemRISnBZM1JwYjI1ek9pQmliMjlzWldGdUNpQWdJQ0F2THlCOUtTQjdDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExXSnZiMnd1WVd4bmJ5NTBjem95TUFvZ0lDQWdMeThnWTI5dWMzUWdaWEJ2WTJoU1pXWWdQU0IxYzJWU2IzVnVaSE1nUHlCSGJHOWlZV3d1Y205MWJtUWdPaUJIYkc5aVlXd3ViR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0JuYkc5aVlXd2dUR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE1Rb0tiV0ZwYmw5ZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZBTlRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExXSnZiMnd1WVd4bmJ5NTBjem8wQ2lBZ0lDQXZMeUJqYkdGemN5QkJjbU0wUW05dmJFRnNaMjhnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdKaVlLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUNBQUdBQUVjRU1SdEJBSWFBQkxEU3JuVTJHZ0NPQVFBQkFERVpGREVZRUVRMkdnRkpGWUVhRWtSSklsTkxBU05iUlFOTEFZRUpXMFVIU3dHQkVWdEZCRXNCZ2NnQlUwVUdUSUhKQVZORkJFRUFPaklHU1VzQ0RVc0dTVTRDSWcxUEEwc0ZDVThERElBQkFDSkxDRlFqVHdSVWdRSlBBMVNCQTA4Q1ZJRUVTd1JVZ0FRVkgzeDFURkN3STBNeUIwTC93ekVaRkRFWUZCQkQiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
