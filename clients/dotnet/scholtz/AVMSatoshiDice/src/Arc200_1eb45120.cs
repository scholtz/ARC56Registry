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

namespace Arc56.Generated.scholtz.AVMSatoshiDice.Arc200_1eb45120
{


    //
    // Smart Contract Token Base Interface
    //
    public class Arc200Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public Arc200Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ApprovalStruct : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 ApprovalAmount { get; set; }

                public Algorand.Address Owner { get; set; }

                public Algorand.Address Spender { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vApprovalAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vApprovalAmount.From(ApprovalAmount);
                    ret.AddRange(vApprovalAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vOwner.From(Owner);
                    ret.AddRange(vOwner.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpender = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vSpender.From(Spender);
                    ret.AddRange(vSpender.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ApprovalStruct Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ApprovalStruct();
                    uint count = 0;
                    var vApprovalAmount = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vApprovalAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.ApprovalAmount = vApprovalAmount;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOwner = vOwner.ToValue();
                    if (valueOwner is Algorand.Address vOwnerValue) { ret.Owner = vOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpender = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vSpender.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSpender = vSpender.ToValue();
                    if (valueSpender is Algorand.Address vSpenderValue) { ret.Spender = vSpenderValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ApprovalStruct);
                }
                public bool Equals(ApprovalStruct? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ApprovalStruct left, ApprovalStruct right)
                {
                    return EqualityComparer<ApprovalStruct>.Default.Equals(left, right);
                }
                public static bool operator !=(ApprovalStruct left, ApprovalStruct right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class Arc200TransferEvent
            {
                public static readonly byte[] Selector = new byte[4] { 121, 131, 195, 92 };
                public const string Signature = "arc200_Transfer(address,address,uint256)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address From { get; set; }
                public Algorand.Address To { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Value { get; set; }

                public static Arc200TransferEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new Arc200TransferEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFrom = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vFrom.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFrom = vFrom.ToValue();
                    if (valueFrom is Algorand.Address vFromValue) { ret.From = vFromValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vTo.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTo = vTo.ToValue();
                    if (valueTo is Algorand.Address vToValue) { ret.To = vToValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vValue = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vValue.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueValue = vValue.ToValue();
                    if (valueValue is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vValueValue) { ret.Value = vValueValue; }
                    return ret;

                }

            }

            public class Arc200ApprovalEvent
            {
                public static readonly byte[] Selector = new byte[4] { 25, 105, 248, 101 };
                public const string Signature = "arc200_Approval(address,address,uint256)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Owner { get; set; }
                public Algorand.Address Spender { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Value { get; set; }

                public static Arc200ApprovalEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new Arc200ApprovalEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOwner = vOwner.ToValue();
                    if (valueOwner is Algorand.Address vOwnerValue) { ret.Owner = vOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpender = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vSpender.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSpender = vSpender.ToValue();
                    if (valueSpender is Algorand.Address vSpenderValue) { ret.Spender = vSpenderValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vValue = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vValue.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueValue = vValue.ToValue();
                    if (valueValue is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vValueValue) { ret.Value = vValueValue; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="name"> </param>
        /// <param name="symbol"> </param>
        /// <param name="decimals"> </param>
        /// <param name="totalSupply"> </param>
        public async Task<bool> Bootstrap(byte[] name, byte[] symbol, byte decimals, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 totalSupply, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 83, 130, 226 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); nameAbi.From(name);
            var symbolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); symbolAbi.From(symbol);
            var decimalsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); decimalsAbi.From(decimals);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi, symbolAbi, decimalsAbi, totalSupply }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Bootstrap_Transactions(byte[] name, byte[] symbol, byte decimals, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 totalSupply, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 83, 130, 226 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); nameAbi.From(name);
            var symbolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); symbolAbi.From(symbol);
            var decimalsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); decimalsAbi.From(decimals);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi, symbolAbi, decimalsAbi, totalSupply }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the name of the token
        ///</summary>
        public async Task<byte[]> Arc200Name(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 125, 19, 236 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> Arc200Name_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 125, 19, 236 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the symbol of the token
        ///</summary>
        public async Task<byte[]> Arc200Symbol(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 182, 174, 26, 37 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(8, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> Arc200Symbol_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 182, 174, 26, 37 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the decimals of the token
        ///</summary>
        public async Task<byte> Arc200Decimals(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 236, 19, 213 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Byte();
            returnValueObj.Decode(lastLogReturnData);
            return ReverseIfLittleEndian(lastLogReturnData)[0];

        }

        public async Task<List<Transaction>> Arc200Decimals_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 236, 19, 213 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the total supply of the token
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Arc200TotalSupply(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 153, 96, 65 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Arc200TotalSupply_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 153, 96, 65 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the current balance of the owner of the token
        ///</summary>
        /// <param name="owner">The address of the owner of the token </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Arc200BalanceOf(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 130, 229, 115, 196 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            var result = await base.SimApp(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Arc200BalanceOf_Transactions(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 130, 229, 115, 196 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Transfers tokens
        ///</summary>
        /// <param name="to">The destination of the transfer </param>
        /// <param name="value">Amount of tokens to transfer </param>
        public async Task<bool> Arc200Transfer(Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 218, 112, 37, 185 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            var result = await base.CallApp(new List<object> { abiHandle, toAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Arc200Transfer_Transactions(Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 218, 112, 37, 185 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            return await base.MakeTransactionList(new List<object> { abiHandle, toAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Transfers tokens from source to destination as approved spender
        ///</summary>
        /// <param name="from">The source of the transfer </param>
        /// <param name="to">The destination of the transfer </param>
        /// <param name="value">Amount of tokens to transfer </param>
        public async Task<bool> Arc200TransferFrom(Algorand.Address from, Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 74, 150, 143, 143 };
            var fromAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fromAbi.From(from);
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            var result = await base.CallApp(new List<object> { abiHandle, fromAbi, toAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Arc200TransferFrom_Transactions(Algorand.Address from, Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 74, 150, 143, 143 };
            var fromAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fromAbi.From(from);
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            return await base.MakeTransactionList(new List<object> { abiHandle, fromAbi, toAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Approve spender for a token
        ///</summary>
        /// <param name="spender">Who is allowed to take tokens on owner's behalf </param>
        /// <param name="value">Amount of tokens to be taken by spender </param>
        public async Task<bool> Arc200Approve(Algorand.Address spender, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 181, 66, 33, 37 };
            var spenderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spenderAbi.From(spender);

            var result = await base.CallApp(new List<object> { abiHandle, spenderAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Arc200Approve_Transactions(Algorand.Address spender, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 181, 66, 33, 37 };
            var spenderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spenderAbi.From(spender);

            return await base.MakeTransactionList(new List<object> { abiHandle, spenderAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the current allowance of the spender of the tokens of the owner
        ///</summary>
        /// <param name="owner">Owner's account </param>
        /// <param name="spender">Who is allowed to take tokens on owner's behalf </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Arc200Allowance(Algorand.Address owner, Algorand.Address spender, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 179, 25, 243 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var spenderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spenderAbi.From(spender);

            var result = await base.SimApp(new List<object> { abiHandle, ownerAbi, spenderAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Arc200Allowance_Transactions(Algorand.Address owner, Algorand.Address spender, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 179, 25, 243 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var spenderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spenderAbi.From(spender);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi, spenderAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXJjMjAwIiwiZGVzYyI6IlNtYXJ0IENvbnRyYWN0IFRva2VuIEJhc2UgSW50ZXJmYWNlIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkFwcHJvdmFsU3RydWN0IjpbeyJuYW1lIjoiYXBwcm92YWxBbW91bnQiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6Im93bmVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJzcGVuZGVyIiwidHlwZSI6ImFkZHJlc3MifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiYm9vdHN0cmFwIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN5bWJvbCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDgiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZWNpbWFscyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsU3VwcGx5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJhcmMyMDBfVHJhbnNmZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmMyMDBfbmFtZSIsImRlc2MiOiJSZXR1cm5zIHRoZSBuYW1lIG9mIHRoZSB0b2tlbiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSBuYW1lIG9mIHRoZSB0b2tlbiJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjMjAwX3N5bWJvbCIsImRlc2MiOiJSZXR1cm5zIHRoZSBzeW1ib2wgb2YgdGhlIHRva2VuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbOF0iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJUaGUgc3ltYm9sIG9mIHRoZSB0b2tlbiJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjMjAwX2RlY2ltYWxzIiwiZGVzYyI6IlJldHVybnMgdGhlIGRlY2ltYWxzIG9mIHRoZSB0b2tlbiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50OCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSBkZWNpbWFscyBvZiB0aGUgdG9rZW4ifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzIwMF90b3RhbFN1cHBseSIsImRlc2MiOiJSZXR1cm5zIHRoZSB0b3RhbCBzdXBwbHkgb2YgdGhlIHRva2VuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJUaGUgdG90YWwgc3VwcGx5IG9mIHRoZSB0b2tlbiJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjMjAwX2JhbGFuY2VPZiIsImRlc2MiOiJSZXR1cm5zIHRoZSBjdXJyZW50IGJhbGFuY2Ugb2YgdGhlIG93bmVyIG9mIHRoZSB0b2tlbiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjoiVGhlIGFkZHJlc3Mgb2YgdGhlIG93bmVyIG9mIHRoZSB0b2tlbiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjoiVGhlIGN1cnJlbnQgYmFsYW5jZSBvZiB0aGUgaG9sZGVyIG9mIHRoZSB0b2tlbiJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjMjAwX3RyYW5zZmVyIiwiZGVzYyI6IlRyYW5zZmVycyB0b2tlbnMiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6IlRoZSBkZXN0aW5hdGlvbiBvZiB0aGUgdHJhbnNmZXIiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOiJBbW91bnQgb2YgdG9rZW5zIHRvIHRyYW5zZmVyIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJTdWNjZXNzIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6ImFyYzIwMF9UcmFuc2ZlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZnJvbSIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzIwMF90cmFuc2ZlckZyb20iLCJkZXNjIjoiVHJhbnNmZXJzIHRva2VucyBmcm9tIHNvdXJjZSB0byBkZXN0aW5hdGlvbiBhcyBhcHByb3ZlZCBzcGVuZGVyIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmcm9tIiwiZGVzYyI6IlRoZSBzb3VyY2Ugb2YgdGhlIHRyYW5zZmVyIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjoiVGhlIGRlc3RpbmF0aW9uIG9mIHRoZSB0cmFuc2ZlciIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6IkFtb3VudCBvZiB0b2tlbnMgdG8gdHJhbnNmZXIiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlN1Y2Nlc3MifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiYXJjMjAwX0FwcHJvdmFsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcGVuZGVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJhcmMyMDBfVHJhbnNmZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmMyMDBfYXBwcm92ZSIsImRlc2MiOiJBcHByb3ZlIHNwZW5kZXIgZm9yIGEgdG9rZW4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwZW5kZXIiLCJkZXNjIjoiV2hvIGlzIGFsbG93ZWQgdG8gdGFrZSB0b2tlbnMgb24gb3duZXIncyBiZWhhbGYiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOiJBbW91bnQgb2YgdG9rZW5zIHRvIGJlIHRha2VuIGJ5IHNwZW5kZXIiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlN1Y2Nlc3MifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiYXJjMjAwX0FwcHJvdmFsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcGVuZGVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjMjAwX2FsbG93YW5jZSIsImRlc2MiOiJSZXR1cm5zIHRoZSBjdXJyZW50IGFsbG93YW5jZSBvZiB0aGUgc3BlbmRlciBvZiB0aGUgdG9rZW5zIG9mIHRoZSBvd25lciIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjoiT3duZXIncyBhY2NvdW50IiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3BlbmRlciIsImRlc2MiOiJXaG8gaXMgYWxsb3dlZCB0byB0YWtlIHRva2VucyBvbiBvd25lcidzIGJlaGFsZiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjoiVGhlIHJlbWFpbmluZyBhbGxvd2FuY2UifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6NH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNTkzLDcyM10sImVycm9yTWVzc2FnZSI6IkJveCBtdXN0IGhhdmUgdmFsdWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MjRdLCJlcnJvck1lc3NhZ2UiOiJJbmRleCBhY2Nlc3MgaXMgb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYxNF0sImVycm9yTWVzc2FnZSI6Ikluc3VmZmljaWVudCBiYWxhbmNlIGF0IHRoZSBzZW5kZXIgYWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM3MV0sImVycm9yTWVzc2FnZSI6Ik5hbWUgb2YgdGhlIGFzc2V0IG11c3QgYmUgbG9uZ2VyIG9yIGVxdWFsIHRvIDEgY2hhcmFjdGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzc0XSwiZXJyb3JNZXNzYWdlIjoiTmFtZSBvZiB0aGUgYXNzZXQgbXVzdCBiZSBzaG9ydGVyIG9yIGVxdWFsIHRvIDMyIGNoYXJhY3RlcnMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDUsMTY3LDE4OSwyMTQsMjM2LDI1NSwyNzEsMjg3LDMwMywzMTldLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNjNdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGRlcGxveWVyIG9mIHRoaXMgc21hcnQgY29udHJhY3QgY2FuIGNhbGwgYm9vdHN0cmFwIG1ldGhvZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM4Ml0sImVycm9yTWVzc2FnZSI6IlN5bWJvbCBvZiB0aGUgYXNzZXQgbXVzdCBiZSBsb25nZXIgb3IgZXF1YWwgdG8gMSBjaGFyYWN0ZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszODVdLCJlcnJvck1lc3NhZ2UiOiJTeW1ib2wgb2YgdGhlIGFzc2V0IG11c3QgYmUgc2hvcnRlciBvciBlcXVhbCB0byA4IGNoYXJhY3RlcnMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOTJdLCJlcnJvck1lc3NhZ2UiOiJUaGlzIG1ldGhvZCBjYW4gYmUgY2FsbGVkIG9ubHkgb25jZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM1Ml0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0OCwxNzAsMTkyLDIxNywyMzksMjU4LDI3NCwyOTAsMzA2LDMyMl0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NDMsNDU4LDQ3Myw0NzhdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MThdLCJlcnJvck1lc3NhZ2UiOiJpbnN1ZmZpY2llbnQgYXBwcm92YWwiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NTEsNDY2LDY5Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgc2l6ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUyNiw2MzIsNjU0XSwiZXJyb3JNZXNzYWdlIjoib3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01TQXpNaUF3SURnS0lDQWdJR0o1ZEdWallteHZZMnNnTUhneE5URm1OMk0zTlNBaVlpSWdJblFpSURCNE9EQWdNSGczT1Rnell6TTFZeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NeU1EQXZZWEpqTWpBd0xtRnNaMjh1ZEhNNk5EUUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJCY21NeU1EQWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5aVlYSmxYM0p2ZFhScGJtZEFNVFVLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGc1TnpVek9ESmxNaUF3ZURZMU4yUXhNMlZqSURCNFlqWmhaVEZoTWpVZ01IZzROR1ZqTVROa05TQXdlR1ZqT1RrMk1EUXhJREI0T0RKbE5UY3pZelFnTUhoa1lUY3dNalZpT1NBd2VEUmhPVFk0WmpobUlEQjRZalUwTWpJeE1qVWdNSGhpWW1Jek1UbG1NeUF2THlCdFpYUm9iMlFnSW1KdmIzUnpkSEpoY0NoaWVYUmxXMTBzWW5sMFpWdGRMSFZwYm5RNExIVnBiblF5TlRZcFltOXZiQ0lzSUcxbGRHaHZaQ0FpWVhKak1qQXdYMjVoYldVb0tXSjVkR1ZiTXpKZElpd2diV1YwYUc5a0lDSmhjbU15TURCZmMzbHRZbTlzS0NsaWVYUmxXemhkSWl3Z2JXVjBhRzlrSUNKaGNtTXlNREJmWkdWamFXMWhiSE1vS1hWcGJuUTRJaXdnYldWMGFHOWtJQ0poY21NeU1EQmZkRzkwWVd4VGRYQndiSGtvS1hWcGJuUXlOVFlpTENCdFpYUm9iMlFnSW1GeVl6SXdNRjlpWVd4aGJtTmxUMllvWVdSa2NtVnpjeWwxYVc1ME1qVTJJaXdnYldWMGFHOWtJQ0poY21NeU1EQmZkSEpoYm5ObVpYSW9ZV1JrY21WemN5eDFhVzUwTWpVMktXSnZiMndpTENCdFpYUm9iMlFnSW1GeVl6SXdNRjkwY21GdWMyWmxja1p5YjIwb1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEhWcGJuUXlOVFlwWW05dmJDSXNJRzFsZEdodlpDQWlZWEpqTWpBd1gyRndjSEp2ZG1Vb1lXUmtjbVZ6Y3l4MWFXNTBNalUyS1dKdmIyd2lMQ0J0WlhSb2IyUWdJbUZ5WXpJd01GOWhiR3h2ZDJGdVkyVW9ZV1JrY21WemN5eGhaR1J5WlhOektYVnBiblF5TlRZaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnRZV2x1WDJKdmIzUnpkSEpoY0Y5eWIzVjBaVUF6SUcxaGFXNWZZWEpqTWpBd1gyNWhiV1ZmY205MWRHVkFOQ0J0WVdsdVgyRnlZekl3TUY5emVXMWliMnhmY205MWRHVkFOU0J0WVdsdVgyRnlZekl3TUY5a1pXTnBiV0ZzYzE5eWIzVjBaVUEySUcxaGFXNWZZWEpqTWpBd1gzUnZkR0ZzVTNWd2NHeDVYM0p2ZFhSbFFEY2diV0ZwYmw5aGNtTXlNREJmWW1Gc1lXNWpaVTltWDNKdmRYUmxRRGdnYldGcGJsOWhjbU15TURCZmRISmhibk5tWlhKZmNtOTFkR1ZBT1NCdFlXbHVYMkZ5WXpJd01GOTBjbUZ1YzJabGNrWnliMjFmY205MWRHVkFNVEFnYldGcGJsOWhjbU15TURCZllYQndjbTkyWlY5eWIzVjBaVUF4TVNCdFlXbHVYMkZ5WXpJd01GOWhiR3h2ZDJGdVkyVmZjbTkxZEdWQU1USUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4T1RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NeU1EQXZZWEpqTWpBd0xtRnNaMjh1ZEhNNk5EUUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJCY21NeU1EQWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyRnlZekl3TUY5aGJHeHZkMkZ1WTJWZmNtOTFkR1ZBTVRJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak1qQXdMMkZ5WXpJd01DNWhiR2R2TG5Sek9qRTROZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6SXdNQzloY21NeU1EQXVZV3huYnk1MGN6bzBOQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVGeVl6SXdNQ0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU15TURBdllYSmpNakF3TG1Gc1oyOHVkSE02TVRnMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdZMkZzYkhOMVlpQmhjbU15TURCZllXeHNiM2RoYm1ObENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJGeVl6SXdNRjloY0hCeWIzWmxYM0p2ZFhSbFFERXhPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZekl3TUM5aGNtTXlNREF1WVd4bmJ5NTBjem94TnpRS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU15TURBdllYSmpNakF3TG1Gc1oyOHVkSE02TkRRS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkJjbU15TURBZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak1qQXdMMkZ5WXpJd01DNWhiR2R2TG5Sek9qRTNOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnWVhKak1qQXdYMkZ3Y0hKdmRtVUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZllYSmpNakF3WDNSeVlXNXpabVZ5Um5KdmJWOXliM1YwWlVBeE1Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTXlNREF2WVhKak1qQXdMbUZzWjI4dWRITTZNVFUzQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpNakF3TDJGeVl6SXdNQzVoYkdkdkxuUnpPalEwQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1FYSmpNakF3SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpJd01DOWhjbU15TURBdVlXeG5ieTUwY3pveE5UY0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JqWVd4c2MzVmlJR0Z5WXpJd01GOTBjbUZ1YzJabGNrWnliMjBLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZWEpqTWpBd1gzUnlZVzV6Wm1WeVgzSnZkWFJsUURrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak1qQXdMMkZ5WXpJd01DNWhiR2R2TG5Sek9qRTBOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6SXdNQzloY21NeU1EQXVZV3huYnk1MGN6bzBOQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVGeVl6SXdNQ0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU15TURBdllYSmpNakF3TG1Gc1oyOHVkSE02TVRRMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZMkZzYkhOMVlpQmhjbU15TURCZmRISmhibk5tWlhJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWVhKak1qQXdYMkpoYkdGdVkyVlBabDl5YjNWMFpVQTRPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZekl3TUM5aGNtTXlNREF1WVd4bmJ5NTBjem94TXpJS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU15TURBdllYSmpNakF3TG1Gc1oyOHVkSE02TkRRS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkJjbU15TURBZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak1qQXdMMkZ5WXpJd01DNWhiR2R2TG5Sek9qRXpNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUdOaGJHeHpkV0lnWVhKak1qQXdYMkpoYkdGdVkyVlBaZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWhjbU15TURCZmRHOTBZV3hUZFhCd2JIbGZjbTkxZEdWQU56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTXlNREF2WVhKak1qQXdMbUZzWjI4dWRITTZNVEl4Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUdGeVl6SXdNRjkwYjNSaGJGTjFjSEJzZVFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDloY21NeU1EQmZaR1ZqYVcxaGJITmZjbTkxZEdWQU5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTXlNREF2WVhKak1qQXdMbUZzWjI4dWRITTZNVEV4Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUdGeVl6SXdNRjlrWldOcGJXRnNjd29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWhjbU15TURCZmMzbHRZbTlzWDNKdmRYUmxRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTWpBd0wyRnlZekl3TUM1aGJHZHZMblJ6T2pFd01Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZMkZzYkhOMVlpQmhjbU15TURCZmMzbHRZbTlzQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMkZ5WXpJd01GOXVZVzFsWDNKdmRYUmxRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTWpBd0wyRnlZekl3TUM1aGJHZHZMblJ6T2preENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQmpZV3hzYzNWaUlHRnlZekl3TUY5dVlXMWxDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgySnZiM1J6ZEhKaGNGOXliM1YwWlVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6SXdNQzloY21NeU1EQXVZV3huYnk1MGN6bzJOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6SXdNQzloY21NeU1EQXVZV3huYnk1MGN6bzBOQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVGeVl6SXdNQ0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU15TURBdllYSmpNakF3TG1Gc1oyOHVkSE02TmpVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmpZV3hzYzNWaUlHSnZiM1J6ZEhKaGNBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aVlYSmxYM0p2ZFhScGJtZEFNVFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTWpBd0wyRnlZekl3TUM1aGJHZHZMblJ6T2pRMENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdRWEpqTWpBd0lHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4T1FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnWTNKbFlYUnBibWNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpNakF3TDJGeVl6SXdNQzVoYkdkdkxuUnpPanBCY21NeU1EQXVZbTl2ZEhOMGNtRndLRzVoYldVNklHSjVkR1Z6TENCemVXMWliMnc2SUdKNWRHVnpMQ0JrWldOcGJXRnNjem9nWW5sMFpYTXNJSFJ2ZEdGc1UzVndjR3g1T2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q21KdmIzUnpkSEpoY0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NeU1EQXZZWEpqTWpBd0xtRnNaMjh1ZEhNNk5qVXROallLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNBdkx5QndkV0pzYVdNZ1ltOXZkSE4wY21Gd0tHNWhiV1U2SUVSNWJtRnRhV05DZVhSbGN5d2djM2x0WW05c09pQkVlVzVoYldsalFubDBaWE1zSUdSbFkybHRZV3h6T2lCVmFXNTBUamdzSUhSdmRHRnNVM1Z3Y0d4NU9pQlZhVzUwVGpJMU5pazZJRUp2YjJ3Z2V3b2dJQ0FnY0hKdmRHOGdOQ0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTWpBd0wyRnlZekl3TUM1aGJHZHZMblJ6T2pZM0NpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxuTmxibVJsY2lBOVBUMGdSMnh2WW1Gc0xtTnlaV0YwYjNKQlpHUnlaWE56TENBblQyNXNlU0JrWlhCc2IzbGxjaUJ2WmlCMGFHbHpJSE50WVhKMElHTnZiblJ5WVdOMElHTmhiaUJqWVd4c0lHSnZiM1J6ZEhKaGNDQnRaWFJvYjJRbktRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaMnh2WW1Gc0lFTnlaV0YwYjNKQlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnWkdWd2JHOTVaWElnYjJZZ2RHaHBjeUJ6YldGeWRDQmpiMjUwY21GamRDQmpZVzRnWTJGc2JDQmliMjkwYzNSeVlYQWdiV1YwYUc5a0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak1qQXdMMkZ5WXpJd01DNWhiR2R2TG5Sek9qWTRDaUFnSUNBdkx5QmhjM05sY25Rb2JtRnRaUzV1WVhScGRtVXViR1Z1WjNSb0lENGdNQ3dnSjA1aGJXVWdiMllnZEdobElHRnpjMlYwSUcxMWMzUWdZbVVnYkc5dVoyVnlJRzl5SUdWeGRXRnNJSFJ2SURFZ1kyaGhjbUZqZEdWeUp5a0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Bb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR3hsYmdvZ0lDQWdaSFZ3Q2lBZ0lDQmhjM05sY25RZ0x5OGdUbUZ0WlNCdlppQjBhR1VnWVhOelpYUWdiWFZ6ZENCaVpTQnNiMjVuWlhJZ2IzSWdaWEYxWVd3Z2RHOGdNU0JqYUdGeVlXTjBaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU15TURBdllYSmpNakF3TG1Gc1oyOHVkSE02TmprS0lDQWdJQzh2SUdGemMyVnlkQ2h1WVcxbExtNWhkR2wyWlM1c1pXNW5kR2dnUEQwZ016SXNJQ2RPWVcxbElHOW1JSFJvWlNCaGMzTmxkQ0J0ZFhOMElHSmxJSE5vYjNKMFpYSWdiM0lnWlhGMVlXd2dkRzhnTXpJZ1kyaGhjbUZqZEdWeWN5Y3BDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnVG1GdFpTQnZaaUIwYUdVZ1lYTnpaWFFnYlhWemRDQmlaU0J6YUc5eWRHVnlJRzl5SUdWeGRXRnNJSFJ2SURNeUlHTm9ZWEpoWTNSbGNuTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTXlNREF2WVhKak1qQXdMbUZzWjI4dWRITTZOekFLSUNBZ0lDOHZJR0Z6YzJWeWRDaHplVzFpYjJ3dWJtRjBhWFpsTG14bGJtZDBhQ0ErSURBc0lDZFRlVzFpYjJ3Z2IyWWdkR2hsSUdGemMyVjBJRzExYzNRZ1ltVWdiRzl1WjJWeUlHOXlJR1Z4ZFdGc0lIUnZJREVnWTJoaGNtRmpkR1Z5SnlrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHeGxiZ29nSUNBZ1pIVndDaUFnSUNCaGMzTmxjblFnTHk4Z1UzbHRZbTlzSUc5bUlIUm9aU0JoYzNObGRDQnRkWE4wSUdKbElHeHZibWRsY2lCdmNpQmxjWFZoYkNCMGJ5QXhJR05vWVhKaFkzUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZekl3TUM5aGNtTXlNREF1WVd4bmJ5NTBjem8zTVFvZ0lDQWdMeThnWVhOelpYSjBLSE41YldKdmJDNXVZWFJwZG1VdWJHVnVaM1JvSUR3OUlEZ3NJQ2RUZVcxaWIyd2diMllnZEdobElHRnpjMlYwSUcxMWMzUWdZbVVnYzJodmNuUmxjaUJ2Y2lCbGNYVmhiQ0IwYnlBNElHTm9ZWEpoWTNSbGNuTW5LUW9nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnVTNsdFltOXNJRzltSUhSb1pTQmhjM05sZENCdGRYTjBJR0psSUhOb2IzSjBaWElnYjNJZ1pYRjFZV3dnZEc4Z09DQmphR0Z5WVdOMFpYSnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpNakF3TDJGeVl6SXdNQzVoYkdkdkxuUnpPall3Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkRzkwWVd4VGRYQndiSGtnUFNCSGJHOWlZV3hUZEdGMFpUeFZhVzUwVGpJMU5qNG9leUJyWlhrNklDZDBKeUI5S1FvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJblFpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTWpBd0wyRnlZekl3TUM1aGJHZHZMblJ6T2pjeUNpQWdJQ0F2THlCaGMzTmxjblFvSVhSb2FYTXVkRzkwWVd4VGRYQndiSGt1YUdGelZtRnNkV1VzSUNkVWFHbHpJRzFsZEdodlpDQmpZVzRnWW1VZ1kyRnNiR1ZrSUc5dWJIa2diMjVqWlNjcENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1luVnllU0F4Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1ZHaHBjeUJ0WlhSb2IyUWdZMkZ1SUdKbElHTmhiR3hsWkNCdmJteDVJRzl1WTJVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NeU1EQXZZWEpqTWpBd0xtRnNaMjh1ZEhNNk5EZ0tJQ0FnSUM4dklIQjFZbXhwWXlCdVlXMWxJRDBnUjJ4dlltRnNVM1JoZEdVOFJIbHVZVzFwWTBKNWRHVnpQaWg3SUd0bGVUb2dKMjRuSUgwcENpQWdJQ0J3ZFhOb1lubDBaWE1nSW00aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak1qQXdMMkZ5WXpJd01DNWhiR2R2TG5Sek9qYzBDaUFnSUNBdkx5QjBhR2x6TG01aGJXVXVkbUZzZFdVZ1BTQnVZVzFsQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTWpBd0wyRnlZekl3TUM1aGJHZHZMblJ6T2pVeUNpQWdJQ0F2THlCd2RXSnNhV01nYzNsdFltOXNJRDBnUjJ4dlltRnNVM1JoZEdVOFJIbHVZVzFwWTBKNWRHVnpQaWg3SUd0bGVUb2dKM01uSUgwcENpQWdJQ0J3ZFhOb1lubDBaWE1nSW5NaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak1qQXdMMkZ5WXpJd01DNWhiR2R2TG5Sek9qYzFDaUFnSUNBdkx5QjBhR2x6TG5ONWJXSnZiQzUyWVd4MVpTQTlJSE41YldKdmJBb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6SXdNQzloY21NeU1EQXVZV3huYnk1MGN6bzJNQW9nSUNBZ0x5OGdjSFZpYkdsaklIUnZkR0ZzVTNWd2NHeDVJRDBnUjJ4dlltRnNVM1JoZEdVOFZXbHVkRTR5TlRZK0tIc2dhMlY1T2lBbmRDY2dmU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJblFpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTWpBd0wyRnlZekl3TUM1aGJHZHZMblJ6T2pjMkNpQWdJQ0F2THlCMGFHbHpMblJ2ZEdGc1UzVndjR3g1TG5aaGJIVmxJRDBnZEc5MFlXeFRkWEJ3YkhrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NeU1EQXZZWEpqTWpBd0xtRnNaMjh1ZEhNNk5UWUtJQ0FnSUM4dklIQjFZbXhwWXlCa1pXTnBiV0ZzY3lBOUlFZHNiMkpoYkZOMFlYUmxQRlZwYm5ST09ENG9leUJyWlhrNklDZGtKeUI5S1FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0prSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpJd01DOWhjbU15TURBdVlXeG5ieTUwY3pvM053b2dJQ0FnTHk4Z2RHaHBjeTVrWldOcGJXRnNjeTUyWVd4MVpTQTlJR1JsWTJsdFlXeHpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpNakF3TDJGeVl6SXdNQzVoYkdkdkxuUnpPamM0Q2lBZ0lDQXZMeUJqYjI1emRDQnpaVzVrWlhJZ1BTQnVaWGNnUVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZekl3TUM5aGNtTXlNREF1WVd4bmJ5NTBjem8yTWdvZ0lDQWdMeThnY0hWaWJHbGpJR0poYkdGdVkyVnpJRDBnUW05NFRXRndQRUZrWkhKbGMzTXNJRlZwYm5ST01qVTJQaWg3SUd0bGVWQnlaV1pwZURvZ0oySW5JSDBwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0ppSWdvZ0lDQWdaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6SXdNQzloY21NeU1EQXVZV3huYnk1MGN6bzRNQW9nSUNBZ0x5OGdkR2hwY3k1aVlXeGhibU5sY3loelpXNWtaWElwTG5aaGJIVmxJRDBnZEc5MFlXeFRkWEJ3YkhrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6SXdNQzloY21NeU1EQXVZV3huYnk1MGN6bzRNZ29nSUNBZ0x5OGdaVzFwZENodVpYY2dZWEpqTWpBd1gxUnlZVzV6Wm1WeUtIc2dabkp2YlRvZ2JtVjNJRUZrWkhKbGMzTW9SMnh2WW1Gc0xucGxjbTlCWkdSeVpYTnpLU3dnZEc4NklITmxibVJsY2l3Z2RtRnNkV1U2SUhSdmRHRnNVM1Z3Y0d4NUlIMHBLUW9nSUNBZ1oyeHZZbUZzSUZwbGNtOUJaR1J5WlhOekNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZeUEwSUM4dklHMWxkR2h2WkNBaVlYSmpNakF3WDFSeVlXNXpabVZ5S0dGa1pISmxjM01zWVdSa2NtVnpjeXgxYVc1ME1qVTJLU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTWpBd0wyRnlZekl3TUM1aGJHZHZMblJ6T2pnekNpQWdJQ0F2THlCeVpYUjFjbTRnYm1WM0lFSnZiMndvZEhKMVpTa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZzRNQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZekl3TUM5aGNtTXlNREF1WVd4bmJ5NTBjem82UVhKak1qQXdMbUZ5WXpJd01GOXVZVzFsS0NrZ0xUNGdZbmwwWlhNNkNtRnlZekl3TUY5dVlXMWxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZekl3TUM5aGNtTXlNREF1WVd4bmJ5NTBjem8wT0FvZ0lDQWdMeThnY0hWaWJHbGpJRzVoYldVZ1BTQkhiRzlpWVd4VGRHRjBaVHhFZVc1aGJXbGpRbmwwWlhNK0tIc2dhMlY1T2lBbmJpY2dmU2tLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCd2RYTm9ZbmwwWlhNZ0ltNGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6SXdNQzloY21NeU1EQXVZV3huYnk1MGN6bzVNd29nSUNBZ0x5OGdjbVYwZFhKdUlHNWxkeUJUZEdGMGFXTkNlWFJsY3p3ek1qNG9kR2hwY3k1dVlXMWxMblpoYkhWbExtNWhkR2wyWlNrS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYzJsNlpRb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6SXdNQzloY21NeU1EQXVZV3huYnk1MGN6bzZRWEpqTWpBd0xtRnlZekl3TUY5emVXMWliMndvS1NBdFBpQmllWFJsY3pvS1lYSmpNakF3WDNONWJXSnZiRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU15TURBdllYSmpNakF3TG1Gc1oyOHVkSE02TlRJS0lDQWdJQzh2SUhCMVlteHBZeUJ6ZVcxaWIyd2dQU0JIYkc5aVlXeFRkR0YwWlR4RWVXNWhiV2xqUW5sMFpYTStLSHNnYTJWNU9pQW5jeWNnZlNrS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQndkWE5vWW5sMFpYTWdJbk1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZekl3TUM5aGNtTXlNREF1WVd4bmJ5NTBjem94TURNS0lDQWdJQzh2SUhKbGRIVnliaUJ1WlhjZ1UzUmhkR2xqUW5sMFpYTThPRDRvZEdocGN5NXplVzFpYjJ3dWRtRnNkV1V1Ym1GMGFYWmxLUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lITnBlbVVLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU15TURBdllYSmpNakF3TG1Gc1oyOHVkSE02T2tGeVl6SXdNQzVoY21NeU1EQmZaR1ZqYVcxaGJITW9LU0F0UGlCaWVYUmxjem9LWVhKak1qQXdYMlJsWTJsdFlXeHpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZekl3TUM5aGNtTXlNREF1WVd4bmJ5NTBjem8xTmdvZ0lDQWdMeThnY0hWaWJHbGpJR1JsWTJsdFlXeHpJRDBnUjJ4dlltRnNVM1JoZEdVOFZXbHVkRTQ0UGloN0lHdGxlVG9nSjJRbklIMHBDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnY0hWemFHSjVkR1Z6SUNKa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NeU1EQXZZWEpqTWpBd0xtRnNaMjh1ZEhNNk1URXpDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTVrWldOcGJXRnNjeTUyWVd4MVpRb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6SXdNQzloY21NeU1EQXVZV3huYnk1MGN6bzZRWEpqTWpBd0xtRnlZekl3TUY5MGIzUmhiRk4xY0hCc2VTZ3BJQzArSUdKNWRHVnpPZ3BoY21NeU1EQmZkRzkwWVd4VGRYQndiSGs2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTWpBd0wyRnlZekl3TUM1aGJHZHZMblJ6T2pZd0NpQWdJQ0F2THlCd2RXSnNhV01nZEc5MFlXeFRkWEJ3YkhrZ1BTQkhiRzlpWVd4VGRHRjBaVHhWYVc1MFRqSTFOajRvZXlCclpYazZJQ2QwSnlCOUtRb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5RaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpJd01DOWhjbU15TURBdVlXeG5ieTUwY3pveE1qTUtJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMblJ2ZEdGc1UzVndjR3g1TG5aaGJIVmxDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpNakF3TDJGeVl6SXdNQzVoYkdkdkxuUnpPanBCY21NeU1EQXVZWEpqTWpBd1gySmhiR0Z1WTJWUFppaHZkMjVsY2pvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwaGNtTXlNREJmWW1Gc1lXNWpaVTltT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpJd01DOWhjbU15TURBdVlXeG5ieTUwY3pveE16SXRNVE16Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ0x5OGdjSFZpYkdsaklHRnlZekl3TUY5aVlXeGhibU5sVDJZb2IzZHVaWEk2SUVGa1pISmxjM01wT2lCaGNtTTBMbFZwYm5ST01qVTJJSHNLSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6SXdNQzloY21NeU1EQXVZV3huYnk1MGN6b3hNelFLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TGw5aVlXeGhibU5sVDJZb2IzZHVaWElwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTmhiR3h6ZFdJZ1gySmhiR0Z1WTJWUFpnb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6SXdNQzloY21NeU1EQXVZV3huYnk1MGN6bzZRWEpqTWpBd0xtRnlZekl3TUY5MGNtRnVjMlpsY2loMGJ6b2dZbmwwWlhNc0lIWmhiSFZsT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q21GeVl6SXdNRjkwY21GdWMyWmxjam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU15TURBdllYSmpNakF3TG1Gc1oyOHVkSE02TVRRMExURTBOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUM4dklIQjFZbXhwWXlCaGNtTXlNREJmZEhKaGJuTm1aWElvZEc4NklFRmtaSEpsYzNNc0lIWmhiSFZsT2lCaGNtTTBMbFZwYm5ST01qVTJLVG9nWVhKak5DNUNiMjlzSUhzS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZekl3TUM5aGNtTXlNREF1WVd4bmJ5NTBjem94TkRZS0lDQWdJQzh2SUhKbGRIVnliaUIwYUdsekxsOTBjbUZ1YzJabGNpaHVaWGNnUVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1N3Z2RHOHNJSFpoYkhWbEtRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTmhiR3h6ZFdJZ1gzUnlZVzV6Wm1WeUNpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak1qQXdMMkZ5WXpJd01DNWhiR2R2TG5Sek9qcEJjbU15TURBdVlYSmpNakF3WDNSeVlXNXpabVZ5Um5KdmJTaG1jbTl0T2lCaWVYUmxjeXdnZEc4NklHSjVkR1Z6TENCMllXeDFaVG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BoY21NeU1EQmZkSEpoYm5ObVpYSkdjbTl0T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpJd01DOWhjbU15TURBdVlXeG5ieTUwY3pveE5UY3RNVFU0Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ0x5OGdjSFZpYkdsaklHRnlZekl3TUY5MGNtRnVjMlpsY2taeWIyMG9abkp2YlRvZ1FXUmtjbVZ6Y3l3Z2RHODZJRUZrWkhKbGMzTXNJSFpoYkhWbE9pQmhjbU0wTGxWcGJuUk9NalUyS1RvZ1lYSmpOQzVDYjI5c0lIc0tJQ0FnSUhCeWIzUnZJRE1nTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpJd01DOWhjbU15TURBdVlXeG5ieTUwY3pveE5Ua0tJQ0FnSUM4dklHTnZibk4wSUhOd1pXNWtaWElnUFNCdVpYY2dRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6SXdNQzloY21NeU1EQXVZV3huYnk1MGN6b3hOakFLSUNBZ0lDOHZJR052Ym5OMElITndaVzVrWlhKZllXeHNiM2RoYm1ObElEMGdkR2hwY3k1ZllXeHNiM2RoYm1ObEtHWnliMjBzSUhOd1pXNWtaWElwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpZV3hzYzNWaUlGOWhiR3h2ZDJGdVkyVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTXlNREF2WVhKak1qQXdMbUZzWjI4dWRITTZNVFl4Q2lBZ0lDQXZMeUJoYzNObGNuUW9jM0JsYm1SbGNsOWhiR3h2ZDJGdVkyVXVibUYwYVhabElENDlJSFpoYkhWbExtNWhkR2wyWlN3Z0oybHVjM1ZtWm1samFXVnVkQ0JoY0hCeWIzWmhiQ2NwQ2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lqNDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNXpkV1ptYVdOcFpXNTBJR0Z3Y0hKdmRtRnNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpNakF3TDJGeVl6SXdNQzVoYkdkdkxuUnpPakUyTWdvZ0lDQWdMeThnWTI5dWMzUWdibVYzWDNOd1pXNWtaWEpmWVd4c2IzZGhibU5sSUQwZ2JtVjNJRlZwYm5ST01qVTJLSE53Wlc1a1pYSmZZV3hzYjNkaGJtTmxMbTVoZEdsMlpTQXRJSFpoYkhWbExtNWhkR2wyWlNrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZaTBLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHSjhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpNakF3TDJGeVl6SXdNQzVoYkdkdkxuUnpPakUyTXdvZ0lDQWdMeThnZEdocGN5NWZZWEJ3Y205MlpTaG1jbTl0TENCemNHVnVaR1Z5TENCdVpYZGZjM0JsYm1SbGNsOWhiR3h2ZDJGdVkyVXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHTmhiR3h6ZFdJZ1gyRndjSEp2ZG1VS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpJd01DOWhjbU15TURBdVlXeG5ieTUwY3pveE5qUUtJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbDkwY21GdWMyWmxjaWhtY205dExDQjBieXdnZG1Gc2RXVXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqWVd4c2MzVmlJRjkwY21GdWMyWmxjZ29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZekl3TUM5aGNtTXlNREF1WVd4bmJ5NTBjem82UVhKak1qQXdMbUZ5WXpJd01GOWhjSEJ5YjNabEtITndaVzVrWlhJNklHSjVkR1Z6TENCMllXeDFaVG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BoY21NeU1EQmZZWEJ3Y205MlpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTXlNREF2WVhKak1qQXdMbUZzWjI4dWRITTZNVGMwTFRFM05Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJQzh2SUhCMVlteHBZeUJoY21NeU1EQmZZWEJ3Y205MlpTaHpjR1Z1WkdWeU9pQkJaR1J5WlhOekxDQjJZV3gxWlRvZ1lYSmpOQzVWYVc1MFRqSTFOaWs2SUVKdmIyd2dld29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak1qQXdMMkZ5WXpJd01DNWhiR2R2TG5Sek9qRTNOZ29nSUNBZ0x5OGdZMjl1YzNRZ2IzZHVaWElnUFNCdVpYY2dRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6SXdNQzloY21NeU1EQXVZV3huYnk1MGN6b3hOemNLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TGw5aGNIQnliM1psS0c5M2JtVnlMQ0J6Y0dWdVpHVnlMQ0IyWVd4MVpTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqWVd4c2MzVmlJRjloY0hCeWIzWmxDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpNakF3TDJGeVl6SXdNQzVoYkdkdkxuUnpPanBCY21NeU1EQXVZWEpqTWpBd1gyRnNiRzkzWVc1alpTaHZkMjVsY2pvZ1lubDBaWE1zSUhOd1pXNWtaWEk2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LWVhKak1qQXdYMkZzYkc5M1lXNWpaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU15TURBdllYSmpNakF3TG1Gc1oyOHVkSE02TVRnMkxURTROd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUM4dklIQjFZbXhwWXlCaGNtTXlNREJmWVd4c2IzZGhibU5sS0c5M2JtVnlPaUJCWkdSeVpYTnpMQ0J6Y0dWdVpHVnlPaUJCWkdSeVpYTnpLVG9nWVhKak5DNVZhVzUwVGpJMU5pQjdDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NeU1EQXZZWEpqTWpBd0xtRnNaMjh1ZEhNNk1UZzRDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTVmWVd4c2IzZGhibU5sS0c5M2JtVnlMQ0J6Y0dWdVpHVnlLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOaGJHeHpkV0lnWDJGc2JHOTNZVzVqWlFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpJd01DOWhjbU15TURBdVlXeG5ieTUwY3pvNlFYSmpNakF3TGw5aVlXeGhibU5sVDJZb2IzZHVaWEk2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LWDJKaGJHRnVZMlZQWmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NeU1EQXZZWEpqTWpBd0xtRnNaMjh1ZEhNNk1Ua3hDaUFnSUNBdkx5QndjbWwyWVhSbElGOWlZV3hoYm1ObFQyWW9iM2R1WlhJNklFRmtaSEpsYzNNcE9pQlZhVzUwVGpJMU5pQjdDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NeU1EQXZZWEpqTWpBd0xtRnNaMjh1ZEhNNk5qSUtJQ0FnSUM4dklIQjFZbXhwWXlCaVlXeGhibU5sY3lBOUlFSnZlRTFoY0R4QlpHUnlaWE56TENCVmFXNTBUakkxTmo0b2V5QnJaWGxRY21WbWFYZzZJQ2RpSnlCOUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVlpSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTXlNREF2WVhKak1qQXdMbUZzWjI4dWRITTZNVGt5Q2lBZ0lDQXZMeUJwWmlBb0lYUm9hWE11WW1Gc1lXNWpaWE1vYjNkdVpYSXBMbVY0YVhOMGN5a2djbVYwZFhKdUlHNWxkeUJWYVc1MFRqSTFOaWd3S1FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWJub2dYMkpoYkdGdVkyVlBabDloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCemQyRndDaUFnSUNCeVpYUnpkV0lLQ2w5aVlXeGhibU5sVDJaZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpJd01DOWhjbU15TURBdVlXeG5ieTUwY3pveE9UTUtJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbUpoYkdGdVkyVnpLRzkzYm1WeUtTNTJZV3gxWlFvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNnZ2JYVnpkQ0JvWVhabElIWmhiSFZsQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTWpBd0wyRnlZekl3TUM1aGJHZHZMblJ6T2pwQmNtTXlNREF1WDNSeVlXNXpabVZ5S0hObGJtUmxjam9nWW5sMFpYTXNJSEpsWTJsd2FXVnVkRG9nWW5sMFpYTXNJR0Z0YjNWdWREb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncGZkSEpoYm5ObVpYSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpNakF3TDJGeVl6SXdNQzVoYkdkdkxuUnpPakU1TmdvZ0lDQWdMeThnY0hKcGRtRjBaU0JmZEhKaGJuTm1aWElvYzJWdVpHVnlPaUJCWkdSeVpYTnpMQ0J5WldOcGNHbGxiblE2SUVGa1pISmxjM01zSUdGdGIzVnVkRG9nVldsdWRFNHlOVFlwT2lCQ2IyOXNJSHNLSUNBZ0lIQnliM1J2SURNZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6SXdNQzloY21NeU1EQXVZV3huYnk1MGN6b3hPVGNLSUNBZ0lDOHZJR052Ym5OMElITmxibVJsY2w5aVlXeGhibU5sSUQwZ2RHaHBjeTVmWW1Gc1lXNWpaVTltS0hObGJtUmxjaWtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1kyRnNiSE4xWWlCZlltRnNZVzVqWlU5bUNpQWdJQ0JrZFhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NeU1EQXZZWEpqTWpBd0xtRnNaMjh1ZEhNNk1UazRDaUFnSUNBdkx5QmpiMjV6ZENCeVpXTnBjR2xsYm5SZlltRnNZVzVqWlNBOUlIUm9hWE11WDJKaGJHRnVZMlZQWmloeVpXTnBjR2xsYm5RcENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR05oYkd4emRXSWdYMkpoYkdGdVkyVlBaZ29nSUNBZ2MzZGhjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZekl3TUM5aGNtTXlNREF1WVd4bmJ5NTBjem94T1RrS0lDQWdJQzh2SUdGemMyVnlkQ2h6Wlc1a1pYSmZZbUZzWVc1alpTNXVZWFJwZG1VZ1BqMGdZVzF2ZFc1MExtNWhkR2wyWlN3Z0owbHVjM1ZtWm1samFXVnVkQ0JpWVd4aGJtTmxJR0YwSUhSb1pTQnpaVzVrWlhJZ1lXTmpiM1Z1ZENjcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0krUFFvZ0lDQWdZWE56WlhKMElDOHZJRWx1YzNWbVptbGphV1Z1ZENCaVlXeGhibU5sSUdGMElIUm9aU0J6Wlc1a1pYSWdZV05qYjNWdWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6SXdNQzloY21NeU1EQXVZV3huYnk1MGN6b3lNREVLSUNBZ0lDOHZJR2xtSUNoelpXNWtaWElnSVQwOUlISmxZMmx3YVdWdWRDa2dld29nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUNFOUNpQWdJQ0JpZWlCZmRISmhibk5tWlhKZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTWpBd0wyRnlZekl3TUM1aGJHZHZMblJ6T2pJd013b2dJQ0FnTHk4Z2RHaHBjeTVpWVd4aGJtTmxjeWh6Wlc1a1pYSXBMblpoYkhWbElEMGdibVYzSUZWcGJuUk9NalUyS0hObGJtUmxjbDlpWVd4aGJtTmxMbTVoZEdsMlpTQXRJR0Z0YjNWdWRDNXVZWFJwZG1VcENpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmlMUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JREVLSUNBZ0lHSjhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpNakF3TDJGeVl6SXdNQzVoYkdkdkxuUnpPall5Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZbUZzWVc1alpYTWdQU0JDYjNoTllYQThRV1JrY21WemN5d2dWV2x1ZEU0eU5UWStLSHNnYTJWNVVISmxabWw0T2lBbllpY2dmU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbUlpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpJd01DOWhjbU15TURBdVlXeG5ieTUwY3pveU1ETUtJQ0FnSUM4dklIUm9hWE11WW1Gc1lXNWpaWE1vYzJWdVpHVnlLUzUyWVd4MVpTQTlJRzVsZHlCVmFXNTBUakkxTmloelpXNWtaWEpmWW1Gc1lXNWpaUzV1WVhScGRtVWdMU0JoYlc5MWJuUXVibUYwYVhabEtRb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZekl3TUM5aGNtTXlNREF1WVd4bmJ5NTBjem95TURRS0lDQWdJQzh2SUhSb2FYTXVZbUZzWVc1alpYTW9jbVZqYVhCcFpXNTBLUzUyWVd4MVpTQTlJRzVsZHlCVmFXNTBUakkxTmloeVpXTnBjR2xsYm5SZlltRnNZVzVqWlM1dVlYUnBkbVVnS3lCaGJXOTFiblF1Ym1GMGFYWmxLUW9nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWWlzS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR0o4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTWpBd0wyRnlZekl3TUM1aGJHZHZMblJ6T2pZeUNpQWdJQ0F2THlCd2RXSnNhV01nWW1Gc1lXNWpaWE1nUFNCQ2IzaE5ZWEE4UVdSa2NtVnpjeXdnVldsdWRFNHlOVFkrS0hzZ2EyVjVVSEpsWm1sNE9pQW5ZaWNnZlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1JaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6SXdNQzloY21NeU1EQXVZV3huYnk1MGN6b3lNRFFLSUNBZ0lDOHZJSFJvYVhNdVltRnNZVzVqWlhNb2NtVmphWEJwWlc1MEtTNTJZV3gxWlNBOUlHNWxkeUJWYVc1MFRqSTFOaWh5WldOcGNHbGxiblJmWW1Gc1lXNWpaUzV1WVhScGRtVWdLeUJoYlc5MWJuUXVibUYwYVhabEtRb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9LWDNSeVlXNXpabVZ5WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU15TURBdllYSmpNakF3TG1Gc1oyOHVkSE02TWpBMkNpQWdJQ0F2THlCbGJXbDBLRzVsZHlCaGNtTXlNREJmVkhKaGJuTm1aWElvZXlCbWNtOXRPaUJ6Wlc1a1pYSXNJSFJ2T2lCeVpXTnBjR2xsYm5Rc0lIWmhiSFZsT2lCaGJXOTFiblFnZlNrcENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTWdOQ0F2THlCdFpYUm9iMlFnSW1GeVl6SXdNRjlVY21GdWMyWmxjaWhoWkdSeVpYTnpMR0ZrWkhKbGMzTXNkV2x1ZERJMU5pa2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZekl3TUM5aGNtTXlNREF1WVd4bmJ5NTBjem95TURjS0lDQWdJQzh2SUhKbGRIVnliaUJ1WlhjZ1FtOXZiQ2gwY25WbEtRb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEZ3dDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTXlNREF2WVhKak1qQXdMbUZzWjI4dWRITTZPa0Z5WXpJd01DNWZZWEJ3Y205MllXeExaWGtvYjNkdVpYSTZJR0o1ZEdWekxDQnpjR1Z1WkdWeU9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNsOWhjSEJ5YjNaaGJFdGxlVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU15TURBdllYSmpNakF3TG1Gc1oyOHVkSE02TWpBNUNpQWdJQ0F2THlCd2NtbDJZWFJsSUY5aGNIQnliM1poYkV0bGVTaHZkMjVsY2pvZ1FXUmtjbVZ6Y3l3Z2MzQmxibVJsY2pvZ1FXUmtjbVZ6Y3lrNklGTjBZWFJwWTBKNWRHVnpQRE15UGlCN0NpQWdJQ0J3Y205MGJ5QXlJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU15TURBdllYSmpNakF3TG1Gc1oyOHVkSE02TWpFd0NpQWdJQ0F2THlCeVpYUjFjbTRnYm1WM0lGTjBZWFJwWTBKNWRHVnpQRE15UGlodmNDNXphR0V5TlRZb2IzQXVZMjl1WTJGMEtHOTNibVZ5TG1KNWRHVnpMQ0J6Y0dWdVpHVnlMbUo1ZEdWektTa3BDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemFHRXlOVFlLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J6YVhwbENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak1qQXdMMkZ5WXpJd01DNWhiR2R2TG5Sek9qcEJjbU15TURBdVgyRnNiRzkzWVc1alpTaHZkMjVsY2pvZ1lubDBaWE1zSUhOd1pXNWtaWEk2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LWDJGc2JHOTNZVzVqWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NeU1EQXZZWEpqTWpBd0xtRnNaMjh1ZEhNNk1qRXpDaUFnSUNBdkx5QndjbWwyWVhSbElGOWhiR3h2ZDJGdVkyVW9iM2R1WlhJNklFRmtaSEpsYzNNc0lITndaVzVrWlhJNklFRmtaSEpsYzNNcE9pQlZhVzUwVGpJMU5pQjdDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NeU1EQXZZWEpqTWpBd0xtRnNaMjh1ZEhNNk1qRTBDaUFnSUNBdkx5QmpiMjV6ZENCclpYa2dQU0IwYUdsekxsOWhjSEJ5YjNaaGJFdGxlU2h2ZDI1bGNpd2djM0JsYm1SbGNpa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqWVd4c2MzVmlJRjloY0hCeWIzWmhiRXRsZVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpJd01DOWhjbU15TURBdVlXeG5ieTUwY3pvMk5Bb2dJQ0FnTHk4Z2NIVmliR2xqSUdGd2NISnZkbUZzY3lBOUlFSnZlRTFoY0R4VGRHRjBhV05DZVhSbGN6d3pNajRzSUVGd2NISnZkbUZzVTNSeWRXTjBQaWg3SUd0bGVWQnlaV1pwZURvZ0oyRW5JSDBwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbUVpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpJd01DOWhjbU15TURBdVlXeG5ieTUwY3pveU1UVUtJQ0FnSUM4dklHbG1JQ2doZEdocGN5NWhjSEJ5YjNaaGJITW9hMlY1S1M1bGVHbHpkSE1wSUhKbGRIVnliaUJ1WlhjZ1ZXbHVkRTR5TlRZb01Da0tJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbTU2SUY5aGJHeHZkMkZ1WTJWZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQmllWFJsWXlBMUlDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdjM2RoY0FvZ0lDQWdjbVYwYzNWaUNncGZZV3hzYjNkaGJtTmxYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTXlNREF2WVhKak1qQXdMbUZzWjI4dWRITTZNakUyQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1aGNIQnliM1poYkhNb2EyVjVLUzUyWVd4MVpTNWhjSEJ5YjNaaGJFRnRiM1Z1ZEFvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNnZ2JYVnpkQ0JvWVhabElIWmhiSFZsQ2lBZ0lDQmxlSFJ5WVdOMElEQWdNeklnTHk4Z2IyNGdaWEp5YjNJNklFbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCemQyRndDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpNakF3TDJGeVl6SXdNQzVoYkdkdkxuUnpPanBCY21NeU1EQXVYMkZ3Y0hKdmRtVW9iM2R1WlhJNklHSjVkR1Z6TENCemNHVnVaR1Z5T2lCaWVYUmxjeXdnWVcxdmRXNTBPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbDloY0hCeWIzWmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZekl3TUM5aGNtTXlNREF1WVd4bmJ5NTBjem95TVRrS0lDQWdJQzh2SUhCeWFYWmhkR1VnWDJGd2NISnZkbVVvYjNkdVpYSTZJRUZrWkhKbGMzTXNJSE53Wlc1a1pYSTZJRUZrWkhKbGMzTXNJR0Z0YjNWdWREb2dWV2x1ZEU0eU5UWXBPaUJDYjI5c0lIc0tJQ0FnSUhCeWIzUnZJRE1nTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpJd01DOWhjbU15TURBdVlXeG5ieTUwY3pveU1qQUtJQ0FnSUM4dklHTnZibk4wSUd0bGVTQTlJSFJvYVhNdVgyRndjSEp2ZG1Gc1MyVjVLRzkzYm1WeUxDQnpjR1Z1WkdWeUtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR05oYkd4emRXSWdYMkZ3Y0hKdmRtRnNTMlY1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTWpBd0wyRnlZekl3TUM1aGJHZHZMblJ6T2pJeU1TMHlNalVLSUNBZ0lDOHZJR052Ym5OMElHRndjSEp2ZG1Gc1FtOTRPaUJCY0hCeWIzWmhiRk4wY25WamRDQTlJRzVsZHlCQmNIQnliM1poYkZOMGNuVmpkQ2g3Q2lBZ0lDQXZMeUFnSUdGd2NISnZkbUZzUVcxdmRXNTBPaUJoYlc5MWJuUXNDaUFnSUNBdkx5QWdJRzkzYm1WeU9pQnZkMjVsY2l3S0lDQWdJQzh2SUNBZ2MzQmxibVJsY2pvZ2MzQmxibVJsY2l3S0lDQWdJQzh2SUgwcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6SXdNQzloY21NeU1EQXVZV3huYnk1MGN6bzJOQW9nSUNBZ0x5OGdjSFZpYkdsaklHRndjSEp2ZG1Gc2N5QTlJRUp2ZUUxaGNEeFRkR0YwYVdOQ2VYUmxjend6TWo0c0lFRndjSEp2ZG1Gc1UzUnlkV04wUGloN0lHdGxlVkJ5WldacGVEb2dKMkVuSUgwcENpQWdJQ0J3ZFhOb1lubDBaWE1nSW1FaUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpJd01DOWhjbU15TURBdVlXeG5ieTUwY3pveU1qWUtJQ0FnSUM4dklIUm9hWE11WVhCd2NtOTJZV3h6S0d0bGVTa3VkbUZzZFdVZ1BTQmhjSEJ5YjNaaGJFSnZlQzVqYjNCNUtDa0tJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU15TURBdllYSmpNakF3TG1Gc1oyOHVkSE02TWpJM0NpQWdJQ0F2THlCbGJXbDBLRzVsZHlCaGNtTXlNREJmUVhCd2NtOTJZV3dvZXlCdmQyNWxjam9nYjNkdVpYSXNJSE53Wlc1a1pYSTZJSE53Wlc1a1pYSXNJSFpoYkhWbE9pQmhiVzkxYm5RZ2ZTa3BDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVGsyT1dZNE5qVWdMeThnYldWMGFHOWtJQ0poY21NeU1EQmZRWEJ3Y205MllXd29ZV1JrY21WemN5eGhaR1J5WlhOekxIVnBiblF5TlRZcElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTXlNREF2WVhKak1qQXdMbUZzWjI4dWRITTZNakk0Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdibVYzSUVKdmIyd29kSEoxWlNrS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnNE1Bb2dJQ0FnY21WMGMzVmlDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFFQVNBQUNDWUdCQlVmZkhVQllnRjBBWUFFZVlQRFhDQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQURFYlFRRVpnZ29FbDFPQzRnUmxmUlBzQkxhdUdpVUVoT3dUMVFUc21XQkJCSUxsYzhRRTJuQWx1UVJLbG8rUEJMVkNJU1VFdTdNWjh6WWFBSTRLQUxBQW9BQ1FBSUFBY0FCZEFFY0FMZ0FZQUFJa1F6RVpGRVF4R0VRMkdnRTJHZ0tJQVpNb1RGQ3dJa014R1JSRU1SaEVOaG9CTmhvQ2lBRndLRXhRc0NKRE1Sa1VSREVZUkRZYUFUWWFBallhQTRnQktTaE1VTEFpUXpFWkZFUXhHRVEyR2dFMkdnS0lBUVlvVEZDd0lrTXhHUlJFTVJoRU5ob0JpQURxS0V4UXNDSkRNUmtVUkRFWVJJZ0ExU2hNVUxBaVF6RVpGRVF4R0VTSUFMNG9URkN3SWtNeEdSUkVNUmhFaUFDZktFeFFzQ0pETVJrVVJERVlSSWdBZ0NoTVVMQWlRekVaRkVReEdFUTJHZ0UyR2dJMkdnTTJHZ1NJQUJFb1RGQ3dJa014R1VEL0x6RVlGRVFpUTRvRUFURUFNZ2tTUkl2OFZ3SUFGVWxFSXc1RWkvMVhBZ0FWU1VRbERrUWtLbVZGQVJSRWdBRnVpL3huZ0FGemkvMW5Lb3YvWjRBQlpJditaekVBS1VzQlVJdi92eklEVEZDTC8xQW5CRXhRc0N1SkpJQUJibVZFVndJQVNSVWpFa1NKSklBQmMyVkVWd0lBU1JVbEVrU0pKSUFCWkdWRWlTUXFaVVNKaWdFQmkvK0lBRlNKaWdJQk1RQ0wvb3YvaUFCZmlZb0RBVEVBaS8xTEFZZ0F0RW1MLzZkRWkvK2hTUlVqRGtRanI2dUwvVTRDaUFEQVNJdjlpLzZMLzRnQU1ZbUtBZ0V4QUl2K2kvK0lBS21KaWdJQmkvNkwvNGdBZTRtS0FRRXBpLzlRU2IxRkFVQUFCQ2NGVEltTEFMNUVUSW1LQXdHTC9Zai80RW1ML29qLzJreUwvNmRFaS8yTC9oTkJBQ2VMQUl2L29Va1ZJdzVFSTY5TVN3R3JLWXY5VUV5L2l3R0wvNkJKRlNNT1JLc3BpLzVRVEwrTC9ZditVSXYvVUNjRVRGQ3dLNHdBaVlvQ0FZditpLzlRQVVrVkl4SkVpWW9DQVl2K2kvK0kvK2VBQVdGTVVFbTlSUUZBQUFRbkJVeUppd0MrUkZjQUlFeUppZ01CaS8yTC9vai94SXYvaS8xUWkvNVFnQUZoVHdKUVRMK0wvWXYrVUl2L1VJQUVHV240WlV4UXNDdUoiLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo3LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOlt7Im5hbWUiOiJhcmMyMDBfVHJhbnNmZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6ImFyYzIwMF9BcHByb3ZhbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3BlbmRlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGx9XX1dLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
