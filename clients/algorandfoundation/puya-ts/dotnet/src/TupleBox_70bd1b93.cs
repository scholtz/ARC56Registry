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

namespace Arc56.Generated.algorandfoundation.puya_ts.TupleBox_70bd1b93
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVHVwbGVCb3giLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiT2JqZWN0QjhBQzc0NDUiOlt7Im5hbWUiOiJhIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImIiLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoiYyIsInR5cGUiOiJib29sIn1dLCJCb3hNYXAyIjpbeyJuYW1lIjoiYSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJiIiwidHlwZSI6ImJ5dGVbXSJ9LHsibmFtZSI6ImMiLCJ0eXBlIjoiYm9vbCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJ0ZXN0Qm94IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RCb3hNYXAiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxOTQsMjQ1LDM1OCw0MTZdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNaUExSURFZ05Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBaWRHMHhZU0lnSW5ReElpQWlkRzB5WVNJZ0luUXlJaUF3ZURBd01EVXdNREJqT0RBd01EQTFOamcyTlRaak5tTTJaakF3TURVM056Wm1OekkyWXpZMElDSm9aV3hzYnlJZ0luZHZjbXhrSWlBaWRHMHhZaUlnTUhnd01EQTFNREF3WVRBd01EQXdNell4TmpJMk16QXdNRE0yTkRZMU5qWWdJblJ0TW1JaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pveE56SUtJQ0FnSUM4dklHTnNZWE56SUZSMWNHeGxRbTk0SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFEa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VHWmpNVGxqTkRabElEQjRPV1l4WmpFNFpUVWdMeThnYldWMGFHOWtJQ0owWlhOMFFtOTRLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSjBaWE4wUW05NFRXRndLQ2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5MFpYTjBRbTk0WDNKdmRYUmxRRFFnYldGcGJsOTBaWE4wUW05NFRXRndYM0p2ZFhSbFFEVUtJQ0FnSUdWeWNnb0tiV0ZwYmw5MFpYTjBRbTk0VFdGd1gzSnZkWFJsUURVNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pveE56VUtJQ0FnSUM4dklHSnZlRTFoY0RFZ1BTQkNiM2hOWVhBOGMzUnlhVzVuTENCYmMzUnlhVzVuTENCaWVYUmxjeXdnWW05dmJHVmhibDArS0hzZ2EyVjVVSEpsWm1sNE9pQW5kRzB4SnlCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWRHMHhZU0lLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPakl3TlFvZ0lDQWdMeThnWVhOelpYSjBLQ0YwYUdsekxtSnZlRTFoY0RFb0oyRW5LUzVsZUdsemRITXBDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TVRjMkNpQWdJQ0F2THlCaWIzaE5ZWEF5SUQwZ1FtOTRUV0Z3UEhOMGNtbHVaeXdnUW05NFRXRndNajRvZXlCclpYbFFjbVZtYVhnNklDZDBiVEluSUgwcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKMGJUSmhJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNakEyQ2lBZ0lDQXZMeUJoYzNObGNuUW9JWFJvYVhNdVltOTRUV0Z3TWlnbllTY3BMbVY0YVhOMGN5a0tJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem94TnpVS0lDQWdJQzh2SUdKdmVFMWhjREVnUFNCQ2IzaE5ZWEE4YzNSeWFXNW5MQ0JiYzNSeWFXNW5MQ0JpZVhSbGN5d2dZbTl2YkdWaGJsMCtLSHNnYTJWNVVISmxabWw0T2lBbmRHMHhKeUI5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZEcweFlTSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qSXdPQW9nSUNBZ0x5OGdkR2hwY3k1aWIzaE5ZWEF4S0NkaEp5a3VkbUZzZFdVZ1BTQmJKMmhsYkd4dkp5d2dRbmwwWlhNb0ozZHZjbXhrSnlrc0lIUnlkV1ZkQ2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pFM05Rb2dJQ0FnTHk4Z1ltOTRUV0Z3TVNBOUlFSnZlRTFoY0R4emRISnBibWNzSUZ0emRISnBibWNzSUdKNWRHVnpMQ0JpYjI5c1pXRnVYVDRvZXlCclpYbFFjbVZtYVhnNklDZDBiVEVuSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMGJURmhJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNakE0Q2lBZ0lDQXZMeUIwYUdsekxtSnZlRTFoY0RFb0oyRW5LUzUyWVd4MVpTQTlJRnNuYUdWc2JHOG5MQ0JDZVhSbGN5Z25kMjl5YkdRbktTd2dkSEoxWlYwS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhnd01EQTFNREF3WXpnd01EQXdOVFk0TmpVMll6WmpObVl3TURBMU56YzJaamN5Tm1NMk5Bb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNVGMyQ2lBZ0lDQXZMeUJpYjNoTllYQXlJRDBnUW05NFRXRndQSE4wY21sdVp5d2dRbTk0VFdGd01qNG9leUJyWlhsUWNtVm1hWGc2SUNkMGJUSW5JSDBwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0owYlRKaElnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk1qQTVDaUFnSUNBdkx5QjBhR2x6TG1KdmVFMWhjRElvSjJFbktTNTJZV3gxWlNBOUlIc2dZVG9nSjJobGJHeHZKeXdnWWpvZ1FubDBaWE1vSjNkdmNteGtKeWtzSUdNNklIUnlkV1VnZlFvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pveE56WUtJQ0FnSUM4dklHSnZlRTFoY0RJZ1BTQkNiM2hOWVhBOGMzUnlhVzVuTENCQ2IzaE5ZWEF5UGloN0lHdGxlVkJ5WldacGVEb2dKM1J0TWljZ2ZTa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0luUnRNbUVpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem95TURnS0lDQWdJQzh2SUhSb2FYTXVZbTk0VFdGd01TZ25ZU2NwTG5aaGJIVmxJRDBnV3lkb1pXeHNieWNzSUVKNWRHVnpLQ2QzYjNKc1pDY3BMQ0IwY25WbFhRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEQXdNRFV3TURCak9EQXdNREExTmpnMk5UWmpObU0yWmpBd01EVTNOelptTnpJMll6WTBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3lNRGtLSUNBZ0lDOHZJSFJvYVhNdVltOTRUV0Z3TWlnbllTY3BMblpoYkhWbElEMGdleUJoT2lBbmFHVnNiRzhuTENCaU9pQkNlWFJsY3lnbmQyOXliR1FuS1N3Z1l6b2dkSEoxWlNCOUNpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3hOelVLSUNBZ0lDOHZJR0p2ZUUxaGNERWdQU0JDYjNoTllYQThjM1J5YVc1bkxDQmJjM1J5YVc1bkxDQmllWFJsY3l3Z1ltOXZiR1ZoYmwwK0tIc2dhMlY1VUhKbFptbDRPaUFuZEcweEp5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkRzB4WVNJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pJeE1Bb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVZbTk0VFdGd01TZ25ZU2NwTG1WNGFYTjBjeWtLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3hOelVLSUNBZ0lDOHZJR0p2ZUUxaGNERWdQU0JDYjNoTllYQThjM1J5YVc1bkxDQmJjM1J5YVc1bkxDQmllWFJsY3l3Z1ltOXZiR1ZoYmwwK0tIc2dhMlY1VUhKbFptbDRPaUFuZEcweEp5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkRzB4WVNJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pJeE1nb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVZbTk0VFdGd01TZ25ZU2NwTG5aaGJIVmxXekJkSUQwOVBTQW5hR1ZzYkc4bktRb2dJQ0FnYVc1MFkxOHhJQzh2SURVS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1luUnZhUW9nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUNzS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pFM05Rb2dJQ0FnTHk4Z1ltOTRUV0Z3TVNBOUlFSnZlRTFoY0R4emRISnBibWNzSUZ0emRISnBibWNzSUdKNWRHVnpMQ0JpYjI5c1pXRnVYVDRvZXlCclpYbFFjbVZtYVhnNklDZDBiVEVuSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMGJURmhJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNakV5Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1aWIzaE5ZWEF4S0NkaEp5a3VkbUZzZFdWYk1GMGdQVDA5SUNkb1pXeHNieWNwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdOUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbWhsYkd4dklnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk1UYzFDaUFnSUNBdkx5QmliM2hOWVhBeElEMGdRbTk0VFdGd1BITjBjbWx1Wnl3Z1czTjBjbWx1Wnl3Z1lubDBaWE1zSUdKdmIyeGxZVzVkUGloN0lHdGxlVkJ5WldacGVEb2dKM1J0TVNjZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luUnRNV0VpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem95TVRNS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtSnZlRTFoY0RFb0oyRW5LUzUyWVd4MVpWc3hYUzVsY1hWaGJITW9RbmwwWlhNb0ozZHZjbXhrSnlrcEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPakUzTlFvZ0lDQWdMeThnWW05NFRXRndNU0E5SUVKdmVFMWhjRHh6ZEhKcGJtY3NJRnR6ZEhKcGJtY3NJR0o1ZEdWekxDQmliMjlzWldGdVhUNG9leUJyWlhsUWNtVm1hWGc2SUNkMGJURW5JSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0owYlRGaElnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk1qRXpDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTVpYjNoTllYQXhLQ2RoSnlrdWRtRnNkV1ZiTVYwdVpYRjFZV3h6S0VKNWRHVnpLQ2QzYjNKc1pDY3BLU2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem94TnpVS0lDQWdJQzh2SUdKdmVFMWhjREVnUFNCQ2IzaE5ZWEE4YzNSeWFXNW5MQ0JiYzNSeWFXNW5MQ0JpZVhSbGN5d2dZbTl2YkdWaGJsMCtLSHNnYTJWNVVISmxabWw0T2lBbmRHMHhKeUI5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZEcweFlTSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qSXhNd29nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11WW05NFRXRndNU2duWVNjcExuWmhiSFZsV3pGZExtVnhkV0ZzY3loQ2VYUmxjeWduZDI5eWJHUW5LU2twQ2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbmR2Y214a0lnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk1UYzFDaUFnSUNBdkx5QmliM2hOWVhBeElEMGdRbTk0VFdGd1BITjBjbWx1Wnl3Z1czTjBjbWx1Wnl3Z1lubDBaWE1zSUdKdmIyeGxZVzVkUGloN0lHdGxlVkJ5WldacGVEb2dKM1J0TVNjZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luUnRNV0VpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem95TVRRS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtSnZlRTFoY0RFb0oyRW5LUzUyWVd4MVpWc3lYU2tLSUNBZ0lHbHVkR05mTXlBdkx5QTBDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnWW05NFgyVjRkSEpoWTNRZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lIQjFjMmhwYm5RZ01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPakUzTmdvZ0lDQWdMeThnWW05NFRXRndNaUE5SUVKdmVFMWhjRHh6ZEhKcGJtY3NJRUp2ZUUxaGNESStLSHNnYTJWNVVISmxabWw0T2lBbmRHMHlKeUI5S1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpZEcweVlTSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qSXhOd29nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11WW05NFRXRndNaWduWVNjcExuWmhiSFZsTG1FZ1BUMDlJQ2RvWld4c2J5Y3BDaUFnSUNCcGJuUmpYekVnTHk4Z05Rb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmlkRzlwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk1UYzJDaUFnSUNBdkx5QmliM2hOWVhBeUlEMGdRbTk0VFdGd1BITjBjbWx1Wnl3Z1FtOTRUV0Z3TWo0b2V5QnJaWGxRY21WbWFYZzZJQ2QwYlRJbklIMHBDaUFnSUNCaWVYUmxZMTh5SUM4dklDSjBiVEpoSWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TWpFM0NpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NWliM2hOWVhBeUtDZGhKeWt1ZG1Gc2RXVXVZU0E5UFQwZ0oyaGxiR3h2SnlrS0lDQWdJR2x1ZEdOZk1TQXZMeUExQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpYUdWc2JHOGlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3hOellLSUNBZ0lDOHZJR0p2ZUUxaGNESWdQU0JDYjNoTllYQThjM1J5YVc1bkxDQkNiM2hOWVhBeVBpaDdJR3RsZVZCeVpXWnBlRG9nSjNSdE1pY2dmU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJblJ0TW1FaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pveU1UZ0tJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbUp2ZUUxaGNESW9KMkVuS1M1MllXeDFaUzVpTG1WeGRXRnNjeWhDZVhSbGN5Z25kMjl5YkdRbktTa3BDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TVRjMkNpQWdJQ0F2THlCaWIzaE5ZWEF5SUQwZ1FtOTRUV0Z3UEhOMGNtbHVaeXdnUW05NFRXRndNajRvZXlCclpYbFFjbVZtYVhnNklDZDBiVEluSUgwcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKMGJUSmhJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNakU0Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1aWIzaE5ZWEF5S0NkaEp5a3VkbUZzZFdVdVlpNWxjWFZoYkhNb1FubDBaWE1vSjNkdmNteGtKeWtwS1FvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1luUnZhUW9nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUNzS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pFM05nb2dJQ0FnTHk4Z1ltOTRUV0Z3TWlBOUlFSnZlRTFoY0R4emRISnBibWNzSUVKdmVFMWhjREkrS0hzZ2EyVjVVSEpsWm1sNE9pQW5kRzB5SnlCOUtRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWRHMHlZU0lLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPakl4T0FvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVltOTRUV0Z3TWlnbllTY3BMblpoYkhWbExtSXVaWEYxWVd4ektFSjVkR1Z6S0NkM2IzSnNaQ2NwS1NrS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdZbmwwWldNZ05pQXZMeUFpZDI5eWJHUWlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3hOellLSUNBZ0lDOHZJR0p2ZUUxaGNESWdQU0JDYjNoTllYQThjM1J5YVc1bkxDQkNiM2hOWVhBeVBpaDdJR3RsZVZCeVpXWnBlRG9nSjNSdE1pY2dmU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJblJ0TW1FaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pveU1Ua0tJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbUp2ZUUxaGNESW9KMkVuS1M1MllXeDFaUzVqS1FvZ0lDQWdhVzUwWTE4eklDOHZJRFFLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCaWIzaGZaWGgwY21GamRDQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdjSFZ6YUdsdWRDQXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TVRjMUNpQWdJQ0F2THlCaWIzaE5ZWEF4SUQwZ1FtOTRUV0Z3UEhOMGNtbHVaeXdnVzNOMGNtbHVaeXdnWW5sMFpYTXNJR0p2YjJ4bFlXNWRQaWg3SUd0bGVWQnlaV1pwZURvZ0ozUnRNU2NnZlNrS0lDQWdJR0o1ZEdWaklEY2dMeThnSW5SdE1XSWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3lNakVLSUNBZ0lDOHZJSFJvYVhNdVltOTRUV0Z3TVNnbllpY3BMblpoYkhWbElEMGdXeWRoWW1NbkxDQkNlWFJsY3lnblpHVm1KeWtzSUdaaGJITmxYUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem94TnpVS0lDQWdJQzh2SUdKdmVFMWhjREVnUFNCQ2IzaE5ZWEE4YzNSeWFXNW5MQ0JiYzNSeWFXNW5MQ0JpZVhSbGN5d2dZbTl2YkdWaGJsMCtLSHNnYTJWNVVISmxabWw0T2lBbmRHMHhKeUI5S1FvZ0lDQWdZbmwwWldNZ055QXZMeUFpZEcweFlpSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qSXlNUW9nSUNBZ0x5OGdkR2hwY3k1aWIzaE5ZWEF4S0NkaUp5a3VkbUZzZFdVZ1BTQmJKMkZpWXljc0lFSjVkR1Z6S0Nka1pXWW5LU3dnWm1Gc2MyVmRDaUFnSUNCaWVYUmxZeUE0SUM4dklEQjRNREF3TlRBd01HRXdNREF3TURNMk1UWXlOak13TURBek5qUTJOVFkyQ2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pveE56WUtJQ0FnSUM4dklHSnZlRTFoY0RJZ1BTQkNiM2hOWVhBOGMzUnlhVzVuTENCQ2IzaE5ZWEF5UGloN0lHdGxlVkJ5WldacGVEb2dKM1J0TWljZ2ZTa0tJQ0FnSUdKNWRHVmpJRGtnTHk4Z0luUnRNbUlpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem95TWpRS0lDQWdJQzh2SUhSb2FYTXVZbTk0VFdGd01pZ25ZaWNwTG5aaGJIVmxJRDBnZXlCaE9pQW5ZV0pqSnl3Z1lqb2dRbmwwWlhNb0oyUmxaaWNwTENCak9pQm1ZV3h6WlNCOUNpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qRTNOZ29nSUNBZ0x5OGdZbTk0VFdGd01pQTlJRUp2ZUUxaGNEeHpkSEpwYm1jc0lFSnZlRTFoY0RJK0tIc2dhMlY1VUhKbFptbDRPaUFuZEcweUp5QjlLUW9nSUNBZ1lubDBaV01nT1NBdkx5QWlkRzB5WWlJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pJeU1Rb2dJQ0FnTHk4Z2RHaHBjeTVpYjNoTllYQXhLQ2RpSnlrdWRtRnNkV1VnUFNCYkoyRmlZeWNzSUVKNWRHVnpLQ2RrWldZbktTd2dabUZzYzJWZENpQWdJQ0JpZVhSbFl5QTRJQzh2SURCNE1EQXdOVEF3TUdFd01EQXdNRE0yTVRZeU5qTXdNREF6TmpRMk5UWTJDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3lNalFLSUNBZ0lDOHZJSFJvYVhNdVltOTRUV0Z3TWlnbllpY3BMblpoYkhWbElEMGdleUJoT2lBbllXSmpKeXdnWWpvZ1FubDBaWE1vSjJSbFppY3BMQ0JqT2lCbVlXeHpaU0I5Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pveE56VUtJQ0FnSUM4dklHSnZlRTFoY0RFZ1BTQkNiM2hOWVhBOGMzUnlhVzVuTENCYmMzUnlhVzVuTENCaWVYUmxjeXdnWW05dmJHVmhibDArS0hzZ2EyVjVVSEpsWm1sNE9pQW5kRzB4SnlCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWRHMHhZU0lLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPakl5TndvZ0lDQWdMeThnZEdocGN5NWliM2hOWVhBeEtDZGhKeWt1WkdWc1pYUmxLQ2tLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TVRjMUNpQWdJQ0F2THlCaWIzaE5ZWEF4SUQwZ1FtOTRUV0Z3UEhOMGNtbHVaeXdnVzNOMGNtbHVaeXdnWW5sMFpYTXNJR0p2YjJ4bFlXNWRQaWg3SUd0bGVWQnlaV1pwZURvZ0ozUnRNU2NnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5SdE1XRWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3lNamdLSUNBZ0lDOHZJR0Z6YzJWeWRDZ2hkR2hwY3k1aWIzaE5ZWEF4S0NkaEp5a3VaWGhwYzNSektRb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPakUzTmdvZ0lDQWdMeThnWW05NFRXRndNaUE5SUVKdmVFMWhjRHh6ZEhKcGJtY3NJRUp2ZUUxaGNESStLSHNnYTJWNVVISmxabWw0T2lBbmRHMHlKeUI5S1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpZEcweVlTSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qSXpNQW9nSUNBZ0x5OGdkR2hwY3k1aWIzaE5ZWEF5S0NkaEp5a3VaR1ZzWlhSbEtDa0tJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNVGMyQ2lBZ0lDQXZMeUJpYjNoTllYQXlJRDBnUW05NFRXRndQSE4wY21sdVp5d2dRbTk0VFdGd01qNG9leUJyWlhsUWNtVm1hWGc2SUNkMGJUSW5JSDBwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0owYlRKaElnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk1qTXhDaUFnSUNBdkx5QmhjM05sY25Rb0lYUm9hWE11WW05NFRXRndNaWduWVNjcExtVjRhWE4wY3lrS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3lNRFFLSUNBZ0lDOHZJSFJsYzNSQ2IzaE5ZWEFvS1NCN0NpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNSbGMzUkNiM2hmY205MWRHVkFORG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPakUzTXdvZ0lDQWdMeThnWW05NE1TQTlJRUp2ZUR4YmMzUnlhVzVuTENCaWVYUmxjeXdnWW05dmJHVmhibDArS0hzZ2EyVjVPaUFuZERFbklIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjBNU0lLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPakUzT1FvZ0lDQWdMeThnZEdocGN5NWliM2d4TG1OeVpXRjBaU2g3SUhOcGVtVTZJREV3SUgwcENpQWdJQ0J3ZFhOb2FXNTBJREV3Q2lBZ0lDQmliM2hmWTNKbFlYUmxDaUFnSUNCd2IzQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qRTNOQW9nSUNBZ0x5OGdZbTk0TWlBOUlFSnZlRHg3SUdFNklITjBjbWx1WnpzZ1lqb2dZbmwwWlhNN0lHTTZJR0p2YjJ4bFlXNGdmVDRvZXlCclpYazZJQ2QwTWljZ2ZTa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0luUXlJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNVGd3Q2lBZ0lDQXZMeUIwYUdsekxtSnZlREl1WTNKbFlYUmxLSHNnYzJsNlpUb2dNakFnZlNrS0lDQWdJSEIxYzJocGJuUWdNakFLSUNBZ0lHSnZlRjlqY21WaGRHVUtJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk1UY3pDaUFnSUNBdkx5QmliM2d4SUQwZ1FtOTRQRnR6ZEhKcGJtY3NJR0o1ZEdWekxDQmliMjlzWldGdVhUNG9leUJyWlhrNklDZDBNU2NnZlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5ReElnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk1UZ3hDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTVpYjNneExteGxibWQwYUNBOVBUMGdNVEFwQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0J3YjNBS0lDQWdJSEIxYzJocGJuUWdNVEFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPakUzTXdvZ0lDQWdMeThnWW05NE1TQTlJRUp2ZUR4YmMzUnlhVzVuTENCaWVYUmxjeXdnWW05dmJHVmhibDArS0hzZ2EyVjVPaUFuZERFbklIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjBNU0lLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPakU0TndvZ0lDQWdMeThnZEdocGN5NWliM2d4TG5aaGJIVmxJRDBnV3lkb1pXeHNieWNzSUVKNWRHVnpLQ2QzYjNKc1pDY3BMQ0IwY25WbFhRb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3hOek1LSUNBZ0lDOHZJR0p2ZURFZ1BTQkNiM2c4VzNOMGNtbHVaeXdnWW5sMFpYTXNJR0p2YjJ4bFlXNWRQaWg3SUd0bGVUb2dKM1F4SnlCOUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWRERWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3hPRGNLSUNBZ0lDOHZJSFJvYVhNdVltOTRNUzUyWVd4MVpTQTlJRnNuYUdWc2JHOG5MQ0JDZVhSbGN5Z25kMjl5YkdRbktTd2dkSEoxWlYwS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhnd01EQTFNREF3WXpnd01EQXdOVFk0TmpVMll6WmpObVl3TURBMU56YzJaamN5Tm1NMk5Bb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNVGN6Q2lBZ0lDQXZMeUJpYjNneElEMGdRbTk0UEZ0emRISnBibWNzSUdKNWRHVnpMQ0JpYjI5c1pXRnVYVDRvZXlCclpYazZJQ2QwTVNjZ2ZTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0luUXhJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNVGc0Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1aWIzZ3hMblpoYkhWbFd6QmRJRDA5UFNBbmFHVnNiRzhuS1FvZ0lDQWdhVzUwWTE4eElDOHZJRFVLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWW5SdmFRb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJQ3NLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPakUzTXdvZ0lDQWdMeThnWW05NE1TQTlJRUp2ZUR4YmMzUnlhVzVuTENCaWVYUmxjeXdnWW05dmJHVmhibDArS0hzZ2EyVjVPaUFuZERFbklIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjBNU0lLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPakU0T0FvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVltOTRNUzUyWVd4MVpWc3dYU0E5UFQwZ0oyaGxiR3h2SnlrS0lDQWdJR2x1ZEdOZk1TQXZMeUExQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpYUdWc2JHOGlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3hOek1LSUNBZ0lDOHZJR0p2ZURFZ1BTQkNiM2c4VzNOMGNtbHVaeXdnWW5sMFpYTXNJR0p2YjJ4bFlXNWRQaWg3SUd0bGVUb2dKM1F4SnlCOUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWRERWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3hPRGtLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1KdmVERXVkbUZzZFdWYk1WMHVaWEYxWVd4ektFSjVkR1Z6S0NkM2IzSnNaQ2NwS1NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3hOek1LSUNBZ0lDOHZJR0p2ZURFZ1BTQkNiM2c4VzNOMGNtbHVaeXdnWW5sMFpYTXNJR0p2YjJ4bFlXNWRQaWg3SUd0bGVUb2dKM1F4SnlCOUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWRERWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3hPRGtLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1KdmVERXVkbUZzZFdWYk1WMHVaWEYxWVd4ektFSjVkR1Z6S0NkM2IzSnNaQ2NwS1NrS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lHSjBiMmtLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNBckNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pveE56TUtJQ0FnSUM4dklHSnZlREVnUFNCQ2IzZzhXM04wY21sdVp5d2dZbmwwWlhNc0lHSnZiMnhsWVc1ZFBpaDdJR3RsZVRvZ0ozUXhKeUI5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpZERFaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pveE9Ea0tJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbUp2ZURFdWRtRnNkV1ZiTVYwdVpYRjFZV3h6S0VKNWRHVnpLQ2QzYjNKc1pDY3BLU2tLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1lubDBaV01nTmlBdkx5QWlkMjl5YkdRaUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pveE56TUtJQ0FnSUM4dklHSnZlREVnUFNCQ2IzZzhXM04wY21sdVp5d2dZbmwwWlhNc0lHSnZiMnhsWVc1ZFBpaDdJR3RsZVRvZ0ozUXhKeUI5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpZERFaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pveE9UQUtJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbUp2ZURFdWRtRnNkV1ZiTWwwcENpQWdJQ0JwYm5Salh6TWdMeThnTkFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lHSnZlRjlsZUhSeVlXTjBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0J3ZFhOb2FXNTBJREFLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pveE56UUtJQ0FnSUM4dklHSnZlRElnUFNCQ2IzZzhleUJoT2lCemRISnBibWM3SUdJNklHSjVkR1Z6T3lCak9pQmliMjlzWldGdUlIMCtLSHNnYTJWNU9pQW5kREluSUgwcENpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKME1pSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qRTVNZ29nSUNBZ0x5OGdkR2hwY3k1aWIzZ3lMblpoYkhWbElEMGdleUJoT2lBbmFHVnNiRzhuTENCaU9pQkNlWFJsY3lnbmQyOXliR1FuS1N3Z1l6b2dkSEoxWlNCOUNpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qRTNOQW9nSUNBZ0x5OGdZbTk0TWlBOUlFSnZlRHg3SUdFNklITjBjbWx1WnpzZ1lqb2dZbmwwWlhNN0lHTTZJR0p2YjJ4bFlXNGdmVDRvZXlCclpYazZJQ2QwTWljZ2ZTa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0luUXlJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNVGczQ2lBZ0lDQXZMeUIwYUdsekxtSnZlREV1ZG1Gc2RXVWdQU0JiSjJobGJHeHZKeXdnUW5sMFpYTW9KM2R2Y214a0p5a3NJSFJ5ZFdWZENpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE1EQXdOVEF3TUdNNE1EQXdNRFUyT0RZMU5tTTJZelptTURBd05UYzNObVkzTWpaak5qUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qRTVNZ29nSUNBZ0x5OGdkR2hwY3k1aWIzZ3lMblpoYkhWbElEMGdleUJoT2lBbmFHVnNiRzhuTENCaU9pQkNlWFJsY3lnbmQyOXliR1FuS1N3Z1l6b2dkSEoxWlNCOUNpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3hOelFLSUNBZ0lDOHZJR0p2ZURJZ1BTQkNiM2c4ZXlCaE9pQnpkSEpwYm1jN0lHSTZJR0o1ZEdWek95QmpPaUJpYjI5c1pXRnVJSDArS0hzZ2EyVjVPaUFuZERJbklIMHBDaUFnSUNCaWVYUmxZMTh6SUM4dklDSjBNaUlLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPakU1TXdvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVltOTRNaTUyWVd4MVpTNWhJRDA5UFNBbmFHVnNiRzhuS1FvZ0lDQWdhVzUwWTE4eElDOHZJRFVLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWW5SdmFRb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJQ3NLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPakUzTkFvZ0lDQWdMeThnWW05NE1pQTlJRUp2ZUR4N0lHRTZJSE4wY21sdVp6c2dZam9nWW5sMFpYTTdJR002SUdKdmIyeGxZVzRnZlQ0b2V5QnJaWGs2SUNkME1pY2dmU2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJblF5SWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TVRrekNpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NWliM2d5TG5aaGJIVmxMbUVnUFQwOUlDZG9aV3hzYnljcENpQWdJQ0JwYm5Salh6RWdMeThnTlFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR0o1ZEdWaklEVWdMeThnSW1obGJHeHZJZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNVGMwQ2lBZ0lDQXZMeUJpYjNneUlEMGdRbTk0UEhzZ1lUb2djM1J5YVc1bk95QmlPaUJpZVhSbGN6c2dZem9nWW05dmJHVmhiaUI5UGloN0lHdGxlVG9nSjNReUp5QjlLUW9nSUNBZ1lubDBaV05mTXlBdkx5QWlkRElpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem94T1RRS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtSnZlREl1ZG1Gc2RXVXVZaTVsY1hWaGJITW9RbmwwWlhNb0ozZHZjbXhrSnlrcEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPakUzTkFvZ0lDQWdMeThnWW05NE1pQTlJRUp2ZUR4N0lHRTZJSE4wY21sdVp6c2dZam9nWW5sMFpYTTdJR002SUdKdmIyeGxZVzRnZlQ0b2V5QnJaWGs2SUNkME1pY2dmU2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJblF5SWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TVRrMENpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NWliM2d5TG5aaGJIVmxMbUl1WlhGMVlXeHpLRUo1ZEdWektDZDNiM0pzWkNjcEtTa0tJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQXJDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3hOelFLSUNBZ0lDOHZJR0p2ZURJZ1BTQkNiM2c4ZXlCaE9pQnpkSEpwYm1jN0lHSTZJR0o1ZEdWek95QmpPaUJpYjI5c1pXRnVJSDArS0hzZ2EyVjVPaUFuZERJbklIMHBDaUFnSUNCaWVYUmxZMTh6SUM4dklDSjBNaUlLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPakU1TkFvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVltOTRNaTUyWVd4MVpTNWlMbVZ4ZFdGc2N5aENlWFJsY3lnbmQyOXliR1FuS1NrcENpQWdJQ0JqYjNabGNpQXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR0o1ZEdWaklEWWdMeThnSW5kdmNteGtJZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNVGMwQ2lBZ0lDQXZMeUJpYjNneUlEMGdRbTk0UEhzZ1lUb2djM1J5YVc1bk95QmlPaUJpZVhSbGN6c2dZem9nWW05dmJHVmhiaUI5UGloN0lHdGxlVG9nSjNReUp5QjlLUW9nSUNBZ1lubDBaV05mTXlBdkx5QWlkRElpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem94T1RVS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtSnZlREl1ZG1Gc2RXVXVZeWtLSUNBZ0lHbHVkR05mTXlBdkx5QTBDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnWW05NFgyVjRkSEpoWTNRZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lIQjFjMmhwYm5RZ01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPakUzTXdvZ0lDQWdMeThnWW05NE1TQTlJRUp2ZUR4YmMzUnlhVzVuTENCaWVYUmxjeXdnWW05dmJHVmhibDArS0hzZ2EyVjVPaUFuZERFbklIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjBNU0lLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPakU1TndvZ0lDQWdMeThnZEdocGN5NWliM2d4TG1SbGJHVjBaU2dwQ2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pFM013b2dJQ0FnTHk4Z1ltOTRNU0E5SUVKdmVEeGJjM1J5YVc1bkxDQmllWFJsY3l3Z1ltOXZiR1ZoYmwwK0tIc2dhMlY1T2lBbmRERW5JSDBwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0owTVNJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pFNU9Bb2dJQ0FnTHk4Z1lYTnpaWEowS0NGMGFHbHpMbUp2ZURFdVpYaHBjM1J6S1FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qRTNOQW9nSUNBZ0x5OGdZbTk0TWlBOUlFSnZlRHg3SUdFNklITjBjbWx1WnpzZ1lqb2dZbmwwWlhNN0lHTTZJR0p2YjJ4bFlXNGdmVDRvZXlCclpYazZJQ2QwTWljZ2ZTa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0luUXlJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNakF3Q2lBZ0lDQXZMeUIwYUdsekxtSnZlREl1WkdWc1pYUmxLQ2tLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TVRjMENpQWdJQ0F2THlCaWIzZ3lJRDBnUW05NFBIc2dZVG9nYzNSeWFXNW5PeUJpT2lCaWVYUmxjenNnWXpvZ1ltOXZiR1ZoYmlCOVBpaDdJR3RsZVRvZ0ozUXlKeUI5S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpZERJaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pveU1ERUtJQ0FnSUM4dklHRnpjMlZ5ZENnaGRHaHBjeTVpYjNneUxtVjRhWE4wY3lrS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3hOemdLSUNBZ0lDOHZJSFJsYzNSQ2IzZ29LU0I3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMTlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpVQTVPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNVGN5Q2lBZ0lDQXZMeUJqYkdGemN5QlVkWEJzWlVKdmVDQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNBbUpnb2dJQ0FnY21WMGRYSnVDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFnVUJCQ1lLQkhSdE1XRUNkREVFZEcweVlRSjBNaE1BQlFBTWdBQUZhR1ZzYkc4QUJYZHZjbXhrQldobGJHeHZCWGR2Y214a0JIUnRNV0lQQUFVQUNnQUFBMkZpWXdBRFpHVm1CSFJ0TW1JeEcwRUJZVEVaRkVReEdFU0NBZ1Q4R2NSdUJKOGZHT1UyR2dDT0FnQ3NBQUVBS0wxRkFSUkVLcjFGQVJSRUtMeElLQ2NFdnlxOFNDb25CTDhvdlVVQlJDZ2pJcm9YSWdnb0kwOEN1bGNDQUNjRkVrUW9Ja202RnloTEFTSzZGeUlJS0U0Q3VsY0NBQ2NHRWtRb0pTUzZnUUJUUkNvaklyb1hJZ2dxSTA4Q3VsY0NBQ2NGRWtRcUlrbTZGeXBMQVNLNkZ5SUlLazRDdWxjQ0FDY0dFa1FxSlNTNmdRQlRSQ2NIdkVnbkJ5Y0l2eWNKdkVnbkNTY0l2eWk4U0NpOVJRRVVSQ3E4U0NxOVJRRVVSQ1JES1lFS3VVZ3JnUlM1U0NtOVNJRUtFa1FwdkVncEp3Uy9LU01pdWhjaUNDa2pUd0s2VndJQUp3VVNSQ2tpU2JvWEtVc0JJcm9YSWdncFRnSzZWd0lBSndZU1JDa2xKTHFCQUZORUs3eElLeWNFdnlzaklyb1hJZ2dySTA4Q3VsY0NBQ2NGRWtRcklrbTZGeXRMQVNLNkZ5SUlLMDRDdWxjQ0FDY0dFa1FySlNTNmdRQlRSQ204U0NtOVJRRVVSQ3U4U0N1OVJRRVVSQ1JETVJrVU1SZ1VFRU09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
