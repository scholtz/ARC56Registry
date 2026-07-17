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

namespace Arc56.Generated.mzf11125.stake_sharia_on_algorand.tawf_sharia_3da97503
{


    public class tawf_shariaProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public tawf_shariaProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetMyIjarahInfoReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetMyIjarahInfoReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetMyIjarahInfoReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is ulong vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetMyIjarahInfoReturn);
                }
                public bool Equals(GetMyIjarahInfoReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetMyIjarahInfoReturn left, GetMyIjarahInfoReturn right)
                {
                    return EqualityComparer<GetMyIjarahInfoReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetMyIjarahInfoReturn left, GetMyIjarahInfoReturn right)
                {
                    return !(left == right);
                }

            }

            public class CheckLessorInfoReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
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

                public static CheckLessorInfoReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new CheckLessorInfoReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as CheckLessorInfoReturn);
                }
                public bool Equals(CheckLessorInfoReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(CheckLessorInfoReturn left, CheckLessorInfoReturn right)
                {
                    return EqualityComparer<CheckLessorInfoReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(CheckLessorInfoReturn left, CheckLessorInfoReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payment"> </param>
        public async Task<string> LeaseValidationRights(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 8, 72, 240, 41 };

            var result = await base.CallApp(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> LeaseValidationRights_Transactions(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 8, 72, 240, 41 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> ClaimUjrah(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 110, 225, 128 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> ClaimUjrah_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 110, 225, 128 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="amount"> </param>
        public async Task<string> TerminateLease(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 181, 84, 227, 96 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> TerminateLease_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 181, 84, 227, 96 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.GetMyIjarahInfoReturn> GetMyIjarahInfo(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 206, 10, 17, 151 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetMyIjarahInfoReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetMyIjarahInfo_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 206, 10, 17, 151 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="lessor"> </param>
        public async Task<Structs.CheckLessorInfoReturn> CheckLessorInfo(Algorand.Address lessor, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 231, 209, 198, 53 };
            var lessorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); lessorAbi.From(lessor);

            var result = await base.CallApp(new List<object> { abiHandle, lessorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.CheckLessorInfoReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> CheckLessorInfo_Transactions(Algorand.Address lessor, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 231, 209, 198, 53 };
            var lessorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); lessorAbi.From(lessor);

            return await base.MakeTransactionList(new List<object> { abiHandle, lessorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> TotalContractBalance(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 69, 240, 223, 118 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> TotalContractBalance_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 69, 240, 223, 118 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoidGF3Zl9zaGFyaWEiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiR2V0TXlJamFyYWhJbmZvUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDY0In1dLCJDaGVja0xlc3NvckluZm9SZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJsZWFzZV92YWxpZGF0aW9uX3JpZ2h0cyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2xhaW1fdWpyYWgiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXJtaW5hdGVfbGVhc2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X215X2lqYXJhaF9pbmZvIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJHZXRNeUlqYXJhaEluZm9SZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjaGVja19sZXNzb3JfaW5mbyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibGVzc29yIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkNoZWNrTGVzc29ySW5mb1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRvdGFsX2NvbnRyYWN0X2JhbGFuY2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzM5NV0sImVycm9yTWVzc2FnZSI6IkV4Y2VlZHMgYmFsYW5jZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM4M10sImVycm9yTWVzc2FnZSI6IkludmFsaWQgYW1vdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTY0XSwiZXJyb3JNZXNzYWdlIjoiSW52YWxpZCByZWNlaXZlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3M10sImVycm9yTWVzc2FnZSI6Ik1pbiAxIEFMR08iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODNdLCJlcnJvck1lc3NhZ2UiOiJObyB1anJhaCB5ZXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4NF0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDVdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wICYmIGNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYyMl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuQU5OVUFMX1VKUkFIX1JBVEVfQlAgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjI3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5TRUNPTkRTX1BFUl9ZRUFSIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU1Nl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNjhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTddLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXhJREFnT0FvZ0lDQWdZbmwwWldOaWJHOWpheUF3ZURFMU1XWTNZemMxSURCNE5qazJZVFl4TnpJMk1UWTROV1lnSWtGT1RsVkJURjlWU2xKQlNGOVNRVlJGWDBKUUlpQWlVMFZEVDA1RVUxOVFSVkpmV1VWQlVpSUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwWVhkbVgzTm9ZWEpwWVM5amIyNTBjbUZqZEM1d2VUbzNDaUFnSUNBdkx5QnpaV3htTGtGT1RsVkJURjlWU2xKQlNGOVNRVlJGWDBKUUlEMGdWVWx1ZERZMEtETXdNQ2tnSUNBZ0lDQWpJRE1sSUdGdWJuVmhiQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlRVTVPVlVGTVgxVktVa0ZJWDFKQlZFVmZRbEFpQ2lBZ0lDQndkWE5vYVc1MElETXdNQ0F2THlBek1EQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHRjNabDl6YUdGeWFXRXZZMjl1ZEhKaFkzUXVjSGs2T0FvZ0lDQWdMeThnYzJWc1ppNVRSVU5QVGtSVFgxQkZVbDlaUlVGU0lEMGdWVWx1ZERZMEtETXhYelUxTjE4Mk1EQXBJQ0FnSXlBek5qVXVNalVnWkdGNWN3b2dJQ0FnWW5sMFpXTmZNeUF2THlBaVUwVkRUMDVFVTE5UVJWSmZXVVZCVWlJS0lDQWdJSEIxYzJocGJuUWdNekUxTlRjMk1EQWdMeThnTXpFMU5UYzJNREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MFlYZG1YM05vWVhKcFlTOWpiMjUwY21GamRDNXdlVG8xQ2lBZ0lDQXZMeUJqYkdGemN5QjBZWGRtWDNOb1lYSnBZU2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZjSGxmWkdWbVlYVnNkRjlqY21WaGRHVkFNVFVLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYlhWemRDQmlaU0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0TURnME9HWXdNamtnTUhnMU5EWmxaVEU0TUNBd2VHSTFOVFJsTXpZd0lEQjRZMlV3WVRFeE9UY2dNSGhsTjJReFl6WXpOU0F3ZURRMVpqQmtaamMySUM4dklHMWxkR2h2WkNBaWJHVmhjMlZmZG1Gc2FXUmhkR2x2Ymw5eWFXZG9kSE1vY0dGNUtYTjBjbWx1WnlJc0lHMWxkR2h2WkNBaVkyeGhhVzFmZFdweVlXZ29LWE4wY21sdVp5SXNJRzFsZEdodlpDQWlkR1Z5YldsdVlYUmxYMnhsWVhObEtIVnBiblEyTkNsemRISnBibWNpTENCdFpYUm9iMlFnSW1kbGRGOXRlVjlwYW1GeVlXaGZhVzVtYnlncEtIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBLU0lzSUcxbGRHaHZaQ0FpWTJobFkydGZiR1Z6YzI5eVgybHVabThvWVdSa2NtVnpjeWtvZFdsdWREWTBMSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJblJ2ZEdGc1gyTnZiblJ5WVdOMFgySmhiR0Z1WTJVb0tYVnBiblEyTkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHeGxZWE5sWDNaaGJHbGtZWFJwYjI1ZmNtbG5hSFJ6SUdOc1lXbHRYM1ZxY21Gb0lIUmxjbTFwYm1GMFpWOXNaV0Z6WlNCblpYUmZiWGxmYVdwaGNtRm9YMmx1Wm04Z1kyaGxZMnRmYkdWemMyOXlYMmx1Wm04Z2RHOTBZV3hmWTI5dWRISmhZM1JmWW1Gc1lXNWpaUW9nSUNBZ1pYSnlDZ3B0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURFMU9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHMTFjM1FnWW1VZ1RtOVBjQ0FtSmlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z1kzSmxZWFJwYm1jS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVkR0YzWmw5emFHRnlhV0V1WTI5dWRISmhZM1F1ZEdGM1psOXphR0Z5YVdFdWJHVmhjMlZmZG1Gc2FXUmhkR2x2Ymw5eWFXZG9kSE5iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwc1pXRnpaVjkyWVd4cFpHRjBhVzl1WDNKcFoyaDBjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBZWGRtWDNOb1lYSnBZUzlqYjI1MGNtRmpkQzV3ZVRveE1DMHhNUW9nSUNBZ0x5OGdJeUE5UFQwZ1RHVmhjMlVnTHlCRVpYQnZjMmwwSUQwOVBRb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUJ3WVhrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJ3WVhrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwWVhkbVgzTm9ZWEpwWVM5amIyNTBjbUZqZEM1d2VUb3hNd29nSUNBZ0x5OGdZWE56WlhKMElIQmhlVzFsYm5RdWNtVmpaV2wyWlhJZ1BUMGdSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d2dJa2x1ZG1Gc2FXUWdjbVZqWldsMlpYSWlDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRkpsWTJWcGRtVnlDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCSmJuWmhiR2xrSUhKbFkyVnBkbVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR0YzWmw5emFHRnlhV0V2WTI5dWRISmhZM1F1Y0hrNk1UUUtJQ0FnSUM4dklHRnpjMlZ5ZENCd1lYbHRaVzUwTG1GdGIzVnVkQ0ErUFNBeFh6QXdNRjh3TURBc0lDSk5hVzRnTVNCQlRFZFBJZ29nSUNBZ1ozUjRibk1nUVcxdmRXNTBDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTVRBd01EQXdNQ0F2THlBeE1EQXdNREF3Q2lBZ0lDQStQUW9nSUNBZ1lYTnpaWEowSUM4dklFMXBiaUF4SUVGTVIwOEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MFlYZG1YM05vWVhKcFlTOWpiMjUwY21GamRDNXdlVG94TmdvZ0lDQWdMeThnYkdWemMyOXlJRDBnVkhodUxuTmxibVJsY2dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUmhkMlpmYzJoaGNtbGhMMk52Ym5SeVlXTjBMbkI1T2pFM0NpQWdJQ0F2THlCdWIzY2dQU0JIYkc5aVlXd3ViR0YwWlhOMFgzUnBiV1Z6ZEdGdGNBb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSaGQyWmZjMmhoY21saEwyTnZiblJ5WVdOMExuQjVPakU0Q2lBZ0lDQXZMeUJpYjNoZmJtRnRaU0E5SUVKNWRHVnpLR0lpYVdwaGNtRm9YeUlwSUNzZ2JHVnpjMjl5TG1KNWRHVnpDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjROamsyWVRZeE56STJNVFk0TldZS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwWVhkbVgzTm9ZWEpwWVM5amIyNTBjbUZqZEM1d2VUb3hOZ29nSUNBZ0x5OGdiR1Z6YzI5eUlEMGdWSGh1TG5ObGJtUmxjZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSaGQyWmZjMmhoY21saEwyTnZiblJ5WVdOMExuQjVPakU0Q2lBZ0lDQXZMeUJpYjNoZmJtRnRaU0E5SUVKNWRHVnpLR0lpYVdwaGNtRm9YeUlwSUNzZ2JHVnpjMjl5TG1KNWRHVnpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JoZDJaZmMyaGhjbWxoTDJOdmJuUnlZV04wTG5CNU9qSXdDaUFnSUNBdkx5QndjbWx1WTJsd1lXd3NJR1IxYlcxNVgyUmhkR0VnUFNCelpXeG1MbDluWlhSZmNISnBibU5wY0dGc0tHSnZlRjl1WVcxbEtRb2dJQ0FnWTJGc2JITjFZaUJmWjJWMFgzQnlhVzVqYVhCaGJBb2dJQ0FnY0c5d0NpQWdJQ0J6ZDJGd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdGM1psOXphR0Z5YVdFdlkyOXVkSEpoWTNRdWNIazZNakVLSUNBZ0lDOHZJSFZ1WTJ4aGFXMWxaQ0E5SUhObGJHWXVYMk5oYkdOMWJHRjBaVjkxYW5KaGFDaGliM2hmYm1GdFpTa0tJQ0FnSUdOaGJHeHpkV0lnWDJOaGJHTjFiR0YwWlY5MWFuSmhhQW9nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHRjNabDl6YUdGeWFXRXZZMjl1ZEhKaFkzUXVjSGs2TWpNS0lDQWdJQzh2SUdsbUlIVnVZMnhoYVcxbFpDQStJRlZKYm5RMk5DZ3dLVG9LSUNBZ0lHSjZJR3hsWVhObFgzWmhiR2xrWVhScGIyNWZjbWxuYUhSelgyRm1kR1Z5WDJsbVgyVnNjMlZBTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JoZDJaZmMyaGhjbWxoTDJOdmJuUnlZV04wTG5CNU9qSTBDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvY21WalpXbDJaWEk5YkdWemMyOXlMQ0JoYlc5MWJuUTlkVzVqYkdGcGJXVmtMQ0JtWldVOVZVbHVkRFkwS0RBcEtTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdaSFZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ0YjNWdWRBb2dJQ0FnWkdsbklEUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1VtVmpaV2wyWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUJ3WVhrS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtDbXhsWVhObFgzWmhiR2xrWVhScGIyNWZjbWxuYUhSelgyRm1kR1Z5WDJsbVgyVnNjMlZBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwWVhkbVgzTm9ZWEpwWVM5amIyNTBjbUZqZEM1d2VUb3lOZ29nSUNBZ0x5OGdibVYzWDNCeWFXNWphWEJoYkNBOUlIQnlhVzVqYVhCaGJDQXJJSEJoZVcxbGJuUXVZVzF2ZFc1MENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWkdsbklEWUtJQ0FnSUNzS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwWVhkbVgzTm9ZWEpwWVM5amIyNTBjbUZqZEM1d2VUb3lOd29nSUNBZ0x5OGdiM0F1UW05NExuQjFkQ2hpYjNoZmJtRnRaU3dnYjNBdWFYUnZZaWh1WlhkZmNISnBibU5wY0dGc0tTQXJJRzl3TG1sMGIySW9ibTkzS1NBcklHOXdMbWwwYjJJb2JtOTNLU2tLSUNBZ0lHbDBiMklLSUNBZ0lHUnBaeUEwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmtkWEF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklEUUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBZWGRtWDNOb1lYSnBZUzlqYjI1MGNtRmpkQzV3ZVRveU9Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUZOMGNtbHVaeWdpVEdWaGMyVWdjM1JoY25SbFpDRWdRVzF2ZFc1ME9pQWlLU0FySUZOMGNtbHVaeTVtY205dFgySjVkR1Z6S0c5d0xtbDBiMklvYm1WM1gzQnlhVzVqYVhCaGJDa3BDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lreGxZWE5sSUhOMFlYSjBaV1FoSUVGdGIzVnVkRG9nSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdGM1psOXphR0Z5YVdFdlkyOXVkSEpoWTNRdWNIazZNVEF0TVRFS0lDQWdJQzh2SUNNZ1BUMDlJRXhsWVhObElDOGdSR1Z3YjNOcGRDQTlQVDBLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWRHRjNabDl6YUdGeWFXRXVZMjl1ZEhKaFkzUXVkR0YzWmw5emFHRnlhV0V1WTJ4aGFXMWZkV3B5WVdoYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpiR0ZwYlY5MWFuSmhhRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBZWGRtWDNOb1lYSnBZUzlqYjI1MGNtRmpkQzV3ZVRvek5Bb2dJQ0FnTHk4Z1kyeGhhVzFsY2lBOUlGUjRiaTV6Wlc1a1pYSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwWVhkbVgzTm9ZWEpwWVM5amIyNTBjbUZqZEM1d2VUb3pOUW9nSUNBZ0x5OGdZbTk0WDI1aGJXVWdQU0JDZVhSbGN5aGlJbWxxWVhKaGFGOGlLU0FySUdOc1lXbHRaWEl1WW5sMFpYTUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZzJPVFpoTmpFM01qWXhOamcxWmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JoZDJaZmMyaGhjbWxoTDJOdmJuUnlZV04wTG5CNU9qTTBDaUFnSUNBdkx5QmpiR0ZwYldWeUlEMGdWSGh1TG5ObGJtUmxjZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSaGQyWmZjMmhoY21saEwyTnZiblJ5WVdOMExuQjVPak0xQ2lBZ0lDQXZMeUJpYjNoZmJtRnRaU0E5SUVKNWRHVnpLR0lpYVdwaGNtRm9YeUlwSUNzZ1kyeGhhVzFsY2k1aWVYUmxjd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEJ1SURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwWVhkbVgzTm9ZWEpwWVM5amIyNTBjbUZqZEM1d2VUb3pOd29nSUNBZ0x5OGdkV3B5WVdnZ1BTQnpaV3htTGw5allXeGpkV3hoZEdWZmRXcHlZV2dvWW05NFgyNWhiV1VwQ2lBZ0lDQmpZV3hzYzNWaUlGOWpZV3hqZFd4aGRHVmZkV3B5WVdnS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSaGQyWmZjMmhoY21saEwyTnZiblJ5WVdOMExuQjVPak00Q2lBZ0lDQXZMeUJoYzNObGNuUWdkV3B5WVdnZ1BpQlZTVzUwTmpRb01Da3NJQ0pPYnlCMWFuSmhhQ0I1WlhRaUNpQWdJQ0JoYzNObGNuUWdMeThnVG04Z2RXcHlZV2dnZVdWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdGM1psOXphR0Z5YVdFdlkyOXVkSEpoWTNRdWNIazZNVEl5Q2lBZ0lDQXZMeUJ3Y21sdVkybHdZV3dzSUdSaGRHRWdQU0J6Wld4bUxsOW5aWFJmY0hKcGJtTnBjR0ZzS0dKdmVGOXVZVzFsS1FvZ0lDQWdZMkZzYkhOMVlpQmZaMlYwWDNCeWFXNWphWEJoYkFvZ0lDQWdjM2RoY0FvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR0YzWmw5emFHRnlhV0V2WTI5dWRISmhZM1F1Y0hrNk1USXpDaUFnSUNBdkx5QnBaaUJ3Y21sdVkybHdZV3dnUFQwZ1ZVbHVkRFkwS0RBcE9nb2dJQ0FnWW5vZ1kyeGhhVzFmZFdweVlXaGZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE11ZEdGM1psOXphR0Z5YVdFdVkyOXVkSEpoWTNRdWRHRjNabDl6YUdGeWFXRXVYM1Z3WkdGMFpWOWliM2hmZEdsdFpVQTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHRjNabDl6YUdGeWFXRXZZMjl1ZEhKaFkzUXVjSGs2TVRJMUNpQWdJQ0F2THlCemRHRnlkQ0E5SUc5d0xtSjBiMmtvYjNBdVpYaDBjbUZqZENoa1lYUmhMQ0E0TENBNEtTa0tJQ0FnSUdScFp5QXhDaUFnSUNCbGVIUnlZV04wSURnZ09Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSaGQyWmZjMmhoY21saEwyTnZiblJ5WVdOMExuQjVPakV5TmdvZ0lDQWdMeThnYjNBdVFtOTRMbkIxZENoaWIzaGZibUZ0WlN3Z2IzQXVhWFJ2WWlod2NtbHVZMmx3WVd3cElDc2diM0F1YVhSdllpaHpkR0Z5ZENrZ0t5QnZjQzVwZEc5aUtFZHNiMkpoYkM1c1lYUmxjM1JmZEdsdFpYTjBZVzF3S1NrS0lDQWdJR1JwWnlBeENpQWdJQ0JwZEc5aUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRFFLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0NtTnNZV2x0WDNWcWNtRm9YMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TG5SaGQyWmZjMmhoY21saExtTnZiblJ5WVdOMExuUmhkMlpmYzJoaGNtbGhMbDkxY0dSaGRHVmZZbTk0WDNScGJXVkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBZWGRtWDNOb1lYSnBZUzlqYjI1MGNtRmpkQzV3ZVRvME1Rb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLSEpsWTJWcGRtVnlQV05zWVdsdFpYSXNJR0Z0YjNWdWREMTFhbkpoYUN3Z1ptVmxQVlZKYm5RMk5DZ3dLU2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdScFp5QXlDaUFnSUNCa2RYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FXMXZkVzUwQ2lBZ0lDQmthV2NnTlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWldObGFYWmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklIQmhlUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JoZDJaZmMyaGhjbWxoTDJOdmJuUnlZV04wTG5CNU9qUXpDaUFnSUNBdkx5QnlaWFIxY200Z1UzUnlhVzVuS0NKVmFuSmhhQ0JqYkdGcGJXVmtPaUFpS1NBcklGTjBjbWx1Wnk1bWNtOXRYMko1ZEdWektHOXdMbWwwYjJJb2RXcHlZV2dwS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pWYW5KaGFDQmpiR0ZwYldWa09pQWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBZWGRtWDNOb1lYSnBZUzlqYjI1MGNtRmpkQzV3ZVRvek1TMHpNZ29nSUNBZ0x5OGdJeUE5UFQwZ1EyeGhhVzBnY0hKdlptbDBJQ2gxYW5KaGFDa2dQVDA5Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuUmhkMlpmYzJoaGNtbGhMbU52Ym5SeVlXTjBMblJoZDJaZmMyaGhjbWxoTG5SbGNtMXBibUYwWlY5c1pXRnpaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25SbGNtMXBibUYwWlY5c1pXRnpaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBZWGRtWDNOb1lYSnBZUzlqYjI1MGNtRmpkQzV3ZVRvME5TMDBOZ29nSUNBZ0x5OGdJeUE5UFQwZ1YybDBhR1J5WVhjZ2NISnBibU5wY0dGc0lDaHdZWEowYVdGc0wyWjFiR3dwSUQwOVBRb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR0YzWmw5emFHRnlhV0V2WTI5dWRISmhZM1F1Y0hrNk5EZ0tJQ0FnSUM4dklIVnpaWElnUFNCVWVHNHVjMlZ1WkdWeUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwWVhkbVgzTm9ZWEpwWVM5amIyNTBjbUZqZEM1d2VUbzBPUW9nSUNBZ0x5OGdZbTk0WDI1aGJXVWdQU0JDZVhSbGN5aGlJbWxxWVhKaGFGOGlLU0FySUhWelpYSXVZbmwwWlhNS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnMk9UWmhOakUzTWpZeE5qZzFaZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwWVhkbVgzTm9ZWEpwWVM5amIyNTBjbUZqZEM1d2VUbzFNQW9nSUNBZ0x5OGdZWE56WlhKMElHRnRiM1Z1ZENBK0lGVkpiblEyTkNnd0tTd2dJa2x1ZG1Gc2FXUWdZVzF2ZFc1MElnb2dJQ0FnWkdsbklERUtJQ0FnSUdGemMyVnlkQ0F2THlCSmJuWmhiR2xrSUdGdGIzVnVkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUmhkMlpmYzJoaGNtbGhMMk52Ym5SeVlXTjBMbkI1T2pVeUNpQWdJQ0F2THlCd2NtbHVZMmx3WVd3c0lHSnZlRjlrWVhSaElEMGdjMlZzWmk1ZloyVjBYM0J5YVc1amFYQmhiQ2hpYjNoZmJtRnRaU2tLSUNBZ0lHUjFjQW9nSUNBZ1kyRnNiSE4xWWlCZloyVjBYM0J5YVc1amFYQmhiQW9nSUNBZ1kyOTJaWElnTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JoZDJaZmMyaGhjbWxoTDJOdmJuUnlZV04wTG5CNU9qVXpDaUFnSUNBdkx5QmhjM05sY25RZ1lXMXZkVzUwSUR3OUlIQnlhVzVqYVhCaGJDd2dJa1Y0WTJWbFpITWdZbUZzWVc1alpTSUtJQ0FnSUdScFp5QXlDaUFnSUNCa2FXY2dNUW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCRmVHTmxaV1J6SUdKaGJHRnVZMlVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBZWGRtWDNOb1lYSnBZUzlqYjI1MGNtRmpkQzV3ZVRvMU5Rb2dJQ0FnTHk4Z2RXcHlZV2dnUFNCelpXeG1MbDlqWVd4amRXeGhkR1ZmZFdweVlXZ29ZbTk0WDI1aGJXVXBDaUFnSUNCemQyRndDaUFnSUNCallXeHNjM1ZpSUY5allXeGpkV3hoZEdWZmRXcHlZV2dLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBZWGRtWDNOb1lYSnBZUzlqYjI1MGNtRmpkQzV3ZVRvMU5nb2dJQ0FnTHk4Z2RHOTBZV3dnUFNCaGJXOTFiblFnS3lCMWFuSmhhQW9nSUNBZ1pHbG5JRElLSUNBZ0lDc0tJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBZWGRtWDNOb1lYSnBZUzlqYjI1MGNtRmpkQzV3ZVRvMU9Bb2dJQ0FnTHk4Z2JtVjNYM0J5YVc1amFYQmhiQ0E5SUhCeWFXNWphWEJoYkNBdElHRnRiM1Z1ZEFvZ0lDQWdjM2RoY0FvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR0YzWmw5emFHRnlhV0V2WTI5dWRISmhZM1F1Y0hrNk5Ua0tJQ0FnSUM4dklHNXZkeUE5SUVkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdDaUFnSUNCbmJHOWlZV3dnVEdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR0YzWmw5emFHRnlhV0V2WTI5dWRISmhZM1F1Y0hrNk5qRUtJQ0FnSUM4dklHbG1JRzVsZDE5d2NtbHVZMmx3WVd3Z1BUMGdWVWx1ZERZMEtEQXBPZ29nSUNBZ1ltNTZJSFJsY20xcGJtRjBaVjlzWldGelpWOWxiSE5sWDJKdlpIbEFNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUmhkMlpmYzJoaGNtbGhMMk52Ym5SeVlXTjBMbkI1T2pZeUNpQWdJQ0F2THlCdmNDNUNiM2d1WkdWc1pYUmxLR0p2ZUY5dVlXMWxLUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2dwMFpYSnRhVzVoZEdWZmJHVmhjMlZmWVdaMFpYSmZhV1pmWld4elpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUmhkMlpmYzJoaGNtbGhMMk52Ym5SeVlXTjBMbkI1T2pZM0NpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9jbVZqWldsMlpYSTlkWE5sY2l3Z1lXMXZkVzUwUFhSdmRHRnNMQ0JtWldVOVZVbHVkRFkwS0RBcEtTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdaR2xuSURJS0lDQWdJR1IxY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUdScFp5QTFDaUFnSUNCcGRIaHVYMlpwWld4a0lGSmxZMlZwZG1WeUNpQWdJQ0JwYm5Salh6QWdMeThnY0dGNUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHRjNabDl6YUdGeWFXRXZZMjl1ZEhKaFkzUXVjSGs2TmprS0lDQWdJQzh2SUhKbGRIVnliaUJUZEhKcGJtY29JbGRwZEdoa2NtRjNiaUFpS1NBcklGTjBjbWx1Wnk1bWNtOXRYMko1ZEdWektHOXdMbWwwYjJJb2RHOTBZV3dwS1NBcklGTjBjbWx1WnlnaUlHMXBZM0p2UVV4SFR5SXBDaUFnSUNCcGRHOWlDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lsZHBkR2hrY21GM2JpQWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlJRzFwWTNKdlFVeEhUeUlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JoZDJaZmMyaGhjbWxoTDJOdmJuUnlZV04wTG5CNU9qUTFMVFEyQ2lBZ0lDQXZMeUFqSUQwOVBTQlhhWFJvWkhKaGR5QndjbWx1WTJsd1lXd2dLSEJoY25ScFlXd3ZablZzYkNrZ1BUMDlDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3AwWlhKdGFXNWhkR1ZmYkdWaGMyVmZaV3h6WlY5aWIyUjVRRE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR0YzWmw5emFHRnlhV0V2WTI5dWRISmhZM1F1Y0hrNk5qUUtJQ0FnSUM4dklISmxiblJoYkY5emRHRnlkQ0E5SUc5d0xtSjBiMmtvYjNBdVpYaDBjbUZqZENoaWIzaGZaR0YwWVN3Z09Dd2dPQ2twQ2lBZ0lDQmthV2NnTkFvZ0lDQWdaWGgwY21GamRDQTRJRGdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBZWGRtWDNOb1lYSnBZUzlqYjI1MGNtRmpkQzV3ZVRvMk5Rb2dJQ0FnTHk4Z2IzQXVRbTk0TG5CMWRDaGliM2hmYm1GdFpTd2diM0F1YVhSdllpaHVaWGRmY0hKcGJtTnBjR0ZzS1NBcklHOXdMbWwwYjJJb2NtVnVkR0ZzWDNOMFlYSjBLU0FySUc5d0xtbDBiMklvYm05M0tTa0tJQ0FnSUdScFp5QXpDaUFnSUNCcGRHOWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUdJZ2RHVnliV2x1WVhSbFgyeGxZWE5sWDJGbWRHVnlYMmxtWDJWc2MyVkFOQW9LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1MFlYZG1YM05vWVhKcFlTNWpiMjUwY21GamRDNTBZWGRtWDNOb1lYSnBZUzVuWlhSZmJYbGZhV3BoY21Gb1gybHVabTliY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUmZiWGxmYVdwaGNtRm9YMmx1Wm04NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdGM1psOXphR0Z5YVdFdlkyOXVkSEpoWTNRdWNIazZOelVLSUNBZ0lDOHZJR0p2ZUY5dVlXMWxJRDBnUW5sMFpYTW9ZaUpwYW1GeVlXaGZJaWtnS3lCallXeHNaWEl1WW5sMFpYTUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZzJPVFpoTmpFM01qWXhOamcxWmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JoZDJaZmMyaGhjbWxoTDJOdmJuUnlZV04wTG5CNU9qYzBDaUFnSUNBdkx5QmpZV3hzWlhJZ1BTQlVlRzR1YzJWdVpHVnlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdGM1psOXphR0Z5YVdFdlkyOXVkSEpoWTNRdWNIazZOelVLSUNBZ0lDOHZJR0p2ZUY5dVlXMWxJRDBnUW5sMFpYTW9ZaUpwYW1GeVlXaGZJaWtnS3lCallXeHNaWEl1WW5sMFpYTUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHRjNabDl6YUdGeWFXRXZZMjl1ZEhKaFkzUXVjSGs2TnpZS0lDQWdJQzh2SUhCeWFXNWphWEJoYkN3Z1ltOTRYMlJoZEdFZ1BTQnpaV3htTGw5blpYUmZjSEpwYm1OcGNHRnNLR0p2ZUY5dVlXMWxLUW9nSUNBZ1kyRnNiSE4xWWlCZloyVjBYM0J5YVc1amFYQmhiQW9nSUNBZ2MzZGhjQW9nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHRjNabDl6YUdGeWFXRXZZMjl1ZEhKaFkzUXVjSGs2TnpnS0lDQWdJQzh2SUdsbUlIQnlhVzVqYVhCaGJDQTlQU0JWU1c1ME5qUW9NQ2s2Q2lBZ0lDQmlibm9nWjJWMFgyMTVYMmxxWVhKaGFGOXBibVp2WDJGbWRHVnlYMmxtWDJWc2MyVkFNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUmhkMlpmYzJoaGNtbGhMMk52Ym5SeVlXTjBMbkI1T2pjNUNpQWdJQ0F2THlCeVpYUjFjbTRnS0ZWSmJuUTJOQ2d3S1N3Z1ZVbHVkRFkwS0RBcExDQlZTVzUwTmpRb01Da3BDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWkhWd2JpQXlDZ3BuWlhSZmJYbGZhV3BoY21Gb1gybHVabTlmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdWRHRjNabDl6YUdGeWFXRXVZMjl1ZEhKaFkzUXVkR0YzWmw5emFHRnlhV0V1WjJWMFgyMTVYMmxxWVhKaGFGOXBibVp2UURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdGM1psOXphR0Z5YVdFdlkyOXVkSEpoWTNRdWNIazZOekV0TnpJS0lDQWdJQzh2SUNNZ1BUMDlJRlpwWlhjZ2IzZHVJR2x1Wm04Z1BUMDlDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSdllnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0taMlYwWDIxNVgybHFZWEpoYUY5cGJtWnZYMkZtZEdWeVgybG1YMlZzYzJWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MFlYZG1YM05vWVhKcFlTOWpiMjUwY21GamRDNXdlVG80TVFvZ0lDQWdMeThnZFdweVlXZ2dQU0J6Wld4bUxsOWpZV3hqZFd4aGRHVmZkV3B5WVdnb1ltOTRYMjVoYldVcENpQWdJQ0JrYVdjZ01nb2dJQ0FnWTJGc2JITjFZaUJmWTJGc1kzVnNZWFJsWDNWcWNtRm9DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHRjNabDl6YUdGeWFXRXZZMjl1ZEhKaFkzUXVjSGs2T0RJS0lDQWdJQzh2SUhOMFlYSjBJRDBnYjNBdVluUnZhU2h2Y0M1bGVIUnlZV04wS0dKdmVGOWtZWFJoTENBNExDQTRLU2tLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBZWGRtWDNOb1lYSnBZUzlqYjI1MGNtRmpkQzV3ZVRvNE13b2dJQ0FnTHk4Z1pIVnlZWFJwYjI0Z1BTQkhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0NBdElITjBZWEowQ2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQXRDaUFnSUNCa2FXY2dNZ29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JoZDJaZmMyaGhjbWxoTDJOdmJuUnlZV04wTG5CNU9qY3hMVGN5Q2lBZ0lDQXZMeUFqSUQwOVBTQldhV1YzSUc5M2JpQnBibVp2SUQwOVBRb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCaUlHZGxkRjl0ZVY5cGFtRnlZV2hmYVc1bWIxOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTUwWVhkbVgzTm9ZWEpwWVM1amIyNTBjbUZqZEM1MFlYZG1YM05vWVhKcFlTNW5aWFJmYlhsZmFXcGhjbUZvWDJsdVptOUFOQW9LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1MFlYZG1YM05vWVhKcFlTNWpiMjUwY21GamRDNTBZWGRtWDNOb1lYSnBZUzVqYUdWamExOXNaWE56YjNKZmFXNW1iMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21Ob1pXTnJYMnhsYzNOdmNsOXBibVp2T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JoZDJaZmMyaGhjbWxoTDJOdmJuUnlZV04wTG5CNU9qZzNMVGc0Q2lBZ0lDQXZMeUFqSUQwOVBTQldhV1YzSUc5MGFHVnljeUE5UFQwS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUmhkMlpmYzJoaGNtbGhMMk52Ym5SeVlXTjBMbkI1T2prd0NpQWdJQ0F2THlCaWIzaGZibUZ0WlNBOUlFSjVkR1Z6S0dJaWFXcGhjbUZvWHlJcElDc2diR1Z6YzI5eUxtSjVkR1Z6Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TmprMllUWXhOekkyTVRZNE5XWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUmhkMlpmYzJoaGNtbGhMMk52Ym5SeVlXTjBMbkI1T2preENpQWdJQ0F2THlCd2NtbHVZMmx3WVd3c0lHUjFiVzE1WDJSaGRHRWdQU0J6Wld4bUxsOW5aWFJmY0hKcGJtTnBjR0ZzS0dKdmVGOXVZVzFsS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmpZV3hzYzNWaUlGOW5aWFJmY0hKcGJtTnBjR0ZzQ2lBZ0lDQndiM0FLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBZWGRtWDNOb1lYSnBZUzlqYjI1MGNtRmpkQzV3ZVRvNU1nb2dJQ0FnTHk4Z2NtVjBkWEp1SUNod2NtbHVZMmx3WVd3c0lITmxiR1l1WDJOaGJHTjFiR0YwWlY5MWFuSmhhQ2hpYjNoZmJtRnRaU2twQ2lBZ0lDQmpZV3hzYzNWaUlGOWpZV3hqZFd4aGRHVmZkV3B5WVdnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwWVhkbVgzTm9ZWEpwWVM5amIyNTBjbUZqZEM1d2VUbzROeTA0T0FvZ0lDQWdMeThnSXlBOVBUMGdWbWxsZHlCdmRHaGxjbk1nUFQwOUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1MFlYZG1YM05vWVhKcFlTNWpiMjUwY21GamRDNTBZWGRtWDNOb1lYSnBZUzUwYjNSaGJGOWpiMjUwY21GamRGOWlZV3hoYm1ObFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkRzkwWVd4ZlkyOXVkSEpoWTNSZlltRnNZVzVqWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwWVhkbVgzTm9ZWEpwWVM5amIyNTBjbUZqZEM1d2VUbzVOd29nSUNBZ0x5OGdjbVYwZFhKdUlHOXdMbUpoYkdGdVkyVW9SMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5a0tJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNCaVlXeGhibU5sQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR0YzWmw5emFHRnlhV0V2WTI5dWRISmhZM1F1Y0hrNk9UUXRPVFVLSUNBZ0lDOHZJQ01nUFQwOUlGWnBaWGNnZEc5MFlXd2dZbUZzWVc1alpTQTlQVDBLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NTBZWGRtWDNOb1lYSnBZUzVqYjI1MGNtRmpkQzUwWVhkbVgzTm9ZWEpwWVM1ZlkyRnNZM1ZzWVhSbFgzVnFjbUZvS0dKdmVGOXVZVzFsT2lCaWVYUmxjeWtnTFQ0Z2RXbHVkRFkwT2dwZlkyRnNZM1ZzWVhSbFgzVnFjbUZvT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JoZDJaZmMyaGhjbWxoTDJOdmJuUnlZV04wTG5CNU9qazVMVEV3TVFvZ0lDQWdMeThnSXlBOVBUMGdTVzUwWlhKdVlXd2dhR1ZzY0dWeWN5QTlQVDBLSUNBZ0lDOHZJRUJ6ZFdKeWIzVjBhVzVsQ2lBZ0lDQXZMeUJrWldZZ1gyTmhiR04xYkdGMFpWOTFhbkpoYUNoelpXeG1MQ0JpYjNoZmJtRnRaVG9nUW5sMFpYTXBJQzArSUZWSmJuUTJORG9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSaGQyWmZjMmhoY21saEwyTnZiblJ5WVdOMExuQjVPakV3TWdvZ0lDQWdMeThnY0hKcGJtTnBjR0ZzTENCaWIzaGZaR0YwWVNBOUlITmxiR1l1WDJkbGRGOXdjbWx1WTJsd1lXd29ZbTk0WDI1aGJXVXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOaGJHeHpkV0lnWDJkbGRGOXdjbWx1WTJsd1lXd0tJQ0FnSUhOM1lYQUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSaGQyWmZjMmhoY21saEwyTnZiblJ5WVdOMExuQjVPakV3TXdvZ0lDQWdMeThnYVdZZ2NISnBibU5wY0dGc0lEMDlJRlZKYm5RMk5DZ3dLVG9LSUNBZ0lHSnVlaUJmWTJGc1kzVnNZWFJsWDNWcWNtRm9YMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSaGQyWmZjMmhoY21saEwyTnZiblJ5WVdOMExuQjVPakV3TkFvZ0lDQWdMeThnY21WMGRYSnVJRlZKYm5RMk5DZ3dLUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ3BmWTJGc1kzVnNZWFJsWDNWcWNtRm9YMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MFlYZG1YM05vWVhKcFlTOWpiMjUwY21GamRDNXdlVG94TURZS0lDQWdJQzh2SUd4aGMzUmZZMnhoYVcwZ1BTQnZjQzVpZEc5cEtHOXdMbVY0ZEhKaFkzUW9ZbTk0WDJSaGRHRXNJREUyTENBNEtTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0J3ZFhOb2FXNTBJREUySUM4dklERTJDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUmhkMlpmYzJoaGNtbGhMMk52Ym5SeVlXTjBMbkI1T2pFd053b2dJQ0FnTHk4Z1pXeGhjSE5sWkNBOUlFZHNiMkpoYkM1c1lYUmxjM1JmZEdsdFpYTjBZVzF3SUMwZ2JHRnpkRjlqYkdGcGJRb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnYzNkaGNBb2dJQ0FnTFFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JoZDJaZmMyaGhjbWxoTDJOdmJuUnlZV04wTG5CNU9qRXdPUW9nSUNBZ0x5OGdjbVYwZFhKdUlDaHdjbWx1WTJsd1lXd2dLaUJsYkdGd2MyVmtJQ29nYzJWc1ppNUJUazVWUVV4ZlZVcFNRVWhmVWtGVVJWOUNVQ2tnTHk4Z0tITmxiR1l1VTBWRFQwNUVVMTlRUlZKZldVVkJVaUFxSUZWSmJuUTJOQ2d4TUY4d01EQXBLUW9nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUNvS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0pCVGs1VlFVeGZWVXBTUVVoZlVrRlVSVjlDVUNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNUJUazVWUVV4ZlZVcFNRVWhmVWtGVVJWOUNVQ0JsZUdsemRITUtJQ0FnSUNvS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0pUUlVOUFRrUlRYMUJGVWw5WlJVRlNJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTGxORlEwOU9SRk5mVUVWU1gxbEZRVklnWlhocGMzUnpDaUFnSUNCd2RYTm9hVzUwSURFd01EQXdJQzh2SURFd01EQXdDaUFnSUNBcUNpQWdJQ0F2Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NTBZWGRtWDNOb1lYSnBZUzVqYjI1MGNtRmpkQzUwWVhkbVgzTm9ZWEpwWVM1ZloyVjBYM0J5YVc1amFYQmhiQ2hpYjNoZmJtRnRaVG9nWW5sMFpYTXBJQzArSUhWcGJuUTJOQ3dnWW5sMFpYTTZDbDluWlhSZmNISnBibU5wY0dGc09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSaGQyWmZjMmhoY21saEwyTnZiblJ5WVdOMExuQjVPakV4TVMweE1USUtJQ0FnSUM4dklFQnpkV0p5YjNWMGFXNWxDaUFnSUNBdkx5QmtaV1lnWDJkbGRGOXdjbWx1WTJsd1lXd29jMlZzWml3Z1ltOTRYMjVoYldVNklFSjVkR1Z6S1NBdFBpQjBkWEJzWlZ0VlNXNTBOalFzSUVKNWRHVnpYVG9LSUNBZ0lIQnliM1J2SURFZ01nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSaGQyWmZjMmhoY21saEwyTnZiblJ5WVdOMExuQjVPakV4TXdvZ0lDQWdMeThnYkdWdVozUm9MQ0JsZUdsemRITWdQU0J2Y0M1Q2IzZ3ViR1Z1WjNSb0tHSnZlRjl1WVcxbEtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpYjNoZmJHVnVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHRjNabDl6YUdGeWFXRXZZMjl1ZEhKaFkzUXVjSGs2TVRFMENpQWdJQ0F2THlCcFppQnViM1FnWlhocGMzUnpJRzl5SUd4bGJtZDBhQ0E5UFNCVlNXNTBOalFvTUNrNkNpQWdJQ0JpZWlCZloyVjBYM0J5YVc1amFYQmhiRjlwWmw5aWIyUjVRRElLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCaWJub2dYMmRsZEY5d2NtbHVZMmx3WVd4ZllXWjBaWEpmYVdaZlpXeHpaVUF6Q2dwZloyVjBYM0J5YVc1amFYQmhiRjlwWmw5aWIyUjVRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR0YzWmw5emFHRnlhV0V2WTI5dWRISmhZM1F1Y0hrNk1URTFDaUFnSUNBdkx5QnlaWFIxY200Z0tGVkpiblEyTkNnd0tTd2dRbmwwWlhNb1lpSWlLU2tLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjbVYwYzNWaUNncGZaMlYwWDNCeWFXNWphWEJoYkY5aFpuUmxjbDlwWmw5bGJITmxRRE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR0YzWmw5emFHRnlhV0V2WTI5dWRISmhZM1F1Y0hrNk1URTJDaUFnSUNBdkx5QmtZWFJoTENCbmIzUWdQU0J2Y0M1Q2IzZ3VaMlYwS0dKdmVGOXVZVzFsS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwWVhkbVgzTm9ZWEpwWVM5amIyNTBjbUZqZEM1d2VUb3hNVGNLSUNBZ0lDOHZJSEJ5YVc1amFYQmhiQ0E5SUc5d0xtSjBiMmtvYjNBdVpYaDBjbUZqZENoa1lYUmhMQ0F3TENBNEtTa0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdGM1psOXphR0Z5YVdFdlkyOXVkSEpoWTNRdWNIazZNVEU0Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdLSEJ5YVc1amFYQmhiQ3dnWkdGMFlTa0tJQ0FnSUhOM1lYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjbVYwYzNWaUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBREFRQUlKZ1FFRlI5OGRRZHBhbUZ5WVdoZkZFRk9UbFZCVEY5VlNsSkJTRjlTUVZSRlgwSlFFRk5GUTA5T1JGTmZVRVZTWDFsRlFWSXhHRUFBRENxQnJBSm5LNEhnajRZUFp6RWJRUUE1TVJrVVJERVlSSUlHQkFoSThDa0VWRzdoZ0FTMVZPTmdCTTRLRVpjRTU5SEdOUVJGOE45Mk5ob0FqZ1lBQ3dDRUFPQUJad0diQWJzQU1Sa1VNUmdVRUVRaVF6RVdJZ2xKT0JBaUVrUkpPQWN5Q2hKRU9BaEpnY0NFUFE5RU1RQXlCeWt4QUZCSEFvZ0J3VWhNaUFHT1NVRUFEN0ZKc2doTEJMSUhJcklRSTdJQnMwc0JTd1lJRmtzRUZrcFFURkJMQkV5L2dCZE1aV0Z6WlNCemRHRnlkR1ZrSVNCQmJXOTFiblE2SUV4UVNSVVdWd1lDVEZBb1RGQ3dJa014QUNreEFGQkhBb2dCTmtsT0FrU0lBVjFNU1VFQUVrc0JWd2dJU3dFV1RGQXlCeFpRU3dSTXY3RkxBa215Q0VzRnNnY2lzaEFqc2dHekZvQVBWV3B5WVdnZ1kyeGhhVzFsWkRvZ1RGQkpGUlpYQmdKTVVDaE1VTEFpUXpZYUFVa1ZKQkpFRnpFQVNVNENLVXhRU1U0Q1N3RkVTWWdBK0U0RVN3SkxBUTVFVElnQXZrc0NDRTREVEFsSlRnSXlCMDRDUUFBOXZFaXhTd0pKc2doTEJiSUhJcklRSTdJQnN4YUFDbGRwZEdoa2NtRjNiaUJNVUlBS0lHMXBZM0p2UVV4SFQxQkpGUlpYQmdKTVVDaE1VTEFpUTBzRVZ3Z0lTd01XVEZCTEFoWlF2MEwvc3lreEFGQkppQUNFVEVsQUFCTWpSd0pQQWhaUEFoWlFUQlpRS0V4UXNDSkRTd0tJQURsTEFpUmJNZ2RNQ1VzQ1RnSkMvOXcyR2dGSkZZRWdFa1FwVEZCSmlBQklTRXlJQUJWTUZrd1dVQ2hNVUxBaVF6SUtZQllvVEZDd0lrT0tBUUdMLzRnQUpreEpRQUFFSTR3QWlZc0FnUkJiTWdkTUNZc0JDeU1xWlVRTEl5dGxSSUdRVGdzS2pBQ0ppZ0VDaS8rOVFRQUZpd0JBQUFZamdBQlBBb21MLzc1SVNTTmJURThDaVE9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjQsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
