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

namespace Arc56.Generated.MitudruDutta.Marlin.PTToken_2fa06b5c
{


    //
    // Principal Token contract for yield tokenization
    //
    public class PTTokenProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PTTokenProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetTokenInfoReturn : AVMObjectType
            {
                public string Field0 { get; set; }

                public string Field1 { get; set; }

                public ulong Field2 { get; set; }

                public ulong Field3 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField0.From(Field0);
                    stringRef[ret.Count] = vField0.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField1.From(Field1);
                    stringRef[ret.Count] = vField1.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetTokenInfoReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new GetTokenInfoReturn();
                    uint count = 0;
                    var indexField0 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField0.Decode(bytes.Skip(indexField0 + prefixOffset).ToArray());
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is string vField0Value) { ret.Field0 = vField0Value; }
                    var indexField1 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField1.Decode(bytes.Skip(indexField1 + prefixOffset).ToArray());
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is string vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is ulong vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is ulong vField3Value) { ret.Field3 = vField3Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetTokenInfoReturn);
                }
                public bool Equals(GetTokenInfoReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetTokenInfoReturn left, GetTokenInfoReturn right)
                {
                    return EqualityComparer<GetTokenInfoReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetTokenInfoReturn left, GetTokenInfoReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Initialize PT token with maturity
        ///</summary>
        /// <param name="name"> </param>
        /// <param name="symbol"> </param>
        /// <param name="maturity_timestamp"> </param>
        public async Task<string> Initialize(string name, string symbol, ulong maturity_timestamp, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 75, 152, 109, 58 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var symbolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); symbolAbi.From(symbol);
            var maturity_timestampAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); maturity_timestampAbi.From(maturity_timestamp);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi, symbolAbi, maturity_timestampAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Initialize_Transactions(string name, string symbol, ulong maturity_timestamp, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 75, 152, 109, 58 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var symbolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); symbolAbi.From(symbol);
            var maturity_timestampAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); maturity_timestampAbi.From(maturity_timestamp);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi, symbolAbi, maturity_timestampAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Mint PT tokens to an address (owner only)
        ///</summary>
        /// <param name="to"> </param>
        /// <param name="amount"> </param>
        public async Task<string> Mint(byte[] to, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 121, 45, 161, 202 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); toAbi.From(to);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, toAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Mint_Transactions(byte[] to, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 121, 45, 161, 202 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); toAbi.From(to);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, toAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Burn PT tokens from sender's balance
        ///</summary>
        /// <param name="amount"> </param>
        public async Task<string> Burn(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 114, 60, 21, 59 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Burn_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 114, 60, 21, 59 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Transfer PT tokens to another address
        ///</summary>
        /// <param name="to"> </param>
        /// <param name="amount"> </param>
        public async Task<string> Transfer(byte[] to, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 123, 95, 111, 87 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); toAbi.From(to);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, toAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Transfer_Transactions(byte[] to, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 123, 95, 111, 87 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); toAbi.From(to);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, toAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get balance of an account
        ///</summary>
        /// <param name="account"> </param>
        public async Task<ulong> BalanceOf(byte[] account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 96, 165, 92, 230 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); accountAbi.From(account);

            var result = await base.SimApp(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> BalanceOf_Transactions(byte[] account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 96, 165, 92, 230 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get total supply of PT tokens
        ///</summary>
        public async Task<ulong> GetTotalSupply(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 144, 147, 85 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTotalSupply_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 144, 147, 85 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get maturity timestamp
        ///</summary>
        public async Task<ulong> GetMaturity(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 79, 55, 62, 136 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetMaturity_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 79, 55, 62, 136 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check if token has reached maturity
        ///</summary>
        public async Task<ulong> IsMature(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 172, 88, 173 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsMature_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 172, 88, 173 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get token information
        ///</summary>
        public async Task<Structs.GetTokenInfoReturn> GetTokenInfo(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 99, 175, 209 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetTokenInfoReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetTokenInfo_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 99, 175, 209 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Approve spender to spend tokens on behalf of sender
        ///</summary>
        /// <param name="spender"> </param>
        /// <param name="amount"> </param>
        public async Task<string> Approve(byte[] spender, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 31, 151, 254 };
            var spenderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); spenderAbi.From(spender);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, spenderAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Approve_Transactions(byte[] spender, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 31, 151, 254 };
            var spenderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); spenderAbi.From(spender);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, spenderAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get allowance for spender
        ///</summary>
        /// <param name="owner"> </param>
        /// <param name="spender"> </param>
        public async Task<ulong> GetAllowance(byte[] owner, byte[] spender, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 42, 21, 201, 136 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); ownerAbi.From(owner);
            var spenderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); spenderAbi.From(spender);

            var result = await base.SimApp(new List<object> { abiHandle, ownerAbi, spenderAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetAllowance_Transactions(byte[] owner, byte[] spender, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 42, 21, 201, 136 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); ownerAbi.From(owner);
            var spenderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); spenderAbi.From(spender);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi, spenderAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Transfer tokens from one address to another using allowance
        ///</summary>
        /// <param name="from_addr"> </param>
        /// <param name="to"> </param>
        /// <param name="amount"> </param>
        public async Task<string> TransferFrom(byte[] from_addr, byte[] to, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 201, 85, 253, 131 };
            var from_addrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); from_addrAbi.From(from_addr);
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); toAbi.From(to);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, from_addrAbi, toAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> TransferFrom_Transactions(byte[] from_addr, byte[] to, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 201, 85, 253, 131 };
            var from_addrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); from_addrAbi.From(from_addr);
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); toAbi.From(to);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, from_addrAbi, toAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update contract owner (current owner only)
        ///</summary>
        /// <param name="new_owner"> </param>
        public async Task<string> UpdateOwner(byte[] new_owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 238, 230, 25 };
            var new_ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); new_ownerAbi.From(new_owner);

            var result = await base.CallApp(new List<object> { abiHandle, new_ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> UpdateOwner_Transactions(byte[] new_owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 238, 230, 25 };
            var new_ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); new_ownerAbi.From(new_owner);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUFRUb2tlbiIsImRlc2MiOiJQcmluY2lwYWwgVG9rZW4gY29udHJhY3QgZm9yIHlpZWxkIHRva2VuaXphdGlvbiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJHZXRUb2tlbkluZm9SZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDMiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImluaXRpYWxpemUiLCJkZXNjIjoiSW5pdGlhbGl6ZSBQVCB0b2tlbiB3aXRoIG1hdHVyaXR5IiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN5bWJvbCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWF0dXJpdHlfdGltZXN0YW1wIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibWludCIsImRlc2MiOiJNaW50IFBUIHRva2VucyB0byBhbiBhZGRyZXNzIChvd25lciBvbmx5KSIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYnVybiIsImRlc2MiOiJCdXJuIFBUIHRva2VucyBmcm9tIHNlbmRlcidzIGJhbGFuY2UiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidHJhbnNmZXIiLCJkZXNjIjoiVHJhbnNmZXIgUFQgdG9rZW5zIHRvIGFub3RoZXIgYWRkcmVzcyIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYmFsYW5jZV9vZiIsImRlc2MiOiJHZXQgYmFsYW5jZSBvZiBhbiBhY2NvdW50IiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF90b3RhbF9zdXBwbHkiLCJkZXNjIjoiR2V0IHRvdGFsIHN1cHBseSBvZiBQVCB0b2tlbnMiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9tYXR1cml0eSIsImRlc2MiOiJHZXQgbWF0dXJpdHkgdGltZXN0YW1wIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpc19tYXR1cmUiLCJkZXNjIjoiQ2hlY2sgaWYgdG9rZW4gaGFzIHJlYWNoZWQgbWF0dXJpdHkiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF90b2tlbl9pbmZvIiwiZGVzYyI6IkdldCB0b2tlbiBpbmZvcm1hdGlvbiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIoc3RyaW5nLHN0cmluZyx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkdldFRva2VuSW5mb1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXBwcm92ZSIsImRlc2MiOiJBcHByb3ZlIHNwZW5kZXIgdG8gc3BlbmQgdG9rZW5zIG9uIGJlaGFsZiBvZiBzZW5kZXIiLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3BlbmRlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2FsbG93YW5jZSIsImRlc2MiOiJHZXQgYWxsb3dhbmNlIGZvciBzcGVuZGVyIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcGVuZGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0cmFuc2Zlcl9mcm9tIiwiZGVzYyI6IlRyYW5zZmVyIHRva2VucyBmcm9tIG9uZSBhZGRyZXNzIHRvIGFub3RoZXIgdXNpbmcgYWxsb3dhbmNlIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb21fYWRkciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZV9vd25lciIsImRlc2MiOiJVcGRhdGUgY29udHJhY3Qgb3duZXIgKGN1cnJlbnQgb3duZXIgb25seSkiLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X293bmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjMsImJ5dGVzIjozfSwibG9jYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls2ODYsNzg0LDg4NywxMTcwXSwiZXJyb3JNZXNzYWdlIjoiQW1vdW50IG11c3QgYmUgcG9zaXRpdmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTgyXSwiZXJyb3JNZXNzYWdlIjoiSW5zdWZmaWNpZW50IGFsbG93YW5jZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc5NSw4OTgsMTE5M10sImVycm9yTWVzc2FnZSI6Ikluc3VmZmljaWVudCBiYWxhbmNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTY4XSwiZXJyb3JNZXNzYWdlIjoiTWF0dXJpdHkgbXVzdCBiZSBpbiBmdXR1cmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODcsMjE3LDI1NywyODYsMzIwLDMzNiwzNTMsMzcwLDM4Nyw0MTAsNDQ0LDQ3Miw1MDZdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NjJdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGNyZWF0b3IgY2FuIGluaXRpYWxpemUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2ODNdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IG93bmVyIGNhbiBtaW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI5OV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgb3duZXIgY2FuIHVwZGF0ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU1MV0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5MCwyMjAsMjYwLDI4OSwzMjMsMzM5LDM1NiwzNzMsMzkwLDQxMyw0NDcsNDc1LDUwOV0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTYzLDExNzddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFsbG93YW5jZSBleGlzdHMgZm9yIGFjY291bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MDIsNzkwLDg5Myw5OTMsMTE4OF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYmFsYW5jZSBleGlzdHMgZm9yIGFjY291bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDUxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5kZWNpbWFscyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDA0LDEwMTJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm1hdHVyaXR5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMjVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm5hbWUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjgxLDEyOTddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm93bmVyIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMzhdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnN5bWJvbCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2OTAsODA4LDk5OCwxMDU2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b3RhbF9zdXBwbHkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjSFJmZEc5clpXNHVZMjl1ZEhKaFkzUXVVRlJVYjJ0bGJpNWZYMkZzWjI5d2VWOWxiblJ5ZVhCdmFXNTBYM2RwZEdoZmFXNXBkQ2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVLSUNBZ0lHSjVkR1ZqWW14dlkyc2dNSGd4TlRGbU4yTTNOU0FpWW1Gc1lXNWpaU0lnSW5SdmRHRnNYM04xY0hCc2VTSWdJbTkzYm1WeUlpQWlZV3hzYjNkaGJtTmxJaUFpYldGMGRYSnBkSGtpSUNKdVlXMWxJaUFpYzNsdFltOXNJaUFpWkdWamFXMWhiSE1pQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSFJmZEc5clpXNHZZMjl1ZEhKaFkzUXVjSGs2TXpBS0lDQWdJQzh2SUdOc1lYTnpJRkJVVkc5clpXNG9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMkpoY21WZmNtOTFkR2x1WjBBeE9Bb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VEUmlPVGcyWkROaElEQjROemt5WkdFeFkyRWdNSGczTWpOak1UVXpZaUF3ZURkaU5XWTJaalUzSURCNE5qQmhOVFZqWlRZZ01IZzBOamt3T1RNMU5TQXdlRFJtTXpjelpUZzRJREI0T0RSaFl6VTRZV1FnTUhnME5qWXpZV1prTVNBd2VEVmlNV1k1TjJabElEQjRNbUV4TldNNU9EZ2dNSGhqT1RVMVptUTRNeUF3ZUdKbFpXVmxOakU1SUM4dklHMWxkR2h2WkNBaWFXNXBkR2xoYkdsNlpTaHpkSEpwYm1jc2MzUnlhVzVuTEhWcGJuUTJOQ2x6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJbTFwYm5Rb1lubDBaVnRkTEhWcGJuUTJOQ2x6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJbUoxY200b2RXbHVkRFkwS1hOMGNtbHVaeUlzSUcxbGRHaHZaQ0FpZEhKaGJuTm1aWElvWW5sMFpWdGRMSFZwYm5RMk5DbHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0ltSmhiR0Z1WTJWZmIyWW9ZbmwwWlZ0ZEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVoyVjBYM1J2ZEdGc1gzTjFjSEJzZVNncGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKblpYUmZiV0YwZFhKcGRIa29LWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlhWE5mYldGMGRYSmxLQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbWRsZEY5MGIydGxibDlwYm1adktDa29jM1J5YVc1bkxITjBjbWx1Wnl4MWFXNTBOalFzZFdsdWREWTBLU0lzSUcxbGRHaHZaQ0FpWVhCd2NtOTJaU2hpZVhSbFcxMHNkV2x1ZERZMEtYTjBjbWx1WnlJc0lHMWxkR2h2WkNBaVoyVjBYMkZzYkc5M1lXNWpaU2hpZVhSbFcxMHNZbmwwWlZ0ZEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaWRISmhibk5tWlhKZlpuSnZiU2hpZVhSbFcxMHNZbmwwWlZ0ZExIVnBiblEyTkNsemRISnBibWNpTENCdFpYUm9iMlFnSW5Wd1pHRjBaVjl2ZDI1bGNpaGllWFJsVzEwcGMzUnlhVzVuSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JXRnBibDlwYm1sMGFXRnNhWHBsWDNKdmRYUmxRRFVnYldGcGJsOXRhVzUwWDNKdmRYUmxRRFlnYldGcGJsOWlkWEp1WDNKdmRYUmxRRGNnYldGcGJsOTBjbUZ1YzJabGNsOXliM1YwWlVBNElHMWhhVzVmWW1Gc1lXNWpaVjl2Wmw5eWIzVjBaVUE1SUcxaGFXNWZaMlYwWDNSdmRHRnNYM04xY0hCc2VWOXliM1YwWlVBeE1DQnRZV2x1WDJkbGRGOXRZWFIxY21sMGVWOXliM1YwWlVBeE1TQnRZV2x1WDJselgyMWhkSFZ5WlY5eWIzVjBaVUF4TWlCdFlXbHVYMmRsZEY5MGIydGxibDlwYm1adlgzSnZkWFJsUURFeklHMWhhVzVmWVhCd2NtOTJaVjl5YjNWMFpVQXhOQ0J0WVdsdVgyZGxkRjloYkd4dmQyRnVZMlZmY205MWRHVkFNVFVnYldGcGJsOTBjbUZ1YzJabGNsOW1jbTl0WDNKdmRYUmxRREUySUcxaGFXNWZkWEJrWVhSbFgyOTNibVZ5WDNKdmRYUmxRREUzQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNIUmZkRzlyWlc0dlkyOXVkSEpoWTNRdWNIazZNekFLSUNBZ0lDOHZJR05zWVhOeklGQlVWRzlyWlc0b1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkWEJrWVhSbFgyOTNibVZ5WDNKdmRYUmxRREUzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0IwWDNSdmEyVnVMMk52Ym5SeVlXTjBMbkI1T2pFNE13b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdkRjkwYjJ0bGJpOWpiMjUwY21GamRDNXdlVG96TUFvZ0lDQWdMeThnWTJ4aGMzTWdVRlJVYjJ0bGJpaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdkRjkwYjJ0bGJpOWpiMjUwY21GamRDNXdlVG94T0RNS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ1kyRnNiSE4xWWlCMWNHUmhkR1ZmYjNkdVpYSUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNSeVlXNXpabVZ5WDJaeWIyMWZjbTkxZEdWQU1UWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNIUmZkRzlyWlc0dlkyOXVkSEpoWTNRdWNIazZNVFl6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCMFgzUnZhMlZ1TDJOdmJuUnlZV04wTG5CNU9qTXdDaUFnSUNBdkx5QmpiR0Z6Y3lCUVZGUnZhMlZ1S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3ZEY5MGIydGxiaTlqYjI1MGNtRmpkQzV3ZVRveE5qTUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdZMkZzYkhOMVlpQjBjbUZ1YzJabGNsOW1jbTl0Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJmWVd4c2IzZGhibU5sWDNKdmRYUmxRREUxT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0IwWDNSdmEyVnVMMk52Ym5SeVlXTjBMbkI1T2pFMU53b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2RGOTBiMnRsYmk5amIyNTBjbUZqZEM1d2VUb3pNQW9nSUNBZ0x5OGdZMnhoYzNNZ1VGUlViMnRsYmloQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hSZmRHOXJaVzR2WTI5dWRISmhZM1F1Y0hrNk1UVTNDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBYMkZzYkc5M1lXNWpaUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWhjSEJ5YjNabFgzSnZkWFJsUURFME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCMFgzUnZhMlZ1TDJOdmJuUnlZV04wTG5CNU9qRTBPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3ZEY5MGIydGxiaTlqYjI1MGNtRmpkQzV3ZVRvek1Bb2dJQ0FnTHk4Z1kyeGhjM01nVUZSVWIydGxiaWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3ZEY5MGIydGxiaTlqYjI1MGNtRmpkQzV3ZVRveE5Ea0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdZMkZzYkhOMVlpQmhjSEJ5YjNabENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlhSZmRHOXJaVzVmYVc1bWIxOXliM1YwWlVBeE16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2RGOTBiMnRsYmk5amIyNTBjbUZqZEM1d2VUb3hNemtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQmpZV3hzYzNWaUlHZGxkRjkwYjJ0bGJsOXBibVp2Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmx6WDIxaGRIVnlaVjl5YjNWMFpVQXhNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdkRjkwYjJ0bGJpOWpiMjUwY21GamRDNXdlVG94TXpFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JqWVd4c2MzVmlJR2x6WDIxaGRIVnlaUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJmYldGMGRYSnBkSGxmY205MWRHVkFNVEU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSFJmZEc5clpXNHZZMjl1ZEhKaFkzUXVjSGs2TVRJMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnWTJGc2JITjFZaUJuWlhSZmJXRjBkWEpwZEhrS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWjJWMFgzUnZkR0ZzWDNOMWNIQnNlVjl5YjNWMFpVQXhNRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdkRjkwYjJ0bGJpOWpiMjUwY21GamRDNXdlVG94TWpFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JqWVd4c2MzVmlJR2RsZEY5MGIzUmhiRjl6ZFhCd2JIa0tJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlltRnNZVzVqWlY5dlpsOXliM1YwWlVBNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCMFgzUnZhMlZ1TDJOdmJuUnlZV04wTG5CNU9qRXhOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdkRjkwYjJ0bGJpOWpiMjUwY21GamRDNXdlVG96TUFvZ0lDQWdMeThnWTJ4aGMzTWdVRlJVYjJ0bGJpaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdkRjkwYjJ0bGJpOWpiMjUwY21GamRDNXdlVG94TVRVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWTJGc2JITjFZaUJpWVd4aGJtTmxYMjltQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1J5WVc1elptVnlYM0p2ZFhSbFFEZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNIUmZkRzlyWlc0dlkyOXVkSEpoWTNRdWNIazZPVGdLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hSZmRHOXJaVzR2WTI5dWRISmhZM1F1Y0hrNk16QUtJQ0FnSUM4dklHTnNZWE56SUZCVVZHOXJaVzRvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hSZmRHOXJaVzR2WTI5dWRISmhZM1F1Y0hrNk9UZ0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdZMkZzYkhOMVlpQjBjbUZ1YzJabGNnb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWW5WeWJsOXliM1YwWlVBM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCMFgzUnZhMlZ1TDJOdmJuUnlZV04wTG5CNU9qZ3pDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0IwWDNSdmEyVnVMMk52Ym5SeVlXTjBMbkI1T2pNd0NpQWdJQ0F2THlCamJHRnpjeUJRVkZSdmEyVnVLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hSZmRHOXJaVzR2WTI5dWRISmhZM1F1Y0hrNk9ETUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdZMkZzYkhOMVlpQmlkWEp1Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXRhVzUwWDNKdmRYUmxRRFk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSFJmZEc5clpXNHZZMjl1ZEhKaFkzUXVjSGs2TmpjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNIUmZkRzlyWlc0dlkyOXVkSEpoWTNRdWNIazZNekFLSUNBZ0lDOHZJR05zWVhOeklGQlVWRzlyWlc0b1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNIUmZkRzlyWlc0dlkyOXVkSEpoWTNRdWNIazZOamNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnWTJGc2JITjFZaUJ0YVc1MENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlwYm1sMGFXRnNhWHBsWDNKdmRYUmxRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSFJmZEc5clpXNHZZMjl1ZEhKaFkzUXVjSGs2TkRZS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNIUmZkRzlyWlc0dlkyOXVkSEpoWTNRdWNIazZNekFLSUNBZ0lDOHZJR05zWVhOeklGQlVWRzlyWlc0b1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCMFgzUnZhMlZ1TDJOdmJuUnlZV04wTG5CNU9qUTJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR05oYkd4emRXSWdhVzVwZEdsaGJHbDZaUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlltRnlaVjl5YjNWMGFXNW5RREU0T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0IwWDNSdmEyVnVMMk52Ym5SeVlXTjBMbkI1T2pNd0NpQWdJQ0F2THlCamJHRnpjeUJRVkZSdmEyVnVLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJqY21WaGRHbHVad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1d2RGOTBiMnRsYmk1amIyNTBjbUZqZEM1UVZGUnZhMlZ1TG1sdWFYUnBZV3hwZW1Vb2JtRnRaVG9nWW5sMFpYTXNJSE41YldKdmJEb2dZbmwwWlhNc0lHMWhkSFZ5YVhSNVgzUnBiV1Z6ZEdGdGNEb2dkV2x1ZERZMEtTQXRQaUJpZVhSbGN6b0thVzVwZEdsaGJHbDZaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdkRjkwYjJ0bGJpOWpiMjUwY21GamRDNXdlVG8wTmkwMU1nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQXZMeUJrWldZZ2FXNXBkR2xoYkdsNlpTZ0tJQ0FnSUM4dklDQWdJQ0J6Wld4bUxBb2dJQ0FnTHk4Z0lDQWdJRzVoYldVNklGTjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQnplVzFpYjJ3NklGTjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQnRZWFIxY21sMGVWOTBhVzFsYzNSaGJYQTZJRlZKYm5RMk5Dd0tJQ0FnSUM4dklDa2dMVDRnVTNSeWFXNW5PZ29nSUNBZ2NISnZkRzhnTXlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hSZmRHOXJaVzR2WTI5dWRISmhZM1F1Y0hrNk5UUUtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJRWRzYjJKaGJDNWpjbVZoZEc5eVgyRmtaSEpsYzNNc0lDSlBibXg1SUdOeVpXRjBiM0lnWTJGdUlHbHVhWFJwWVd4cGVtVWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JuYkc5aVlXd2dRM0psWVhSdmNrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCamNtVmhkRzl5SUdOaGJpQnBibWwwYVdGc2FYcGxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNIUmZkRzlyWlc0dlkyOXVkSEpoWTNRdWNIazZOVFVLSUNBZ0lDOHZJR0Z6YzJWeWRDQnRZWFIxY21sMGVWOTBhVzFsYzNSaGJYQWdQaUJIYkc5aVlXd3ViR0YwWlhOMFgzUnBiV1Z6ZEdGdGNDd2dJazFoZEhWeWFYUjVJRzExYzNRZ1ltVWdhVzRnWm5WMGRYSmxJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbmJHOWlZV3dnVEdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNBK0NpQWdJQ0JoYzNObGNuUWdMeThnVFdGMGRYSnBkSGtnYlhWemRDQmlaU0JwYmlCbWRYUjFjbVVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdkRjkwYjJ0bGJpOWpiMjUwY21GamRDNXdlVG8xTndvZ0lDQWdMeThnYzJWc1ppNXZkMjVsY2k1MllXeDFaU0E5SUZSNGJpNXpaVzVrWlhJdVlubDBaWE1LSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbTkzYm1WeUlnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3ZEY5MGIydGxiaTlqYjI1MGNtRmpkQzV3ZVRvMU9Bb2dJQ0FnTHk4Z2MyVnNaaTV1WVcxbExuWmhiSFZsSUQwZ2JtRnRaUW9nSUNBZ1lubDBaV01nTmlBdkx5QWlibUZ0WlNJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3ZEY5MGIydGxiaTlqYjI1MGNtRmpkQzV3ZVRvMU9Rb2dJQ0FnTHk4Z2MyVnNaaTV6ZVcxaWIyd3VkbUZzZFdVZ1BTQnplVzFpYjJ3S0lDQWdJR0o1ZEdWaklEY2dMeThnSW5ONWJXSnZiQ0lLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdkRjkwYjJ0bGJpOWpiMjUwY21GamRDNXdlVG8yTUFvZ0lDQWdMeThnYzJWc1ppNXRZWFIxY21sMGVTNTJZV3gxWlNBOUlHMWhkSFZ5YVhSNVgzUnBiV1Z6ZEdGdGNBb2dJQ0FnWW5sMFpXTWdOU0F2THlBaWJXRjBkWEpwZEhraUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hSZmRHOXJaVzR2WTI5dWRISmhZM1F1Y0hrNk5qRUtJQ0FnSUM4dklITmxiR1l1ZEc5MFlXeGZjM1Z3Y0d4NUxuWmhiSFZsSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKMGIzUmhiRjl6ZFhCd2JIa2lDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2RGOTBiMnRsYmk5amIyNTBjbUZqZEM1d2VUbzJNZ29nSUNBZ0x5OGdjMlZzWmk1a1pXTnBiV0ZzY3k1MllXeDFaU0E5SUZWSmJuUTJOQ2c0S1FvZ0lDQWdZbmwwWldNZ09DQXZMeUFpWkdWamFXMWhiSE1pQ2lBZ0lDQndkWE5vYVc1MElEZ2dMeThnT0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3ZEY5MGIydGxiaTlqYjI1MGNtRmpkQzV3ZVRvMk5Bb2dJQ0FnTHk4Z2JHOW5LR0lpVUZRZ1ZHOXJaVzRnYVc1cGRHbGhiR2w2WldRZ0xTQk5ZWFIxY21sMGVUb2dJaUFySUc5d0xtbDBiMklvYldGMGRYSnBkSGxmZEdsdFpYTjBZVzF3S1NrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhWFJ2WWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TlRBMU5ESXdOVFEyWmpaaU5qVTJaVEl3TmprMlpUWTVOelEyT1RZeE5tTTJPVGRoTmpVMk5ESXdNbVF5TURSa05qRTNORGMxTnpJMk9UYzBOemt6WVRJd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCMFgzUnZhMlZ1TDJOdmJuUnlZV04wTG5CNU9qWTFDaUFnSUNBdkx5QnlaWFIxY200Z1UzUnlhVzVuS0NKUVZDQlViMnRsYmlCcGJtbDBhV0ZzYVhwbFpDQnpkV05qWlhOelpuVnNiSGtpS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pRVkNCVWIydGxiaUJwYm1sMGFXRnNhWHBsWkNCemRXTmpaWE56Wm5Wc2JIa2lDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWNIUmZkRzlyWlc0dVkyOXVkSEpoWTNRdVVGUlViMnRsYmk1dGFXNTBLSFJ2T2lCaWVYUmxjeXdnWVcxdmRXNTBPaUIxYVc1ME5qUXBJQzArSUdKNWRHVnpPZ3B0YVc1ME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCMFgzUnZhMlZ1TDJOdmJuUnlZV04wTG5CNU9qWTNMVFk0Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUM4dklHUmxaaUJ0YVc1MEtITmxiR1lzSUhSdk9pQkNlWFJsY3l3Z1lXMXZkVzUwT2lCVlNXNTBOalFwSUMwK0lGTjBjbWx1WnpvS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQjBYM1J2YTJWdUwyTnZiblJ5WVdOMExuQjVPamN3Q2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaTVpZVhSbGN5QTlQU0J6Wld4bUxtOTNibVZ5TG5aaGJIVmxMQ0FpVDI1c2VTQnZkMjVsY2lCallXNGdiV2x1ZENJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSnZkMjVsY2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXZkMjVsY2lCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0J2ZDI1bGNpQmpZVzRnYldsdWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCMFgzUnZhMlZ1TDJOdmJuUnlZV04wTG5CNU9qY3hDaUFnSUNBdkx5QmhjM05sY25RZ1lXMXZkVzUwSUQ0Z1ZVbHVkRFkwS0RBcExDQWlRVzF2ZFc1MElHMTFjM1FnWW1VZ2NHOXphWFJwZG1VaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0Z6YzJWeWRDQXZMeUJCYlc5MWJuUWdiWFZ6ZENCaVpTQndiM05wZEdsMlpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCMFgzUnZhMlZ1TDJOdmJuUnlZV04wTG5CNU9qY3pMVGMwQ2lBZ0lDQXZMeUFqSUZWd1pHRjBaU0IwYjNSaGJDQnpkWEJ3YkhrS0lDQWdJQzh2SUhObGJHWXVkRzkwWVd4ZmMzVndjR3g1TG5aaGJIVmxJRDBnYzJWc1ppNTBiM1JoYkY5emRYQndiSGt1ZG1Gc2RXVWdLeUJoYlc5MWJuUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKMGIzUmhiRjl6ZFhCd2JIa2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEc5MFlXeGZjM1Z3Y0d4NUlHVjRhWE4wY3dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZMTh5SUM4dklDSjBiM1JoYkY5emRYQndiSGtpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0IwWDNSdmEyVnVMMk52Ym5SeVlXTjBMbkI1T2pjMkxUYzRDaUFnSUNBdkx5QWpJRlZ3WkdGMFpTQnlaV05wY0dsbGJuUWdZbUZzWVc1alpTQW9jMmx0Y0d4cFptbGxaQ0F0SUdsdUlIQnliMlIxWTNScGIyNGdkMjkxYkdRZ2JtVmxaQ0J3Y205d1pYSWdZV1JrY21WemN5Qm9ZVzVrYkdsdVp5a0tJQ0FnSUM4dklDTWdSbTl5SUc1dmR5d2diV2x1ZENCMGJ5QnpaVzVrWlhJS0lDQWdJQzh2SUhObGJHWXVZbUZzWVc1alpWdFVlRzR1YzJWdVpHVnlYU0E5SUhObGJHWXVZbUZzWVc1alpWdFVlRzR1YzJWdVpHVnlYU0FySUdGdGIzVnVkQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1KaGJHRnVZMlVpQ2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aVlXeGhibU5sSUdWNGFYTjBjeUJtYjNJZ1lXTmpiM1Z1ZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQXJDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKaVlXeGhibU5sSWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNIUmZkRzlyWlc0dlkyOXVkSEpoWTNRdWNIazZPREFLSUNBZ0lDOHZJR3h2WnloaUlsQlVJSFJ2YTJWdWN5QnRhVzUwWldRZ0xTQkJiVzkxYm5RNklDSWdLeUJ2Y0M1cGRHOWlLR0Z0YjNWdWRDa3BDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsMGIySUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEVXdOVFF5TURjME5tWTJZalkxTm1VM016SXdObVEyT1RabE56UTJOVFkwTWpBeVpESXdOREUyWkRabU56VTJaVGMwTTJFeU1Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2RGOTBiMnRsYmk5amIyNTBjbUZqZEM1d2VUbzRNUW9nSUNBZ0x5OGdjbVYwZFhKdUlGTjBjbWx1WnlnaVVGUWdkRzlyWlc1eklHMXBiblJsWkNCemRXTmpaWE56Wm5Wc2JIa2lLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSlFWQ0IwYjJ0bGJuTWdiV2x1ZEdWa0lITjFZMk5sYzNObWRXeHNlU0lLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXdkRjkwYjJ0bGJpNWpiMjUwY21GamRDNVFWRlJ2YTJWdUxtSjFjbTRvWVcxdmRXNTBPaUIxYVc1ME5qUXBJQzArSUdKNWRHVnpPZ3BpZFhKdU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCMFgzUnZhMlZ1TDJOdmJuUnlZV04wTG5CNU9qZ3pMVGcwQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUM4dklHUmxaaUJpZFhKdUtITmxiR1lzSUdGdGIzVnVkRG9nVlVsdWREWTBLU0F0UGlCVGRISnBibWM2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2RGOTBiMnRsYmk5amIyNTBjbUZqZEM1d2VUbzROZ29nSUNBZ0x5OGdZWE56WlhKMElHRnRiM1Z1ZENBK0lGVkpiblEyTkNnd0tTd2dJa0Z0YjNWdWRDQnRkWE4wSUdKbElIQnZjMmwwYVhabElnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JoYzNObGNuUWdMeThnUVcxdmRXNTBJRzExYzNRZ1ltVWdjRzl6YVhScGRtVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2RGOTBiMnRsYmk5amIyNTBjbUZqZEM1d2VUbzRPQW9nSUNBZ0x5OGdZM1Z5Y21WdWRGOWlZV3hoYm1ObElEMGdjMlZzWmk1aVlXeGhibU5sVzFSNGJpNXpaVzVrWlhKZENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZbUZzWVc1alpTSUtJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUpoYkdGdVkyVWdaWGhwYzNSeklHWnZjaUJoWTJOdmRXNTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNIUmZkRzlyWlc0dlkyOXVkSEpoWTNRdWNIazZPRGtLSUNBZ0lDOHZJR0Z6YzJWeWRDQmpkWEp5Wlc1MFgySmhiR0Z1WTJVZ1BqMGdZVzF2ZFc1MExDQWlTVzV6ZFdabWFXTnBaVzUwSUdKaGJHRnVZMlVpQ2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1BqMEtJQ0FnSUdGemMyVnlkQ0F2THlCSmJuTjFabVpwWTJsbGJuUWdZbUZzWVc1alpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCMFgzUnZhMlZ1TDJOdmJuUnlZV04wTG5CNU9qa3hMVGt5Q2lBZ0lDQXZMeUFqSUZWd1pHRjBaU0JpWVd4aGJtTmxjd29nSUNBZ0x5OGdjMlZzWmk1aVlXeGhibU5sVzFSNGJpNXpaVzVrWlhKZElEMGdZM1Z5Y21WdWRGOWlZV3hoYm1ObElDMGdZVzF2ZFc1MENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJQzBLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltSmhiR0Z1WTJVaUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHRndjRjlzYjJOaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdkRjkwYjJ0bGJpOWpiMjUwY21GamRDNXdlVG81TXdvZ0lDQWdMeThnYzJWc1ppNTBiM1JoYkY5emRYQndiSGt1ZG1Gc2RXVWdQU0J6Wld4bUxuUnZkR0ZzWDNOMWNIQnNlUzUyWVd4MVpTQXRJR0Z0YjNWdWRBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5SdmRHRnNYM04xY0hCc2VTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjNSaGJGOXpkWEJ3YkhrZ1pYaHBjM1J6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lDMEtJQ0FnSUdKNWRHVmpYeklnTHk4Z0luUnZkR0ZzWDNOMWNIQnNlU0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSFJmZEc5clpXNHZZMjl1ZEhKaFkzUXVjSGs2T1RVS0lDQWdJQzh2SUd4dlp5aGlJbEJVSUhSdmEyVnVjeUJpZFhKdVpXUWdMU0JCYlc5MWJuUTZJQ0lnS3lCdmNDNXBkRzlpS0dGdGIzVnVkQ2twQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbDBiMklLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFV3TlRReU1EYzBObVkyWWpZMU5tVTNNekl3TmpJM05UY3lObVUyTlRZME1qQXlaREl3TkRFMlpEWm1OelUyWlRjME0yRXlNQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdkRjkwYjJ0bGJpOWpiMjUwY21GamRDNXdlVG81TmdvZ0lDQWdMeThnY21WMGRYSnVJRk4wY21sdVp5Z2lVRlFnZEc5clpXNXpJR0oxY201bFpDQnpkV05qWlhOelpuVnNiSGtpS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pRVkNCMGIydGxibk1nWW5WeWJtVmtJSE4xWTJObGMzTm1kV3hzZVNJS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV3ZEY5MGIydGxiaTVqYjI1MGNtRmpkQzVRVkZSdmEyVnVMblJ5WVc1elptVnlLSFJ2T2lCaWVYUmxjeXdnWVcxdmRXNTBPaUIxYVc1ME5qUXBJQzArSUdKNWRHVnpPZ3AwY21GdWMyWmxjam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdkRjkwYjJ0bGJpOWpiMjUwY21GamRDNXdlVG81T0MwNU9Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQXZMeUJrWldZZ2RISmhibk5tWlhJb2MyVnNaaXdnZEc4NklFSjVkR1Z6TENCaGJXOTFiblE2SUZWSmJuUTJOQ2tnTFQ0Z1UzUnlhVzVuT2dvZ0lDQWdjSEp2ZEc4Z01pQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNIUmZkRzlyWlc0dlkyOXVkSEpoWTNRdWNIazZNVEF4Q2lBZ0lDQXZMeUJoYzNObGNuUWdZVzF2ZFc1MElENGdWVWx1ZERZMEtEQXBMQ0FpUVcxdmRXNTBJRzExYzNRZ1ltVWdjRzl6YVhScGRtVWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdGemMyVnlkQ0F2THlCQmJXOTFiblFnYlhWemRDQmlaU0J3YjNOcGRHbDJaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQjBYM1J2YTJWdUwyTnZiblJ5WVdOMExuQjVPakV3TXdvZ0lDQWdMeThnYzJWdVpHVnlYMkpoYkdGdVkyVWdQU0J6Wld4bUxtSmhiR0Z1WTJWYlZIaHVMbk5sYm1SbGNsMEtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0ppWVd4aGJtTmxJZ29nSUNBZ1lYQndYMnh2WTJGc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WW1Gc1lXNWpaU0JsZUdsemRITWdabTl5SUdGalkyOTFiblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdkRjkwYjJ0bGJpOWpiMjUwY21GamRDNXdlVG94TURRS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wlc1a1pYSmZZbUZzWVc1alpTQStQU0JoYlc5MWJuUXNJQ0pKYm5OMVptWnBZMmxsYm5RZ1ltRnNZVzVqWlNJS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQStQUW9nSUNBZ1lYTnpaWEowSUM4dklFbHVjM1ZtWm1samFXVnVkQ0JpWVd4aGJtTmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNIUmZkRzlyWlc0dlkyOXVkSEpoWTNRdWNIazZNVEEyTFRFd053b2dJQ0FnTHk4Z0l5QlZjR1JoZEdVZ2MyVnVaR1Z5SUdKaGJHRnVZMlVLSUNBZ0lDOHZJSE5sYkdZdVltRnNZVzVqWlZ0VWVHNHVjMlZ1WkdWeVhTQTlJSE5sYm1SbGNsOWlZV3hoYm1ObElDMGdZVzF2ZFc1MENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJQzBLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltSmhiR0Z1WTJVaUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHRndjRjlzYjJOaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdkRjkwYjJ0bGJpOWpiMjUwY21GamRDNXdlVG94TVRJS0lDQWdJQzh2SUd4dlp5aGlJbEJVSUhSdmEyVnVjeUIwY21GdWMyWmxjbkpsWkNBdElFRnRiM1Z1ZERvZ0lpQXJJRzl3TG1sMGIySW9ZVzF2ZFc1MEtTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVhSdllnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5UQTFOREl3TnpRMlpqWmlOalUyWlRjek1qQTNORGN5TmpFMlpUY3pOalkyTlRjeU56STJOVFkwTWpBeVpESXdOREUyWkRabU56VTJaVGMwTTJFeU1Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2RGOTBiMnRsYmk5amIyNTBjbUZqZEM1d2VUb3hNVE1LSUNBZ0lDOHZJSEpsZEhWeWJpQlRkSEpwYm1jb0lsQlVJSFJ2YTJWdWN5QjBjbUZ1YzJabGNuSmxaQ0J6ZFdOalpYTnpablZzYkhraUtRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKUVZDQjBiMnRsYm5NZ2RISmhibk5tWlhKeVpXUWdjM1ZqWTJWemMyWjFiR3g1SWdvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbkIwWDNSdmEyVnVMbU52Ym5SeVlXTjBMbEJVVkc5clpXNHVZbUZzWVc1alpWOXZaaWhoWTJOdmRXNTBPaUJpZVhSbGN5a2dMVDRnZFdsdWREWTBPZ3BpWVd4aGJtTmxYMjltT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0IwWDNSdmEyVnVMMk52Ym5SeVlXTjBMbkI1T2pFeE5TMHhNVFlLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdMeThnWkdWbUlHSmhiR0Z1WTJWZmIyWW9jMlZzWml3Z1lXTmpiM1Z1ZERvZ1FubDBaWE1wSUMwK0lGVkpiblEyTkRvS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQjBYM1J2YTJWdUwyTnZiblJ5WVdOMExuQjVPakV4T0MweE1Ua0tJQ0FnSUM4dklDTWdVMmx0Y0d4cFptbGxaQ0F0SUhKbGRIVnlibk1nYzJWdVpHVnlKM01nWW1Gc1lXNWpaUW9nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1WW1Gc1lXNWpaVnRVZUc0dWMyVnVaR1Z5WFFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltSmhiR0Z1WTJVaUNpQWdJQ0JoY0hCZmJHOWpZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWlZV3hoYm1ObElHVjRhWE4wY3lCbWIzSWdZV05qYjNWdWRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5CMFgzUnZhMlZ1TG1OdmJuUnlZV04wTGxCVVZHOXJaVzR1WjJWMFgzUnZkR0ZzWDNOMWNIQnNlU2dwSUMwK0lIVnBiblEyTkRvS1oyVjBYM1J2ZEdGc1gzTjFjSEJzZVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3ZEY5MGIydGxiaTlqYjI1MGNtRmpkQzV3ZVRveE1qUUtJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MblJ2ZEdGc1gzTjFjSEJzZVM1MllXeDFaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0luUnZkR0ZzWDNOMWNIQnNlU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGIzUmhiRjl6ZFhCd2JIa2daWGhwYzNSekNpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Y0hSZmRHOXJaVzR1WTI5dWRISmhZM1F1VUZSVWIydGxiaTVuWlhSZmJXRjBkWEpwZEhrb0tTQXRQaUIxYVc1ME5qUTZDbWRsZEY5dFlYUjFjbWwwZVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3ZEY5MGIydGxiaTlqYjI1MGNtRmpkQzV3ZVRveE1qa0tJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MbTFoZEhWeWFYUjVMblpoYkhWbENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpYldGMGRYSnBkSGtpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJXRjBkWEpwZEhrZ1pYaHBjM1J6Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjSFJmZEc5clpXNHVZMjl1ZEhKaFkzUXVVRlJVYjJ0bGJpNXBjMTl0WVhSMWNtVW9LU0F0UGlCMWFXNTBOalE2Q21selgyMWhkSFZ5WlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3ZEY5MGIydGxiaTlqYjI1MGNtRmpkQzV3ZVRveE16UUtJQ0FnSUM4dklHbG1JRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0lENDlJSE5sYkdZdWJXRjBkWEpwZEhrdWRtRnNkV1U2Q2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTlNBdkx5QWliV0YwZFhKcGRIa2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YldGMGRYSnBkSGtnWlhocGMzUnpDaUFnSUNBK1BRb2dJQ0FnWW5vZ2FYTmZiV0YwZFhKbFgyVnNjMlZmWW05a2VVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNIUmZkRzlyWlc0dlkyOXVkSEpoWTNRdWNIazZNVE0xQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdWVWx1ZERZMEtERXBJQ0FqSUZSeWRXVUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSemRXSUtDbWx6WDIxaGRIVnlaVjlsYkhObFgySnZaSGxBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3ZEY5MGIydGxiaTlqYjI1MGNtRmpkQzV3ZVRveE16Y0tJQ0FnSUM4dklISmxkSFZ5YmlCVlNXNTBOalFvTUNrZ0lDTWdSbUZzYzJVS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjSFJmZEc5clpXNHVZMjl1ZEhKaFkzUXVVRlJVYjJ0bGJpNW5aWFJmZEc5clpXNWZhVzVtYnlncElDMCtJR0o1ZEdWek9ncG5aWFJmZEc5clpXNWZhVzVtYnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3ZEY5MGIydGxiaTlqYjI1MGNtRmpkQzV3ZVRveE5ETUtJQ0FnSUM4dklHRnlZelF1VTNSeWFXNW5LSE5sYkdZdWJtRnRaUzUyWVd4MVpTa3NDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOaUF2THlBaWJtRnRaU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1dVlXMWxJR1Y0YVhOMGN3b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3ZEY5MGIydGxiaTlqYjI1MGNtRmpkQzV3ZVRveE5EUUtJQ0FnSUM4dklHRnlZelF1VTNSeWFXNW5LSE5sYkdZdWMzbHRZbTlzTG5aaGJIVmxLU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEzSUM4dklDSnplVzFpYjJ3aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjM2x0WW05c0lHVjRhWE4wY3dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdkRjkwYjJ0bGJpOWpiMjUwY21GamRDNXdlVG94TkRVS0lDQWdJQzh2SUdGeVl6UXVWVWx1ZERZMEtITmxiR1l1WkdWamFXMWhiSE11ZG1Gc2RXVXBMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z0ltUmxZMmx0WVd4eklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbVJsWTJsdFlXeHpJR1Y0YVhOMGN3b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCMFgzUnZhMlZ1TDJOdmJuUnlZV04wTG5CNU9qRTBOZ29nSUNBZ0x5OGdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNTBiM1JoYkY5emRYQndiSGt1ZG1Gc2RXVXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWRHOTBZV3hmYzNWd2NHeDVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SdmRHRnNYM04xY0hCc2VTQmxlR2x6ZEhNS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3ZEY5MGIydGxiaTlqYjI1MGNtRmpkQzV3ZVRveE5ESXRNVFEzQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1VWRYQnNaU2dvQ2lBZ0lDQXZMeUFnSUNBZ1lYSmpOQzVUZEhKcGJtY29jMlZzWmk1dVlXMWxMblpoYkhWbEtTd0tJQ0FnSUM4dklDQWdJQ0JoY21NMExsTjBjbWx1WnloelpXeG1Mbk41YldKdmJDNTJZV3gxWlNrc0NpQWdJQ0F2THlBZ0lDQWdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNWtaV05wYldGc2N5NTJZV3gxWlNrc0NpQWdJQ0F2THlBZ0lDQWdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNTBiM1JoYkY5emRYQndiSGt1ZG1Gc2RXVXBDaUFnSUNBdkx5QXBLUW9nSUNBZ1pHbG5JRE1LSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBeU1DQXZMeUF5TUFvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNVFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbkIwWDNSdmEyVnVMbU52Ym5SeVlXTjBMbEJVVkc5clpXNHVZWEJ3Y205MlpTaHpjR1Z1WkdWeU9pQmllWFJsY3l3Z1lXMXZkVzUwT2lCMWFXNTBOalFwSUMwK0lHSjVkR1Z6T2dwaGNIQnliM1psT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0IwWDNSdmEyVnVMMk52Ym5SeVlXTjBMbkI1T2pFME9TMHhOVEFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnTHk4Z1pHVm1JR0Z3Y0hKdmRtVW9jMlZzWml3Z2MzQmxibVJsY2pvZ1FubDBaWE1zSUdGdGIzVnVkRG9nVlVsdWREWTBLU0F0UGlCVGRISnBibWM2Q2lBZ0lDQndjbTkwYnlBeUlERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2RGOTBiMnRsYmk5amIyNTBjbUZqZEM1d2VUb3hOVElLSUNBZ0lDOHZJSE5sYkdZdVlXeHNiM2RoYm1ObFcxUjRiaTV6Wlc1a1pYSmRJRDBnWVcxdmRXNTBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKaGJHeHZkMkZ1WTJVaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3ZEY5MGIydGxiaTlqYjI1MGNtRmpkQzV3ZVRveE5UUUtJQ0FnSUM4dklHeHZaeWhpSWtGd2NISnZkbUZzSUhObGRDQXRJRUZ0YjNWdWREb2dJaUFySUc5d0xtbDBiMklvWVcxdmRXNTBLU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FYUnZZZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjROREUzTURjd056STJaamMyTmpFMll6SXdOek0yTlRjME1qQXlaREl3TkRFMlpEWm1OelUyWlRjME0yRXlNQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdkRjkwYjJ0bGJpOWpiMjUwY21GamRDNXdlVG94TlRVS0lDQWdJQzh2SUhKbGRIVnliaUJUZEhKcGJtY29Ja0Z3Y0hKdmRtRnNJSE5sZENCemRXTmpaWE56Wm5Wc2JIa2lLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSkJjSEJ5YjNaaGJDQnpaWFFnYzNWalkyVnpjMloxYkd4NUlnb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5CMFgzUnZhMlZ1TG1OdmJuUnlZV04wTGxCVVZHOXJaVzR1WjJWMFgyRnNiRzkzWVc1alpTaHZkMjVsY2pvZ1lubDBaWE1zSUhOd1pXNWtaWEk2SUdKNWRHVnpLU0F0UGlCMWFXNTBOalE2Q21kbGRGOWhiR3h2ZDJGdVkyVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNIUmZkRzlyWlc0dlkyOXVkSEpoWTNRdWNIazZNVFUzTFRFMU9Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNBdkx5QmtaV1lnWjJWMFgyRnNiRzkzWVc1alpTaHpaV3htTENCdmQyNWxjam9nUW5sMFpYTXNJSE53Wlc1a1pYSTZJRUo1ZEdWektTQXRQaUJWU1c1ME5qUTZDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3ZEY5MGIydGxiaTlqYjI1MGNtRmpkQzV3ZVRveE5qQXRNVFl4Q2lBZ0lDQXZMeUFqSUZOcGJYQnNhV1pwWldRZ0xTQnlaWFIxY201eklITmxibVJsY2lkeklHRnNiRzkzWVc1alpRb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVZV3hzYjNkaGJtTmxXMVI0Ymk1elpXNWtaWEpkQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVlXeHNiM2RoYm1ObElnb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZV3hzYjNkaGJtTmxJR1Y0YVhOMGN5Qm1iM0lnWVdOamIzVnVkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuQjBYM1J2YTJWdUxtTnZiblJ5WVdOMExsQlVWRzlyWlc0dWRISmhibk5tWlhKZlpuSnZiU2htY205dFgyRmtaSEk2SUdKNWRHVnpMQ0IwYnpvZ1lubDBaWE1zSUdGdGIzVnVkRG9nZFdsdWREWTBLU0F0UGlCaWVYUmxjem9LZEhKaGJuTm1aWEpmWm5KdmJUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2RGOTBiMnRsYmk5amIyNTBjbUZqZEM1d2VUb3hOak10TVRZMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lDOHZJR1JsWmlCMGNtRnVjMlpsY2w5bWNtOXRLSE5sYkdZc0lHWnliMjFmWVdSa2Nqb2dRbmwwWlhNc0lIUnZPaUJDZVhSbGN5d2dZVzF2ZFc1ME9pQlZTVzUwTmpRcElDMCtJRk4wY21sdVp6b0tJQ0FnSUhCeWIzUnZJRE1nTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0IwWDNSdmEyVnVMMk52Ym5SeVlXTjBMbkI1T2pFMk5nb2dJQ0FnTHk4Z1lYTnpaWEowSUdGdGIzVnVkQ0ErSUZWSmJuUTJOQ2d3S1N3Z0lrRnRiM1Z1ZENCdGRYTjBJR0psSUhCdmMybDBhWFpsSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmhjM05sY25RZ0x5OGdRVzF2ZFc1MElHMTFjM1FnWW1VZ2NHOXphWFJwZG1VS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3ZEY5MGIydGxiaTlqYjI1MGNtRmpkQzV3ZVRveE5qZ3RNVFk1Q2lBZ0lDQXZMeUFqSUVOb1pXTnJJR0ZzYkc5M1lXNWpaU0FvYzJsdGNHeHBabWxsWkNrS0lDQWdJQzh2SUdOMWNuSmxiblJmWVd4c2IzZGhibU5sSUQwZ2MyVnNaaTVoYkd4dmQyRnVZMlZiVkhodUxuTmxibVJsY2wwS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmhiR3h2ZDJGdVkyVWlDaUFnSUNCaGNIQmZiRzlqWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVoYkd4dmQyRnVZMlVnWlhocGMzUnpJR1p2Y2lCaFkyTnZkVzUwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSFJmZEc5clpXNHZZMjl1ZEhKaFkzUXVjSGs2TVRjd0NpQWdJQ0F2THlCaGMzTmxjblFnWTNWeWNtVnVkRjloYkd4dmQyRnVZMlVnUGowZ1lXMXZkVzUwTENBaVNXNXpkV1ptYVdOcFpXNTBJR0ZzYkc5M1lXNWpaU0lLSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBK1BRb2dJQ0FnWVhOelpYSjBJQzh2SUVsdWMzVm1abWxqYVdWdWRDQmhiR3h2ZDJGdVkyVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2RGOTBiMnRsYmk5amIyNTBjbUZqZEM1d2VUb3hOekl0TVRjekNpQWdJQ0F2THlBaklFTm9aV05ySUdKaGJHRnVZMlVnS0hOcGJYQnNhV1pwWldRZ0xTQmphR1ZqYTJsdVp5QnpaVzVrWlhJbmN5QmlZV3hoYm1ObEtRb2dJQ0FnTHk4Z2MyVnVaR1Z5WDJKaGJHRnVZMlVnUFNCelpXeG1MbUpoYkdGdVkyVmJWSGh1TG5ObGJtUmxjbDBLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKaVlXeGhibU5sSWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVltRnNZVzVqWlNCbGVHbHpkSE1nWm05eUlHRmpZMjkxYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3ZEY5MGIydGxiaTlqYjI1MGNtRmpkQzV3ZVRveE56UUtJQ0FnSUM4dklHRnpjMlZ5ZENCelpXNWtaWEpmWW1Gc1lXNWpaU0ErUFNCaGJXOTFiblFzSUNKSmJuTjFabVpwWTJsbGJuUWdZbUZzWVc1alpTSUtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0ErUFFvZ0lDQWdZWE56WlhKMElDOHZJRWx1YzNWbVptbGphV1Z1ZENCaVlXeGhibU5sQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSFJmZEc5clpXNHZZMjl1ZEhKaFkzUXVjSGs2TVRjMkxURTNOd29nSUNBZ0x5OGdJeUJWY0dSaGRHVWdZbUZzWVc1alpYTWdZVzVrSUdGc2JHOTNZVzVqWlFvZ0lDQWdMeThnYzJWc1ppNWlZV3hoYm1ObFcxUjRiaTV6Wlc1a1pYSmRJRDBnYzJWdVpHVnlYMkpoYkdGdVkyVWdMU0JoYlc5MWJuUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnTFFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lubDBaV05mTVNBdkx5QWlZbUZzWVc1alpTSUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0IwWDNSdmEyVnVMMk52Ym5SeVlXTjBMbkI1T2pFM09Bb2dJQ0FnTHk4Z2MyVnNaaTVoYkd4dmQyRnVZMlZiVkhodUxuTmxibVJsY2wwZ1BTQmpkWEp5Wlc1MFgyRnNiRzkzWVc1alpTQXRJR0Z0YjNWdWRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0F0Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmhiR3h2ZDJGdVkyVWlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3ZEY5MGIydGxiaTlqYjI1MGNtRmpkQzV3ZVRveE9EQUtJQ0FnSUM4dklHeHZaeWhpSWxSdmEyVnVjeUIwY21GdWMyWmxjbkpsWkNCbWNtOXRJQzBnUVcxdmRXNTBPaUFpSUNzZ2IzQXVhWFJ2WWloaGJXOTFiblFwS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcxTkRabU5tSTJOVFpsTnpNeU1EYzBOekkyTVRabE56TTJOalkxTnpJM01qWTFOalF5TURZMk56STJaalprTWpBeVpESXdOREUyWkRabU56VTJaVGMwTTJFeU1Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2RGOTBiMnRsYmk5amIyNTBjbUZqZEM1d2VUb3hPREVLSUNBZ0lDOHZJSEpsZEhWeWJpQlRkSEpwYm1jb0lsUnZhMlZ1Y3lCMGNtRnVjMlpsY25KbFpDQnpkV05qWlhOelpuVnNiSGtpS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pVYjJ0bGJuTWdkSEpoYm5ObVpYSnlaV1FnYzNWalkyVnpjMloxYkd4NUlnb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5CMFgzUnZhMlZ1TG1OdmJuUnlZV04wTGxCVVZHOXJaVzR1ZFhCa1lYUmxYMjkzYm1WeUtHNWxkMTl2ZDI1bGNqb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncDFjR1JoZEdWZmIzZHVaWEk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSFJmZEc5clpXNHZZMjl1ZEhKaFkzUXVjSGs2TVRnekxURTROQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0F2THlCa1pXWWdkWEJrWVhSbFgyOTNibVZ5S0hObGJHWXNJRzVsZDE5dmQyNWxjam9nUW5sMFpYTXBJQzArSUZOMGNtbHVaem9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCMFgzUnZhMlZ1TDJOdmJuUnlZV04wTG5CNU9qRTROZ29nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSXVZbmwwWlhNZ1BUMGdjMlZzWmk1dmQyNWxjaTUyWVd4MVpTd2dJazl1YkhrZ2IzZHVaWElnWTJGdUlIVndaR0YwWlNJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSnZkMjVsY2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXZkMjVsY2lCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0J2ZDI1bGNpQmpZVzRnZFhCa1lYUmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNIUmZkRzlyWlc0dlkyOXVkSEpoWTNRdWNIazZNVGc0Q2lBZ0lDQXZMeUJ6Wld4bUxtOTNibVZ5TG5aaGJIVmxJRDBnYm1WM1gyOTNibVZ5Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0p2ZDI1bGNpSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2RGOTBiMnRsYmk5amIyNTBjbUZqZEM1d2VUb3hPVEFLSUNBZ0lDOHZJR3h2WnloaUlrOTNibVZ5SUhWd1pHRjBaV1FpS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TkdZM056WmxOalUzTWpJd056VTNNRFkwTmpFM05EWTFOalFLSUNBZ0lHeHZad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQjBYM1J2YTJWdUwyTnZiblJ5WVdOMExuQjVPakU1TVFvZ0lDQWdMeThnY21WMGRYSnVJRk4wY21sdVp5Z2lUM2R1WlhJZ2RYQmtZWFJsWkNCemRXTmpaWE56Wm5Wc2JIa2lLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSlBkMjVsY2lCMWNHUmhkR1ZrSUhOMVkyTmxjM05tZFd4c2VTSUtJQ0FnSUhKbGRITjFZZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUNBQUVtQ1FRVkgzeDFCMkpoYkdGdVkyVU1kRzkwWVd4ZmMzVndjR3g1Qlc5M2JtVnlDV0ZzYkc5M1lXNWpaUWh0WVhSMWNtbDBlUVJ1WVcxbEJuTjViV0p2YkFoa1pXTnBiV0ZzY3pFYlFRSExnZzBFUzVodE9nUjVMYUhLQkhJOEZUc0VlMTl2VndSZ3BWem1CRWFRazFVRVR6YytpQVNFckZpdEJFWmpyOUVFV3grWC9nUXFGY21JQk1sVi9ZTUV2dTdtR1RZYUFJNE5BVUVCSHdFREFPRUF5Z0M1QUtnQWx3Q0hBR1VBU0FBZ0FBSWlRekVaRkVReEdFUTJHZ0ZYQWdDSUJFRkpGUlpYQmdKTVVDaE1VTEFqUXpFWkZFUXhHRVEyR2dGWEFnQTJHZ0pYQWdBMkdnTVhpQU9kU1JVV1Z3WUNURkFvVEZDd0kwTXhHUlJFTVJoRU5ob0JWd0lBTmhvQ1Z3SUFpQU51RmloTVVMQWpRekVaRkVReEdFUTJHZ0ZYQWdBMkdnSVhpQU1PU1JVV1Z3WUNURkFvVEZDd0kwTXhHUlJFTVJoRWlBSzJLRXhRc0NORE1Sa1VSREVZUklnQ2x4WW9URkN3STBNeEdSUkVNUmhFaUFLQUZpaE1VTEFqUXpFWkZFUXhHRVNJQW1vV0tFeFFzQ05ETVJrVVJERVlSRFlhQVZjQ0FJZ0NTUllvVEZDd0kwTXhHUlJFTVJoRU5ob0JWd0lBTmhvQ0Y0Z0J4MGtWRmxjR0FreFFLRXhRc0NORE1Sa1VSREVZUkRZYUFSZUlBVVJKRlJaWEJnSk1VQ2hNVUxBalF6RVpGRVF4R0VRMkdnRlhBZ0EyR2dJWGlBQzRTUlVXVndZQ1RGQW9URkN3STBNeEdSUkVNUmhFTmhvQlZ3SUFOaG9DVndJQU5ob0RGNGdBR1VrVkZsY0dBa3hRS0V4UXNDTkRNUmxBL3BJeEdCUkVJME9LQXdFeEFESUpFa1NML3pJSERVUXJNUUJuSndhTC9XY25CNHYrWnljRmkvOW5LaUpuSndpQkNHZUwveGFBSVZCVUlGUnZhMlZ1SUdsdWFYUnBZV3hwZW1Wa0lDMGdUV0YwZFhKcGRIazZJRXhRc0lBaFVGUWdWRzlyWlc0Z2FXNXBkR2xoYkdsNlpXUWdjM1ZqWTJWemMyWjFiR3g1aVlvQ0FURUFJaXRsUkJKRWkvOUVJaXBsUkl2L0NDcE1aekVBSWlsalJJdi9DREVBS1U4Q1pvdi9Gb0FiVUZRZ2RHOXJaVzV6SUcxcGJuUmxaQ0F0SUVGdGIzVnVkRG9nVEZDd2dCMVFWQ0IwYjJ0bGJuTWdiV2x1ZEdWa0lITjFZMk5sYzNObWRXeHNlWW1LQVFHTC8wUXhBQ0lwWTBSSmkvOFBSSXYvQ1RFQUtVOENaaUlxWlVTTC93a3FUR2VML3hhQUcxQlVJSFJ2YTJWdWN5QmlkWEp1WldRZ0xTQkJiVzkxYm5RNklFeFFzSUFkVUZRZ2RHOXJaVzV6SUdKMWNtNWxaQ0J6ZFdOalpYTnpablZzYkhtSmlnSUJpLzlFTVFBaUtXTkVTWXYvRDBTTC93a3hBQ2xQQW1hTC94YUFJRkJVSUhSdmEyVnVjeUIwY21GdWMyWmxjbkpsWkNBdElFRnRiM1Z1ZERvZ1RGQ3dnQ0pRVkNCMGIydGxibk1nZEhKaGJuTm1aWEp5WldRZ2MzVmpZMlZ6YzJaMWJHeDVpWW9CQVRFQUlpbGpSSWtpS21WRWlTSW5CV1ZFaVRJSElpY0ZaVVFQUVFBQ0k0a2lpU0luQm1WRVNSVVdWd1lDVEZBaUp3ZGxSRWtWRmxjR0FreFFJaWNJWlVRV0lpcGxSQlpMQXhXQkZBZ1dWd1lDZ0FJQUZFeFFUd0pRVEZCUEFsQk1VSW1LQWdFeEFDY0VpLzltaS84V2dCZEJjSEJ5YjNaaGJDQnpaWFFnTFNCQmJXOTFiblE2SUV4UXNJQVpRWEJ3Y205MllXd2djMlYwSUhOMVkyTmxjM05tZFd4c2VZbUtBZ0V4QUNJbkJHTkVpWW9EQVl2L1JERUFJaWNFWTBSSmkvOFBSREVBSWlsalJFbUwvdzlFaS84Sk1RQXBUd0ptaS84Sk1RQW5CRThDWm92L0ZvQWlWRzlyWlc1eklIUnlZVzV6Wm1WeWNtVmtJR1p5YjIwZ0xTQkJiVzkxYm5RNklFeFFzSUFmVkc5clpXNXpJSFJ5WVc1elptVnljbVZrSUhOMVkyTmxjM05tZFd4c2VZbUtBUUV4QUNJclpVUVNSQ3VMLzJlQURVOTNibVZ5SUhWd1pHRjBaV1N3Z0JwUGQyNWxjaUIxY0dSaGRHVmtJSE4xWTJObGMzTm1kV3hzZVlrPSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjEwLCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
