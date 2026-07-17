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

namespace Arc56.Generated.algorandfoundation.puya_ts.TestTuple_d6dea59b
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVGVzdFR1cGxlIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7Ik9iamVjdDNEQjg4RkZEIjpbeyJuYW1lIjoiYSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJiIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImMiLCJ0eXBlIjoiYm9vbCJ9XSwiRGF0YSI6W3sibmFtZSI6ImEiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiYiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJkIiwidHlwZSI6InN0cmluZyJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJ0ZXN0VHVwbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjo1fSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0TURBd1lqQXdNREF3TURBd01EQXdNREF3TjJJNE1EQXdNRFUyT0RZMU5tTTJZelptSURCNE1EQXdOREF3TURjd01EQXhOakV3TURRek1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBeFl6ZzRNREF3TURFMk1nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkc2IySmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qVTVDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVkdWemRGUjFjR3hsSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFEVUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERXlOVFEzTjJZMUlDOHZJRzFsZEdodlpDQWlkR1Z6ZEZSMWNHeGxLQ2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5MFpYTjBWSFZ3YkdWZmNtOTFkR1ZBTXdvZ0lDQWdaWEp5Q2dwdFlXbHVYM1JsYzNSVWRYQnNaVjl5YjNWMFpVQXpPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZHNiMkpoYkMxemRHRjBaUzVoYkdkdkxuUnpPalk0Q2lBZ0lDQXZMeUIwWlhOMFZIVndiR1VvS1NCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0ppWUtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZHNiMkpoYkMxemRHRjBaUzVoYkdkdkxuUnpPall3Q2lBZ0lDQXZMeUIwTVNBOUlFZHNiMkpoYkZOMFlYUmxQRnR6ZEhKcGJtY3NJSFZwYm5RMk5Dd2dZbTl2YkdWaGJsMCtLQ2tLSUNBZ0lIQjFjMmhpZVhSbGN5QWlkREVpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaMnh2WW1Gc0xYTjBZWFJsTG1Gc1oyOHVkSE02TmprS0lDQWdJQzh2SUhSb2FYTXVkREV1ZG1Gc2RXVWdQU0JiSjJobGJHeHZKeXdnTVRJekxDQjBjblZsWFFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBd01HSXdNREF3TURBd01EQXdNREF3TURkaU9EQXdNREExTmpnMk5UWmpObU0yWmdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluYkc5aVlXd3RjM1JoZEdVdVlXeG5ieTUwY3pvMk1Rb2dJQ0FnTHk4Z2RESWdQU0JIYkc5aVlXeFRkR0YwWlR4YmMzUnlhVzVuTENCYmMzUnlhVzVuTENCaWFXZDFhVzUwTENCaWIyOXNaV0Z1WFYwK0tDa0tJQ0FnSUhCMWMyaGllWFJsY3lBaWRESWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdloyeHZZbUZzTFhOMFlYUmxMbUZzWjI4dWRITTZOelFLSUNBZ0lDOHZJSFJvYVhNdWRESXVkbUZzZFdVZ1BTQmJKMkVuTENCYkoySW5MQ0EwTlRadUxDQjBjblZsWFYwS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01EQTBNREF3TnpBd01ERTJNVEF3TkRNd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURGak9EZ3dNREF3TVRZeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkc2IySmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qWXpDaUFnSUNBdkx5QjBNeUE5SUVkc2IySmhiRk4wWVhSbFBIc2dZVG9nYzNSeWFXNW5PeUJpT2lCMWFXNTBOalE3SUdNNklHSnZiMnhsWVc0Z2ZUNG9LUW9nSUNBZ2NIVnphR0o1ZEdWeklDSjBNeUlLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5iRzlpWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem8yT1FvZ0lDQWdMeThnZEdocGN5NTBNUzUyWVd4MVpTQTlJRnNuYUdWc2JHOG5MQ0F4TWpNc0lIUnlkV1ZkQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURBd1lqQXdNREF3TURBd01EQXdNREF3TjJJNE1EQXdNRFUyT0RZMU5tTTJZelptQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaMnh2WW1Gc0xYTjBZWFJsTG1Gc1oyOHVkSE02T0RBS0lDQWdJQzh2SUhSb2FYTXVkRE11ZG1Gc2RXVWdQU0I3SUdFNklDZG9aV3hzYnljc0lHSTZJREV5TXl3Z1l6b2dkSEoxWlNCOUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkc2IySmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qWTBDaUFnSUNBdkx5QjBOQ0E5SUVkc2IySmhiRk4wWVhSbFBGdHpkSEpwYm1jc0lIc2dZVG9nYzNSeWFXNW5PeUJpT2lCaWFXZDFhVzUwT3lCak9pQmliMjlzWldGdUlIMWRQaWdwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJblEwSWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmRzYjJKaGJDMXpkR0YwWlM1aGJHZHZMblJ6T2pjMENpQWdJQ0F2THlCMGFHbHpMblF5TG5aaGJIVmxJRDBnV3lkaEp5d2dXeWRpSnl3Z05EVTJiaXdnZEhKMVpWMWRDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREF3TkRBd01EY3dNREF4TmpFd01EUXpNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXhZemc0TURBd01ERTJNZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZHNiMkpoYkMxemRHRjBaUzVoYkdkdkxuUnpPamcxQ2lBZ0lDQXZMeUIwYUdsekxuUTBMblpoYkhWbElEMGdXeWRoSnl3Z2V5QmhPaUFuWWljc0lHSTZJRFExTm00c0lHTTZJSFJ5ZFdVZ2ZWMEtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdloyeHZZbUZzTFhOMFlYUmxMbUZzWjI4dWRITTZOallLSUNBZ0lDOHZJSFExSUQwZ1IyeHZZbUZzVTNSaGRHVThSR0YwWVQ0b0tRb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBaWREVWlJREI0TURBd1pEQXdNREF3TURBd01EQXdNREF3TjJJNE1EQXdNVFF3TURBMU5qZzJOVFpqTm1NMlpqQXdNRFUxTnpabU56STJZelkwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaMnh2WW1Gc0xYTjBZWFJsTG1Gc1oyOHVkSE02T1RFS0lDQWdJQzh2SUhSb2FYTXVkRFV1ZG1Gc2RXVWdQU0I3SUdFNklDZG9aV3hzYnljc0lHSTZJREV5TXl3Z1l6b2dkSEoxWlN3Z1pEb2dibVYzSUdGeVl6UXVVM1J5S0NkWGIzSnNaQ2NwSUgwS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjJ4dlltRnNMWE4wWVhSbExtRnNaMjh1ZEhNNk5qZ0tJQ0FnSUM4dklIUmxjM1JVZFhCc1pTZ3BJSHNLSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgxOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlVBMU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkc2IySmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qVTVDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVkdWemRGUjFjR3hsSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJQ1ltQ2lBZ0lDQnlaWFIxY200SyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5WUNFZ0FMQUFBQUFBQUFBSHVBQUFWb1pXeHNiMDBBQkFBSEFBRmhBRU1BQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUhJZ0FBQllqRWJRUUJTZ0FRU1ZIZjFOaG9BamdFQUFRQXhHUlF4R0JCRWdBSjBNU2huZ0FKME1pbG5nQUowTXlobmdBSjBOQ2xuZ2dJQ2REVWJBQTBBQUFBQUFBQUFlNEFBRkFBRmFHVnNiRzhBQlZkdmNteGtaNEVCUXpFWkZERVlGQkJEIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
