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

namespace Arc56.Generated.Marshal_AM.x500_algorand.X500Pool_cf5cfb02
{


    public class X500PoolProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public X500PoolProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class BalanceOfReturn : AVMObjectType
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

                public static BalanceOfReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new BalanceOfReturn();
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
                    return Equals(obj as BalanceOfReturn);
                }
                public bool Equals(BalanceOfReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(BalanceOfReturn left, BalanceOfReturn right)
                {
                    return EqualityComparer<BalanceOfReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(BalanceOfReturn left, BalanceOfReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="settlerAppId"> </param>
        public async Task Init(ulong settlerAppId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 205, 229, 45 };
            var settlerAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); settlerAppIdAbi.From(settlerAppId);

            var result = await base.CallApp(new List<object> { abiHandle, settlerAppIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Init_Transactions(ulong settlerAppId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 205, 229, 45 };
            var settlerAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); settlerAppIdAbi.From(settlerAppId);

            return await base.MakeTransactionList(new List<object> { abiHandle, settlerAppIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Opt the pool app into testnet USDC (zero-amount self-transfer).
        ///</summary>
        public async Task OptInUsdc(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 183, 52, 213, 214 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptInUsdc_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 183, 52, 213, 214 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="slug"> </param>
        public async Task TopUp(byte[] slug, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 96, 64, 56, 190 };
            var slugAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(16, "byte"); slugAbi.From(slug);

            var result = await base.CallApp(new List<object> { abiHandle, slugAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TopUp_Transactions(byte[] slug, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 96, 64, 56, 190 };
            var slugAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(16, "byte"); slugAbi.From(slug);

            return await base.MakeTransactionList(new List<object> { abiHandle, slugAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task DepositEscrow(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 163, 130, 43, 239 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DepositEscrow_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 163, 130, 43, 239 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agent"> </param>
        public async Task<ulong> EscrowOf(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 174, 27, 3 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            var result = await base.SimApp(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> EscrowOf_Transactions(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 174, 27, 3 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="slug"> </param>
        public async Task<Structs.BalanceOfReturn> BalanceOf(byte[] slug, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 90, 105, 226, 183 };
            var slugAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(16, "byte"); slugAbi.From(slug);

            var result = await base.SimApp(new List<object> { abiHandle, slugAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.BalanceOfReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> BalanceOf_Transactions(byte[] slug, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 90, 105, 226, 183 };
            var slugAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(16, "byte"); slugAbi.From(slug);

            return await base.MakeTransactionList(new List<object> { abiHandle, slugAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="slug"> </param>
        /// <param name="agent"> </param>
        /// <param name="premium"> </param>
        /// <param name="refund"> </param>
        /// <param name="breach"> </param>
        public async Task ApplySettlement(byte[] slug, Algorand.Address agent, ulong premium, ulong refund, bool breach, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 30, 174, 222, 25 };
            var slugAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(16, "byte"); slugAbi.From(slug);
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);
            var premiumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); premiumAbi.From(premium);
            var refundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); refundAbi.From(refund);
            var breachAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); breachAbi.From(breach);

            var result = await base.CallApp(new List<object> { abiHandle, slugAbi, agentAbi, premiumAbi, refundAbi, breachAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ApplySettlement_Transactions(byte[] slug, Algorand.Address agent, ulong premium, ulong refund, bool breach, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 30, 174, 222, 25 };
            var slugAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(16, "byte"); slugAbi.From(slug);
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);
            var premiumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); premiumAbi.From(premium);
            var refundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); refundAbi.From(refund);
            var breachAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); breachAbi.From(breach);

            return await base.MakeTransactionList(new List<object> { abiHandle, slugAbi, agentAbi, premiumAbi, refundAbi, breachAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiWDUwMFBvb2wiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQmFsYW5jZU9mUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiaW5pdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZXR0bGVyQXBwSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3B0X2luX3VzZGMiLCJkZXNjIjoiT3B0IHRoZSBwb29sIGFwcCBpbnRvIHRlc3RuZXQgVVNEQyAoemVyby1hbW91bnQgc2VsZi10cmFuc2ZlcikuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRvcF91cCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFsxNl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzbHVnIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlcG9zaXRfZXNjcm93IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImVzY3Jvd19vZiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJhbGFuY2Vfb2YiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMTZdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2x1ZyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJCYWxhbmNlT2ZSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFwcGx5X3NldHRsZW1lbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMTZdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2x1ZyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFnZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmVtaXVtIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWZ1bmQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJicmVhY2giLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjMsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls1MTddLCJlcnJvck1lc3NhZ2UiOiJCb3ggbXVzdCBoYXZlIHZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU3XSwiZXJyb3JNZXNzYWdlIjoiYWxyZWFkeSBpbml0aWFsaXplZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ1Ml0sImVycm9yTWVzc2FnZSI6ImFwcGxpY2F0aW9uIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzMiwyODVdLCJlcnJvck1lc3NhZ2UiOiJhc3NlcnQgdGFyZ2V0IGlzIG1hdGNoIGZvciBjb25kaXRpb25zIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU1LDE2OSwyMDMsMjU3LDMxNCwzNzIsNDQyLDQ0OSw0ODFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDcsMjYxXSwiZXJyb3JNZXNzYWdlIjoiZ3JvdXBlZCBheGZlciByZXF1aXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ3Ml0sImVycm9yTWVzc2FnZSI6Imluc3VmZmljaWVudCBlc2Nyb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MjZdLCJlcnJvck1lc3NhZ2UiOiJpbnN1ZmZpY2llbnQgcG9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQzNl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmJvb2wiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTksMzYwLDM5NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAxNj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMzIsNDA2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1MCw0MTUsNDI1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTcwLDIwNCwyNTgsNDQzXSwiZXJyb3JNZXNzYWdlIjoibm90IGluaXRpYWxpemVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDU0XSwiZXJyb3JNZXNzYWdlIjoibm90IHNldHRsZXIgYXBwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjE3LDI2N10sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgYXhmZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzgsMjkxXSwiZXJyb3JNZXNzYWdlIjoid3JvbmcgYXNzZXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJREV3TkRVNE9UUXhJRFFLSUNBZ0lHSjVkR1ZqWW14dlkyc2dJbWx1YVhScFlXeHBlbVZrSWlBaWRHOTBZV3hGYzJOeWIzY2lJQ0psSWlBaWMyVjBkR3hsY2tGd2NDSWdNSGd4TlRGbU4yTTNOUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxZzFNREJRYjI5c0xtRnNaMjh1ZEhNNk1qVUtJQ0FnSUM4dklIUnZkR0ZzUlhOamNtOTNJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHbHVhWFJwWVd4V1lXeDFaVG9nVldsdWREWTBLREFwSUgwcE93b2dJQ0FnWW5sMFpXTmZNU0F2THlBaWRHOTBZV3hGYzJOeWIzY2lDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVlOVEF3VUc5dmJDNWhiR2R2TG5Sek9qSTJDaUFnSUNBdkx5QnBibWwwYVdGc2FYcGxaQ0E5SUVkc2IySmhiRk4wWVhSbFBHSnZiMnhsWVc0K0tIc2dhVzVwZEdsaGJGWmhiSFZsT2lCbVlXeHpaU0I5S1RzS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1sdWFYUnBZV3hwZW1Wa0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlZTlRBd1VHOXZiQzVoYkdkdkxuUnpPakl6Q2lBZ0lDQXZMeUJsZUhCdmNuUWdaR1ZtWVhWc2RDQmpiR0Z6Y3lCWU5UQXdVRzl2YkNCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpVQXhOZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRNV0pqWkdVMU1tUWdNSGhpTnpNMFpEVmtOaUF3ZURZd05EQXpPR0psSURCNFlUTTRNakppWldZZ01IZzRNMkZsTVdJd015QXdlRFZoTmpsbE1tSTNJREI0TVdWaFpXUmxNVGtnTHk4Z2JXVjBhRzlrSUNKcGJtbDBLSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKdmNIUmZhVzVmZFhOa1l5Z3BkbTlwWkNJc0lHMWxkR2h2WkNBaWRHOXdYM1Z3S0hWcGJuUTRXekUyWFNsMmIybGtJaXdnYldWMGFHOWtJQ0prWlhCdmMybDBYMlZ6WTNKdmR5Z3BkbTlwWkNJc0lHMWxkR2h2WkNBaVpYTmpjbTkzWDI5bUtHRmtaSEpsYzNNcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKaVlXeGhibU5sWDI5bUtIVnBiblE0V3pFMlhTa29kV2x1ZERZMExIVnBiblEyTkNraUxDQnRaWFJvYjJRZ0ltRndjR3g1WDNObGRIUnNaVzFsYm5Rb2RXbHVkRGhiTVRaZExHRmtaSEpsYzNNc2RXbHVkRFkwTEhWcGJuUTJOQ3hpYjI5c0tYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCcGJtbDBJRzl3ZEVsdVZYTmtZeUIwYjNCVmNDQmtaWEJ2YzJsMFJYTmpjbTkzSUdWelkzSnZkMDltSUdKaGJHRnVZMlZQWmlCaGNIQnNlVk5sZEhSc1pXMWxiblFLSUNBZ0lHVnljZ29LYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU1UWTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZXRFV3TUZCdmIyd3VZV3huYnk1MGN6b3lNd29nSUNBZ0x5OGdaWGh3YjNKMElHUmxabUYxYkhRZ1kyeGhjM01nV0RVd01GQnZiMndnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdKaVlLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR052Ym5SeVlXTjBjeTlZTlRBd1VHOXZiQzVoYkdkdkxuUnpPanBZTlRBd1VHOXZiQzVwYm1sMFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0thVzVwZERvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5WU5UQXdVRzl2YkM1aGJHZHZMblJ6T2pNeENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2dibUZ0WlRvZ0ltbHVhWFFpSUgwcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxZzFNREJRYjI5c0xtRnNaMjh1ZEhNNk16TUtJQ0FnSUM4dklHRnpjMlZ5ZENnaGRHaHBjeTVwYm1sMGFXRnNhWHBsWkM1MllXeDFaU3dnSW1Gc2NtVmhaSGtnYVc1cGRHbGhiR2w2WldRaUtUc0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdldEVXdNRkJ2YjJ3dVlXeG5ieTUwY3pveU5nb2dJQ0FnTHk4Z2FXNXBkR2xoYkdsNlpXUWdQU0JIYkc5aVlXeFRkR0YwWlR4aWIyOXNaV0Z1UGloN0lHbHVhWFJwWVd4V1lXeDFaVG9nWm1Gc2MyVWdmU2s3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pwYm1sMGFXRnNhWHBsWkNJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5WU5UQXdVRzl2YkM1aGJHZHZMblJ6T2pNekNpQWdJQ0F2THlCaGMzTmxjblFvSVhSb2FYTXVhVzVwZEdsaGJHbDZaV1F1ZG1Gc2RXVXNJQ0poYkhKbFlXUjVJR2x1YVhScFlXeHBlbVZrSWlrN0NpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHRnNjbVZoWkhrZ2FXNXBkR2xoYkdsNlpXUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVlOVEF3VUc5dmJDNWhiR2R2TG5Sek9qSTBDaUFnSUNBdkx5QnpaWFIwYkdWeVFYQndJRDBnUjJ4dlltRnNVM1JoZEdVOFFYQndiR2xqWVhScGIyNCtLQ2s3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0p6WlhSMGJHVnlRWEJ3SWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFnMU1EQlFiMjlzTG1Gc1oyOHVkSE02TXpRS0lDQWdJQzh2SUhSb2FYTXVjMlYwZEd4bGNrRndjQzUyWVd4MVpTQTlJSE5sZEhSc1pYSkJjSEJKWkRzS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdldEVXdNRkJ2YjJ3dVlXeG5ieTUwY3pveU5nb2dJQ0FnTHk4Z2FXNXBkR2xoYkdsNlpXUWdQU0JIYkc5aVlXeFRkR0YwWlR4aWIyOXNaV0Z1UGloN0lHbHVhWFJwWVd4V1lXeDFaVG9nWm1Gc2MyVWdmU2s3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pwYm1sMGFXRnNhWHBsWkNJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5WU5UQXdVRzl2YkM1aGJHZHZMblJ6T2pNMUNpQWdJQ0F2THlCMGFHbHpMbWx1YVhScFlXeHBlbVZrTG5aaGJIVmxJRDBnZEhKMVpUc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxZzFNREJRYjI5c0xtRnNaMjh1ZEhNNk16RUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ1WVcxbE9pQWlhVzVwZENJZ2ZTa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCamIyNTBjbUZqZEhNdldEVXdNRkJ2YjJ3dVlXeG5ieTUwY3pvNldEVXdNRkJ2YjJ3dWIzQjBTVzVWYzJSalczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tiM0IwU1c1VmMyUmpPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMWcxTURCUWIyOXNMbUZzWjI4dWRITTZOREVLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1sdWFYUnBZV3hwZW1Wa0xuWmhiSFZsTENBaWJtOTBJR2x1YVhScFlXeHBlbVZrSWlrN0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFnMU1EQlFiMjlzTG1Gc1oyOHVkSE02TWpZS0lDQWdJQzh2SUdsdWFYUnBZV3hwZW1Wa0lEMGdSMnh2WW1Gc1UzUmhkR1U4WW05dmJHVmhiajRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJR1poYkhObElIMHBPd29nSUNBZ1lubDBaV05mTUNBdkx5QWlhVzVwZEdsaGJHbDZaV1FpQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12V0RVd01GQnZiMnd1WVd4bmJ5NTBjem8wTVFvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdWFXNXBkR2xoYkdsNlpXUXVkbUZzZFdVc0lDSnViM1FnYVc1cGRHbGhiR2w2WldRaUtUc0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0JoYzNObGNuUWdMeThnYm05MElHbHVhWFJwWVd4cGVtVmtDaUFnSUNBdkx5QmpiMjUwY21GamRITXZXRFV3TUZCdmIyd3VZV3huYnk1MGN6bzBNaTAwT1FvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVZWE56WlhSVWNtRnVjMlpsY2loN0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSU1pXTmxhWFpsY2pvZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxja0Z6YzJWME9pQlZVMFJEWDFSRlUxUk9SVlJmUVZOQlgwbEVMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBRVzF2ZFc1ME9pQlZhVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnWm1WbE9pQlZhVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQXZMeUFnSUM1emRXSnRhWFFvS1RzS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlZTlRBd1VHOXZiQzVoYkdkdkxuUnpPalEwQ2lBZ0lDQXZMeUJoYzNObGRGSmxZMlZwZG1WeU9pQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdldEVXdNRkJ2YjJ3dVlXeG5ieTUwY3pvME5nb2dJQ0FnTHk4Z1lYTnpaWFJCYlc5MWJuUTZJRlZwYm5RMk5DZ3dLU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwUVcxdmRXNTBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZXRFV3TUZCdmIyd3VZV3huYnk1MGN6bzBOUW9nSUNBZ0x5OGdlR1psY2tGemMyVjBPaUJWVTBSRFgxUkZVMVJPUlZSZlFWTkJYMGxFTEFvZ0lDQWdhVzUwWTE4eUlDOHZJREV3TkRVNE9UUXhDaUFnSUNCcGRIaHVYMlpwWld4a0lGaG1aWEpCYzNObGRBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRkpsWTJWcGRtVnlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZXRFV3TUZCdmIyd3VZV3huYnk1MGN6bzBNaTAwT0FvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVZWE56WlhSVWNtRnVjMlpsY2loN0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSU1pXTmxhWFpsY2pvZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxja0Z6YzJWME9pQlZVMFJEWDFSRlUxUk9SVlJmUVZOQlgwbEVMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBRVzF2ZFc1ME9pQlZhVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnWm1WbE9pQlZhVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdOQW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxZzFNREJRYjI5c0xtRnNaMjh1ZEhNNk5EY0tJQ0FnSUM4dklHWmxaVG9nVldsdWREWTBLREFwTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12V0RVd01GQnZiMnd1WVd4bmJ5NTBjem8wTWkwME9Rb2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1WVhOelpYUlVjbUZ1YzJabGNpaDdDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUlNaV05sYVhabGNqb2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdlR1psY2tGemMyVjBPaUJWVTBSRFgxUkZVMVJPUlZSZlFWTkJYMGxFTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwUVcxdmRXNTBPaUJWYVc1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxPaUJWYVc1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0F2THlBZ0lDNXpkV0p0YVhRb0tUc0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdldEVXdNRkJ2YjJ3dVlXeG5ieTUwY3pvek9Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJRzVoYldVNklDSnZjSFJmYVc1ZmRYTmtZeUlnZlNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJqYjI1MGNtRmpkSE12V0RVd01GQnZiMnd1WVd4bmJ5NTBjem82V0RVd01GQnZiMnd1ZEc5d1ZYQmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AwYjNCVmNEb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVlOVEF3VUc5dmJDNWhiR2R2TG5Sek9qVXlDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnYm1GdFpUb2dJblJ2Y0Y5MWNDSWdmU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURFMkNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBeE5qNEtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVlOVEF3VUc5dmJDNWhiR2R2TG5Sek9qVTBDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTVwYm1sMGFXRnNhWHBsWkM1MllXeDFaU3dnSW01dmRDQnBibWwwYVdGc2FYcGxaQ0lwT3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlZTlRBd1VHOXZiQzVoYkdkdkxuUnpPakkyQ2lBZ0lDQXZMeUJwYm1sMGFXRnNhWHBsWkNBOUlFZHNiMkpoYkZOMFlYUmxQR0p2YjJ4bFlXNCtLSHNnYVc1cGRHbGhiRlpoYkhWbE9pQm1ZV3h6WlNCOUtUc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltbHVhWFJwWVd4cGVtVmtJZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMWcxTURCUWIyOXNMbUZzWjI4dWRITTZOVFFLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1sdWFYUnBZV3hwZW1Wa0xuWmhiSFZsTENBaWJtOTBJR2x1YVhScFlXeHBlbVZrSWlrN0NpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCcGJtbDBhV0ZzYVhwbFpBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxZzFNREJRYjI5c0xtRnNaMjh1ZEhNNk5UVUtJQ0FnSUM4dklHRnpjMlZ5ZENoVWVHNHVaM0p2ZFhCSmJtUmxlQ0ErSUZWcGJuUTJOQ2d3S1N3Z0ltZHliM1Z3WldRZ1lYaG1aWElnY21WeGRXbHlaV1FpS1RzS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JoYzNObGNuUWdMeThnWjNKdmRYQmxaQ0JoZUdabGNpQnlaWEYxYVhKbFpBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxZzFNREJRYjI5c0xtRnNaMjh1ZEhNNk5UWUtJQ0FnSUM4dklHTnZibk4wSUdGNFptVnlJRDBnWjNSNGJpNUJjM05sZEZSeVlXNXpabVZ5VkhodUtGUjRiaTVuY205MWNFbHVaR1Y0SUMwZ1ZXbHVkRFkwS0RFcEtUc0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4eklDOHZJR0Y0Wm1WeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFJ5WVc1ellXTjBhVzl1SUhSNWNHVWdhWE1nWVhobVpYSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVlOVEF3VUc5dmJDNWhiR2R2TG5Sek9qVTNMVFl3Q2lBZ0lDQXZMeUJoYzNObGNuUk5ZWFJqYUNoaGVHWmxjaXdnZXdvZ0lDQWdMeThnSUNCaGMzTmxkRkpsWTJWcGRtVnlPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdZWE56WlhSQmJXOTFiblE2SUhzZ1ozSmxZWFJsY2xSb1lXNDZJRlZwYm5RMk5DZ3dLU0I5TEFvZ0lDQWdMeThnZlNrN0NpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklFRnpjMlYwVW1WalpXbDJaWElLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlZTlRBd1VHOXZiQzVoYkdkdkxuUnpPalU0Q2lBZ0lDQXZMeUJoYzNObGRGSmxZMlZwZG1WeU9pQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdldEVXdNRkJ2YjJ3dVlXeG5ieTUwY3pvMU55MDJNQW9nSUNBZ0x5OGdZWE56WlhKMFRXRjBZMmdvWVhobVpYSXNJSHNLSUNBZ0lDOHZJQ0FnWVhOelpYUlNaV05sYVhabGNqb2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lHRnpjMlYwUVcxdmRXNTBPaUI3SUdkeVpXRjBaWEpVYUdGdU9pQlZhVzUwTmpRb01Da2dmU3dLSUNBZ0lDOHZJSDBwT3dvZ0lDQWdQVDBLSUNBZ0lHUnBaeUF4Q2lBZ0lDQm5kSGh1Y3lCQmMzTmxkRUZ0YjNWdWRBb2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUWdMeThnWVhOelpYSjBJSFJoY21kbGRDQnBjeUJ0WVhSamFDQm1iM0lnWTI5dVpHbDBhVzl1Y3dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFnMU1EQlFiMjlzTG1Gc1oyOHVkSE02TmpFS0lDQWdJQzh2SUdGemMyVnlkQ2hoZUdabGNpNTRabVZ5UVhOelpYUXVhV1FnUFQwOUlGVlRSRU5mVkVWVFZFNUZWRjlCVTBGZlNVUXNJQ0ozY205dVp5QmhjM05sZENJcE93b2dJQ0FnYzNkaGNBb2dJQ0FnWjNSNGJuTWdXR1psY2tGemMyVjBDaUFnSUNCcGJuUmpYeklnTHk4Z01UQTBOVGc1TkRFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkM0p2Ym1jZ1lYTnpaWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlZTlRBd1VHOXZiQzVoYkdkdkxuUnpPall5Q2lBZ0lDQXZMeUJqYjI1emRDQmpkWEp5Wlc1MElEMGdkR2hwY3k1d2IyOXNRbUZzWVc1alpYTW9jMngxWnlrdVoyVjBLSHNnWkdWbVlYVnNkRG9nVldsdWREWTBLREFwSUgwcE93b2dJQ0FnWkdsbklERUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lITjNZWEFLSUNBZ0lHSjBiMmtLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCemQyRndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxZzFNREJRYjI5c0xtRnNaMjh1ZEhNNk5qTUtJQ0FnSUM4dklIUm9hWE11Y0c5dmJFSmhiR0Z1WTJWektITnNkV2NwTG5aaGJIVmxJRDBnWTNWeWNtVnVkQ0FySUdGNFptVnlMbUZ6YzJWMFFXMXZkVzUwT3dvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFnMU1EQlFiMjlzTG1Gc1oyOHVkSE02TlRJS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnVZVzFsT2lBaWRHOXdYM1Z3SWlCOUtRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdOdmJuUnlZV04wY3k5WU5UQXdVRzl2YkM1aGJHZHZMblJ6T2pwWU5UQXdVRzl2YkM1a1pYQnZjMmwwUlhOamNtOTNXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWkdWd2IzTnBkRVZ6WTNKdmR6b0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVlOVEF3VUc5dmJDNWhiR2R2TG5Sek9qWTRDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTVwYm1sMGFXRnNhWHBsWkM1MllXeDFaU3dnSW01dmRDQnBibWwwYVdGc2FYcGxaQ0lwT3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlZTlRBd1VHOXZiQzVoYkdkdkxuUnpPakkyQ2lBZ0lDQXZMeUJwYm1sMGFXRnNhWHBsWkNBOUlFZHNiMkpoYkZOMFlYUmxQR0p2YjJ4bFlXNCtLSHNnYVc1cGRHbGhiRlpoYkhWbE9pQm1ZV3h6WlNCOUtUc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltbHVhWFJwWVd4cGVtVmtJZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMWcxTURCUWIyOXNMbUZzWjI4dWRITTZOamdLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1sdWFYUnBZV3hwZW1Wa0xuWmhiSFZsTENBaWJtOTBJR2x1YVhScFlXeHBlbVZrSWlrN0NpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCcGJtbDBhV0ZzYVhwbFpBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxZzFNREJRYjI5c0xtRnNaMjh1ZEhNNk5qa0tJQ0FnSUM4dklHRnpjMlZ5ZENoVWVHNHVaM0p2ZFhCSmJtUmxlQ0ErSUZWcGJuUTJOQ2d3S1N3Z0ltZHliM1Z3WldRZ1lYaG1aWElnY21WeGRXbHlaV1FpS1RzS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JoYzNObGNuUWdMeThnWjNKdmRYQmxaQ0JoZUdabGNpQnlaWEYxYVhKbFpBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxZzFNREJRYjI5c0xtRnNaMjh1ZEhNNk56QUtJQ0FnSUM4dklHTnZibk4wSUdGNFptVnlJRDBnWjNSNGJpNUJjM05sZEZSeVlXNXpabVZ5VkhodUtGVnBiblEyTkNnd0tTazdDaUFnSUNCbmRIaHVJREFnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTXlBdkx5QmhlR1psY2dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjBjbUZ1YzJGamRHbHZiaUIwZVhCbElHbHpJR0Y0Wm1WeUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdldEVXdNRkJ2YjJ3dVlXeG5ieTUwY3pvM01TMDNOUW9nSUNBZ0x5OGdZWE56WlhKMFRXRjBZMmdvWVhobVpYSXNJSHNLSUNBZ0lDOHZJQ0FnWVhOelpYUlNaV05sYVhabGNqb2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lITmxibVJsY2pvZ1ZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdZWE56WlhSQmJXOTFiblE2SUhzZ1ozSmxZWFJsY2xSb1lXNDZJRlZwYm5RMk5DZ3dLU0I5TEFvZ0lDQWdMeThnZlNrN0NpQWdJQ0JuZEhodUlEQWdRWE56WlhSU1pXTmxhWFpsY2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFnMU1EQlFiMjlzTG1Gc1oyOHVkSE02TnpJS0lDQWdJQzh2SUdGemMyVjBVbVZqWldsMlpYSTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVlOVEF3VUc5dmJDNWhiR2R2TG5Sek9qY3hMVGMxQ2lBZ0lDQXZMeUJoYzNObGNuUk5ZWFJqYUNoaGVHWmxjaXdnZXdvZ0lDQWdMeThnSUNCaGMzTmxkRkpsWTJWcGRtVnlPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdjMlZ1WkdWeU9pQlVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0JoYzNObGRFRnRiM1Z1ZERvZ2V5Qm5jbVZoZEdWeVZHaGhiam9nVldsdWREWTBLREFwSUgwc0NpQWdJQ0F2THlCOUtUc0tJQ0FnSUQwOUNpQWdJQ0JuZEhodUlEQWdVMlZ1WkdWeUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdldEVXdNRkJ2YjJ3dVlXeG5ieTUwY3pvM013b2dJQ0FnTHk4Z2MyVnVaR1Z5T2lCVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFnMU1EQlFiMjlzTG1Gc1oyOHVkSE02TnpFdE56VUtJQ0FnSUM4dklHRnpjMlZ5ZEUxaGRHTm9LR0Y0Wm1WeUxDQjdDaUFnSUNBdkx5QWdJR0Z6YzJWMFVtVmpaV2wyWlhJNklFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TEFvZ0lDQWdMeThnSUNCelpXNWtaWEk2SUZSNGJpNXpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lHRnpjMlYwUVcxdmRXNTBPaUI3SUdkeVpXRjBaWEpVYUdGdU9pQlZhVzUwTmpRb01Da2dmU3dLSUNBZ0lDOHZJSDBwT3dvZ0lDQWdQVDBLSUNBZ0lDWW1DaUFnSUNCbmRIaHVJREFnUVhOelpYUkJiVzkxYm5RS0lDQWdJQ1ltQ2lBZ0lDQmhjM05sY25RZ0x5OGdZWE56WlhKMElIUmhjbWRsZENCcGN5QnRZWFJqYUNCbWIzSWdZMjl1WkdsMGFXOXVjd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMWcxTURCUWIyOXNMbUZzWjI4dWRITTZOellLSUNBZ0lDOHZJR0Z6YzJWeWRDaGhlR1psY2k1NFptVnlRWE56WlhRdWFXUWdQVDA5SUZWVFJFTmZWRVZUVkU1RlZGOUJVMEZmU1VRc0lDSjNjbTl1WnlCaGMzTmxkQ0lwT3dvZ0lDQWdaM1I0YmlBd0lGaG1aWEpCYzNObGRBb2dJQ0FnYVc1MFkxOHlJQzh2SURFd05EVTRPVFF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIZHliMjVuSUdGemMyVjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZXRFV3TUZCdmIyd3VZV3huYnk1MGN6b3lPUW9nSUNBZ0x5OGdaWE5qY205M1FtRnNZVzVqWlhNZ1BTQkNiM2hOWVhBOFFXTmpiM1Z1ZEN3Z2RXbHVkRFkwUGloN0lHdGxlVkJ5WldacGVEb2dJbVVpSUgwcE93b2dJQ0FnWW5sMFpXTmZNaUF2THlBaVpTSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVlOVEF3VUc5dmJDNWhiR2R2TG5Sek9qYzNDaUFnSUNBdkx5QmpiMjV6ZENCaFoyVnVkQ0E5SUZSNGJpNXpaVzVrWlhJN0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12V0RVd01GQnZiMnd1WVd4bmJ5NTBjem95T1FvZ0lDQWdMeThnWlhOamNtOTNRbUZzWVc1alpYTWdQU0JDYjNoTllYQThRV05qYjNWdWRDd2dkV2x1ZERZMFBpaDdJR3RsZVZCeVpXWnBlRG9nSW1VaUlIMHBPd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12V0RVd01GQnZiMnd1WVd4bmJ5NTBjem8zT0FvZ0lDQWdMeThnWTI5dWMzUWdZM1Z5Y21WdWRDQTlJSFJvYVhNdVpYTmpjbTkzUW1Gc1lXNWpaWE1vWVdkbGJuUXBMbWRsZENoN0lHUmxabUYxYkhRNklGVnBiblEyTkNnd0tTQjlLVHNLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZblJ2YVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lITjNZWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZXRFV3TUZCdmIyd3VZV3huYnk1MGN6bzNPUW9nSUNBZ0x5OGdkR2hwY3k1bGMyTnliM2RDWVd4aGJtTmxjeWhoWjJWdWRDa3VkbUZzZFdVZ1BTQmpkWEp5Wlc1MElDc2dZWGhtWlhJdVlYTnpaWFJCYlc5MWJuUTdDaUFnSUNCbmRIaHVJREFnUVhOelpYUkJiVzkxYm5RS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5WU5UQXdVRzl2YkM1aGJHZHZMblJ6T2pnd0NpQWdJQ0F2THlCMGFHbHpMblJ2ZEdGc1JYTmpjbTkzTG5aaGJIVmxJRDBnZEdocGN5NTBiM1JoYkVWelkzSnZkeTUyWVd4MVpTQXJJR0Y0Wm1WeUxtRnpjMlYwUVcxdmRXNTBPd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVlOVEF3VUc5dmJDNWhiR2R2TG5Sek9qSTFDaUFnSUNBdkx5QjBiM1JoYkVWelkzSnZkeUE5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnBibWwwYVdGc1ZtRnNkV1U2SUZWcGJuUTJOQ2d3S1NCOUtUc0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0luUnZkR0ZzUlhOamNtOTNJZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMWcxTURCUWIyOXNMbUZzWjI4dWRITTZPREFLSUNBZ0lDOHZJSFJvYVhNdWRHOTBZV3hGYzJOeWIzY3VkbUZzZFdVZ1BTQjBhR2x6TG5SdmRHRnNSWE5qY205M0xuWmhiSFZsSUNzZ1lYaG1aWEl1WVhOelpYUkJiVzkxYm5RN0NpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdaM1I0YmlBd0lFRnpjMlYwUVcxdmRXNTBDaUFnSUNBckNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdldEVXdNRkJ2YjJ3dVlXeG5ieTUwY3pveU5Rb2dJQ0FnTHk4Z2RHOTBZV3hGYzJOeWIzY2dQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUJWYVc1ME5qUW9NQ2tnZlNrN0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKMGIzUmhiRVZ6WTNKdmR5SUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVlOVEF3VUc5dmJDNWhiR2R2TG5Sek9qZ3dDaUFnSUNBdkx5QjBhR2x6TG5SdmRHRnNSWE5qY205M0xuWmhiSFZsSUQwZ2RHaHBjeTUwYjNSaGJFVnpZM0p2ZHk1MllXeDFaU0FySUdGNFptVnlMbUZ6YzJWMFFXMXZkVzUwT3dvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5WU5UQXdVRzl2YkM1aGJHZHZMblJ6T2pZMkNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2dibUZ0WlRvZ0ltUmxjRzl6YVhSZlpYTmpjbTkzSWlCOUtRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdOdmJuUnlZV04wY3k5WU5UQXdVRzl2YkM1aGJHZHZMblJ6T2pwWU5UQXdVRzl2YkM1bGMyTnliM2RQWmx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtVnpZM0p2ZDA5bU9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxZzFNREJRYjI5c0xtRnNaMjh1ZEhNNk9ETUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ1WVcxbE9pQWlaWE5qY205M1gyOW1JaXdnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVlOVEF3VUc5dmJDNWhiR2R2TG5Sek9qSTVDaUFnSUNBdkx5QmxjMk55YjNkQ1lXeGhibU5sY3lBOUlFSnZlRTFoY0R4QlkyTnZkVzUwTENCMWFXNTBOalErS0hzZ2EyVjVVSEpsWm1sNE9pQWlaU0lnZlNrN0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKbElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZXRFV3TUZCdmIyd3VZV3huYnk1MGN6bzROZ29nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11WlhOamNtOTNRbUZzWVc1alpYTW9ZV2RsYm5RcExtZGxkQ2g3SUdSbFptRjFiSFE2SUZWcGJuUTJOQ2d3S1NCOUtUc0tJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lITjNZWEFLSUNBZ0lHSjBiMmtLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCemQyRndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxZzFNREJRYjI5c0xtRnNaMjh1ZEhNNk9ETUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ1WVcxbE9pQWlaWE5qY205M1gyOW1JaXdnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmpiMjUwY21GamRITXZXRFV3TUZCdmIyd3VZV3huYnk1MGN6bzZXRFV3TUZCdmIyd3VZbUZzWVc1alpVOW1XM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWW1Gc1lXNWpaVTltT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFnMU1EQlFiMjlzTG1Gc1oyOHVkSE02T0RrS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnVZVzFsT2lBaVltRnNZVzVqWlY5dlppSXNJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F4TmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTVRZK0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdldEVXdNRkJ2YjJ3dVlXeG5ieTUwY3pvNU1nb2dJQ0FnTHk4Z1kyOXVjM1FnY0c5dmJFSmhiR0Z1WTJVZ1BTQjBhR2x6TG5CdmIyeENZV3hoYm1ObGN5aHpiSFZuS1M1blpYUW9leUJrWldaaGRXeDBPaUJWYVc1ME5qUW9NQ2tnZlNrN0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCemQyRndDaUFnSUNCaWRHOXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYzNkaGNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5WU5UQXdVRzl2YkM1aGJHZHZMblJ6T2prekNpQWdJQ0F2THlCeVpYUjFjbTRnVzNCdmIyeENZV3hoYm1ObExDQjBhR2x6TG5SdmRHRnNSWE5qY205M0xuWmhiSFZsWFRzS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12V0RVd01GQnZiMnd1WVd4bmJ5NTBjem95TlFvZ0lDQWdMeThnZEc5MFlXeEZjMk55YjNjZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYVc1cGRHbGhiRlpoYkhWbE9pQlZhVzUwTmpRb01Da2dmU2s3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0owYjNSaGJFVnpZM0p2ZHlJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5WU5UQXdVRzl2YkM1aGJHZHZMblJ6T2prekNpQWdJQ0F2THlCeVpYUjFjbTRnVzNCdmIyeENZV3hoYm1ObExDQjBhR2x6TG5SdmRHRnNSWE5qY205M0xuWmhiSFZsWFRzS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5WU5UQXdVRzl2YkM1aGJHZHZMblJ6T2pnNUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2dibUZ0WlRvZ0ltSmhiR0Z1WTJWZmIyWWlMQ0J5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ1lubDBaV01nTkNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTnZiblJ5WVdOMGN5OVlOVEF3VUc5dmJDNWhiR2R2TG5Sek9qcFlOVEF3VUc5dmJDNWhjSEJzZVZObGRIUnNaVzFsYm5SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGhjSEJzZVZObGRIUnNaVzFsYm5RNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdldEVXdNRkJ2YjJ3dVlXeG5ieTUwY3pvNU5nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJRzVoYldVNklDSmhjSEJzZVY5elpYUjBiR1Z0Wlc1MElpQjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ01UWUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lERTJQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURVS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVpYjI5c0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdldEVXdNRkJ2YjJ3dVlXeG5ieTUwY3pveE1EUUtJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbWx1YVhScFlXeHBlbVZrTG5aaGJIVmxMQ0FpYm05MElHbHVhWFJwWVd4cGVtVmtJaWs3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMWcxTURCUWIyOXNMbUZzWjI4dWRITTZNallLSUNBZ0lDOHZJR2x1YVhScFlXeHBlbVZrSUQwZ1IyeHZZbUZzVTNSaGRHVThZbTl2YkdWaGJqNG9leUJwYm1sMGFXRnNWbUZzZFdVNklHWmhiSE5sSUgwcE93b2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWFXNXBkR2xoYkdsNlpXUWlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZXRFV3TUZCdmIyd3VZV3huYnk1MGN6b3hNRFFLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1sdWFYUnBZV3hwZW1Wa0xuWmhiSFZsTENBaWJtOTBJR2x1YVhScFlXeHBlbVZrSWlrN0NpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCcGJtbDBhV0ZzYVhwbFpBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxZzFNREJRYjI5c0xtRnNaMjh1ZEhNNk1UQTFDaUFnSUNBdkx5QmhjM05sY25Rb1ZIaHVMbk5sYm1SbGNpQTlQVDBnZEdocGN5NXpaWFIwYkdWeVFYQndMblpoYkhWbExtRmtaSEpsYzNNc0lDSnViM1FnYzJWMGRHeGxjaUJoY0hBaUtUc0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12V0RVd01GQnZiMnd1WVd4bmJ5NTBjem95TkFvZ0lDQWdMeThnYzJWMGRHeGxja0Z3Y0NBOUlFZHNiMkpoYkZOMFlYUmxQRUZ3Y0d4cFkyRjBhVzl1UGlncE93b2dJQ0FnWW5sMFpXTmZNeUF2THlBaWMyVjBkR3hsY2tGd2NDSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVlOVEF3VUc5dmJDNWhiR2R2TG5Sek9qRXdOUW9nSUNBZ0x5OGdZWE56WlhKMEtGUjRiaTV6Wlc1a1pYSWdQVDA5SUhSb2FYTXVjMlYwZEd4bGNrRndjQzUyWVd4MVpTNWhaR1J5WlhOekxDQWlibTkwSUhObGRIUnNaWElnWVhCd0lpazdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnWVhCd1gzQmhjbUZ0YzE5blpYUWdRWEJ3UVdSa2NtVnpjd29nSUNBZ1lYTnpaWEowSUM4dklHRndjR3hwWTJGMGFXOXVJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2MyVjBkR3hsY2lCaGNIQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVlOVEF3VUc5dmJDNWhiR2R2TG5Sek9qSTVDaUFnSUNBdkx5QmxjMk55YjNkQ1lXeGhibU5sY3lBOUlFSnZlRTFoY0R4QlkyTnZkVzUwTENCMWFXNTBOalErS0hzZ2EyVjVVSEpsWm1sNE9pQWlaU0lnZlNrN0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKbElnb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5WU5UQXdVRzl2YkM1aGJHZHZMblJ6T2pFd053b2dJQ0FnTHk4Z1kyOXVjM1FnWlhOamNtOTNJRDBnZEdocGN5NWxjMk55YjNkQ1lXeGhibU5sY3loaFoyVnVkQ2t1WjJWMEtIc2daR1ZtWVhWc2REb2dWV2x1ZERZMEtEQXBJSDBwT3dvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J6ZDJGd0NpQWdJQ0JpZEc5cENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlZTlRBd1VHOXZiQzVoYkdkdkxuUnpPakV3T0FvZ0lDQWdMeThnWVhOelpYSjBLR1Z6WTNKdmR5QStQU0J3Y21WdGFYVnRMQ0FpYVc1emRXWm1hV05wWlc1MElHVnpZM0p2ZHlJcE93b2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ05Bb2dJQ0FnUGowS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5OMVptWnBZMmxsYm5RZ1pYTmpjbTkzQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12V0RVd01GQnZiMnd1WVd4bmJ5NTBjem94TURrS0lDQWdJQzh2SUhSb2FYTXVaWE5qY205M1FtRnNZVzVqWlhNb1lXZGxiblFwTG5aaGJIVmxJRDBnWlhOamNtOTNJQzBnY0hKbGJXbDFiVHNLSUNBZ0lHUnBaeUF6Q2lBZ0lDQXRDaUFnSUNCcGRHOWlDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12V0RVd01GQnZiMnd1WVd4bmJ5NTBjem94TVRBS0lDQWdJQzh2SUhSb2FYTXVkRzkwWVd4RmMyTnliM2N1ZG1Gc2RXVWdQU0IwYUdsekxuUnZkR0ZzUlhOamNtOTNMblpoYkhWbElDMGdjSEpsYldsMWJUc0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdldEVXdNRkJ2YjJ3dVlXeG5ieTUwY3pveU5Rb2dJQ0FnTHk4Z2RHOTBZV3hGYzJOeWIzY2dQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUJWYVc1ME5qUW9NQ2tnZlNrN0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKMGIzUmhiRVZ6WTNKdmR5SUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVlOVEF3VUc5dmJDNWhiR2R2TG5Sek9qRXhNQW9nSUNBZ0x5OGdkR2hwY3k1MGIzUmhiRVZ6WTNKdmR5NTJZV3gxWlNBOUlIUm9hWE11ZEc5MFlXeEZjMk55YjNjdWRtRnNkV1VnTFNCd2NtVnRhWFZ0T3dvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lHUnBaeUF5Q2lBZ0lDQXRDaUFnSUNBdkx5QmpiMjUwY21GamRITXZXRFV3TUZCdmIyd3VZV3huYnk1MGN6b3lOUW9nSUNBZ0x5OGdkRzkwWVd4RmMyTnliM2NnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhVzVwZEdsaGJGWmhiSFZsT2lCVmFXNTBOalFvTUNrZ2ZTazdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjBiM1JoYkVWelkzSnZkeUlLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlZTlRBd1VHOXZiQzVoYkdkdkxuUnpPakV4TUFvZ0lDQWdMeThnZEdocGN5NTBiM1JoYkVWelkzSnZkeTUyWVd4MVpTQTlJSFJvYVhNdWRHOTBZV3hGYzJOeWIzY3VkbUZzZFdVZ0xTQndjbVZ0YVhWdE93b2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVlOVEF3VUc5dmJDNWhiR2R2TG5Sek9qRXhNZ29nSUNBZ0x5OGdZMjl1YzNRZ2NHOXZiQ0E5SUhSb2FYTXVjRzl2YkVKaGJHRnVZMlZ6S0hOc2RXY3BMbWRsZENoN0lHUmxabUYxYkhRNklGVnBiblEyTkNnd0tTQjlLVHNLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J6ZDJGd0NpQWdJQ0JpZEc5cENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlZTlRBd1VHOXZiQzVoYkdkdkxuUnpPakV4TXdvZ0lDQWdMeThnZEdocGN5NXdiMjlzUW1Gc1lXNWpaWE1vYzJ4MVp5a3VkbUZzZFdVZ1BTQndiMjlzSUNzZ2NISmxiV2wxYlRzS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdldEVXdNRkJ2YjJ3dVlXeG5ieTUwY3pveE1UVUtJQ0FnSUM4dklHbG1JQ2hpY21WaFkyZ2dKaVlnY21WbWRXNWtJRDRnVldsdWREWTBLREFwS1NCN0NpQWdJQ0JpZWlCaGNIQnNlVk5sZEhSc1pXMWxiblJmWVdaMFpYSmZhV1pmWld4elpVQTFDaUFnSUNCa2RYQUtJQ0FnSUdKNklHRndjR3g1VTJWMGRHeGxiV1Z1ZEY5aFpuUmxjbDlwWmw5bGJITmxRRFVLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlZTlRBd1VHOXZiQzVoYkdkdkxuUnpPakV4TmdvZ0lDQWdMeThnWTI5dWMzUWdjRzl2YkVGbWRHVnlVSEpsYldsMWJTQTlJSFJvYVhNdWNHOXZiRUpoYkdGdVkyVnpLSE5zZFdjcExuWmhiSFZsT3dvZ0lDQWdaR2xuSURJS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJR0owYjJrS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5WU5UQXdVRzl2YkM1aGJHZHZMblJ6T2pFeE53b2dJQ0FnTHk4Z1lYTnpaWEowS0hCdmIyeEJablJsY2xCeVpXMXBkVzBnUGowZ2NtVm1kVzVrTENBaWFXNXpkV1ptYVdOcFpXNTBJSEJ2YjJ3aUtUc0tJQ0FnSUdSMWNBb2dJQ0FnWkdsbklETUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ1BqMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuTjFabVpwWTJsbGJuUWdjRzl2YkFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFnMU1EQlFiMjlzTG1Gc1oyOHVkSE02TVRFNENpQWdJQ0F2THlCMGFHbHpMbkJ2YjJ4Q1lXeGhibU5sY3loemJIVm5LUzUyWVd4MVpTQTlJSEJ2YjJ4QlpuUmxjbEJ5WlcxcGRXMGdMU0J5WldaMWJtUTdDaUFnSUNCa2FXY2dNUW9nSUNBZ0xRb2dJQ0FnYVhSdllnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdldEVXdNRkJ2YjJ3dVlXeG5ieTUwY3pveE1Ua3RNVEkyQ2lBZ0lDQXZMeUJwZEhodUNpQWdJQ0F2THlBZ0lDNWhjM05sZEZSeVlXNXpabVZ5S0hzS0lDQWdJQzh2SUNBZ0lDQmhjM05sZEZKbFkyVnBkbVZ5T2lCaFoyVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCNFptVnlRWE56WlhRNklGVlRSRU5mVkVWVFZFNUZWRjlCVTBGZlNVUXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUkJiVzkxYm5RNklISmxablZ1WkN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U2SUZWcGJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUM4dklDQWdMbk4xWW0xcGRDZ3BPd29nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRUZ0YjNWdWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxZzFNREJRYjI5c0xtRnNaMjh1ZEhNNk1USXlDaUFnSUNBdkx5QjRabVZ5UVhOelpYUTZJRlZUUkVOZlZFVlRWRTVGVkY5QlUwRmZTVVFzQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNVEEwTlRnNU5ERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1dHWmxja0Z6YzJWMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRkpsWTJWcGRtVnlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZXRFV3TUZCdmIyd3VZV3huYnk1MGN6b3hNVGt0TVRJMUNpQWdJQ0F2THlCcGRIaHVDaUFnSUNBdkx5QWdJQzVoYzNObGRGUnlZVzV6Wm1WeUtIc0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGSmxZMlZwZG1WeU9pQmhaMlZ1ZEN3S0lDQWdJQzh2SUNBZ0lDQjRabVZ5UVhOelpYUTZJRlZUUkVOZlZFVlRWRTVGVkY5QlUwRmZTVVFzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJCYlc5MWJuUTZJSEpsWm5WdVpDd0tJQ0FnSUM4dklDQWdJQ0JtWldVNklGVnBiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lHbHVkR05mTXlBdkx5QTBDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdldEVXdNRkJ2YjJ3dVlXeG5ieTUwY3pveE1qUUtJQ0FnSUM4dklHWmxaVG9nVldsdWREWTBLREFwTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12V0RVd01GQnZiMnd1WVd4bmJ5NTBjem94TVRrdE1USTJDaUFnSUNBdkx5QnBkSGh1Q2lBZ0lDQXZMeUFnSUM1aGMzTmxkRlJ5WVc1elptVnlLSHNLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRkpsWTJWcGRtVnlPaUJoWjJWdWRDd0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVFYTnpaWFE2SUZWVFJFTmZWRVZUVkU1RlZGOUJVMEZmU1VRc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSQmJXOTFiblE2SUhKbFpuVnVaQ3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTZJRlZwYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJQzh2SUNBZ0xuTjFZbTFwZENncE93b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0NtRndjR3g1VTJWMGRHeGxiV1Z1ZEY5aFpuUmxjbDlwWmw5bGJITmxRRFU2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12V0RVd01GQnZiMnd1WVd4bmJ5NTBjem81TmdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lHNWhiV1U2SUNKaGNIQnNlVjl6WlhSMGJHVnRaVzUwSWlCOUtRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFHOXJ2NEVCQ1lGQzJsdWFYUnBZV3hwZW1Wa0MzUnZkR0ZzUlhOamNtOTNBV1VLYzJWMGRHeGxja0Z3Y0FRVkgzeDFNUmhBQUFZcEltY29JbWN4RzBFQVFERVpGRVF4R0VTQ0J3UWJ6ZVV0QkxjMDFkWUVZRUE0dmdTamdpdnZCSU91R3dNRVdtbml0d1FlcnQ0Wk5ob0FqZ2NBQ1FBaEFEb0FlUUMvQU5zQS9BQXhHUlF4R0JRUVF6WWFBVWtWZ1FnU1JCY2lLR1ZFRkVRclRHY29JMmNqUXlJb1pVUkVzVElLSXJJU0pMSVJzaFFsc2hBaXNnR3pJME0yR2dGSkZZRVFFa1FpS0dWRVJERVdSREVXSXdsSk9CQWxFa1JKT0JReUNoSkxBVGdTVEVzQkVFUk1PQkVrRWtSTEFiNU1GeUpNVHdKTkNCYS9JME1pS0dWRVJERVdSRE1BRUNVU1JETUFGRElLRWpNQUFERUFFaEF6QUJJUVJETUFFU1FTUkNveEFGQkp2a3dYSWt4UEFrMHpBQklJRnI4aUtXVkVNd0FTQ0NsTVp5TkROaG9CU1JXQklCSkVLa3hRdmt3WElreFBBazBXSndSTVVMQWpRellhQVVrVmdSQVNSTDVNRnlKTVR3Sk5JaWxsUkV3V1RCWlFKd1JNVUxBalF6WWFBVWNDRllFUUVrUTJHZ0pKVGdKSkZZRWdFa1EyR2dOSkZZRUlFa1FYTmhvRVNSV0JDQkpFRjA0RE5ob0ZTUlVqRWtRaVV5SW9aVVJFTVFBaUsyVkVjZ2hFRWtRcVR3TlFTYjVNRnlKTVR3Sk5TVXNFRDBSTEF3a1d2eUlwWlVSTEFna3BUR2RMQXI1TUZ5Sk1Ud0pOVHdJSUZrOENUTDlCQUN0SlFRQW5Td0pKdmtRWFNVc0RTVTRERDBSTEFRa1dUd0pNdjdHeUVpU3lFVXNCc2hRbHNoQWlzZ0d6STBNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
