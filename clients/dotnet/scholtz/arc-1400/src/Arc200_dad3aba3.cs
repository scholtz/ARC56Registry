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

namespace Arc56.Generated.scholtz.arc_1400.Arc200_dad3aba3
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

            public class Arc88OwnershipTransferredEvent
            {
                public static readonly byte[] Selector = new byte[4] { 67, 85, 210, 173 };
                public const string Signature = "arc88_OwnershipTransferred(address,address)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address PreviousOwner { get; set; }
                public Algorand.Address NewOwner { get; set; }

                public static Arc88OwnershipTransferredEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new Arc88OwnershipTransferredEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPreviousOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vPreviousOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePreviousOwner = vPreviousOwner.ToValue();
                    if (valuePreviousOwner is Algorand.Address vPreviousOwnerValue) { ret.PreviousOwner = vPreviousOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNewOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vNewOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNewOwner = vNewOwner.ToValue();
                    if (valueNewOwner is Algorand.Address vNewOwnerValue) { ret.NewOwner = vNewOwnerValue; }
                    return ret;

                }

            }

            public class Arc88OwnershipRenouncedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 52, 106, 161, 102 };
                public const string Signature = "arc88_OwnershipRenounced(address)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address PreviousOwner { get; set; }

                public static Arc88OwnershipRenouncedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new Arc88OwnershipRenouncedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPreviousOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vPreviousOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePreviousOwner = vPreviousOwner.ToValue();
                    if (valuePreviousOwner is Algorand.Address vPreviousOwnerValue) { ret.PreviousOwner = vPreviousOwnerValue; }
                    return ret;

                }

            }

            public class Arc88OwnershipTransferRequestedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 22, 191, 31, 145 };
                public const string Signature = "arc88_OwnershipTransferRequested(address,address)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address PreviousOwner { get; set; }
                public Algorand.Address PendingOwner { get; set; }

                public static Arc88OwnershipTransferRequestedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new Arc88OwnershipTransferRequestedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPreviousOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vPreviousOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePreviousOwner = vPreviousOwner.ToValue();
                    if (valuePreviousOwner is Algorand.Address vPreviousOwnerValue) { ret.PreviousOwner = vPreviousOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPendingOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vPendingOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePendingOwner = vPendingOwner.ToValue();
                    if (valuePendingOwner is Algorand.Address vPendingOwnerValue) { ret.PendingOwner = vPendingOwnerValue; }
                    return ret;

                }

            }

            public class Arc88OwnershipTransferAcceptedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 247, 227, 107, 55 };
                public const string Signature = "arc88_OwnershipTransferAccepted(address,address)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address PreviousOwner { get; set; }
                public Algorand.Address NewOwner { get; set; }

                public static Arc88OwnershipTransferAcceptedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new Arc88OwnershipTransferAcceptedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPreviousOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vPreviousOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePreviousOwner = vPreviousOwner.ToValue();
                    if (valuePreviousOwner is Algorand.Address vPreviousOwnerValue) { ret.PreviousOwner = vPreviousOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNewOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vNewOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNewOwner = vNewOwner.ToValue();
                    if (valueNewOwner is Algorand.Address vNewOwnerValue) { ret.NewOwner = vNewOwnerValue; }
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
        ///
        ///</summary>
        public async Task<Algorand.Address> Arc88Owner(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 7, 2, 101, 78 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> Arc88Owner_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 7, 2, 101, 78 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="query"> </param>
        public async Task<bool> Arc88IsOwner(Algorand.Address query, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 208, 21, 114, 78 };
            var queryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); queryAbi.From(query);

            var result = await base.SimApp(new List<object> { abiHandle, queryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Arc88IsOwner_Transactions(Algorand.Address query, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 208, 21, 114, 78 };
            var queryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); queryAbi.From(query);

            return await base.MakeTransactionList(new List<object> { abiHandle, queryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Explicit initialization override (creation group recommended). Fails if already initialized.
        ///</summary>
        /// <param name="new_owner"> </param>
        public async Task Arc88InitializeOwner(Algorand.Address new_owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 159, 236, 192 };
            var new_ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_ownerAbi.From(new_owner);

            var result = await base.CallApp(new List<object> { abiHandle, new_ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc88InitializeOwner_Transactions(Algorand.Address new_owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 159, 236, 192 };
            var new_ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_ownerAbi.From(new_owner);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="new_owner"> </param>
        public async Task Arc88TransferOwnership(Algorand.Address new_owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 115, 73, 51, 78 };
            var new_ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_ownerAbi.From(new_owner);

            var result = await base.CallApp(new List<object> { abiHandle, new_ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc88TransferOwnership_Transactions(Algorand.Address new_owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 115, 73, 51, 78 };
            var new_ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_ownerAbi.From(new_owner);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Arc88RenounceOwnership(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 219, 124, 130, 239 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc88RenounceOwnership_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 219, 124, 130, 239 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="pending"> </param>
        public async Task Arc88TransferOwnershipRequest(Algorand.Address pending, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 253, 44, 44, 110 };
            var pendingAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); pendingAbi.From(pending);

            var result = await base.CallApp(new List<object> { abiHandle, pendingAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc88TransferOwnershipRequest_Transactions(Algorand.Address pending, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 253, 44, 44, 110 };
            var pendingAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); pendingAbi.From(pending);

            return await base.MakeTransactionList(new List<object> { abiHandle, pendingAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Arc88AcceptOwnership(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 66, 165, 240, 101 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc88AcceptOwnership_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 66, 165, 240, 101 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Arc88CancelOwnershipRequest(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 173, 79, 104, 234 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc88CancelOwnershipRequest_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 173, 79, 104, 234 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXJjMjAwIiwiZGVzYyI6IlNtYXJ0IENvbnRyYWN0IFRva2VuIEJhc2UgSW50ZXJmYWNlIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkFwcHJvdmFsU3RydWN0IjpbeyJuYW1lIjoiYXBwcm92YWxBbW91bnQiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6Im93bmVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJzcGVuZGVyIiwidHlwZSI6ImFkZHJlc3MifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiYm9vdHN0cmFwIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN5bWJvbCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDgiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZWNpbWFscyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsU3VwcGx5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJhcmMyMDBfVHJhbnNmZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmMyMDBfbmFtZSIsImRlc2MiOiJSZXR1cm5zIHRoZSBuYW1lIG9mIHRoZSB0b2tlbiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSBuYW1lIG9mIHRoZSB0b2tlbiJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjMjAwX3N5bWJvbCIsImRlc2MiOiJSZXR1cm5zIHRoZSBzeW1ib2wgb2YgdGhlIHRva2VuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbOF0iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJUaGUgc3ltYm9sIG9mIHRoZSB0b2tlbiJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjMjAwX2RlY2ltYWxzIiwiZGVzYyI6IlJldHVybnMgdGhlIGRlY2ltYWxzIG9mIHRoZSB0b2tlbiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50OCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSBkZWNpbWFscyBvZiB0aGUgdG9rZW4ifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzIwMF90b3RhbFN1cHBseSIsImRlc2MiOiJSZXR1cm5zIHRoZSB0b3RhbCBzdXBwbHkgb2YgdGhlIHRva2VuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJUaGUgdG90YWwgc3VwcGx5IG9mIHRoZSB0b2tlbiJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjMjAwX2JhbGFuY2VPZiIsImRlc2MiOiJSZXR1cm5zIHRoZSBjdXJyZW50IGJhbGFuY2Ugb2YgdGhlIG93bmVyIG9mIHRoZSB0b2tlbiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjoiVGhlIGFkZHJlc3Mgb2YgdGhlIG93bmVyIG9mIHRoZSB0b2tlbiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjoiVGhlIGN1cnJlbnQgYmFsYW5jZSBvZiB0aGUgaG9sZGVyIG9mIHRoZSB0b2tlbiJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjMjAwX3RyYW5zZmVyIiwiZGVzYyI6IlRyYW5zZmVycyB0b2tlbnMiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6IlRoZSBkZXN0aW5hdGlvbiBvZiB0aGUgdHJhbnNmZXIiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOiJBbW91bnQgb2YgdG9rZW5zIHRvIHRyYW5zZmVyIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJTdWNjZXNzIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6ImFyYzIwMF9UcmFuc2ZlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZnJvbSIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzIwMF90cmFuc2ZlckZyb20iLCJkZXNjIjoiVHJhbnNmZXJzIHRva2VucyBmcm9tIHNvdXJjZSB0byBkZXN0aW5hdGlvbiBhcyBhcHByb3ZlZCBzcGVuZGVyIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmcm9tIiwiZGVzYyI6IlRoZSBzb3VyY2Ugb2YgdGhlIHRyYW5zZmVyIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjoiVGhlIGRlc3RpbmF0aW9uIG9mIHRoZSB0cmFuc2ZlciIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6IkFtb3VudCBvZiB0b2tlbnMgdG8gdHJhbnNmZXIiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlN1Y2Nlc3MifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiYXJjMjAwX0FwcHJvdmFsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcGVuZGVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJhcmMyMDBfVHJhbnNmZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmMyMDBfYXBwcm92ZSIsImRlc2MiOiJBcHByb3ZlIHNwZW5kZXIgZm9yIGEgdG9rZW4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwZW5kZXIiLCJkZXNjIjoiV2hvIGlzIGFsbG93ZWQgdG8gdGFrZSB0b2tlbnMgb24gb3duZXIncyBiZWhhbGYiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOiJBbW91bnQgb2YgdG9rZW5zIHRvIGJlIHRha2VuIGJ5IHNwZW5kZXIiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlN1Y2Nlc3MifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiYXJjMjAwX0FwcHJvdmFsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcGVuZGVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjMjAwX2FsbG93YW5jZSIsImRlc2MiOiJSZXR1cm5zIHRoZSBjdXJyZW50IGFsbG93YW5jZSBvZiB0aGUgc3BlbmRlciBvZiB0aGUgdG9rZW5zIG9mIHRoZSBvd25lciIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjoiT3duZXIncyBhY2NvdW50IiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3BlbmRlciIsImRlc2MiOiJXaG8gaXMgYWxsb3dlZCB0byB0YWtlIHRva2VucyBvbiBvd25lcidzIGJlaGFsZiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjoiVGhlIHJlbWFpbmluZyBhbGxvd2FuY2UifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzg4X293bmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjODhfaXNfb3duZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InF1ZXJ5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjODhfaW5pdGlhbGl6ZV9vd25lciIsImRlc2MiOiJFeHBsaWNpdCBpbml0aWFsaXphdGlvbiBvdmVycmlkZSAoY3JlYXRpb24gZ3JvdXAgcmVjb21tZW5kZWQpLiBGYWlscyBpZiBhbHJlYWR5IGluaXRpYWxpemVkLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X293bmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzg4X3RyYW5zZmVyX293bmVyc2hpcCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X293bmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJhcmM4OF9Pd25lcnNoaXBUcmFuc2ZlcnJlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJldmlvdXNfb3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X293bmVyIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjODhfcmVub3VuY2Vfb3duZXJzaGlwIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJhcmM4OF9Pd25lcnNoaXBSZW5vdW5jZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByZXZpb3VzX293bmVyIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjODhfdHJhbnNmZXJfb3duZXJzaGlwX3JlcXVlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBlbmRpbmciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6ImFyYzg4X093bmVyc2hpcFRyYW5zZmVyUmVxdWVzdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmV2aW91c19vd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwZW5kaW5nX293bmVyIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjODhfYWNjZXB0X293bmVyc2hpcCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiYXJjODhfT3duZXJzaGlwVHJhbnNmZXJBY2NlcHRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJldmlvdXNfb3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X293bmVyIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJhcmM4OF9Pd25lcnNoaXBUcmFuc2ZlcnJlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJldmlvdXNfb3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X293bmVyIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjODhfY2FuY2VsX293bmVyc2hpcF9yZXF1ZXN0IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6N30sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbODAzLDkzNV0sImVycm9yTWVzc2FnZSI6IkJveCBtdXN0IGhhdmUgdmFsdWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5MzZdLCJlcnJvck1lc3NhZ2UiOiJJbmRleCBhY2Nlc3MgaXMgb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgyNF0sImVycm9yTWVzc2FnZSI6Ikluc3VmZmljaWVudCBiYWxhbmNlIGF0IHRoZSBzZW5kZXIgYWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU3Nl0sImVycm9yTWVzc2FnZSI6Ik5hbWUgb2YgdGhlIGFzc2V0IG11c3QgYmUgbG9uZ2VyIG9yIGVxdWFsIHRvIDEgY2hhcmFjdGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTc5XSwiZXJyb3JNZXNzYWdlIjoiTmFtZSBvZiB0aGUgYXNzZXQgbXVzdCBiZSBzaG9ydGVyIG9yIGVxdWFsIHRvIDMyIGNoYXJhY3RlcnMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzQsMjQ2LDI1OCwyNzMsMjg1LDMwMCwzMTUsMzM0LDM1MCwzNzIsMzk0LDQxOSw0NDEsNDYwLDQ3Niw0OTIsNTA4LDUyNF0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU2OF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgZGVwbG95ZXIgb2YgdGhpcyBzbWFydCBjb250cmFjdCBjYW4gY2FsbCBib290c3RyYXAgbWV0aG9kIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTg3XSwiZXJyb3JNZXNzYWdlIjoiU3ltYm9sIG9mIHRoZSBhc3NldCBtdXN0IGJlIGxvbmdlciBvciBlcXVhbCB0byAxIGNoYXJhY3RlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU5MF0sImVycm9yTWVzc2FnZSI6IlN5bWJvbCBvZiB0aGUgYXNzZXQgbXVzdCBiZSBzaG9ydGVyIG9yIGVxdWFsIHRvIDggY2hhcmFjdGVycyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU5OF0sImVycm9yTWVzc2FnZSI6IlRoaXMgbWV0aG9kIGNhbiBiZSBjYWxsZWQgb25seSBvbmNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTEwMF0sImVycm9yTWVzc2FnZSI6ImFscmVhZHlfaW5pdGlhbGl6ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NTddLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzcsMjQ5LDI2MSwyNzYsMjg4LDMwMywzMTgsMzM3LDM1MywzNzUsMzk3LDQyMiw0NDQsNDYzLDQ3OSw0OTUsNTExLDUyN10sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NTIsNjY3LDY4Miw2ODgsMTAwMCwxMDMwLDEwNTIsMTA2NCwxMDkxLDExMzIsMTE0MywxMTY1LDExNzEsMTE5NiwxMjE1LDEyMjcsMTI1NSwxMjYzLDEyOTddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MjhdLCJlcnJvck1lc3NhZ2UiOiJpbnN1ZmZpY2llbnQgYXBwcm92YWwiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NjAsNjc1LDkwNV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgc2l6ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExMzQsMTE2NywxMTk4LDEyOTldLCJlcnJvck1lc3NhZ2UiOiJub3Rfb3duZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjQ5LDEyNTldLCJlcnJvck1lc3NhZ2UiOiJub3RfcGVuZGluZ19vd25lciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzczNiw4NDIsODY1XSwiZXJyb3JNZXNzYWdlIjoib3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjE5XSwiZXJyb3JNZXNzYWdlIjoicGVuZGluZ190cmFuc2Zlcl9leGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTA1LDExMzksMTIwM10sImVycm9yTWVzc2FnZSI6Inplcm9fYWRkcmVzc19ub3RfYWxsb3dlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElETXlJRGdLSUNBZ0lHSjVkR1ZqWW14dlkyc2dJbUZ5WXpnNFgyOGlJREI0TVRVeFpqZGpOelVnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0lDSmhjbU00T0Y5d2J5SWdJbUZ5WXpnNFgyOXBJaUFpWWlJZ0luUWlJREI0T0RBZ01IZ3dNQ0F3ZURjNU9ETmpNelZqSURCNE5ETTFOV1F5WVdRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pvek5Rb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUZ5WXpJd01DQmxlSFJsYm1SeklFRnlZemc0SUhzS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMkpoY21WZmNtOTFkR2x1WjBBeU5Rb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VEazNOVE00TW1VeUlEQjROalUzWkRFelpXTWdNSGhpTm1GbE1XRXlOU0F3ZURnMFpXTXhNMlExSURCNFpXTTVPVFl3TkRFZ01IZzRNbVUxTnpOak5DQXdlR1JoTnpBeU5XSTVJREI0TkdFNU5qaG1PR1lnTUhoaU5UUXlNakV5TlNBd2VHSmlZak14T1dZeklEQjRNRGN3TWpZMU5HVWdNSGhrTURFMU56STBaU0F3ZURBeU9XWmxZMk13SURCNE56TTBPVE16TkdVZ01IaGtZamRqT0RKbFppQXdlR1prTW1NeVl6WmxJREI0TkRKaE5XWXdOalVnTUhoaFpEUm1OamhsWVNBdkx5QnRaWFJvYjJRZ0ltSnZiM1J6ZEhKaGNDaGllWFJsVzEwc1lubDBaVnRkTEhWcGJuUTRMSFZwYm5ReU5UWXBZbTl2YkNJc0lHMWxkR2h2WkNBaVlYSmpNakF3WDI1aGJXVW9LV0o1ZEdWYk16SmRJaXdnYldWMGFHOWtJQ0poY21NeU1EQmZjM2x0WW05c0tDbGllWFJsV3poZElpd2diV1YwYUc5a0lDSmhjbU15TURCZlpHVmphVzFoYkhNb0tYVnBiblE0SWl3Z2JXVjBhRzlrSUNKaGNtTXlNREJmZEc5MFlXeFRkWEJ3Ykhrb0tYVnBiblF5TlRZaUxDQnRaWFJvYjJRZ0ltRnlZekl3TUY5aVlXeGhibU5sVDJZb1lXUmtjbVZ6Y3lsMWFXNTBNalUySWl3Z2JXVjBhRzlrSUNKaGNtTXlNREJmZEhKaGJuTm1aWElvWVdSa2NtVnpjeXgxYVc1ME1qVTJLV0p2YjJ3aUxDQnRaWFJvYjJRZ0ltRnlZekl3TUY5MGNtRnVjMlpsY2taeWIyMG9ZV1JrY21WemN5eGhaR1J5WlhOekxIVnBiblF5TlRZcFltOXZiQ0lzSUcxbGRHaHZaQ0FpWVhKak1qQXdYMkZ3Y0hKdmRtVW9ZV1JrY21WemN5eDFhVzUwTWpVMktXSnZiMndpTENCdFpYUm9iMlFnSW1GeVl6SXdNRjloYkd4dmQyRnVZMlVvWVdSa2NtVnpjeXhoWkdSeVpYTnpLWFZwYm5ReU5UWWlMQ0J0WlhSb2IyUWdJbUZ5WXpnNFgyOTNibVZ5S0NsaFpHUnlaWE56SWl3Z2JXVjBhRzlrSUNKaGNtTTRPRjlwYzE5dmQyNWxjaWhoWkdSeVpYTnpLV0p2YjJ3aUxDQnRaWFJvYjJRZ0ltRnlZemc0WDJsdWFYUnBZV3hwZW1WZmIzZHVaWElvWVdSa2NtVnpjeWwyYjJsa0lpd2diV1YwYUc5a0lDSmhjbU00T0Y5MGNtRnVjMlpsY2w5dmQyNWxjbk5vYVhBb1lXUmtjbVZ6Y3lsMmIybGtJaXdnYldWMGFHOWtJQ0poY21NNE9GOXlaVzV2ZFc1alpWOXZkMjVsY25Ob2FYQW9LWFp2YVdRaUxDQnRaWFJvYjJRZ0ltRnlZemc0WDNSeVlXNXpabVZ5WDI5M2JtVnljMmhwY0Y5eVpYRjFaWE4wS0dGa1pISmxjM01wZG05cFpDSXNJRzFsZEdodlpDQWlZWEpqT0RoZllXTmpaWEIwWDI5M2JtVnljMmhwY0NncGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWVhKak9EaGZZMkZ1WTJWc1gyOTNibVZ5YzJocGNGOXlaWEYxWlhOMEtDbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JXRnBibDlpYjI5MGMzUnlZWEJmY205MWRHVkFOU0J0WVdsdVgyRnlZekl3TUY5dVlXMWxYM0p2ZFhSbFFEWWdiV0ZwYmw5aGNtTXlNREJmYzNsdFltOXNYM0p2ZFhSbFFEY2diV0ZwYmw5aGNtTXlNREJmWkdWamFXMWhiSE5mY205MWRHVkFPQ0J0WVdsdVgyRnlZekl3TUY5MGIzUmhiRk4xY0hCc2VWOXliM1YwWlVBNUlHMWhhVzVmWVhKak1qQXdYMkpoYkdGdVkyVlBabDl5YjNWMFpVQXhNQ0J0WVdsdVgyRnlZekl3TUY5MGNtRnVjMlpsY2w5eWIzVjBaVUF4TVNCdFlXbHVYMkZ5WXpJd01GOTBjbUZ1YzJabGNrWnliMjFmY205MWRHVkFNVElnYldGcGJsOWhjbU15TURCZllYQndjbTkyWlY5eWIzVjBaVUF4TXlCdFlXbHVYMkZ5WXpJd01GOWhiR3h2ZDJGdVkyVmZjbTkxZEdWQU1UUWdiV0ZwYmw5aGNtTTRPRjl2ZDI1bGNsOXliM1YwWlVBeE5TQnRZV2x1WDJGeVl6ZzRYMmx6WDI5M2JtVnlYM0p2ZFhSbFFERTJJRzFoYVc1ZllYSmpPRGhmYVc1cGRHbGhiR2w2WlY5dmQyNWxjbDl5YjNWMFpVQXhOeUJ0WVdsdVgyRnlZemc0WDNSeVlXNXpabVZ5WDI5M2JtVnljMmhwY0Y5eWIzVjBaVUF4T0NCdFlXbHVYMkZ5WXpnNFgzSmxibTkxYm1ObFgyOTNibVZ5YzJocGNGOXliM1YwWlVBeE9TQnRZV2x1WDJGeVl6ZzRYM1J5WVc1elptVnlYMjkzYm1WeWMyaHBjRjl5WlhGMVpYTjBYM0p2ZFhSbFFESXdJRzFoYVc1ZllYSmpPRGhmWVdOalpYQjBYMjkzYm1WeWMyaHBjRjl5YjNWMFpVQXlNU0J0WVdsdVgyRnlZemc0WDJOaGJtTmxiRjl2ZDI1bGNuTm9hWEJmY21WeGRXVnpkRjl5YjNWMFpVQXlNZ29LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpJd01DNWhiR2R2TG5Sek9qTTFDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUVhKak1qQXdJR1Y0ZEdWdVpITWdRWEpqT0RnZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aGNtTTRPRjlqWVc1alpXeGZiM2R1WlhKemFHbHdYM0psY1hWbGMzUmZjbTkxZEdWQU1qSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6b3hNRE1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnWVhKak9EaGZZMkZ1WTJWc1gyOTNibVZ5YzJocGNGOXlaWEYxWlhOMENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJGeVl6ZzRYMkZqWTJWd2RGOXZkMjVsY25Ob2FYQmZjbTkxZEdWQU1qRTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6bzVNQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnWTJGc2JITjFZaUJoY21NNE9GOWhZMk5sY0hSZmIzZHVaWEp6YUdsd0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJGeVl6ZzRYM1J5WVc1elptVnlYMjkzYm1WeWMyaHBjRjl5WlhGMVpYTjBYM0p2ZFhSbFFESXdPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZOemdLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6b3pOUW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVGeVl6SXdNQ0JsZUhSbGJtUnpJRUZ5WXpnNElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qYzRDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnWTJGc2JITjFZaUJoY21NNE9GOTBjbUZ1YzJabGNsOXZkMjVsY25Ob2FYQmZjbVZ4ZFdWemRBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aGNtTTRPRjl5Wlc1dmRXNWpaVjl2ZDI1bGNuTm9hWEJmY205MWRHVkFNVGs2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpPRGd1WVd4bmJ5NTBjem8yT0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCaGNtTTRPRjl5Wlc1dmRXNWpaVjl2ZDI1bGNuTm9hWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZWEpqT0RoZmRISmhibk5tWlhKZmIzZHVaWEp6YUdsd1gzSnZkWFJsUURFNE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk5UZ0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pvek5Rb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUZ5WXpJd01DQmxlSFJsYm1SeklFRnlZemc0SUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU00T0M1aGJHZHZMblJ6T2pVNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZMkZzYkhOMVlpQmhjbU00T0Y5MGNtRnVjMlpsY2w5dmQyNWxjbk5vYVhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWVhKak9EaGZhVzVwZEdsaGJHbDZaVjl2ZDI1bGNsOXliM1YwWlVBeE56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qVXdDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk16VUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJCY21NeU1EQWdaWGgwWlc1a2N5QkJjbU00T0NCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pvMU1Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR05oYkd4emRXSWdZWEpqT0RoZmFXNXBkR2xoYkdsNlpWOXZkMjVsY2dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDloY21NNE9GOXBjMTl2ZDI1bGNsOXliM1YwWlVBeE5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qUXhDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk16VUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJCY21NeU1EQWdaWGgwWlc1a2N5QkJjbU00T0NCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pvME1Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJR05oYkd4emRXSWdZWEpqT0RoZmFYTmZiM2R1WlhJS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWVhKak9EaGZiM2R1WlhKZmNtOTFkR1ZBTVRVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pvek5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZMkZzYkhOMVlpQmhjbU00T0Y5dmQyNWxjZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWhjbU15TURCZllXeHNiM2RoYm1ObFgzSnZkWFJsUURFME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpJd01DNWhiR2R2TG5Sek9qRTNOd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpJd01DNWhiR2R2TG5Sek9qTTFDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUVhKak1qQXdJR1Y0ZEdWdVpITWdRWEpqT0RnZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpJd01DNWhiR2R2TG5Sek9qRTNOd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUdOaGJHeHpkV0lnWVhKak1qQXdYMkZzYkc5M1lXNWpaUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWhjbU15TURCZllYQndjbTkyWlY5eWIzVjBaVUF4TXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pveE5qVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pvek5Rb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUZ5WXpJd01DQmxlSFJsYm1SeklFRnlZemc0SUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pveE5qVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JqWVd4c2MzVmlJR0Z5WXpJd01GOWhjSEJ5YjNabENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJGeVl6SXdNRjkwY21GdWMyWmxja1p5YjIxZmNtOTFkR1ZBTVRJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk1UUTRDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk16VUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJCY21NeU1EQWdaWGgwWlc1a2N5QkJjbU00T0NCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk1UUTRDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnWTJGc2JITjFZaUJoY21NeU1EQmZkSEpoYm5ObVpYSkdjbTl0Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMkZ5WXpJd01GOTBjbUZ1YzJabGNsOXliM1YwWlVBeE1Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6b3hNelVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6b3pOUW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVGeVl6SXdNQ0JsZUhSbGJtUnpJRUZ5WXpnNElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6b3hNelVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCallXeHNjM1ZpSUdGeVl6SXdNRjkwY21GdWMyWmxjZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWhjbU15TURCZlltRnNZVzVqWlU5bVgzSnZkWFJsUURFd09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpJd01DNWhiR2R2TG5Sek9qRXlNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpJd01DNWhiR2R2TG5Sek9qTTFDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUVhKak1qQXdJR1Y0ZEdWdVpITWdRWEpqT0RnZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpJd01DNWhiR2R2TG5Sek9qRXlNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUdOaGJHeHpkV0lnWVhKak1qQXdYMkpoYkdGdVkyVlBaZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWhjbU15TURCZmRHOTBZV3hUZFhCd2JIbGZjbTkxZEdWQU9Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6b3hNVElLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnWVhKak1qQXdYM1J2ZEdGc1UzVndjR3g1Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMkZ5WXpJd01GOWtaV05wYldGc2MxOXliM1YwWlVBNE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpJd01DNWhiR2R2TG5Sek9qRXdNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnWTJGc2JITjFZaUJoY21NeU1EQmZaR1ZqYVcxaGJITUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZllYSmpNakF3WDNONWJXSnZiRjl5YjNWMFpVQTNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPamt5Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUdGeVl6SXdNRjl6ZVcxaWIyd0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZllYSmpNakF3WDI1aGJXVmZjbTkxZEdWQU5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6bzRNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnWTJGc2JITjFZaUJoY21NeU1EQmZibUZ0WlFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlpYjI5MGMzUnlZWEJmY205MWRHVkFOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXlNREF1WVd4bmJ5NTBjem8xTmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPak0xQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1FYSmpNakF3SUdWNGRHVnVaSE1nUVhKak9EZ2dld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPalUyQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ1kyRnNiSE4xWWlCaWIyOTBjM1J5WVhBS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWW1GeVpWOXliM1YwYVc1blFESTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPak0xQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1FYSmpNakF3SUdWNGRHVnVaSE1nUVhKak9EZ2dld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU9Rb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z1kzSmxZWFJwYm1jS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02T2tGeVl6SXdNQzVpYjI5MGMzUnlZWEFvYm1GdFpUb2dZbmwwWlhNc0lITjViV0p2YkRvZ1lubDBaWE1zSUdSbFkybHRZV3h6T2lCaWVYUmxjeXdnZEc5MFlXeFRkWEJ3YkhrNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1ltOXZkSE4wY21Gd09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpJd01DNWhiR2R2TG5Sek9qVTJMVFUzQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ0x5OGdjSFZpYkdsaklHSnZiM1J6ZEhKaGNDaHVZVzFsT2lCRWVXNWhiV2xqUW5sMFpYTXNJSE41YldKdmJEb2dSSGx1WVcxcFkwSjVkR1Z6TENCa1pXTnBiV0ZzY3pvZ1ZXbHVkRTQ0TENCMGIzUmhiRk4xY0hCc2VUb2dWV2x1ZEU0eU5UWXBPaUJDYjI5c0lIc0tJQ0FnSUhCeWIzUnZJRFFnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pVNENpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxuTmxibVJsY2lBOVBUMGdSMnh2WW1Gc0xtTnlaV0YwYjNKQlpHUnlaWE56TENBblQyNXNlU0JrWlhCc2IzbGxjaUJ2WmlCMGFHbHpJSE50WVhKMElHTnZiblJ5WVdOMElHTmhiaUJqWVd4c0lHSnZiM1J6ZEhKaGNDQnRaWFJvYjJRbktRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaMnh2WW1Gc0lFTnlaV0YwYjNKQlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnWkdWd2JHOTVaWElnYjJZZ2RHaHBjeUJ6YldGeWRDQmpiMjUwY21GamRDQmpZVzRnWTJGc2JDQmliMjkwYzNSeVlYQWdiV1YwYUc5a0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk5Ua0tJQ0FnSUM4dklHRnpjMlZ5ZENodVlXMWxMbTVoZEdsMlpTNXNaVzVuZEdnZ1BpQXdMQ0FuVG1GdFpTQnZaaUIwYUdVZ1lYTnpaWFFnYlhWemRDQmlaU0JzYjI1blpYSWdiM0lnWlhGMVlXd2dkRzhnTVNCamFHRnlZV04wWlhJbktRb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdiR1Z1Q2lBZ0lDQmtkWEFLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk9ZVzFsSUc5bUlIUm9aU0JoYzNObGRDQnRkWE4wSUdKbElHeHZibWRsY2lCdmNpQmxjWFZoYkNCMGJ5QXhJR05vWVhKaFkzUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPall3Q2lBZ0lDQXZMeUJoYzNObGNuUW9ibUZ0WlM1dVlYUnBkbVV1YkdWdVozUm9JRHc5SURNeUxDQW5UbUZ0WlNCdlppQjBhR1VnWVhOelpYUWdiWFZ6ZENCaVpTQnphRzl5ZEdWeUlHOXlJR1Z4ZFdGc0lIUnZJRE15SUdOb1lYSmhZM1JsY25NbktRb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRTVoYldVZ2IyWWdkR2hsSUdGemMyVjBJRzExYzNRZ1ltVWdjMmh2Y25SbGNpQnZjaUJsY1hWaGJDQjBieUF6TWlCamFHRnlZV04wWlhKekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk5qRUtJQ0FnSUM4dklHRnpjMlZ5ZENoemVXMWliMnd1Ym1GMGFYWmxMbXhsYm1kMGFDQStJREFzSUNkVGVXMWliMndnYjJZZ2RHaGxJR0Z6YzJWMElHMTFjM1FnWW1VZ2JHOXVaMlZ5SUc5eUlHVnhkV0ZzSUhSdklERWdZMmhoY21GamRHVnlKeWtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUd4bGJnb2dJQ0FnWkhWd0NpQWdJQ0JoYzNObGNuUWdMeThnVTNsdFltOXNJRzltSUhSb1pTQmhjM05sZENCdGRYTjBJR0psSUd4dmJtZGxjaUJ2Y2lCbGNYVmhiQ0IwYnlBeElHTm9ZWEpoWTNSbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpJd01DNWhiR2R2TG5Sek9qWXlDaUFnSUNBdkx5QmhjM05sY25Rb2MzbHRZbTlzTG01aGRHbDJaUzVzWlc1bmRHZ2dQRDBnT0N3Z0oxTjViV0p2YkNCdlppQjBhR1VnWVhOelpYUWdiWFZ6ZENCaVpTQnphRzl5ZEdWeUlHOXlJR1Z4ZFdGc0lIUnZJRGdnWTJoaGNtRmpkR1Z5Y3ljcENpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlRlVzFpYjJ3Z2IyWWdkR2hsSUdGemMyVjBJRzExYzNRZ1ltVWdjMmh2Y25SbGNpQnZjaUJsY1hWaGJDQjBieUE0SUdOb1lYSmhZM1JsY25NS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pvMU1Rb2dJQ0FnTHk4Z2NIVmliR2xqSUhSdmRHRnNVM1Z3Y0d4NUlEMGdSMnh2WW1Gc1UzUmhkR1U4VldsdWRFNHlOVFkrS0hzZ2EyVjVPaUFuZENjZ2ZTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKMElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpJd01DNWhiR2R2TG5Sek9qWXpDaUFnSUNBdkx5QmhjM05sY25Rb0lYUm9hWE11ZEc5MFlXeFRkWEJ3YkhrdWFHRnpWbUZzZFdVc0lDZFVhR2x6SUcxbGRHaHZaQ0JqWVc0Z1ltVWdZMkZzYkdWa0lHOXViSGtnYjI1alpTY3BDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZblZ5ZVNBeENpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdWR2hwY3lCdFpYUm9iMlFnWTJGdUlHSmxJR05oYkd4bFpDQnZibXg1SUc5dVkyVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6b3pPUW9nSUNBZ0x5OGdjSFZpYkdsaklHNWhiV1VnUFNCSGJHOWlZV3hUZEdGMFpUeEVlVzVoYldsalFubDBaWE0rS0hzZ2EyVjVPaUFuYmljZ2ZTa0tJQ0FnSUhCMWMyaGllWFJsY3lBaWJpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6bzJOUW9nSUNBZ0x5OGdkR2hwY3k1dVlXMWxMblpoYkhWbElEMGdibUZ0WlFvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pRekNpQWdJQ0F2THlCd2RXSnNhV01nYzNsdFltOXNJRDBnUjJ4dlltRnNVM1JoZEdVOFJIbHVZVzFwWTBKNWRHVnpQaWg3SUd0bGVUb2dKM01uSUgwcENpQWdJQ0J3ZFhOb1lubDBaWE1nSW5NaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk5qWUtJQ0FnSUM4dklIUm9hWE11YzNsdFltOXNMblpoYkhWbElEMGdjM2x0WW05c0NpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk5URUtJQ0FnSUM4dklIQjFZbXhwWXlCMGIzUmhiRk4xY0hCc2VTQTlJRWRzYjJKaGJGTjBZWFJsUEZWcGJuUk9NalUyUGloN0lHdGxlVG9nSjNRbklIMHBDaUFnSUNCaWVYUmxZeUEySUM4dklDSjBJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPalkzQ2lBZ0lDQXZMeUIwYUdsekxuUnZkR0ZzVTNWd2NHeDVMblpoYkhWbElEMGdkRzkwWVd4VGRYQndiSGtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXlNREF1WVd4bmJ5NTBjem8wTndvZ0lDQWdMeThnY0hWaWJHbGpJR1JsWTJsdFlXeHpJRDBnUjJ4dlltRnNVM1JoZEdVOFZXbHVkRTQ0UGloN0lHdGxlVG9nSjJRbklIMHBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0ltUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZOamdLSUNBZ0lDOHZJSFJvYVhNdVpHVmphVzFoYkhNdWRtRnNkV1VnUFNCa1pXTnBiV0ZzY3dvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pZNUNpQWdJQ0F2THlCamIyNXpkQ0J6Wlc1a1pYSWdQU0J1WlhjZ1FXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pVekNpQWdJQ0F2THlCd2RXSnNhV01nWW1Gc1lXNWpaWE1nUFNCQ2IzaE5ZWEE4UVdSa2NtVnpjeXdnVldsdWRFNHlOVFkrS0hzZ2EyVjVVSEpsWm1sNE9pQW5ZaWNnZlNrS0lDQWdJR0o1ZEdWaklEVWdMeThnSW1JaUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZOekVLSUNBZ0lDOHZJSFJvYVhNdVltRnNZVzVqWlhNb2MyVnVaR1Z5S1M1MllXeDFaU0E5SUhSdmRHRnNVM1Z3Y0d4NUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6bzNNd29nSUNBZ0x5OGdaVzFwZENodVpYY2dZWEpqTWpBd1gxUnlZVzV6Wm1WeUtIc2dabkp2YlRvZ2JtVjNJRUZrWkhKbGMzTW9SMnh2WW1Gc0xucGxjbTlCWkdSeVpYTnpLU3dnZEc4NklITmxibVJsY2l3Z2RtRnNkV1U2SUhSdmRHRnNVM1Z3Y0d4NUlIMHBLUW9nSUNBZ1oyeHZZbUZzSUZwbGNtOUJaR1J5WlhOekNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZeUE1SUM4dklHMWxkR2h2WkNBaVlYSmpNakF3WDFSeVlXNXpabVZ5S0dGa1pISmxjM01zWVdSa2NtVnpjeXgxYVc1ME1qVTJLU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02TnpRS0lDQWdJQzh2SUhKbGRIVnliaUJ1WlhjZ1FtOXZiQ2gwY25WbEtRb2dJQ0FnWW5sMFpXTWdOeUF2THlBd2VEZ3dDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZPa0Z5WXpJd01DNWhjbU15TURCZmJtRnRaU2dwSUMwK0lHSjVkR1Z6T2dwaGNtTXlNREJmYm1GdFpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6b3pPUW9nSUNBZ0x5OGdjSFZpYkdsaklHNWhiV1VnUFNCSGJHOWlZV3hUZEdGMFpUeEVlVzVoYldsalFubDBaWE0rS0hzZ2EyVjVPaUFuYmljZ2ZTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0J3ZFhOb1lubDBaWE1nSW00aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pnMENpQWdJQ0F2THlCeVpYUjFjbTRnYm1WM0lGTjBZWFJwWTBKNWRHVnpQRE15UGloMGFHbHpMbTVoYldVdWRtRnNkV1V1Ym1GMGFYWmxLUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnphWHBsQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02T2tGeVl6SXdNQzVoY21NeU1EQmZjM2x0WW05c0tDa2dMVDRnWW5sMFpYTTZDbUZ5WXpJd01GOXplVzFpYjJ3NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk5ETUtJQ0FnSUM4dklIQjFZbXhwWXlCemVXMWliMndnUFNCSGJHOWlZV3hUZEdGMFpUeEVlVzVoYldsalFubDBaWE0rS0hzZ2EyVjVPaUFuY3ljZ2ZTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0J3ZFhOb1lubDBaWE1nSW5NaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2prMENpQWdJQ0F2THlCeVpYUjFjbTRnYm1WM0lGTjBZWFJwWTBKNWRHVnpQRGcrS0hSb2FYTXVjM2x0WW05c0xuWmhiSFZsTG01aGRHbDJaU2tLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnphWHBsQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02T2tGeVl6SXdNQzVoY21NeU1EQmZaR1ZqYVcxaGJITW9LU0F0UGlCaWVYUmxjem9LWVhKak1qQXdYMlJsWTJsdFlXeHpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPalEzQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdaR1ZqYVcxaGJITWdQU0JIYkc5aVlXeFRkR0YwWlR4VmFXNTBUamcrS0hzZ2EyVjVPaUFuWkNjZ2ZTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0J3ZFhOb1lubDBaWE1nSW1RaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pFd05Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVaR1ZqYVcxaGJITXVkbUZzZFdVS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pvNlFYSmpNakF3TG1GeVl6SXdNRjkwYjNSaGJGTjFjSEJzZVNncElDMCtJR0o1ZEdWek9ncGhjbU15TURCZmRHOTBZV3hUZFhCd2JIazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZOVEVLSUNBZ0lDOHZJSEIxWW14cFl5QjBiM1JoYkZOMWNIQnNlU0E5SUVkc2IySmhiRk4wWVhSbFBGVnBiblJPTWpVMlBpaDdJR3RsZVRvZ0ozUW5JSDBwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTmlBdkx5QWlkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZNVEUwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1MGIzUmhiRk4xY0hCc2VTNTJZV3gxWlFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pwQmNtTXlNREF1WVhKak1qQXdYMkpoYkdGdVkyVlBaaWh2ZDI1bGNqb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncGhjbU15TURCZlltRnNZVzVqWlU5bU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpJd01DNWhiR2R2TG5Sek9qRXlNeTB4TWpRS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZWEpqTWpBd1gySmhiR0Z1WTJWUFppaHZkMjVsY2pvZ1FXUmtjbVZ6Y3lrNklHRnlZelF1VldsdWRFNHlOVFlnZXdvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZNVEkxQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1ZlltRnNZVzVqWlU5bUtHOTNibVZ5S1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpZV3hzYzNWaUlGOWlZV3hoYm1ObFQyWUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6bzZRWEpqTWpBd0xtRnlZekl3TUY5MGNtRnVjMlpsY2loMGJ6b2dZbmwwWlhNc0lIWmhiSFZsT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q21GeVl6SXdNRjkwY21GdWMyWmxjam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXlNREF1WVd4bmJ5NTBjem94TXpVdE1UTTJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnTHk4Z2NIVmliR2xqSUdGeVl6SXdNRjkwY21GdWMyWmxjaWgwYnpvZ1FXUmtjbVZ6Y3l3Z2RtRnNkV1U2SUdGeVl6UXVWV2x1ZEU0eU5UWXBPaUJoY21NMExrSnZiMndnZXdvZ0lDQWdjSEp2ZEc4Z01pQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZNVE0zQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1ZmRISmhibk5tWlhJb2JtVjNJRUZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzSUhSdkxDQjJZV3gxWlNrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCallXeHNjM1ZpSUY5MGNtRnVjMlpsY2dvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pwQmNtTXlNREF1WVhKak1qQXdYM1J5WVc1elptVnlSbkp2YlNobWNtOXRPaUJpZVhSbGN5d2dkRzg2SUdKNWRHVnpMQ0IyWVd4MVpUb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncGhjbU15TURCZmRISmhibk5tWlhKR2NtOXRPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPakUwT0MweE5Ea0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCd2RXSnNhV01nWVhKak1qQXdYM1J5WVc1elptVnlSbkp2YlNobWNtOXRPaUJCWkdSeVpYTnpMQ0IwYnpvZ1FXUmtjbVZ6Y3l3Z2RtRnNkV1U2SUdGeVl6UXVWV2x1ZEU0eU5UWXBPaUJoY21NMExrSnZiMndnZXdvZ0lDQWdjSEp2ZEc4Z015QXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZNVFV3Q2lBZ0lDQXZMeUJqYjI1emRDQnpjR1Z1WkdWeUlEMGdibVYzSUVGa1pISmxjM01vVkhodUxuTmxibVJsY2lrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXlNREF1WVd4bmJ5NTBjem94TlRFS0lDQWdJQzh2SUdOdmJuTjBJSE53Wlc1a1pYSmZZV3hzYjNkaGJtTmxJRDBnZEdocGN5NWZZV3hzYjNkaGJtTmxLR1p5YjIwc0lITndaVzVrWlhJcENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR1JwWnlBeENpQWdJQ0JqWVd4c2MzVmlJRjloYkd4dmQyRnVZMlVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXlNREF1WVd4bmJ5NTBjem94TlRJS0lDQWdJQzh2SUdGemMyVnlkQ2h6Y0dWdVpHVnlYMkZzYkc5M1lXNWpaUzV1WVhScGRtVWdQajBnZG1Gc2RXVXVibUYwYVhabExDQW5hVzV6ZFdabWFXTnBaVzUwSUdGd2NISnZkbUZzSnlrS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmlQajBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBibk4xWm1acFkybGxiblFnWVhCd2NtOTJZV3dLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXlNREF1WVd4bmJ5NTBjem94TlRNS0lDQWdJQzh2SUdOdmJuTjBJRzVsZDE5emNHVnVaR1Z5WDJGc2JHOTNZVzVqWlNBOUlHNWxkeUJWYVc1MFRqSTFOaWh6Y0dWdVpHVnlYMkZzYkc5M1lXNWpaUzV1WVhScGRtVWdMU0IyWVd4MVpTNXVZWFJwZG1VcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0l0Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlmQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPakUxTkFvZ0lDQWdMeThnZEdocGN5NWZZWEJ3Y205MlpTaG1jbTl0TENCemNHVnVaR1Z5TENCdVpYZGZjM0JsYm1SbGNsOWhiR3h2ZDJGdVkyVXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHTmhiR3h6ZFdJZ1gyRndjSEp2ZG1VS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pFMU5Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVYM1J5WVc1elptVnlLR1p5YjIwc0lIUnZMQ0IyWVd4MVpTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR05oYkd4emRXSWdYM1J5WVc1elptVnlDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZPa0Z5WXpJd01DNWhjbU15TURCZllYQndjbTkyWlNoemNHVnVaR1Z5T2lCaWVYUmxjeXdnZG1Gc2RXVTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tZWEpqTWpBd1gyRndjSEp2ZG1VNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk1UWTFMVEUyTmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lDOHZJSEIxWW14cFl5QmhjbU15TURCZllYQndjbTkyWlNoemNHVnVaR1Z5T2lCQlpHUnlaWE56TENCMllXeDFaVG9nWVhKak5DNVZhVzUwVGpJMU5pazZJRUp2YjJ3Z2V3b2dJQ0FnY0hKdmRHOGdNaUF4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02TVRZM0NpQWdJQ0F2THlCamIyNXpkQ0J2ZDI1bGNpQTlJRzVsZHlCQlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02TVRZNENpQWdJQ0F2THlCeVpYUjFjbTRnZEdocGN5NWZZWEJ3Y205MlpTaHZkMjVsY2l3Z2MzQmxibVJsY2l3Z2RtRnNkV1VwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyRnNiSE4xWWlCZllYQndjbTkyWlFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pwQmNtTXlNREF1WVhKak1qQXdYMkZzYkc5M1lXNWpaU2h2ZDI1bGNqb2dZbmwwWlhNc0lITndaVzVrWlhJNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1lYSmpNakF3WDJGc2JHOTNZVzVqWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pveE56Y3RNVGM0Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ0x5OGdjSFZpYkdsaklHRnlZekl3TUY5aGJHeHZkMkZ1WTJVb2IzZHVaWEk2SUVGa1pISmxjM01zSUhOd1pXNWtaWEk2SUVGa1pISmxjM01wT2lCaGNtTTBMbFZwYm5ST01qVTJJSHNLSUNBZ0lIQnliM1J2SURJZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpJd01DNWhiR2R2TG5Sek9qRTNPUW9nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11WDJGc2JHOTNZVzVqWlNodmQyNWxjaXdnYzNCbGJtUmxjaWtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCallXeHNjM1ZpSUY5aGJHeHZkMkZ1WTJVS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pvNlFYSmpNakF3TGw5aVlXeGhibU5sVDJZb2IzZHVaWEk2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LWDJKaGJHRnVZMlZQWmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pveE9ESUtJQ0FnSUM4dklIQnliM1JsWTNSbFpDQmZZbUZzWVc1alpVOW1LRzkzYm1WeU9pQkJaR1J5WlhOektUb2dWV2x1ZEU0eU5UWWdld29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk5UTUtJQ0FnSUM4dklIQjFZbXhwWXlCaVlXeGhibU5sY3lBOUlFSnZlRTFoY0R4QlpHUnlaWE56TENCVmFXNTBUakkxTmo0b2V5QnJaWGxRY21WbWFYZzZJQ2RpSnlCOUtRb2dJQ0FnWW5sMFpXTWdOU0F2THlBaVlpSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6b3hPRE1LSUNBZ0lDOHZJR2xtSUNnaGRHaHBjeTVpWVd4aGJtTmxjeWh2ZDI1bGNpa3VaWGhwYzNSektTQnlaWFIxY200Z2JtVjNJRlZwYm5ST01qVTJLREFwQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdKdWVpQmZZbUZzWVc1alpVOW1YMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUhOM1lYQUtJQ0FnSUhKbGRITjFZZ29LWDJKaGJHRnVZMlZQWmw5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02TVRnMENpQWdJQ0F2THlCeVpYUjFjbTRnZEdocGN5NWlZV3hoYm1ObGN5aHZkMjVsY2lrdWRtRnNkV1VLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdRbTk0SUcxMWMzUWdhR0YyWlNCMllXeDFaUW9nSUNBZ2MzZGhjQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPanBCY21NeU1EQXVYM1J5WVc1elptVnlLSE5sYm1SbGNqb2dZbmwwWlhNc0lISmxZMmx3YVdWdWREb2dZbmwwWlhNc0lHRnRiM1Z1ZERvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwZmRISmhibk5tWlhJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk1UZzNDaUFnSUNBdkx5QndjbTkwWldOMFpXUWdYM1J5WVc1elptVnlLSE5sYm1SbGNqb2dRV1JrY21WemN5d2djbVZqYVhCcFpXNTBPaUJCWkdSeVpYTnpMQ0JoYlc5MWJuUTZJRlZwYm5ST01qVTJLVG9nUW05dmJDQjdDaUFnSUNCd2NtOTBieUF6SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pveE9EZ0tJQ0FnSUM4dklHTnZibk4wSUhObGJtUmxjbDlpWVd4aGJtTmxJRDBnZEdocGN5NWZZbUZzWVc1alpVOW1LSE5sYm1SbGNpa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWTJGc2JITjFZaUJmWW1Gc1lXNWpaVTltQ2lBZ0lDQmtkWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXlNREF1WVd4bmJ5NTBjem94T0RrS0lDQWdJQzh2SUdOdmJuTjBJSEpsWTJsd2FXVnVkRjlpWVd4aGJtTmxJRDBnZEdocGN5NWZZbUZzWVc1alpVOW1LSEpsWTJsd2FXVnVkQ2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyRnNiSE4xWWlCZlltRnNZVzVqWlU5bUNpQWdJQ0J6ZDJGd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk1Ua3dDaUFnSUNBdkx5QmhjM05sY25Rb2MyVnVaR1Z5WDJKaGJHRnVZMlV1Ym1GMGFYWmxJRDQ5SUdGdGIzVnVkQzV1WVhScGRtVXNJQ2RKYm5OMVptWnBZMmxsYm5RZ1ltRnNZVzVqWlNCaGRDQjBhR1VnYzJWdVpHVnlJR0ZqWTI5MWJuUW5LUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaVBqMEtJQ0FnSUdGemMyVnlkQ0F2THlCSmJuTjFabVpwWTJsbGJuUWdZbUZzWVc1alpTQmhkQ0IwYUdVZ2MyVnVaR1Z5SUdGalkyOTFiblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXlNREF1WVd4bmJ5NTBjem94T1RJS0lDQWdJQzh2SUdsbUlDaHpaVzVrWlhJZ0lUMDlJSEpsWTJsd2FXVnVkQ2tnZXdvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lDRTlDaUFnSUNCaWVpQmZkSEpoYm5ObVpYSmZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk1UazBDaUFnSUNBdkx5QjBhR2x6TG1KaGJHRnVZMlZ6S0hObGJtUmxjaWt1ZG1Gc2RXVWdQU0J1WlhjZ1ZXbHVkRTR5TlRZb2MyVnVaR1Z5WDJKaGJHRnVZMlV1Ym1GMGFYWmxJQzBnWVcxdmRXNTBMbTVoZEdsMlpTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0l0Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZbndLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXlNREF1WVd4bmJ5NTBjem8xTXdvZ0lDQWdMeThnY0hWaWJHbGpJR0poYkdGdVkyVnpJRDBnUW05NFRXRndQRUZrWkhKbGMzTXNJRlZwYm5ST01qVTJQaWg3SUd0bGVWQnlaV1pwZURvZ0oySW5JSDBwQ2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0ppSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pveE9UUUtJQ0FnSUM4dklIUm9hWE11WW1Gc1lXNWpaWE1vYzJWdVpHVnlLUzUyWVd4MVpTQTlJRzVsZHlCVmFXNTBUakkxTmloelpXNWtaWEpmWW1Gc1lXNWpaUzV1WVhScGRtVWdMU0JoYlc5MWJuUXVibUYwYVhabEtRb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPakU1TlFvZ0lDQWdMeThnZEdocGN5NWlZV3hoYm1ObGN5aHlaV05wY0dsbGJuUXBMblpoYkhWbElEMGdibVYzSUZWcGJuUk9NalUyS0hKbFkybHdhV1Z1ZEY5aVlXeGhibU5sTG01aGRHbDJaU0FySUdGdGIzVnVkQzV1WVhScGRtVXBDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpS3dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdZbndLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXlNREF1WVd4bmJ5NTBjem8xTXdvZ0lDQWdMeThnY0hWaWJHbGpJR0poYkdGdVkyVnpJRDBnUW05NFRXRndQRUZrWkhKbGMzTXNJRlZwYm5ST01qVTJQaWg3SUd0bGVWQnlaV1pwZURvZ0oySW5JSDBwQ2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0ppSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pveE9UVUtJQ0FnSUM4dklIUm9hWE11WW1Gc1lXNWpaWE1vY21WamFYQnBaVzUwS1M1MllXeDFaU0E5SUc1bGR5QlZhVzUwVGpJMU5paHlaV05wY0dsbGJuUmZZbUZzWVc1alpTNXVZWFJwZG1VZ0t5QmhiVzkxYm5RdWJtRjBhWFpsS1FvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb0tYM1J5WVc1elptVnlYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6b3hPVGNLSUNBZ0lDOHZJR1Z0YVhRb2JtVjNJR0Z5WXpJd01GOVVjbUZ1YzJabGNpaDdJR1p5YjIwNklITmxibVJsY2l3Z2RHODZJSEpsWTJsd2FXVnVkQ3dnZG1Gc2RXVTZJR0Z0YjNWdWRDQjlLU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWXlBNUlDOHZJRzFsZEdodlpDQWlZWEpqTWpBd1gxUnlZVzV6Wm1WeUtHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4MWFXNTBNalUyS1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk1UazRDaUFnSUNBdkx5QnlaWFIxY200Z2JtVjNJRUp2YjJ3b2RISjFaU2tLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdNSGc0TUFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02T2tGeVl6SXdNQzVmWVhCd2NtOTJZV3hMWlhrb2IzZHVaWEk2SUdKNWRHVnpMQ0J6Y0dWdVpHVnlPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbDloY0hCeWIzWmhiRXRsZVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pveU1EQUtJQ0FnSUM4dklIQnliM1JsWTNSbFpDQmZZWEJ3Y205MllXeExaWGtvYjNkdVpYSTZJRUZrWkhKbGMzTXNJSE53Wlc1a1pYSTZJRUZrWkhKbGMzTXBPaUJUZEdGMGFXTkNlWFJsY3p3ek1qNGdld29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk1qQXhDaUFnSUNBdkx5QnlaWFIxY200Z2JtVjNJRk4wWVhScFkwSjVkR1Z6UERNeVBpaHZjQzV6YUdFeU5UWW9iM0F1WTI5dVkyRjBLRzkzYm1WeUxtSjVkR1Z6TENCemNHVnVaR1Z5TG1KNWRHVnpLU2twQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnphR0V5TlRZS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCemFYcGxDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZPa0Z5WXpJd01DNWZZV3hzYjNkaGJtTmxLRzkzYm1WeU9pQmllWFJsY3l3Z2MzQmxibVJsY2pvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwZllXeHNiM2RoYm1ObE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpJd01DNWhiR2R2TG5Sek9qSXdOQW9nSUNBZ0x5OGdjSEp2ZEdWamRHVmtJRjloYkd4dmQyRnVZMlVvYjNkdVpYSTZJRUZrWkhKbGMzTXNJSE53Wlc1a1pYSTZJRUZrWkhKbGMzTXBPaUJWYVc1MFRqSTFOaUI3Q2lBZ0lDQndjbTkwYnlBeUlERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6b3lNRFVLSUNBZ0lDOHZJR052Ym5OMElHdGxlU0E5SUhSb2FYTXVYMkZ3Y0hKdmRtRnNTMlY1S0c5M2JtVnlMQ0J6Y0dWdVpHVnlLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOaGJHeHpkV0lnWDJGd2NISnZkbUZzUzJWNUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk5UVUtJQ0FnSUM4dklIQjFZbXhwWXlCaGNIQnliM1poYkhNZ1BTQkNiM2hOWVhBOFUzUmhkR2xqUW5sMFpYTThNekkrTENCQmNIQnliM1poYkZOMGNuVmpkRDRvZXlCclpYbFFjbVZtYVhnNklDZGhKeUI5S1FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0poSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU15TURBdVlXeG5ieTUwY3pveU1EWUtJQ0FnSUM4dklHbG1JQ2doZEdocGN5NWhjSEJ5YjNaaGJITW9hMlY1S1M1bGVHbHpkSE1wSUhKbGRIVnliaUJ1WlhjZ1ZXbHVkRTR5TlRZb01Da0tJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbTU2SUY5aGJHeHZkMkZ1WTJWZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdjM2RoY0FvZ0lDQWdjbVYwYzNWaUNncGZZV3hzYjNkaGJtTmxYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6b3lNRGNLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TG1Gd2NISnZkbUZzY3loclpYa3BMblpoYkhWbExtRndjSEp2ZG1Gc1FXMXZkVzUwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJRUp2ZUNCdGRYTjBJR2hoZG1VZ2RtRnNkV1VLSUNBZ0lHVjRkSEpoWTNRZ01DQXpNaUF2THlCdmJpQmxjbkp2Y2pvZ1NXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUhOM1lYQUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6bzZRWEpqTWpBd0xsOWhjSEJ5YjNabEtHOTNibVZ5T2lCaWVYUmxjeXdnYzNCbGJtUmxjam9nWW5sMFpYTXNJR0Z0YjNWdWREb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncGZZWEJ3Y205MlpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NeU1EQXVZV3huYnk1MGN6b3lNVEFLSUNBZ0lDOHZJSEJ5YjNSbFkzUmxaQ0JmWVhCd2NtOTJaU2h2ZDI1bGNqb2dRV1JrY21WemN5d2djM0JsYm1SbGNqb2dRV1JrY21WemN5d2dZVzF2ZFc1ME9pQlZhVzUwVGpJMU5pazZJRUp2YjJ3Z2V3b2dJQ0FnY0hKdmRHOGdNeUF4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpNakF3TG1Gc1oyOHVkSE02TWpFeENpQWdJQ0F2THlCamIyNXpkQ0JyWlhrZ1BTQjBhR2x6TGw5aGNIQnliM1poYkV0bGVTaHZkMjVsY2l3Z2MzQmxibVJsY2lrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpZV3hzYzNWaUlGOWhjSEJ5YjNaaGJFdGxlUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6SXdNQzVoYkdkdkxuUnpPakl4TWkweU1UWUtJQ0FnSUM4dklHTnZibk4wSUdGd2NISnZkbUZzUW05NE9pQkJjSEJ5YjNaaGJGTjBjblZqZENBOUlHNWxkeUJCY0hCeWIzWmhiRk4wY25WamRDaDdDaUFnSUNBdkx5QWdJR0Z3Y0hKdmRtRnNRVzF2ZFc1ME9pQmhiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lHOTNibVZ5T2lCdmQyNWxjaXdLSUNBZ0lDOHZJQ0FnYzNCbGJtUmxjam9nYzNCbGJtUmxjaXdLSUNBZ0lDOHZJSDBwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZekl3TUM1aGJHZHZMblJ6T2pVMUNpQWdJQ0F2THlCd2RXSnNhV01nWVhCd2NtOTJZV3h6SUQwZ1FtOTRUV0Z3UEZOMFlYUnBZMEo1ZEdWelBETXlQaXdnUVhCd2NtOTJZV3hUZEhKMVkzUStLSHNnYTJWNVVISmxabWw0T2lBbllTY2dmU2tLSUNBZ0lIQjFjMmhpZVhSbGN5QWlZU0lLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak1qQXdMbUZzWjI4dWRITTZNakUzQ2lBZ0lDQXZMeUIwYUdsekxtRndjSEp2ZG1Gc2N5aHJaWGtwTG5aaGJIVmxJRDBnWVhCd2NtOTJZV3hDYjNndVkyOXdlU2dwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqTWpBd0xtRnNaMjh1ZEhNNk1qRTRDaUFnSUNBdkx5QmxiV2wwS0c1bGR5QmhjbU15TURCZlFYQndjbTkyWVd3b2V5QnZkMjVsY2pvZ2IzZHVaWElzSUhOd1pXNWtaWEk2SUhOd1pXNWtaWElzSUhaaGJIVmxPaUJoYlc5MWJuUWdmU2twQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRrMk9XWTROalVnTHk4Z2JXVjBhRzlrSUNKaGNtTXlNREJmUVhCd2NtOTJZV3dvWVdSa2NtVnpjeXhoWkdSeVpYTnpMSFZwYm5ReU5UWXBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTXlNREF1WVd4bmJ5NTBjem95TVRrS0lDQWdJQzh2SUhKbGRIVnliaUJ1WlhjZ1FtOXZiQ2gwY25WbEtRb2dJQ0FnWW5sMFpXTWdOeUF2THlBd2VEZ3dDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6bzZRWEpqT0RndVgyVnVjM1Z5WlVSbFptRjFiSFJQZDI1bGNpZ3BJQzArSUhadmFXUTZDbDlsYm5OMWNtVkVaV1poZFd4MFQzZHVaWEk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpPRGd1WVd4bmJ5NTBjem94T1FvZ0lDQWdMeThnY0hWaWJHbGpJR2x1YVhScFlXeHBlbVZrSUQwZ1IyeHZZbUZzVTNSaGRHVThZWEpqTkM1Q2VYUmxQaWg3SUd0bGVUb2dKMkZ5WXpnNFgyOXBKeUI5S1NBdkx5QXhJR2xtSUdsdWFYUnBZV3hwZW1Wa0lDaGxlSEJzYVdOcGRDQnZjaUJwYlhCc2FXTnBkQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmhjbU00T0Y5dmFTSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qSTNDaUFnSUNBdkx5QnBaaUFvSVhSb2FYTXVhVzVwZEdsaGJHbDZaV1F1YUdGelZtRnNkV1VnZkh3Z2RHaHBjeTVwYm1sMGFXRnNhWHBsWkM1MllXeDFaUzV1WVhScGRtVWdQVDA5SURBcElIc0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0o2SUY5bGJuTjFjbVZFWldaaGRXeDBUM2R1WlhKZmFXWmZZbTlrZVVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pveE9Rb2dJQ0FnTHk4Z2NIVmliR2xqSUdsdWFYUnBZV3hwZW1Wa0lEMGdSMnh2WW1Gc1UzUmhkR1U4WVhKak5DNUNlWFJsUGloN0lHdGxlVG9nSjJGeVl6ZzRYMjlwSnlCOUtTQXZMeUF4SUdsbUlHbHVhWFJwWVd4cGVtVmtJQ2hsZUhCc2FXTnBkQ0J2Y2lCcGJYQnNhV05wZENrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0poY21NNE9GOXZhU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6b3lOd29nSUNBZ0x5OGdhV1lnS0NGMGFHbHpMbWx1YVhScFlXeHBlbVZrTG1oaGMxWmhiSFZsSUh4OElIUm9hWE11YVc1cGRHbGhiR2w2WldRdWRtRnNkV1V1Ym1GMGFYWmxJRDA5UFNBd0tTQjdDaUFnSUNCaWRHOXBDaUFnSUNCaWJub2dYMlZ1YzNWeVpVUmxabUYxYkhSUGQyNWxjbDloWm5SbGNsOXBabDlsYkhObFFEVUtDbDlsYm5OMWNtVkVaV1poZFd4MFQzZHVaWEpmYVdaZlltOWtlVUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZemc0TG1Gc1oyOHVkSE02TVRjS0lDQWdJQzh2SUhCMVlteHBZeUJ2ZDI1bGNpQTlJRWRzYjJKaGJGTjBZWFJsUEdGeVl6UXVRV1JrY21WemN6NG9leUJyWlhrNklDZGhjbU00T0Y5dkp5QjlLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltRnlZemc0WDI4aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pveU9Bb2dJQ0FnTHk4Z2FXWWdLQ0YwYUdsekxtOTNibVZ5TG1oaGMxWmhiSFZsS1NCN0NpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1luVnllU0F4Q2lBZ0lDQmlibm9nWDJWdWMzVnlaVVJsWm1GMWJIUlBkMjVsY2w5aFpuUmxjbDlwWmw5bGJITmxRRFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPakUzQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdiM2R1WlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHhoY21NMExrRmtaSEpsYzNNK0tIc2dhMlY1T2lBbllYSmpPRGhmYnljZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltRnlZemc0WDI4aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pveU9Rb2dJQ0FnTHk4Z2RHaHBjeTV2ZDI1bGNpNTJZV3gxWlNBOUlHNWxkeUJoY21NMExrRmtaSEpsYzNNb1IyeHZZbUZzTG1OeVpXRjBiM0pCWkdSeVpYTnpLUW9nSUNBZ1oyeHZZbUZzSUVOeVpXRjBiM0pCWkdSeVpYTnpDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9LWDJWdWMzVnlaVVJsWm1GMWJIUlBkMjVsY2w5aFpuUmxjbDlwWmw5bGJITmxRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpPRGd1WVd4bmJ5NTBjem94T1FvZ0lDQWdMeThnY0hWaWJHbGpJR2x1YVhScFlXeHBlbVZrSUQwZ1IyeHZZbUZzVTNSaGRHVThZWEpqTkM1Q2VYUmxQaWg3SUd0bGVUb2dKMkZ5WXpnNFgyOXBKeUI5S1NBdkx5QXhJR2xtSUdsdWFYUnBZV3hwZW1Wa0lDaGxlSEJzYVdOcGRDQnZjaUJwYlhCc2FXTnBkQ2tLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbUZ5WXpnNFgyOXBJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZNekVLSUNBZ0lDOHZJSFJvYVhNdWFXNXBkR2xoYkdsNlpXUXVkbUZzZFdVZ1BTQnVaWGNnWVhKak5DNUNlWFJsS0RFcENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtDbDlsYm5OMWNtVkVaV1poZFd4MFQzZHVaWEpmWVdaMFpYSmZhV1pmWld4elpVQTFPZ29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZPa0Z5WXpnNExtRnlZemc0WDI5M2JtVnlLQ2tnTFQ0Z1lubDBaWE02Q21GeVl6ZzRYMjkzYm1WeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk16Y0tJQ0FnSUM4dklIUm9hWE11WDJWdWMzVnlaVVJsWm1GMWJIUlBkMjVsY2lncENpQWdJQ0JqWVd4c2MzVmlJRjlsYm5OMWNtVkVaV1poZFd4MFQzZHVaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPakUzQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdiM2R1WlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHhoY21NMExrRmtaSEpsYzNNK0tIc2dhMlY1T2lBbllYSmpPRGhmYnljZ2ZTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaGNtTTRPRjl2SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPak00Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1dmQyNWxjaTUyWVd4MVpRb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk9rRnlZemc0TG1GeVl6ZzRYMmx6WDI5M2JtVnlLSEYxWlhKNU9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNtRnlZemc0WDJselgyOTNibVZ5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZemc0TG1Gc1oyOHVkSE02TkRFdE5ESUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0F2THlCd2RXSnNhV01nWVhKak9EaGZhWE5mYjNkdVpYSW9jWFZsY25rNklHRnlZelF1UVdSa2NtVnpjeWs2SUdGeVl6UXVRbTl2YkNCN0NpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPalF6Q2lBZ0lDQXZMeUIwYUdsekxsOWxibk4xY21WRVpXWmhkV3gwVDNkdVpYSW9LUW9nSUNBZ1kyRnNiSE4xWWlCZlpXNXpkWEpsUkdWbVlYVnNkRTkzYm1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pveE53b2dJQ0FnTHk4Z2NIVmliR2xqSUc5M2JtVnlJRDBnUjJ4dlltRnNVM1JoZEdVOFlYSmpOQzVCWkdSeVpYTnpQaWg3SUd0bGVUb2dKMkZ5WXpnNFgyOG5JSDBwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZWEpqT0RoZmJ5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qUTBDaUFnSUNBdkx5QnBaaUFvSVhSb2FYTXViM2R1WlhJdWFHRnpWbUZzZFdVcElISmxkSFZ5YmlCdVpYY2dZWEpqTkM1Q2IyOXNLR1poYkhObEtRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbTU2SUdGeVl6ZzRYMmx6WDI5M2JtVnlYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnWW5sMFpXTWdPQ0F2THlBd2VEQXdDaUFnSUNCeVpYUnpkV0lLQ21GeVl6ZzRYMmx6WDI5M2JtVnlYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qRTNDaUFnSUNBdkx5QndkV0pzYVdNZ2IzZHVaWElnUFNCSGJHOWlZV3hUZEdGMFpUeGhjbU0wTGtGa1pISmxjM00rS0hzZ2EyVjVPaUFuWVhKak9EaGZieWNnZlNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0poY21NNE9GOXZJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qUTFDaUFnSUNBdkx5QnBaaUFvZEdocGN5NXZkMjVsY2k1MllXeDFaU0E5UFQwZ2JtVjNJR0Z5WXpRdVFXUmtjbVZ6Y3lncEtTQnlaWFIxY200Z2JtVjNJR0Z5WXpRdVFtOXZiQ2htWVd4elpTa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z1lXUmtjaUJCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJXVFZJUmt0UkNpQWdJQ0E5UFFvZ0lDQWdZbm9nWVhKak9EaGZhWE5mYjNkdVpYSmZZV1owWlhKZmFXWmZaV3h6WlVBMENpQWdJQ0JpZVhSbFl5QTRJQzh2SURCNE1EQUtJQ0FnSUhKbGRITjFZZ29LWVhKak9EaGZhWE5mYjNkdVpYSmZZV1owWlhKZmFXWmZaV3h6WlVBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk1UY0tJQ0FnSUM4dklIQjFZbXhwWXlCdmQyNWxjaUE5SUVkc2IySmhiRk4wWVhSbFBHRnlZelF1UVdSa2NtVnpjejRvZXlCclpYazZJQ2RoY21NNE9GOXZKeUI5S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUZ5WXpnNFgyOGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk5EWUtJQ0FnSUM4dklISmxkSFZ5YmlCdVpYY2dZWEpqTkM1Q2IyOXNLSFJvYVhNdWIzZHVaWEl1ZG1Gc2RXVWdQVDA5SUhGMVpYSjVLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBOVBRb2dJQ0FnWW5sMFpXTWdPQ0F2THlBd2VEQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU00T0M1aGJHZHZMblJ6T2pwQmNtTTRPQzVoY21NNE9GOXBibWwwYVdGc2FYcGxYMjkzYm1WeUtHNWxkMTl2ZDI1bGNqb2dZbmwwWlhNcElDMCtJSFp2YVdRNkNtRnlZemc0WDJsdWFYUnBZV3hwZW1WZmIzZHVaWEk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpPRGd1WVd4bmJ5NTBjem8xTUMwMU1Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJQzh2SUhCMVlteHBZeUJoY21NNE9GOXBibWwwYVdGc2FYcGxYMjkzYm1WeUtHNWxkMTl2ZDI1bGNqb2dZWEpqTkM1QlpHUnlaWE56S1RvZ2RtOXBaQ0I3Q2lBZ0lDQndjbTkwYnlBeElEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qRTVDaUFnSUNBdkx5QndkV0pzYVdNZ2FXNXBkR2xoYkdsNlpXUWdQU0JIYkc5aVlXeFRkR0YwWlR4aGNtTTBMa0o1ZEdVK0tIc2dhMlY1T2lBbllYSmpPRGhmYjJrbklIMHBJQzh2SURFZ2FXWWdhVzVwZEdsaGJHbDZaV1FnS0dWNGNHeHBZMmwwSUc5eUlHbHRjR3hwWTJsMEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEUWdMeThnSW1GeVl6ZzRYMjlwSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZemc0TG1Gc1oyOHVkSE02TlRJS0lDQWdJQzh2SUdGemMyVnlkQ2doS0hSb2FYTXVhVzVwZEdsaGJHbDZaV1F1YUdGelZtRnNkV1VnSmlZZ2RHaHBjeTVwYm1sMGFXRnNhWHBsWkM1MllXeDFaUzV1WVhScGRtVWdQVDA5SURFcExDQW5ZV3h5WldGa2VWOXBibWwwYVdGc2FYcGxaQ2NwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWVpQmhjbU00T0Y5cGJtbDBhV0ZzYVhwbFgyOTNibVZ5WDJKdmIyeGZabUZzYzJWQU13b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk1Ua0tJQ0FnSUM4dklIQjFZbXhwWXlCcGJtbDBhV0ZzYVhwbFpDQTlJRWRzYjJKaGJGTjBZWFJsUEdGeVl6UXVRbmwwWlQ0b2V5QnJaWGs2SUNkaGNtTTRPRjl2YVNjZ2ZTa2dMeThnTVNCcFppQnBibWwwYVdGc2FYcGxaQ0FvWlhod2JHbGphWFFnYjNJZ2FXMXdiR2xqYVhRcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWVhKak9EaGZiMmtpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZOVElLSUNBZ0lDOHZJR0Z6YzJWeWRDZ2hLSFJvYVhNdWFXNXBkR2xoYkdsNlpXUXVhR0Z6Vm1Gc2RXVWdKaVlnZEdocGN5NXBibWwwYVdGc2FYcGxaQzUyWVd4MVpTNXVZWFJwZG1VZ1BUMDlJREVwTENBbllXeHlaV0ZrZVY5cGJtbDBhV0ZzYVhwbFpDY3BDaUFnSUNCaWRHOXBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0o2SUdGeVl6ZzRYMmx1YVhScFlXeHBlbVZmYjNkdVpYSmZZbTl2YkY5bVlXeHpaVUF6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9LWVhKak9EaGZhVzVwZEdsaGJHbDZaVjl2ZDI1bGNsOWliMjlzWDIxbGNtZGxRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpPRGd1WVd4bmJ5NTBjem8xTWdvZ0lDQWdMeThnWVhOelpYSjBLQ0VvZEdocGN5NXBibWwwYVdGc2FYcGxaQzVvWVhOV1lXeDFaU0FtSmlCMGFHbHpMbWx1YVhScFlXeHBlbVZrTG5aaGJIVmxMbTVoZEdsMlpTQTlQVDBnTVNrc0lDZGhiSEpsWVdSNVgybHVhWFJwWVd4cGVtVmtKeWtLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCaGJISmxZV1I1WDJsdWFYUnBZV3hwZW1Wa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pvMU13b2dJQ0FnTHk4Z1lYTnpaWEowS0c1bGQxOXZkMjVsY2lBaFBUMGdibVYzSUdGeVl6UXVRV1JrY21WemN5Z3BMQ0FuZW1WeWIxOWhaR1J5WlhOelgyNXZkRjloYkd4dmQyVmtKeWtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lubDBaV05mTWlBdkx5QmhaR1J5SUVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZaTlVoR1MxRUtJQ0FnSUNFOUNpQWdJQ0JoYzNObGNuUWdMeThnZW1WeWIxOWhaR1J5WlhOelgyNXZkRjloYkd4dmQyVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6b3hOd29nSUNBZ0x5OGdjSFZpYkdsaklHOTNibVZ5SUQwZ1IyeHZZbUZzVTNSaGRHVThZWEpqTkM1QlpHUnlaWE56UGloN0lHdGxlVG9nSjJGeVl6ZzRYMjhuSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaGNtTTRPRjl2SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZemc0TG1Gc1oyOHVkSE02TlRRS0lDQWdJQzh2SUhSb2FYTXViM2R1WlhJdWRtRnNkV1VnUFNCdVpYZGZiM2R1WlhJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU00T0M1aGJHZHZMblJ6T2pFNUNpQWdJQ0F2THlCd2RXSnNhV01nYVc1cGRHbGhiR2w2WldRZ1BTQkhiRzlpWVd4VGRHRjBaVHhoY21NMExrSjVkR1UrS0hzZ2EyVjVPaUFuWVhKak9EaGZiMmtuSUgwcElDOHZJREVnYVdZZ2FXNXBkR2xoYkdsNlpXUWdLR1Y0Y0d4cFkybDBJRzl5SUdsdGNHeHBZMmwwS1FvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWVhKak9EaGZiMmtpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpPRGd1WVd4bmJ5NTBjem8xTlFvZ0lDQWdMeThnZEdocGN5NXBibWwwYVdGc2FYcGxaQzUyWVd4MVpTQTlJRzVsZHlCaGNtTTBMa0o1ZEdVb01Ta0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2dwaGNtTTRPRjlwYm1sMGFXRnNhWHBsWDI5M2JtVnlYMkp2YjJ4ZlptRnNjMlZBTXpvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlJR0Z5WXpnNFgybHVhWFJwWVd4cGVtVmZiM2R1WlhKZlltOXZiRjl0WlhKblpVQTBDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk9rRnlZemc0TG1GeVl6ZzRYM1J5WVc1elptVnlYMjkzYm1WeWMyaHBjQ2h1WlhkZmIzZHVaWEk2SUdKNWRHVnpLU0F0UGlCMmIybGtPZ3BoY21NNE9GOTBjbUZ1YzJabGNsOXZkMjVsY25Ob2FYQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6bzFPQzAxT1FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lDOHZJSEIxWW14cFl5QmhjbU00T0Y5MGNtRnVjMlpsY2w5dmQyNWxjbk5vYVhBb2JtVjNYMjkzYm1WeU9pQmhjbU0wTGtGa1pISmxjM01wT2lCMmIybGtJSHNLSUNBZ0lIQnliM1J2SURFZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk5qQUtJQ0FnSUM4dklIUm9hWE11WDJWdWMzVnlaVVJsWm1GMWJIUlBkMjVsY2lncENpQWdJQ0JqWVd4c2MzVmlJRjlsYm5OMWNtVkVaV1poZFd4MFQzZHVaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPall4Q2lBZ0lDQXZMeUJoYzNObGNuUW9ibVYzSUdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU0E5UFQwZ2RHaHBjeTV2ZDI1bGNpNTJZV3gxWlN3Z0oyNXZkRjl2ZDI1bGNpY3BDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pveE53b2dJQ0FnTHk4Z2NIVmliR2xqSUc5M2JtVnlJRDBnUjJ4dlltRnNVM1JoZEdVOFlYSmpOQzVCWkdSeVpYTnpQaWg3SUd0bGVUb2dKMkZ5WXpnNFgyOG5JSDBwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZWEpqT0RoZmJ5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pvMk1Rb2dJQ0FnTHk4Z1lYTnpaWEowS0c1bGR5QmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrZ1BUMDlJSFJvYVhNdWIzZHVaWEl1ZG1Gc2RXVXNJQ2R1YjNSZmIzZHVaWEluS1FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1JmYjNkdVpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qWXlDaUFnSUNBdkx5QmhjM05sY25Rb2JtVjNYMjkzYm1WeUlDRTlQU0J1WlhjZ1lYSmpOQzVCWkdSeVpYTnpLQ2tzSUNkNlpYSnZYMkZrWkhKbGMzTmZibTkwWDJGc2JHOTNaV1FuS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmllWFJsWTE4eUlDOHZJR0ZrWkhJZ1FVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVZrMVNFWkxVUW9nSUNBZ0lUMEtJQ0FnSUdGemMyVnlkQ0F2THlCNlpYSnZYMkZrWkhKbGMzTmZibTkwWDJGc2JHOTNaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPakUzQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdiM2R1WlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHhoY21NMExrRmtaSEpsYzNNK0tIc2dhMlY1T2lBbllYSmpPRGhmYnljZ2ZTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaGNtTTRPRjl2SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUZ5WXpnNFgyOGlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6bzJOQW9nSUNBZ0x5OGdkR2hwY3k1dmQyNWxjaTUyWVd4MVpTQTlJRzVsZDE5dmQyNWxjZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZOalVLSUNBZ0lDOHZJR1Z0YVhRb2JtVjNJR0Z5WXpnNFgwOTNibVZ5YzJocGNGUnlZVzV6Wm1WeWNtVmtLSHNnY0hKbGRtbHZkWE5mYjNkdVpYSTZJSEJ5WlhacGIzVnpMQ0J1WlhkZmIzZHVaWElnZlNrcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTWdNVEFnTHk4Z2JXVjBhRzlrSUNKaGNtTTRPRjlQZDI1bGNuTm9hWEJVY21GdWMyWmxjbkpsWkNoaFpHUnlaWE56TEdGa1pISmxjM01wSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU00T0M1aGJHZHZMblJ6T2pwQmNtTTRPQzVoY21NNE9GOXlaVzV2ZFc1alpWOXZkMjVsY25Ob2FYQW9LU0F0UGlCMmIybGtPZ3BoY21NNE9GOXlaVzV2ZFc1alpWOXZkMjVsY25Ob2FYQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6bzNNQW9nSUNBZ0x5OGdkR2hwY3k1ZlpXNXpkWEpsUkdWbVlYVnNkRTkzYm1WeUtDa0tJQ0FnSUdOaGJHeHpkV0lnWDJWdWMzVnlaVVJsWm1GMWJIUlBkMjVsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZemc0TG1Gc1oyOHVkSE02TnpFS0lDQWdJQzh2SUdGemMyVnlkQ2h1WlhjZ1lYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwSUQwOVBTQjBhR2x6TG05M2JtVnlMblpoYkhWbExDQW5ibTkwWDI5M2JtVnlKeWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qRTNDaUFnSUNBdkx5QndkV0pzYVdNZ2IzZHVaWElnUFNCSGJHOWlZV3hUZEdGMFpUeGhjbU0wTGtGa1pISmxjM00rS0hzZ2EyVjVPaUFuWVhKak9EaGZieWNnZlNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0poY21NNE9GOXZJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qY3hDaUFnSUNBdkx5QmhjM05sY25Rb2JtVjNJR0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTQTlQVDBnZEdocGN5NXZkMjVsY2k1MllXeDFaU3dnSjI1dmRGOXZkMjVsY2ljcENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZEY5dmQyNWxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZNVGNLSUNBZ0lDOHZJSEIxWW14cFl5QnZkMjVsY2lBOUlFZHNiMkpoYkZOMFlYUmxQR0Z5WXpRdVFXUmtjbVZ6Y3o0b2V5QnJaWGs2SUNkaGNtTTRPRjl2SnlCOUtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1GeVl6ZzRYMjhpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ1lubDBaV05mTUNBdkx5QWlZWEpqT0RoZmJ5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qY3pDaUFnSUNBdkx5QjBhR2x6TG05M2JtVnlMblpoYkhWbElEMGdibVYzSUdGeVl6UXVRV1JrY21WemN5Z3BDaUFnSUNCaWVYUmxZMTh5SUM4dklHRmtaSElnUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVmsxU0VaTFVRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qYzBDaUFnSUNBdkx5QmxiV2wwS0c1bGR5QmhjbU00T0Y5UGQyNWxjbk5vYVhCU1pXNXZkVzVqWldRb2V5QndjbVYyYVc5MWMxOXZkMjVsY2pvZ2NISmxkbWx2ZFhNZ2ZTa3BDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3pORFpoWVRFMk5pQXZMeUJ0WlhSb2IyUWdJbUZ5WXpnNFgwOTNibVZ5YzJocGNGSmxibTkxYm1ObFpDaGhaR1J5WlhOektTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6bzZRWEpqT0RndVlYSmpPRGhmZEhKaGJuTm1aWEpmYjNkdVpYSnphR2x3WDNKbGNYVmxjM1FvY0dWdVpHbHVaem9nWW5sMFpYTXBJQzArSUhadmFXUTZDbUZ5WXpnNFgzUnlZVzV6Wm1WeVgyOTNibVZ5YzJocGNGOXlaWEYxWlhOME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk56Z3ROemtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNBdkx5QndkV0pzYVdNZ1lYSmpPRGhmZEhKaGJuTm1aWEpmYjNkdVpYSnphR2x3WDNKbGNYVmxjM1FvY0dWdVpHbHVaem9nWVhKak5DNUJaR1J5WlhOektUb2dkbTlwWkNCN0NpQWdJQ0J3Y205MGJ5QXhJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPamd3Q2lBZ0lDQXZMeUIwYUdsekxsOWxibk4xY21WRVpXWmhkV3gwVDNkdVpYSW9LUW9nSUNBZ1kyRnNiSE4xWWlCZlpXNXpkWEpsUkdWbVlYVnNkRTkzYm1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pvNE1Rb2dJQ0FnTHk4Z1lYTnpaWEowS0c1bGR5QmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrZ1BUMDlJSFJvYVhNdWIzZHVaWEl1ZG1Gc2RXVXNJQ2R1YjNSZmIzZHVaWEluS1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZNVGNLSUNBZ0lDOHZJSEIxWW14cFl5QnZkMjVsY2lBOUlFZHNiMkpoYkZOMFlYUmxQR0Z5WXpRdVFXUmtjbVZ6Y3o0b2V5QnJaWGs2SUNkaGNtTTRPRjl2SnlCOUtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1GeVl6ZzRYMjhpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZPREVLSUNBZ0lDOHZJR0Z6YzJWeWRDaHVaWGNnWVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBJRDA5UFNCMGFHbHpMbTkzYm1WeUxuWmhiSFZsTENBbmJtOTBYMjkzYm1WeUp5a0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYm05MFgyOTNibVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZqZFhKcGRIbGZkRzlyWlc0dllYSmpPRGd1WVd4bmJ5NTBjem80TWdvZ0lDQWdMeThnWVhOelpYSjBLSEJsYm1ScGJtY2dJVDA5SUc1bGR5QmhjbU0wTGtGa1pISmxjM01vS1N3Z0ozcGxjbTlmWVdSa2NtVnpjMTl1YjNSZllXeHNiM2RsWkNjcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0o1ZEdWalh6SWdMeThnWVdSa2NpQkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQldUVklSa3RSQ2lBZ0lDQWhQUW9nSUNBZ1lYTnpaWEowSUM4dklIcGxjbTlmWVdSa2NtVnpjMTl1YjNSZllXeHNiM2RsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZemc0TG1Gc1oyOHVkSE02TVRnS0lDQWdJQzh2SUhCMVlteHBZeUJ3Wlc1a2FXNW5UM2R1WlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHhoY21NMExrRmtaSEpsYzNNK0tIc2dhMlY1T2lBbllYSmpPRGhmY0c4bklIMHBJQzh2SUc5d2RHbHZibUZzSUhSM2J5MXpkR1Z3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTXlBdkx5QWlZWEpqT0RoZmNHOGlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6bzRNd29nSUNBZ0x5OGdhV1lnS0hSb2FYTXVjR1Z1WkdsdVowOTNibVZ5TG1oaGMxWmhiSFZsSUNZbUlIUm9hWE11Y0dWdVpHbHVaMDkzYm1WeUxuWmhiSFZsSUNFOVBTQnVaWGNnWVhKak5DNUJaR1J5WlhOektDa3BJSHNLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JpZFhKNUlERUtJQ0FnSUdKNklHRnlZemc0WDNSeVlXNXpabVZ5WDI5M2JtVnljMmhwY0Y5eVpYRjFaWE4wWDJGbWRHVnlYMmxtWDJWc2MyVkFNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZNVGdLSUNBZ0lDOHZJSEIxWW14cFl5QndaVzVrYVc1blQzZHVaWElnUFNCSGJHOWlZV3hUZEdGMFpUeGhjbU0wTGtGa1pISmxjM00rS0hzZ2EyVjVPaUFuWVhKak9EaGZjRzhuSUgwcElDOHZJRzl3ZEdsdmJtRnNJSFIzYnkxemRHVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaVlYSmpPRGhmY0c4aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZemc0TG1Gc1oyOHVkSE02T0RNS0lDQWdJQzh2SUdsbUlDaDBhR2x6TG5CbGJtUnBibWRQZDI1bGNpNW9ZWE5XWVd4MVpTQW1KaUIwYUdsekxuQmxibVJwYm1kUGQyNWxjaTUyWVd4MVpTQWhQVDBnYm1WM0lHRnlZelF1UVdSa2NtVnpjeWdwS1NCN0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUdGa1pISWdRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFWazFTRVpMVVFvZ0lDQWdJVDBLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCd1pXNWthVzVuWDNSeVlXNXpabVZ5WDJWNGFYTjBjd29LWVhKak9EaGZkSEpoYm5ObVpYSmZiM2R1WlhKemFHbHdYM0psY1hWbGMzUmZZV1owWlhKZmFXWmZaV3h6WlVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk1UZ0tJQ0FnSUM4dklIQjFZbXhwWXlCd1pXNWthVzVuVDNkdVpYSWdQU0JIYkc5aVlXeFRkR0YwWlR4aGNtTTBMa0ZrWkhKbGMzTStLSHNnYTJWNU9pQW5ZWEpqT0RoZmNHOG5JSDBwSUM4dklHOXdkR2x2Ym1Gc0lIUjNieTF6ZEdWd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKaGNtTTRPRjl3YnlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU00T0M1aGJHZHZMblJ6T2pnMkNpQWdJQ0F2THlCMGFHbHpMbkJsYm1ScGJtZFBkMjVsY2k1MllXeDFaU0E5SUhCbGJtUnBibWNLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPakUzQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdiM2R1WlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHhoY21NMExrRmtaSEpsYzNNK0tIc2dhMlY1T2lBbllYSmpPRGhmYnljZ2ZTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaGNtTTRPRjl2SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPamczQ2lBZ0lDQXZMeUJsYldsMEtHNWxkeUJoY21NNE9GOVBkMjVsY25Ob2FYQlVjbUZ1YzJabGNsSmxjWFZsYzNSbFpDaDdJSEJ5WlhacGIzVnpYMjkzYm1WeU9pQjBhR2x6TG05M2JtVnlMblpoYkhWbExDQndaVzVrYVc1blgyOTNibVZ5T2lCd1pXNWthVzVuSUgwcEtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTJZbVl4WmpreElDOHZJRzFsZEdodlpDQWlZWEpqT0RoZlQzZHVaWEp6YUdsd1ZISmhibk5tWlhKU1pYRjFaWE4wWldRb1lXUmtjbVZ6Y3l4aFpHUnlaWE56S1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pvNlFYSmpPRGd1WVhKak9EaGZZV05qWlhCMFgyOTNibVZ5YzJocGNDZ3BJQzArSUhadmFXUTZDbUZ5WXpnNFgyRmpZMlZ3ZEY5dmQyNWxjbk5vYVhBNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pvNU1nb2dJQ0FnTHk4Z2RHaHBjeTVmWlc1emRYSmxSR1ZtWVhWc2RFOTNibVZ5S0NrS0lDQWdJR05oYkd4emRXSWdYMlZ1YzNWeVpVUmxabUYxYkhSUGQyNWxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZNVGdLSUNBZ0lDOHZJSEIxWW14cFl5QndaVzVrYVc1blQzZHVaWElnUFNCSGJHOWlZV3hUZEdGMFpUeGhjbU0wTGtGa1pISmxjM00rS0hzZ2EyVjVPaUFuWVhKak9EaGZjRzhuSUgwcElDOHZJRzl3ZEdsdmJtRnNJSFIzYnkxemRHVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaVlYSmpPRGhmY0c4aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pvNU13b2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVjR1Z1WkdsdVowOTNibVZ5TG1oaGMxWmhiSFZsTENBbmJtOTBYM0JsYm1ScGJtZGZiM2R1WlhJbktRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZEY5d1pXNWthVzVuWDI5M2JtVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6bzVOQW9nSUNBZ0x5OGdZMjl1YzNRZ2MyVnVaR1Z5SUQwZ2JtVjNJR0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sWTNWeWFYUjVYM1J2YTJWdUwyRnlZemc0TG1Gc1oyOHVkSE02TVRnS0lDQWdJQzh2SUhCMVlteHBZeUJ3Wlc1a2FXNW5UM2R1WlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHhoY21NMExrRmtaSEpsYzNNK0tIc2dhMlY1T2lBbllYSmpPRGhmY0c4bklIMHBJQzh2SUc5d2RHbHZibUZzSUhSM2J5MXpkR1Z3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTXlBdkx5QWlZWEpqT0RoZmNHOGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk9UVUtJQ0FnSUM4dklHRnpjMlZ5ZENoelpXNWtaWElnUFQwOUlIUm9hWE11Y0dWdVpHbHVaMDkzYm1WeUxuWmhiSFZsTENBbmJtOTBYM0JsYm1ScGJtZGZiM2R1WlhJbktRb2dJQ0FnWkdsbklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYm05MFgzQmxibVJwYm1kZmIzZHVaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPakUzQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdiM2R1WlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHhoY21NMExrRmtaSEpsYzNNK0tIc2dhMlY1T2lBbllYSmpPRGhmYnljZ2ZTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaGNtTTRPRjl2SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUZ5WXpnNFgyOGlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6bzVOd29nSUNBZ0x5OGdkR2hwY3k1dmQyNWxjaTUyWVd4MVpTQTlJSE5sYm1SbGNnb2dJQ0FnWkdsbklESUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVmpkWEpwZEhsZmRHOXJaVzR2WVhKak9EZ3VZV3huYnk1MGN6b3hPQW9nSUNBZ0x5OGdjSFZpYkdsaklIQmxibVJwYm1kUGQyNWxjaUE5SUVkc2IySmhiRk4wWVhSbFBHRnlZelF1UVdSa2NtVnpjejRvZXlCclpYazZJQ2RoY21NNE9GOXdieWNnZlNrZ0x5OGdiM0IwYVc5dVlXd2dkSGR2TFhOMFpYQUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltRnlZemc0WDNCdklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk9UZ0tJQ0FnSUM4dklIUm9hWE11Y0dWdVpHbHVaMDkzYm1WeUxuWmhiSFZsSUQwZ2JtVjNJR0Z5WXpRdVFXUmtjbVZ6Y3lncENpQWdJQ0JpZVhSbFkxOHlJQzh2SUdGa1pISWdRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFWazFTRVpMVVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU00T0M1aGJHZHZMblJ6T2prNUNpQWdJQ0F2THlCbGJXbDBLRzVsZHlCaGNtTTRPRjlQZDI1bGNuTm9hWEJVY21GdWMyWmxja0ZqWTJWd2RHVmtLSHNnY0hKbGRtbHZkWE5mYjNkdVpYSTZJSEJ5WlhacGIzVnpMQ0J1WlhkZmIzZHVaWEk2SUhObGJtUmxjaUI5S1NrS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFpqZGxNelppTXpjZ0x5OGdiV1YwYUc5a0lDSmhjbU00T0Y5UGQyNWxjbk5vYVhCVWNtRnVjMlpsY2tGalkyVndkR1ZrS0dGa1pISmxjM01zWVdSa2NtVnpjeWtpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WldOMWNtbDBlVjkwYjJ0bGJpOWhjbU00T0M1aGJHZHZMblJ6T2pFd01Bb2dJQ0FnTHk4Z1pXMXBkQ2h1WlhjZ1lYSmpPRGhmVDNkdVpYSnphR2x3VkhKaGJuTm1aWEp5WldRb2V5QndjbVYyYVc5MWMxOXZkMjVsY2pvZ2NISmxkbWx2ZFhNc0lHNWxkMTl2ZDI1bGNqb2djMlZ1WkdWeUlIMHBLUW9nSUNBZ1lubDBaV01nTVRBZ0x5OGdiV1YwYUc5a0lDSmhjbU00T0Y5UGQyNWxjbk5vYVhCVWNtRnVjMlpsY25KbFpDaGhaR1J5WlhOekxHRmtaSEpsYzNNcElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qcEJjbU00T0M1aGNtTTRPRjlqWVc1alpXeGZiM2R1WlhKemFHbHdYM0psY1hWbGMzUW9LU0F0UGlCMmIybGtPZ3BoY21NNE9GOWpZVzVqWld4ZmIzZHVaWEp6YUdsd1gzSmxjWFZsYzNRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWamRYSnBkSGxmZEc5clpXNHZZWEpqT0RndVlXeG5ieTUwY3pveE1EVUtJQ0FnSUM4dklIUm9hWE11WDJWdWMzVnlaVVJsWm1GMWJIUlBkMjVsY2lncENpQWdJQ0JqWVd4c2MzVmlJRjlsYm5OMWNtVkVaV1poZFd4MFQzZHVaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaV04xY21sMGVWOTBiMnRsYmk5aGNtTTRPQzVoYkdkdkxuUnpPakV3TmdvZ0lDQWdMeThnWVhOelpYSjBLRzVsZHlCaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtnUFQwOUlIUm9hWE11YjNkdVpYSXVkbUZzZFdVc0lDZHViM1JmYjNkdVpYSW5LUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk1UY0tJQ0FnSUM4dklIQjFZbXhwWXlCdmQyNWxjaUE5SUVkc2IySmhiRk4wWVhSbFBHRnlZelF1UVdSa2NtVnpjejRvZXlCclpYazZJQ2RoY21NNE9GOXZKeUI5S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUZ5WXpnNFgyOGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObFkzVnlhWFI1WDNSdmEyVnVMMkZ5WXpnNExtRnNaMjh1ZEhNNk1UQTJDaUFnSUNBdkx5QmhjM05sY25Rb2JtVjNJR0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTQTlQVDBnZEdocGN5NXZkMjVsY2k1MllXeDFaU3dnSjI1dmRGOXZkMjVsY2ljcENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZEY5dmQyNWxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxZM1Z5YVhSNVgzUnZhMlZ1TDJGeVl6ZzRMbUZzWjI4dWRITTZNVGdLSUNBZ0lDOHZJSEIxWW14cFl5QndaVzVrYVc1blQzZHVaWElnUFNCSGJHOWlZV3hUZEdGMFpUeGhjbU0wTGtGa1pISmxjM00rS0hzZ2EyVjVPaUFuWVhKak9EaGZjRzhuSUgwcElDOHZJRzl3ZEdsdmJtRnNJSFIzYnkxemRHVndDaUFnSUNCaWVYUmxZMTh6SUM4dklDSmhjbU00T0Y5d2J5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXTjFjbWwwZVY5MGIydGxiaTloY21NNE9DNWhiR2R2TG5Sek9qRXdOd29nSUNBZ0x5OGdkR2hwY3k1d1pXNWthVzVuVDNkdVpYSXVkbUZzZFdVZ1BTQnVaWGNnWVhKak5DNUJaR1J5WlhOektDa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z1lXUmtjaUJCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJXVFZJUmt0UkNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnY21WMGMzVmlDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFFQUFFZ0NDWUxCMkZ5WXpnNFgyOEVGUjk4ZFNBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQWhoY21NNE9GOXdid2hoY21NNE9GOXZhUUZpQVhRQmdBRUFCSG1EdzF3RVExWFNyVEViUVFIRmdoSUVsMU9DNGdSbGZSUHNCTGF1R2lVRWhPd1QxUVRzbVdCQkJJTGxjOFFFMm5BbHVRUktsbytQQkxWQ0lTVUV1N01aOHdRSEFtVk9CTkFWY2s0RUFwL3N3QVJ6U1ROT0JOdDhndThFL1N3c2JnUkNwZkJsQksxUGFPbzJHZ0NPRWdFa0FSUUJCQUQwQU9RQTBRQzdBS0lBakFCMkFHWUFVd0JFQURVQUtRQWFBQTRBQWlKRE1Sa1VSREVZUklnRUdDTkRNUmtVUkRFWVJJZ0QzQ05ETVJrVVJERVlSRFlhQVlnRGxTTkRNUmtVUkRFWVJJZ0RiU05ETVJrVVJERVlSRFlhQVlnRE9pTkRNUmtVUkRFWVJEWWFBWWdDL1NORE1Sa1VSREVZUkRZYUFZZ0N3eWxNVUxBalF6RVpGRVF4R0VTSUFxc3BURkN3STBNeEdSUkVNUmhFTmhvQk5ob0NpQUdZS1V4UXNDTkRNUmtVUkRFWVJEWWFBVFlhQW9nQmRTbE1VTEFqUXpFWkZFUXhHRVEyR2dFMkdnSTJHZ09JQVM0cFRGQ3dJME14R1JSRU1SaEVOaG9CTmhvQ2lBRUxLVXhRc0NORE1Sa1VSREVZUkRZYUFZZ0E3eWxNVUxBalF6RVpGRVF4R0VTSUFOa3BURkN3STBNeEdSUkVNUmhFaUFEQ0tVeFFzQ05ETVJrVVJERVlSSWdBb3lsTVVMQWpRekVaRkVReEdFU0lBSVFwVEZDd0kwTXhHUlJFTVJoRU5ob0JOaG9DTmhvRE5ob0VpQUFSS1V4UXNDTkRNUmxBL3JzeEdCUkVJME9LQkFFeEFESUpFa1NML0ZjQ0FCVkpSQ1FPUkl2OVZ3SUFGVWxFSlE1RUlpY0daVVVCRkVTQUFXNkwvR2VBQVhPTC9XY25Cb3YvWjRBQlpJditaekVBSndWTEFWQ0wvNzh5QTB4UWkvOVFKd2xNVUxBbkI0a2lnQUZ1WlVSWEFnQkpGU1FTUklraWdBRnpaVVJYQWdCSkZTVVNSSWtpZ0FGa1pVU0pJaWNHWlVTSmlnRUJpLytJQUZTSmlnSUJNUUNML292L2lBQmZpWW9EQVRFQWkvMUxBWWdBdDBtTC82ZEVpLytoU1JVa0RrUWtyNnVML1U0Q2lBRENTSXY5aS82TC80Z0FNWW1LQWdFeEFJditpLytJQUt1SmlnSUJpLzZMLzRnQWZvbUtBUUVuQll2L1VFbTlSUUZBQUFNcVRJbUxBTDVFVEltS0F3R0wvWWovNEVtTC9vai8ya3lMLzZkRWkvMkwvaE5CQUNtTEFJdi9vVWtWSkE1RUpLOU1Td0dySndXTC9WQk12NHNCaS8rZ1NSVWtEa1NySndXTC9sQk12NHY5aS81UWkvOVFKd2xNVUxBbkI0d0FpWW9DQVl2K2kvOVFBVWtWSkJKRWlZb0NBWXYraS8rSS8rZUFBV0ZNVUVtOVJRRkFBQU1xVEltTEFMNUVWd0FnVEltS0F3R0wvWXYraVAvRmkvK0wvVkNML2xDQUFXRlBBbEJNdjR2OWkvNVFpLzlRZ0FRWmFmaGxURkN3SndlSklpY0VaVVVCUVFBSklpY0VaVVFYUUFBU0lpaGxSUUZBQUFRb01nbG5Kd1NBQVFGbmlZai8yQ0lvWlVTSmlnRUJpUC9OSWlobFJRRkFBQU1uQ0lraUtHVkVLaEpCQUFNbkNJa2lLR1ZFaS84U0p3Z2lUd0pVaVlvQkFDSW5CR1ZGQVVFQUhpSW5CR1ZFRnlNU1FRQVRJeFJFaS84cUUwUW9pLzluSndTQUFRRm5pU0pDLytxS0FRQ0kvM1F4QUNJb1pVUVNSSXYvS2hORUlpaGxSQ2lMLzJlTC8xQW5Da3hRc0ltSS8xTXhBQ0lvWlVRU1JDSW9aVVFvS21lQUJEUnFvV1pNVUxDSmlnRUFpUDgwTVFBaUtHVkVFa1NML3lvVFJDSXJaVVVCUVFBSUlpdGxSQ29URkVRcmkvOW5JaWhsUkl2L1VJQUVGcjhma1V4UXNJbUkvdjhpSzJWRkFVUXhBQ0lyWlVSTEFSSkVJaWhsUkNoTEFtY3JLbWRNVUlBRTkrTnJOMHNCVUxBbkNreFFzSW1JL3M4eEFDSW9aVVFTUkNzcVo0az0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo3LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOlt7Im5hbWUiOiJhcmMyMDBfVHJhbnNmZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6ImFyYzIwMF9BcHByb3ZhbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3BlbmRlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiYXJjODhfT3duZXJzaGlwVHJhbnNmZXJyZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByZXZpb3VzX293bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19vd25lciIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiYXJjODhfT3duZXJzaGlwUmVub3VuY2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmV2aW91c19vd25lciIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiYXJjODhfT3duZXJzaGlwVHJhbnNmZXJSZXF1ZXN0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByZXZpb3VzX293bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBlbmRpbmdfb3duZXIiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6ImFyYzg4X093bmVyc2hpcFRyYW5zZmVyQWNjZXB0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByZXZpb3VzX293bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19vd25lciIsImRlc2MiOm51bGx9XX1dLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
