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

namespace Arc56.Generated.funk_af.zk_colorsort.PuzzleScores_083758b5
{


    public class PuzzleScoresProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PuzzleScoresProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Groth16Bn254Proof : AVMObjectType
            {
                public byte[] PiA { get; set; }

                public byte[] PiB { get; set; }

                public byte[] PiC { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPiA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[64]");
                    vPiA.From(PiA);
                    ret.AddRange(vPiA.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPiB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[128]");
                    vPiB.From(PiB);
                    ret.AddRange(vPiB.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPiC = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[64]");
                    vPiC.From(PiC);
                    ret.AddRange(vPiC.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Groth16Bn254Proof Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Groth16Bn254Proof();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPiA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[64]");
                    count = vPiA.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePiA = vPiA.ToValue();
                    if (valuePiA is byte[] vPiAValue) { ret.PiA = vPiAValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPiB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[128]");
                    count = vPiB.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePiB = vPiB.ToValue();
                    if (valuePiB is byte[] vPiBValue) { ret.PiB = vPiBValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPiC = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[64]");
                    count = vPiC.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePiC = vPiC.ToValue();
                    if (valuePiC is byte[] vPiCValue) { ret.PiC = vPiCValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Groth16Bn254Proof);
                }
                public bool Equals(Groth16Bn254Proof? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Groth16Bn254Proof left, Groth16Bn254Proof right)
                {
                    return EqualityComparer<Groth16Bn254Proof>.Default.Equals(left, right);
                }
                public static bool operator !=(Groth16Bn254Proof left, Groth16Bn254Proof right)
                {
                    return !(left == right);
                }

            }

            public class GetMyScoreReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public bool Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetMyScoreReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetMyScoreReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is bool vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetMyScoreReturn);
                }
                public bool Equals(GetMyScoreReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetMyScoreReturn left, GetMyScoreReturn right)
                {
                    return EqualityComparer<GetMyScoreReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetMyScoreReturn left, GetMyScoreReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> BoxMbr(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 94, 246, 250, 53 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> BoxMbr_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 94, 246, 250, 53 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="verifierAddress"> </param>
        public async Task SetVerifier(Algorand.Address verifierAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 116, 85, 192, 169 };
            var verifierAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); verifierAddressAbi.From(verifierAddress);

            var result = await base.CallApp(new List<object> { abiHandle, verifierAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetVerifier_Transactions(Algorand.Address verifierAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 116, 85, 192, 169 };
            var verifierAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); verifierAddressAbi.From(verifierAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, verifierAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task UpdateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 247, 101, 51 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 247, 101, 51 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="signals"> </param>
        /// <param name="proof"> Groth16Bn254Proof</param>
        /// <param name="puzzleCode"> </param>
        /// <param name="score"> </param>
        /// <param name="payMbr"> </param>
        /// <param name="verifierTxn"> </param>
        public async Task AddScore(PaymentTransaction payMbr, PaymentTransaction verifierTxn, AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] signals, Structs.Groth16Bn254Proof proof, byte[] puzzleCode, ulong score, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payMbr, verifierTxn });
            byte[] abiHandle = { 145, 103, 231, 203 };
            var signalsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt256>("uint256"); signalsAbi.From(signals);
            var puzzleCodeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); puzzleCodeAbi.From(puzzleCode);
            var scoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); scoreAbi.From(score);

            var result = await base.CallApp(new List<object> { abiHandle, signalsAbi, proof, puzzleCodeAbi, scoreAbi, payMbr, verifierTxn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AddScore_Transactions(PaymentTransaction payMbr, PaymentTransaction verifierTxn, AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] signals, Structs.Groth16Bn254Proof proof, byte[] puzzleCode, ulong score, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payMbr, verifierTxn });
            byte[] abiHandle = { 145, 103, 231, 203 };
            var signalsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt256>("uint256"); signalsAbi.From(signals);
            var puzzleCodeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); puzzleCodeAbi.From(puzzleCode);
            var scoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); scoreAbi.From(score);

            return await base.MakeTransactionList(new List<object> { abiHandle, signalsAbi, proof, puzzleCodeAbi, scoreAbi, payMbr, verifierTxn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="signals"> </param>
        /// <param name="proof"> Groth16Bn254Proof</param>
        /// <param name="puzzleCode"> </param>
        /// <param name="newScore"> </param>
        /// <param name="verifierTxn"> </param>
        public async Task UpdateScore(PaymentTransaction verifierTxn, AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] signals, Structs.Groth16Bn254Proof proof, byte[] puzzleCode, ulong newScore, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { verifierTxn });
            byte[] abiHandle = { 116, 202, 118, 23 };
            var signalsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt256>("uint256"); signalsAbi.From(signals);
            var puzzleCodeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); puzzleCodeAbi.From(puzzleCode);
            var newScoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newScoreAbi.From(newScore);

            var result = await base.CallApp(new List<object> { abiHandle, signalsAbi, proof, puzzleCodeAbi, newScoreAbi, verifierTxn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateScore_Transactions(PaymentTransaction verifierTxn, AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] signals, Structs.Groth16Bn254Proof proof, byte[] puzzleCode, ulong newScore, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { verifierTxn });
            byte[] abiHandle = { 116, 202, 118, 23 };
            var signalsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt256>("uint256"); signalsAbi.From(signals);
            var puzzleCodeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); puzzleCodeAbi.From(puzzleCode);
            var newScoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newScoreAbi.From(newScore);

            return await base.MakeTransactionList(new List<object> { abiHandle, signalsAbi, proof, puzzleCodeAbi, newScoreAbi, verifierTxn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="puzzleCode"> </param>
        public async Task RemoveScore(byte[] puzzleCode, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 235, 214, 63, 130 };
            var puzzleCodeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); puzzleCodeAbi.From(puzzleCode);

            var result = await base.CallApp(new List<object> { abiHandle, puzzleCodeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RemoveScore_Transactions(byte[] puzzleCode, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 235, 214, 63, 130 };
            var puzzleCodeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); puzzleCodeAbi.From(puzzleCode);

            return await base.MakeTransactionList(new List<object> { abiHandle, puzzleCodeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="puzzleCode"> </param>
        public async Task<Structs.GetMyScoreReturn> GetMyScore(byte[] puzzleCode, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 127, 182, 175, 247 };
            var puzzleCodeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); puzzleCodeAbi.From(puzzleCode);

            var result = await base.SimApp(new List<object> { abiHandle, puzzleCodeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetMyScoreReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetMyScore_Transactions(byte[] puzzleCode, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 127, 182, 175, 247 };
            var puzzleCodeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); puzzleCodeAbi.From(puzzleCode);

            return await base.MakeTransactionList(new List<object> { abiHandle, puzzleCodeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="puzzleCode"> </param>
        /// <param name="user"> </param>
        public async Task<Structs.GetMyScoreReturn> GetScoreForUser(byte[] puzzleCode, Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 96, 10, 17, 91 };
            var puzzleCodeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); puzzleCodeAbi.From(puzzleCode);
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            var result = await base.SimApp(new List<object> { abiHandle, puzzleCodeAbi, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetMyScoreReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetScoreForUser_Transactions(byte[] puzzleCode, Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 96, 10, 17, 91 };
            var puzzleCodeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); puzzleCodeAbi.From(puzzleCode);
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            return await base.MakeTransactionList(new List<object> { abiHandle, puzzleCodeAbi, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUHV6emxlU2NvcmVzIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7Ikdyb3RoMTZCbjI1NFByb29mIjpbeyJuYW1lIjoicGlBIiwidHlwZSI6ImJ5dGVbNjRdIn0seyJuYW1lIjoicGlCIiwidHlwZSI6ImJ5dGVbMTI4XSJ9LHsibmFtZSI6InBpQyIsInR5cGUiOiJieXRlWzY0XSJ9XSwiR2V0TXlTY29yZVJldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoiYm9vbCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJib3hNYnIiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldFZlcmlmaWVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2ZXJpZmllckFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlQXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJVcGRhdGVBcHBsaWNhdGlvbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFkZFNjb3JlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTZbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNpZ25hbHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6IihieXRlWzY0XSxieXRlWzEyOF0sYnl0ZVs2NF0pIiwic3RydWN0IjoiR3JvdGgxNkJuMjU0UHJvb2YiLCJuYW1lIjoicHJvb2YiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InB1enpsZUNvZGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNjb3JlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXlNYnIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZlcmlmaWVyVHhuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZVNjb3JlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTZbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNpZ25hbHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6IihieXRlWzY0XSxieXRlWzEyOF0sYnl0ZVs2NF0pIiwic3RydWN0IjoiR3JvdGgxNkJuMjU0UHJvb2YiLCJuYW1lIjoicHJvb2YiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InB1enpsZUNvZGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld1Njb3JlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2ZXJpZmllclR4biIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZW1vdmVTY29yZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwdXp6bGVDb2RlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldE15U2NvcmUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHV6emxlQ29kZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LGJvb2wpIiwic3RydWN0IjoiR2V0TXlTY29yZVJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0U2NvcmVGb3JVc2VyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InB1enpsZUNvZGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsYm9vbCkiLCJzdHJ1Y3QiOiJHZXRNeVNjb3JlUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzQ3XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0NF0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AgJiYgY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTMzXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgVXBkYXRlQXBwbGljYXRpb24gJiYgY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4MCwyMDYsMzI2LDM1Miw0MzAsNDY5LDQ5Niw1ODZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTAsMzM2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQyNTY+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjEzLDM1OSw0MzcsNDc2LDUwM10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTUsNTE1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyNCwzNzBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDAsMzQ2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGNvbnRyYWN0cy9QdXp6bGVTY29yZXMuYWxnby50czo6R3JvdGgxNkJuMjU0UHJvb2YiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MTZdLCJlcnJvck1lc3NhZ2UiOiJuZXcgc2NvcmUgbXVzdCBiZSBiZXR0ZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjFdLCJlcnJvck1lc3NhZ2UiOiJvbmx5IHRoZSBjcmVhdG9yIGNhbiBzZXQgdGhlIHZlcmlmaWVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTcyXSwiZXJyb3JNZXNzYWdlIjoib25seSB0aGUgY3JlYXRvciBjYW4gdXBkYXRlIHRoZSBhcHAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMTJdLCJlcnJvck1lc3NhZ2UiOiJwYXltZW50IG11c3QgY292ZXIgYm94IE1CUiBleGFjdGx5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzA1XSwiZXJyb3JNZXNzYWdlIjoicGF5bWVudCByZWNlaXZlciBtdXN0IGJlIGFwcCBhY2NvdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjkxXSwiZXJyb3JNZXNzYWdlIjoicGF5bWVudCBzZW5kZXIgbXVzdCBtYXRjaCBjYWxsZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3OTddLCJlcnJvck1lc3NhZ2UiOiJwdWJsaWMgcHV6emxlIGNvZGUgbXVzdCBtYXRjaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc5NF0sImVycm9yTWVzc2FnZSI6InB1YmxpYyBzY29yZSBtdXN0IG1hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzk4XSwiZXJyb3JNZXNzYWdlIjoicHVibGljIHNlbmRlciBtdXN0IG1hdGNoIGNhbGxlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU4OV0sImVycm9yTWVzc2FnZSI6InB1YmxpYyBzaWduYWxzIGxlbmd0aCBpcyBpbnZhbGlkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTk3XSwiZXJyb3JNZXNzYWdlIjoicHV6emxlIGNvZGUgbGVuZ3RoIGlzIGludmFsaWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNjNdLCJlcnJvck1lc3NhZ2UiOiJzY29yZSBhbHJlYWR5IGV4aXN0cyBmb3IgcHV6emxlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzk2LDQ0NV0sImVycm9yTWVzc2FnZSI6InNjb3JlIGRvZXMgbm90IGV4aXN0IGZvciBwdXp6bGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNTIsMzg4XSwiZXJyb3JNZXNzYWdlIjoic2NvcmUgZXhjZWVkcyBvbmUtYnl0ZSBzdG9yYWdlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjM1LDI0NSwzODFdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU2OF0sImVycm9yTWVzc2FnZSI6InZlcmlmaWVyIGlzIG5vdCBjb25maWd1cmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTc0XSwiZXJyb3JNZXNzYWdlIjoidmVyaWZpZXIgdHhuIG11c3QgY29tZSBmcm9tIHRoZSB2ZXJpZmllciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU4Ml0sImVycm9yTWVzc2FnZSI6InZlcmlmaWVyIHR4biByZWNlaXZlciBtdXN0IGJlIGFwcCBhY2NvdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3SURJZ09DQXlNemN3TUFvZ0lDQWdZbmwwWldOaWJHOWpheUFpZG1WeWFXWnBaWElpSURCNE1UVXhaamRqTnpVS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5UWRYcDZiR1ZUWTI5eVpYTXVZV3huYnk1MGN6bzBOd29nSUNBZ0x5OGdaWGh3YjNKMElHUmxabUYxYkhRZ1kyeGhjM01nVUhWNmVteGxVMk52Y21WeklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRREUyQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcwTm1ZM05qVXpNeUF2THlCdFpYUm9iMlFnSW5Wd1pHRjBaVUZ3Y0d4cFkyRjBhVzl1S0NsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOTFjR1JoZEdWQmNIQnNhV05oZEdsdmJsOXliM1YwWlVBekNncHRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTkRvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5UWRYcDZiR1ZUWTI5eVpYTXVZV3huYnk1MGN6bzBOd29nSUNBZ0x5OGdaWGh3YjNKMElHUmxabUYxYkhRZ1kyeGhjM01nVUhWNmVteGxVMk52Y21WeklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnRkWE4wSUdKbElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IZzFaV1kyWm1Fek5TQXdlRGMwTlRWak1HRTVJREI0T1RFMk4yVTNZMklnTUhnM05HTmhOell4TnlBd2VHVmlaRFl6WmpneUlEQjROMlppTm1GbVpqY2dNSGcyTURCaE1URTFZaUF2THlCdFpYUm9iMlFnSW1KdmVFMWljaWdwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0p6WlhSV1pYSnBabWxsY2loaFpHUnlaWE56S1hadmFXUWlMQ0J0WlhSb2IyUWdJbUZrWkZOamIzSmxLSFZwYm5ReU5UWmJYU3dvWW5sMFpWczJORjBzWW5sMFpWc3hNamhkTEdKNWRHVmJOalJkS1N4aWVYUmxXMTBzZFdsdWREWTBMSEJoZVN4d1lYa3BkbTlwWkNJc0lHMWxkR2h2WkNBaWRYQmtZWFJsVTJOdmNtVW9kV2x1ZERJMU5sdGRMQ2hpZVhSbFd6WTBYU3hpZVhSbFd6RXlPRjBzWW5sMFpWczJORjBwTEdKNWRHVmJYU3gxYVc1ME5qUXNjR0Y1S1hadmFXUWlMQ0J0WlhSb2IyUWdJbkpsYlc5MlpWTmpiM0psS0dKNWRHVmJYU2wyYjJsa0lpd2diV1YwYUc5a0lDSm5aWFJOZVZOamIzSmxLR0o1ZEdWYlhTa29kV2x1ZERZMExHSnZiMndwSWl3Z2JXVjBhRzlrSUNKblpYUlRZMjl5WlVadmNsVnpaWElvWW5sMFpWdGRMR0ZrWkhKbGMzTXBLSFZwYm5RMk5DeGliMjlzS1NJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmWW05NFRXSnlYM0p2ZFhSbFFEWWdjMlYwVm1WeWFXWnBaWElnWVdSa1UyTnZjbVVnZFhCa1lYUmxVMk52Y21VZ2NtVnRiM1psVTJOdmNtVWdaMlYwVFhsVFkyOXlaU0JuWlhSVFkyOXlaVVp2Y2xWelpYSUtJQ0FnSUdWeWNnb0tiV0ZwYmw5aWIzaE5ZbkpmY205MWRHVkFOam9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlRZFhwNmJHVlRZMjl5WlhNdVlXeG5ieTUwY3pvMU1DMDFNUW9nSUNBZ0x5OGdRSEpsWVdSdmJteDVDaUFnSUNBdkx5QndkV0pzYVdNZ1ltOTRUV0p5S0NrNklIVnBiblEyTkNCN0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlRBd01EQXdNREF3TURBd01EVmpPVFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTFjR1JoZEdWQmNIQnNhV05oZEdsdmJsOXliM1YwWlVBek9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxQjFlbnBzWlZOamIzSmxjeTVoYkdkdkxuUnpPall6Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkWEJrWVhSbFFYQndiR2xqWVhScGIyNG9LVG9nZG05cFpDQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQndkWE5vYVc1MElEUWdMeThnVlhCa1lYUmxRWEJ3YkdsallYUnBiMjRLSUNBZ0lEMDlDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdKaVlLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYlhWemRDQmlaU0JWY0dSaGRHVkJjSEJzYVdOaGRHbHZiaUFtSmlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCaUlIVndaR0YwWlVGd2NHeHBZMkYwYVc5dUNncHRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUF4TmpvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5UWRYcDZiR1ZUWTI5eVpYTXVZV3huYnk1MGN6bzBOd29nSUNBZ0x5OGdaWGh3YjNKMElHUmxabUYxYkhRZ1kyeGhjM01nVUhWNmVteGxVMk52Y21WeklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHMTFjM1FnWW1VZ1RtOVBjQ0FtSmlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z1kzSmxZWFJwYm1jS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJqYjI1MGNtRmpkSE12VUhWNmVteGxVMk52Y21WekxtRnNaMjh1ZEhNNk9sQjFlbnBzWlZOamIzSmxjeTV6WlhSV1pYSnBabWxsY2x0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRlpsY21sbWFXVnlPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMUIxZW5wc1pWTmpiM0psY3k1aGJHZHZMblJ6T2pVMUNpQWdJQ0F2THlCd2RXSnNhV01nYzJWMFZtVnlhV1pwWlhJb2RtVnlhV1pwWlhKQlpHUnlaWE56T2lCQlkyTnZkVzUwS1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlVIVjZlbXhsVTJOdmNtVnpMbUZzWjI4dWRITTZOVGNLSUNBZ0lDOHZJRlI0Ymk1elpXNWtaWElnUFQwOUlFZHNiMkpoYkM1amNtVmhkRzl5UVdSa2NtVnpjeXdLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdkc2IySmhiQ0JEY21WaGRHOXlRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5UWRYcDZiR1ZUWTI5eVpYTXVZV3huYnk1MGN6bzFOaTAxT1FvZ0lDQWdMeThnWVhOelpYSjBLQW9nSUNBZ0x5OGdJQ0JVZUc0dWMyVnVaR1Z5SUQwOVBTQkhiRzlpWVd3dVkzSmxZWFJ2Y2tGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNKdmJteDVJSFJvWlNCamNtVmhkRzl5SUdOaGJpQnpaWFFnZEdobElIWmxjbWxtYVdWeUlpd0tJQ0FnSUM4dklDazdDaUFnSUNCaGMzTmxjblFnTHk4Z2IyNXNlU0IwYUdVZ1kzSmxZWFJ2Y2lCallXNGdjMlYwSUhSb1pTQjJaWEpwWm1sbGNnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxQjFlbnBzWlZOamIzSmxjeTVoYkdkdkxuUnpPalE0Q2lBZ0lDQXZMeUIyWlhKcFptbGxjaUE5SUVkc2IySmhiRk4wWVhSbFBFRmpZMjkxYm5RK0tIc2dhMlY1T2lBaWRtVnlhV1pwWlhJaUlIMHBPd29nSUNBZ1lubDBaV05mTUNBdkx5QWlkbVZ5YVdacFpYSWlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZVSFY2ZW14bFUyTnZjbVZ6TG1Gc1oyOHVkSE02TmpBS0lDQWdJQzh2SUhSb2FYTXVkbVZ5YVdacFpYSXVkbUZzZFdVZ1BTQjJaWEpwWm1sbGNrRmtaSEpsYzNNN0NpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxQjFlbnBzWlZOamIzSmxjeTVoYkdkdkxuUnpPalUxQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjMlYwVm1WeWFXWnBaWElvZG1WeWFXWnBaWEpCWkdSeVpYTnpPaUJCWTJOdmRXNTBLVG9nZG05cFpDQjdDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1kyOXVkSEpoWTNSekwxQjFlbnBzWlZOamIzSmxjeTVoYkdkdkxuUnpPanBRZFhwNmJHVlRZMjl5WlhNdWRYQmtZWFJsUVhCd2JHbGpZWFJwYjI1YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDFjR1JoZEdWQmNIQnNhV05oZEdsdmJqb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVFkWHA2YkdWVFkyOXlaWE11WVd4bmJ5NTBjem8yTlFvZ0lDQWdMeThnVkhodUxuTmxibVJsY2lBOVBUMGdSMnh2WW1Gc0xtTnlaV0YwYjNKQlpHUnlaWE56TEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1oyeHZZbUZzSUVOeVpXRjBiM0pCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxQjFlbnBzWlZOamIzSmxjeTVoYkdkdkxuUnpPalkwTFRZM0NpQWdJQ0F2THlCaGMzTmxjblFvQ2lBZ0lDQXZMeUFnSUZSNGJpNXpaVzVrWlhJZ1BUMDlJRWRzYjJKaGJDNWpjbVZoZEc5eVFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0ltOXViSGtnZEdobElHTnlaV0YwYjNJZ1kyRnVJSFZ3WkdGMFpTQjBhR1VnWVhCd0lpd0tJQ0FnSUM4dklDazdDaUFnSUNCaGMzTmxjblFnTHk4Z2IyNXNlU0IwYUdVZ1kzSmxZWFJ2Y2lCallXNGdkWEJrWVhSbElIUm9aU0JoY0hBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5UWRYcDZiR1ZUWTI5eVpYTXVZV3huYnk1MGN6bzJNd29nSUNBZ0x5OGdjSFZpYkdsaklIVndaR0YwWlVGd2NHeHBZMkYwYVc5dUtDazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdOdmJuUnlZV04wY3k5UWRYcDZiR1ZUWTI5eVpYTXVZV3huYnk1MGN6bzZVSFY2ZW14bFUyTnZjbVZ6TG1Ga1pGTmpiM0psVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1lXUmtVMk52Y21VNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlVIVjZlbXhsVTJOdmNtVnpMbUZzWjI4dWRITTZOekF0TnpjS0lDQWdJQzh2SUhCMVlteHBZeUJoWkdSVFkyOXlaU2dLSUNBZ0lDOHZJQ0FnYzJsbmJtRnNjem9nVUhWaWJHbGpVMmxuYm1Gc2N5d0tJQ0FnSUM4dklDQWdjSEp2YjJZNklFZHliM1JvTVRaQ2JqSTFORkJ5YjI5bUxBb2dJQ0FnTHk4Z0lDQndkWHA2YkdWRGIyUmxPaUJpZVhSbGN5d0tJQ0FnSUM4dklDQWdjMk52Y21VNklIVnBiblEyTkN3S0lDQWdJQzh2SUNBZ2NHRjVUV0p5T2lCbmRIaHVMbEJoZVcxbGJuUlVlRzRzQ2lBZ0lDQXZMeUFnSUhabGNtbG1hV1Z5VkhodU9pQm5kSGh1TGxCaGVXMWxiblJVZUc0c0NpQWdJQ0F2THlBcE9pQjJiMmxrSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTXpJZ0x5OGdNeklLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBNalUyUGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ01qVTJJQzh2SURJMU5nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWTI5dWRISmhZM1J6TDFCMWVucHNaVk5qYjNKbGN5NWhiR2R2TG5Sek9qcEhjbTkwYURFMlFtNHlOVFJRY205dlpnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdENpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnY0dGNUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFJ5WVc1ellXTjBhVzl1SUhSNWNHVWdhWE1nY0dGNUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlVIVjZlbXhsVTJOdmNtVnpMbUZzWjI4dWRITTZOemdLSUNBZ0lDOHZJR0Z6YzJWeWRDaHpZMjl5WlNBOFBTQk5RVmhmVTFSUFVrVkVYMU5EVDFKRkxDQWljMk52Y21VZ1pYaGpaV1ZrY3lCdmJtVXRZbmwwWlNCemRHOXlZV2RsSWlrN0NpQWdJQ0JrYVdjZ01nb2dJQ0FnY0hWemFHbHVkQ0F5TlRVZ0x5OGdNalUxQ2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklITmpiM0psSUdWNFkyVmxaSE1nYjI1bExXSjVkR1VnYzNSdmNtRm5aUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMUIxZW5wc1pWTmpiM0psY3k1aGJHZHZMblJ6T2pFMU5Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhCMWVucHNaVU52WkdVdVkyOXVZMkYwS0hWelpYSXVZbmwwWlhNcE93b2dJQ0FnWkdsbklETUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVFkWHA2YkdWVFkyOXlaWE11WVd4bmJ5NTBjem80TUFvZ0lDQWdMeThnWTI5dWMzUWdhMlY1SUQwZ2RHaHBjeTV6WTI5eVpVdGxlU2h3ZFhwNmJHVkRiMlJsTENCVWVHNHVjMlZ1WkdWeUtUc0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5UWRYcDZiR1ZUWTI5eVpYTXVZV3huYnk1MGN6b3hOVFFLSUNBZ0lDOHZJSEpsZEhWeWJpQndkWHA2YkdWRGIyUmxMbU52Ym1OaGRDaDFjMlZ5TG1KNWRHVnpLVHNLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFCMWVucHNaVk5qYjNKbGN5NWhiR2R2TG5Sek9qZ3hDaUFnSUNBdkx5QmpiMjV6ZENCYkxDQmxlR2x6ZEhOZElEMGdRbTk0VDNBdVoyVjBLR3RsZVNrN0NpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMUIxZW5wc1pWTmpiM0psY3k1aGJHZHZMblJ6T2pneUNpQWdJQ0F2THlCaGMzTmxjblFvSVdWNGFYTjBjeXdnSW5OamIzSmxJR0ZzY21WaFpIa2daWGhwYzNSeklHWnZjaUJ3ZFhwNmJHVWlLVHNLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCelkyOXlaU0JoYkhKbFlXUjVJR1Y0YVhOMGN5Qm1iM0lnY0hWNmVteGxDaUFnSUNBdkx5QmpiMjUwY21GamRITXZVSFY2ZW14bFUyTnZjbVZ6TG1Gc1oyOHVkSE02T0RRS0lDQWdJQzh2SUhSb2FYTXVkbVZ5YVdaNVZtVnlhV1pwWlhKVWVHNG9kbVZ5YVdacFpYSlVlRzRzSUhOcFoyNWhiSE1zSUhCeWIyOW1MQ0J3ZFhwNmJHVkRiMlJsTENCelkyOXlaU2s3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCa2FXY2dOZ29nSUNBZ1kyRnNiSE4xWWlCMlpYSnBabmxXWlhKcFptbGxjbFI0YmdvZ0lDQWdjRzl3YmlBeUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlVIVjZlbXhsVTJOdmNtVnpMbUZzWjI4dWRITTZPRGdLSUNBZ0lDOHZJRlI0Ymk1elpXNWtaWEl1WW5sMFpYTUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5UWRYcDZiR1ZUWTI5eVpYTXVZV3huYnk1MGN6bzRPQzA0T1FvZ0lDQWdMeThnVkhodUxuTmxibVJsY2k1aWVYUmxjd29nSUNBZ0x5OGdJQ0F1YzJ4cFkyVW9NQ3dnVldsdWREWTBLRE15S1NrS0lDQWdJSE4xWW5OMGNtbHVaeUF3SURNeUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlVIVjZlbXhsVTJOdmNtVnpMbUZzWjI4dWRITTZPVEFLSUNBZ0lDOHZJQzVsY1hWaGJITW9jR0Y1VFdKeUxuTmxibVJsY2k1aWVYUmxjeTV6YkdsalpTZ3dMQ0JWYVc1ME5qUW9NeklwS1Nrc0NpQWdJQ0JrYVdjZ01nb2dJQ0FnWjNSNGJuTWdVMlZ1WkdWeUNpQWdJQ0J6ZFdKemRISnBibWNnTUNBek1nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxQjFlbnBzWlZOamIzSmxjeTVoYkdkdkxuUnpPamc0TFRrd0NpQWdJQ0F2THlCVWVHNHVjMlZ1WkdWeUxtSjVkR1Z6Q2lBZ0lDQXZMeUFnSUM1emJHbGpaU2d3TENCVmFXNTBOalFvTXpJcEtRb2dJQ0FnTHk4Z0lDQXVaWEYxWVd4ektIQmhlVTFpY2k1elpXNWtaWEl1WW5sMFpYTXVjMnhwWTJVb01Dd2dWV2x1ZERZMEtETXlLU2twTEFvZ0lDQWdQVDBLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlRZFhwNmJHVlRZMjl5WlhNdVlXeG5ieTUwY3pvNE55MDVNZ29nSUNBZ0x5OGdZWE56WlhKMEtBb2dJQ0FnTHk4Z0lDQlVlRzR1YzJWdVpHVnlMbUo1ZEdWekNpQWdJQ0F2THlBZ0lDQWdMbk5zYVdObEtEQXNJRlZwYm5RMk5DZ3pNaWtwQ2lBZ0lDQXZMeUFnSUNBZ0xtVnhkV0ZzY3lod1lYbE5Zbkl1YzJWdVpHVnlMbUo1ZEdWekxuTnNhV05sS0RBc0lGVnBiblEyTkNnek1pa3BLU3dLSUNBZ0lDOHZJQ0FnSW5CaGVXMWxiblFnYzJWdVpHVnlJRzExYzNRZ2JXRjBZMmdnWTJGc2JHVnlJaXdLSUNBZ0lDOHZJQ2s3Q2lBZ0lDQmhjM05sY25RZ0x5OGdjR0Y1YldWdWRDQnpaVzVrWlhJZ2JYVnpkQ0J0WVhSamFDQmpZV3hzWlhJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5UWRYcDZiR1ZUWTI5eVpYTXVZV3huYnk1MGN6bzVOQW9nSUNBZ0x5OGdSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNdVlubDBaWE1LSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VUhWNmVteGxVMk52Y21WekxtRnNaMjh1ZEhNNk9UUXRPVFVLSUNBZ0lDOHZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxtSjVkR1Z6Q2lBZ0lDQXZMeUFnSUM1emJHbGpaU2d3TENCVmFXNTBOalFvTXpJcEtRb2dJQ0FnYzNWaWMzUnlhVzVuSURBZ016SUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVFkWHA2YkdWVFkyOXlaWE11WVd4bmJ5NTBjem81TmdvZ0lDQWdMeThnTG1WeGRXRnNjeWh3WVhsTlluSXVjbVZqWldsMlpYSXVZbmwwWlhNdWMyeHBZMlVvTUN3Z1ZXbHVkRFkwS0RNeUtTa3BMQW9nSUNBZ1pHbG5JRElLSUNBZ0lHZDBlRzV6SUZKbFkyVnBkbVZ5Q2lBZ0lDQnpkV0p6ZEhKcGJtY2dNQ0F6TWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFCMWVucHNaVk5qYjNKbGN5NWhiR2R2TG5Sek9qazBMVGsyQ2lBZ0lDQXZMeUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5NWllWFJsY3dvZ0lDQWdMeThnSUNBdWMyeHBZMlVvTUN3Z1ZXbHVkRFkwS0RNeUtTa0tJQ0FnSUM4dklDQWdMbVZ4ZFdGc2N5aHdZWGxOWW5JdWNtVmpaV2wyWlhJdVlubDBaWE11YzJ4cFkyVW9NQ3dnVldsdWREWTBLRE15S1NrcExBb2dJQ0FnUFQwS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5UWRYcDZiR1ZUWTI5eVpYTXVZV3huYnk1MGN6bzVNeTA1T0FvZ0lDQWdMeThnWVhOelpYSjBLQW9nSUNBZ0x5OGdJQ0JIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5NWllWFJsY3dvZ0lDQWdMeThnSUNBZ0lDNXpiR2xqWlNnd0xDQlZhVzUwTmpRb016SXBLUW9nSUNBZ0x5OGdJQ0FnSUM1bGNYVmhiSE1vY0dGNVRXSnlMbkpsWTJWcGRtVnlMbUo1ZEdWekxuTnNhV05sS0RBc0lGVnBiblEyTkNnek1pa3BLU3dLSUNBZ0lDOHZJQ0FnSW5CaGVXMWxiblFnY21WalpXbDJaWElnYlhWemRDQmlaU0JoY0hBZ1lXTmpiM1Z1ZENJc0NpQWdJQ0F2THlBcE93b2dJQ0FnWVhOelpYSjBJQzh2SUhCaGVXMWxiblFnY21WalpXbDJaWElnYlhWemRDQmlaU0JoY0hBZ1lXTmpiM1Z1ZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFCMWVucHNaVk5qYjNKbGN5NWhiR2R2TG5Sek9qazVDaUFnSUNBdkx5QmhjM05sY25Rb2NHRjVUV0p5TG1GdGIzVnVkQ0E5UFQwZ2NtVnhkV2x5WldSTlluSXNJQ0p3WVhsdFpXNTBJRzExYzNRZ1kyOTJaWElnWW05NElFMUNVaUJsZUdGamRHeDVJaWs3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlRZFhwNmJHVlRZMjl5WlhNdVlXeG5ieTUwY3pveE5UZ0tJQ0FnSUM4dklISmxkSFZ5YmlCQ1QxaGZRa0ZUUlY5TlFsSWdLeUJDVDFoZlFsbFVSVjlOUWxJZ0tpQW9VME5QVWtWZlMwVlpYMHhGVGtkVVNDQXJJRk5EVDFKRlgweEZUa2RVU0NrN0NpQWdJQ0JwYm5SaklEUWdMeThnTWpNM01EQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVFkWHA2YkdWVFkyOXlaWE11WVd4bmJ5NTBjem81T1FvZ0lDQWdMeThnWVhOelpYSjBLSEJoZVUxaWNpNWhiVzkxYm5RZ1BUMDlJSEpsY1hWcGNtVmtUV0p5TENBaWNHRjViV1Z1ZENCdGRYTjBJR052ZG1WeUlHSnZlQ0JOUWxJZ1pYaGhZM1JzZVNJcE93b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ3WVhsdFpXNTBJRzExYzNRZ1kyOTJaWElnWW05NElFMUNVaUJsZUdGamRHeDVDaUFnSUNBdkx5QmpiMjUwY21GamRITXZVSFY2ZW14bFUyTnZjbVZ6TG1Gc1oyOHVkSE02TVRZeUNpQWdJQ0F2THlCeVpYUjFjbTRnYVhSdllpaHpZMjl5WlNrdWMyeHBZMlVvVldsdWREWTBLRGNwTENCVmFXNTBOalFvT0NrcE93b2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnYzNWaWMzUnlhVzVuSURjZ09Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxQjFlbnBzWlZOamIzSmxjeTVoYkdkdkxuUnpPakV3TVFvZ0lDQWdMeThnUW05NFQzQXVjSFYwS0d0bGVTd2dkR2hwY3k1bGJtTnZaR1ZUWTI5eVpVSjVkR1VvYzJOdmNtVXBLVHNLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5UWRYcDZiR1ZUWTI5eVpYTXVZV3huYnk1MGN6bzNNQzAzTndvZ0lDQWdMeThnY0hWaWJHbGpJR0ZrWkZOamIzSmxLQW9nSUNBZ0x5OGdJQ0J6YVdkdVlXeHpPaUJRZFdKc2FXTlRhV2R1WVd4ekxBb2dJQ0FnTHk4Z0lDQndjbTl2WmpvZ1IzSnZkR2d4TmtKdU1qVTBVSEp2YjJZc0NpQWdJQ0F2THlBZ0lIQjFlbnBzWlVOdlpHVTZJR0o1ZEdWekxBb2dJQ0FnTHk4Z0lDQnpZMjl5WlRvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCd1lYbE5Zbkk2SUdkMGVHNHVVR0Y1YldWdWRGUjRiaXdLSUNBZ0lDOHZJQ0FnZG1WeWFXWnBaWEpVZUc0NklHZDBlRzR1VUdGNWJXVnVkRlI0Yml3S0lDQWdJQzh2SUNrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR052Ym5SeVlXTjBjeTlRZFhwNmJHVlRZMjl5WlhNdVlXeG5ieTUwY3pvNlVIVjZlbXhsVTJOdmNtVnpMblZ3WkdGMFpWTmpiM0psVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RYQmtZWFJsVTJOdmNtVTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZVSFY2ZW14bFUyTnZjbVZ6TG1Gc1oyOHVkSE02TVRBMExURXhNQW9nSUNBZ0x5OGdjSFZpYkdsaklIVndaR0YwWlZOamIzSmxLQW9nSUNBZ0x5OGdJQ0J6YVdkdVlXeHpPaUJRZFdKc2FXTlRhV2R1WVd4ekxBb2dJQ0FnTHk4Z0lDQndjbTl2WmpvZ1IzSnZkR2d4TmtKdU1qVTBVSEp2YjJZc0NpQWdJQ0F2THlBZ0lIQjFlbnBzWlVOdlpHVTZJR0o1ZEdWekxBb2dJQ0FnTHk4Z0lDQnVaWGRUWTI5eVpUb2dkV2x1ZERZMExBb2dJQ0FnTHk4Z0lDQjJaWEpwWm1sbGNsUjRiam9nWjNSNGJpNVFZWGx0Wlc1MFZIaHVMQW9nSUNBZ0x5OGdLVG9nZG05cFpDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQndkWE5vYVc1MElETXlJQzh2SURNeUNpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERJMU5qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJREkxTmlBdkx5QXlOVFlLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHTnZiblJ5WVdOMGN5OVFkWHA2YkdWVFkyOXlaWE11WVd4bmJ5NTBjem82UjNKdmRHZ3hOa0p1TWpVMFVISnZiMllLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUJ3WVhrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJ3WVhrS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5UWRYcDZiR1ZUWTI5eVpYTXVZV3huYnk1MGN6b3hNVEVLSUNBZ0lDOHZJR0Z6YzJWeWRDaHVaWGRUWTI5eVpTQThQU0JOUVZoZlUxUlBVa1ZFWDFORFQxSkZMQ0FpYzJOdmNtVWdaWGhqWldWa2N5QnZibVV0WW5sMFpTQnpkRzl5WVdkbElpazdDaUFnSUNCa2FXY2dNUW9nSUNBZ2NIVnphR2x1ZENBeU5UVWdMeThnTWpVMUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJSE5qYjNKbElHVjRZMlZsWkhNZ2IyNWxMV0o1ZEdVZ2MzUnZjbUZuWlFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFCMWVucHNaVk5qYjNKbGN5NWhiR2R2TG5Sek9qRTFOQW9nSUNBZ0x5OGdjbVYwZFhKdUlIQjFlbnBzWlVOdlpHVXVZMjl1WTJGMEtIVnpaWEl1WW5sMFpYTXBPd29nSUNBZ1pHbG5JRElLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlRZFhwNmJHVlRZMjl5WlhNdVlXeG5ieTUwY3pveE1UTUtJQ0FnSUM4dklHTnZibk4wSUd0bGVTQTlJSFJvYVhNdWMyTnZjbVZMWlhrb2NIVjZlbXhsUTI5a1pTd2dWSGh1TG5ObGJtUmxjaWs3Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZVSFY2ZW14bFUyTnZjbVZ6TG1Gc1oyOHVkSE02TVRVMENpQWdJQ0F2THlCeVpYUjFjbTRnY0hWNmVteGxRMjlrWlM1amIyNWpZWFFvZFhObGNpNWllWFJsY3lrN0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVFkWHA2YkdWVFkyOXlaWE11WVd4bmJ5NTBjem94TVRRS0lDQWdJQzh2SUdOdmJuTjBJRnR6WTI5eVpVSjVkR1Z6TENCbGVHbHpkSE5kSUQwZ1FtOTRUM0F1WjJWMEtHdGxlU2s3Q2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5UWRYcDZiR1ZUWTI5eVpYTXVZV3huYnk1MGN6b3hNVFVLSUNBZ0lDOHZJR0Z6YzJWeWRDaGxlR2x6ZEhNc0lDSnpZMjl5WlNCa2IyVnpJRzV2ZENCbGVHbHpkQ0JtYjNJZ2NIVjZlbXhsSWlrN0NpQWdJQ0JoYzNObGNuUWdMeThnYzJOdmNtVWdaRzlsY3lCdWIzUWdaWGhwYzNRZ1ptOXlJSEIxZW5wc1pRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxQjFlbnBzWlZOamIzSmxjeTVoYkdkdkxuUnpPakV4TndvZ0lDQWdMeThnZEdocGN5NTJaWEpwWm5sV1pYSnBabWxsY2xSNGJpaDJaWEpwWm1sbGNsUjRiaXdnYzJsbmJtRnNjeXdnY0hKdmIyWXNJSEIxZW5wc1pVTnZaR1VzSUc1bGQxTmpiM0psS1RzS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWkdsbklEWUtJQ0FnSUdOaGJHeHpkV0lnZG1WeWFXWjVWbVZ5YVdacFpYSlVlRzRLSUNBZ0lIQnZjRzRnTWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFCMWVucHNaVk5qYjNKbGN5NWhiR2R2TG5Sek9qRXhPUW9nSUNBZ0x5OGdZWE56WlhKMEtHNWxkMU5qYjNKbElEd2dZblJ2YVNoelkyOXlaVUo1ZEdWektTd2dJbTVsZHlCelkyOXlaU0J0ZFhOMElHSmxJR0psZEhSbGNpSXBPd29nSUNBZ1luUnZhUW9nSUNBZ1pHbG5JRElLSUNBZ0lENEtJQ0FnSUdGemMyVnlkQ0F2THlCdVpYY2djMk52Y21VZ2JYVnpkQ0JpWlNCaVpYUjBaWElLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlRZFhwNmJHVlRZMjl5WlhNdVlXeG5ieTUwY3pveE5qSUtJQ0FnSUM4dklISmxkSFZ5YmlCcGRHOWlLSE5qYjNKbEtTNXpiR2xqWlNoVmFXNTBOalFvTnlrc0lGVnBiblEyTkNnNEtTazdDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNCemRXSnpkSEpwYm1jZ055QTRDaUFnSUNBdkx5QmpiMjUwY21GamRITXZVSFY2ZW14bFUyTnZjbVZ6TG1Gc1oyOHVkSE02TVRJd0NpQWdJQ0F2THlCQ2IzaFBjQzV3ZFhRb2EyVjVMQ0IwYUdsekxtVnVZMjlrWlZOamIzSmxRbmwwWlNodVpYZFRZMjl5WlNrcE93b2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMUIxZW5wc1pWTmpiM0psY3k1aGJHZHZMblJ6T2pFd05DMHhNVEFLSUNBZ0lDOHZJSEIxWW14cFl5QjFjR1JoZEdWVFkyOXlaU2dLSUNBZ0lDOHZJQ0FnYzJsbmJtRnNjem9nVUhWaWJHbGpVMmxuYm1Gc2N5d0tJQ0FnSUM4dklDQWdjSEp2YjJZNklFZHliM1JvTVRaQ2JqSTFORkJ5YjI5bUxBb2dJQ0FnTHk4Z0lDQndkWHA2YkdWRGIyUmxPaUJpZVhSbGN5d0tJQ0FnSUM4dklDQWdibVYzVTJOdmNtVTZJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDQWdkbVZ5YVdacFpYSlVlRzQ2SUdkMGVHNHVVR0Y1YldWdWRGUjRiaXdLSUNBZ0lDOHZJQ2s2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTnZiblJ5WVdOMGN5OVFkWHA2YkdWVFkyOXlaWE11WVd4bmJ5NTBjem82VUhWNmVteGxVMk52Y21WekxuSmxiVzkyWlZOamIzSmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY21WdGIzWmxVMk52Y21VNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlVIVjZlbXhsVTJOdmNtVnpMbUZzWjI4dWRITTZNVEl6Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjbVZ0YjNabFUyTnZjbVVvY0hWNmVteGxRMjlrWlRvZ1lubDBaWE1wT2lCMmIybGtJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlVIVjZlbXhsVTJOdmNtVnpMbUZzWjI4dWRITTZNVEkwQ2lBZ0lDQXZMeUJqYjI1emRDQnJaWGtnUFNCMGFHbHpMbk5qYjNKbFMyVjVLSEIxZW5wc1pVTnZaR1VzSUZSNGJpNXpaVzVrWlhJcE93b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFCMWVucHNaVk5qYjNKbGN5NWhiR2R2TG5Sek9qRTFOQW9nSUNBZ0x5OGdjbVYwZFhKdUlIQjFlbnBzWlVOdlpHVXVZMjl1WTJGMEtIVnpaWEl1WW5sMFpYTXBPd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VUhWNmVteGxVMk52Y21WekxtRnNaMjh1ZEhNNk1USTFDaUFnSUNBdkx5QmpiMjV6ZENCa1pXeGxkR1ZrSUQwZ1FtOTRUM0F1WkdWc1pYUmxLR3RsZVNrN0NpQWdJQ0JpYjNoZlpHVnNDaUFnSUNBdkx5QmpiMjUwY21GamRITXZVSFY2ZW14bFUyTnZjbVZ6TG1Gc1oyOHVkSE02TVRJMkNpQWdJQ0F2THlCaGMzTmxjblFvWkdWc1pYUmxaQ3dnSW5OamIzSmxJR1J2WlhNZ2JtOTBJR1Y0YVhOMElHWnZjaUJ3ZFhwNmJHVWlLVHNLSUNBZ0lHRnpjMlZ5ZENBdkx5QnpZMjl5WlNCa2IyVnpJRzV2ZENCbGVHbHpkQ0JtYjNJZ2NIVjZlbXhsQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VUhWNmVteGxVMk52Y21WekxtRnNaMjh1ZEhNNk1USTRMVEV6TkFvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVjR0Y1YldWdWRDaDdDaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk2SUZSNGJpNXpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1ME9pQjBhR2x6TG5OamIzSmxRbTk0VFdKeUtDa3NDaUFnSUNBdkx5QWdJQ0FnWm1WbE9pQXdMQW9nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdMeThnSUNBdWMzVmliV2wwS0NrN0NpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VUhWNmVteGxVMk52Y21WekxtRnNaMjh1ZEhNNk1UTXdDaUFnSUNBdkx5QnlaV05sYVhabGNqb2dWSGh1TG5ObGJtUmxjaXdLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVFkWHA2YkdWVFkyOXlaWE11WVd4bmJ5NTBjem94TlRnS0lDQWdJQzh2SUhKbGRIVnliaUJDVDFoZlFrRlRSVjlOUWxJZ0t5QkNUMWhmUWxsVVJWOU5RbElnS2lBb1UwTlBVa1ZmUzBWWlgweEZUa2RVU0NBcklGTkRUMUpGWDB4RlRrZFVTQ2s3Q2lBZ0lDQnBiblJqSURRZ0x5OGdNak0zTURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVcxdmRXNTBDaUFnSUNCcGRIaHVYMlpwWld4a0lGSmxZMlZwZG1WeUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlVIVjZlbXhsVTJOdmNtVnpMbUZzWjI4dWRITTZNVEk0TFRFek13b2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1Y0dGNWJXVnVkQ2g3Q2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJNklGUjRiaTV6Wlc1a1pYSXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBPaUIwYUdsekxuTmpiM0psUW05NFRXSnlLQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxPaUF3TEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlRZFhwNmJHVlRZMjl5WlhNdVlXeG5ieTUwY3pveE16SUtJQ0FnSUM4dklHWmxaVG9nTUN3S0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFCMWVucHNaVk5qYjNKbGN5NWhiR2R2TG5Sek9qRXlPQzB4TXpRS0lDQWdJQzh2SUdsMGVHNEtJQ0FnSUM4dklDQWdMbkJoZVcxbGJuUW9ld29nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5T2lCVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREb2dkR2hwY3k1elkyOXlaVUp2ZUUxaWNpZ3BMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUb2dNQ3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJQzh2SUNBZ0xuTjFZbTFwZENncE93b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5UWRYcDZiR1ZUWTI5eVpYTXVZV3huYnk1MGN6b3hNak1LSUNBZ0lDOHZJSEIxWW14cFl5QnlaVzF2ZG1WVFkyOXlaU2h3ZFhwNmJHVkRiMlJsT2lCaWVYUmxjeWs2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTnZiblJ5WVdOMGN5OVFkWHA2YkdWVFkyOXlaWE11WVd4bmJ5NTBjem82VUhWNmVteGxVMk52Y21WekxtZGxkRTE1VTJOdmNtVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSTmVWTmpiM0psT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFCMWVucHNaVk5qYjNKbGN5NWhiR2R2TG5Sek9qRXpOeTB4TXpnS0lDQWdJQzh2SUVCeVpXRmtiMjVzZVFvZ0lDQWdMeThnY0hWaWJHbGpJR2RsZEUxNVUyTnZjbVVvY0hWNmVteGxRMjlrWlRvZ1lubDBaWE1wT2lCYmRXbHVkRFkwTENCaWIyOXNaV0Z1WFNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMUIxZW5wc1pWTmpiM0psY3k1aGJHZHZMblJ6T2pFek9Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVaMlYwVTJOdmNtVkdiM0pWYzJWeUtIQjFlbnBzWlVOdlpHVXNJRlI0Ymk1elpXNWtaWElwT3dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1kyRnNiSE4xWWlCamIyNTBjbUZqZEhNdlVIVjZlbXhsVTJOdmNtVnpMbUZzWjI4dWRITTZPbEIxZW5wc1pWTmpiM0psY3k1blpYUlRZMjl5WlVadmNsVnpaWElLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlRZFhwNmJHVlRZMjl5WlhNdVlXeG5ieTUwY3pveE16Y3RNVE00Q2lBZ0lDQXZMeUJBY21WaFpHOXViSGtLSUNBZ0lDOHZJSEIxWW14cFl5Qm5aWFJOZVZOamIzSmxLSEIxZW5wc1pVTnZaR1U2SUdKNWRHVnpLVG9nVzNWcGJuUTJOQ3dnWW05dmJHVmhibDBnZXdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR052Ym5SeVlXTjBjeTlRZFhwNmJHVlRZMjl5WlhNdVlXeG5ieTUwY3pvNlVIVjZlbXhsVTJOdmNtVnpMbWRsZEZOamIzSmxSbTl5VlhObGNsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEZOamIzSmxSbTl5VlhObGNqb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVFkWHA2YkdWVFkyOXlaWE11WVd4bmJ5NTBjem94TkRJdE1UUXpDaUFnSUNBdkx5QkFjbVZoWkc5dWJIa0tJQ0FnSUM4dklIQjFZbXhwWXlCblpYUlRZMjl5WlVadmNsVnpaWElvY0hWNmVteGxRMjlrWlRvZ1lubDBaWE1zSUhWelpYSTZJRUZqWTI5MWJuUXBPaUJiZFdsdWREWTBMQ0JpYjI5c1pXRnVYU0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ1kyRnNiSE4xWWlCamIyNTBjbUZqZEhNdlVIVjZlbXhsVTJOdmNtVnpMbUZzWjI4dWRITTZPbEIxZW5wc1pWTmpiM0psY3k1blpYUlRZMjl5WlVadmNsVnpaWElLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmpiMjUwY21GamRITXZVSFY2ZW14bFUyTnZjbVZ6TG1Gc1oyOHVkSE02T2xCMWVucHNaVk5qYjNKbGN5NW5aWFJUWTI5eVpVWnZjbFZ6WlhJb2NIVjZlbXhsUTI5a1pUb2dZbmwwWlhNc0lIVnpaWEk2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LWTI5dWRISmhZM1J6TDFCMWVucHNaVk5qYjNKbGN5NWhiR2R2TG5Sek9qcFFkWHA2YkdWVFkyOXlaWE11WjJWMFUyTnZjbVZHYjNKVmMyVnlPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMUIxZW5wc1pWTmpiM0psY3k1aGJHZHZMblJ6T2pFME1pMHhORE1LSUNBZ0lDOHZJRUJ5WldGa2IyNXNlUW9nSUNBZ0x5OGdjSFZpYkdsaklHZGxkRk5qYjNKbFJtOXlWWE5sY2lod2RYcDZiR1ZEYjJSbE9pQmllWFJsY3l3Z2RYTmxjam9nUVdOamIzVnVkQ2s2SUZ0MWFXNTBOalFzSUdKdmIyeGxZVzVkSUhzS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMUIxZW5wc1pWTmpiM0psY3k1aGJHZHZMblJ6T2pFMU5Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhCMWVucHNaVU52WkdVdVkyOXVZMkYwS0hWelpYSXVZbmwwWlhNcE93b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxQjFlbnBzWlZOamIzSmxjeTVoYkdkdkxuUnpPakUwTkFvZ0lDQWdMeThnWTI5dWMzUWdXM05qYjNKbFFubDBaWE1zSUdWNGFYTjBjMTBnUFNCQ2IzaFBjQzVuWlhRb2RHaHBjeTV6WTI5eVpVdGxlU2h3ZFhwNmJHVkRiMlJsTENCMWMyVnlLU2s3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlVIVjZlbXhsVTJOdmNtVnpMbUZzWjI4dWRITTZNVFEyQ2lBZ0lDQXZMeUJwWmlBb0lXVjRhWE4wY3lrZ2V3b2dJQ0FnWW01NklHTnZiblJ5WVdOMGN5OVFkWHA2YkdWVFkyOXlaWE11WVd4bmJ5NTBjem82VUhWNmVteGxVMk52Y21WekxtZGxkRk5qYjNKbFJtOXlWWE5sY2w5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlRZFhwNmJHVlRZMjl5WlhNdVlXeG5ieTUwY3pveE5EY0tJQ0FnSUM4dklISmxkSFZ5YmlCYlZXbHVkRFkwS0RBcExDQm1ZV3h6WlYwN0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJSE4zWVhBS0lDQWdJSEpsZEhOMVlnb0tZMjl1ZEhKaFkzUnpMMUIxZW5wc1pWTmpiM0psY3k1aGJHZHZMblJ6T2pwUWRYcDZiR1ZUWTI5eVpYTXVaMlYwVTJOdmNtVkdiM0pWYzJWeVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5UWRYcDZiR1ZUWTI5eVpYTXVZV3huYnk1MGN6b3hOVEFLSUNBZ0lDOHZJSEpsZEhWeWJpQmJZblJ2YVNoelkyOXlaVUo1ZEdWektTd2dkSEoxWlYwN0NpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdZblJ2YVFvZ0lDQWdhWFJ2WWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0T0RBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z1kyOXVkSEpoWTNSekwxQjFlbnBzWlZOamIzSmxjeTVoYkdkdkxuUnpPanBRZFhwNmJHVlRZMjl5WlhNdWRtVnlhV1o1Vm1WeWFXWnBaWEpVZUc0b2RtVnlhV1pwWlhKVWVHNDZJSFZwYm5RMk5Dd2djMmxuYm1Gc2N6b2dZbmwwWlhNc0lGOXdjbTl2WmpvZ1lubDBaWE1zSUhCMWVucHNaVU52WkdVNklHSjVkR1Z6TENCelkyOXlaVG9nZFdsdWREWTBLU0F0UGlCaWVYUmxjeXdnWW5sMFpYTTZDblpsY21sbWVWWmxjbWxtYVdWeVZIaHVPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMUIxZW5wc1pWTmpiM0psY3k1aGJHZHZMblJ6T2pFMk5TMHhOekVLSUNBZ0lDOHZJSEJ5YVhaaGRHVWdkbVZ5YVdaNVZtVnlhV1pwWlhKVWVHNG9DaUFnSUNBdkx5QWdJSFpsY21sbWFXVnlWSGh1T2lCbmRIaHVMbEJoZVcxbGJuUlVlRzRzQ2lBZ0lDQXZMeUFnSUhOcFoyNWhiSE02SUZCMVlteHBZMU5wWjI1aGJITXNDaUFnSUNBdkx5QWdJRjl3Y205dlpqb2dSM0p2ZEdneE5rSnVNalUwVUhKdmIyWXNDaUFnSUNBdkx5QWdJSEIxZW5wc1pVTnZaR1U2SUdKNWRHVnpMQW9nSUNBZ0x5OGdJQ0J6WTI5eVpUb2dkV2x1ZERZMExBb2dJQ0FnTHk4Z0tUb2dkbTlwWkNCN0NpQWdJQ0J3Y205MGJ5QTFJRElLSUNBZ0lIQjFjMmhpZVhSbGN5QWlJZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMUIxZW5wc1pWTmpiM0psY3k1aGJHZHZMblJ6T2pFM01nb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVkbVZ5YVdacFpYSXVhR0Z6Vm1Gc2RXVXNJQ0oyWlhKcFptbGxjaUJwY3lCdWIzUWdZMjl1Wm1sbmRYSmxaQ0lwT3dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlRZFhwNmJHVlRZMjl5WlhNdVlXeG5ieTUwY3pvME9Bb2dJQ0FnTHk4Z2RtVnlhV1pwWlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHhCWTJOdmRXNTBQaWg3SUd0bGVUb2dJblpsY21sbWFXVnlJaUI5S1RzS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5abGNtbG1hV1Z5SWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFCMWVucHNaVk5qYjNKbGN5NWhiR2R2TG5Sek9qRTNNZ29nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11ZG1WeWFXWnBaWEl1YUdGelZtRnNkV1VzSUNKMlpYSnBabWxsY2lCcGN5QnViM1FnWTI5dVptbG5kWEpsWkNJcE93b2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QjJaWEpwWm1sbGNpQnBjeUJ1YjNRZ1kyOXVabWxuZFhKbFpBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxQjFlbnBzWlZOamIzSmxjeTVoYkdkdkxuUnpPakUzTkFvZ0lDQWdMeThnZG1WeWFXWnBaWEpVZUc0dWMyVnVaR1Z5SUQwOVBTQjBhR2x6TG5abGNtbG1hV1Z5TG5aaGJIVmxMQW9nSUNBZ1puSmhiV1ZmWkdsbklDMDFDaUFnSUNCbmRIaHVjeUJUWlc1a1pYSUtJQ0FnSUQwOUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlVIVjZlbXhsVTJOdmNtVnpMbUZzWjI4dWRITTZNVGN6TFRFM05nb2dJQ0FnTHk4Z1lYTnpaWEowS0FvZ0lDQWdMeThnSUNCMlpYSnBabWxsY2xSNGJpNXpaVzVrWlhJZ1BUMDlJSFJvYVhNdWRtVnlhV1pwWlhJdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUNKMlpYSnBabWxsY2lCMGVHNGdiWFZ6ZENCamIyMWxJR1p5YjIwZ2RHaGxJSFpsY21sbWFXVnlJaXdLSUNBZ0lDOHZJQ2s3Q2lBZ0lDQmhjM05sY25RZ0x5OGdkbVZ5YVdacFpYSWdkSGh1SUcxMWMzUWdZMjl0WlNCbWNtOXRJSFJvWlNCMlpYSnBabWxsY2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFCMWVucHNaVk5qYjNKbGN5NWhiR2R2TG5Sek9qRTNPQW9nSUNBZ0x5OGdSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNZ1BUMDlJSFpsY21sbWFXVnlWSGh1TG5KbFkyVnBkbVZ5TEFvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TlFvZ0lDQWdaM1I0Ym5NZ1VtVmpaV2wyWlhJS0lDQWdJRDA5Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VUhWNmVteGxVMk52Y21WekxtRnNaMjh1ZEhNNk1UYzNMVEU0TUFvZ0lDQWdMeThnWVhOelpYSjBLQW9nSUNBZ0x5OGdJQ0JIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5QTlQVDBnZG1WeWFXWnBaWEpVZUc0dWNtVmpaV2wyWlhJc0NpQWdJQ0F2THlBZ0lDSjJaWEpwWm1sbGNpQjBlRzRnY21WalpXbDJaWElnYlhWemRDQmlaU0JoY0hBZ1lXTmpiM1Z1ZENJc0NpQWdJQ0F2THlBcE93b2dJQ0FnWVhOelpYSjBJQzh2SUhabGNtbG1hV1Z5SUhSNGJpQnlaV05sYVhabGNpQnRkWE4wSUdKbElHRndjQ0JoWTJOdmRXNTBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZVSFY2ZW14bFUyTnZjbVZ6TG1Gc1oyOHVkSE02TVRnekNpQWdJQ0F2THlCemFXZHVZV3h6TG14bGJtZDBhQ0ErUFNCUVZVSk1TVU5mVTBsSFRrRk1YME5QVlU1VUxBb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQ0OUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlVIVjZlbXhsVTJOdmNtVnpMbUZzWjI4dWRITTZNVGd5TFRFNE5Rb2dJQ0FnTHk4Z1lYTnpaWEowS0FvZ0lDQWdMeThnSUNCemFXZHVZV3h6TG14bGJtZDBhQ0ErUFNCUVZVSk1TVU5mVTBsSFRrRk1YME5QVlU1VUxBb2dJQ0FnTHk4Z0lDQWljSFZpYkdsaklITnBaMjVoYkhNZ2JHVnVaM1JvSUdseklHbHVkbUZzYVdRaUxBb2dJQ0FnTHk4Z0tUc0tJQ0FnSUdGemMyVnlkQ0F2THlCd2RXSnNhV01nYzJsbmJtRnNjeUJzWlc1bmRHZ2dhWE1nYVc1MllXeHBaQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMUIxZW5wc1pWTmpiM0psY3k1aGJHZHZMblJ6T2pFNE53b2dJQ0FnTHk4Z2NIVjZlbXhsUTI5a1pTNXNaVzVuZEdnZ1BUMDlJRkJWV2xwTVJWOURUMFJGWDB4RlRrZFVTQ3dLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2JHVnVDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTWpBZ0x5OGdNakFLSUNBZ0lEMDlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZVSFY2ZW14bFUyTnZjbVZ6TG1Gc1oyOHVkSE02TVRnMkxURTRPUW9nSUNBZ0x5OGdZWE56WlhKMEtBb2dJQ0FnTHk4Z0lDQndkWHA2YkdWRGIyUmxMbXhsYm1kMGFDQTlQVDBnVUZWYVdreEZYME5QUkVWZlRFVk9SMVJJTEFvZ0lDQWdMeThnSUNBaWNIVjZlbXhsSUdOdlpHVWdiR1Z1WjNSb0lHbHpJR2x1ZG1Gc2FXUWlMQW9nSUNBZ0x5OGdLVHNLSUNBZ0lHRnpjMlZ5ZENBdkx5QndkWHA2YkdVZ1kyOWtaU0JzWlc1bmRHZ2dhWE1nYVc1MllXeHBaQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMUIxZW5wc1pWTmpiM0psY3k1aGJHZHZMblJ6T2pFNU1Rb2dJQ0FnTHk4Z1kyOXVjM1FnWlhod1pXTjBaV1JUWTI5eVpTQTlJRUpwWjFWcGJuUW9jMk52Y21VcE93b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlVIVjZlbXhsVTJOdmNtVnpMbUZzWjI4dWRITTZNVGt6Q2lBZ0lDQXZMeUJ6YVdkdVlXeHpMbUYwS0ZORFQxSkZYMU5KUjA1QlRGOUpUa1JGV0NraExtRnpRbWxuVldsdWRDZ3BJRDA5UFNCbGVIQmxZM1JsWkZOamIzSmxPd29nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCbGVIUnlZV04wSURJZ016SUtJQ0FnSUdJOVBRb2dJQ0FnYzNkaGNBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxQjFlbnBzWlZOamIzSmxjeTVoYkdkdkxuUnpPakU1TlFvZ0lDQWdMeThnWTI5dWMzUWdjSFY2ZW14bFRHbHRZakFnUFNCaWRHOXBLSEIxZW5wc1pVTnZaR1V1YzJ4cFkyVW9WV2x1ZERZMEtEQXBMQ0JWYVc1ME5qUW9PQ2twS1RzS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdQajBLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCa2FXY2dNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0JrYVdjZ01nb2dJQ0FnUGowS0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQmthV2NnTXdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JrYVdjZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFCMWVucHNaVk5qYjNKbGN5NWhiR2R2TG5Sek9qRTVOZ29nSUNBZ0x5OGdZMjl1YzNRZ2NIVjZlbXhsVEdsdFlqRWdQU0JpZEc5cEtIQjFlbnBzWlVOdlpHVXVjMnhwWTJVb1ZXbHVkRFkwS0RncExDQlZhVzUwTmpRb01UWXBLU2s3Q2lBZ0lDQndkWE5vYVc1MElERTJJQzh2SURFMkNpQWdJQ0JrYVdjZ013b2dJQ0FnUGowS0lDQWdJSEIxYzJocGJuUWdNVFlnTHk4Z01UWUtJQ0FnSUdScFp5QTBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCaWRHOXBDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VUhWNmVteGxVMk52Y21WekxtRnNaMjh1ZEhNNk1UazNDaUFnSUNBdkx5QmpiMjV6ZENCd2RYcDZiR1ZNYVcxaU1pQTlJR0owYjJrb2NIVjZlbXhsUTI5a1pTNXpiR2xqWlNoVmFXNTBOalFvTVRZcExDQlZhVzUwTmpRb01qQXBLU2s3Q2lBZ0lDQndkWE5vYVc1MElESXdJQzh2SURJd0NpQWdJQ0JrYVdjZ013b2dJQ0FnUGowS0lDQWdJSEIxYzJocGJuUWdNakFnTHk4Z01qQUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1luUnZhUW9nSUNBZ2MzZGhjQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMUIxZW5wc1pWTmpiM0psY3k1aGJHZHZMblJ6T2pFNU9Rb2dJQ0FnTHk4Z1kyOXVjM1FnYzJWdVpHVnlUR2x0WWpBZ1BTQmlkRzlwS0ZSNGJpNXpaVzVrWlhJdVlubDBaWE11YzJ4cFkyVW9WV2x1ZERZMEtEQXBMQ0JWYVc1ME5qUW9PQ2twS1RzS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lITjFZbk4wY21sdVp5QXdJRGdLSUNBZ0lHSjBiMmtLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlRZFhwNmJHVlRZMjl5WlhNdVlXeG5ieTUwY3pveU1EQUtJQ0FnSUM4dklHTnZibk4wSUhObGJtUmxja3hwYldJeElEMGdZblJ2YVNoVWVHNHVjMlZ1WkdWeUxtSjVkR1Z6TG5Oc2FXTmxLRlZwYm5RMk5DZzRLU3dnVldsdWREWTBLREUyS1NrcE93b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdjM1ZpYzNSeWFXNW5JRGdnTVRZS0lDQWdJR0owYjJrS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5UWRYcDZiR1ZUWTI5eVpYTXVZV3huYnk1MGN6b3lNREVLSUNBZ0lDOHZJR052Ym5OMElITmxibVJsY2t4cGJXSXlJRDBnWW5SdmFTaFVlRzR1YzJWdVpHVnlMbUo1ZEdWekxuTnNhV05sS0ZWcGJuUTJOQ2d4Tmlrc0lGVnBiblEyTkNneU5Da3BLVHNLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUhOMVluTjBjbWx1WnlBeE5pQXlOQW9nSUNBZ1luUnZhUW9nSUNBZ2MzZGhjQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMUIxZW5wc1pWTmpiM0psY3k1aGJHZHZMblJ6T2pJd01nb2dJQ0FnTHk4Z1kyOXVjM1FnYzJWdVpHVnlUR2x0WWpNZ1BTQmlkRzlwS0ZSNGJpNXpaVzVrWlhJdVlubDBaWE11YzJ4cFkyVW9WV2x1ZERZMEtESTBLU3dnVldsdWREWTBLRE15S1NrcE93b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdjM1ZpYzNSeWFXNW5JREkwSURNeUNpQWdJQ0JpZEc5cENpQWdJQ0J6ZDJGd0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlVIVjZlbXhsVTJOdmNtVnpMbUZzWjI4dWRITTZNakExQ2lBZ0lDQXZMeUJ6YVdkdVlXeHpMbUYwS0ZCVldscE1SVjlNU1UxQ1h6QmZTVTVFUlZncElTNWhjMEpwWjFWcGJuUW9LU0E5UFQwZ1FtbG5WV2x1ZENod2RYcDZiR1ZNYVcxaU1Da2dKaVlLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ1pYaDBjbUZqZENBek5DQXpNZ29nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ1lqMDlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZVSFY2ZW14bFUyTnZjbVZ6TG1Gc1oyOHVkSE02TWpBMUxUSXdOZ29nSUNBZ0x5OGdjMmxuYm1Gc2N5NWhkQ2hRVlZwYVRFVmZURWxOUWw4d1gwbE9SRVZZS1NFdVlYTkNhV2RWYVc1MEtDa2dQVDA5SUVKcFoxVnBiblFvY0hWNmVteGxUR2x0WWpBcElDWW1DaUFnSUNBdkx5QnphV2R1WVd4ekxtRjBLRkJWV2xwTVJWOU1TVTFDWHpGZlNVNUVSVmdwSVM1aGMwSnBaMVZwYm5Rb0tTQTlQVDBnUW1sblZXbHVkQ2h3ZFhwNmJHVk1hVzFpTVNrZ0ppWUtJQ0FnSUdKNklIWmxjbWxtZVZabGNtbG1hV1Z5VkhodVgySnZiMnhmWm1Gc2MyVkFOQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMUIxZW5wc1pWTmpiM0psY3k1aGJHZHZMblJ6T2pJd05nb2dJQ0FnTHk4Z2MybG5ibUZzY3k1aGRDaFFWVnBhVEVWZlRFbE5RbDh4WDBsT1JFVllLU0V1WVhOQ2FXZFZhVzUwS0NrZ1BUMDlJRUpwWjFWcGJuUW9jSFY2ZW14bFRHbHRZakVwSUNZbUNpQWdJQ0JtY21GdFpWOWthV2NnTFRRS0lDQWdJR1Y0ZEhKaFkzUWdOallnTXpJS0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmlQVDBLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlRZFhwNmJHVlRZMjl5WlhNdVlXeG5ieTUwY3pveU1EVXRNakEyQ2lBZ0lDQXZMeUJ6YVdkdVlXeHpMbUYwS0ZCVldscE1SVjlNU1UxQ1h6QmZTVTVFUlZncElTNWhjMEpwWjFWcGJuUW9LU0E5UFQwZ1FtbG5WV2x1ZENod2RYcDZiR1ZNYVcxaU1Da2dKaVlLSUNBZ0lDOHZJSE5wWjI1aGJITXVZWFFvVUZWYVdreEZYMHhKVFVKZk1WOUpUa1JGV0NraExtRnpRbWxuVldsdWRDZ3BJRDA5UFNCQ2FXZFZhVzUwS0hCMWVucHNaVXhwYldJeEtTQW1KZ29nSUNBZ1lub2dkbVZ5YVdaNVZtVnlhV1pwWlhKVWVHNWZZbTl2YkY5bVlXeHpaVUEwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VUhWNmVteGxVMk52Y21WekxtRnNaMjh1ZEhNNk1qQTNDaUFnSUNBdkx5QnphV2R1WVd4ekxtRjBLRkJWV2xwTVJWOU1TVTFDWHpKZlNVNUVSVmdwSVM1aGMwSnBaMVZwYm5Rb0tTQTlQVDBnUW1sblZXbHVkQ2h3ZFhwNmJHVk1hVzFpTWlrN0NpQWdJQ0JtY21GdFpWOWthV2NnTFRRS0lDQWdJR1Y0ZEhKaFkzUWdPVGdnTXpJS0lDQWdJR1p5WVcxbFgyUnBaeUF6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmlQVDBLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlRZFhwNmJHVlRZMjl5WlhNdVlXeG5ieTUwY3pveU1EVXRNakEzQ2lBZ0lDQXZMeUJ6YVdkdVlXeHpMbUYwS0ZCVldscE1SVjlNU1UxQ1h6QmZTVTVFUlZncElTNWhjMEpwWjFWcGJuUW9LU0E5UFQwZ1FtbG5WV2x1ZENod2RYcDZiR1ZNYVcxaU1Da2dKaVlLSUNBZ0lDOHZJSE5wWjI1aGJITXVZWFFvVUZWYVdreEZYMHhKVFVKZk1WOUpUa1JGV0NraExtRnpRbWxuVldsdWRDZ3BJRDA5UFNCQ2FXZFZhVzUwS0hCMWVucHNaVXhwYldJeEtTQW1KZ29nSUNBZ0x5OGdjMmxuYm1Gc2N5NWhkQ2hRVlZwYVRFVmZURWxOUWw4eVgwbE9SRVZZS1NFdVlYTkNhV2RWYVc1MEtDa2dQVDA5SUVKcFoxVnBiblFvY0hWNmVteGxUR2x0WWpJcE93b2dJQ0FnWW5vZ2RtVnlhV1o1Vm1WeWFXWnBaWEpVZUc1ZlltOXZiRjltWVd4elpVQTBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NncDJaWEpwWm5sV1pYSnBabWxsY2xSNGJsOWliMjlzWDIxbGNtZGxRRFU2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VUhWNmVteGxVMk52Y21WekxtRnNaMjh1ZEhNNk1qRXdDaUFnSUNBdkx5QnphV2R1WVd4ekxtRjBLRk5GVGtSRlVsOU1TVTFDWHpCZlNVNUVSVmdwSVM1aGMwSnBaMVZwYm5Rb0tTQTlQVDBnUW1sblZXbHVkQ2h6Wlc1a1pYSk1hVzFpTUNrZ0ppWUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Bb2dJQ0FnWlhoMGNtRmpkQ0F4TXpBZ016SUtJQ0FnSUdaeVlXMWxYMlJwWnlBMENpQWdJQ0JwZEc5aUNpQWdJQ0JpUFQwS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5UWRYcDZiR1ZUWTI5eVpYTXVZV3huYnk1MGN6b3lNVEF0TWpFeENpQWdJQ0F2THlCemFXZHVZV3h6TG1GMEtGTkZUa1JGVWw5TVNVMUNYekJmU1U1RVJWZ3BJUzVoYzBKcFoxVnBiblFvS1NBOVBUMGdRbWxuVldsdWRDaHpaVzVrWlhKTWFXMWlNQ2tnSmlZS0lDQWdJQzh2SUhOcFoyNWhiSE11WVhRb1UwVk9SRVZTWDB4SlRVSmZNVjlKVGtSRldDa2hMbUZ6UW1sblZXbHVkQ2dwSUQwOVBTQkNhV2RWYVc1MEtITmxibVJsY2t4cGJXSXhLU0FtSmdvZ0lDQWdZbm9nZG1WeWFXWjVWbVZ5YVdacFpYSlVlRzVmWW05dmJGOW1ZV3h6WlVBeE1Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxQjFlbnBzWlZOamIzSmxjeTVoYkdkdkxuUnpPakl4TVFvZ0lDQWdMeThnYzJsbmJtRnNjeTVoZENoVFJVNUVSVkpmVEVsTlFsOHhYMGxPUkVWWUtTRXVZWE5DYVdkVmFXNTBLQ2tnUFQwOUlFSnBaMVZwYm5Rb2MyVnVaR1Z5VEdsdFlqRXBJQ1ltQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHVjRkSEpoWTNRZ01UWXlJRE15Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dOUW9nSUNBZ2FYUnZZZ29nSUNBZ1lqMDlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZVSFY2ZW14bFUyTnZjbVZ6TG1Gc1oyOHVkSE02TWpFd0xUSXhNUW9nSUNBZ0x5OGdjMmxuYm1Gc2N5NWhkQ2hUUlU1RVJWSmZURWxOUWw4d1gwbE9SRVZZS1NFdVlYTkNhV2RWYVc1MEtDa2dQVDA5SUVKcFoxVnBiblFvYzJWdVpHVnlUR2x0WWpBcElDWW1DaUFnSUNBdkx5QnphV2R1WVd4ekxtRjBLRk5GVGtSRlVsOU1TVTFDWHpGZlNVNUVSVmdwSVM1aGMwSnBaMVZwYm5Rb0tTQTlQVDBnUW1sblZXbHVkQ2h6Wlc1a1pYSk1hVzFpTVNrZ0ppWUtJQ0FnSUdKNklIWmxjbWxtZVZabGNtbG1hV1Z5VkhodVgySnZiMnhmWm1Gc2MyVkFNVEFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlRZFhwNmJHVlRZMjl5WlhNdVlXeG5ieTUwY3pveU1USUtJQ0FnSUM4dklITnBaMjVoYkhNdVlYUW9VMFZPUkVWU1gweEpUVUpmTWw5SlRrUkZXQ2toTG1GelFtbG5WV2x1ZENncElEMDlQU0JDYVdkVmFXNTBLSE5sYm1SbGNreHBiV0l5S1NBbUpnb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JsZUhSeVlXTjBJREU1TkNBek1nb2dJQ0FnWm5KaGJXVmZaR2xuSURZS0lDQWdJR2wwYjJJS0lDQWdJR0k5UFFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFCMWVucHNaVk5qYjNKbGN5NWhiR2R2TG5Sek9qSXhNQzB5TVRJS0lDQWdJQzh2SUhOcFoyNWhiSE11WVhRb1UwVk9SRVZTWDB4SlRVSmZNRjlKVGtSRldDa2hMbUZ6UW1sblZXbHVkQ2dwSUQwOVBTQkNhV2RWYVc1MEtITmxibVJsY2t4cGJXSXdLU0FtSmdvZ0lDQWdMeThnYzJsbmJtRnNjeTVoZENoVFJVNUVSVkpmVEVsTlFsOHhYMGxPUkVWWUtTRXVZWE5DYVdkVmFXNTBLQ2tnUFQwOUlFSnBaMVZwYm5Rb2MyVnVaR1Z5VEdsdFlqRXBJQ1ltQ2lBZ0lDQXZMeUJ6YVdkdVlXeHpMbUYwS0ZORlRrUkZVbDlNU1UxQ1h6SmZTVTVFUlZncElTNWhjMEpwWjFWcGJuUW9LU0E5UFQwZ1FtbG5WV2x1ZENoelpXNWtaWEpNYVcxaU1pa2dKaVlLSUNBZ0lHSjZJSFpsY21sbWVWWmxjbWxtYVdWeVZIaHVYMkp2YjJ4ZlptRnNjMlZBTVRBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5UWRYcDZiR1ZUWTI5eVpYTXVZV3huYnk1MGN6b3lNVE1LSUNBZ0lDOHZJSE5wWjI1aGJITXVZWFFvVTBWT1JFVlNYMHhKVFVKZk0xOUpUa1JGV0NraExtRnpRbWxuVldsdWRDZ3BJRDA5UFNCQ2FXZFZhVzUwS0hObGJtUmxja3hwYldJektUc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Bb2dJQ0FnWlhoMGNtRmpkQ0F5TWpZZ016SUtJQ0FnSUdaeVlXMWxYMlJwWnlBM0NpQWdJQ0JwZEc5aUNpQWdJQ0JpUFQwS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5UWRYcDZiR1ZUWTI5eVpYTXVZV3huYnk1MGN6b3lNVEF0TWpFekNpQWdJQ0F2THlCemFXZHVZV3h6TG1GMEtGTkZUa1JGVWw5TVNVMUNYekJmU1U1RVJWZ3BJUzVoYzBKcFoxVnBiblFvS1NBOVBUMGdRbWxuVldsdWRDaHpaVzVrWlhKTWFXMWlNQ2tnSmlZS0lDQWdJQzh2SUhOcFoyNWhiSE11WVhRb1UwVk9SRVZTWDB4SlRVSmZNVjlKVGtSRldDa2hMbUZ6UW1sblZXbHVkQ2dwSUQwOVBTQkNhV2RWYVc1MEtITmxibVJsY2t4cGJXSXhLU0FtSmdvZ0lDQWdMeThnYzJsbmJtRnNjeTVoZENoVFJVNUVSVkpmVEVsTlFsOHlYMGxPUkVWWUtTRXVZWE5DYVdkVmFXNTBLQ2tnUFQwOUlFSnBaMVZwYm5Rb2MyVnVaR1Z5VEdsdFlqSXBJQ1ltQ2lBZ0lDQXZMeUJ6YVdkdVlXeHpMbUYwS0ZORlRrUkZVbDlNU1UxQ1h6TmZTVTVFUlZncElTNWhjMEpwWjFWcGJuUW9LU0E5UFQwZ1FtbG5WV2x1ZENoelpXNWtaWEpNYVcxaU15azdDaUFnSUNCaWVpQjJaWEpwWm5sV1pYSnBabWxsY2xSNGJsOWliMjlzWDJaaGJITmxRREV3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9LZG1WeWFXWjVWbVZ5YVdacFpYSlVlRzVmWW05dmJGOXRaWEpuWlVBeE1Ub0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVFkWHA2YkdWVFkyOXlaWE11WVd4bmJ5NTBjem95TVRVS0lDQWdJQzh2SUdGemMyVnlkQ2h6WTI5eVpVRjBUM1YwY0hWMExDQWljSFZpYkdsaklITmpiM0psSUcxMWMzUWdiV0YwWTJnaUtUc0tJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JoYzNObGNuUWdMeThnY0hWaWJHbGpJSE5qYjNKbElHMTFjM1FnYldGMFkyZ0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVFkWHA2YkdWVFkyOXlaWE11WVd4bmJ5NTBjem95TVRZS0lDQWdJQzh2SUdGemMyVnlkQ2h3ZFhwNmJHVk5ZWFJqYUdWekxDQWljSFZpYkdsaklIQjFlbnBzWlNCamIyUmxJRzExYzNRZ2JXRjBZMmdpS1RzS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQmhjM05sY25RZ0x5OGdjSFZpYkdsaklIQjFlbnBzWlNCamIyUmxJRzExYzNRZ2JXRjBZMmdLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlRZFhwNmJHVlRZMjl5WlhNdVlXeG5ieTUwY3pveU1UY0tJQ0FnSUM4dklHRnpjMlZ5ZENoelpXNWtaWEpOWVhSamFHVnpMQ0FpY0hWaWJHbGpJSE5sYm1SbGNpQnRkWE4wSUcxaGRHTm9JR05oYkd4bGNpSXBPd29nSUNBZ1lYTnpaWEowSUM4dklIQjFZbXhwWXlCelpXNWtaWElnYlhWemRDQnRZWFJqYUNCallXeHNaWElLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCbWNtRnRaVjlpZFhKNUlERUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ3AyWlhKcFpubFdaWEpwWm1sbGNsUjRibDlpYjI5c1gyWmhiSE5sUURFd09nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0lnZG1WeWFXWjVWbVZ5YVdacFpYSlVlRzVmWW05dmJGOXRaWEpuWlVBeE1Rb0tkbVZ5YVdaNVZtVnlhV1pwWlhKVWVHNWZZbTl2YkY5bVlXeHpaVUEwT2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ1lpQjJaWEpwWm5sV1pYSnBabWxsY2xSNGJsOWliMjlzWDIxbGNtZGxRRFVLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFGQVFBQ0NKUzVBU1lDQ0habGNtbG1hV1Z5QkJVZmZIVXhHMEVBYW9BRVJ2ZGxNellhQUk0QkFGRXhHUlJFTVJoRWdnY0VYdmI2TlFSMFZjQ3BCSkZuNThzRWRNcDJGd1RyMWorQ0JIKzJyL2NFWUFvUld6WWFBSTRIQUFFQUtBQkVBTllCUGdGbEFZQUFnQXdWSDN4MUFBQUFBQUFBWEpTd0lrTXhHWUVFRWpFWUVFUkNBQjR4R1JReEdCUVFSQ0pETmhvQlNSV0JJQkpFTVFBeUNSSkVLRXhuSWtNeEFESUpFa1FpUXpZYUFVa2pXWUVnQ3lRSVN3RVZFa1EyR2dKSkZZR0FBaEpFTmhvRFNTTlpKQWhMQVJVU1JGY0NBRFlhQkVrVkpSSkVGekVXSkFsSk9CQWlFa1F4RmlJSlNUZ1FJaEpFU3dLQi93RU9SRXNETVFCUVNiMUZBUlJFVEU4R1R3WlBCa3NHaUFFY1JnSXhBRkVBSUVzQ09BQlJBQ0FTUkRJS1VRQWdTd0k0QjFFQUlCSkVURGdJSVFRU1JFd1dVUWNJdnlKRE5ob0JTU05aZ1NBTEpBaExBUlVTUkRZYUFra1ZnWUFDRWtRMkdnTkpJMWtrQ0VzQkZSSkVWd0lBTmhvRVNSVWxFa1FYTVJZaUNVazRFQ0lTUkVzQmdmOEJEa1JMQWpFQVVFbStSRThDVHdaUEJrOEdTd2FJQUpaR0FoZExBZzFFVEJaUkJ3aS9Ja00yR2dGSkkxa2tDRXNCRlJKRVZ3SUFNUUJRdkVTeE1RQWhCTElJc2djaXNoQWpzZ0d6SWtNMkdnRkpJMWtrQ0VzQkZSSkVWd0lBTVFDSUFDZ3BURkN3SWtNMkdnRkpJMWtrQ0VzQkZSSkVWd0lBTmhvQ1NSV0JJQkpFaUFBR0tVeFFzQ0pEaWdJQmkvNkwvMUMrUUFBTmdBa0FBQUFBQUFBQUFBQk1pWXNBRnhhQUFZQlFUSW1LQlFLQUFDTW9aVVNMK3pnQUVrUXlDb3Y3T0FjU1JJdjhJMWtsRDBTTC9oVkpnUlFTUkl2L0ZvdjhWd0lncUV3alN3RVBJMHNDVHdKTkpVc0NEeVZMQTA4Q1RZditUd0pMQWxJWGdSQkxBdytCRUVzRVR3Sk5pLzVQQTBzQ1VoZE9BNEVVU3dNUGdSUlBCRThDVFl2K1RnSlNGMHd4QUZFQUNCZE1NUUJSQ0JBWFRERUFVUkFZRjB3eEFGRVlJQmRNaS94WElpQk1GcWhCQUdDTC9GZENJSXNDRnFoQkFGU0wvRmRpSUlzREZxaEJBRWdpakFDTC9GZUNJSXNFRnFoQkFEV0wvRmVpSUlzRkZxaEJBQ21ML0ZmQ0lJc0dGcWhCQUIyTC9GZmlJSXNIRnFoQkFCRWlpd0ZFaXdCRVJJdjhpLzJNQVl3QWlTTkMvK3dqakFCQy83VT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjozLCJwYXRjaCI6MiwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
