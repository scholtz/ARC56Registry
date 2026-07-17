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

namespace Arc56.Generated.algorandfoundation.puya_ts.TupleBox_01e97ceb
{


    public class TupleBoxProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TupleBoxProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ObjectB8Ac7445 : AVMObjectType
            {
                public string A { get; set; }

                public byte[] B { get; set; }

                public bool C { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vA.From(A);
                    stringRef[ret.Count] = vA.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
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

                public static ObjectB8Ac7445 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new ObjectB8Ac7445();
                    uint count = 0;
                    var indexA = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vA.Decode(bytes.Skip(indexA + prefixOffset).ToArray());
                    var valueA = vA.ToValue();
                    if (valueA is string vAValue) { ret.A = vAValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vB.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueB = vB.ToValue();
                    if (valueB is byte[] vBValue) { ret.B = vBValue; }
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
                    return Equals(obj as ObjectB8Ac7445);
                }
                public bool Equals(ObjectB8Ac7445? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ObjectB8Ac7445 left, ObjectB8Ac7445 right)
                {
                    return EqualityComparer<ObjectB8Ac7445>.Default.Equals(left, right);
                }
                public static bool operator !=(ObjectB8Ac7445 left, ObjectB8Ac7445 right)
                {
                    return !(left == right);
                }

            }

            public class BoxMap2 : AVMObjectType
            {
                public string A { get; set; }

                public byte[] B { get; set; }

                public bool C { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vA.From(A);
                    stringRef[ret.Count] = vA.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
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

                public static BoxMap2 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new BoxMap2();
                    uint count = 0;
                    var indexA = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vA.Decode(bytes.Skip(indexA + prefixOffset).ToArray());
                    var valueA = vA.ToValue();
                    if (valueA is string vAValue) { ret.A = vAValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vB.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueB = vB.ToValue();
                    if (valueB is byte[] vBValue) { ret.B = vBValue; }
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
                    return Equals(obj as BoxMap2);
                }
                public bool Equals(BoxMap2? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(BoxMap2 left, BoxMap2 right)
                {
                    return EqualityComparer<BoxMap2>.Default.Equals(left, right);
                }
                public static bool operator !=(BoxMap2 left, BoxMap2 right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task TestBox(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 252, 25, 196, 110 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestBox_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 252, 25, 196, 110 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task TestBoxMap(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 159, 31, 24, 229 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestBoxMap_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 159, 31, 24, 229 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVHVwbGVCb3giLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiT2JqZWN0QjhBQzc0NDUiOlt7Im5hbWUiOiJhIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImIiLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoiYyIsInR5cGUiOiJib29sIn1dLCJCb3hNYXAyIjpbeyJuYW1lIjoiYSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJiIiwidHlwZSI6ImJ5dGVbXSJ9LHsibmFtZSI6ImMiLCJ0eXBlIjoiYm9vbCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJ0ZXN0Qm94IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RCb3hNYXAiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxOTUsMjUzLDM1NSw0MDZdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNaUExSURFZ05Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBaWRERWlJQ0owYlRGaElpQWlkRElpSUNKMGJUSmhJaUF3ZURBd01EVXdNREJqT0RBd01EQTFOamcyTlRaak5tTTJaakF3TURVM056Wm1OekkyWXpZMElDSm9aV3hzYnlJZ0luZHZjbXhrSWlBaWRHMHhZaUlnTUhnd01EQTFNREF3WVRBd01EQXdNell4TmpJMk16QXdNRE0yTkRZMU5qWWdJblJ0TW1JaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pveE56SUtJQ0FnSUM4dklHTnNZWE56SUZSMWNHeGxRbTk0SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFEa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VHWmpNVGxqTkRabElEQjRPV1l4WmpFNFpUVWdMeThnYldWMGFHOWtJQ0owWlhOMFFtOTRLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSjBaWE4wUW05NFRXRndLQ2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2dkR1Z6ZEVKdmVDQjBaWE4wUW05NFRXRndDaUFnSUNCbGNuSUtDbTFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURrNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pveE56SUtJQ0FnSUM4dklHTnNZWE56SUZSMWNHeGxRbTk0SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJQ1ltQ2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem82VkhWd2JHVkNiM2d1ZEdWemRFSnZlRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25SbGMzUkNiM2c2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem94TnpNS0lDQWdJQzh2SUdKdmVERWdQU0JDYjNnOFczTjBjbWx1Wnl3Z1lubDBaWE1zSUdKdmIyeGxZVzVkUGloN0lHdGxlVG9nSjNReEp5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkREVpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem94TnprS0lDQWdJQzh2SUhSb2FYTXVZbTk0TVM1amNtVmhkR1VvZXlCemFYcGxPaUF4TUNCOUtRb2dJQ0FnY0hWemFHbHVkQ0F4TUFvZ0lDQWdZbTk0WDJOeVpXRjBaUW9nSUNBZ2NHOXdDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3hOelFLSUNBZ0lDOHZJR0p2ZURJZ1BTQkNiM2c4ZXlCaE9pQnpkSEpwYm1jN0lHSTZJR0o1ZEdWek95QmpPaUJpYjI5c1pXRnVJSDArS0hzZ2EyVjVPaUFuZERJbklIMHBDaUFnSUNCaWVYUmxZMTh5SUM4dklDSjBNaUlLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPakU0TUFvZ0lDQWdMeThnZEdocGN5NWliM2d5TG1OeVpXRjBaU2g3SUhOcGVtVTZJREl3SUgwcENpQWdJQ0J3ZFhOb2FXNTBJREl3Q2lBZ0lDQmliM2hmWTNKbFlYUmxDaUFnSUNCd2IzQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qRTNNd29nSUNBZ0x5OGdZbTk0TVNBOUlFSnZlRHhiYzNSeWFXNW5MQ0JpZVhSbGN5d2dZbTl2YkdWaGJsMCtLSHNnYTJWNU9pQW5kREVuSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKME1TSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qRTRNUW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11WW05NE1TNXNaVzVuZEdnZ1BUMDlJREV3S1FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnY0c5d0NpQWdJQ0J3ZFhOb2FXNTBJREV3Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem94TnpNS0lDQWdJQzh2SUdKdmVERWdQU0JDYjNnOFczTjBjbWx1Wnl3Z1lubDBaWE1zSUdKdmIyeGxZVzVkUGloN0lHdGxlVG9nSjNReEp5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkREVpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem94T0RjS0lDQWdJQzh2SUhSb2FYTXVZbTk0TVM1MllXeDFaU0E5SUZzbmFHVnNiRzhuTENCQ2VYUmxjeWduZDI5eWJHUW5LU3dnZEhKMVpWMEtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNVGN6Q2lBZ0lDQXZMeUJpYjNneElEMGdRbTk0UEZ0emRISnBibWNzSUdKNWRHVnpMQ0JpYjI5c1pXRnVYVDRvZXlCclpYazZJQ2QwTVNjZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luUXhJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNVGczQ2lBZ0lDQXZMeUIwYUdsekxtSnZlREV1ZG1Gc2RXVWdQU0JiSjJobGJHeHZKeXdnUW5sMFpYTW9KM2R2Y214a0p5a3NJSFJ5ZFdWZENpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE1EQXdOVEF3TUdNNE1EQXdNRFUyT0RZMU5tTTJZelptTURBd05UYzNObVkzTWpaak5qUUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPakUzTXdvZ0lDQWdMeThnWW05NE1TQTlJRUp2ZUR4YmMzUnlhVzVuTENCaWVYUmxjeXdnWW05dmJHVmhibDArS0hzZ2EyVjVPaUFuZERFbklIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSjBNU0lLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPakU0T0FvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVltOTRNUzUyWVd4MVpWc3dYU0E5UFQwZ0oyaGxiR3h2SnlrS0lDQWdJR2x1ZEdOZk1TQXZMeUExQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem94TnpNS0lDQWdJQzh2SUdKdmVERWdQU0JDYjNnOFczTjBjbWx1Wnl3Z1lubDBaWE1zSUdKdmIyeGxZVzVkUGloN0lHdGxlVG9nSjNReEp5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkREVpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem94T0RnS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtSnZlREV1ZG1Gc2RXVmJNRjBnUFQwOUlDZG9aV3hzYnljcENpQWdJQ0JwYm5Salh6RWdMeThnTlFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR0o1ZEdWaklEVWdMeThnSW1obGJHeHZJZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNVGN6Q2lBZ0lDQXZMeUJpYjNneElEMGdRbTk0UEZ0emRISnBibWNzSUdKNWRHVnpMQ0JpYjI5c1pXRnVYVDRvZXlCclpYazZJQ2QwTVNjZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luUXhJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNVGc1Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1aWIzZ3hMblpoYkhWbFd6RmRMbVZ4ZFdGc2N5aENlWFJsY3lnbmQyOXliR1FuS1NrcENpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNVGN6Q2lBZ0lDQXZMeUJpYjNneElEMGdRbTk0UEZ0emRISnBibWNzSUdKNWRHVnpMQ0JpYjI5c1pXRnVYVDRvZXlCclpYazZJQ2QwTVNjZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luUXhJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNVGc1Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1aWIzZ3hMblpoYkhWbFd6RmRMbVZ4ZFdGc2N5aENlWFJsY3lnbmQyOXliR1FuS1NrcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmlkRzlwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk1UY3pDaUFnSUNBdkx5QmliM2d4SUQwZ1FtOTRQRnR6ZEhKcGJtY3NJR0o1ZEdWekxDQmliMjlzWldGdVhUNG9leUJyWlhrNklDZDBNU2NnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5ReElnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk1UZzVDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTVpYjNneExuWmhiSFZsV3pGZExtVnhkV0ZzY3loQ2VYUmxjeWduZDI5eWJHUW5LU2twQ2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbmR2Y214a0lnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk1UY3pDaUFnSUNBdkx5QmliM2d4SUQwZ1FtOTRQRnR6ZEhKcGJtY3NJR0o1ZEdWekxDQmliMjlzWldGdVhUNG9leUJyWlhrNklDZDBNU2NnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5ReElnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk1Ua3dDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTVpYjNneExuWmhiSFZsV3pKZEtRb2dJQ0FnYVc1MFkxOHpJQzh2SURRS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQ0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnY0hWemFHbHVkQ0F3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk1UYzBDaUFnSUNBdkx5QmliM2d5SUQwZ1FtOTRQSHNnWVRvZ2MzUnlhVzVuT3lCaU9pQmllWFJsY3pzZ1l6b2dZbTl2YkdWaGJpQjlQaWg3SUd0bGVUb2dKM1F5SnlCOUtRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWRESWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3hPVElLSUNBZ0lDOHZJSFJvYVhNdVltOTRNaTUyWVd4MVpTQTlJSHNnWVRvZ0oyaGxiR3h2Snl3Z1lqb2dRbmwwWlhNb0ozZHZjbXhrSnlrc0lHTTZJSFJ5ZFdVZ2ZRb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3hOelFLSUNBZ0lDOHZJR0p2ZURJZ1BTQkNiM2c4ZXlCaE9pQnpkSEpwYm1jN0lHSTZJR0o1ZEdWek95QmpPaUJpYjI5c1pXRnVJSDArS0hzZ2EyVjVPaUFuZERJbklIMHBDaUFnSUNCaWVYUmxZMTh5SUM4dklDSjBNaUlLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPakU0TndvZ0lDQWdMeThnZEdocGN5NWliM2d4TG5aaGJIVmxJRDBnV3lkb1pXeHNieWNzSUVKNWRHVnpLQ2QzYjNKc1pDY3BMQ0IwY25WbFhRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEQXdNRFV3TURCak9EQXdNREExTmpnMk5UWmpObU0yWmpBd01EVTNOelptTnpJMll6WTBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3hPVElLSUNBZ0lDOHZJSFJvYVhNdVltOTRNaTUyWVd4MVpTQTlJSHNnWVRvZ0oyaGxiR3h2Snl3Z1lqb2dRbmwwWlhNb0ozZHZjbXhrSnlrc0lHTTZJSFJ5ZFdVZ2ZRb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNVGMwQ2lBZ0lDQXZMeUJpYjNneUlEMGdRbTk0UEhzZ1lUb2djM1J5YVc1bk95QmlPaUJpZVhSbGN6c2dZem9nWW05dmJHVmhiaUI5UGloN0lHdGxlVG9nSjNReUp5QjlLUW9nSUNBZ1lubDBaV05mTWlBdkx5QWlkRElpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem94T1RNS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtSnZlREl1ZG1Gc2RXVXVZU0E5UFQwZ0oyaGxiR3h2SnlrS0lDQWdJR2x1ZEdOZk1TQXZMeUExQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem94TnpRS0lDQWdJQzh2SUdKdmVESWdQU0JDYjNnOGV5QmhPaUJ6ZEhKcGJtYzdJR0k2SUdKNWRHVnpPeUJqT2lCaWIyOXNaV0Z1SUgwK0tIc2dhMlY1T2lBbmRESW5JSDBwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0owTWlJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pFNU13b2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVZbTk0TWk1MllXeDFaUzVoSUQwOVBTQW5hR1ZzYkc4bktRb2dJQ0FnYVc1MFkxOHhJQzh2SURVS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKb1pXeHNieUlLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPakUzTkFvZ0lDQWdMeThnWW05NE1pQTlJRUp2ZUR4N0lHRTZJSE4wY21sdVp6c2dZam9nWW5sMFpYTTdJR002SUdKdmIyeGxZVzRnZlQ0b2V5QnJaWGs2SUNkME1pY2dmU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJblF5SWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TVRrMENpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NWliM2d5TG5aaGJIVmxMbUl1WlhGMVlXeHpLRUo1ZEdWektDZDNiM0pzWkNjcEtTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem94TnpRS0lDQWdJQzh2SUdKdmVESWdQU0JDYjNnOGV5QmhPaUJ6ZEhKcGJtYzdJR0k2SUdKNWRHVnpPeUJqT2lCaWIyOXNaV0Z1SUgwK0tIc2dhMlY1T2lBbmRESW5JSDBwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0owTWlJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pFNU5Bb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVZbTk0TWk1MllXeDFaUzVpTG1WeGRXRnNjeWhDZVhSbGN5Z25kMjl5YkdRbktTa3BDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JpZEc5cENpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdLd29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNVGMwQ2lBZ0lDQXZMeUJpYjNneUlEMGdRbTk0UEhzZ1lUb2djM1J5YVc1bk95QmlPaUJpZVhSbGN6c2dZem9nWW05dmJHVmhiaUI5UGloN0lHdGxlVG9nSjNReUp5QjlLUW9nSUNBZ1lubDBaV05mTWlBdkx5QWlkRElpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem94T1RRS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtSnZlREl1ZG1Gc2RXVXVZaTVsY1hWaGJITW9RbmwwWlhNb0ozZHZjbXhrSnlrcEtRb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKM2IzSnNaQ0lLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPakUzTkFvZ0lDQWdMeThnWW05NE1pQTlJRUp2ZUR4N0lHRTZJSE4wY21sdVp6c2dZam9nWW5sMFpYTTdJR002SUdKdmIyeGxZVzRnZlQ0b2V5QnJaWGs2SUNkME1pY2dmU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJblF5SWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TVRrMUNpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NWliM2d5TG5aaGJIVmxMbU1wQ2lBZ0lDQnBiblJqWHpNZ0x5OGdOQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQndkWE5vYVc1MElEQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem94TnpNS0lDQWdJQzh2SUdKdmVERWdQU0JDYjNnOFczTjBjbWx1Wnl3Z1lubDBaWE1zSUdKdmIyeGxZVzVkUGloN0lHdGxlVG9nSjNReEp5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkREVpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem94T1RjS0lDQWdJQzh2SUhSb2FYTXVZbTk0TVM1a1pXeGxkR1VvS1FvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pveE56TUtJQ0FnSUM4dklHSnZlREVnUFNCQ2IzZzhXM04wY21sdVp5d2dZbmwwWlhNc0lHSnZiMnhsWVc1ZFBpaDdJR3RsZVRvZ0ozUXhKeUI5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZERFaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pveE9UZ0tJQ0FnSUM4dklHRnpjMlZ5ZENnaGRHaHBjeTVpYjNneExtVjRhWE4wY3lrS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3hOelFLSUNBZ0lDOHZJR0p2ZURJZ1BTQkNiM2c4ZXlCaE9pQnpkSEpwYm1jN0lHSTZJR0o1ZEdWek95QmpPaUJpYjI5c1pXRnVJSDArS0hzZ2EyVjVPaUFuZERJbklIMHBDaUFnSUNCaWVYUmxZMTh5SUM4dklDSjBNaUlLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPakl3TUFvZ0lDQWdMeThnZEdocGN5NWliM2d5TG1SbGJHVjBaU2dwQ2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pFM05Bb2dJQ0FnTHk4Z1ltOTRNaUE5SUVKdmVEeDdJR0U2SUhOMGNtbHVaenNnWWpvZ1lubDBaWE03SUdNNklHSnZiMnhsWVc0Z2ZUNG9leUJyWlhrNklDZDBNaWNnZlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5ReUlnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk1qQXhDaUFnSUNBdkx5QmhjM05sY25Rb0lYUm9hWE11WW05NE1pNWxlR2x6ZEhNcENpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNVGM0Q2lBZ0lDQXZMeUIwWlhOMFFtOTRLQ2tnZXdvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPanBVZFhCc1pVSnZlQzUwWlhOMFFtOTRUV0Z3VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RHVnpkRUp2ZUUxaGNEb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qRTNOUW9nSUNBZ0x5OGdZbTk0VFdGd01TQTlJRUp2ZUUxaGNEeHpkSEpwYm1jc0lGdHpkSEpwYm1jc0lHSjVkR1Z6TENCaWIyOXNaV0Z1WFQ0b2V5QnJaWGxRY21WbWFYZzZJQ2QwYlRFbklIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjBiVEZoSWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TWpBMUNpQWdJQ0F2THlCaGMzTmxjblFvSVhSb2FYTXVZbTk0VFdGd01TZ25ZU2NwTG1WNGFYTjBjeWtLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pveE56WUtJQ0FnSUM4dklHSnZlRTFoY0RJZ1BTQkNiM2hOWVhBOGMzUnlhVzVuTENCQ2IzaE5ZWEF5UGloN0lHdGxlVkJ5WldacGVEb2dKM1J0TWljZ2ZTa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0luUnRNbUVpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem95TURZS0lDQWdJQzh2SUdGemMyVnlkQ2doZEdocGN5NWliM2hOWVhBeUtDZGhKeWt1WlhocGMzUnpLUW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pFM05Rb2dJQ0FnTHk4Z1ltOTRUV0Z3TVNBOUlFSnZlRTFoY0R4emRISnBibWNzSUZ0emRISnBibWNzSUdKNWRHVnpMQ0JpYjI5c1pXRnVYVDRvZXlCclpYbFFjbVZtYVhnNklDZDBiVEVuSUgwcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKMGJURmhJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNakE0Q2lBZ0lDQXZMeUIwYUdsekxtSnZlRTFoY0RFb0oyRW5LUzUyWVd4MVpTQTlJRnNuYUdWc2JHOG5MQ0JDZVhSbGN5Z25kMjl5YkdRbktTd2dkSEoxWlYwS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk1UYzFDaUFnSUNBdkx5QmliM2hOWVhBeElEMGdRbTk0VFdGd1BITjBjbWx1Wnl3Z1czTjBjbWx1Wnl3Z1lubDBaWE1zSUdKdmIyeGxZVzVkUGloN0lHdGxlVkJ5WldacGVEb2dKM1J0TVNjZ2ZTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0luUnRNV0VpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem95TURnS0lDQWdJQzh2SUhSb2FYTXVZbTk0VFdGd01TZ25ZU2NwTG5aaGJIVmxJRDBnV3lkb1pXeHNieWNzSUVKNWRHVnpLQ2QzYjNKc1pDY3BMQ0IwY25WbFhRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEQXdNRFV3TURCak9EQXdNREExTmpnMk5UWmpObU0yWmpBd01EVTNOelptTnpJMll6WTBDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem94TnpZS0lDQWdJQzh2SUdKdmVFMWhjRElnUFNCQ2IzaE5ZWEE4YzNSeWFXNW5MQ0JDYjNoTllYQXlQaWg3SUd0bGVWQnlaV1pwZURvZ0ozUnRNaWNnZlNrS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5SdE1tRWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3lNRGtLSUNBZ0lDOHZJSFJvYVhNdVltOTRUV0Z3TWlnbllTY3BMblpoYkhWbElEMGdleUJoT2lBbmFHVnNiRzhuTENCaU9pQkNlWFJsY3lnbmQyOXliR1FuS1N3Z1l6b2dkSEoxWlNCOUNpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qRTNOZ29nSUNBZ0x5OGdZbTk0VFdGd01pQTlJRUp2ZUUxaGNEeHpkSEpwYm1jc0lFSnZlRTFoY0RJK0tIc2dhMlY1VUhKbFptbDRPaUFuZEcweUp5QjlLUW9nSUNBZ1lubDBaV05mTXlBdkx5QWlkRzB5WVNJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pJd09Bb2dJQ0FnTHk4Z2RHaHBjeTVpYjNoTllYQXhLQ2RoSnlrdWRtRnNkV1VnUFNCYkoyaGxiR3h2Snl3Z1FubDBaWE1vSjNkdmNteGtKeWtzSUhSeWRXVmRDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjRNREF3TlRBd01HTTRNREF3TURVMk9EWTFObU0yWXpabU1EQXdOVGMzTm1ZM01qWmpOalFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPakl3T1FvZ0lDQWdMeThnZEdocGN5NWliM2hOWVhBeUtDZGhKeWt1ZG1Gc2RXVWdQU0I3SUdFNklDZG9aV3hzYnljc0lHSTZJRUo1ZEdWektDZDNiM0pzWkNjcExDQmpPaUIwY25WbElIMEtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPakUzTlFvZ0lDQWdMeThnWW05NFRXRndNU0E5SUVKdmVFMWhjRHh6ZEhKcGJtY3NJRnR6ZEhKcGJtY3NJR0o1ZEdWekxDQmliMjlzWldGdVhUNG9leUJyWlhsUWNtVm1hWGc2SUNkMGJURW5JSDBwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0owYlRGaElnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk1qRXdDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTVpYjNoTllYQXhLQ2RoSnlrdVpYaHBjM1J6S1FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPakUzTlFvZ0lDQWdMeThnWW05NFRXRndNU0E5SUVKdmVFMWhjRHh6ZEhKcGJtY3NJRnR6ZEhKcGJtY3NJR0o1ZEdWekxDQmliMjlzWldGdVhUNG9leUJyWlhsUWNtVm1hWGc2SUNkMGJURW5JSDBwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0owYlRGaElnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk1qRXlDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTVpYjNoTllYQXhLQ2RoSnlrdWRtRnNkV1ZiTUYwZ1BUMDlJQ2RvWld4c2J5Y3BDaUFnSUNCcGJuUmpYekVnTHk4Z05Rb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmlkRzlwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk1UYzFDaUFnSUNBdkx5QmliM2hOWVhBeElEMGdRbTk0VFdGd1BITjBjbWx1Wnl3Z1czTjBjbWx1Wnl3Z1lubDBaWE1zSUdKdmIyeGxZVzVkUGloN0lHdGxlVkJ5WldacGVEb2dKM1J0TVNjZ2ZTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0luUnRNV0VpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem95TVRJS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtSnZlRTFoY0RFb0oyRW5LUzUyWVd4MVpWc3dYU0E5UFQwZ0oyaGxiR3h2SnlrS0lDQWdJR2x1ZEdOZk1TQXZMeUExQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpYUdWc2JHOGlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3hOelVLSUNBZ0lDOHZJR0p2ZUUxaGNERWdQU0JDYjNoTllYQThjM1J5YVc1bkxDQmJjM1J5YVc1bkxDQmllWFJsY3l3Z1ltOXZiR1ZoYmwwK0tIc2dhMlY1VUhKbFptbDRPaUFuZEcweEp5QjlLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlkRzB4WVNJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pJeE13b2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVZbTk0VFdGd01TZ25ZU2NwTG5aaGJIVmxXekZkTG1WeGRXRnNjeWhDZVhSbGN5Z25kMjl5YkdRbktTa3BDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TVRjMUNpQWdJQ0F2THlCaWIzaE5ZWEF4SUQwZ1FtOTRUV0Z3UEhOMGNtbHVaeXdnVzNOMGNtbHVaeXdnWW5sMFpYTXNJR0p2YjJ4bFlXNWRQaWg3SUd0bGVWQnlaV1pwZURvZ0ozUnRNU2NnZlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5SdE1XRWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3lNVE1LSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1KdmVFMWhjREVvSjJFbktTNTJZV3gxWlZzeFhTNWxjWFZoYkhNb1FubDBaWE1vSjNkdmNteGtKeWtwS1FvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1luUnZhUW9nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUNzS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pFM05Rb2dJQ0FnTHk4Z1ltOTRUV0Z3TVNBOUlFSnZlRTFoY0R4emRISnBibWNzSUZ0emRISnBibWNzSUdKNWRHVnpMQ0JpYjI5c1pXRnVYVDRvZXlCclpYbFFjbVZtYVhnNklDZDBiVEVuSUgwcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKMGJURmhJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNakV6Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1aWIzaE5ZWEF4S0NkaEp5a3VkbUZzZFdWYk1WMHVaWEYxWVd4ektFSjVkR1Z6S0NkM2IzSnNaQ2NwS1NrS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdZbmwwWldNZ05pQXZMeUFpZDI5eWJHUWlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3hOelVLSUNBZ0lDOHZJR0p2ZUUxaGNERWdQU0JDYjNoTllYQThjM1J5YVc1bkxDQmJjM1J5YVc1bkxDQmllWFJsY3l3Z1ltOXZiR1ZoYmwwK0tIc2dhMlY1VUhKbFptbDRPaUFuZEcweEp5QjlLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlkRzB4WVNJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pJeE5Bb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVZbTk0VFdGd01TZ25ZU2NwTG5aaGJIVmxXekpkS1FvZ0lDQWdhVzUwWTE4eklDOHZJRFFLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCaWIzaGZaWGgwY21GamRDQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdjSFZ6YUdsdWRDQXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TVRjMkNpQWdJQ0F2THlCaWIzaE5ZWEF5SUQwZ1FtOTRUV0Z3UEhOMGNtbHVaeXdnUW05NFRXRndNajRvZXlCclpYbFFjbVZtYVhnNklDZDBiVEluSUgwcENpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKMGJUSmhJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNakUzQ2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1aWIzaE5ZWEF5S0NkaEp5a3VkbUZzZFdVdVlTQTlQVDBnSjJobGJHeHZKeWtLSUNBZ0lHbHVkR05mTVNBdkx5QTFDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQXJDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3hOellLSUNBZ0lDOHZJR0p2ZUUxaGNESWdQU0JDYjNoTllYQThjM1J5YVc1bkxDQkNiM2hOWVhBeVBpaDdJR3RsZVZCeVpXWnBlRG9nSjNSdE1pY2dmU2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJblJ0TW1FaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pveU1UY0tJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbUp2ZUUxaGNESW9KMkVuS1M1MllXeDFaUzVoSUQwOVBTQW5hR1ZzYkc4bktRb2dJQ0FnYVc1MFkxOHhJQzh2SURVS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKb1pXeHNieUlLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPakUzTmdvZ0lDQWdMeThnWW05NFRXRndNaUE5SUVKdmVFMWhjRHh6ZEhKcGJtY3NJRUp2ZUUxaGNESStLSHNnYTJWNVVISmxabWw0T2lBbmRHMHlKeUI5S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpZEcweVlTSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qSXhPQW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11WW05NFRXRndNaWduWVNjcExuWmhiSFZsTG1JdVpYRjFZV3h6S0VKNWRHVnpLQ2QzYjNKc1pDY3BLU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pveE56WUtJQ0FnSUM4dklHSnZlRTFoY0RJZ1BTQkNiM2hOWVhBOGMzUnlhVzVuTENCQ2IzaE5ZWEF5UGloN0lHdGxlVkJ5WldacGVEb2dKM1J0TWljZ2ZTa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0luUnRNbUVpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem95TVRnS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtSnZlRTFoY0RJb0oyRW5LUzUyWVd4MVpTNWlMbVZ4ZFdGc2N5aENlWFJsY3lnbmQyOXliR1FuS1NrcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmlkRzlwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk1UYzJDaUFnSUNBdkx5QmliM2hOWVhBeUlEMGdRbTk0VFdGd1BITjBjbWx1Wnl3Z1FtOTRUV0Z3TWo0b2V5QnJaWGxRY21WbWFYZzZJQ2QwYlRJbklIMHBDaUFnSUNCaWVYUmxZMTh6SUM4dklDSjBiVEpoSWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TWpFNENpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NWliM2hOWVhBeUtDZGhKeWt1ZG1Gc2RXVXVZaTVsY1hWaGJITW9RbmwwWlhNb0ozZHZjbXhrSnlrcEtRb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKM2IzSnNaQ0lLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPakUzTmdvZ0lDQWdMeThnWW05NFRXRndNaUE5SUVKdmVFMWhjRHh6ZEhKcGJtY3NJRUp2ZUUxaGNESStLSHNnYTJWNVVISmxabWw0T2lBbmRHMHlKeUI5S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpZEcweVlTSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qSXhPUW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11WW05NFRXRndNaWduWVNjcExuWmhiSFZsTG1NcENpQWdJQ0JwYm5Salh6TWdMeThnTkFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lHSnZlRjlsZUhSeVlXTjBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0J3ZFhOb2FXNTBJREFLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pveE56VUtJQ0FnSUM4dklHSnZlRTFoY0RFZ1BTQkNiM2hOWVhBOGMzUnlhVzVuTENCYmMzUnlhVzVuTENCaWVYUmxjeXdnWW05dmJHVmhibDArS0hzZ2EyVjVVSEpsWm1sNE9pQW5kRzB4SnlCOUtRb2dJQ0FnWW5sMFpXTWdOeUF2THlBaWRHMHhZaUlLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPakl5TVFvZ0lDQWdMeThnZEdocGN5NWliM2hOWVhBeEtDZGlKeWt1ZG1Gc2RXVWdQU0JiSjJGaVl5Y3NJRUo1ZEdWektDZGtaV1luS1N3Z1ptRnNjMlZkQ2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pFM05Rb2dJQ0FnTHk4Z1ltOTRUV0Z3TVNBOUlFSnZlRTFoY0R4emRISnBibWNzSUZ0emRISnBibWNzSUdKNWRHVnpMQ0JpYjI5c1pXRnVYVDRvZXlCclpYbFFjbVZtYVhnNklDZDBiVEVuSUgwcENpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKMGJURmlJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNakl4Q2lBZ0lDQXZMeUIwYUdsekxtSnZlRTFoY0RFb0oySW5LUzUyWVd4MVpTQTlJRnNuWVdKakp5d2dRbmwwWlhNb0oyUmxaaWNwTENCbVlXeHpaVjBLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdNSGd3TURBMU1EQXdZVEF3TURBd016WXhOakkyTXpBd01ETTJORFkxTmpZS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qRTNOZ29nSUNBZ0x5OGdZbTk0VFdGd01pQTlJRUp2ZUUxaGNEeHpkSEpwYm1jc0lFSnZlRTFoY0RJK0tIc2dhMlY1VUhKbFptbDRPaUFuZEcweUp5QjlLUW9nSUNBZ1lubDBaV01nT1NBdkx5QWlkRzB5WWlJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pJeU5Bb2dJQ0FnTHk4Z2RHaHBjeTVpYjNoTllYQXlLQ2RpSnlrdWRtRnNkV1VnUFNCN0lHRTZJQ2RoWW1NbkxDQmlPaUJDZVhSbGN5Z25aR1ZtSnlrc0lHTTZJR1poYkhObElIMEtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNVGMyQ2lBZ0lDQXZMeUJpYjNoTllYQXlJRDBnUW05NFRXRndQSE4wY21sdVp5d2dRbTk0VFdGd01qNG9leUJyWlhsUWNtVm1hWGc2SUNkMGJUSW5JSDBwQ2lBZ0lDQmllWFJsWXlBNUlDOHZJQ0owYlRKaUlnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk1qSXhDaUFnSUNBdkx5QjBhR2x6TG1KdmVFMWhjREVvSjJJbktTNTJZV3gxWlNBOUlGc25ZV0pqSnl3Z1FubDBaWE1vSjJSbFppY3BMQ0JtWVd4elpWMEtJQ0FnSUdKNWRHVmpJRGdnTHk4Z01IZ3dNREExTURBd1lUQXdNREF3TXpZeE5qSTJNekF3TURNMk5EWTFOallLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPakl5TkFvZ0lDQWdMeThnZEdocGN5NWliM2hOWVhBeUtDZGlKeWt1ZG1Gc2RXVWdQU0I3SUdFNklDZGhZbU1uTENCaU9pQkNlWFJsY3lnblpHVm1KeWtzSUdNNklHWmhiSE5sSUgwS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qRTNOUW9nSUNBZ0x5OGdZbTk0VFdGd01TQTlJRUp2ZUUxaGNEeHpkSEpwYm1jc0lGdHpkSEpwYm1jc0lHSjVkR1Z6TENCaWIyOXNaV0Z1WFQ0b2V5QnJaWGxRY21WbWFYZzZJQ2QwYlRFbklIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjBiVEZoSWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TWpJM0NpQWdJQ0F2THlCMGFHbHpMbUp2ZUUxaGNERW9KMkVuS1M1a1pXeGxkR1VvS1FvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pveE56VUtJQ0FnSUM4dklHSnZlRTFoY0RFZ1BTQkNiM2hOWVhBOGMzUnlhVzVuTENCYmMzUnlhVzVuTENCaWVYUmxjeXdnWW05dmJHVmhibDArS0hzZ2EyVjVVSEpsWm1sNE9pQW5kRzB4SnlCOUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWRHMHhZU0lLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPakl5T0FvZ0lDQWdMeThnWVhOelpYSjBLQ0YwYUdsekxtSnZlRTFoY0RFb0oyRW5LUzVsZUdsemRITXBDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TVRjMkNpQWdJQ0F2THlCaWIzaE5ZWEF5SUQwZ1FtOTRUV0Z3UEhOMGNtbHVaeXdnUW05NFRXRndNajRvZXlCclpYbFFjbVZtYVhnNklDZDBiVEluSUgwcENpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKMGJUSmhJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNak13Q2lBZ0lDQXZMeUIwYUdsekxtSnZlRTFoY0RJb0oyRW5LUzVrWld4bGRHVW9LUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem94TnpZS0lDQWdJQzh2SUdKdmVFMWhjRElnUFNCQ2IzaE5ZWEE4YzNSeWFXNW5MQ0JDYjNoTllYQXlQaWg3SUd0bGVWQnlaV1pwZURvZ0ozUnRNaWNnZlNrS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5SdE1tRWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3lNekVLSUNBZ0lDOHZJR0Z6YzJWeWRDZ2hkR2hwY3k1aWIzaE5ZWEF5S0NkaEp5a3VaWGhwYzNSektRb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPakl3TkFvZ0lDQWdMeThnZEdWemRFSnZlRTFoY0NncElIc0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQWdVQkJDWUtBblF4QkhSdE1XRUNkRElFZEcweVlSTUFCUUFNZ0FBRmFHVnNiRzhBQlhkdmNteGtCV2hsYkd4dkJYZHZjbXhrQkhSdE1XSVBBQVVBQ2dBQUEyRmlZd0FEWkdWbUJIUnRNbUl4RzBFQUhURVpGRVF4R0VTQ0FnVDhHY1J1Qko4ZkdPVTJHZ0NPQWdBSkFLSUFNUmtVTVJnVUVFTW9nUXE1U0NxQkZMbElLTDFJZ1FvU1JDaThTQ2duQkw4b0l5SzZGeUlJS0NOUEFycFhBZ0FuQlJKRUtDSkp1aGNvU3dFaXVoY2lDQ2hPQXJwWEFnQW5CaEpFS0NVa3VvRUFVMFFxdkVncUp3Uy9LaU1pdWhjaUNDb2pUd0s2VndJQUp3VVNSQ29pU2JvWEtrc0JJcm9YSWdncVRnSzZWd0lBSndZU1JDb2xKTHFCQUZORUtMeElLTDFGQVJSRUtyeElLcjFGQVJSRUpFTXB2VVVCRkVRcnZVVUJGRVFwdkVncEp3Uy9LN3hJS3ljRXZ5bTlSUUZFS1NNaXVoY2lDQ2tqVHdLNlZ3SUFKd1VTUkNraVNib1hLVXNCSXJvWElnZ3BUZ0s2VndJQUp3WVNSQ2tsSkxxQkFGTkVLeU1pdWhjaUNDc2pUd0s2VndJQUp3VVNSQ3NpU2JvWEswc0JJcm9YSWdnclRnSzZWd0lBSndZU1JDc2xKTHFCQUZORUp3ZThTQ2NISndpL0p3bThTQ2NKSndpL0tieElLYjFGQVJSRUs3eElLNzFGQVJSRUpFTT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
