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

namespace Arc56.Generated.Antxnrx.CodeX_NutriGrade.NutriGradeSimple_74d3d873
{


    //
    // 
    //    Simple NutriGrade Smart Contract for food product scanning.
    //    Stores basic product information and scan counts on Algorand blockchain.
    //
    //    Features:
    //    - Add/update product information
    //    - Track scan counts for products
    //    - Query product details
    //    - Simple and easy to deploy
    //    
    //
    public class NutriGradeSimpleProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public NutriGradeSimpleProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetStatsReturn : AVMObjectType
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

                public static GetStatsReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetStatsReturn();
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
                    return Equals(obj as GetStatsReturn);
                }
                public bool Equals(GetStatsReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetStatsReturn left, GetStatsReturn right)
                {
                    return EqualityComparer<GetStatsReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetStatsReturn left, GetStatsReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetUserStatsReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public string Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField1.From(Field1);
                    stringRef[ret.Count] = vField1.Encode();
                    ret.AddRange(new byte[2]);
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetUserStatsReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new GetUserStatsReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    var indexField1 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField1.Decode(bytes.Skip(indexField1 + prefixOffset).ToArray());
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is string vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetUserStatsReturn);
                }
                public bool Equals(GetUserStatsReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetUserStatsReturn left, GetUserStatsReturn right)
                {
                    return EqualityComparer<GetUserStatsReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetUserStatsReturn left, GetUserStatsReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Initialize the contract (can only be called once by creator)
        ///</summary>
        public async Task<string> Bootstrap(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 57, 25, 70 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Bootstrap_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 57, 25, 70 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Add a new product to the blockchain.
        ///Only contract owner can add products.
        ///</summary>
        /// <param name="product_id">Barcode or unique identifier </param>
        /// <param name="name">Product name </param>
        /// <param name="ingredients">Comma-separated ingredients list </param>
        public async Task<string> AddProduct(string product_id, string name, string ingredients, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 230, 22, 145 };
            var product_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); product_idAbi.From(product_id);
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var ingredientsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); ingredientsAbi.From(ingredients);

            var result = await base.CallApp(new List<object> { abiHandle, product_idAbi, nameAbi, ingredientsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> AddProduct_Transactions(string product_id, string name, string ingredients, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 230, 22, 145 };
            var product_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); product_idAbi.From(product_id);
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var ingredientsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); ingredientsAbi.From(ingredients);

            return await base.MakeTransactionList(new List<object> { abiHandle, product_idAbi, nameAbi, ingredientsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Record a product scan by a user.
        ///Any user can scan products.
        ///</summary>
        /// <param name="product_id">The product being scanned </param>
        public async Task<string> ScanProduct(string product_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 58, 243, 82, 148 };
            var product_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); product_idAbi.From(product_id);

            var result = await base.CallApp(new List<object> { abiHandle, product_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> ScanProduct_Transactions(string product_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 58, 243, 82, 148 };
            var product_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); product_idAbi.From(product_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, product_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get contract statistics.
        ///</summary>
        public async Task<Structs.GetStatsReturn> GetStats(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 230, 125, 175, 81 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetStatsReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetStats_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 230, 125, 175, 81 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get user's scanning statistics.
        ///</summary>
        public async Task<Structs.GetUserStatsReturn> GetUserStats(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 50, 227, 162, 173 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetUserStatsReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetUserStats_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 50, 227, 162, 173 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Opt-in to use the NutriGrade scanner.
        ///Users must opt-in before they can scan products.
        ///</summary>
        public async Task<string> OptIn(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 18, 34, 56, 242 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> OptIn_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 18, 34, 56, 242 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Opt-out from the NutriGrade scanner.
        ///This will clear user's local state.
        ///</summary>
        public async Task<string> OptOut(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 105, 132, 238, 152 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> OptOut_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 105, 132, 238, 152 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update existing product information.
        ///Only owner can update products.
        ///</summary>
        /// <param name="product_id">Product identifier </param>
        /// <param name="name">Updated product name </param>
        /// <param name="ingredients">Updated ingredients </param>
        public async Task<string> UpdateProduct(string product_id, string name, string ingredients, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 28, 125, 89, 101 };
            var product_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); product_idAbi.From(product_id);
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var ingredientsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); ingredientsAbi.From(ingredients);

            var result = await base.CallApp(new List<object> { abiHandle, product_idAbi, nameAbi, ingredientsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> UpdateProduct_Transactions(string product_id, string name, string ingredients, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 28, 125, 89, 101 };
            var product_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); product_idAbi.From(product_id);
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var ingredientsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); ingredientsAbi.From(ingredients);

            return await base.MakeTransactionList(new List<object> { abiHandle, product_idAbi, nameAbi, ingredientsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the contract owner address.
        ///</summary>
        public async Task<Algorand.Address> GetOwner(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 255, 43, 165, 197 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> GetOwner_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 255, 43, 165, 197 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get contract version.
        ///</summary>
        public async Task<string> GetVersion(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 47, 186, 90, 27 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetVersion_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 47, 186, 90, 27 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTnV0cmlHcmFkZVNpbXBsZSIsImRlc2MiOiJcbiAgICBTaW1wbGUgTnV0cmlHcmFkZSBTbWFydCBDb250cmFjdCBmb3IgZm9vZCBwcm9kdWN0IHNjYW5uaW5nLlxuICAgIFN0b3JlcyBiYXNpYyBwcm9kdWN0IGluZm9ybWF0aW9uIGFuZCBzY2FuIGNvdW50cyBvbiBBbGdvcmFuZCBibG9ja2NoYWluLlxuXG4gICAgRmVhdHVyZXM6XG4gICAgLSBBZGQvdXBkYXRlIHByb2R1Y3QgaW5mb3JtYXRpb25cbiAgICAtIFRyYWNrIHNjYW4gY291bnRzIGZvciBwcm9kdWN0c1xuICAgIC0gUXVlcnkgcHJvZHVjdCBkZXRhaWxzXG4gICAgLSBTaW1wbGUgYW5kIGVhc3kgdG8gZGVwbG95XG4gICAgIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkdldFN0YXRzUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifV0sIkdldFVzZXJTdGF0c1JldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoic3RyaW5nIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImJvb3RzdHJhcCIsImRlc2MiOiJJbml0aWFsaXplIHRoZSBjb250cmFjdCAoY2FuIG9ubHkgYmUgY2FsbGVkIG9uY2UgYnkgY3JlYXRvcikiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhZGRfcHJvZHVjdCIsImRlc2MiOiJBZGQgYSBuZXcgcHJvZHVjdCB0byB0aGUgYmxvY2tjaGFpbi5cbk9ubHkgY29udHJhY3Qgb3duZXIgY2FuIGFkZCBwcm9kdWN0cy4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvZHVjdF9pZCIsImRlc2MiOiJCYXJjb2RlIG9yIHVuaXF1ZSBpZGVudGlmaWVyIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6IlByb2R1Y3QgbmFtZSIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW5ncmVkaWVudHMiLCJkZXNjIjoiQ29tbWEtc2VwYXJhdGVkIGluZ3JlZGllbnRzIGxpc3QiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjoiU3VjY2VzcyBtZXNzYWdlIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2Nhbl9wcm9kdWN0IiwiZGVzYyI6IlJlY29yZCBhIHByb2R1Y3Qgc2NhbiBieSBhIHVzZXIuXG5BbnkgdXNlciBjYW4gc2NhbiBwcm9kdWN0cy4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvZHVjdF9pZCIsImRlc2MiOiJUaGUgcHJvZHVjdCBiZWluZyBzY2FubmVkIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlNjYW4gY29uZmlybWF0aW9uIG1lc3NhZ2UifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfc3RhdHMiLCJkZXNjIjoiR2V0IGNvbnRyYWN0IHN0YXRpc3RpY3MuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkdldFN0YXRzUmV0dXJuIiwiZGVzYyI6IlR1cGxlIG9mICh0b3RhbF9wcm9kdWN0cywgdG90YWxfc2NhbnMpIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfdXNlcl9zdGF0cyIsImRlc2MiOiJHZXQgdXNlcidzIHNjYW5uaW5nIHN0YXRpc3RpY3MuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsc3RyaW5nKSIsInN0cnVjdCI6IkdldFVzZXJTdGF0c1JldHVybiIsImRlc2MiOiJUdXBsZSBvZiAoc2Nhbl9jb3VudCwgbGFzdF9zY2FubmVkX3Byb2R1Y3RfaWQpIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJvcHRfaW4iLCJkZXNjIjoiT3B0LWluIHRvIHVzZSB0aGUgTnV0cmlHcmFkZSBzY2FubmVyLlxuVXNlcnMgbXVzdCBvcHQtaW4gYmVmb3JlIHRoZXkgY2FuIHNjYW4gcHJvZHVjdHMuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IldlbGNvbWUgbWVzc2FnZSJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im9wdF9vdXQiLCJkZXNjIjoiT3B0LW91dCBmcm9tIHRoZSBOdXRyaUdyYWRlIHNjYW5uZXIuXG5UaGlzIHdpbGwgY2xlYXIgdXNlcidzIGxvY2FsIHN0YXRlLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJHb29kYnllIG1lc3NhZ2UifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIkNsb3NlT3V0Il19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlX3Byb2R1Y3QiLCJkZXNjIjoiVXBkYXRlIGV4aXN0aW5nIHByb2R1Y3QgaW5mb3JtYXRpb24uXG5Pbmx5IG93bmVyIGNhbiB1cGRhdGUgcHJvZHVjdHMuIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb2R1Y3RfaWQiLCJkZXNjIjoiUHJvZHVjdCBpZGVudGlmaWVyIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6IlVwZGF0ZWQgcHJvZHVjdCBuYW1lIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbmdyZWRpZW50cyIsImRlc2MiOiJVcGRhdGVkIGluZ3JlZGllbnRzIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlVwZGF0ZSBjb25maXJtYXRpb24ifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfb3duZXIiLCJkZXNjIjoiR2V0IHRoZSBjb250cmFjdCBvd25lciBhZGRyZXNzLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjoiT3duZXIncyBhZGRyZXNzIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfdmVyc2lvbiIsImRlc2MiOiJHZXQgY29udHJhY3QgdmVyc2lvbi4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjoiVmVyc2lvbiBzdHJpbmcifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoyLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjEsImJ5dGVzIjoxfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNDQ3XSwiZXJyb3JNZXNzYWdlIjoiQWxyZWFkeSBib290c3RyYXBwZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNjldLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IENsb3NlT3V0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg0LDIyNiwyNDIsMzE4LDMzNCwzNTAsMzY2LDM4NSw0MTBdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MTRdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IG93bmVyIGNhbiBhZGQgcHJvZHVjdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NDFdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IG93bmVyIGNhbiBib290c3RyYXAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3OTJdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IG93bmVyIGNhbiB1cGRhdGUgcHJvZHVjdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NjRdLCJlcnJvck1lc3NhZ2UiOiJQbGVhc2Ugb3B0LWluIGZpcnN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDMxXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg3LDIyOSwyNDUsMjcyLDMyMSwzMzcsMzUzLDM2OSwzODgsNDEzXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY5N10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYubGFzdF9zY2FubmVkX3Byb2R1Y3QgZXhpc3RzIGZvciBhY2NvdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDM5LDUxMiw3OTAsODMwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5vd25lciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NDUsNTE4LDYzOV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfcHJvZHVjdHMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTY4LDY0NF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfc2NhbnMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTgwLDY4OV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudXNlcl9zY2FuX2NvdW50IGV4aXN0cyBmb3IgYWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Ym5WMGNtbGZZMjl1ZEhKaFkzUXVZMjl1ZEhKaFkzUXVUblYwY21sSGNtRmtaVk5wYlhCc1pTNWZYMkZzWjI5d2VWOWxiblJ5ZVhCdmFXNTBYM2RwZEdoZmFXNXBkQ2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVLSUNBZ0lHSjVkR1ZqWW14dlkyc2dNSGd4TlRGbU4yTTNOU0FpZEc5MFlXeGZjSEp2WkhWamRITWlJQ0p2ZDI1bGNpSWdJblJ2ZEdGc1gzTmpZVzV6SWlBaWRYTmxjbDl6WTJGdVgyTnZkVzUwSWlBaWJHRnpkRjl6WTJGdWJtVmtYM0J5YjJSMVkzUWlDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym5WMGNtbGZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TWpZdE1qY0tJQ0FnSUM4dklDTWdSMnh2WW1Gc0lITjBZWFJsSUMwZ1kyOXVkSEpoWTNRZ2JHVjJaV3dnWkdGMFlRb2dJQ0FnTHk4Z2MyVnNaaTV2ZDI1bGNpQTlJRWRzYjJKaGJGTjBZWFJsS0ZSNGJpNXpaVzVrWlhJcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKdmQyNWxjaUlLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJuVjBjbWxmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1qZ0tJQ0FnSUM4dklITmxiR1l1ZEc5MFlXeGZjSEp2WkhWamRITWdQU0JIYkc5aVlXeFRkR0YwWlNoVlNXNTBOalFvTUNrcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKMGIzUmhiRjl3Y205a2RXTjBjeUlLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNTFkSEpwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qSTVDaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYM05qWVc1eklEMGdSMnh2WW1Gc1UzUmhkR1VvVlVsdWREWTBLREFwS1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpZEc5MFlXeGZjMk5oYm5NaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNTFkSEpwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qRXpDaUFnSUNBdkx5QmpiR0Z6Y3lCT2RYUnlhVWR5WVdSbFUybHRjR3hsS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5aVlYSmxYM0p2ZFhScGJtZEFNVFVLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGcxTkRNNU1UazBOaUF3ZUdZeFpUWXhOamt4SURCNE0yRm1NelV5T1RRZ01IaGxOamRrWVdZMU1TQXdlRE15WlROaE1tRmtJREI0TVRJeU1qTTRaaklnTUhnMk9UZzBaV1U1T0NBd2VERmpOMlExT1RZMUlEQjRabVl5WW1FMVl6VWdNSGd5Wm1KaE5XRXhZaUF2THlCdFpYUm9iMlFnSW1KdmIzUnpkSEpoY0NncGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKaFpHUmZjSEp2WkhWamRDaHpkSEpwYm1jc2MzUnlhVzVuTEhOMGNtbHVaeWx6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJbk5qWVc1ZmNISnZaSFZqZENoemRISnBibWNwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0puWlhSZmMzUmhkSE1vS1NoMWFXNTBOalFzZFdsdWREWTBLU0lzSUcxbGRHaHZaQ0FpWjJWMFgzVnpaWEpmYzNSaGRITW9LU2gxYVc1ME5qUXNjM1J5YVc1bktTSXNJRzFsZEdodlpDQWliM0IwWDJsdUtDbHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0ltOXdkRjl2ZFhRb0tYTjBjbWx1WnlJc0lHMWxkR2h2WkNBaWRYQmtZWFJsWDNCeWIyUjFZM1FvYzNSeWFXNW5MSE4wY21sdVp5eHpkSEpwYm1jcGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKblpYUmZiM2R1WlhJb0tXRmtaSEpsYzNNaUxDQnRaWFJvYjJRZ0ltZGxkRjkyWlhKemFXOXVLQ2x6ZEhKcGJtY2lDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J0WVdsdVgySnZiM1J6ZEhKaGNGOXliM1YwWlVBMUlHMWhhVzVmWVdSa1gzQnliMlIxWTNSZmNtOTFkR1ZBTmlCdFlXbHVYM05qWVc1ZmNISnZaSFZqZEY5eWIzVjBaVUEzSUcxaGFXNWZaMlYwWDNOMFlYUnpYM0p2ZFhSbFFEZ2diV0ZwYmw5blpYUmZkWE5sY2w5emRHRjBjMTl5YjNWMFpVQTVJRzFoYVc1ZmIzQjBYMmx1WDNKdmRYUmxRREV3SUcxaGFXNWZiM0IwWDI5MWRGOXliM1YwWlVBeE1TQnRZV2x1WDNWd1pHRjBaVjl3Y205a2RXTjBYM0p2ZFhSbFFERXlJRzFoYVc1ZloyVjBYMjkzYm1WeVgzSnZkWFJsUURFeklHMWhhVzVmWjJWMFgzWmxjbk5wYjI1ZmNtOTFkR1ZBTVRRS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhOem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVkWFJ5YVY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3hNd29nSUNBZ0x5OGdZMnhoYzNNZ1RuVjBjbWxIY21Ga1pWTnBiWEJzWlNoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJmZG1WeWMybHZibDl5YjNWMFpVQXhORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVkWFJ5YVY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3lNRE1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOVEF3TVRnMFpUYzFOelEzTWpZNU5EYzNNall4TmpRMk5USXdOVE0yT1Raa056QTJZelkxTWpBM05qTXhNbVV6TURKbE16QUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUmZiM2R1WlhKZmNtOTFkR1ZBTVRNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym5WMGNtbGZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TVRrekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnWTJGc2JITjFZaUJuWlhSZmIzZHVaWElLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkWEJrWVhSbFgzQnliMlIxWTNSZmNtOTFkR1ZBTVRJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym5WMGNtbGZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TVRZNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNTFkSEpwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qRXpDaUFnSUNBdkx5QmpiR0Z6Y3lCT2RYUnlhVWR5WVdSbFUybHRjR3hsS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJuVjBjbWxmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1UWTVDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR05oYkd4emRXSWdkWEJrWVhSbFgzQnliMlIxWTNRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmYjNCMFgyOTFkRjl5YjNWMFpVQXhNVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVkWFJ5YVY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3hOVGdLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaGhiR3h2ZDE5aFkzUnBiMjV6UFZzaVEyeHZjMlZQZFhRaVhTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lIQjFjMmhwYm5RZ01pQXZMeUJEYkc5elpVOTFkQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFTnNiM05sVDNWMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREUxTVdZM1l6YzFNREF4WmpVME5qZzJNVFpsTm1JeU1EYzVObVkzTlRJd05qWTJaamN5TWpBM05UY3pOamsyWlRZM01qQTBaVGMxTnpRM01qWTVORGMzTWpZeE5qUTJOVEl4Q2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZiM0IwWDJsdVgzSnZkWFJsUURFd09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1MWRISnBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pFME13b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lHTmhiR3h6ZFdJZ2IzQjBYMmx1Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEY5MWMyVnlYM04wWVhSelgzSnZkWFJsUURrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym5WMGNtbGZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TVRFNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnWTJGc2JITjFZaUJuWlhSZmRYTmxjbDl6ZEdGMGN3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUmZjM1JoZEhOZmNtOTFkR1ZBT0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1ZFhSeWFWOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG94TURRS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JqWVd4c2MzVmlJR2RsZEY5emRHRjBjd29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXpZMkZ1WDNCeWIyUjFZM1JmY205MWRHVkFOem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVkWFJ5YVY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzNOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1ZFhSeWFWOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG94TXdvZ0lDQWdMeThnWTJ4aGMzTWdUblYwY21sSGNtRmtaVk5wYlhCc1pTaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjUxZEhKcFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPamMxQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdOaGJHeHpkV0lnYzJOaGJsOXdjbTlrZFdOMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJGa1pGOXdjbTlrZFdOMFgzSnZkWFJsUURZNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym5WMGNtbGZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TkRjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJuVjBjbWxmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1UTUtJQ0FnSUM4dklHTnNZWE56SUU1MWRISnBSM0poWkdWVGFXMXdiR1VvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dWRYUnlhVjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvME53b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQmpZV3hzYzNWaUlHRmtaRjl3Y205a2RXTjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgySnZiM1J6ZEhKaGNGOXliM1YwWlVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1MWRISnBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pNMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCaWIyOTBjM1J5WVhBS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWW1GeVpWOXliM1YwYVc1blFERTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNTFkSEpwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qRXpDaUFnSUNBdkx5QmpiR0Z6Y3lCT2RYUnlhVWR5WVdSbFUybHRjR3hsS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURFM0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCamNtVmhkR2x1WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXVkWFJ5YVY5amIyNTBjbUZqZEM1amIyNTBjbUZqZEM1T2RYUnlhVWR5WVdSbFUybHRjR3hsTG1KdmIzUnpkSEpoY0NncElDMCtJR0o1ZEdWek9ncGliMjkwYzNSeVlYQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJuVjBjbWxmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk16Z0tJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSE5sYkdZdWIzZHVaWEl1ZG1Gc2RXVXNJQ0pQYm14NUlHOTNibVZ5SUdOaGJpQmliMjkwYzNSeVlYQWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpYjNkdVpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YjNkdVpYSWdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ2IzZHVaWElnWTJGdUlHSnZiM1J6ZEhKaGNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1MWRISnBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pNNUNpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNTBiM1JoYkY5d2NtOWtkV04wY3k1MllXeDFaU0E5UFNCVlNXNTBOalFvTUNrc0lDSkJiSEpsWVdSNUlHSnZiM1J6ZEhKaGNIQmxaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjBiM1JoYkY5d2NtOWtkV04wY3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5d2NtOWtkV04wY3lCbGVHbHpkSE1LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCQmJISmxZV1I1SUdKdmIzUnpkSEpoY0hCbFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1MWRISnBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pReExUUXlDaUFnSUNBdkx5QWpJRk5sZENCcGJtbDBhV0ZzSUhOMFlYUmxDaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYM0J5YjJSMVkzUnpMblpoYkhWbElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjBiM1JoYkY5d2NtOWtkV04wY3lJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjUxZEhKcFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalF6Q2lBZ0lDQXZMeUJ6Wld4bUxuUnZkR0ZzWDNOallXNXpMblpoYkhWbElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZMTh6SUM4dklDSjBiM1JoYkY5elkyRnVjeUlLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNTFkSEpwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qUTFDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpOQzVUZEhKcGJtY29JazUxZEhKcFIzSmhaR1VnUTI5dWRISmhZM1FnU1c1cGRHbGhiR2w2WldRZ1UzVmpZMlZ6YzJaMWJHeDVJU0lwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURKa05HVTNOVGMwTnpJMk9UUTNOekkyTVRZME5qVXlNRFF6Tm1ZMlpUYzBOekkyTVRZek56UXlNRFE1Tm1VMk9UYzBOamsyTVRaak5qazNZVFkxTmpReU1EVXpOelUyTXpZek5qVTNNemN6TmpZM05UWmpObU0zT1RJeENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Ym5WMGNtbGZZMjl1ZEhKaFkzUXVZMjl1ZEhKaFkzUXVUblYwY21sSGNtRmtaVk5wYlhCc1pTNWhaR1JmY0hKdlpIVmpkQ2h3Y205a2RXTjBYMmxrT2lCaWVYUmxjeXdnYm1GdFpUb2dZbmwwWlhNc0lHbHVaM0psWkdsbGJuUnpPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbUZrWkY5d2NtOWtkV04wT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjUxZEhKcFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalEzTFRVekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lDOHZJR1JsWmlCaFpHUmZjSEp2WkhWamRDZ0tJQ0FnSUM4dklDQWdJQ0J6Wld4bUxBb2dJQ0FnTHk4Z0lDQWdJSEJ5YjJSMVkzUmZhV1E2SUdGeVl6UXVVM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQWdJRzVoYldVNklHRnlZelF1VTNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0FnSUdsdVozSmxaR2xsYm5Sek9pQmhjbU0wTGxOMGNtbHVaeXdLSUNBZ0lDOHZJQ2tnTFQ0Z1lYSmpOQzVUZEhKcGJtYzZDaUFnSUNCd2NtOTBieUF6SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1ZFhSeWFWOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8yTmkwMk53b2dJQ0FnTHk4Z0l5QlBibXg1SUc5M2JtVnlJR05oYmlCaFpHUWdjSEp2WkhWamRITUtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSE5sYkdZdWIzZHVaWEl1ZG1Gc2RXVXNJQ0pQYm14NUlHOTNibVZ5SUdOaGJpQmhaR1FnY0hKdlpIVmpkSE1pQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWIzZHVaWElpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWIzZHVaWElnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2diM2R1WlhJZ1kyRnVJR0ZrWkNCd2NtOWtkV04wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjUxZEhKcFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalk1TFRjeENpQWdJQ0F2THlBaklFbHVJR0VnY21WaGJDQnBiWEJzWlcxbGJuUmhkR2x2Yml3Z2QyVW5aQ0J6ZEc5eVpTQjBhR2x6SUdsdUlHSnZlQ0J6ZEc5eVlXZGxDaUFnSUNBdkx5QWpJRVp2Y2lCa1pXMXZJSEIxY25CdmMyVnpMQ0IzWlNkeVpTQnFkWE4wSUdsdVkzSmxiV1Z1ZEdsdVp5QjBhR1VnWTI5MWJuUmxjZ29nSUNBZ0x5OGdjMlZzWmk1MGIzUmhiRjl3Y205a2RXTjBjeTUyWVd4MVpTQTlJSE5sYkdZdWRHOTBZV3hmY0hKdlpIVmpkSE11ZG1Gc2RXVWdLeUJWU1c1ME5qUW9NU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjBiM1JoYkY5d2NtOWtkV04wY3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5d2NtOWtkV04wY3lCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKMGIzUmhiRjl3Y205a2RXTjBjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiblYwY21sZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOek1LSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGxOMGNtbHVaeWdpVUhKdlpIVmpkQ0JoWkdSbFpDQnpkV05qWlhOelpuVnNiSGtoSWlrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01XSTFNRGN5Tm1ZMk5EYzFOak0zTkRJd05qRTJORFkwTmpVMk5ESXdOek0zTlRZek5qTTJOVGN6TnpNMk5qYzFObU0yWXpjNU1qRUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1dWRYUnlhVjlqYjI1MGNtRmpkQzVqYjI1MGNtRmpkQzVPZFhSeWFVZHlZV1JsVTJsdGNHeGxMbk5qWVc1ZmNISnZaSFZqZENod2NtOWtkV04wWDJsa09pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNuTmpZVzVmY0hKdlpIVmpkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVkWFJ5YVY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzNOUzAzT1FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNBdkx5QmtaV1lnYzJOaGJsOXdjbTlrZFdOMEtBb2dJQ0FnTHk4Z0lDQWdJSE5sYkdZc0NpQWdJQ0F2THlBZ0lDQWdjSEp2WkhWamRGOXBaRG9nWVhKak5DNVRkSEpwYm1jc0NpQWdJQ0F2THlBcElDMCtJR0Z5WXpRdVUzUnlhVzVuT2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJuVjBjbWxmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk9USUtJQ0FnSUM4dklGUjRiaTV6Wlc1a1pYSXNJRzl3TGtkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJsa0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dWRYUnlhVjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvNU1DMDVNd29nSUNBZ0x5OGdJeUJQY0hRdGFXNGdZMmhsWTJzZ1ptOXlJR3h2WTJGc0lITjBZWFJsQ2lBZ0lDQXZMeUJoYzNObGNuUWdiM0F1WVhCd1gyOXdkR1ZrWDJsdUtBb2dJQ0FnTHk4Z0lDQWdJRlI0Ymk1elpXNWtaWElzSUc5d0xrZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgybGtDaUFnSUNBdkx5QXBMQ0FpVUd4bFlYTmxJRzl3ZEMxcGJpQm1hWEp6ZENJS0lDQWdJR0Z3Y0Y5dmNIUmxaRjlwYmdvZ0lDQWdZWE56WlhKMElDOHZJRkJzWldGelpTQnZjSFF0YVc0Z1ptbHljM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVkWFJ5YVY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzVOUzA1TmdvZ0lDQWdMeThnSXlCVmNHUmhkR1VnWjJ4dlltRnNJSE5qWVc0Z1kyOTFiblFLSUNBZ0lDOHZJSE5sYkdZdWRHOTBZV3hmYzJOaGJuTXVkbUZzZFdVZ1BTQnpaV3htTG5SdmRHRnNYM05qWVc1ekxuWmhiSFZsSUNzZ1ZVbHVkRFkwS0RFcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk15QXZMeUFpZEc5MFlXeGZjMk5oYm5NaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkRzkwWVd4ZmMyTmhibk1nWlhocGMzUnpDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZbmwwWldOZk15QXZMeUFpZEc5MFlXeGZjMk5oYm5NaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1MWRISnBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2prNExUazVDaUFnSUNBdkx5QWpJRlZ3WkdGMFpTQjFjMlZ5SjNNZ2JHOWpZV3dnYzNSaGRHVUtJQ0FnSUM4dklITmxiR1l1ZFhObGNsOXpZMkZ1WDJOdmRXNTBXMVI0Ymk1elpXNWtaWEpkSUQwZ2MyVnNaaTUxYzJWeVgzTmpZVzVmWTI5MWJuUmJWSGh1TG5ObGJtUmxjbDBnS3lCVlNXNTBOalFvTVNrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSjFjMlZ5WDNOallXNWZZMjkxYm5RaUNpQWdJQ0JoY0hCZmJHOWpZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTFjMlZ5WDNOallXNWZZMjkxYm5RZ1pYaHBjM1J6SUdadmNpQmhZMk52ZFc1MENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaWRYTmxjbDl6WTJGdVgyTnZkVzUwSWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJuVjBjbWxmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1UQXdDaUFnSUNBdkx5QnpaV3htTG14aGMzUmZjMk5oYm01bFpGOXdjbTlrZFdOMFcxUjRiaTV6Wlc1a1pYSmRJRDBnY0hKdlpIVmpkRjlwWkM1dVlYUnBkbVVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR0o1ZEdWaklEVWdMeThnSW14aGMzUmZjMk5oYm01bFpGOXdjbTlrZFdOMElnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiblYwY21sZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNVEF5Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1VGRISnBibWNvSWxCeWIyUjFZM1FnYzJOaGJtNWxaQ0J6ZFdOalpYTnpablZzYkhraElpa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNV1ExTURjeU5tWTJORGMxTmpNM05ESXdOek0yTXpZeE5tVTJaVFkxTmpReU1EY3pOelUyTXpZek5qVTNNemN6TmpZM05UWmpObU0zT1RJeENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Ym5WMGNtbGZZMjl1ZEhKaFkzUXVZMjl1ZEhKaFkzUXVUblYwY21sSGNtRmtaVk5wYlhCc1pTNW5aWFJmYzNSaGRITW9LU0F0UGlCaWVYUmxjem9LWjJWMFgzTjBZWFJ6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjUxZEhKcFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakV4TkFvZ0lDQWdMeThnWVhKak5DNVZTVzUwTmpRb2MyVnNaaTUwYjNSaGJGOXdjbTlrZFdOMGN5NTJZV3gxWlNrc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpZEc5MFlXeGZjSEp2WkhWamRITWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEc5MFlXeGZjSEp2WkhWamRITWdaWGhwYzNSekNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym5WMGNtbGZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TVRFMUNpQWdJQ0F2THlCaGNtTTBMbFZKYm5RMk5DaHpaV3htTG5SdmRHRnNYM05qWVc1ekxuWmhiSFZsS1N3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0owYjNSaGJGOXpZMkZ1Y3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5elkyRnVjeUJsZUdsemRITUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dWRYUnlhVjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveE1USXRNVEUzQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1VWRYQnNaU2dLSUNBZ0lDOHZJQ0FnSUNBb0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUdGeVl6UXVWVWx1ZERZMEtITmxiR1l1ZEc5MFlXeGZjSEp2WkhWamRITXVkbUZzZFdVcExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCaGNtTTBMbFZKYm5RMk5DaHpaV3htTG5SdmRHRnNYM05qWVc1ekxuWmhiSFZsS1N3S0lDQWdJQzh2SUNBZ0lDQXBDaUFnSUNBdkx5QXBDaUFnSUNCamIyNWpZWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXVkWFJ5YVY5amIyNTBjbUZqZEM1amIyNTBjbUZqZEM1T2RYUnlhVWR5WVdSbFUybHRjR3hsTG1kbGRGOTFjMlZ5WDNOMFlYUnpLQ2tnTFQ0Z1lubDBaWE02Q21kbGRGOTFjMlZ5WDNOMFlYUnpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNTFkSEpwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qRXlOeTB4TWpnS0lDQWdJQzh2SUNNZ1EyaGxZMnNnYVdZZ2RYTmxjaUJvWVhNZ2IzQjBaV1FnYVc0S0lDQWdJQzh2SUdsbUlHNXZkQ0J2Y0M1aGNIQmZiM0IwWldSZmFXNG9WSGh1TG5ObGJtUmxjaXdnYjNBdVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZmFXUXBPZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjSEJmYjNCMFpXUmZhVzRLSUNBZ0lHSnVlaUJuWlhSZmRYTmxjbDl6ZEdGMGMxOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1ZFhSeWFWOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG94TWprdE1UTTBDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpOQzVVZFhCc1pTZ0tJQ0FnSUM4dklDQWdJQ0FvQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJR0Z5WXpRdVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCaGNtTTBMbE4wY21sdVp5Z2lUbThnYzJOaGJuTWdlV1YwSWlrc0NpQWdJQ0F2THlBZ0lDQWdLUW9nSUNBZ0x5OGdLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNR0V3TURCak5HVTJaakl3TnpNMk16WXhObVUzTXpJd056azJOVGMwQ2lBZ0lDQnlaWFJ6ZFdJS0NtZGxkRjkxYzJWeVgzTjBZWFJ6WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVkWFJ5YVY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3hNemdLSUNBZ0lDOHZJR0Z5WXpRdVZVbHVkRFkwS0hObGJHWXVkWE5sY2w5elkyRnVYMk52ZFc1MFcxUjRiaTV6Wlc1a1pYSmRLU3dLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKMWMyVnlYM05qWVc1ZlkyOTFiblFpQ2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MWMyVnlYM05qWVc1ZlkyOTFiblFnWlhocGMzUnpJR1p2Y2lCaFkyTnZkVzUwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiblYwY21sZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNVE01Q2lBZ0lDQXZMeUJoY21NMExsTjBjbWx1WnloelpXeG1MbXhoYzNSZmMyTmhibTVsWkY5d2NtOWtkV04wVzFSNGJpNXpaVzVrWlhKZEtTd0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0pzWVhOMFgzTmpZVzV1WldSZmNISnZaSFZqZENJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxteGhjM1JmYzJOaGJtNWxaRjl3Y205a2RXTjBJR1Y0YVhOMGN5Qm1iM0lnWVdOamIzVnVkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dWRYUnlhVjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveE16WXRNVFF4Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1VWRYQnNaU2dLSUNBZ0lDOHZJQ0FnSUNBb0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUdGeVl6UXVWVWx1ZERZMEtITmxiR1l1ZFhObGNsOXpZMkZ1WDJOdmRXNTBXMVI0Ymk1elpXNWtaWEpkS1N3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnWVhKak5DNVRkSEpwYm1jb2MyVnNaaTVzWVhOMFgzTmpZVzV1WldSZmNISnZaSFZqZEZ0VWVHNHVjMlZ1WkdWeVhTa3NDaUFnSUNBdkx5QWdJQ0FnS1FvZ0lDQWdMeThnS1FvZ0lDQWdjM2RoY0FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd1lRb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXVkWFJ5YVY5amIyNTBjbUZqZEM1amIyNTBjbUZqZEM1T2RYUnlhVWR5WVdSbFUybHRjR3hsTG05d2RGOXBiaWdwSUMwK0lHSjVkR1Z6T2dwdmNIUmZhVzQ2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiblYwY21sZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNVFV5TFRFMU13b2dJQ0FnTHk4Z0l5QkpibWwwYVdGc2FYcGxJSFZ6WlhJbmN5QnNiMk5oYkNCemRHRjBaUW9nSUNBZ0x5OGdjMlZzWmk1MWMyVnlYM05qWVc1ZlkyOTFiblJiVkhodUxuTmxibVJsY2wwZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR0o1ZEdWaklEUWdMeThnSW5WelpYSmZjMk5oYmw5amIzVnVkQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJuVjBjbWxmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1UVTBDaUFnSUNBdkx5QnpaV3htTG14aGMzUmZjMk5oYm01bFpGOXdjbTlrZFdOMFcxUjRiaTV6Wlc1a1pYSmRJRDBnVTNSeWFXNW5LQ0lpS1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lubDBaV01nTlNBdkx5QWliR0Z6ZEY5elkyRnVibVZrWDNCeWIyUjFZM1FpQ2lBZ0lDQndkWE5vWW5sMFpYTWdJaUlLSUNBZ0lHRndjRjlzYjJOaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVkWFJ5YVY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3hOVFlLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGxOMGNtbHVaeWdpVjJWc1kyOXRaU0IwYnlCT2RYUnlhVWR5WVdSbElTQlpiM1VnWTJGdUlHNXZkeUJ6WTJGdUlIQnliMlIxWTNSekxpSXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNRE14TlRjMk5UWmpOak0yWmpaa05qVXlNRGMwTm1ZeU1EUmxOelUzTkRjeU5qazBOemN5TmpFMk5EWTFNakV5TURVNU5tWTNOVEl3TmpNMk1UWmxNakEyWlRabU56Y3lNRGN6TmpNMk1UWmxNakEzTURjeU5tWTJORGMxTmpNM05EY3pNbVVLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXVkWFJ5YVY5amIyNTBjbUZqZEM1amIyNTBjbUZqZEM1T2RYUnlhVWR5WVdSbFUybHRjR3hsTG5Wd1pHRjBaVjl3Y205a2RXTjBLSEJ5YjJSMVkzUmZhV1E2SUdKNWRHVnpMQ0J1WVcxbE9pQmllWFJsY3l3Z2FXNW5jbVZrYVdWdWRITTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tkWEJrWVhSbFgzQnliMlIxWTNRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym5WMGNtbGZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TVRZNUxURTNOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0F2THlCa1pXWWdkWEJrWVhSbFgzQnliMlIxWTNRb0NpQWdJQ0F2THlBZ0lDQWdjMlZzWml3S0lDQWdJQzh2SUNBZ0lDQndjbTlrZFdOMFgybGtPaUJoY21NMExsTjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQnVZVzFsT2lCaGNtTTBMbE4wY21sdVp5d0tJQ0FnSUM4dklDQWdJQ0JwYm1keVpXUnBaVzUwY3pvZ1lYSmpOQzVUZEhKcGJtY3NDaUFnSUNBdkx5QXBJQzArSUdGeVl6UXVVM1J5YVc1bk9nb2dJQ0FnY0hKdmRHOGdNeUF4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiblYwY21sZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNVGc0TFRFNE9Rb2dJQ0FnTHk4Z0l5QlBibXg1SUc5M2JtVnlJR05oYmlCMWNHUmhkR1VLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlJRDA5SUhObGJHWXViM2R1WlhJdWRtRnNkV1VzSUNKUGJteDVJRzkzYm1WeUlHTmhiaUIxY0dSaGRHVWdjSEp2WkhWamRITWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpYjNkdVpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YjNkdVpYSWdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ2IzZHVaWElnWTJGdUlIVndaR0YwWlNCd2NtOWtkV04wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjUxZEhKcFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakU1TVFvZ0lDQWdMeThnY21WMGRYSnVJR0Z5WXpRdVUzUnlhVzVuS0NKUWNtOWtkV04wSUhWd1pHRjBaV1FnYzNWalkyVnpjMloxYkd4NUlTSXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREZrTlRBM01qWm1OalEzTlRZek56UXlNRGMxTnpBMk5EWXhOelEyTlRZME1qQTNNemMxTmpNMk16WTFOek0zTXpZMk56VTJZelpqTnpreU1Rb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG01MWRISnBYMk52Ym5SeVlXTjBMbU52Ym5SeVlXTjBMazUxZEhKcFIzSmhaR1ZUYVcxd2JHVXVaMlYwWDI5M2JtVnlLQ2tnTFQ0Z1lubDBaWE02Q21kbGRGOXZkMjVsY2pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1ZFhSeWFWOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG95TURFS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExrRmtaSEpsYzNNb2MyVnNaaTV2ZDI1bGNpNTJZV3gxWlNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0p2ZDI1bGNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV2ZDI1bGNpQmxlR2x6ZEhNS0lDQWdJSEpsZEhOMVlnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBQ0FBRW1CZ1FWSDN4MURuUnZkR0ZzWDNCeWIyUjFZM1J6Qlc5M2JtVnlDM1J2ZEdGc1gzTmpZVzV6RDNWelpYSmZjMk5oYmw5amIzVnVkQlJzWVhOMFgzTmpZVzV1WldSZmNISnZaSFZqZERFWVFBQUtLakVBWnlraVp5c2laekViUVFGQmdnb0VWRGtaUmdUeDVoYVJCRHJ6VXBRRTVuMnZVUVF5NDZLdEJCSWlPUElFYVlUdW1BUWNmVmxsQlA4cnBjVUVMN3BhR3pZYUFJNEtBT1FBeXdDNEFLZ0FtQUNJQUZVQVBBQXNBQUlpUXpFWkZFUXhHRVNBSGhVZmZIVUFHRTUxZEhKcFIzSmhaR1VnVTJsdGNHeGxJSFl4TGpBdU1MQWpRekVaRkVReEdFU0lBbElvVEZDd0kwTXhHUlJFTVJoRU5ob0JOaG9DTmhvRGlBSU1LRXhRc0NORE1SbUJBaEpFTVJoRWdDVVZIM3gxQUI5VWFHRnVheUI1YjNVZ1ptOXlJSFZ6YVc1bklFNTFkSEpwUjNKaFpHVWhzQ05ETVJrVVJERVlSSWdCaGloTVVMQWpRekVaRkVReEdFU0lBVE1vVEZDd0kwTXhHUlJFTVJoRWlBRVhLRXhRc0NORE1Sa1VSREVZUkRZYUFZZ0F0Q2hNVUxBalF6RVpGRVF4R0VRMkdnRTJHZ0kyR2dPSUFHY29URkN3STBNeEdSUkVNUmhFaUFBUktFeFFzQ05ETVJsQS93Y3hHQlJFSTBNeEFDSXFaVVFTUkNJcFpVUVVSQ2tpWnlzaVo0QXZBQzFPZFhSeWFVZHlZV1JsSUVOdmJuUnlZV04wSUVsdWFYUnBZV3hwZW1Wa0lGTjFZMk5sYzNObWRXeHNlU0dKaWdNQk1RQWlLbVZFRWtRaUtXVkVJd2dwVEdlQUhRQWJVSEp2WkhWamRDQmhaR1JsWkNCemRXTmpaWE56Wm5Wc2JIa2hpWW9CQVRFQU1naGhSQ0lyWlVRakNDdE1aekVBSWljRVkwUWpDREVBSndSUEFtYUwvMWNDQURFQUp3VlBBbWFBSHdBZFVISnZaSFZqZENCelkyRnVibVZrSUhOMVkyTmxjM05tZFd4c2VTR0pJaWxsUkJZaUsyVkVGbENKTVFBeUNHRkFBQnVBR0FBQUFBQUFBQUFBQUFvQURFNXZJSE5qWVc1eklIbGxkSWt4QUNJbkJHTkVGakVBSWljRlkwUkpGUlpYQmdKTVVFeUFBZ0FLVUV4UWlURUFKd1FpWmpFQUp3V0FBR2FBTXdBeFYyVnNZMjl0WlNCMGJ5Qk9kWFJ5YVVkeVlXUmxJU0JaYjNVZ1kyRnVJRzV2ZHlCelkyRnVJSEJ5YjJSMVkzUnpMb21LQXdFeEFDSXFaVVFTUklBZkFCMVFjbTlrZFdOMElIVndaR0YwWldRZ2MzVmpZMlZ6YzJaMWJHeDVJWWtpS21WRWlRPT0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjoxMCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
