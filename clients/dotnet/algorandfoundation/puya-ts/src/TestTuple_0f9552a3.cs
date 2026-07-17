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

namespace Arc56.Generated.algorandfoundation.puya_ts.TestTuple_0f9552a3
{


    public class TestTupleProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TestTupleProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Object3Db88Ffd : AVMObjectType
            {
                public string A { get; set; }

                public ulong B { get; set; }

                public bool C { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vA.From(A);
                    stringRef[ret.Count] = vA.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vB.From(B);
                    ret.AddRange(vB.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vC = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vC.From(C);
                    ret.AddRange(vC.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Object3Db88Ffd Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new Object3Db88Ffd();
                    uint count = 0;
                    var indexA = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vA.Decode(bytes.Skip(indexA + prefixOffset).ToArray());
                    var valueA = vA.ToValue();
                    if (valueA is string vAValue) { ret.A = vAValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vB.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueB = vB.ToValue();
                    if (valueB is ulong vBValue) { ret.B = vBValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vC = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vC.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueC = vC.ToValue();
                    if (valueC is bool vCValue) { ret.C = vCValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Object3Db88Ffd);
                }
                public bool Equals(Object3Db88Ffd? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Object3Db88Ffd left, Object3Db88Ffd right)
                {
                    return EqualityComparer<Object3Db88Ffd>.Default.Equals(left, right);
                }
                public static bool operator !=(Object3Db88Ffd left, Object3Db88Ffd right)
                {
                    return !(left == right);
                }

            }

            public class Data : AVMObjectType
            {
                public string A { get; set; }

                public ulong B { get; set; }

                public bool C { get; set; }

                public string D { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vA.From(A);
                    stringRef[ret.Count] = vA.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vB.From(B);
                    ret.AddRange(vB.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vC = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vC.From(C);
                    ret.AddRange(vC.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vD = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vD.From(D);
                    stringRef[ret.Count] = vD.Encode();
                    ret.AddRange(new byte[2]);
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Data Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new Data();
                    uint count = 0;
                    var indexA = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vA.Decode(bytes.Skip(indexA + prefixOffset).ToArray());
                    var valueA = vA.ToValue();
                    if (valueA is string vAValue) { ret.A = vAValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vB.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueB = vB.ToValue();
                    if (valueB is ulong vBValue) { ret.B = vBValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vC = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vC.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueC = vC.ToValue();
                    if (valueC is bool vCValue) { ret.C = vCValue; }
                    var indexD = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vD = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vD.Decode(bytes.Skip(indexD + prefixOffset).ToArray());
                    var valueD = vD.ToValue();
                    if (valueD is string vDValue) { ret.D = vDValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Data);
                }
                public bool Equals(Data? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Data left, Data right)
                {
                    return EqualityComparer<Data>.Default.Equals(left, right);
                }
                public static bool operator !=(Data left, Data right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task TestTuple(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 18, 84, 119, 245 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestTuple_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 18, 84, 119, 245 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVGVzdFR1cGxlIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7Ik9iamVjdDNEQjg4RkZEIjpbeyJuYW1lIjoiYSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJiIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImMiLCJ0eXBlIjoiYm9vbCJ9XSwiRGF0YSI6W3sibmFtZSI6ImEiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiYiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJkIiwidHlwZSI6InN0cmluZyJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJ0ZXN0VHVwbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjo1fSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls3OTYsODA5LDgyMCw4NDddLCJlcnJvck1lc3NhZ2UiOiJNdXRhYmxlIG9iamVjdCB2YWx1ZSBzaG91bGQgYmUgc2V0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDczLDQ4Niw0OTddLCJlcnJvck1lc3NhZ2UiOiJPYmplY3QgdmFsdWUgc2hvdWxkIGJlIHNldCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4NSwxOTgsMjA5LDMyMiwzNjEsMzg3LDQxMyw2MTAsNjQ5LDY3NSw3MDFdLCJlcnJvck1lc3NhZ2UiOiJUdXBsZSB2YWx1ZSBzaG91bGQgYmUgc2V0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTY1LDE5MCwyMDMsMzAwLDMyNywzNjYsMzkyLDQ1Myw0NzgsNDkxLDU4OCw2MTUsNjU0LDY4MCw3NzQsODAxLDgxNCw4MjVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzMsNTIxXSwiZXJyb3JNZXNzYWdlIjoib3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXlJREVnTVRJekNpQWdJQ0JpZVhSbFkySnNiMk5ySUNKb1pXeHNieUlnTUhnZ0ltSWlJREI0TURGak9DQWlZU0lnTUhnd01DQWlkRElpSUNKME5DSWdJblExSWlBaWRERWlJQ0owTXlJZ0lsZHZjbXhrSWdvZ0lDQWdZaUJ0WVdsdVgySnNiMk5yUURBS0NtMWhhVzVmWW14dlkydEFNRG9LSUNBZ0lHSWdiV0ZwYmw5aWJHOWphMEF4Q2dwdFlXbHVYMkpzYjJOclFERTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdloyeHZZbUZzTFhOMFlYUmxMbUZzWjI4dWRITTZOVGtLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCVVpYTjBWSFZ3YkdVZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQ0U5Q2lBZ0lDQmllaUJ0WVdsdVgxOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlVBMUNpQWdJQ0JpSUcxaGFXNWZZV0pwWDNKdmRYUnBibWRBTWdvS2JXRnBibDloWW1sZmNtOTFkR2x1WjBBeU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkc2IySmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qVTVDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVkdWemRGUjFjR3hsSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRJMU5EYzNaalVnTHk4Z2JXVjBhRzlrSUNKMFpYTjBWSFZ3YkdVb0tYWnZhV1FpQ2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZmRHVnpkRlIxY0d4bFgzSnZkWFJsUURNS0lDQWdJR0lnYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFEUUtDbTFoYVc1ZmMzZHBkR05vWDJOaGMyVmZibVY0ZEVBME9nb2dJQ0FnWWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU5nb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRFk2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaMnh2WW1Gc0xYTjBZWFJsTG1Gc1oyOHVkSE02TlRrS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QlVaWE4wVkhWd2JHVWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCbGNuSUtDbTFoYVc1ZmRHVnpkRlIxY0d4bFgzSnZkWFJsUURNNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjJ4dlltRnNMWE4wWVhSbExtRnNaMjh1ZEhNNk5qZ0tJQ0FnSUM4dklIUmxjM1JVZFhCc1pTZ3BJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1DQXZMeUJPYjA5d0NpQWdJQ0E5UFFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0FoUFFvZ0lDQWdKaVlLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdZMkZzYkhOMVlpQjBaWE4wVkhWd2JHVUtJQ0FnSUdJZ2JXRnBibDl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRRFFLQ20xaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFEVTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdloyeHZZbUZzTFhOMFlYUmxMbUZzWjI4dWRITTZOVGtLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCVVpYTjBWSFZ3YkdVZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z1RtOVBjQW9nSUNBZ1BUMEtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1BUMEtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUdOaGJHeHpkV0lnWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkc2IySmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qcFVaWE4wVkhWd2JHVXVkR1Z6ZEZSMWNHeGxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZEdWemRGUjFjR3hsT2dvZ0lDQWdZaUIwWlhOMFZIVndiR1ZmWW14dlkydEFNQW9LZEdWemRGUjFjR3hsWDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaMnh2WW1Gc0xYTjBZWFJsTG1Gc1oyOHVkSE02TmpnS0lDQWdJQzh2SUhSbGMzUlVkWEJzWlNncElIc0tJQ0FnSUdOaGJHeHpkV0lnZEdWemRITXZZWEJ3Y205MllXeHpMMmRzYjJKaGJDMXpkR0YwWlM1aGJHZHZMblJ6T2pwVVpYTjBWSFZ3YkdVdWRHVnpkRlIxY0d4bENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmRzYjJKaGJDMXpkR0YwWlM1aGJHZHZMblJ6T2pwVVpYTjBWSFZ3YkdVdWRHVnpkRlIxY0d4bEtDa2dMVDRnZG05cFpEb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZHNiMkpoYkMxemRHRjBaUzVoYkdkdkxuUnpPanBVWlhOMFZIVndiR1V1ZEdWemRGUjFjR3hsT2dvZ0lDQWdZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaMnh2WW1Gc0xYTjBZWFJsTG1Gc1oyOHVkSE02T2xSbGMzUlVkWEJzWlM1MFpYTjBWSFZ3YkdWZllteHZZMnRBTUFvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkc2IySmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qcFVaWE4wVkhWd2JHVXVkR1Z6ZEZSMWNHeGxYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdloyeHZZbUZzTFhOMFlYUmxMbUZzWjI4dWRITTZOamtLSUNBZ0lDOHZJSFJvYVhNdWRERXVkbUZzZFdVZ1BTQmJKMmhsYkd4dkp5d2dNVEl6TENCMGNuVmxYUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlhR1ZzYkc4aUNpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pvWld4c2J5SUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR2x1ZENBeE1Rb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNVEl6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWaklEVWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluYkc5aVlXd3RjM1JoZEdVdVlXeG5ieTUwY3pvMk1Bb2dJQ0FnTHk4Z2RERWdQU0JIYkc5aVlXeFRkR0YwWlR4YmMzUnlhVzVuTENCMWFXNTBOalFzSUdKdmIyeGxZVzVkUGlncENpQWdJQ0JpZVhSbFl5QTVJQzh2SUNKME1TSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmJHOWlZV3d0YzNSaGRHVXVZV3huYnk1MGN6bzJPUW9nSUNBZ0x5OGdkR2hwY3k1ME1TNTJZV3gxWlNBOUlGc25hR1ZzYkc4bkxDQXhNak1zSUhSeWRXVmRDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjJ4dlltRnNMWE4wWVhSbExtRnNaMjh1ZEhNNk56QUtJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMblF4TG5aaGJIVmxXekJkSUQwOVBTQW5hR1ZzYkc4bkxDQW5WSFZ3YkdVZ2RtRnNkV1VnYzJodmRXeGtJR0psSUhObGRDY3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkc2IySmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qWXdDaUFnSUNBdkx5QjBNU0E5SUVkc2IySmhiRk4wWVhSbFBGdHpkSEpwYm1jc0lIVnBiblEyTkN3Z1ltOXZiR1ZoYmwwK0tDa0tJQ0FnSUdKNWRHVmpJRGtnTHk4Z0luUXhJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZHNiMkpoYkMxemRHRjBaUzVoYkdkdkxuUnpPamN3Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1ME1TNTJZV3gxWlZzd1hTQTlQVDBnSjJobGJHeHZKeXdnSjFSMWNHeGxJSFpoYkhWbElITm9iM1ZzWkNCaVpTQnpaWFFuS1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCamIzWmxjaUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ1kyOTJaWElnTVFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSm9aV3hzYnlJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdWSFZ3YkdVZ2RtRnNkV1VnYzJodmRXeGtJR0psSUhObGRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkc2IySmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qY3hDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTUwTVM1MllXeDFaVnN4WFNBOVBUMGdNVEl6TENBblZIVndiR1VnZG1Gc2RXVWdjMmh2ZFd4a0lHSmxJSE5sZENjcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmRzYjJKaGJDMXpkR0YwWlM1aGJHZHZMblJ6T2pZd0NpQWdJQ0F2THlCME1TQTlJRWRzYjJKaGJGTjBZWFJsUEZ0emRISnBibWNzSUhWcGJuUTJOQ3dnWW05dmJHVmhibDArS0NrS0lDQWdJR0o1ZEdWaklEa2dMeThnSW5ReElnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkc2IySmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qY3hDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTUwTVM1MllXeDFaVnN4WFNBOVBUMGdNVEl6TENBblZIVndiR1VnZG1Gc2RXVWdjMmh2ZFd4a0lHSmxJSE5sZENjcENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHSjBiMmtLSUNBZ0lHbHVkR05mTXlBdkx5QXhNak1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1ZIVndiR1VnZG1Gc2RXVWdjMmh2ZFd4a0lHSmxJSE5sZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmRzYjJKaGJDMXpkR0YwWlM1aGJHZHZMblJ6T2pjeUNpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NTBNUzUyWVd4MVpWc3lYU0E5UFQwZ2RISjFaU3dnSjFSMWNHeGxJSFpoYkhWbElITm9iM1ZzWkNCaVpTQnpaWFFuS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5iRzlpWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem8yTUFvZ0lDQWdMeThnZERFZ1BTQkhiRzlpWVd4VGRHRjBaVHhiYzNSeWFXNW5MQ0IxYVc1ME5qUXNJR0p2YjJ4bFlXNWRQaWdwQ2lBZ0lDQmllWFJsWXlBNUlDOHZJQ0owTVNJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluYkc5aVlXd3RjM1JoZEdVdVlXeG5ieTUwY3pvM01nb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVkREV1ZG1Gc2RXVmJNbDBnUFQwOUlIUnlkV1VzSUNkVWRYQnNaU0IyWVd4MVpTQnphRzkxYkdRZ1ltVWdjMlYwSnlrS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQndkWE5vYVc1MElEZ3dDaUFnSUNCblpYUmlhWFFLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUZSMWNHeGxJSFpoYkhWbElITm9iM1ZzWkNCaVpTQnpaWFFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5iRzlpWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem8zTkFvZ0lDQWdMeThnZEdocGN5NTBNaTUyWVd4MVpTQTlJRnNuWVNjc0lGc25ZaWNzSURRMU5tNHNJSFJ5ZFdWZFhRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVlpSUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1JaUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaHBiblFnTmpjS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0Q2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlREF4WXpnS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTJOQW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdjSFZ6YUdsdWRDQTJOQW9nSUNBZ1lucGxjbThLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd3TVdNNENpQWdJQ0JpZkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjMlYwWW1sMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKaElnb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWVNJS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHbHVkQ0EwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlQW9nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUdOdmRtVnlJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURRS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmJHOWlZV3d0YzNSaGRHVXVZV3huYnk1MGN6bzJNUW9nSUNBZ0x5OGdkRElnUFNCSGJHOWlZV3hUZEdGMFpUeGJjM1J5YVc1bkxDQmJjM1J5YVc1bkxDQmlhV2QxYVc1MExDQmliMjlzWldGdVhWMCtLQ2tLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJblF5SWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmRzYjJKaGJDMXpkR0YwWlM1aGJHZHZMblJ6T2pjMENpQWdJQ0F2THlCMGFHbHpMblF5TG5aaGJIVmxJRDBnV3lkaEp5d2dXeWRpSnl3Z05EVTJiaXdnZEhKMVpWMWRDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjJ4dlltRnNMWE4wWVhSbExtRnNaMjh1ZEhNNk56VUtJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMblF5TG5aaGJIVmxXekJkSUQwOVBTQW5ZU2NzSUNkVWRYQnNaU0IyWVd4MVpTQnphRzkxYkdRZ1ltVWdjMlYwSnlrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaMnh2WW1Gc0xYTjBZWFJsTG1Gc1oyOHVkSE02TmpFS0lDQWdJQzh2SUhReUlEMGdSMnh2WW1Gc1UzUmhkR1U4VzNOMGNtbHVaeXdnVzNOMGNtbHVaeXdnWW1sbmRXbHVkQ3dnWW05dmJHVmhibDFkUGlncENpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKME1pSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmJHOWlZV3d0YzNSaGRHVXVZV3huYnk1MGN6bzNOUW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11ZERJdWRtRnNkV1ZiTUYwZ1BUMDlJQ2RoSnl3Z0oxUjFjR3hsSUhaaGJIVmxJSE5vYjNWc1pDQmlaU0J6WlhRbktRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmpiM1psY2lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR0o1ZEdWaklEUWdMeThnSW1FaUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRlIxY0d4bElIWmhiSFZsSUhOb2IzVnNaQ0JpWlNCelpYUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmJHOWlZV3d0YzNSaGRHVXVZV3huYnk1MGN6bzNOZ29nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11ZERJdWRtRnNkV1ZiTVYxYk1GMGdQVDA5SUNkaUp5d2dKMVIxY0d4bElIWmhiSFZsSUhOb2IzVnNaQ0JpWlNCelpYUW5LUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmJHOWlZV3d0YzNSaGRHVXVZV3huYnk1MGN6bzJNUW9nSUNBZ0x5OGdkRElnUFNCSGJHOWlZV3hUZEdGMFpUeGJjM1J5YVc1bkxDQmJjM1J5YVc1bkxDQmlhV2QxYVc1MExDQmliMjlzWldGdVhWMCtLQ2tLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJblF5SWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmRzYjJKaGJDMXpkR0YwWlM1aGJHZHZMblJ6T2pjMkNpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NTBNaTUyWVd4MVpWc3hYVnN3WFNBOVBUMGdKMkluTENBblZIVndiR1VnZG1Gc2RXVWdjMmh2ZFd4a0lHSmxJSE5sZENjcENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHTnZkbVZ5SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQmpiM1psY2lBeENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHTnZkbVZ5SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQmpiM1psY2lBeENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbUlpQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklGUjFjR3hsSUhaaGJIVmxJSE5vYjNWc1pDQmlaU0J6WlhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluYkc5aVlXd3RjM1JoZEdVdVlXeG5ieTUwY3pvM053b2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVkREl1ZG1Gc2RXVmJNVjFiTVYwZ1BUMDlJRFExTm00c0lDZFVkWEJzWlNCMllXeDFaU0J6YUc5MWJHUWdZbVVnYzJWMEp5a0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjJ4dlltRnNMWE4wWVhSbExtRnNaMjh1ZEhNNk5qRUtJQ0FnSUM4dklIUXlJRDBnUjJ4dlltRnNVM1JoZEdVOFczTjBjbWx1Wnl3Z1czTjBjbWx1Wnl3Z1ltbG5kV2x1ZEN3Z1ltOXZiR1ZoYmwxZFBpZ3BDaUFnSUNCaWVYUmxZeUEySUM4dklDSjBNaUlLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5iRzlpWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem8zTndvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdWRESXVkbUZzZFdWYk1WMWJNVjBnUFQwOUlEUTFObTRzSUNkVWRYQnNaU0IyWVd4MVpTQnphRzkxYkdRZ1ltVWdjMlYwSnlrS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1kyOTJaWElnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHTnZkbVZ5SURFS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ2NIVnphR2x1ZENBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd3TVdNNENpQWdJQ0JpUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJVZFhCc1pTQjJZV3gxWlNCemFHOTFiR1FnWW1VZ2MyVjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdloyeHZZbUZzTFhOMFlYUmxMbUZzWjI4dWRITTZOemdLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG5ReUxuWmhiSFZsV3pGZFd6SmRJRDA5UFNCMGNuVmxMQ0FuVkhWd2JHVWdkbUZzZFdVZ2MyaHZkV3hrSUdKbElITmxkQ2NwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZHNiMkpoYkMxemRHRjBaUzVoYkdkdkxuUnpPall4Q2lBZ0lDQXZMeUIwTWlBOUlFZHNiMkpoYkZOMFlYUmxQRnR6ZEhKcGJtY3NJRnR6ZEhKcGJtY3NJR0pwWjNWcGJuUXNJR0p2YjJ4bFlXNWRYVDRvS1FvZ0lDQWdZbmwwWldNZ05pQXZMeUFpZERJaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjJ4dlltRnNMWE4wWVhSbExtRnNaMjh1ZEhNNk56Z0tJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMblF5TG5aaGJIVmxXekZkV3pKZElEMDlQU0IwY25WbExDQW5WSFZ3YkdVZ2RtRnNkV1VnYzJodmRXeGtJR0psSUhObGRDY3BDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR052ZG1WeUlERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JqYjNabGNpQXhDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnY0hWemFHbHVkQ0ExTWpnS0lDQWdJR2RsZEdKcGRBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdWSFZ3YkdVZ2RtRnNkV1VnYzJodmRXeGtJR0psSUhObGRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkc2IySmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qZ3dDaUFnSUNBdkx5QjBhR2x6TG5RekxuWmhiSFZsSUQwZ2V5QmhPaUFuYUdWc2JHOG5MQ0JpT2lBeE1qTXNJR002SUhSeWRXVWdmUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlhR1ZzYkc4aUNpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pvWld4c2J5SUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR2x1ZENBeE1Rb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNVEl6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWaklEVWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluYkc5aVlXd3RjM1JoZEdVdVlXeG5ieTUwY3pvMk13b2dJQ0FnTHk4Z2RETWdQU0JIYkc5aVlXeFRkR0YwWlR4N0lHRTZJSE4wY21sdVp6c2dZam9nZFdsdWREWTBPeUJqT2lCaWIyOXNaV0Z1SUgwK0tDa0tJQ0FnSUdKNWRHVmpJREV3SUM4dklDSjBNeUlLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5iRzlpWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem80TUFvZ0lDQWdMeThnZEdocGN5NTBNeTUyWVd4MVpTQTlJSHNnWVRvZ0oyaGxiR3h2Snl3Z1lqb2dNVEl6TENCak9pQjBjblZsSUgwS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5iRzlpWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem80TVFvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdWRETXVkbUZzZFdVdVlTQTlQVDBnSjJobGJHeHZKeXdnSjA5aWFtVmpkQ0IyWVd4MVpTQnphRzkxYkdRZ1ltVWdjMlYwSnlrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaMnh2WW1Gc0xYTjBZWFJsTG1Gc1oyOHVkSE02TmpNS0lDQWdJQzh2SUhReklEMGdSMnh2WW1Gc1UzUmhkR1U4ZXlCaE9pQnpkSEpwYm1jN0lHSTZJSFZwYm5RMk5Ec2dZem9nWW05dmJHVmhiaUI5UGlncENpQWdJQ0JpZVhSbFl5QXhNQ0F2THlBaWRETWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdloyeHZZbUZzTFhOMFlYUmxMbUZzWjI4dWRITTZPREVLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG5RekxuWmhiSFZsTG1FZ1BUMDlJQ2RvWld4c2J5Y3NJQ2RQWW1wbFkzUWdkbUZzZFdVZ2MyaHZkV3hrSUdKbElITmxkQ2NwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdOdmRtVnlJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCamIzWmxjaUF4Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltaGxiR3h2SWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBZbXBsWTNRZ2RtRnNkV1VnYzJodmRXeGtJR0psSUhObGRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkc2IySmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qZ3lDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTUwTXk1MllXeDFaUzVpSUQwOVBTQXhNak1zSUNkUFltcGxZM1FnZG1Gc2RXVWdjMmh2ZFd4a0lHSmxJSE5sZENjcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmRzYjJKaGJDMXpkR0YwWlM1aGJHZHZMblJ6T2pZekNpQWdJQ0F2THlCME15QTlJRWRzYjJKaGJGTjBZWFJsUEhzZ1lUb2djM1J5YVc1bk95QmlPaUIxYVc1ME5qUTdJR002SUdKdmIyeGxZVzRnZlQ0b0tRb2dJQ0FnWW5sMFpXTWdNVEFnTHk4Z0luUXpJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZHNiMkpoYkMxemRHRjBaUzVoYkdkdkxuUnpPamd5Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1ME15NTJZV3gxWlM1aUlEMDlQU0F4TWpNc0lDZFBZbXBsWTNRZ2RtRnNkV1VnYzJodmRXeGtJR0psSUhObGRDY3BDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJSEIxYzJocGJuUWdPQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk15QXZMeUF4TWpNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMkpxWldOMElIWmhiSFZsSUhOb2IzVnNaQ0JpWlNCelpYUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmJHOWlZV3d0YzNSaGRHVXVZV3huYnk1MGN6bzRNd29nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11ZERNdWRtRnNkV1V1WXlBOVBUMGdkSEoxWlN3Z0owOWlhbVZqZENCMllXeDFaU0J6YUc5MWJHUWdZbVVnYzJWMEp5a0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjJ4dlltRnNMWE4wWVhSbExtRnNaMjh1ZEhNNk5qTUtJQ0FnSUM4dklIUXpJRDBnUjJ4dlltRnNVM1JoZEdVOGV5QmhPaUJ6ZEhKcGJtYzdJR0k2SUhWcGJuUTJORHNnWXpvZ1ltOXZiR1ZoYmlCOVBpZ3BDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QWlkRE1pQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaMnh2WW1Gc0xYTjBZWFJsTG1Gc1oyOHVkSE02T0RNS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxuUXpMblpoYkhWbExtTWdQVDA5SUhSeWRXVXNJQ2RQWW1wbFkzUWdkbUZzZFdVZ2MyaHZkV3hrSUdKbElITmxkQ2NwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ2NIVnphR2x1ZENBNE1Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQWW1wbFkzUWdkbUZzZFdVZ2MyaHZkV3hrSUdKbElITmxkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZHNiMkpoYkMxemRHRjBaUzVoYkdkdkxuUnpPamcxQ2lBZ0lDQXZMeUIwYUdsekxuUTBMblpoYkhWbElEMGdXeWRoSnl3Z2V5QmhPaUFuWWljc0lHSTZJRFExTm00c0lHTTZJSFJ5ZFdVZ2ZWMEtJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltSWlDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKaUlnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9hVzUwSURZM0NpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZUFvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd3TVdNNENpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdOalFLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJSEIxYzJocGJuUWdOalFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TURGak9Bb2dJQ0FnWW53S0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTWdOU0F2THlBd2VEQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSE5sZEdKcGRBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVlTSUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJR0o1ZEdWaklEUWdMeThnSW1FaUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaHBiblFnTkFvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGdLSUNBZ0lIVnVZMjkyWlhJZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCamIzWmxjaUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBMENpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0IxYm1OdmRtVnlJREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdloyeHZZbUZzTFhOMFlYUmxMbUZzWjI4dWRITTZOalFLSUNBZ0lDOHZJSFEwSUQwZ1IyeHZZbUZzVTNSaGRHVThXM04wY21sdVp5d2dleUJoT2lCemRISnBibWM3SUdJNklHSnBaM1ZwYm5RN0lHTTZJR0p2YjJ4bFlXNGdmVjArS0NrS0lDQWdJR0o1ZEdWaklEY2dMeThnSW5RMElnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkc2IySmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qZzFDaUFnSUNBdkx5QjBhR2x6TG5RMExuWmhiSFZsSUQwZ1d5ZGhKeXdnZXlCaE9pQW5ZaWNzSUdJNklEUTFObTRzSUdNNklIUnlkV1VnZlYwS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5iRzlpWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem80TmdvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdWREUXVkbUZzZFdWYk1GMGdQVDA5SUNkaEp5d2dKMVIxY0d4bElIWmhiSFZsSUhOb2IzVnNaQ0JpWlNCelpYUW5LUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmJHOWlZV3d0YzNSaGRHVXVZV3huYnk1MGN6bzJOQW9nSUNBZ0x5OGdkRFFnUFNCSGJHOWlZV3hUZEdGMFpUeGJjM1J5YVc1bkxDQjdJR0U2SUhOMGNtbHVaenNnWWpvZ1ltbG5kV2x1ZERzZ1l6b2dZbTl2YkdWaGJpQjlYVDRvS1FvZ0lDQWdZbmwwWldNZ055QXZMeUFpZERRaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjJ4dlltRnNMWE4wWVhSbExtRnNaMjh1ZEhNNk9EWUtJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMblEwTG5aaGJIVmxXekJkSUQwOVBTQW5ZU2NzSUNkVWRYQnNaU0IyWVd4MVpTQnphRzkxYkdRZ1ltVWdjMlYwSnlrS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1kyOTJaWElnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lIVnVZMjkyWlhJZ01Rb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0poSWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlVkWEJzWlNCMllXeDFaU0J6YUc5MWJHUWdZbVVnYzJWMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjJ4dlltRnNMWE4wWVhSbExtRnNaMjh1ZEhNNk9EY0tJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMblEwTG5aaGJIVmxXekZkTG1FZ1BUMDlJQ2RpSnl3Z0oxUjFjR3hsSUhaaGJIVmxJSE5vYjNWc1pDQmlaU0J6WlhRbktRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluYkc5aVlXd3RjM1JoZEdVdVlXeG5ieTUwY3pvMk5Bb2dJQ0FnTHk4Z2REUWdQU0JIYkc5aVlXeFRkR0YwWlR4YmMzUnlhVzVuTENCN0lHRTZJSE4wY21sdVp6c2dZam9nWW1sbmRXbHVkRHNnWXpvZ1ltOXZiR1ZoYmlCOVhUNG9LUW9nSUNBZ1lubDBaV01nTnlBdkx5QWlkRFFpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaMnh2WW1Gc0xYTjBZWFJsTG1Gc1oyOHVkSE02T0RjS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxuUTBMblpoYkhWbFd6RmRMbUVnUFQwOUlDZGlKeXdnSjFSMWNHeGxJSFpoYkhWbElITm9iM1ZzWkNCaVpTQnpaWFFuS1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCamIzWmxjaUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ1kyOTJaWElnTVFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCamIzWmxjaUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ1kyOTJaWElnTVFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmlJZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCVWRYQnNaU0IyWVd4MVpTQnphRzkxYkdRZ1ltVWdjMlYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaMnh2WW1Gc0xYTjBZWFJsTG1Gc1oyOHVkSE02T0RnS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxuUTBMblpoYkhWbFd6RmRMbUlnUFQwOUlEUTFObTRzSUNkVWRYQnNaU0IyWVd4MVpTQnphRzkxYkdRZ1ltVWdjMlYwSnlrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaMnh2WW1Gc0xYTjBZWFJsTG1Gc1oyOHVkSE02TmpRS0lDQWdJQzh2SUhRMElEMGdSMnh2WW1Gc1UzUmhkR1U4VzNOMGNtbHVaeXdnZXlCaE9pQnpkSEpwYm1jN0lHSTZJR0pwWjNWcGJuUTdJR002SUdKdmIyeGxZVzRnZlYwK0tDa0tJQ0FnSUdKNWRHVmpJRGNnTHk4Z0luUTBJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZHNiMkpoYkMxemRHRjBaUzVoYkdkdkxuUnpPamc0Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1ME5DNTJZV3gxWlZzeFhTNWlJRDA5UFNBME5UWnVMQ0FuVkhWd2JHVWdkbUZzZFdVZ2MyaHZkV3hrSUdKbElITmxkQ2NwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdOdmRtVnlJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCamIzWmxjaUF4Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUhCMWMyaHBiblFnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNREZqT0FvZ0lDQWdZajA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdWSFZ3YkdVZ2RtRnNkV1VnYzJodmRXeGtJR0psSUhObGRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkc2IySmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qZzVDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTUwTkM1MllXeDFaVnN4WFM1aklEMDlQU0IwY25WbExDQW5WSFZ3YkdVZ2RtRnNkV1VnYzJodmRXeGtJR0psSUhObGRDY3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkc2IySmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qWTBDaUFnSUNBdkx5QjBOQ0E5SUVkc2IySmhiRk4wWVhSbFBGdHpkSEpwYm1jc0lIc2dZVG9nYzNSeWFXNW5PeUJpT2lCaWFXZDFhVzUwT3lCak9pQmliMjlzWldGdUlIMWRQaWdwQ2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0owTkNJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluYkc5aVlXd3RjM1JoZEdVdVlXeG5ieTUwY3pvNE9Rb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVkRFF1ZG1Gc2RXVmJNVjB1WXlBOVBUMGdkSEoxWlN3Z0oxUjFjR3hsSUhaaGJIVmxJSE5vYjNWc1pDQmlaU0J6WlhRbktRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmpiM1psY2lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdZMjkyWlhJZ01Rb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJSEIxYzJocGJuUWdOVEk0Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklGUjFjR3hsSUhaaGJIVmxJSE5vYjNWc1pDQmlaU0J6WlhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluYkc5aVlXd3RjM1JoZEdVdVlXeG5ieTUwY3pvNU1Rb2dJQ0FnTHk4Z2RHaHBjeTUwTlM1MllXeDFaU0E5SUhzZ1lUb2dKMmhsYkd4dkp5d2dZam9nTVRJekxDQmpPaUIwY25WbExDQmtPaUJ1WlhjZ1lYSmpOQzVUZEhJb0oxZHZjbXhrSnlrZ2ZRb2dJQ0FnWW5sMFpXTWdNVEVnTHk4Z0lsZHZjbXhrSWdvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ1lubDBaV01nTVRFZ0x5OGdJbGR2Y214a0lnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSm9aV3hzYnlJS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbWhsYkd4dklnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9hVzUwSURFekNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZUFvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHTnZkbVZ5SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElERXpDaUFnSUNBckNpQWdJQ0JqYjNabGNpQXhDaUFnSUNCcGJuUmpYek1nTHk4Z01USXpDaUFnSUNCcGRHOWlDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWXlBMUlDOHZJREI0TURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2MyVjBZbWwwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjJ4dlltRnNMWE4wWVhSbExtRnNaMjh1ZEhNNk5qWUtJQ0FnSUM4dklIUTFJRDBnUjJ4dlltRnNVM1JoZEdVOFJHRjBZVDRvS1FvZ0lDQWdZbmwwWldNZ09DQXZMeUFpZERVaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjJ4dlltRnNMWE4wWVhSbExtRnNaMjh1ZEhNNk9URUtJQ0FnSUM4dklIUm9hWE11ZERVdWRtRnNkV1VnUFNCN0lHRTZJQ2RvWld4c2J5Y3NJR0k2SURFeU15d2dZem9nZEhKMVpTd2daRG9nYm1WM0lHRnlZelF1VTNSeUtDZFhiM0pzWkNjcElIMEtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluYkc5aVlXd3RjM1JoZEdVdVlXeG5ieTUwY3pvNU1nb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVkRFV1ZG1Gc2RXVXVZU0E5UFQwZ0oyaGxiR3h2Snl3Z0owMTFkR0ZpYkdVZ2IySnFaV04wSUhaaGJIVmxJSE5vYjNWc1pDQmlaU0J6WlhRbktRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluYkc5aVlXd3RjM1JoZEdVdVlXeG5ieTUwY3pvMk5nb2dJQ0FnTHk4Z2REVWdQU0JIYkc5aVlXeFRkR0YwWlR4RVlYUmhQaWdwQ2lBZ0lDQmllWFJsWXlBNElDOHZJQ0owTlNJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluYkc5aVlXd3RjM1JoZEdVdVlXeG5ieTUwY3pvNU1nb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVkRFV1ZG1Gc2RXVXVZU0E5UFQwZ0oyaGxiR3h2Snl3Z0owMTFkR0ZpYkdVZ2IySnFaV04wSUhaaGJIVmxJSE5vYjNWc1pDQmlaU0J6WlhRbktRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmpiM1psY2lBeENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNVEVLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYUdWc2JHOGlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUUxMWRHRmliR1VnYjJKcVpXTjBJSFpoYkhWbElITm9iM1ZzWkNCaVpTQnpaWFFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5iRzlpWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem81TXdvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdWREVXVkbUZzZFdVdVlpQTlQVDBnTVRJekxDQW5UWFYwWVdKc1pTQnZZbXBsWTNRZ2RtRnNkV1VnYzJodmRXeGtJR0psSUhObGRDY3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkc2IySmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qWTJDaUFnSUNBdkx5QjBOU0E5SUVkc2IySmhiRk4wWVhSbFBFUmhkR0UrS0NrS0lDQWdJR0o1ZEdWaklEZ2dMeThnSW5RMUlnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkc2IySmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qa3pDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTUwTlM1MllXeDFaUzVpSUQwOVBTQXhNak1zSUNkTmRYUmhZbXhsSUc5aWFtVmpkQ0IyWVd4MVpTQnphRzkxYkdRZ1ltVWdjMlYwSnlrS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1luUnZhUW9nSUNBZ2FXNTBZMTh6SUM4dklERXlNd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCTmRYUmhZbXhsSUc5aWFtVmpkQ0IyWVd4MVpTQnphRzkxYkdRZ1ltVWdjMlYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaMnh2WW1Gc0xYTjBZWFJsTG1Gc1oyOHVkSE02T1RRS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxuUTFMblpoYkhWbExtTWdQVDA5SUhSeWRXVXNJQ2ROZFhSaFlteGxJRzlpYW1WamRDQjJZV3gxWlNCemFHOTFiR1FnWW1VZ2MyVjBKeWtLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdloyeHZZbUZzTFhOMFlYUmxMbUZzWjI4dWRITTZOallLSUNBZ0lDOHZJSFExSUQwZ1IyeHZZbUZzVTNSaGRHVThSR0YwWVQ0b0tRb2dJQ0FnWW5sMFpXTWdPQ0F2THlBaWREVWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdloyeHZZbUZzTFhOMFlYUmxMbUZzWjI4dWRITTZPVFFLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG5RMUxuWmhiSFZsTG1NZ1BUMDlJSFJ5ZFdVc0lDZE5kWFJoWW14bElHOWlhbVZqZENCMllXeDFaU0J6YUc5MWJHUWdZbVVnYzJWMEp5a0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0J3ZFhOb2FXNTBJRGd3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFMTFkR0ZpYkdVZ2IySnFaV04wSUhaaGJIVmxJSE5vYjNWc1pDQmlaU0J6WlhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluYkc5aVlXd3RjM1JoZEdVdVlXeG5ieTUwY3pvNU5Rb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVkRFV1ZG1Gc2RXVXVaQzV1WVhScGRtVWdQVDA5SUNkWGIzSnNaQ2NzSUNkTmRYUmhZbXhsSUc5aWFtVmpkQ0IyWVd4MVpTQnphRzkxYkdRZ1ltVWdjMlYwSnlrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaMnh2WW1Gc0xYTjBZWFJsTG1Gc1oyOHVkSE02TmpZS0lDQWdJQzh2SUhRMUlEMGdSMnh2WW1Gc1UzUmhkR1U4UkdGMFlUNG9LUW9nSUNBZ1lubDBaV01nT0NBdkx5QWlkRFVpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaMnh2WW1Gc0xYTjBZWFJsTG1Gc1oyOHVkSE02T1RVS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxuUTFMblpoYkhWbExtUXVibUYwYVhabElEMDlQU0FuVjI5eWJHUW5MQ0FuVFhWMFlXSnNaU0J2WW1wbFkzUWdkbUZzZFdVZ2MyaHZkV3hrSUdKbElITmxkQ2NwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURFeENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWTI5MlpYSWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdOdmRtVnlJREVLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWW5sMFpXTWdNVEVnTHk4Z0lsZHZjbXhrSWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk5kWFJoWW14bElHOWlhbVZqZENCMllXeDFaU0J6YUc5MWJHUWdZbVVnYzJWMENpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjJ4dlltRnNMWE4wWVhSbExtRnNaMjh1ZEhNNk9sUmxjM1JVZFhCc1pTNWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdVb0tTQXRQaUIyYjJsa09ncGZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdVNkNpQWdJQ0JpSUY5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVjlpYkc5amEwQXdDZ3BmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVmZZbXh2WTJ0QU1Eb0tJQ0FnSUhKbGRITjFZZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQmlJRzFoYVc1ZllteHZZMnRBTUFvS2JXRnBibDlpYkc5amEwQXdPZ29nSUNBZ2NIVnphR2x1ZENBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFJQmV5WU1CV2hsYkd4dkFBRmlBZ0hJQVdFQkFBSjBNZ0owTkFKME5RSjBNUUowTXdWWGIzSnNaRUlBQUVJQUFERWJJaE5CQUNsQ0FBQTJHZ0NBQkJKVWQvVlBBWTRCQUFkQ0FBQkNBQUFBTVJraUVqRVlJaE1RUklnQUVrTC83REVaSWhJeEdDSVNFRVNJQXVBa1EwSUFBSWdBQWlSRFFnQUFLQlVXVndZQ0tGQ0JDeFpYQmdJcFR3RlFKUlpRSndVaUpGUlFUd0ZRSndsUEFXY2lKd2xsUkVraVdVNEJTUlZPQVU4Q1R3SlNWd0lBS0JKRUlpY0paVVFqZ1FoWUZ5VVNSQ0luQ1dWRWdWQlRKQkpFS2hVV1Z3WUNLbENCUXhaWEJnSXBUd0ZRS3hXQlFBNUVnVUN2SzZ0UUp3VWlKRlJRVHdGUUp3UVZGbGNHQWljRVVJRUVGbGNHQWlsUEFWQk9BVWtWZ1FRSUZsY0dBazhDVHdGUVR3RlFUd0ZRSndaUEFXY2lKd1psUkVraVdVNEJTU05aVHdGUEFrOENVbGNDQUNjRUVrUWlKd1psUkVraldVNEJTUlZPQVU4Q1R3SlNTU0paVGdGSkZVNEJUd0pQQWxKWEFnQXFFa1FpSndabFJFa2pXVTRCU1JWT0FVOENUd0pTSTRGQVdDdW9SQ0luQm1WRVNTTlpUZ0ZKRlU0QlR3SlBBbEtCa0FSVEpCSkVLQlVXVndZQ0tGQ0JDeFpYQmdJcFR3RlFKUlpRSndVaUpGUlFUd0ZRSndwUEFXY2lKd3BsUkVraVdVNEJTUlZPQVU4Q1R3SlNWd0lBS0JKRUlpY0taVVFqZ1FoWUZ5VVNSQ0luQ21WRWdWQlRKQkpFS2hVV1Z3WUNLbENCUXhaWEJnSXBUd0ZRS3hXQlFBNUVnVUN2SzZ0UUp3VWlKRlJRVHdGUUp3UVZGbGNHQWljRVVJRUVGbGNHQWlsUEFWQk9BVWtWZ1FRSUZsY0dBazhDVHdGUVR3RlFUd0ZRSndkUEFXY2lKd2RsUkVraVdVNEJTU05aVHdGUEFrOENVbGNDQUNjRUVrUWlKd2RsUkVraldVNEJTUlZPQVU4Q1R3SlNTU0paVGdGSkZVNEJUd0pQQWxKWEFnQXFFa1FpSndkbFJFa2pXVTRCU1JWT0FVOENUd0pTSTRGQVdDdW9SQ0luQjJWRVNTTlpUZ0ZKRlU0QlR3SlBBbEtCa0FSVEpCSkVKd3NWRmxjR0FpY0xVQ2dWRmxjR0FpaFFnUTBXVndZQ0tVOEJVRTRCU1JXQkRRaE9BU1VXVHdOUEFWQW5CU0lrVkZCUEFoWlhCZ0pRVHdGUVR3RlFKd2hQQVdjaUp3aGxSRWtpV1U0QlNZRUxXVThCVHdKUEFsSlhBZ0FvRWtRaUp3aGxSQ09CQ0ZnWEpSSkVJaWNJWlVTQlVGTWtFa1FpSndobFJFbUJDMWxPQVVrVlRnRlBBazhDVWxjQ0FDY0xFa1NKUWdBQWlRPT0iLCJjbGVhciI6IkMwSUFBSUVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
