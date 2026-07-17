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

namespace Arc56.Generated.MitudruDutta.Marlin.YTToken_031cf738
{


    //
    // Yield Token contract for yield tokenization
    //
    public class YTTokenProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public YTTokenProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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

            public class GetYieldStatusReturn : AVMObjectType
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

                public static GetYieldStatusReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetYieldStatusReturn();
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
                    return Equals(obj as GetYieldStatusReturn);
                }
                public bool Equals(GetYieldStatusReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetYieldStatusReturn left, GetYieldStatusReturn right)
                {
                    return EqualityComparer<GetYieldStatusReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetYieldStatusReturn left, GetYieldStatusReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Initialize YT token with maturity
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
        ///Mint YT tokens to an address (owner only)
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
        ///Burn YT tokens from sender's balance
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
        ///Transfer YT tokens to another address
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
        ///Get total supply of YT tokens
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
        ///Check if yield is still accruing (before maturity)
        ///</summary>
        public async Task<ulong> IsAccruingYield(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 228, 112, 85, 221 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsAccruingYield_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 228, 112, 85, 221 };

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
        ///Get yield status information
        ///</summary>
        public async Task<Structs.GetYieldStatusReturn> GetYieldStatus(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 217, 127, 140 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetYieldStatusReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetYieldStatus_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 217, 127, 140 };

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
        ///Calculate potential yield value based on time remaining
        ///</summary>
        /// <param name="base_amount"> </param>
        /// <param name="yield_rate"> </param>
        public async Task<ulong> CalculateYieldValue(ulong base_amount, ulong yield_rate, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 83, 15, 64, 233 };
            var base_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); base_amountAbi.From(base_amount);
            var yield_rateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); yield_rateAbi.From(yield_rate);

            var result = await base.CallApp(new List<object> { abiHandle, base_amountAbi, yield_rateAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CalculateYieldValue_Transactions(ulong base_amount, ulong yield_rate, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 83, 15, 64, 233 };
            var base_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); base_amountAbi.From(base_amount);
            var yield_rateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); yield_rateAbi.From(yield_rate);

            return await base.MakeTransactionList(new List<object> { abiHandle, base_amountAbi, yield_rateAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiWVRUb2tlbiIsImRlc2MiOiJZaWVsZCBUb2tlbiBjb250cmFjdCBmb3IgeWllbGQgdG9rZW5pemF0aW9uIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkdldFRva2VuSW5mb1JldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMyIsInR5cGUiOiJ1aW50NjQifV0sIkdldFlpZWxkU3RhdHVzUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImluaXRpYWxpemUiLCJkZXNjIjoiSW5pdGlhbGl6ZSBZVCB0b2tlbiB3aXRoIG1hdHVyaXR5IiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN5bWJvbCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWF0dXJpdHlfdGltZXN0YW1wIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibWludCIsImRlc2MiOiJNaW50IFlUIHRva2VucyB0byBhbiBhZGRyZXNzIChvd25lciBvbmx5KSIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYnVybiIsImRlc2MiOiJCdXJuIFlUIHRva2VucyBmcm9tIHNlbmRlcidzIGJhbGFuY2UiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidHJhbnNmZXIiLCJkZXNjIjoiVHJhbnNmZXIgWVQgdG9rZW5zIHRvIGFub3RoZXIgYWRkcmVzcyIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYmFsYW5jZV9vZiIsImRlc2MiOiJHZXQgYmFsYW5jZSBvZiBhbiBhY2NvdW50IiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF90b3RhbF9zdXBwbHkiLCJkZXNjIjoiR2V0IHRvdGFsIHN1cHBseSBvZiBZVCB0b2tlbnMiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9tYXR1cml0eSIsImRlc2MiOiJHZXQgbWF0dXJpdHkgdGltZXN0YW1wIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpc19tYXR1cmUiLCJkZXNjIjoiQ2hlY2sgaWYgdG9rZW4gaGFzIHJlYWNoZWQgbWF0dXJpdHkiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImlzX2FjY3J1aW5nX3lpZWxkIiwiZGVzYyI6IkNoZWNrIGlmIHlpZWxkIGlzIHN0aWxsIGFjY3J1aW5nIChiZWZvcmUgbWF0dXJpdHkpIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfdG9rZW5faW5mbyIsImRlc2MiOiJHZXQgdG9rZW4gaW5mb3JtYXRpb24iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHN0cmluZyxzdHJpbmcsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJHZXRUb2tlbkluZm9SZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF95aWVsZF9zdGF0dXMiLCJkZXNjIjoiR2V0IHlpZWxkIHN0YXR1cyBpbmZvcm1hdGlvbiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiR2V0WWllbGRTdGF0dXNSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFwcHJvdmUiLCJkZXNjIjoiQXBwcm92ZSBzcGVuZGVyIHRvIHNwZW5kIHRva2VucyBvbiBiZWhhbGYgb2Ygc2VuZGVyIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwZW5kZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9hbGxvd2FuY2UiLCJkZXNjIjoiR2V0IGFsbG93YW5jZSBmb3Igc3BlbmRlciIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3BlbmRlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidHJhbnNmZXJfZnJvbSIsImRlc2MiOiJUcmFuc2ZlciB0b2tlbnMgZnJvbSBvbmUgYWRkcmVzcyB0byBhbm90aGVyIHVzaW5nIGFsbG93YW5jZSIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmcm9tX2FkZHIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYWxjdWxhdGVfeWllbGRfdmFsdWUiLCJkZXNjIjoiQ2FsY3VsYXRlIHBvdGVudGlhbCB5aWVsZCB2YWx1ZSBiYXNlZCBvbiB0aW1lIHJlbWFpbmluZyIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiYXNlX2Ftb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoieWllbGRfcmF0ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZV9vd25lciIsImRlc2MiOiJVcGRhdGUgY29udHJhY3Qgb3duZXIgKGN1cnJlbnQgb3duZXIgb25seSkiLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X293bmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjMsImJ5dGVzIjozfSwibG9jYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls3NjYsODY0LDk2NywxMzA4XSwiZXJyb3JNZXNzYWdlIjoiQW1vdW50IG11c3QgYmUgcG9zaXRpdmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzIwXSwiZXJyb3JNZXNzYWdlIjoiSW5zdWZmaWNpZW50IGFsbG93YW5jZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg3NSw5NzgsMTMzMV0sImVycm9yTWVzc2FnZSI6Ikluc3VmZmljaWVudCBiYWxhbmNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjQ3XSwiZXJyb3JNZXNzYWdlIjoiTWF0dXJpdHkgbXVzdCBiZSBpbiBmdXR1cmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDgsMjM4LDI2MywzMDMsMzMyLDM2NiwzODIsMzk4LDQxNSw0MzIsNDQ5LDQ2Niw0ODksNTIzLDU1MSw1ODVdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NDFdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGNyZWF0b3IgY2FuIGluaXRpYWxpemUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NjNdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IG93bmVyIGNhbiBtaW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ4NF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgb3duZXIgY2FuIHVwZGF0ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYzMF0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxMSwyNDEsMjY2LDMwNiwzMzUsMzY5LDM4NSw0MDEsNDE4LDQzNSw0NTIsNDY5LDQ5Miw1MjYsNTU0LDU4OF0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzAxLDEzMTVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFsbG93YW5jZSBleGlzdHMgZm9yIGFjY291bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3ODIsODcwLDk3MywxMDczLDEzMjZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmJhbGFuY2UgZXhpc3RzIGZvciBhY2NvdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE0M10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZGVjaW1hbHMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA4MywxMDkwLDExMDQsMTE5MiwxNDQyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5tYXR1cml0eSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTE3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5uYW1lIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc2MSwxNDgyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5vd25lciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTMwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5zeW1ib2wgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzcwLDg4OCwxMDc4LDExNDhdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRvdGFsX3N1cHBseSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWVYUmZkRzlyWlc0dVkyOXVkSEpoWTNRdVdWUlViMnRsYmk1ZlgyRnNaMjl3ZVY5bGJuUnllWEJ2YVc1MFgzZHBkR2hmYVc1cGRDZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ01IZ3hOVEZtTjJNM05TQWlZbUZzWVc1alpTSWdJblJ2ZEdGc1gzTjFjSEJzZVNJZ0ltMWhkSFZ5YVhSNUlpQWliM2R1WlhJaUlDSmhiR3h2ZDJGdVkyVWlJQ0p1WVcxbElpQWljM2x0WW05c0lpQWlaR1ZqYVcxaGJITWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVYUmZkRzlyWlc0dlkyOXVkSEpoWTNRdWNIazZNekFLSUNBZ0lDOHZJR05zWVhOeklGbFVWRzlyWlc0b1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgySmhjbVZmY205MWRHbHVaMEF5TVFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURSaU9UZzJaRE5oSURCNE56a3laR0V4WTJFZ01IZzNNak5qTVRVellpQXdlRGRpTldZMlpqVTNJREI0TmpCaE5UVmpaVFlnTUhnME5qa3dPVE0xTlNBd2VEUm1NemN6WlRnNElEQjRPRFJoWXpVNFlXUWdNSGhsTkRjd05UVmtaQ0F3ZURRMk5qTmhabVF4SURCNFlqUmtPVGRtT0dNZ01IZzFZakZtT1RkbVpTQXdlREpoTVRWak9UZzRJREI0WXprMU5XWmtPRE1nTUhnMU16Qm1OREJsT1NBd2VHSmxaV1ZsTmpFNUlDOHZJRzFsZEdodlpDQWlhVzVwZEdsaGJHbDZaU2h6ZEhKcGJtY3NjM1J5YVc1bkxIVnBiblEyTkNsemRISnBibWNpTENCdFpYUm9iMlFnSW0xcGJuUW9ZbmwwWlZ0ZExIVnBiblEyTkNsemRISnBibWNpTENCdFpYUm9iMlFnSW1KMWNtNG9kV2x1ZERZMEtYTjBjbWx1WnlJc0lHMWxkR2h2WkNBaWRISmhibk5tWlhJb1lubDBaVnRkTEhWcGJuUTJOQ2x6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJbUpoYkdGdVkyVmZiMllvWW5sMFpWdGRLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlaMlYwWDNSdmRHRnNYM04xY0hCc2VTZ3BkV2x1ZERZMElpd2diV1YwYUc5a0lDSm5aWFJmYldGMGRYSnBkSGtvS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpYVhOZmJXRjBkWEpsS0NsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1selgyRmpZM0oxYVc1blgzbHBaV3hrS0NsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1kbGRGOTBiMnRsYmw5cGJtWnZLQ2tvYzNSeWFXNW5MSE4wY21sdVp5eDFhVzUwTmpRc2RXbHVkRFkwS1NJc0lHMWxkR2h2WkNBaVoyVjBYM2xwWld4a1gzTjBZWFIxY3lncEtIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBLU0lzSUcxbGRHaHZaQ0FpWVhCd2NtOTJaU2hpZVhSbFcxMHNkV2x1ZERZMEtYTjBjbWx1WnlJc0lHMWxkR2h2WkNBaVoyVjBYMkZzYkc5M1lXNWpaU2hpZVhSbFcxMHNZbmwwWlZ0ZEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaWRISmhibk5tWlhKZlpuSnZiU2hpZVhSbFcxMHNZbmwwWlZ0ZExIVnBiblEyTkNsemRISnBibWNpTENCdFpYUm9iMlFnSW1OaGJHTjFiR0YwWlY5NWFXVnNaRjkyWVd4MVpTaDFhVzUwTmpRc2RXbHVkRFkwS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpZFhCa1lYUmxYMjkzYm1WeUtHSjVkR1ZiWFNsemRISnBibWNpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYMmx1YVhScFlXeHBlbVZmY205MWRHVkFOU0J0WVdsdVgyMXBiblJmY205MWRHVkFOaUJ0WVdsdVgySjFjbTVmY205MWRHVkFOeUJ0WVdsdVgzUnlZVzV6Wm1WeVgzSnZkWFJsUURnZ2JXRnBibDlpWVd4aGJtTmxYMjltWDNKdmRYUmxRRGtnYldGcGJsOW5aWFJmZEc5MFlXeGZjM1Z3Y0d4NVgzSnZkWFJsUURFd0lHMWhhVzVmWjJWMFgyMWhkSFZ5YVhSNVgzSnZkWFJsUURFeElHMWhhVzVmYVhOZmJXRjBkWEpsWDNKdmRYUmxRREV5SUcxaGFXNWZhWE5mWVdOamNuVnBibWRmZVdsbGJHUmZjbTkxZEdWQU1UTWdiV0ZwYmw5blpYUmZkRzlyWlc1ZmFXNW1iMTl5YjNWMFpVQXhOQ0J0WVdsdVgyZGxkRjk1YVdWc1pGOXpkR0YwZFhOZmNtOTFkR1ZBTVRVZ2JXRnBibDloY0hCeWIzWmxYM0p2ZFhSbFFERTJJRzFoYVc1ZloyVjBYMkZzYkc5M1lXNWpaVjl5YjNWMFpVQXhOeUJ0WVdsdVgzUnlZVzV6Wm1WeVgyWnliMjFmY205MWRHVkFNVGdnYldGcGJsOWpZV3hqZFd4aGRHVmZlV2xsYkdSZmRtRnNkV1ZmY205MWRHVkFNVGtnYldGcGJsOTFjR1JoZEdWZmIzZHVaWEpmY205MWRHVkFNakFLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOTBiMnRsYmk5amIyNTBjbUZqZEM1d2VUb3pNQW9nSUNBZ0x5OGdZMnhoYzNNZ1dWUlViMnRsYmloQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTFjR1JoZEdWZmIzZHVaWEpmY205MWRHVkFNakE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlWFJmZEc5clpXNHZZMjl1ZEhKaFkzUXVjSGs2TWpJekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzbDBYM1J2YTJWdUwyTnZiblJ5WVdOMExuQjVPak13Q2lBZ0lDQXZMeUJqYkdGemN5QlpWRlJ2YTJWdUtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzbDBYM1J2YTJWdUwyTnZiblJ5WVdOMExuQjVPakl5TXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCallXeHNjM1ZpSUhWd1pHRjBaVjl2ZDI1bGNnb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWTJGc1kzVnNZWFJsWDNscFpXeGtYM1poYkhWbFgzSnZkWFJsUURFNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNsMFgzUnZhMlZ1TDJOdmJuUnlZV04wTG5CNU9qSXdOZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1ZEY5MGIydGxiaTlqYjI1MGNtRmpkQzV3ZVRvek1Bb2dJQ0FnTHk4Z1kyeGhjM01nV1ZSVWIydGxiaWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNsMFgzUnZhMlZ1TDJOdmJuUnlZV04wTG5CNU9qSXdOZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JqWVd4c2MzVmlJR05oYkdOMWJHRjBaVjk1YVdWc1pGOTJZV3gxWlFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkwY21GdWMyWmxjbDltY205dFgzSnZkWFJsUURFNE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNsMFgzUnZhMlZ1TDJOdmJuUnlZV04wTG5CNU9qRTROZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1ZEY5MGIydGxiaTlqYjI1MGNtRmpkQzV3ZVRvek1Bb2dJQ0FnTHk4Z1kyeGhjM01nV1ZSVWIydGxiaWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlWFJmZEc5clpXNHZZMjl1ZEhKaFkzUXVjSGs2TVRnMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHTmhiR3h6ZFdJZ2RISmhibk5tWlhKZlpuSnZiUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBYMkZzYkc5M1lXNWpaVjl5YjNWMFpVQXhOem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTVkRjkwYjJ0bGJpOWpiMjUwY21GamRDNXdlVG94T0RBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVhSZmRHOXJaVzR2WTI5dWRISmhZM1F1Y0hrNk16QUtJQ0FnSUM4dklHTnNZWE56SUZsVVZHOXJaVzRvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2wwWDNSdmEyVnVMMk52Ym5SeVlXTjBMbkI1T2pFNE1Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCallXeHNjM1ZpSUdkbGRGOWhiR3h2ZDJGdVkyVUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZllYQndjbTkyWlY5eWIzVjBaVUF4TmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1ZEY5MGIydGxiaTlqYjI1MGNtRmpkQzV3ZVRveE56SUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlWFJmZEc5clpXNHZZMjl1ZEhKaFkzUXVjSGs2TXpBS0lDQWdJQzh2SUdOc1lYTnpJRmxVVkc5clpXNG9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlWFJmZEc5clpXNHZZMjl1ZEhKaFkzUXVjSGs2TVRjeUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHTmhiR3h6ZFdJZ1lYQndjbTkyWlFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwWDNscFpXeGtYM04wWVhSMWMxOXliM1YwWlVBeE5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOTBiMnRsYmk5amIyNTBjbUZqZEM1d2VUb3hOVGNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQmpZV3hzYzNWaUlHZGxkRjk1YVdWc1pGOXpkR0YwZFhNS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWjJWMFgzUnZhMlZ1WDJsdVptOWZjbTkxZEdWQU1UUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVYUmZkRzlyWlc0dlkyOXVkSEpoWTNRdWNIazZNVFEzQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZMkZzYkhOMVlpQm5aWFJmZEc5clpXNWZhVzVtYndvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlwYzE5aFkyTnlkV2x1WjE5NWFXVnNaRjl5YjNWMFpVQXhNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTVkRjkwYjJ0bGJpOWpiMjUwY21GamRDNXdlVG94TXprS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JqWVd4c2MzVmlJR2x6WDJGalkzSjFhVzVuWDNscFpXeGtDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgybHpYMjFoZEhWeVpWOXliM1YwWlVBeE1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOTBiMnRsYmk5amIyNTBjbUZqZEM1d2VUb3hNekVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQmpZV3hzYzNWaUlHbHpYMjFoZEhWeVpRb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUmZiV0YwZFhKcGRIbGZjbTkxZEdWQU1URTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVYUmZkRzlyWlc0dlkyOXVkSEpoWTNRdWNIazZNVEkyQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZMkZzYkhOMVlpQm5aWFJmYldGMGRYSnBkSGtLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwWDNSdmRHRnNYM04xY0hCc2VWOXliM1YwWlVBeE1Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOTBiMnRsYmk5amIyNTBjbUZqZEM1d2VUb3hNakVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQmpZV3hzYzNWaUlHZGxkRjkwYjNSaGJGOXpkWEJ3YkhrS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWW1Gc1lXNWpaVjl2Wmw5eWIzVjBaVUE1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2wwWDNSdmEyVnVMMk52Ym5SeVlXTjBMbkI1T2pFeE5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOTBiMnRsYmk5amIyNTBjbUZqZEM1d2VUb3pNQW9nSUNBZ0x5OGdZMnhoYzNNZ1dWUlViMnRsYmloQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOTBiMnRsYmk5amIyNTBjbUZqZEM1d2VUb3hNVFVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZMkZzYkhOMVlpQmlZV3hoYm1ObFgyOW1DaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUnlZVzV6Wm1WeVgzSnZkWFJsUURnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVhSZmRHOXJaVzR2WTI5dWRISmhZM1F1Y0hrNk9UZ0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlWFJmZEc5clpXNHZZMjl1ZEhKaFkzUXVjSGs2TXpBS0lDQWdJQzh2SUdOc1lYTnpJRmxVVkc5clpXNG9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlWFJmZEc5clpXNHZZMjl1ZEhKaFkzUXVjSGs2T1RnS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ1kyRnNiSE4xWWlCMGNtRnVjMlpsY2dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZblZ5Ymw5eWIzVjBaVUEzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2wwWDNSdmEyVnVMMk52Ym5SeVlXTjBMbkI1T2pnekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzbDBYM1J2YTJWdUwyTnZiblJ5WVdOMExuQjVPak13Q2lBZ0lDQXZMeUJqYkdGemN5QlpWRlJ2YTJWdUtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlWFJmZEc5clpXNHZZMjl1ZEhKaFkzUXVjSGs2T0RNS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ1kyRnNiSE4xWWlCaWRYSnVDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5dGFXNTBYM0p2ZFhSbFFEWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVYUmZkRzlyWlc0dlkyOXVkSEpoWTNRdWNIazZOamNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVhSZmRHOXJaVzR2WTI5dWRISmhZM1F1Y0hrNk16QUtJQ0FnSUM4dklHTnNZWE56SUZsVVZHOXJaVzRvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVhSZmRHOXJaVzR2WTI5dWRISmhZM1F1Y0hrNk5qY0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdZMkZzYkhOMVlpQnRhVzUwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXBibWwwYVdGc2FYcGxYM0p2ZFhSbFFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVYUmZkRzlyWlc0dlkyOXVkSEpoWTNRdWNIazZORFlLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVhSZmRHOXJaVzR2WTI5dWRISmhZM1F1Y0hrNk16QUtJQ0FnSUM4dklHTnNZWE56SUZsVVZHOXJaVzRvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2wwWDNSdmEyVnVMMk52Ym5SeVlXTjBMbkI1T2pRMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHTmhiR3h6ZFdJZ2FXNXBkR2xoYkdsNlpRb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWW1GeVpWOXliM1YwYVc1blFESXhPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzbDBYM1J2YTJWdUwyTnZiblJ5WVdOMExuQjVPak13Q2lBZ0lDQXZMeUJqYkdGemN5QlpWRlJ2YTJWdUtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESXpDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQmpjbVZoZEdsdVp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTU1ZEY5MGIydGxiaTVqYjI1MGNtRmpkQzVaVkZSdmEyVnVMbWx1YVhScFlXeHBlbVVvYm1GdFpUb2dZbmwwWlhNc0lITjViV0p2YkRvZ1lubDBaWE1zSUcxaGRIVnlhWFI1WDNScGJXVnpkR0Z0Y0RvZ2RXbHVkRFkwS1NBdFBpQmllWFJsY3pvS2FXNXBkR2xoYkdsNlpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOTBiMnRsYmk5amIyNTBjbUZqZEM1d2VUbzBOaTAxTWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNBdkx5QmtaV1lnYVc1cGRHbGhiR2w2WlNnS0lDQWdJQzh2SUNBZ0lDQnpaV3htTEFvZ0lDQWdMeThnSUNBZ0lHNWhiV1U2SUZOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCemVXMWliMnc2SUZOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCdFlYUjFjbWwwZVY5MGFXMWxjM1JoYlhBNklGVkpiblEyTkN3S0lDQWdJQzh2SUNrZ0xUNGdVM1J5YVc1bk9nb2dJQ0FnY0hKdmRHOGdNeUF4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlWFJmZEc5clpXNHZZMjl1ZEhKaFkzUXVjSGs2TlRRS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlFZHNiMkpoYkM1amNtVmhkRzl5WDJGa1pISmxjM01zSUNKUGJteDVJR055WldGMGIzSWdZMkZ1SUdsdWFYUnBZV3hwZW1VaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQm5iRzlpWVd3Z1EzSmxZWFJ2Y2tGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0JqY21WaGRHOXlJR05oYmlCcGJtbDBhV0ZzYVhwbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVhSZmRHOXJaVzR2WTI5dWRISmhZM1F1Y0hrNk5UVUtJQ0FnSUM4dklHRnpjMlZ5ZENCdFlYUjFjbWwwZVY5MGFXMWxjM1JoYlhBZ1BpQkhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0N3Z0lrMWhkSFZ5YVhSNUlHMTFjM1FnWW1VZ2FXNGdablYwZFhKbElnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JuYkc5aVlXd2dUR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0ErQ2lBZ0lDQmhjM05sY25RZ0x5OGdUV0YwZFhKcGRIa2diWFZ6ZENCaVpTQnBiaUJtZFhSMWNtVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOTBiMnRsYmk5amIyNTBjbUZqZEM1d2VUbzFOd29nSUNBZ0x5OGdjMlZzWmk1dmQyNWxjaTUyWVd4MVpTQTlJRlI0Ymk1elpXNWtaWEl1WW5sMFpYTUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltOTNibVZ5SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTVkRjkwYjJ0bGJpOWpiMjUwY21GamRDNXdlVG8xT0FvZ0lDQWdMeThnYzJWc1ppNXVZVzFsTG5aaGJIVmxJRDBnYm1GdFpRb2dJQ0FnWW5sMFpXTWdOaUF2THlBaWJtRnRaU0lLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTVkRjkwYjJ0bGJpOWpiMjUwY21GamRDNXdlVG8xT1FvZ0lDQWdMeThnYzJWc1ppNXplVzFpYjJ3dWRtRnNkV1VnUFNCemVXMWliMndLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJbk41YldKdmJDSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOTBiMnRsYmk5amIyNTBjbUZqZEM1d2VUbzJNQW9nSUNBZ0x5OGdjMlZzWmk1dFlYUjFjbWwwZVM1MllXeDFaU0E5SUcxaGRIVnlhWFI1WDNScGJXVnpkR0Z0Y0FvZ0lDQWdZbmwwWldOZk15QXZMeUFpYldGMGRYSnBkSGtpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlWFJmZEc5clpXNHZZMjl1ZEhKaFkzUXVjSGs2TmpFS0lDQWdJQzh2SUhObGJHWXVkRzkwWVd4ZmMzVndjR3g1TG5aaGJIVmxJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0owYjNSaGJGOXpkWEJ3YkhraUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1ZEY5MGIydGxiaTlqYjI1MGNtRmpkQzV3ZVRvMk1nb2dJQ0FnTHk4Z2MyVnNaaTVrWldOcGJXRnNjeTUyWVd4MVpTQTlJRlZKYm5RMk5DZzRLUW9nSUNBZ1lubDBaV01nT0NBdkx5QWlaR1ZqYVcxaGJITWlDaUFnSUNCd2RYTm9hVzUwSURnZ0x5OGdPQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTVkRjkwYjJ0bGJpOWpiMjUwY21GamRDNXdlVG8yTkFvZ0lDQWdMeThnYkc5bktHSWlXVlFnVkc5clpXNGdhVzVwZEdsaGJHbDZaV1FnTFNCTllYUjFjbWwwZVRvZ0lpQXJJRzl3TG1sMGIySW9iV0YwZFhKcGRIbGZkR2x0WlhOMFlXMXdLU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FYUnZZZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjROVGsxTkRJd05UUTJaalppTmpVMlpUSXdOamsyWlRZNU56UTJPVFl4Tm1NMk9UZGhOalUyTkRJd01tUXlNRFJrTmpFM05EYzFOekkyT1RjME56a3pZVEl3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2wwWDNSdmEyVnVMMk52Ym5SeVlXTjBMbkI1T2pZMUNpQWdJQ0F2THlCeVpYUjFjbTRnVTNSeWFXNW5LQ0paVkNCVWIydGxiaUJwYm1sMGFXRnNhWHBsWkNCemRXTmpaWE56Wm5Wc2JIa2lLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSlpWQ0JVYjJ0bGJpQnBibWwwYVdGc2FYcGxaQ0J6ZFdOalpYTnpablZzYkhraUNpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11ZVhSZmRHOXJaVzR1WTI5dWRISmhZM1F1V1ZSVWIydGxiaTV0YVc1MEtIUnZPaUJpZVhSbGN5d2dZVzF2ZFc1ME9pQjFhVzUwTmpRcElDMCtJR0o1ZEdWek9ncHRhVzUwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2wwWDNSdmEyVnVMMk52Ym5SeVlXTjBMbkI1T2pZM0xUWTRDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJQzh2SUdSbFppQnRhVzUwS0hObGJHWXNJSFJ2T2lCQ2VYUmxjeXdnWVcxdmRXNTBPaUJWU1c1ME5qUXBJQzArSUZOMGNtbHVaem9LSUNBZ0lIQnliM1J2SURJZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNsMFgzUnZhMlZ1TDJOdmJuUnlZV04wTG5CNU9qY3dDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpNWllWFJsY3lBOVBTQnpaV3htTG05M2JtVnlMblpoYkhWbExDQWlUMjVzZVNCdmQyNWxjaUJqWVc0Z2JXbHVkQ0lLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKdmQyNWxjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1dmQyNWxjaUJsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1c2VTQnZkMjVsY2lCallXNGdiV2x1ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2wwWDNSdmEyVnVMMk52Ym5SeVlXTjBMbkI1T2pjeENpQWdJQ0F2THlCaGMzTmxjblFnWVcxdmRXNTBJRDRnVlVsdWREWTBLREFwTENBaVFXMXZkVzUwSUcxMWMzUWdZbVVnY0c5emFYUnBkbVVpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJiVzkxYm5RZ2JYVnpkQ0JpWlNCd2IzTnBkR2wyWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2wwWDNSdmEyVnVMMk52Ym5SeVlXTjBMbkI1T2pjekxUYzBDaUFnSUNBdkx5QWpJRlZ3WkdGMFpTQjBiM1JoYkNCemRYQndiSGtLSUNBZ0lDOHZJSE5sYkdZdWRHOTBZV3hmYzNWd2NHeDVMblpoYkhWbElEMGdjMlZzWmk1MGIzUmhiRjl6ZFhCd2JIa3VkbUZzZFdVZ0t5QmhiVzkxYm5RS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0owYjNSaGJGOXpkWEJ3YkhraUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkRzkwWVd4ZmMzVndjR3g1SUdWNGFYTjBjd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBckNpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKMGIzUmhiRjl6ZFhCd2JIa2lDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzbDBYM1J2YTJWdUwyTnZiblJ5WVdOMExuQjVPamMyTFRjNENpQWdJQ0F2THlBaklGVndaR0YwWlNCeVpXTnBjR2xsYm5RZ1ltRnNZVzVqWlNBb2MybHRjR3hwWm1sbFpDQXRJR2x1SUhCeWIyUjFZM1JwYjI0Z2QyOTFiR1FnYm1WbFpDQndjbTl3WlhJZ1lXUmtjbVZ6Y3lCb1lXNWtiR2x1WnlrS0lDQWdJQzh2SUNNZ1JtOXlJRzV2ZHl3Z2JXbHVkQ0IwYnlCelpXNWtaWElLSUNBZ0lDOHZJSE5sYkdZdVltRnNZVzVqWlZ0VWVHNHVjMlZ1WkdWeVhTQTlJSE5sYkdZdVltRnNZVzVqWlZ0VWVHNHVjMlZ1WkdWeVhTQXJJR0Z0YjNWdWRBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbUpoYkdGdVkyVWlDaUFnSUNCaGNIQmZiRzlqWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVpWVd4aGJtTmxJR1Y0YVhOMGN5Qm1iM0lnWVdOamIzVnVkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBckNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0ppWVd4aGJtTmxJZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JoY0hCZmJHOWpZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVhSZmRHOXJaVzR2WTI5dWRISmhZM1F1Y0hrNk9EQUtJQ0FnSUM4dklHeHZaeWhpSWxsVUlIUnZhMlZ1Y3lCdGFXNTBaV1FnTFNCQmJXOTFiblE2SUNJZ0t5QnZjQzVwZEc5aUtHRnRiM1Z1ZENrcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2wwYjJJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURVNU5UUXlNRGMwTm1ZMllqWTFObVUzTXpJd05tUTJPVFpsTnpRMk5UWTBNakF5WkRJd05ERTJaRFptTnpVMlpUYzBNMkV5TUFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1ZEY5MGIydGxiaTlqYjI1MGNtRmpkQzV3ZVRvNE1Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUZOMGNtbHVaeWdpV1ZRZ2RHOXJaVzV6SUcxcGJuUmxaQ0J6ZFdOalpYTnpablZzYkhraUtRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKWlZDQjBiMnRsYm5NZ2JXbHVkR1ZrSUhOMVkyTmxjM05tZFd4c2VTSUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1NWRGOTBiMnRsYmk1amIyNTBjbUZqZEM1WlZGUnZhMlZ1TG1KMWNtNG9ZVzF2ZFc1ME9pQjFhVzUwTmpRcElDMCtJR0o1ZEdWek9ncGlkWEp1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2wwWDNSdmEyVnVMMk52Ym5SeVlXTjBMbkI1T2pnekxUZzBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJQzh2SUdSbFppQmlkWEp1S0hObGJHWXNJR0Z0YjNWdWREb2dWVWx1ZERZMEtTQXRQaUJUZEhKcGJtYzZDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1ZEY5MGIydGxiaTlqYjI1MGNtRmpkQzV3ZVRvNE5nb2dJQ0FnTHk4Z1lYTnpaWEowSUdGdGIzVnVkQ0ErSUZWSmJuUTJOQ2d3S1N3Z0lrRnRiM1Z1ZENCdGRYTjBJR0psSUhCdmMybDBhWFpsSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmhjM05sY25RZ0x5OGdRVzF2ZFc1MElHMTFjM1FnWW1VZ2NHOXphWFJwZG1VS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1ZEY5MGIydGxiaTlqYjI1MGNtRmpkQzV3ZVRvNE9Bb2dJQ0FnTHk4Z1kzVnljbVZ1ZEY5aVlXeGhibU5sSUQwZ2MyVnNaaTVpWVd4aGJtTmxXMVI0Ymk1elpXNWtaWEpkQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVltRnNZVzVqWlNJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtSmhiR0Z1WTJVZ1pYaHBjM1J6SUdadmNpQmhZMk52ZFc1MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVhSZmRHOXJaVzR2WTI5dWRISmhZM1F1Y0hrNk9Ea0tJQ0FnSUM4dklHRnpjMlZ5ZENCamRYSnlaVzUwWDJKaGJHRnVZMlVnUGowZ1lXMXZkVzUwTENBaVNXNXpkV1ptYVdOcFpXNTBJR0poYkdGdVkyVWlDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnUGowS0lDQWdJR0Z6YzJWeWRDQXZMeUJKYm5OMVptWnBZMmxsYm5RZ1ltRnNZVzVqWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2wwWDNSdmEyVnVMMk52Ym5SeVlXTjBMbkI1T2preExUa3lDaUFnSUNBdkx5QWpJRlZ3WkdGMFpTQmlZV3hoYm1ObGN3b2dJQ0FnTHk4Z2MyVnNaaTVpWVd4aGJtTmxXMVI0Ymk1elpXNWtaWEpkSUQwZ1kzVnljbVZ1ZEY5aVlXeGhibU5sSUMwZ1lXMXZkVzUwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lDMEtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1KaGJHRnVZMlVpQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdGd2NGOXNiMk5oYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOTBiMnRsYmk5amIyNTBjbUZqZEM1d2VUbzVNd29nSUNBZ0x5OGdjMlZzWmk1MGIzUmhiRjl6ZFhCd2JIa3VkbUZzZFdVZ1BTQnpaV3htTG5SdmRHRnNYM04xY0hCc2VTNTJZV3gxWlNBdElHRnRiM1Z1ZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJblJ2ZEdGc1gzTjFjSEJzZVNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5emRYQndiSGtnWlhocGMzUnpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUMwS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5SdmRHRnNYM04xY0hCc2VTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVYUmZkRzlyWlc0dlkyOXVkSEpoWTNRdWNIazZPVFVLSUNBZ0lDOHZJR3h2WnloaUlsbFVJSFJ2YTJWdWN5QmlkWEp1WldRZ0xTQkJiVzkxYm5RNklDSWdLeUJ2Y0M1cGRHOWlLR0Z0YjNWdWRDa3BDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsMGIySUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEVTVOVFF5TURjME5tWTJZalkxTm1VM016SXdOakkzTlRjeU5tVTJOVFkwTWpBeVpESXdOREUyWkRabU56VTJaVGMwTTJFeU1Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOTBiMnRsYmk5amIyNTBjbUZqZEM1d2VUbzVOZ29nSUNBZ0x5OGdjbVYwZFhKdUlGTjBjbWx1WnlnaVdWUWdkRzlyWlc1eklHSjFjbTVsWkNCemRXTmpaWE56Wm5Wc2JIa2lLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSlpWQ0IwYjJ0bGJuTWdZblZ5Ym1Wa0lITjFZMk5sYzNObWRXeHNlU0lLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NTVkRjkwYjJ0bGJpNWpiMjUwY21GamRDNVpWRlJ2YTJWdUxuUnlZVzV6Wm1WeUtIUnZPaUJpZVhSbGN5d2dZVzF2ZFc1ME9pQjFhVzUwTmpRcElDMCtJR0o1ZEdWek9ncDBjbUZ1YzJabGNqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOTBiMnRsYmk5amIyNTBjbUZqZEM1d2VUbzVPQzA1T1FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNBdkx5QmtaV1lnZEhKaGJuTm1aWElvYzJWc1ppd2dkRzg2SUVKNWRHVnpMQ0JoYlc5MWJuUTZJRlZKYm5RMk5Da2dMVDRnVTNSeWFXNW5PZ29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVhSZmRHOXJaVzR2WTI5dWRISmhZM1F1Y0hrNk1UQXhDaUFnSUNBdkx5QmhjM05sY25RZ1lXMXZkVzUwSUQ0Z1ZVbHVkRFkwS0RBcExDQWlRVzF2ZFc1MElHMTFjM1FnWW1VZ2NHOXphWFJwZG1VaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0Z6YzJWeWRDQXZMeUJCYlc5MWJuUWdiWFZ6ZENCaVpTQndiM05wZEdsMlpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNsMFgzUnZhMlZ1TDJOdmJuUnlZV04wTG5CNU9qRXdNd29nSUNBZ0x5OGdjMlZ1WkdWeVgySmhiR0Z1WTJVZ1BTQnpaV3htTG1KaGJHRnVZMlZiVkhodUxuTmxibVJsY2wwS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmlZV3hoYm1ObElnb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZbUZzWVc1alpTQmxlR2x6ZEhNZ1ptOXlJR0ZqWTI5MWJuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOTBiMnRsYmk5amIyNTBjbUZqZEM1d2VUb3hNRFFLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaVzVrWlhKZlltRnNZVzVqWlNBK1BTQmhiVzkxYm5Rc0lDSkpibk4xWm1acFkybGxiblFnWW1Gc1lXNWpaU0lLSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBK1BRb2dJQ0FnWVhOelpYSjBJQzh2SUVsdWMzVm1abWxqYVdWdWRDQmlZV3hoYm1ObENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVhSZmRHOXJaVzR2WTI5dWRISmhZM1F1Y0hrNk1UQTJMVEV3TndvZ0lDQWdMeThnSXlCVmNHUmhkR1VnYzJWdVpHVnlJR0poYkdGdVkyVUtJQ0FnSUM4dklITmxiR1l1WW1Gc1lXNWpaVnRVZUc0dWMyVnVaR1Z5WFNBOUlITmxibVJsY2w5aVlXeGhibU5sSUMwZ1lXMXZkVzUwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lDMEtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1KaGJHRnVZMlVpQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdGd2NGOXNiMk5oYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOTBiMnRsYmk5amIyNTBjbUZqZEM1d2VUb3hNVElLSUNBZ0lDOHZJR3h2WnloaUlsbFVJSFJ2YTJWdWN5QjBjbUZ1YzJabGNuSmxaQ0F0SUVGdGIzVnVkRG9nSWlBcklHOXdMbWwwYjJJb1lXMXZkVzUwS1NrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhWFJ2WWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TlRrMU5ESXdOelEyWmpaaU5qVTJaVGN6TWpBM05EY3lOakUyWlRjek5qWTJOVGN5TnpJMk5UWTBNakF5WkRJd05ERTJaRFptTnpVMlpUYzBNMkV5TUFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1ZEY5MGIydGxiaTlqYjI1MGNtRmpkQzV3ZVRveE1UTUtJQ0FnSUM4dklISmxkSFZ5YmlCVGRISnBibWNvSWxsVUlIUnZhMlZ1Y3lCMGNtRnVjMlpsY25KbFpDQnpkV05qWlhOelpuVnNiSGtpS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0paVkNCMGIydGxibk1nZEhKaGJuTm1aWEp5WldRZ2MzVmpZMlZ6YzJaMWJHeDVJZ29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxubDBYM1J2YTJWdUxtTnZiblJ5WVdOMExsbFVWRzlyWlc0dVltRnNZVzVqWlY5dlppaGhZMk52ZFc1ME9pQmllWFJsY3lrZ0xUNGdkV2x1ZERZME9ncGlZV3hoYm1ObFgyOW1PZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzbDBYM1J2YTJWdUwyTnZiblJ5WVdOMExuQjVPakV4TlMweE1UWUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ0x5OGdaR1ZtSUdKaGJHRnVZMlZmYjJZb2MyVnNaaXdnWVdOamIzVnVkRG9nUW5sMFpYTXBJQzArSUZWSmJuUTJORG9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNsMFgzUnZhMlZ1TDJOdmJuUnlZV04wTG5CNU9qRXhPQzB4TVRrS0lDQWdJQzh2SUNNZ1UybHRjR3hwWm1sbFpDQXRJSEpsZEhWeWJuTWdjMlZ1WkdWeUozTWdZbUZzWVc1alpRb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVZbUZzWVc1alpWdFVlRzR1YzJWdVpHVnlYUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1KaGJHRnVZMlVpQ2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aVlXeGhibU5sSUdWNGFYTjBjeUJtYjNJZ1lXTmpiM1Z1ZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbmwwWDNSdmEyVnVMbU52Ym5SeVlXTjBMbGxVVkc5clpXNHVaMlYwWDNSdmRHRnNYM04xY0hCc2VTZ3BJQzArSUhWcGJuUTJORG9LWjJWMFgzUnZkR0ZzWDNOMWNIQnNlVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTVkRjkwYjJ0bGJpOWpiMjUwY21GamRDNXdlVG94TWpRS0lDQWdJQzh2SUhKbGRIVnliaUJ6Wld4bUxuUnZkR0ZzWDNOMWNIQnNlUzUyWVd4MVpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5SdmRHRnNYM04xY0hCc2VTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjNSaGJGOXpkWEJ3YkhrZ1pYaHBjM1J6Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVlWFJmZEc5clpXNHVZMjl1ZEhKaFkzUXVXVlJVYjJ0bGJpNW5aWFJmYldGMGRYSnBkSGtvS1NBdFBpQjFhVzUwTmpRNkNtZGxkRjl0WVhSMWNtbDBlVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTVkRjkwYjJ0bGJpOWpiMjUwY21GamRDNXdlVG94TWprS0lDQWdJQzh2SUhKbGRIVnliaUJ6Wld4bUxtMWhkSFZ5YVhSNUxuWmhiSFZsQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTXlBdkx5QWliV0YwZFhKcGRIa2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YldGMGRYSnBkSGtnWlhocGMzUnpDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWVYUmZkRzlyWlc0dVkyOXVkSEpoWTNRdVdWUlViMnRsYmk1cGMxOXRZWFIxY21Vb0tTQXRQaUIxYVc1ME5qUTZDbWx6WDIxaGRIVnlaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTVkRjkwYjJ0bGJpOWpiMjUwY21GamRDNXdlVG94TXpRS0lDQWdJQzh2SUdsbUlFZHNiMkpoYkM1c1lYUmxjM1JmZEdsdFpYTjBZVzF3SUQ0OUlITmxiR1l1YldGMGRYSnBkSGt1ZG1Gc2RXVTZDaUFnSUNCbmJHOWlZV3dnVEdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWJXRjBkWEpwZEhraUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXViV0YwZFhKcGRIa2daWGhwYzNSekNpQWdJQ0ErUFFvZ0lDQWdZbm9nYVhOZmJXRjBkWEpsWDJWc2MyVmZZbTlrZVVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVhSZmRHOXJaVzR2WTI5dWRISmhZM1F1Y0hrNk1UTTFDaUFnSUNBdkx5QnlaWFIxY200Z1ZVbHVkRFkwS0RFcElDQWpJRlJ5ZFdVS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFJ6ZFdJS0NtbHpYMjFoZEhWeVpWOWxiSE5sWDJKdlpIbEFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTVkRjkwYjJ0bGJpOWpiMjUwY21GamRDNXdlVG94TXpjS0lDQWdJQzh2SUhKbGRIVnliaUJWU1c1ME5qUW9NQ2tnSUNNZ1JtRnNjMlVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWVYUmZkRzlyWlc0dVkyOXVkSEpoWTNRdVdWUlViMnRsYmk1cGMxOWhZMk55ZFdsdVoxOTVhV1ZzWkNncElDMCtJSFZwYm5RMk5Eb0thWE5mWVdOamNuVnBibWRmZVdsbGJHUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVYUmZkRzlyWlc0dlkyOXVkSEpoWTNRdWNIazZNVFF5Q2lBZ0lDQXZMeUJwWmlCSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ0E4SUhObGJHWXViV0YwZFhKcGRIa3VkbUZzZFdVNkNpQWdJQ0JuYkc5aVlXd2dUR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk15QXZMeUFpYldGMGRYSnBkSGtpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJXRjBkWEpwZEhrZ1pYaHBjM1J6Q2lBZ0lDQThDaUFnSUNCaWVpQnBjMTloWTJOeWRXbHVaMTk1YVdWc1pGOWxiSE5sWDJKdlpIbEFNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzbDBYM1J2YTJWdUwyTnZiblJ5WVdOMExuQjVPakUwTXdvZ0lDQWdMeThnY21WMGRYSnVJRlZKYm5RMk5DZ3hLU0FnSXlCVWNuVmxJQzBnYzNScGJHd2dZV05qY25WcGJtY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSemRXSUtDbWx6WDJGalkzSjFhVzVuWDNscFpXeGtYMlZzYzJWZlltOWtlVUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2wwWDNSdmEyVnVMMk52Ym5SeVlXTjBMbkI1T2pFME5Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUZWSmJuUTJOQ2d3S1NBZ0l5QkdZV3h6WlNBdElHNXZJR3h2Ym1kbGNpQmhZMk55ZFdsdVp3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTU1ZEY5MGIydGxiaTVqYjI1MGNtRmpkQzVaVkZSdmEyVnVMbWRsZEY5MGIydGxibDlwYm1adktDa2dMVDRnWW5sMFpYTTZDbWRsZEY5MGIydGxibDlwYm1adk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNsMFgzUnZhMlZ1TDJOdmJuUnlZV04wTG5CNU9qRTFNUW9nSUNBZ0x5OGdZWEpqTkM1VGRISnBibWNvYzJWc1ppNXVZVzFsTG5aaGJIVmxLU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEySUM4dklDSnVZVzFsSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtNWhiV1VnWlhocGMzUnpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNsMFgzUnZhMlZ1TDJOdmJuUnlZV04wTG5CNU9qRTFNZ29nSUNBZ0x5OGdZWEpqTkM1VGRISnBibWNvYzJWc1ppNXplVzFpYjJ3dWRtRnNkV1VwTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJbk41YldKdmJDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV6ZVcxaWIyd2daWGhwYzNSekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2wwWDNSdmEyVnVMMk52Ym5SeVlXTjBMbkI1T2pFMU13b2dJQ0FnTHk4Z1lYSmpOQzVWU1c1ME5qUW9jMlZzWmk1a1pXTnBiV0ZzY3k1MllXeDFaU2tzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nT0NBdkx5QWlaR1ZqYVcxaGJITWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WkdWamFXMWhiSE1nWlhocGMzUnpDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVYUmZkRzlyWlc0dlkyOXVkSEpoWTNRdWNIazZNVFUwQ2lBZ0lDQXZMeUJoY21NMExsVkpiblEyTkNoelpXeG1MblJ2ZEdGc1gzTjFjSEJzZVM1MllXeDFaU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSjBiM1JoYkY5emRYQndiSGtpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOTBZV3hmYzNWd2NHeDVJR1Y0YVhOMGN3b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNsMFgzUnZhMlZ1TDJOdmJuUnlZV04wTG5CNU9qRTFNQzB4TlRVS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExsUjFjR3hsS0NnS0lDQWdJQzh2SUNBZ0lDQmhjbU0wTGxOMGNtbHVaeWh6Wld4bUxtNWhiV1V1ZG1Gc2RXVXBMQW9nSUNBZ0x5OGdJQ0FnSUdGeVl6UXVVM1J5YVc1bktITmxiR1l1YzNsdFltOXNMblpoYkhWbEtTd0tJQ0FnSUM4dklDQWdJQ0JoY21NMExsVkpiblEyTkNoelpXeG1MbVJsWTJsdFlXeHpMblpoYkhWbEtTd0tJQ0FnSUM4dklDQWdJQ0JoY21NMExsVkpiblEyTkNoelpXeG1MblJ2ZEdGc1gzTjFjSEJzZVM1MllXeDFaU2tLSUNBZ0lDOHZJQ2twQ2lBZ0lDQmthV2NnTXdvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElESXdJQzh2SURJd0NpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF4TkFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11ZVhSZmRHOXJaVzR1WTI5dWRISmhZM1F1V1ZSVWIydGxiaTVuWlhSZmVXbGxiR1JmYzNSaGRIVnpLQ2tnTFQ0Z1lubDBaWE02Q21kbGRGOTVhV1ZzWkY5emRHRjBkWE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlWFJmZEc5clpXNHZZMjl1ZEhKaFkzUXVjSGs2TVRVM0xURTFPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQXZMeUJrWldZZ1oyVjBYM2xwWld4a1gzTjBZWFIxY3loelpXeG1LU0F0UGlCaGNtTTBMbFIxY0d4bFcyRnlZelF1VlVsdWREWTBMQ0JoY21NMExsVkpiblEyTkN3Z1lYSmpOQzVWU1c1ME5qUmRPZ29nSUNBZ2NISnZkRzhnTUNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVhSZmRHOXJaVzR2WTI5dWRISmhZM1F1Y0hrNk1UWXdDaUFnSUNBdkx5QmpkWEp5Wlc1MFgzUnBiV1VnUFNCSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQW9nSUNBZ1oyeHZZbUZzSUV4aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVYUmZkRzlyWlc0dlkyOXVkSEpoWTNRdWNIazZNVFl4Q2lBZ0lDQXZMeUJ0WVhSMWNtbDBlVjkwYVcxbElEMGdjMlZzWmk1dFlYUjFjbWwwZVM1MllXeDFaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltMWhkSFZ5YVhSNUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lITjNZWEFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJXRjBkWEpwZEhrZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlWFJmZEc5clpXNHZZMjl1ZEhKaFkzUXVjSGs2TVRZekNpQWdJQ0F2THlCcGMxOWhZMk55ZFdsdVp5QTlJRlZKYm5RMk5DZ3hLU0JwWmlCamRYSnlaVzUwWDNScGJXVWdQQ0J0WVhSMWNtbDBlVjkwYVcxbElHVnNjMlVnVlVsdWREWTBLREFwQ2lBZ0lDQThDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOTBiMnRsYmk5amIyNTBjbUZqZEM1d2VUb3hOalFLSUNBZ0lDOHZJSFJwYldWZmRHOWZiV0YwZFhKcGRIa2dQU0J0WVhSMWNtbDBlVjkwYVcxbElDMGdZM1Z5Y21WdWRGOTBhVzFsSUdsbUlHTjFjbkpsYm5SZmRHbHRaU0E4SUcxaGRIVnlhWFI1WDNScGJXVWdaV3h6WlNCVlNXNTBOalFvTUNrS0lDQWdJR0o2SUdkbGRGOTVhV1ZzWkY5emRHRjBkWE5mZEdWeWJtRnllVjltWVd4elpVQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJQzBLQ21kbGRGOTVhV1ZzWkY5emRHRjBkWE5mZEdWeWJtRnllVjl0WlhKblpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzbDBYM1J2YTJWdUwyTnZiblJ5WVdOMExuQjVPakUyTndvZ0lDQWdMeThnWVhKak5DNVZTVzUwTmpRb2FYTmZZV05qY25WcGJtY3BMQW9nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOTBiMnRsYmk5amIyNTBjbUZqZEM1d2VUb3hOamdLSUNBZ0lDOHZJR0Z5WXpRdVZVbHVkRFkwS0hScGJXVmZkRzlmYldGMGRYSnBkSGtwTEFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2wwWDNSdmEyVnVMMk52Ym5SeVlXTjBMbkI1T2pFMk9Rb2dJQ0FnTHk4Z1lYSmpOQzVWU1c1ME5qUW9iV0YwZFhKcGRIbGZkR2x0WlNrS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlWFJmZEc5clpXNHZZMjl1ZEhKaFkzUXVjSGs2TVRZMkxURTNNQW9nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1VkhWd2JHVW9LQW9nSUNBZ0x5OGdJQ0FnSUdGeVl6UXVWVWx1ZERZMEtHbHpYMkZqWTNKMWFXNW5LU3dLSUNBZ0lDOHZJQ0FnSUNCaGNtTTBMbFZKYm5RMk5DaDBhVzFsWDNSdlgyMWhkSFZ5YVhSNUtTd0tJQ0FnSUM4dklDQWdJQ0JoY21NMExsVkpiblEyTkNodFlYUjFjbWwwZVY5MGFXMWxLUW9nSUNBZ0x5OGdLU2tLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LWjJWMFgzbHBaV3hrWDNOMFlYUjFjMTkwWlhKdVlYSjVYMlpoYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVYUmZkRzlyWlc0dlkyOXVkSEpoWTNRdWNIazZNVFkwQ2lBZ0lDQXZMeUIwYVcxbFgzUnZYMjFoZEhWeWFYUjVJRDBnYldGMGRYSnBkSGxmZEdsdFpTQXRJR04xY25KbGJuUmZkR2x0WlNCcFppQmpkWEp5Wlc1MFgzUnBiV1VnUENCdFlYUjFjbWwwZVY5MGFXMWxJR1ZzYzJVZ1ZVbHVkRFkwS0RBcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJuWlhSZmVXbGxiR1JmYzNSaGRIVnpYM1JsY201aGNubGZiV1Z5WjJWQU13b0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTU1ZEY5MGIydGxiaTVqYjI1MGNtRmpkQzVaVkZSdmEyVnVMbUZ3Y0hKdmRtVW9jM0JsYm1SbGNqb2dZbmwwWlhNc0lHRnRiM1Z1ZERvZ2RXbHVkRFkwS1NBdFBpQmllWFJsY3pvS1lYQndjbTkyWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1ZEY5MGIydGxiaTlqYjI1MGNtRmpkQzV3ZVRveE56SXRNVGN6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUM4dklHUmxaaUJoY0hCeWIzWmxLSE5sYkdZc0lITndaVzVrWlhJNklFSjVkR1Z6TENCaGJXOTFiblE2SUZWSmJuUTJOQ2tnTFQ0Z1UzUnlhVzVuT2dvZ0lDQWdjSEp2ZEc4Z01pQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVYUmZkRzlyWlc0dlkyOXVkSEpoWTNRdWNIazZNVGMxQ2lBZ0lDQXZMeUJ6Wld4bUxtRnNiRzkzWVc1alpWdFVlRzR1YzJWdVpHVnlYU0E5SUdGdGIzVnVkQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWW5sMFpXTWdOU0F2THlBaVlXeHNiM2RoYm1ObElnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JoY0hCZmJHOWpZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVhSZmRHOXJaVzR2WTI5dWRISmhZM1F1Y0hrNk1UYzNDaUFnSUNBdkx5QnNiMmNvWWlKQmNIQnliM1poYkNCelpYUWdMU0JCYlc5MWJuUTZJQ0lnS3lCdmNDNXBkRzlpS0dGdGIzVnVkQ2twQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbDBiMklLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFF4TnpBM01EY3lObVkzTmpZeE5tTXlNRGN6TmpVM05ESXdNbVF5TURReE5tUTJaamMxTm1VM05ETmhNakFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlWFJmZEc5clpXNHZZMjl1ZEhKaFkzUXVjSGs2TVRjNENpQWdJQ0F2THlCeVpYUjFjbTRnVTNSeWFXNW5LQ0pCY0hCeWIzWmhiQ0J6WlhRZ2MzVmpZMlZ6YzJaMWJHeDVJaWtLSUNBZ0lIQjFjMmhpZVhSbGN5QWlRWEJ3Y205MllXd2djMlYwSUhOMVkyTmxjM05tZFd4c2VTSUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1NWRGOTBiMnRsYmk1amIyNTBjbUZqZEM1WlZGUnZhMlZ1TG1kbGRGOWhiR3h2ZDJGdVkyVW9iM2R1WlhJNklHSjVkR1Z6TENCemNHVnVaR1Z5T2lCaWVYUmxjeWtnTFQ0Z2RXbHVkRFkwT2dwblpYUmZZV3hzYjNkaGJtTmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzbDBYM1J2YTJWdUwyTnZiblJ5WVdOMExuQjVPakU0TUMweE9ERUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ0x5OGdaR1ZtSUdkbGRGOWhiR3h2ZDJGdVkyVW9jMlZzWml3Z2IzZHVaWEk2SUVKNWRHVnpMQ0J6Y0dWdVpHVnlPaUJDZVhSbGN5a2dMVDRnVlVsdWREWTBPZ29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVhSZmRHOXJaVzR2WTI5dWRISmhZM1F1Y0hrNk1UZ3pMVEU0TkFvZ0lDQWdMeThnSXlCVGFXMXdiR2xtYVdWa0lDMGdjbVYwZFhKdWN5QnpaVzVrWlhJbmN5QmhiR3h2ZDJGdVkyVUtJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MbUZzYkc5M1lXNWpaVnRVZUc0dWMyVnVaR1Z5WFFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltRnNiRzkzWVc1alpTSUtJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUZzYkc5M1lXNWpaU0JsZUdsemRITWdabTl5SUdGalkyOTFiblFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NTVkRjkwYjJ0bGJpNWpiMjUwY21GamRDNVpWRlJ2YTJWdUxuUnlZVzV6Wm1WeVgyWnliMjBvWm5KdmJWOWhaR1J5T2lCaWVYUmxjeXdnZEc4NklHSjVkR1Z6TENCaGJXOTFiblE2SUhWcGJuUTJOQ2tnTFQ0Z1lubDBaWE02Q25SeVlXNXpabVZ5WDJaeWIyMDZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVYUmZkRzlyWlc0dlkyOXVkSEpoWTNRdWNIazZNVGcyTFRFNE53b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQXZMeUJrWldZZ2RISmhibk5tWlhKZlpuSnZiU2h6Wld4bUxDQm1jbTl0WDJGa1pISTZJRUo1ZEdWekxDQjBiem9nUW5sMFpYTXNJR0Z0YjNWdWREb2dWVWx1ZERZMEtTQXRQaUJUZEhKcGJtYzZDaUFnSUNCd2NtOTBieUF6SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1ZEY5MGIydGxiaTlqYjI1MGNtRmpkQzV3ZVRveE9Ea0tJQ0FnSUM4dklHRnpjMlZ5ZENCaGJXOTFiblFnUGlCVlNXNTBOalFvTUNrc0lDSkJiVzkxYm5RZ2JYVnpkQ0JpWlNCd2IzTnBkR2wyWlNJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZWE56WlhKMElDOHZJRUZ0YjNWdWRDQnRkWE4wSUdKbElIQnZjMmwwYVhabENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVhSZmRHOXJaVzR2WTI5dWRISmhZM1F1Y0hrNk1Ua3hMVEU1TWdvZ0lDQWdMeThnSXlCRGFHVmpheUJoYkd4dmQyRnVZMlVnS0hOcGJYQnNhV1pwWldRcENpQWdJQ0F2THlCamRYSnlaVzUwWDJGc2JHOTNZVzVqWlNBOUlITmxiR1l1WVd4c2IzZGhibU5sVzFSNGJpNXpaVzVrWlhKZENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTlNBdkx5QWlZV3hzYjNkaGJtTmxJZ29nSUNBZ1lYQndYMnh2WTJGc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVd4c2IzZGhibU5sSUdWNGFYTjBjeUJtYjNJZ1lXTmpiM1Z1ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2wwWDNSdmEyVnVMMk52Ym5SeVlXTjBMbkI1T2pFNU13b2dJQ0FnTHk4Z1lYTnpaWEowSUdOMWNuSmxiblJmWVd4c2IzZGhibU5sSUQ0OUlHRnRiM1Z1ZEN3Z0lrbHVjM1ZtWm1samFXVnVkQ0JoYkd4dmQyRnVZMlVpQ2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1BqMEtJQ0FnSUdGemMyVnlkQ0F2THlCSmJuTjFabVpwWTJsbGJuUWdZV3hzYjNkaGJtTmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVYUmZkRzlyWlc0dlkyOXVkSEpoWTNRdWNIazZNVGsxTFRFNU5nb2dJQ0FnTHk4Z0l5QkRhR1ZqYXlCaVlXeGhibU5sSUNoemFXMXdiR2xtYVdWa0lDMGdZMmhsWTJ0cGJtY2djMlZ1WkdWeUozTWdZbUZzWVc1alpTa0tJQ0FnSUM4dklITmxibVJsY2w5aVlXeGhibU5sSUQwZ2MyVnNaaTVpWVd4aGJtTmxXMVI0Ymk1elpXNWtaWEpkQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVltRnNZVzVqWlNJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtSmhiR0Z1WTJVZ1pYaHBjM1J6SUdadmNpQmhZMk52ZFc1MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVhSZmRHOXJaVzR2WTI5dWRISmhZM1F1Y0hrNk1UazNDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnVaR1Z5WDJKaGJHRnVZMlVnUGowZ1lXMXZkVzUwTENBaVNXNXpkV1ptYVdOcFpXNTBJR0poYkdGdVkyVWlDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnUGowS0lDQWdJR0Z6YzJWeWRDQXZMeUJKYm5OMVptWnBZMmxsYm5RZ1ltRnNZVzVqWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2wwWDNSdmEyVnVMMk52Ym5SeVlXTjBMbkI1T2pFNU9TMHlNREFLSUNBZ0lDOHZJQ01nVlhCa1lYUmxJR0poYkdGdVkyVnpJR0Z1WkNCaGJHeHZkMkZ1WTJVS0lDQWdJQzh2SUhObGJHWXVZbUZzWVc1alpWdFVlRzR1YzJWdVpHVnlYU0E5SUhObGJtUmxjbDlpWVd4aGJtTmxJQzBnWVcxdmRXNTBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUMwS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbUpoYkdGdVkyVWlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1ZEY5MGIydGxiaTlqYjI1MGNtRmpkQzV3ZVRveU1ERUtJQ0FnSUM4dklITmxiR1l1WVd4c2IzZGhibU5sVzFSNGJpNXpaVzVrWlhKZElEMGdZM1Z5Y21WdWRGOWhiR3h2ZDJGdVkyVWdMU0JoYlc5MWJuUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnTFFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lubDBaV01nTlNBdkx5QWlZV3hzYjNkaGJtTmxJZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JoY0hCZmJHOWpZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVhSZmRHOXJaVzR2WTI5dWRISmhZM1F1Y0hrNk1qQXpDaUFnSUNBdkx5QnNiMmNvWWlKVWIydGxibk1nZEhKaGJuTm1aWEp5WldRZ1puSnZiU0F0SUVGdGIzVnVkRG9nSWlBcklHOXdMbWwwYjJJb1lXMXZkVzUwS1NrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhWFJ2WWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TlRRMlpqWmlOalUyWlRjek1qQTNORGN5TmpFMlpUY3pOalkyTlRjeU56STJOVFkwTWpBMk5qY3lObVkyWkRJd01tUXlNRFF4Tm1RMlpqYzFObVUzTkROaE1qQUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVYUmZkRzlyWlc0dlkyOXVkSEpoWTNRdWNIazZNakEwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdVM1J5YVc1bktDSlViMnRsYm5NZ2RISmhibk5tWlhKeVpXUWdjM1ZqWTJWemMyWjFiR3g1SWlrS0lDQWdJSEIxYzJoaWVYUmxjeUFpVkc5clpXNXpJSFJ5WVc1elptVnljbVZrSUhOMVkyTmxjM05tZFd4c2VTSUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1NWRGOTBiMnRsYmk1amIyNTBjbUZqZEM1WlZGUnZhMlZ1TG1OaGJHTjFiR0YwWlY5NWFXVnNaRjkyWVd4MVpTaGlZWE5sWDJGdGIzVnVkRG9nZFdsdWREWTBMQ0I1YVdWc1pGOXlZWFJsT2lCMWFXNTBOalFwSUMwK0lIVnBiblEyTkRvS1kyRnNZM1ZzWVhSbFgzbHBaV3hrWDNaaGJIVmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzbDBYM1J2YTJWdUwyTnZiblJ5WVdOMExuQjVPakl3TmkweU1EY0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdMeThnWkdWbUlHTmhiR04xYkdGMFpWOTVhV1ZzWkY5MllXeDFaU2h6Wld4bUxDQmlZWE5sWDJGdGIzVnVkRG9nVlVsdWREWTBMQ0I1YVdWc1pGOXlZWFJsT2lCVlNXNTBOalFwSUMwK0lGVkpiblEyTkRvS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzbDBYM1J2YTJWdUwyTnZiblJ5WVdOMExuQjVPakl3T1FvZ0lDQWdMeThnWTNWeWNtVnVkRjkwYVcxbElEMGdSMnh2WW1Gc0xteGhkR1Z6ZEY5MGFXMWxjM1JoYlhBS0lDQWdJR2RzYjJKaGJDQk1ZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJR1IxY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2wwWDNSdmEyVnVMMk52Ym5SeVlXTjBMbkI1T2pJeE1Bb2dJQ0FnTHk4Z2JXRjBkWEpwZEhsZmRHbHRaU0E5SUhObGJHWXViV0YwZFhKcGRIa3VkbUZzZFdVS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0p0WVhSMWNtbDBlU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0J6ZDJGd0NpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbTFoZEhWeWFYUjVJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNsMFgzUnZhMlZ1TDJOdmJuUnlZV04wTG5CNU9qSXhNZ29nSUNBZ0x5OGdhV1lnWTNWeWNtVnVkRjkwYVcxbElENDlJRzFoZEhWeWFYUjVYM1JwYldVNkNpQWdJQ0ErUFFvZ0lDQWdZbm9nWTJGc1kzVnNZWFJsWDNscFpXeGtYM1poYkhWbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2wwWDNSdmEyVnVMMk52Ym5SeVlXTjBMbkI1T2pJeE13b2dJQ0FnTHk4Z2NtVjBkWEp1SUZWSmJuUTJOQ2d3S1NBZ0l5Qk9ieUI1YVdWc1pDQmhablJsY2lCdFlYUjFjbWwwZVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ2NtVjBjM1ZpQ2dwallXeGpkV3hoZEdWZmVXbGxiR1JmZG1Gc2RXVmZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNsMFgzUnZhMlZ1TDJOdmJuUnlZV04wTG5CNU9qSXhOUW9nSUNBZ0x5OGdkR2x0WlY5eVpXMWhhVzVwYm1jZ1BTQnRZWFIxY21sMGVWOTBhVzFsSUMwZ1kzVnljbVZ1ZEY5MGFXMWxDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJQzBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTVkRjkwYjJ0bGJpOWpiMjUwY21GamRDNXdlVG95TWpBS0lDQWdJQzh2SUhscFpXeGtYM1poYkhWbElEMGdLR0poYzJWZllXMXZkVzUwSUNvZ2VXbGxiR1JmY21GMFpTQXFJSFJwYldWZmNtVnRZV2x1YVc1bktTQXZMeUFvYzJWamIyNWtjMTl3WlhKZmVXVmhjaUFxSUZWSmJuUTJOQ2d4TURBd01Da3BDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnS2dvZ0lDQWdLZ29nSUNBZ2NIVnphR2x1ZENBek1UVXpOakF3TURBd01EQWdMeThnTXpFMU16WXdNREF3TURBd0NpQWdJQ0F2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlWFJmZEc5clpXNHZZMjl1ZEhKaFkzUXVjSGs2TWpJeENpQWdJQ0F2THlCeVpYUjFjbTRnZVdsbGJHUmZkbUZzZFdVS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbmwwWDNSdmEyVnVMbU52Ym5SeVlXTjBMbGxVVkc5clpXNHVkWEJrWVhSbFgyOTNibVZ5S0c1bGQxOXZkMjVsY2pvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwMWNHUmhkR1ZmYjNkdVpYSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVYUmZkRzlyWlc0dlkyOXVkSEpoWTNRdWNIazZNakl6TFRJeU5Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQXZMeUJrWldZZ2RYQmtZWFJsWDI5M2JtVnlLSE5sYkdZc0lHNWxkMTl2ZDI1bGNqb2dRbmwwWlhNcElDMCtJRk4wY21sdVp6b0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2wwWDNSdmEyVnVMMk52Ym5SeVlXTjBMbkI1T2pJeU5nb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJdVlubDBaWE1nUFQwZ2MyVnNaaTV2ZDI1bGNpNTJZV3gxWlN3Z0lrOXViSGtnYjNkdVpYSWdZMkZ1SUhWd1pHRjBaU0lLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKdmQyNWxjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1dmQyNWxjaUJsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1c2VTQnZkMjVsY2lCallXNGdkWEJrWVhSbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVhSZmRHOXJaVzR2WTI5dWRISmhZM1F1Y0hrNk1qSTRDaUFnSUNBdkx5QnpaV3htTG05M2JtVnlMblpoYkhWbElEMGdibVYzWDI5M2JtVnlDaUFnSUNCaWVYUmxZeUEwSUM4dklDSnZkMjVsY2lJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1ZEY5MGIydGxiaTlqYjI1MGNtRmpkQzV3ZVRveU16QUtJQ0FnSUM4dklHeHZaeWhpSWs5M2JtVnlJSFZ3WkdGMFpXUWlLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjROR1kzTnpabE5qVTNNakl3TnpVM01EWTBOakUzTkRZMU5qUUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNsMFgzUnZhMlZ1TDJOdmJuUnlZV04wTG5CNU9qSXpNUW9nSUNBZ0x5OGdjbVYwZFhKdUlGTjBjbWx1WnlnaVQzZHVaWElnZFhCa1lYUmxaQ0J6ZFdOalpYTnpablZzYkhraUtRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKUGQyNWxjaUIxY0dSaGRHVmtJSE4xWTJObGMzTm1kV3hzZVNJS0lDQWdJSEpsZEhOMVlnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBQ0FBRW1DUVFWSDN4MUIySmhiR0Z1WTJVTWRHOTBZV3hmYzNWd2NHeDVDRzFoZEhWeWFYUjVCVzkzYm1WeUNXRnNiRzkzWVc1alpRUnVZVzFsQm5ONWJXSnZiQWhrWldOcGJXRnNjekViUVFJYWdoQUVTNWh0T2dSNUxhSEtCSEk4RlRzRWUxOXZWd1JncFZ6bUJFYVFrMVVFVHpjK2lBU0VyRml0Qk9Sd1ZkMEVSbU92MFFTMDJYK01CRnNmbC80RUtoWEppQVRKVmYyREJGTVBRT2tFdnU3bUdUWWFBSTRRQVhzQldRRTlBUnNCQkFEekFPSUEwUURBQUxBQW9BQitBR0VBT1FBZ0FBSWlRekVaRkVReEdFUTJHZ0ZYQWdDSUJPUkpGUlpYQmdKTVVDaE1VTEFqUXpFWkZFUXhHRVEyR2dFWE5ob0NGNGdFbGhZb1RGQ3dJME14R1JSRU1SaEVOaG9CVndJQU5ob0NWd0lBTmhvREY0Z0QrVWtWRmxjR0FreFFLRXhRc0NORE1Sa1VSREVZUkRZYUFWY0NBRFlhQWxjQ0FJZ0R5aFlvVEZDd0kwTXhHUlJFTVJoRU5ob0JWd0lBTmhvQ0Y0Z0Rha2tWRmxjR0FreFFLRXhRc0NORE1Sa1VSREVZUklnREpDaE1VTEFqUXpFWkZFUXhHRVNJQXRRb1RGQ3dJME14R1JSRU1SaEVpQUsyRmloTVVMQWpRekVaRkVReEdFU0lBcGNXS0V4UXNDTkRNUmtVUkRFWVJJZ0NnUllvVEZDd0kwTXhHUlJFTVJoRWlBSnJGaWhNVUxBalF6RVpGRVF4R0VRMkdnRlhBZ0NJQWtvV0tFeFFzQ05ETVJrVVJERVlSRFlhQVZjQ0FEWWFBaGVJQWNoSkZSWlhCZ0pNVUNoTVVMQWpRekVaRkVReEdFUTJHZ0VYaUFGRlNSVVdWd1lDVEZBb1RGQ3dJME14R1JSRU1SaEVOaG9CVndJQU5ob0NGNGdBdUVrVkZsY0dBa3hRS0V4UXNDTkRNUmtVUkRFWVJEWWFBVmNDQURZYUFsY0NBRFlhQXhlSUFCbEpGUlpYQmdKTVVDaE1VTEFqUXpFWlFQNVlNUmdVUkNORGlnTUJNUUF5Q1JKRWkvOHlCdzFFSndReEFHY25Cb3Y5WnljSGkvNW5LNHYvWnlvaVp5Y0lnUWhuaS84V2dDRlpWQ0JVYjJ0bGJpQnBibWwwYVdGc2FYcGxaQ0F0SUUxaGRIVnlhWFI1T2lCTVVMQ0FJVmxVSUZSdmEyVnVJR2x1YVhScFlXeHBlbVZrSUhOMVkyTmxjM05tZFd4c2VZbUtBZ0V4QUNJbkJHVkVFa1NMLzBRaUttVkVpLzhJS2t4bk1RQWlLV05FaS84SU1RQXBUd0ptaS84V2dCdFpWQ0IwYjJ0bGJuTWdiV2x1ZEdWa0lDMGdRVzF2ZFc1ME9pQk1VTENBSFZsVUlIUnZhMlZ1Y3lCdGFXNTBaV1FnYzNWalkyVnpjMloxYkd4NWlZb0JBWXYvUkRFQUlpbGpSRW1ML3c5RWkvOEpNUUFwVHdKbUlpcGxSSXYvQ1NwTVo0di9Gb0FiV1ZRZ2RHOXJaVzV6SUdKMWNtNWxaQ0F0SUVGdGIzVnVkRG9nVEZDd2dCMVpWQ0IwYjJ0bGJuTWdZblZ5Ym1Wa0lITjFZMk5sYzNObWRXeHNlWW1LQWdHTC8wUXhBQ0lwWTBSSmkvOFBSSXYvQ1RFQUtVOENab3YvRm9BZ1dWUWdkRzlyWlc1eklIUnlZVzV6Wm1WeWNtVmtJQzBnUVcxdmRXNTBPaUJNVUxDQUlsbFVJSFJ2YTJWdWN5QjBjbUZ1YzJabGNuSmxaQ0J6ZFdOalpYTnpablZzYkhtSmlnRUJNUUFpS1dORWlTSXFaVVNKSWl0bFJJa3lCeUlyWlVRUFFRQUNJNGtpaVRJSElpdGxSQXhCQUFJamlTS0pJaWNHWlVSSkZSWlhCZ0pNVUNJbkIyVkVTUlVXVndZQ1RGQWlKd2hsUkJZaUttVkVGa3NERllFVUNCWlhCZ0tBQWdBVVRGQlBBbEJNVUU4Q1VFeFFpWW9BQVRJSFNTSXJaVXhKVGdKT0EwUU1TVUVBRllzQml3QUppd0lXVEJhTEFSWk9BbEJNVUl3QWlTSkMvK3lLQWdFeEFDY0ZpLzltaS84V2dCZEJjSEJ5YjNaaGJDQnpaWFFnTFNCQmJXOTFiblE2SUV4UXNJQVpRWEJ3Y205MllXd2djMlYwSUhOMVkyTmxjM05tZFd4c2VZbUtBZ0V4QUNJbkJXTkVpWW9EQVl2L1JERUFJaWNGWTBSSmkvOFBSREVBSWlsalJFbUwvdzlFaS84Sk1RQXBUd0ptaS84Sk1RQW5CVThDWm92L0ZvQWlWRzlyWlc1eklIUnlZVzV6Wm1WeWNtVmtJR1p5YjIwZ0xTQkJiVzkxYm5RNklFeFFzSUFmVkc5clpXNXpJSFJ5WVc1elptVnljbVZrSUhOMVkyTmxjM05tZFd4c2VZbUtBZ0V5QjBraUsyVk1TVTRDVGdORUQwRUFCQ0tNQUltTEFZc0FDWXYraS84TEM0R0E4SzdubGdrS2pBQ0ppZ0VCTVFBaUp3UmxSQkpFSndTTC8yZUFEVTkzYm1WeUlIVndaR0YwWldTd2dCcFBkMjVsY2lCMWNHUmhkR1ZrSUhOMVkyTmxjM05tZFd4c2VZaz0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjoxMCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
