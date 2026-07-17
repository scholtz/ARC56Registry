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

namespace Arc56.Generated.joe_p.snarkjs_algorand.PlonkSignalsAndProof_8f611b56
{


    public class PlonkSignalsAndProofProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PlonkSignalsAndProofProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class PlonkProof : AVMObjectType
            {
                public byte[] A { get; set; }

                public byte[] B { get; set; }

                public byte[] C { get; set; }

                public byte[] Z { get; set; }

                public byte[] T1 { get; set; }

                public byte[] T2 { get; set; }

                public byte[] T3 { get; set; }

                public byte[] Wxi { get; set; }

                public byte[] Wxiw { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 EvalA { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 EvalB { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 EvalC { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 EvalS1 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 EvalS2 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 EvalZw { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[96]");
                    vA.From(A);
                    ret.AddRange(vA.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[96]");
                    vB.From(B);
                    ret.AddRange(vB.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vC = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[96]");
                    vC.From(C);
                    ret.AddRange(vC.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vZ = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[96]");
                    vZ.From(Z);
                    ret.AddRange(vZ.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vT1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[96]");
                    vT1.From(T1);
                    ret.AddRange(vT1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vT2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[96]");
                    vT2.From(T2);
                    ret.AddRange(vT2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vT3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[96]");
                    vT3.From(T3);
                    ret.AddRange(vT3.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWxi = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[96]");
                    vWxi.From(Wxi);
                    ret.AddRange(vWxi.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWxiw = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[96]");
                    vWxiw.From(Wxiw);
                    ret.AddRange(vWxiw.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEvalA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vEvalA.From(EvalA);
                    ret.AddRange(vEvalA.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEvalB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vEvalB.From(EvalB);
                    ret.AddRange(vEvalB.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEvalC = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vEvalC.From(EvalC);
                    ret.AddRange(vEvalC.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEvalS1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vEvalS1.From(EvalS1);
                    ret.AddRange(vEvalS1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEvalS2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vEvalS2.From(EvalS2);
                    ret.AddRange(vEvalS2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEvalZw = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vEvalZw.From(EvalZw);
                    ret.AddRange(vEvalZw.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static PlonkProof Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new PlonkProof();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[96]");
                    count = vA.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueA = vA.ToValue();
                    if (valueA is byte[] vAValue) { ret.A = vAValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[96]");
                    count = vB.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueB = vB.ToValue();
                    if (valueB is byte[] vBValue) { ret.B = vBValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vC = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[96]");
                    count = vC.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueC = vC.ToValue();
                    if (valueC is byte[] vCValue) { ret.C = vCValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vZ = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[96]");
                    count = vZ.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueZ = vZ.ToValue();
                    if (valueZ is byte[] vZValue) { ret.Z = vZValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vT1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[96]");
                    count = vT1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueT1 = vT1.ToValue();
                    if (valueT1 is byte[] vT1Value) { ret.T1 = vT1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vT2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[96]");
                    count = vT2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueT2 = vT2.ToValue();
                    if (valueT2 is byte[] vT2Value) { ret.T2 = vT2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vT3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[96]");
                    count = vT3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueT3 = vT3.ToValue();
                    if (valueT3 is byte[] vT3Value) { ret.T3 = vT3Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWxi = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[96]");
                    count = vWxi.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWxi = vWxi.ToValue();
                    if (valueWxi is byte[] vWxiValue) { ret.Wxi = vWxiValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWxiw = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[96]");
                    count = vWxiw.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWxiw = vWxiw.ToValue();
                    if (valueWxiw is byte[] vWxiwValue) { ret.Wxiw = vWxiwValue; }
                    var vEvalA = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vEvalA.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.EvalA = vEvalA;
                    var vEvalB = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vEvalB.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.EvalB = vEvalB;
                    var vEvalC = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vEvalC.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.EvalC = vEvalC;
                    var vEvalS1 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vEvalS1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.EvalS1 = vEvalS1;
                    var vEvalS2 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vEvalS2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.EvalS2 = vEvalS2;
                    var vEvalZw = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vEvalZw.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.EvalZw = vEvalZw;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as PlonkProof);
                }
                public bool Equals(PlonkProof? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(PlonkProof left, PlonkProof right)
                {
                    return EqualityComparer<PlonkProof>.Default.Equals(left, right);
                }
                public static bool operator !=(PlonkProof left, PlonkProof right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="signals"> </param>
        /// <param name="proof"> PlonkProof</param>
        public async Task SignalsAndProof(AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] signals, Structs.PlonkProof proof, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 68, 164, 120, 139 };
            var signalsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt256>("uint256"); signalsAbi.From(signals);

            var result = await base.CallApp(new List<object> { abiHandle, signalsAbi, proof }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SignalsAndProof_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] signals, Structs.PlonkProof proof, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 68, 164, 120, 139 };
            var signalsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt256>("uint256"); signalsAbi.From(signals);

            return await base.MakeTransactionList(new List<object> { abiHandle, signalsAbi, proof }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUGxvbmtTaWduYWxzQW5kUHJvb2YiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiUGxvbmtQcm9vZiI6W3sibmFtZSI6IkEiLCJ0eXBlIjoiYnl0ZVs5Nl0ifSx7Im5hbWUiOiJCIiwidHlwZSI6ImJ5dGVbOTZdIn0seyJuYW1lIjoiQyIsInR5cGUiOiJieXRlWzk2XSJ9LHsibmFtZSI6IloiLCJ0eXBlIjoiYnl0ZVs5Nl0ifSx7Im5hbWUiOiJUMSIsInR5cGUiOiJieXRlWzk2XSJ9LHsibmFtZSI6IlQyIiwidHlwZSI6ImJ5dGVbOTZdIn0seyJuYW1lIjoiVDMiLCJ0eXBlIjoiYnl0ZVs5Nl0ifSx7Im5hbWUiOiJXeGkiLCJ0eXBlIjoiYnl0ZVs5Nl0ifSx7Im5hbWUiOiJXeGl3IiwidHlwZSI6ImJ5dGVbOTZdIn0seyJuYW1lIjoiZXZhbF9hIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJldmFsX2IiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImV2YWxfYyIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZXZhbF9zMSIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZXZhbF9zMiIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZXZhbF96dyIsInR5cGUiOiJ1aW50MjU2In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InNpZ25hbHNBbmRQcm9vZiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaWduYWxzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIoYnl0ZVs5Nl0sYnl0ZVs5Nl0sYnl0ZVs5Nl0sYnl0ZVs5Nl0sYnl0ZVs5Nl0sYnl0ZVs5Nl0sYnl0ZVs5Nl0sYnl0ZVs5Nl0sYnl0ZVs5Nl0sdWludDI1Nix1aW50MjU2LHVpbnQyNTYsdWludDI1Nix1aW50MjU2LHVpbnQyNTYpIiwic3RydWN0IjoiUGxvbmtQcm9vZiIsIm5hbWUiOiJwcm9vZiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzQ0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDI1Nj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBjb250cmFjdHMvcGxvbmtfYmxzMTIzODEuYWxnby50czo6UGxvbmtQcm9vZiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNHeHZibXRmZG1WeWFXWnBaWEl1WVd4bmJ5NTBjem8yTmdvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGQnNiMjVyVTJsbmJtRnNjMEZ1WkZCeWIyOW1JR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURVS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURRMFlUUTNPRGhpSUM4dklHMWxkR2h2WkNBaWMybG5ibUZzYzBGdVpGQnliMjltS0hWcGJuUXlOVFpiWFN3b1lubDBaVnM1Tmwwc1lubDBaVnM1Tmwwc1lubDBaVnM1Tmwwc1lubDBaVnM1Tmwwc1lubDBaVnM1Tmwwc1lubDBaVnM1Tmwwc1lubDBaVnM1Tmwwc1lubDBaVnM1Tmwwc1lubDBaVnM1Tmwwc2RXbHVkREkxTml4MWFXNTBNalUyTEhWcGJuUXlOVFlzZFdsdWRESTFOaXgxYVc1ME1qVTJMSFZwYm5ReU5UWXBLWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnRZV2x1WDNOcFoyNWhiSE5CYm1SUWNtOXZabDl5YjNWMFpVQXpDaUFnSUNCbGNuSUtDbTFoYVc1ZmMybG5ibUZzYzBGdVpGQnliMjltWDNKdmRYUmxRRE02Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Y0d4dmJtdGZkbVZ5YVdacFpYSXVZV3huYnk1MGN6bzJOd29nSUNBZ0x5OGdjSFZpYkdsaklITnBaMjVoYkhOQmJtUlFjbTl2WmloemFXZHVZV3h6T2lCVmFXNTBNalUyVzEwc0lIQnliMjltT2lCUWJHOXVhMUJ5YjI5bUtUb2dkbTlwWkNCN2ZRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDWW1DaUFnSUNCaGMzTmxjblFLSUNBZ0lHSWdjMmxuYm1Gc2MwRnVaRkJ5YjI5bUNncHRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUExT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNCc2IyNXJYM1psY21sbWFXVnlMbUZzWjI4dWRITTZOallLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCUWJHOXVhMU5wWjI1aGJITkJibVJRY205dlppQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNBbUpnb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1kyOXVkSEpoWTNSekwzQnNiMjVyWDNabGNtbG1hV1Z5TG1Gc1oyOHVkSE02T2xCc2IyNXJVMmxuYm1Gc2MwRnVaRkJ5YjI5bUxuTnBaMjVoYkhOQmJtUlFjbTl2Wmx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTnBaMjVoYkhOQmJtUlFjbTl2WmpvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5d2JHOXVhMTkyWlhKcFptbGxjaTVoYkdkdkxuUnpPalkzQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjMmxuYm1Gc2MwRnVaRkJ5YjI5bUtITnBaMjVoYkhNNklGVnBiblF5TlRaYlhTd2djSEp2YjJZNklGQnNiMjVyVUhKdmIyWXBPaUIyYjJsa0lIdDlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnS2dvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblF5TlRZK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNVEExTmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZMjl1ZEhKaFkzUnpMM0JzYjI1clgySnNjekV5TXpneExtRnNaMjh1ZEhNNk9sQnNiMjVyVUhKdmIyWUtJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDekViUVFBWWdBUkVwSGlMTmhvQWpnRUFBUUF4R1JReEdCQkVRZ0FJTVJrVU1SZ1VFRU0yR2dGSmdRQlpnU0FMZ1FJSVRCVVNSRFlhQWhXQm9BZ1NSSUVCUXc9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjgsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
