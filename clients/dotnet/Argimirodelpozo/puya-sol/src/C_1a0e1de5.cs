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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.C_1a0e1de5
{


    public class CProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class S1 : AVMObjectType
            {
                public byte[] A { get; set; }

                public byte[] B { get; set; }

                public byte[] C { get; set; }

                public byte[] D { get; set; }

                public byte[] E { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[1]");
                    vA.From(A);
                    ret.AddRange(vA.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[1]");
                    vB.From(B);
                    ret.AddRange(vB.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vC = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[10]");
                    vC.From(C);
                    ret.AddRange(vC.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vD = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[9]");
                    vD.From(D);
                    ret.AddRange(vD.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vE = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[10]");
                    vE.From(E);
                    ret.AddRange(vE.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static S1 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new S1();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[1]");
                    count = vA.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueA = vA.ToValue();
                    if (valueA is byte[] vAValue) { ret.A = vAValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[1]");
                    count = vB.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueB = vB.ToValue();
                    if (valueB is byte[] vBValue) { ret.B = vBValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vC = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[10]");
                    count = vC.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueC = vC.ToValue();
                    if (valueC is byte[] vCValue) { ret.C = vCValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vD = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[9]");
                    count = vD.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueD = vD.ToValue();
                    if (valueD is byte[] vDValue) { ret.D = vDValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vE = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[10]");
                    count = vE.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueE = vE.ToValue();
                    if (valueE is byte[] vEValue) { ret.E = vEValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as S1);
                }
                public bool Equals(S1? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(S1 left, S1 right)
                {
                    return EqualityComparer<S1>.Default.Equals(left, right);
                }
                public static bool operator !=(S1 left, S1 right)
                {
                    return !(left == right);
                }

            }

            public class S2 : AVMObjectType
            {
                public byte[] A { get; set; }

                public Structs.S1 Inner { get; set; } = new Structs.S1();

                public byte[] B { get; set; }

                public byte[] C { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[1]");
                    vA.From(A);
                    ret.AddRange(vA.Encode());
                    ret.AddRange(Inner.ToByteArray());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[1]");
                    vB.From(B);
                    ret.AddRange(vB.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vC = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[1]");
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

                public static S2 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new S2();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[1]");
                    count = vA.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueA = vA.ToValue();
                    if (valueA is byte[] vAValue) { ret.A = vAValue; }
                    ret.Inner = Structs.S1.Parse(queue.ToArray());
                    { var consumedInner = ret.Inner.ToByteArray().Length; for (int i = 0; i < consumedInner && queue.Count > 0; i++) { queue.Dequeue(); } }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[1]");
                    count = vB.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueB = vB.ToValue();
                    if (valueB is byte[] vBValue) { ret.B = vBValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vC = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[1]");
                    count = vC.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueC = vC.ToValue();
                    if (valueC is byte[] vCValue) { ret.C = vCValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as S2);
                }
                public bool Equals(S2? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(S2 left, S2 right)
                {
                    return EqualityComparer<S2>.Default.Equals(left, right);
                }
                public static bool operator !=(S2 left, S2 right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<bool> Test(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 158, 60, 196 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Test_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 158, 60, 196 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJzMSI6W3sibmFtZSI6ImEiLCJ0eXBlIjoidWludDhbMV0ifSx7Im5hbWUiOiJiIiwidHlwZSI6InVpbnQ4WzFdIn0seyJuYW1lIjoiYyIsInR5cGUiOiJ1aW50OFsxMF0ifSx7Im5hbWUiOiJkIiwidHlwZSI6InVpbnQ4WzldIn0seyJuYW1lIjoiZSIsInR5cGUiOiJ1aW50OFsxMF0ifV0sInMyIjpbeyJuYW1lIjoiYSIsInR5cGUiOiJ1aW50OFsxXSJ9LHsibmFtZSI6ImlubmVyIiwidHlwZSI6InMxIn0seyJuYW1lIjoiYiIsInR5cGUiOiJ1aW50OFsxXSJ9LHsibmFtZSI6ImMiLCJ0eXBlIjoidWludDhbMV0ifV19LCJNZXRob2RzIjpbeyJuYW1lIjoidGVzdCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjJ9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzcwN10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTgwXSwiZXJyb3JNZXNzYWdlIjoibm90IHBheWFibGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dmRHVnpkSE12YzI5c2FXUnBkSGt0YzJWdFlXNTBhV010ZEdWemRITXZkR1Z6ZEhNdmMzUnZjbUZuWlM5d1lXTnJaV1JmYzNSdmNtRm5aVjl6ZEhKMVkzUnpYMko1ZEdWekxuTnZiQzVETG1Gd2NISnZkbUZzWDNCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4Q2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0prWVhSaElpQXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0lEQjRNREFnSW5raUlEQjRNekV6TWpNek16UXpOVE0yTXpjek9ETTVNekFnTUhnek1UTXlNek16TkRNMU16WXpOek00TXprZ01IZzJNVFl5TmpNMk5EWTFOalkyTnpZNE5qazJZUW9nSUNBZ2NIVnphR2x1ZENBME1EazJDaUFnSUNCaWVtVnlid29nSUNBZ1pIVndDaUFnSUNCemRHOXlaU0ExQ2lBZ0lDQnpkRzl5WlNBd0NpQWdJQ0JzYjJGa0lEQUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd09EQUtJQ0FnSUhKbGNHeGhZMlV5SURZMENpQWdJQ0J6ZEc5eVpTQXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0J3ZFhOb1lubDBaWE1nSW5naUNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1EQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZMTh6SUM4dklDSjVJZ29nSUNBZ1lubDBaV05mTWlBdkx5QXdlREF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaG1OVGxsTTJOak5DQXZMeUJ0WlhSb2IyUWdJblJsYzNRb0tXSnZiMndpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYM1JsYzNSZmNtOTFkR1ZBTkFvZ0lDQWdaWEp5Q2dwdFlXbHVYM1JsYzNSZmNtOTFkR1ZBTkRvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBbUpnb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1lub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRGdLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENncHRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFPVG9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBaWVDSWdNSGd3TVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1SaGRHRWlDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElETXlJREVLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMElETXpJREVLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWlhoMGNtRmpkQ0F4SURNeENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTUNBeENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F6TWlBeENpQWdJQ0JrYVdjZ01nb2dJQ0FnWlhoMGNtRmpkQ0F6TXlBeENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHVjRkSEpoWTNRZ01TQXpNUW9nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURFZ01Rb2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1FnTWlBeE1Bb2dJQ0FnWkdsbklESUtJQ0FnSUdWNGRISmhZM1FnTVRJZ09Rb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmxlSFJ5WVdOMElESXhJREV3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TXdvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJREFnTVFvZ0lDQWdaR2xuSURFS0lDQWdJR1Y0ZEhKaFkzUWdNeklnTVFvZ0lDQWdaR2xuSURJS0lDQWdJR1Y0ZEhKaFkzUWdNek1nTVFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCbGVIUnlZV04wSURFZ016RUtJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0F3SURFS0lDQWdJR1JwWnlBeENpQWdJQ0JsZUhSeVlXTjBJRElnTVRBS0lDQWdJR1JwWnlBeUNpQWdJQ0JsZUhSeVlXTjBJREV5SURrS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1pYaDBjbUZqZENBeU1TQXhNQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQXdJREVLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMElETXlJREVLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmxlSFJ5WVdOMElETXpJREVLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWlhoMGNtRmpkQ0F4SURNeENpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F4Q2lBZ0lDQmthV2NnTVFvZ0lDQWdaWGgwY21GamRDQXhJREVLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmxlSFJ5WVdOMElERXlJRGtLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWlhoMGNtRmpkQ0F5TVNBeE1Bb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV01nTkNBdkx5QXdlRE14TXpJek16TTBNelV6TmpNM016Z3pPVE13Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ01DQXhDaUFnSUNCa2FXY2dNUW9nSUNBZ1pYaDBjbUZqZENBek1pQXhDaUFnSUNCa2FXY2dNZ29nSUNBZ1pYaDBjbUZqZENBek15QXhDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR1Y0ZEhKaFkzUWdNU0F6TVFvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEQWdNUW9nSUNBZ1pHbG5JREVLSUNBZ0lHVjRkSEpoWTNRZ01TQXhDaUFnSUNCa2FXY2dNZ29nSUNBZ1pYaDBjbUZqZENBeUlERXdDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR1Y0ZEhKaFkzUWdNakVnTVRBS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE16RXpNak16TXpRek5UTTJNemN6T0RNNUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0F3SURFS0lDQWdJR1JwWnlBeENpQWdJQ0JsZUhSeVlXTjBJRE15SURFS0lDQWdJR1JwWnlBeUNpQWdJQ0JsZUhSeVlXTjBJRE16SURFS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1pYaDBjbUZqZENBeElETXhDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTUNBeENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F4SURFS0lDQWdJR1JwWnlBeUNpQWdJQ0JsZUhSeVlXTjBJRElnTVRBS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1pYaDBjbUZqZENBeE1pQTVDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWXlBMklDOHZJREI0TmpFMk1qWXpOalEyTlRZMk5qYzJPRFk1Tm1FS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQXdJREVLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMElETXpJREVLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWlhoMGNtRmpkQ0F4SURNeENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTUNBeENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F6TWlBeENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHVjRkSEpoWTNRZ01TQXpNUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWkdGMFlTSUtJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0o1SWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURjS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaMlYwWW5sMFpRb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQTlQUW9nSUNBZ1lub2diV0ZwYmw5aWIyOXNYMlpoYkhObFFESXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmtZWFJoSWdvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdWNGRISmhZM1FnTVNBek1Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2RsZEdKNWRHVUtJQ0FnSUhCMWMyaHBiblFnTXdvZ0lDQWdQVDBLSUNBZ0lHSjZJRzFoYVc1ZlltOXZiRjltWVd4elpVQXlNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlaR0YwWVNJS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCbGVIUnlZV04wSURFZ016RUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JuWlhSaWVYUmxDaUFnSUNCd2RYTm9hVzUwSURRS0lDQWdJRDA5Q2lBZ0lDQmllaUJ0WVdsdVgySnZiMnhmWm1Gc2MyVkFNakFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbVJoZEdFaUNpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1pYaDBjbUZqZENBeElETXhDaUFnSUNCbGVIUnlZV04wSURJZ01UQUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0lqRXlNelExTmpjNE9UQWlDaUFnSUNBOVBRb2dJQ0FnWW5vZ2JXRnBibDlpYjI5c1gyWmhiSE5sUURJd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKa1lYUmhJZ29nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR1Y0ZEhKaFkzUWdNU0F6TVFvZ0lDQWdaWGgwY21GamRDQXhNaUE1Q2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0l4TWpNME5UWTNPRGtpQ2lBZ0lDQTlQUW9nSUNBZ1lub2diV0ZwYmw5aWIyOXNYMlpoYkhObFFESXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmtZWFJoSWdvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdWNGRISmhZM1FnTVNBek1Rb2dJQ0FnWlhoMGNtRmpkQ0F5TVNBeE1Bb2dJQ0FnWW5sMFpXTWdOaUF2THlBaVlXSmpaR1ZtWjJocGFpSUtJQ0FnSUQwOUNpQWdJQ0JpZWlCdFlXbHVYMkp2YjJ4ZlptRnNjMlZBTWpBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1SaGRHRWlDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdjSFZ6YUdsdWRDQXpNZ29nSUNBZ1oyVjBZbmwwWlFvZ0lDQWdjSFZ6YUdsdWRDQTFDaUFnSUNBOVBRb2dJQ0FnWW5vZ2JXRnBibDlpYjI5c1gyWmhiSE5sUURJd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKa1lYUmhJZ29nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR1Y0ZEhKaFkzUWdNek1nTVFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURZS0lDQWdJRDA5Q2lBZ0lDQmllaUJ0WVdsdVgySnZiMnhmWm1Gc2MyVkFNakFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSjVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QjVJR1Y0YVhOMGN3b2dJQ0FnWW5SdmFRb2dJQ0FnY0hWemFHbHVkQ0EzQ2lBZ0lDQTlQUW9nSUNBZ1lub2diV0ZwYmw5aWIyOXNYMlpoYkhObFFESXdDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb0tiV0ZwYmw5aWIyOXNYMjFsY21kbFFESXhPZ29nSUNBZ1lubDBaV05mTWlBdkx5QXdlREF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aWIyOXNYMlpoYkhObFFESXdPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ2JXRnBibDlpYjI5c1gyMWxjbWRsUURJeENncHRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFPRG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTVDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZkR1Z6ZEhNdmMyOXNhV1JwZEhrdGMyVnRZVzUwYVdNdGRHVnpkSE12ZEdWemRITXZjM1J2Y21GblpTOXdZV05yWldSZmMzUnZjbUZuWlY5emRISjFZM1J6WDJKNWRHVnpMbk52YkM1RExtTnNaV0Z5WDNOMFlYUmxYM0J5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFDQUFFbUJ3UmtZWFJoSWdBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFCQUFGNUNqRXlNelExTmpjNE9UQUpNVEl6TkRVMk56ZzVDbUZpWTJSbFptZG9hV3FCZ0NDdlNUVUZOUUEwQUlBZ0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBSUJjUURVQU1SaEFBQXFBQVhncVp5c3FaeU5EZ0FUMW5qekVOaG9BamdFQUFRQXhHUlF4R0JCRU1SWkJBak14RmlNSk9BZ1VSSUlDQVhnQkFXY292aWxPQWsxSlZ5QUJTd0ZYSVFGUEFsY0JINEFCQWt4UVR3SlFURkJKVndBQlN3RlhJQUZMQWxjaEFVOERWd0VmU1ZjQkFVc0JWd0lLU3dKWERBbFBBMWNWQ29BQkEwOEVVRThEVUU4Q1VFeFFUd05NVUU4Q1VFeFFTVmNBQVVzQlZ5QUJTd0pYSVFGUEExY0JIMGxYQUFGTEFWY0NDa3NDVnd3SlR3TlhGUXBQQTRBQkJGQlBBMUJQQWxCTVVFOERURkJQQWxCTVVFbFhBQUZMQVZjZ0FVc0NWeUVCVHdOWEFSOUpWd0FCU3dGWEFRRkxBbGNNQ1U4RFZ4VUtUd05QQTFBbkJGQlBBbEJNVUU4RFRGQlBBbEJNVUVsWEFBRkxBVmNnQVVzQ1Z5RUJUd05YQVI5SlZ3QUJTd0ZYQVFGTEFsY0NDazhEVnhVS1R3TlBBMUJQQWxBbkJWQk1VRThEVEZCUEFsQk1VRWxYQUFGTEFWY2dBVXNDVnlFQlR3TlhBUjlKVndBQlN3RlhBUUZMQWxjQ0NrOERWd3dKVHdOUEExQlBBbEJNVUNjR1VFOERURkJQQWxCTVVFbFhBQUZMQVZjaEFVOENWd0VmVHdKTVVJQUJCVkJNVUVsWEFBRkxBVmNnQVU4Q1Z3RWZUd0pNVUV4UWdBRUdVQ2hMQWI4cmdBRUhaeUpWZ1FJU1FRQ1RLTDRwVGdKTlZ3RWZJbFdCQXhKQkFJSW92aWxPQWsxWEFSOGpWWUVFRWtFQWNTaStLVTRDVFZjQkgxY0NDaWNFRWtFQVh5aStLVTRDVFZjQkgxY01DU2NGRWtFQVRTaStLVTRDVFZjQkgxY1ZDaWNHRWtFQU95aStLVTRDVFlFZ1ZZRUZFa0VBTENpK0tVNENUVmNoQVlBQkJoSkJBQndpSzJWRUY0RUhFa0VBRVNNcUlrOENWSUFFRlI5OGRVeFFzQ05ESWtMLzdDSkMvYzg9IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
