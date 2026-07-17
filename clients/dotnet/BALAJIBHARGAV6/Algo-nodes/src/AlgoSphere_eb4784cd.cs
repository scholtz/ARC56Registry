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

namespace Arc56.Generated.BALAJIBHARGAV6.Algo_nodes.AlgoSphere_eb4784cd
{


    //
    // 
    //    AlgoSphere Staking Pool Smart Contract
    //    
    //    A simple staking pool where users can:
    //    - Deposit ALGO and receive shares
    //    - Withdraw their staked ALGO based on shares
    //    - View their staking information
    //    
    //
    public class AlgoSphereProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AlgoSphereProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetPoolStateReturn : AVMObjectType
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

                public static GetPoolStateReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetPoolStateReturn();
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
                    return Equals(obj as GetPoolStateReturn);
                }
                public bool Equals(GetPoolStateReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetPoolStateReturn left, GetPoolStateReturn right)
                {
                    return EqualityComparer<GetPoolStateReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetPoolStateReturn left, GetPoolStateReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetUserStateReturn : AVMObjectType
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

                public static GetUserStateReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetUserStateReturn();
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
                    return Equals(obj as GetUserStateReturn);
                }
                public bool Equals(GetUserStateReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetUserStateReturn left, GetUserStateReturn right)
                {
                    return EqualityComparer<GetUserStateReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetUserStateReturn left, GetUserStateReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Initialize the staking pool with admin address.
        ///</summary>
        /// <param name="admin_address"> </param>
        public async Task CreatePool(Algorand.Address admin_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 254, 87, 147, 145 };
            var admin_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); admin_addressAbi.From(admin_address);

            var result = await base.CallApp(new List<object> { abiHandle, admin_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreatePool_Transactions(Algorand.Address admin_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 254, 87, 147, 145 };
            var admin_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); admin_addressAbi.From(admin_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, admin_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Deposit ALGO and receive shares based on current share price.
        ///This method expects payment transaction to be grouped with the application call.
        ///</summary>
        public async Task Deposit(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 146, 224, 59, 28 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Deposit_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 146, 224, 59, 28 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Withdraw ALGO by burning shares.
        ///shares_to_burn: number of shares to burn for withdrawal
        ///</summary>
        /// <param name="shares_to_burn"> </param>
        public async Task Withdraw(ulong shares_to_burn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 241, 221, 255 };
            var shares_to_burnAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); shares_to_burnAbi.From(shares_to_burn);

            var result = await base.CallApp(new List<object> { abiHandle, shares_to_burnAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Withdraw_Transactions(ulong shares_to_burn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 241, 221, 255 };
            var shares_to_burnAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); shares_to_burnAbi.From(shares_to_burn);

            return await base.MakeTransactionList(new List<object> { abiHandle, shares_to_burnAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get current pool state.
        ///</summary>
        public async Task<Structs.GetPoolStateReturn> GetPoolState(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 182, 167, 216, 150 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetPoolStateReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetPoolState_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 182, 167, 216, 150 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get user staking state.
        ///</summary>
        /// <param name="user"> </param>
        public async Task<Structs.GetUserStateReturn> GetUserState(Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 41, 8, 69, 220 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            var result = await base.SimApp(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetUserStateReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetUserState_Transactions(Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 41, 8, 69, 220 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Allow users to opt into the contract.
        ///</summary>
        public async Task OptIn(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 198, 213, 138 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptIn_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 198, 213, 138 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWxnb1NwaGVyZSIsImRlc2MiOiJcbiAgICBBbGdvU3BoZXJlIFN0YWtpbmcgUG9vbCBTbWFydCBDb250cmFjdFxuICAgIFxuICAgIEEgc2ltcGxlIHN0YWtpbmcgcG9vbCB3aGVyZSB1c2VycyBjYW46XG4gICAgLSBEZXBvc2l0IEFMR08gYW5kIHJlY2VpdmUgc2hhcmVzXG4gICAgLSBXaXRoZHJhdyB0aGVpciBzdGFrZWQgQUxHTyBiYXNlZCBvbiBzaGFyZXNcbiAgICAtIFZpZXcgdGhlaXIgc3Rha2luZyBpbmZvcm1hdGlvblxuICAgICIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJHZXRQb29sU3RhdGVSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50NjQifV0sIkdldFVzZXJTdGF0ZVJldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZV9wb29sIiwiZGVzYyI6IkluaXRpYWxpemUgdGhlIHN0YWtpbmcgcG9vbCB3aXRoIGFkbWluIGFkZHJlc3MuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZG1pbl9hZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlcG9zaXQiLCJkZXNjIjoiRGVwb3NpdCBBTEdPIGFuZCByZWNlaXZlIHNoYXJlcyBiYXNlZCBvbiBjdXJyZW50IHNoYXJlIHByaWNlLlxuVGhpcyBtZXRob2QgZXhwZWN0cyBwYXltZW50IHRyYW5zYWN0aW9uIHRvIGJlIGdyb3VwZWQgd2l0aCB0aGUgYXBwbGljYXRpb24gY2FsbC4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoid2l0aGRyYXciLCJkZXNjIjoiV2l0aGRyYXcgQUxHTyBieSBidXJuaW5nIHNoYXJlcy5cbnNoYXJlc190b19idXJuOiBudW1iZXIgb2Ygc2hhcmVzIHRvIGJ1cm4gZm9yIHdpdGhkcmF3YWwiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2hhcmVzX3RvX2J1cm4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3Bvb2xfc3RhdGUiLCJkZXNjIjoiR2V0IGN1cnJlbnQgcG9vbCBzdGF0ZS4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkdldFBvb2xTdGF0ZVJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3VzZXJfc3RhdGUiLCJkZXNjIjoiR2V0IHVzZXIgc3Rha2luZyBzdGF0ZS4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiR2V0VXNlclN0YXRlUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJvcHRfaW4iLCJkZXNjIjoiQWxsb3cgdXNlcnMgdG8gb3B0IGludG8gdGhlIGNvbnRyYWN0LiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjR9LCJsb2NhbCI6eyJpbnRzIjoxLCJieXRlcyI6MX19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzQ2MF0sImVycm9yTWVzc2FnZSI6IkFkZHJlc3MgbGVuZ3RoIGlzIDMyIGJ5dGVzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzU5XSwiZXJyb3JNZXNzYWdlIjoiSW5zdWZmaWNpZW50IGNvbnRyYWN0IGJhbGFuY2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNTBdLCJlcnJvck1lc3NhZ2UiOiJJbnN1ZmZpY2llbnQgc2hhcmVzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjcwXSwiZXJyb3JNZXNzYWdlIjoiTWluaW11bSBkZXBvc2l0IGlzIDEgQUxHTyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0MywxNTUsMTc1LDE5MiwyMDcsMjE5XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQwXSwiZXJyb3JNZXNzYWdlIjoiT25seSBjcmVhdG9yIGNhbiBpbml0aWFsaXplIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzU1XSwiZXJyb3JNZXNzYWdlIjoiYWNjb3VudCBmdW5kZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjNdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDYsMTU4LDE3OCwxOTUsMjEwXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4Miw0MzZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnNoYXJlX3ByaWNlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5NywzNzMsNDIzXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b3RhbF9zaGFyZXMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjg3LDM2Myw0MDhdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRvdGFsX3N0YWtlZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MTMsNDI4LDQ0MSw0NzRdLCJlcnJvck1lc3NhZ2UiOiJvdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WVd4bmIzTndhR1Z5WlM1amIyNTBjbUZqZEM1QmJHZHZVM0JvWlhKbExsOWZZV3huYjNCNVgyVnVkSEo1Y0c5cGJuUmZkMmwwYUY5cGJtbDBLQ2tnTFQ0Z2RXbHVkRFkwT2dwdFlXbHVPZ29nSUNBZ2FXNTBZMkpzYjJOcklEQWdNU0E0Q2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0owYjNSaGJGOXpkR0ZyWldRaUlEQjRJQ0owYjNSaGJGOXphR0Z5WlhNaUlDSjFjMlZ5WDNOb1lYSmxjeUlnSW5Ob1lYSmxYM0J5YVdObElpQWljM1JoYTJWZmRHbHRaWE4wWVcxd0lpQXdlREUxTVdZM1l6YzFJREI0TUdZME1qUXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM053YUdWeVpTOWpiMjUwY21GamRDNXdlVG94TmdvZ0lDQWdMeThnWTJ4aGMzTWdRV3huYjFOd2FHVnlaU2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhNUW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlR1psTlRjNU16a3hJREI0T1RKbE1ETmlNV01nTUhneU1XWXhaR1JtWmlBd2VHSTJZVGRrT0RrMklEQjRNamt3T0RRMVpHTWdNSGd6TUdNMlpEVTRZU0F2THlCdFpYUm9iMlFnSW1OeVpXRjBaVjl3YjI5c0tHRmtaSEpsYzNNcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWkdWd2IzTnBkQ2dwZG05cFpDSXNJRzFsZEdodlpDQWlkMmwwYUdSeVlYY29kV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW1kbGRGOXdiMjlzWDNOMFlYUmxLQ2tvZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRcElpd2diV1YwYUc5a0lDSm5aWFJmZFhObGNsOXpkR0YwWlNoaFpHUnlaWE56S1NoMWFXNTBOalFzZFdsdWREWTBLU0lzSUcxbGRHaHZaQ0FpYjNCMFgybHVLQ2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5amNtVmhkR1ZmY0c5dmJGOXliM1YwWlVBMUlHMWhhVzVmWkdWd2IzTnBkRjl5YjNWMFpVQTJJRzFoYVc1ZmQybDBhR1J5WVhkZmNtOTFkR1ZBTnlCdFlXbHVYMmRsZEY5d2IyOXNYM04wWVhSbFgzSnZkWFJsUURnZ2JXRnBibDluWlhSZmRYTmxjbDl6ZEdGMFpWOXliM1YwWlVBNUlHMWhhVzVmYjNCMFgybHVYM0p2ZFhSbFFERXdDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRFNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIzTndhR1Z5WlM5amIyNTBjbUZqZEM1d2VUb3hOZ29nSUNBZ0x5OGdZMnhoYzNNZ1FXeG5iMU53YUdWeVpTaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDl2Y0hSZmFXNWZjbTkxZEdWQU1UQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM053YUdWeVpTOWpiMjUwY21GamRDNXdlVG94TWpnS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUc5d2RGOXBiZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJmZFhObGNsOXpkR0YwWlY5eWIzVjBaVUE1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5emNHaGxjbVV2WTI5dWRISmhZM1F1Y0hrNk1URTJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl6Y0dobGNtVXZZMjl1ZEhKaFkzUXVjSGs2TVRZS0lDQWdJQzh2SUdOc1lYTnpJRUZzWjI5VGNHaGxjbVVvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjM0JvWlhKbEwyTnZiblJ5WVdOMExuQjVPakV4TmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JqWVd4c2MzVmlJR2RsZEY5MWMyVnlYM04wWVhSbENpQWdJQ0JpZVhSbFl5QTJJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRGOXdiMjlzWDNOMFlYUmxYM0p2ZFhSbFFEZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM053YUdWeVpTOWpiMjUwY21GamRDNXdlVG94TURNS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JqWVd4c2MzVmlJR2RsZEY5d2IyOXNYM04wWVhSbENpQWdJQ0JpZVhSbFl5QTJJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNkcGRHaGtjbUYzWDNKdmRYUmxRRGM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNOd2FHVnlaUzlqYjI1MGNtRmpkQzV3ZVRvM01nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2YzNCb1pYSmxMMk52Ym5SeVlXTjBMbkI1T2pFMkNpQWdJQ0F2THlCamJHRnpjeUJCYkdkdlUzQm9aWEpsS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM053YUdWeVpTOWpiMjUwY21GamRDNXdlVG8zTWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCallXeHNjM1ZpSUhkcGRHaGtjbUYzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMlJsY0c5emFYUmZjbTkxZEdWQU5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjM0JvWlhKbEwyTnZiblJ5WVdOMExuQjVPalEzQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnWTJGc2JITjFZaUJrWlhCdmMybDBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyTnlaV0YwWlY5d2IyOXNYM0p2ZFhSbFFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM053YUdWeVpTOWpiMjUwY21GamRDNXdlVG96TndvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLR055WldGMFpUMGljbVZ4ZFdseVpTSXBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl6Y0dobGNtVXZZMjl1ZEhKaFkzUXVjSGs2TVRZS0lDQWdJQzh2SUdOc1lYTnpJRUZzWjI5VGNHaGxjbVVvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjM0JvWlhKbEwyTnZiblJ5WVdOMExuQjVPak0zQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9ZM0psWVhSbFBTSnlaWEYxYVhKbElpa0tJQ0FnSUdOaGJHeHpkV0lnWTNKbFlYUmxYM0J2YjJ3S0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZV3huYjNOd2FHVnlaUzVqYjI1MGNtRmpkQzVCYkdkdlUzQm9aWEpsTG1OeVpXRjBaVjl3YjI5c0tHRmtiV2x1WDJGa1pISmxjM002SUdKNWRHVnpLU0F0UGlCMmIybGtPZ3BqY21WaGRHVmZjRzl2YkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmMzQm9aWEpsTDJOdmJuUnlZV04wTG5CNU9qTTNMVE00Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9ZM0psWVhSbFBTSnlaWEYxYVhKbElpa0tJQ0FnSUM4dklHUmxaaUJqY21WaGRHVmZjRzl2YkNoelpXeG1MQ0JoWkcxcGJsOWhaR1J5WlhOek9pQmhjbU0wTGtGa1pISmxjM01wSUMwK0lFNXZibVU2Q2lBZ0lDQndjbTkwYnlBeElEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjM0JvWlhKbEwyTnZiblJ5WVdOMExuQjVPalF3Q2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaUE5UFNCSGJHOWlZV3d1WTNKbFlYUnZjbDloWkdSeVpYTnpMQ0FpVDI1c2VTQmpjbVZoZEc5eUlHTmhiaUJwYm1sMGFXRnNhWHBsSWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1oyeHZZbUZzSUVOeVpXRjBiM0pCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2dZM0psWVhSdmNpQmpZVzRnYVc1cGRHbGhiR2w2WlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5emNHaGxjbVV2WTI5dWRISmhZM1F1Y0hrNk5ESUtJQ0FnSUM4dklITmxiR1l1WVdSdGFXNHVkbUZzZFdVZ1BTQmhaRzFwYmw5aFpHUnlaWE56TG1KNWRHVnpDaUFnSUNCd2RYTm9ZbmwwWlhNZ0ltRmtiV2x1SWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5emNHaGxjbVV2WTI5dWRISmhZM1F1Y0hrNk5ETUtJQ0FnSUM4dklITmxiR1l1YzJoaGNtVmZjSEpwWTJVdWRtRnNkV1VnUFNCQ2FXZFZTVzUwS0RGZk1EQXdYekF3TUNrZ0lDTWdTVzVwZEdsaGJDQndjbWxqWlRvZ01TNHdJRUZNUjA4Z2NHVnlJSE5vWVhKbENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKemFHRnlaVjl3Y21salpTSUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z01IZ3daalF5TkRBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIzTndhR1Z5WlM5amIyNTBjbUZqZEM1d2VUbzBOQW9nSUNBZ0x5OGdjMlZzWmk1MGIzUmhiRjl6ZEdGclpXUXVkbUZzZFdVZ1BTQkNhV2RWU1c1MEtEQXBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSjBiM1JoYkY5emRHRnJaV1FpQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5emNHaGxjbVV2WTI5dWRISmhZM1F1Y0hrNk5EVUtJQ0FnSUM4dklITmxiR1l1ZEc5MFlXeGZjMmhoY21WekxuWmhiSFZsSUQwZ1FtbG5WVWx1ZENnd0tRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWRHOTBZV3hmYzJoaGNtVnpJZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWhiR2R2YzNCb1pYSmxMbU52Ym5SeVlXTjBMa0ZzWjI5VGNHaGxjbVV1WkdWd2IzTnBkQ2dwSUMwK0lIWnZhV1E2Q21SbGNHOXphWFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNOd2FHVnlaUzlqYjI1MGNtRmpkQzV3ZVRvMU15MDFOQW9nSUNBZ0x5OGdJeUJXWVd4cFpHRjBaU0J0YVc1cGJYVnRJR1JsY0c5emFYUWdLREVnUVV4SFR5a0tJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVZVzF2ZFc1MElENDlJREZmTURBd1h6QXdNQ3dnSWsxcGJtbHRkVzBnWkdWd2IzTnBkQ0JwY3lBeElFRk1SMDhpQ2lBZ0lDQjBlRzRnUVcxdmRXNTBDaUFnSUNCd2RYTm9hVzUwSURFd01EQXdNREFnTHk4Z01UQXdNREF3TUFvZ0lDQWdQajBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk5hVzVwYlhWdElHUmxjRzl6YVhRZ2FYTWdNU0JCVEVkUENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIzTndhR1Z5WlM5amIyNTBjbUZqZEM1d2VUbzFOZ29nSUNBZ0x5OGdaR1Z3YjNOcGRGOWhiVzkxYm5RZ1BTQkNhV2RWU1c1MEtGUjRiaTVoYlc5MWJuUXBDaUFnSUNCMGVHNGdRVzF2ZFc1MENpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIzTndhR1Z5WlM5amIyNTBjbUZqZEM1d2VUbzFPQzAxT1FvZ0lDQWdMeThnSXlCRFlXeGpkV3hoZEdVZ2MyaGhjbVZ6SUhSdklHMXBiblFnWW1GelpXUWdiMjRnWTNWeWNtVnVkQ0J6YUdGeVpTQndjbWxqWlFvZ0lDQWdMeThnYzJoaGNtVnpYM1J2WDIxcGJuUWdQU0JrWlhCdmMybDBYMkZ0YjNWdWRDQXFJRUpwWjFWSmJuUW9NVjh3TURCZk1EQXdLU0F2THlCelpXeG1Mbk5vWVhKbFgzQnlhV05sTG5aaGJIVmxDaUFnSUNCa2RYQUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z01IZ3daalF5TkRBS0lDQWdJR0lxQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTkNBdkx5QWljMmhoY21WZmNISnBZMlVpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWMyaGhjbVZmY0hKcFkyVWdaWGhwYzNSekNpQWdJQ0JpTHdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5emNHaGxjbVV2WTI5dWRISmhZM1F1Y0hrNk5qRXROaklLSUNBZ0lDOHZJQ01nVlhCa1lYUmxJR2RzYjJKaGJDQnpkR0YwWlFvZ0lDQWdMeThnYzJWc1ppNTBiM1JoYkY5emRHRnJaV1F1ZG1Gc2RXVWdLejBnWkdWd2IzTnBkRjloYlc5MWJuUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMGIzUmhiRjl6ZEdGclpXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEc5MFlXeGZjM1JoYTJWa0lHVjRhWE4wY3dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaUt3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWRHOTBZV3hmYzNSaGEyVmtJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2YzNCb1pYSmxMMk52Ym5SeVlXTjBMbkI1T2pZekNpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gzTm9ZWEpsY3k1MllXeDFaU0FyUFNCemFHRnlaWE5mZEc5ZmJXbHVkQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0luUnZkR0ZzWDNOb1lYSmxjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGIzUmhiRjl6YUdGeVpYTWdaWGhwYzNSekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWWlzS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5SdmRHRnNYM05vWVhKbGN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM053YUdWeVpTOWpiMjUwY21GamRDNXdlVG8yTlMwMk5nb2dJQ0FnTHk4Z0l5QlZjR1JoZEdVZ2RYTmxjaUJ6ZEdGMFpRb2dJQ0FnTHk4Z1kzVnljbVZ1ZEY5emFHRnlaWE1nUFNCelpXeG1MblZ6WlhKZmMyaGhjbVZ6TG1kbGRDaFVlRzR1YzJWdVpHVnlMQ0JDYVdkVlNXNTBLREFwS1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0luVnpaWEpmYzJoaGNtVnpJZ29nSUNBZ1lYQndYMnh2WTJGc1gyZGxkRjlsZUFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM053YUdWeVpTOWpiMjUwY21GamRDNXdlVG8yTndvZ0lDQWdMeThnYzJWc1ppNTFjMlZ5WDNOb1lYSmxjMXRVZUc0dWMyVnVaR1Z5WFNBOUlHTjFjbkpsYm5SZmMyaGhjbVZ6SUNzZ2MyaGhjbVZ6WDNSdlgyMXBiblFLSUNBZ0lHSXJDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKMWMyVnlYM05vWVhKbGN5SUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5emNHaGxjbVV2WTI5dWRISmhZM1F1Y0hrNk5qa3ROekFLSUNBZ0lDOHZJQ01nVTJWMElITjBZV3RwYm1jZ2RHbHRaWE4wWVcxd0NpQWdJQ0F2THlCelpXeG1Mbk4wWVd0bFgzUnBiV1Z6ZEdGdGNGdFVlRzR1YzJWdVpHVnlYU0E5SUVkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKemRHRnJaVjkwYVcxbGMzUmhiWEFpQ2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZV3huYjNOd2FHVnlaUzVqYjI1MGNtRmpkQzVCYkdkdlUzQm9aWEpsTG5kcGRHaGtjbUYzS0hOb1lYSmxjMTkwYjE5aWRYSnVPaUJpZVhSbGN5a2dMVDRnZG05cFpEb0tkMmwwYUdSeVlYYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM053YUdWeVpTOWpiMjUwY21GamRDNXdlVG8zTWkwM013b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQXZMeUJrWldZZ2QybDBhR1J5WVhjb2MyVnNaaXdnYzJoaGNtVnpYM1J2WDJKMWNtNDZJR0Z5WXpRdVZVbHVkRFkwS1NBdFBpQk9iMjVsT2dvZ0lDQWdjSEp2ZEc4Z01TQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM053YUdWeVpTOWpiMjUwY21GamRDNXdlVG8zT0FvZ0lDQWdMeThnZFhObGNsOXphR0Z5WlhNZ1BTQnpaV3htTG5WelpYSmZjMmhoY21WekxtZGxkQ2hVZUc0dWMyVnVaR1Z5TENCQ2FXZFZTVzUwS0RBcEtRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJblZ6WlhKZmMyaGhjbVZ6SWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNOd2FHVnlaUzlqYjI1MGNtRmpkQzV3ZVRvM09Rb2dJQ0FnTHk4Z2MyaGhjbVZ6WDJGdGIzVnVkQ0E5SUVKcFoxVkpiblFvYzJoaGNtVnpYM1J2WDJKMWNtNHVibUYwYVhabEtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpZEc5cENpQWdJQ0JrZFhBS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmMzQm9aWEpsTDJOdmJuUnlZV04wTG5CNU9qZ3hMVGd5Q2lBZ0lDQXZMeUFqSUZaaGJHbGtZWFJsSUhWelpYSWdhR0Z6SUdWdWIzVm5hQ0J6YUdGeVpYTUtJQ0FnSUM4dklHRnpjMlZ5ZENCMWMyVnlYM05vWVhKbGN5QStQU0J6YUdGeVpYTmZZVzF2ZFc1MExDQWlTVzV6ZFdabWFXTnBaVzUwSUhOb1lYSmxjeUlLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZajQ5Q2lBZ0lDQmhjM05sY25RZ0x5OGdTVzV6ZFdabWFXTnBaVzUwSUhOb1lYSmxjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl6Y0dobGNtVXZZMjl1ZEhKaFkzUXVjSGs2T0RjdE9EZ0tJQ0FnSUM4dklDTWdSVzV6ZFhKbElHTnZiblJ5WVdOMElHaGhjeUJ6ZFdabWFXTnBaVzUwSUdKaGJHRnVZMlVLSUNBZ0lDOHZJR0Z6YzJWeWRDQkhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxtSmhiR0Z1WTJVZ1BqMGdZV3huYjE5aGJXOTFiblFzSUNKSmJuTjFabVpwWTJsbGJuUWdZMjl1ZEhKaFkzUWdZbUZzWVc1alpTSUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNCaFkyTjBYM0JoY21GdGMxOW5aWFFnUVdOamRFSmhiR0Z1WTJVS0lDQWdJR0Z6YzJWeWRDQXZMeUJoWTJOdmRXNTBJR1oxYm1SbFpBb2dJQ0FnWkdsbklESUtJQ0FnSUQ0OUNpQWdJQ0JoYzNObGNuUWdMeThnU1c1emRXWm1hV05wWlc1MElHTnZiblJ5WVdOMElHSmhiR0Z1WTJVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmMzQm9aWEpsTDJOdmJuUnlZV04wTG5CNU9qa3dMVGt4Q2lBZ0lDQXZMeUFqSUZWd1pHRjBaU0JuYkc5aVlXd2djM1JoZEdVS0lDQWdJQzh2SUhObGJHWXVkRzkwWVd4ZmMzUmhhMlZrTG5aaGJIVmxJQzA5SUVKcFoxVkpiblFvWVd4bmIxOWhiVzkxYm5RcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZEc5MFlXeGZjM1JoYTJWa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2ZEdGc1gzTjBZV3RsWkNCbGVHbHpkSE1LSUNBZ0lHUnBaeUF4Q2lBZ0lDQmlMUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkRzkwWVd4ZmMzUmhhMlZrSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmMzQm9aWEpsTDJOdmJuUnlZV04wTG5CNU9qa3lDaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYM05vWVhKbGN5NTJZV3gxWlNBdFBTQnphR0Z5WlhOZllXMXZkVzUwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlkRzkwWVd4ZmMyaGhjbVZ6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUnZkR0ZzWDNOb1lYSmxjeUJsZUdsemRITUtJQ0FnSUdScFp5QXhDaUFnSUNCaUxRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWRHOTBZV3hmYzJoaGNtVnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2YzNCb1pYSmxMMk52Ym5SeVlXTjBMbkI1T2prMExUazFDaUFnSUNBdkx5QWpJRlZ3WkdGMFpTQjFjMlZ5SUhOMFlYUmxDaUFnSUNBdkx5QnpaV3htTG5WelpYSmZjMmhoY21WelcxUjRiaTV6Wlc1a1pYSmRJRDBnZFhObGNsOXphR0Z5WlhNZ0xTQnphR0Z5WlhOZllXMXZkVzUwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUdJdENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0oxYzJWeVgzTm9ZWEpsY3lJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lYQndYMnh2WTJGc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl6Y0dobGNtVXZZMjl1ZEhKaFkzUXVjSGs2T1RjdE1UQXhDaUFnSUNBdkx5QWpJRk5sYm1RZ1FVeEhUeUJpWVdOcklIUnZJSFZ6WlhJS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjajFVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEQxaGJHZHZYMkZ0YjNWdWRDd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmMzQm9aWEpsTDJOdmJuUnlZV04wTG5CNU9qazVDaUFnSUNBdkx5QnlaV05sYVhabGNqMVVlRzR1YzJWdVpHVnlMQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXTmxhWFpsY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjM0JvWlhKbEwyTnZiblJ5WVdOMExuQjVPamszTFRrNENpQWdJQ0F2THlBaklGTmxibVFnUVV4SFR5QmlZV05ySUhSdklIVnpaWElLSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJR2x1ZEdOZk1TQXZMeUJ3WVhrS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl6Y0dobGNtVXZZMjl1ZEhKaFkzUXVjSGs2T1RjdE1UQXhDaUFnSUNBdkx5QWpJRk5sYm1RZ1FVeEhUeUJpWVdOcklIUnZJSFZ6WlhJS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjajFVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEQxaGJHZHZYMkZ0YjNWdWRDd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WVd4bmIzTndhR1Z5WlM1amIyNTBjbUZqZEM1QmJHZHZVM0JvWlhKbExtZGxkRjl3YjI5c1gzTjBZWFJsS0NrZ0xUNGdZbmwwWlhNNkNtZGxkRjl3YjI5c1gzTjBZWFJsT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5emNHaGxjbVV2WTI5dWRISmhZM1F1Y0hrNk1URXhDaUFnSUNBdkx5QmhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxuUnZkR0ZzWDNOMFlXdGxaQzUyWVd4MVpTa3NDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWRHOTBZV3hmYzNSaGEyVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SdmRHRnNYM04wWVd0bFpDQmxlR2x6ZEhNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lHSjZaWEp2Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZbndLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2YzNCb1pYSmxMMk52Ym5SeVlXTjBMbkI1T2pFeE1nb2dJQ0FnTHk4Z1lYSmpOQzVWU1c1ME5qUW9jMlZzWmk1MGIzUmhiRjl6YUdGeVpYTXVkbUZzZFdVcExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5SdmRHRnNYM05vWVhKbGN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjNSaGJGOXphR0Z5WlhNZ1pYaHBjM1J6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmlmQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl6Y0dobGNtVXZZMjl1ZEhKaFkzUXVjSGs2TVRFekNpQWdJQ0F2THlCaGNtTTBMbFZKYm5RMk5DaHpaV3htTG5Ob1lYSmxYM0J5YVdObExuWmhiSFZsS1N3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0p6YUdGeVpWOXdjbWxqWlNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXphR0Z5WlY5d2NtbGpaU0JsZUdsemRITUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmlmQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl6Y0dobGNtVXZZMjl1ZEhKaFkzUXVjSGs2TVRFd0xURXhOQW9nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1VkhWd2JHVW9LQW9nSUNBZ0x5OGdJQ0FnSUdGeVl6UXVWVWx1ZERZMEtITmxiR1l1ZEc5MFlXeGZjM1JoYTJWa0xuWmhiSFZsS1N3S0lDQWdJQzh2SUNBZ0lDQmhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxuUnZkR0ZzWDNOb1lYSmxjeTUyWVd4MVpTa3NDaUFnSUNBdkx5QWdJQ0FnWVhKak5DNVZTVzUwTmpRb2MyVnNaaTV6YUdGeVpWOXdjbWxqWlM1MllXeDFaU2tzQ2lBZ0lDQXZMeUFwS1FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWhiR2R2YzNCb1pYSmxMbU52Ym5SeVlXTjBMa0ZzWjI5VGNHaGxjbVV1WjJWMFgzVnpaWEpmYzNSaGRHVW9kWE5sY2pvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwblpYUmZkWE5sY2w5emRHRjBaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2YzNCb1pYSmxMMk52Ym5SeVlXTjBMbkI1T2pFeE5pMHhNakFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdMeThnWkdWbUlHZGxkRjkxYzJWeVgzTjBZWFJsS0hObGJHWXNJSFZ6WlhJNklHRnlZelF1UVdSa2NtVnpjeWtnTFQ0Z1lYSmpOQzVVZFhCc1pWc0tJQ0FnSUM4dklDQWdJQ0JoY21NMExsVkpiblEyTkN3Z0lDTWdjMmhoY21WekNpQWdJQ0F2THlBZ0lDQWdZWEpqTkM1VlNXNTBOalFzSUNBaklITjBZV3RsWDNScGJXVnpkR0Z0Y0FvZ0lDQWdMeThnWFRvS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl6Y0dobGNtVXZZMjl1ZEhKaFkzUXVjSGs2TVRJeUNpQWdJQ0F2THlCMWMyVnlYMkZqWTI5MWJuUWdQU0JCWTJOdmRXNTBLSFZ6WlhJdVlubDBaWE1wQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJaR1J5WlhOeklHeGxibWQwYUNCcGN5QXpNaUJpZVhSbGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXpjR2hsY21VdlkyOXVkSEpoWTNRdWNIazZNVEkwQ2lBZ0lDQXZMeUJoY21NMExsVkpiblEyTkNoelpXeG1MblZ6WlhKZmMyaGhjbVZ6TG1kbGRDaDFjMlZ5WDJGalkyOTFiblFzSUVKcFoxVkpiblFvTUNrcEtTd0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5WelpYSmZjMmhoY21Weklnb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZbndLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2YzNCb1pYSmxMMk52Ym5SeVlXTjBMbkI1T2pFeU5Rb2dJQ0FnTHk4Z1lYSmpOQzVWU1c1ME5qUW9jMlZzWmk1emRHRnJaVjkwYVcxbGMzUmhiWEF1WjJWMEtIVnpaWEpmWVdOamIzVnVkQ3dnVlVsdWREWTBLREFwS1Nrc0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0p6ZEdGclpWOTBhVzFsYzNSaGJYQWlDaUFnSUNCaGNIQmZiRzlqWVd4ZloyVjBYMlY0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIzTndhR1Z5WlM5amIyNTBjbUZqZEM1d2VUb3hNak10TVRJMkNpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNVVkWEJzWlNnb0NpQWdJQ0F2THlBZ0lDQWdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNTFjMlZ5WDNOb1lYSmxjeTVuWlhRb2RYTmxjbDloWTJOdmRXNTBMQ0JDYVdkVlNXNTBLREFwS1Nrc0NpQWdJQ0F2THlBZ0lDQWdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNXpkR0ZyWlY5MGFXMWxjM1JoYlhBdVoyVjBLSFZ6WlhKZllXTmpiM1Z1ZEN3Z1ZVbHVkRFkwS0RBcEtTa3NDaUFnSUNBdkx5QXBLUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZV3huYjNOd2FHVnlaUzVqYjI1MGNtRmpkQzVCYkdkdlUzQm9aWEpsTG05d2RGOXBiaWdwSUMwK0lIWnZhV1E2Q205d2RGOXBiam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2YzNCb1pYSmxMMk52Ym5SeVlXTjBMbkI1T2pFek1TMHhNeklLSUNBZ0lDOHZJQ01nU1c1cGRHbGhiR2w2WlNCMWMyVnlJR3h2WTJGc0lITjBZWFJsQ2lBZ0lDQXZMeUJ6Wld4bUxuVnpaWEpmYzJoaGNtVnpXMVI0Ymk1elpXNWtaWEpkSUQwZ1FtbG5WVWx1ZENnd0tRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZbmwwWldOZk15QXZMeUFpZFhObGNsOXphR0Z5WlhNaUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNENpQWdJQ0JoY0hCZmJHOWpZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIzTndhR1Z5WlM5amIyNTBjbUZqZEM1d2VUb3hNek1LSUNBZ0lDOHZJSE5sYkdZdWMzUmhhMlZmZEdsdFpYTjBZVzF3VzFSNGJpNXpaVzVrWlhKZElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKemRHRnJaVjkwYVcxbGMzUmhiWEFpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMnh2WTJGc1gzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFEQUFFSUpnZ01kRzkwWVd4ZmMzUmhhMlZrQUF4MGIzUmhiRjl6YUdGeVpYTUxkWE5sY2w5emFHRnlaWE1MYzJoaGNtVmZjSEpwWTJVUGMzUmhhMlZmZEdsdFpYTjBZVzF3QkJVZmZIVUREMEpBTVJ0QkFER0NCZ1QrVjVPUkJKTGdPeHdFSWZIZC93UzJwOWlXQkNrSVJkd0VNTWJWaWpZYUFJNEdBRTRBUWdBekFDSUFEZ0FDSWtNeEdSUkVNUmhFaUFGVkkwTXhHUlJFTVJoRU5ob0JpQUVlSndaTVVMQWpRekVaRkVReEdFU0lBTjhuQmt4UXNDTkRNUmtVUkRFWVJEWWFBWWdBZmlORE1Sa1VSREVZUklnQU1TTkRNUmtVUkRFWUZFUTJHZ0dJQUFJalE0b0JBREVBTWdrU1JJQUZZV1J0YVc2TC8yY25CQ2NIWnlncFp5b3BaNGt4Q0lIQWhEMFBSREVJRmtrbkI2TWlKd1JsUktJaUtHVkVUd0tnS0V4bklpcGxSRXNCb0NwTVp6RUFJaXRqS1U0Q1RhQXhBQ3RQQW1ZeEFDY0ZNZ2RtaVlvQkFERUFJaXRqS1U0Q1RZdi9GMGtXU3dKTEFhZEVNZ3B6QUVSTEFnOUVJaWhsUkVzQm9TaE1aeUlxWlVSTEFhRXFUR2RQQWt5aE1RQXJUd0ptc1RFQXNnZXlDQ095RUNLeUFiT0pJaWhsUkVrVkpBNUVKSzlNU3dHcklpcGxSRWtWSkE1RVN3S3JJaWNFWlVSSkZTUU9SRThEcTA0Q1VFeFFpWW9CQVl2L0ZZRWdFa1NML3lJcll5bE9BazFKRlNRT1JDU3ZxNHYvSWljRll5Sk9BazBXVUlreEFDc3BaakVBSndVaVpvaz0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjoxMCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
