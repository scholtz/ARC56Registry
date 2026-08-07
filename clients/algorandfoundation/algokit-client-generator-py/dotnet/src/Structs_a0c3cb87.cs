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

namespace Arc56.Generated.algorandfoundation.algokit_client_generator_py.Structs_a0c3cb87
{


    public class StructsProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public StructsProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class NestedStruct : AVMObjectType
            {
                public Structs.Vector Content { get; set; } = new Structs.Vector();

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    stringRef[ret.Count] = Content.ToByteArray();
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

                public static NestedStruct Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new NestedStruct();
                    var indexContent = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Content = Structs.Vector.Parse(bytes.Skip(indexContent + prefixOffset).ToArray());
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as NestedStruct);
                }
                public bool Equals(NestedStruct? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(NestedStruct left, NestedStruct right)
                {
                    return EqualityComparer<NestedStruct>.Default.Equals(left, right);
                }
                public static bool operator !=(NestedStruct left, NestedStruct right)
                {
                    return !(left == right);
                }

            }

            public class RootStruct : AVMObjectType
            {
                public Structs.NestedStruct Nested { get; set; } = new Structs.NestedStruct();

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    stringRef[ret.Count] = Nested.ToByteArray();
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

                public static RootStruct Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new RootStruct();
                    var indexNested = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Nested = Structs.NestedStruct.Parse(bytes.Skip(indexNested + prefixOffset).ToArray());
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as RootStruct);
                }
                public bool Equals(RootStruct? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(RootStruct left, RootStruct right)
                {
                    return EqualityComparer<RootStruct>.Default.Equals(left, right);
                }
                public static bool operator !=(RootStruct left, RootStruct right)
                {
                    return !(left == right);
                }

            }

            public class StructWithNameVariations : AVMObjectType
            {
                public string FirstVariatIon { get; set; }

                public string SecondVariation { get; set; }

                public string ThirdVariation { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFirstVariatIon = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vFirstVariatIon.From(FirstVariatIon);
                    stringRef[ret.Count] = vFirstVariatIon.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSecondVariation = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vSecondVariation.From(SecondVariation);
                    stringRef[ret.Count] = vSecondVariation.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vThirdVariation = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vThirdVariation.From(ThirdVariation);
                    stringRef[ret.Count] = vThirdVariation.Encode();
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

                public static StructWithNameVariations Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new StructWithNameVariations();
                    var indexFirstVariatIon = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFirstVariatIon = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vFirstVariatIon.Decode(bytes.Skip(indexFirstVariatIon + prefixOffset).ToArray());
                    var valueFirstVariatIon = vFirstVariatIon.ToValue();
                    if (valueFirstVariatIon is string vFirstVariatIonValue) { ret.FirstVariatIon = vFirstVariatIonValue; }
                    var indexSecondVariation = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSecondVariation = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vSecondVariation.Decode(bytes.Skip(indexSecondVariation + prefixOffset).ToArray());
                    var valueSecondVariation = vSecondVariation.ToValue();
                    if (valueSecondVariation is string vSecondVariationValue) { ret.SecondVariation = vSecondVariationValue; }
                    var indexThirdVariation = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vThirdVariation = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vThirdVariation.Decode(bytes.Skip(indexThirdVariation + prefixOffset).ToArray());
                    var valueThirdVariation = vThirdVariation.ToValue();
                    if (valueThirdVariation is string vThirdVariationValue) { ret.ThirdVariation = vThirdVariationValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as StructWithNameVariations);
                }
                public bool Equals(StructWithNameVariations? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(StructWithNameVariations left, StructWithNameVariations right)
                {
                    return EqualityComparer<StructWithNameVariations>.Default.Equals(left, right);
                }
                public static bool operator !=(StructWithNameVariations left, StructWithNameVariations right)
                {
                    return !(left == right);
                }

            }

            public class Vector : AVMObjectType
            {
                public string X { get; set; }

                public string Y { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vX = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vX.From(X);
                    stringRef[ret.Count] = vX.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vY = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vY.From(Y);
                    stringRef[ret.Count] = vY.Encode();
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

                public static Vector Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new Vector();
                    var indexX = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vX = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vX.Decode(bytes.Skip(indexX + prefixOffset).ToArray());
                    var valueX = vX.ToValue();
                    if (valueX is string vXValue) { ret.X = vXValue; }
                    var indexY = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vY = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vY.Decode(bytes.Skip(indexY + prefixOffset).ToArray());
                    var valueY = vY.ToValue();
                    if (valueY is string vYValue) { ret.Y = vYValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Vector);
                }
                public bool Equals(Vector? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Vector left, Vector right)
                {
                    return EqualityComparer<Vector>.Default.Equals(left, right);
                }
                public static bool operator !=(Vector left, Vector right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="name"> </param>
        public async Task<string> Hello(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 190, 206, 17 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Hello_Transactions(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 190, 206, 17 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.RootStruct> GiveMeRootStruct(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 164, 163, 206, 154 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.RootStruct.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GiveMeRootStruct_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 164, 163, 206, 154 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.StructWithNameVariations> GiveMeStructWithNameVariations(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 32, 118, 33 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.StructWithNameVariations.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GiveMeStructWithNameVariations_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 32, 118, 33 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3RydWN0cyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJOZXN0ZWRTdHJ1Y3QiOlt7Im5hbWUiOiJjb250ZW50IiwidHlwZSI6IlZlY3RvciJ9XSwiUm9vdFN0cnVjdCI6W3sibmFtZSI6Im5lc3RlZCIsInR5cGUiOiJOZXN0ZWRTdHJ1Y3QifV0sIlN0cnVjdF9XaXRoTmFtZVZhcmlhdGlvbnMiOlt7Im5hbWUiOiJmaXJzdF9WYXJpYXRJb24iLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoic2Vjb25kVmFyaWF0aW9uIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6InRoaXJkX3ZhcmlhdGlvbiIsInR5cGUiOiJzdHJpbmcifV0sIlZlY3RvciI6W3sibmFtZSI6IngiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoieSIsInR5cGUiOiJzdHJpbmcifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiaGVsbG8iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdpdmVfbWVfcm9vdF9zdHJ1Y3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKCgoc3RyaW5nLHN0cmluZykpKSIsInN0cnVjdCI6IlJvb3RTdHJ1Y3QiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnaXZlX21lX3N0cnVjdF93aXRoX25hbWVfdmFyaWF0aW9ucyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIoc3RyaW5nLHN0cmluZyxzdHJpbmcpIiwic3RydWN0IjoiU3RydWN0X1dpdGhOYW1lVmFyaWF0aW9ucyIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im9wdF9pbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk9wdEluIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjozfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjJ9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyMjEsMjUyLDI4Ml0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwOV0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgT3B0SW4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMTFdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTIsMjI0LDI1NSwyODVdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJsZUdGdGNHeGxjeTV6YldGeWRGOWpiMjUwY21GamRITXVjM1J5ZFdOMGN5NWpiMjUwY21GamRDNVRkSEoxWTNSekxsOWZZV3huYjNCNVgyVnVkSEo1Y0c5cGJuUmZkMmwwYUY5cGJtbDBLQ2tnTFQ0Z2RXbHVkRFkwT2dwdFlXbHVPZ29nSUNBZ2FXNTBZMkpzYjJOcklERUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ01IZ3dNREEwTURBd056QXdNREV6TVRBd01ERXpNaUF3ZURBd01ESXdNREF5TURBd05EQXdNRGN3TURBeE16RXdNREF4TXpJZ0ltMTVYMkp2ZUY5emRISjFZM1FpSUNKdGVWOXVaWE4wWldSZlltOTRYM04wY25WamRDSWdNSGcyWkRjNU5XWTJNalptTnpnMlpEWXhOekExWmpjek56UTNNamMxTmpNM05EQXdNREF3TURBd01EQXdNREF3TjJJZ01IZzJaRGM1TldZMlpUWTFOek0zTkRZMU5qUTFaall5Tm1ZM09EWmtOakUzTURWbU56TTNORGN5TnpVMk16YzBNREF3TURBd01EQXdNREF3TURBM1lnb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wY25WamRITXZZMjl1ZEhKaFkzUXVjSGs2TWpjS0lDQWdJQzh2SUhObGJHWXViWGxmYzNSeWRXTjBJRDBnUjJ4dlltRnNVM1JoZEdVb1ZtVmpkRzl5S0hnOVlYSmpOQzVUZEhKcGJtY29JakVpS1N3Z2VUMWhjbU0wTGxOMGNtbHVaeWdpTWlJcEtTa0tJQ0FnSUhCMWMyaGllWFJsY3lBaWJYbGZjM1J5ZFdOMElnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXdNRFF3TURBM01EQXdNVE14TURBd01UTXlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBjblZqZEhNdlkyOXVkSEpoWTNRdWNIazZNamdLSUNBZ0lDOHZJSE5sYkdZdWJYbGZibVZ6ZEdWa1gzTjBjblZqZENBOUlFZHNiMkpoYkZOMFlYUmxLQW9nSUNBZ2NIVnphR0o1ZEdWeklDSnRlVjl1WlhOMFpXUmZjM1J5ZFdOMElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMGNuVmpkSE12WTI5dWRISmhZM1F1Y0hrNk1qa0tJQ0FnSUM4dklGSnZiM1JUZEhKMVkzUW9ibVZ6ZEdWa1BVNWxjM1JsWkZOMGNuVmpkQ2hqYjI1MFpXNTBQVlpsWTNSdmNpaDRQV0Z5WXpRdVUzUnlhVzVuS0NJeElpa3NJSGs5WVhKak5DNVRkSEpwYm1jb0lqSWlLU2twS1FvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBd01ESXdNREF5TURBd05EQXdNRGN3TURBeE16RXdNREF4TXpJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEhKMVkzUnpMMk52Ym5SeVlXTjBMbkI1T2pJNExUTXdDaUFnSUNBdkx5QnpaV3htTG0xNVgyNWxjM1JsWkY5emRISjFZM1FnUFNCSGJHOWlZV3hUZEdGMFpTZ0tJQ0FnSUM4dklDQWdJQ0JTYjI5MFUzUnlkV04wS0c1bGMzUmxaRDFPWlhOMFpXUlRkSEoxWTNRb1kyOXVkR1Z1ZEQxV1pXTjBiM0lvZUQxaGNtTTBMbE4wY21sdVp5Z2lNU0lwTENCNVBXRnlZelF1VTNSeWFXNW5LQ0l5SWlrcEtTa0tJQ0FnSUM4dklDa0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEhKMVkzUnpMMk52Ym5SeVlXTjBMbkI1T2pJMUNpQWdJQ0F2THlCamJHRnpjeUJUZEhKMVkzUnpLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlpWVhKbFgzSnZkWFJwYm1kQU9Rb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VEQXlZbVZqWlRFeElEQjRZVFJoTTJObE9XRWdNSGhoWXpJd056WXlNU0F3ZURNd1l6WmtOVGhoSUM4dklHMWxkR2h2WkNBaWFHVnNiRzhvYzNSeWFXNW5LWE4wY21sdVp5SXNJRzFsZEdodlpDQWlaMmwyWlY5dFpWOXliMjkwWDNOMGNuVmpkQ2dwS0Nnb2MzUnlhVzVuTEhOMGNtbHVaeWtwS1NJc0lHMWxkR2h2WkNBaVoybDJaVjl0WlY5emRISjFZM1JmZDJsMGFGOXVZVzFsWDNaaGNtbGhkR2x2Ym5Nb0tTaHpkSEpwYm1jc2MzUnlhVzVuTEhOMGNtbHVaeWtpTENCdFpYUm9iMlFnSW05d2RGOXBiaWdwZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZmFHVnNiRzlmY205MWRHVkFOU0J0WVdsdVgyZHBkbVZmYldWZmNtOXZkRjl6ZEhKMVkzUmZjbTkxZEdWQU5pQnRZV2x1WDJkcGRtVmZiV1ZmYzNSeWRXTjBYM2RwZEdoZmJtRnRaVjkyWVhKcFlYUnBiMjV6WDNKdmRYUmxRRGNnYldGcGJsOXZjSFJmYVc1ZmNtOTFkR1ZBT0FvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERXhPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBjblZqZEhNdlkyOXVkSEpoWTNRdWNIazZNalVLSUNBZ0lDOHZJR05zWVhOeklGTjBjblZqZEhNb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIQjFjMmhwYm5RZ01DQXZMeUF3Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmYjNCMFgybHVYM0p2ZFhSbFFEZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUnlkV04wY3k5amIyNTBjbUZqZEM1d2VUbzFNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tHRnNiRzkzWDJGamRHbHZibk05V3lKUGNIUkpiaUpkS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHdJQzh2SUU5d2RFbHVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1QzQjBTVzRLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnWTJGc2JITjFZaUJ2Y0hSZmFXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloybDJaVjl0WlY5emRISjFZM1JmZDJsMGFGOXVZVzFsWDNaaGNtbGhkR2x2Ym5OZmNtOTFkR1ZBTnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEhKMVkzUnpMMk52Ym5SeVlXTjBMbkI1T2pRM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOVEF3TURZd01EQTVNREF3WXpBd01ERXpNVEF3TURFek1qQXdNREV6TXdvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRwZG1WZmJXVmZjbTl2ZEY5emRISjFZM1JmY205MWRHVkFOam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkSEoxWTNSekwyTnZiblJ5WVdOMExuQjVPalF6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05UQXdNREl3TURBeU1EQXdOREF3TURjd01EQXhNekV3TURBeE16SUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5b1pXeHNiMTl5YjNWMFpVQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBjblZqZEhNdlkyOXVkSEpoWTNRdWNIazZNemtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRISjFZM1J6TDJOdmJuUnlZV04wTG5CNU9qSTFDaUFnSUNBdkx5QmpiR0Z6Y3lCVGRISjFZM1J6S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUnlkV04wY3k5amIyNTBjbUZqZEM1d2VUb3pPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnYUdWc2JHOEtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aVlYSmxYM0p2ZFhScGJtZEFPVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkSEoxWTNSekwyTnZiblJ5WVdOMExuQjVPakkxQ2lBZ0lDQXZMeUJqYkdGemN5QlRkSEoxWTNSektFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERXhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQmpjbVZoZEdsdVp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdWNFlXMXdiR1Z6TG5OdFlYSjBYMk52Ym5SeVlXTjBjeTV6ZEhKMVkzUnpMbU52Ym5SeVlXTjBMbE4wY25WamRITXVhR1ZzYkc4b2JtRnRaVG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BvWld4c2J6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRISjFZM1J6TDJOdmJuUnlZV04wTG5CNU9qTTVMVFF3Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ0x5OGdaR1ZtSUdobGJHeHZLSE5sYkdZc0lHNWhiV1U2SUdGeVl6UXVVM1J5YVc1bktTQXRQaUJoY21NMExsTjBjbWx1WnpvS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBjblZqZEhNdlkyOXVkSEpoWTNRdWNIazZOREVLSUNBZ0lDOHZJSEpsZEhWeWJpQWlTR1ZzYkc4c0lDSWdLeUJ1WVcxbENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcwT0RZMU5tTTJZelptTW1NeU1Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z1pYaGhiWEJzWlhNdWMyMWhjblJmWTI5dWRISmhZM1J6TG5OMGNuVmpkSE11WTI5dWRISmhZM1F1VTNSeWRXTjBjeTV2Y0hSZmFXNG9LU0F0UGlCMmIybGtPZ3B2Y0hSZmFXNDZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUnlkV04wY3k5amIyNTBjbUZqZEM1d2VUbzFOUW9nSUNBZ0x5OGdjMlZzWmk1dGVWOWliM2hmYzNSeWRXTjBMblpoYkhWbElEMGdWbVZqZEc5eUtIZzlZWEpqTkM1VGRISnBibWNvSWpFaUtTd2dlVDFoY21NMExsTjBjbWx1WnlnaU1pSXBLUW9nSUNBZ1lubDBaV05mTWlBdkx5QWliWGxmWW05NFgzTjBjblZqZENJS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWJYbGZZbTk0WDNOMGNuVmpkQ0lLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TURBME1EQXdOekF3TURFek1UQXdNREV6TWdvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMGNuVmpkSE12WTI5dWRISmhZM1F1Y0hrNk5UWUtJQ0FnSUM4dklITmxiR1l1YlhsZmJtVnpkR1ZrWDJKdmVGOXpkSEoxWTNRdWRtRnNkV1VnUFNCU2IyOTBVM1J5ZFdOMEtBb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWJYbGZibVZ6ZEdWa1gySnZlRjl6ZEhKMVkzUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUnlkV04wY3k5amIyNTBjbUZqZEM1d2VUbzFOaTAxT0FvZ0lDQWdMeThnYzJWc1ppNXRlVjl1WlhOMFpXUmZZbTk0WDNOMGNuVmpkQzUyWVd4MVpTQTlJRkp2YjNSVGRISjFZM1FvQ2lBZ0lDQXZMeUFnSUNBZ2JtVnpkR1ZrUFU1bGMzUmxaRk4wY25WamRDaGpiMjUwWlc1MFBWWmxZM1J2Y2loNFBXRnlZelF1VTNSeWFXNW5LQ0l4SWlrc0lIazlZWEpqTkM1VGRISnBibWNvSWpJaUtTa3BDaUFnSUNBdkx5QXBDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkSEoxWTNSekwyTnZiblJ5WVdOMExuQjVPalUyQ2lBZ0lDQXZMeUJ6Wld4bUxtMTVYMjVsYzNSbFpGOWliM2hmYzNSeWRXTjBMblpoYkhWbElEMGdVbTl2ZEZOMGNuVmpkQ2dLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbTE1WDI1bGMzUmxaRjlpYjNoZmMzUnlkV04wSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wY25WamRITXZZMjl1ZEhKaFkzUXVjSGs2TlRZdE5UZ0tJQ0FnSUM4dklITmxiR1l1YlhsZmJtVnpkR1ZrWDJKdmVGOXpkSEoxWTNRdWRtRnNkV1VnUFNCU2IyOTBVM1J5ZFdOMEtBb2dJQ0FnTHk4Z0lDQWdJRzVsYzNSbFpEMU9aWE4wWldSVGRISjFZM1FvWTI5dWRHVnVkRDFXWldOMGIzSW9lRDFoY21NMExsTjBjbWx1WnlnaU1TSXBMQ0I1UFdGeVl6UXVVM1J5YVc1bktDSXlJaWtwS1FvZ0lDQWdMeThnS1FvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBd01ESXdNREF5TURBd05EQXdNRGN3TURBeE16RXdNREF4TXpJS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRISjFZM1J6TDJOdmJuUnlZV04wTG5CNU9qVTVDaUFnSUNBdkx5QnpaV3htTG0xNVgySnZlRzFoY0Y5emRISjFZM1JiWVhKak5DNVZTVzUwTmpRb01USXpLVjBnUFNCV1pXTjBiM0lvZUQxaGNtTTBMbE4wY21sdVp5Z2lNU0lwTENCNVBXRnlZelF1VTNSeWFXNW5LQ0l5SWlrcENpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE5tUTNPVFZtTmpJMlpqYzRObVEyTVRjd05XWTNNemMwTnpJM05UWXpOelF3TURBd01EQXdNREF3TURBd01EZGlDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGcyWkRjNU5XWTJNalptTnpnMlpEWXhOekExWmpjek56UTNNamMxTmpNM05EQXdNREF3TURBd01EQXdNREF3TjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01EQTBNREF3TnpBd01ERXpNVEF3TURFek1nb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBjblZqZEhNdlkyOXVkSEpoWTNRdWNIazZOakFLSUNBZ0lDOHZJSE5sYkdZdWJYbGZibVZ6ZEdWa1gySnZlRzFoY0Y5emRISjFZM1JiWVhKak5DNVZTVzUwTmpRb01USXpLVjBnUFNCU2IyOTBVM1J5ZFdOMEtBb2dJQ0FnWW5sMFpXTWdOU0F2THlBd2VEWmtOemsxWmpabE5qVTNNemMwTmpVMk5EVm1OakkyWmpjNE5tUTJNVGN3TldZM016YzBOekkzTlRZek56UXdNREF3TURBd01EQXdNREF3TURkaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSeWRXTjBjeTlqYjI1MGNtRmpkQzV3ZVRvMk1DMDJNZ29nSUNBZ0x5OGdjMlZzWmk1dGVWOXVaWE4wWldSZlltOTRiV0Z3WDNOMGNuVmpkRnRoY21NMExsVkpiblEyTkNneE1qTXBYU0E5SUZKdmIzUlRkSEoxWTNRb0NpQWdJQ0F2THlBZ0lDQWdibVZ6ZEdWa1BVNWxjM1JsWkZOMGNuVmpkQ2hqYjI1MFpXNTBQVlpsWTNSdmNpaDRQV0Z5WXpRdVUzUnlhVzVuS0NJeElpa3NJSGs5WVhKak5DNVRkSEpwYm1jb0lqSWlLU2twQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEhKMVkzUnpMMk52Ym5SeVlXTjBMbkI1T2pZd0NpQWdJQ0F2THlCelpXeG1MbTE1WDI1bGMzUmxaRjlpYjNodFlYQmZjM1J5ZFdOMFcyRnlZelF1VlVsdWREWTBLREV5TXlsZElEMGdVbTl2ZEZOMGNuVmpkQ2dLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGcyWkRjNU5XWTJaVFkxTnpNM05EWTFOalExWmpZeU5tWTNPRFprTmpFM01EVm1Oek0zTkRjeU56VTJNemMwTURBd01EQXdNREF3TURBd01EQTNZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBjblZqZEhNdlkyOXVkSEpoWTNRdWNIazZOakF0TmpJS0lDQWdJQzh2SUhObGJHWXViWGxmYm1WemRHVmtYMkp2ZUcxaGNGOXpkSEoxWTNSYllYSmpOQzVWU1c1ME5qUW9NVEl6S1YwZ1BTQlNiMjkwVTNSeWRXTjBLQW9nSUNBZ0x5OGdJQ0FnSUc1bGMzUmxaRDFPWlhOMFpXUlRkSEoxWTNRb1kyOXVkR1Z1ZEQxV1pXTjBiM0lvZUQxaGNtTTBMbE4wY21sdVp5Z2lNU0lwTENCNVBXRnlZelF1VTNSeWFXNW5LQ0l5SWlrcEtRb2dJQ0FnTHk4Z0tRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXdNREl3TURBeU1EQXdOREF3TURjd01EQXhNekV3TURBeE16SUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkSEoxWTNSekwyTnZiblJ5WVdOMExuQjVPall6Q2lBZ0lDQXZMeUJ6Wld4bUxtMTVYMnh2WTJGc2MzUmhkR1ZmYzNSeWRXTjBXMVI0Ymk1elpXNWtaWEpkSUQwZ1ZtVmpkRzl5S0hnOVlYSmpOQzVUZEhKcGJtY29JakVpS1N3Z2VUMWhjbU0wTGxOMGNtbHVaeWdpTWlJcEtRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0p0ZVY5c2IyTmhiSE4wWVhSbFgzTjBjblZqZENJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01EQTBNREF3TnpBd01ERXpNVEF3TURFek1nb2dJQ0FnWVhCd1gyeHZZMkZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMGNuVmpkSE12WTI5dWRISmhZM1F1Y0hrNk5qUUtJQ0FnSUM4dklITmxiR1l1YlhsZmJtVnpkR1ZrWDJ4dlkyRnNjM1JoZEdWZmMzUnlkV04wVzFSNGJpNXpaVzVrWlhKZElEMGdVbTl2ZEZOMGNuVmpkQ2dLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUhCMWMyaGllWFJsY3lBaWJYbGZibVZ6ZEdWa1gyeHZZMkZzYzNSaGRHVmZjM1J5ZFdOMElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMGNuVmpkSE12WTI5dWRISmhZM1F1Y0hrNk5qUXROallLSUNBZ0lDOHZJSE5sYkdZdWJYbGZibVZ6ZEdWa1gyeHZZMkZzYzNSaGRHVmZjM1J5ZFdOMFcxUjRiaTV6Wlc1a1pYSmRJRDBnVW05dmRGTjBjblZqZENnS0lDQWdJQzh2SUNBZ0lDQnVaWE4wWldROVRtVnpkR1ZrVTNSeWRXTjBLR052Ym5SbGJuUTlWbVZqZEc5eUtIZzlZWEpqTkM1VGRISnBibWNvSWpFaUtTd2dlVDFoY21NMExsTjBjbWx1WnlnaU1pSXBLU2tLSUNBZ0lDOHZJQ2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TURBeU1EQXdNakF3TURRd01EQTNNREF3TVRNeE1EQXdNVE15Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQnlaWFJ6ZFdJSyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFCQVNZR0NnQUVBQWNBQVRFQUFUSU9BQUlBQWdBRUFBY0FBVEVBQVRJTmJYbGZZbTk0WDNOMGNuVmpkQlJ0ZVY5dVpYTjBaV1JmWW05NFgzTjBjblZqZEJodGVWOWliM2h0WVhCZmMzUnlkV04wQUFBQUFBQUFBSHNmYlhsZmJtVnpkR1ZrWDJKdmVHMWhjRjl6ZEhKMVkzUUFBQUFBQUFBQWV6RVlRQUFoZ0FsdGVWOXpkSEoxWTNRb1o0QVFiWGxmYm1WemRHVmtYM04wY25WamRDbG5NUnRCQUlpQ0JBUUN2czRSQktTanpwb0VyQ0IySVFRd3h0V0tOaG9BamdRQVRRQXZBQkFBQTRFQVF6RVpJaEpFTVJoRWlBQitJa014R1JSRU1SaEVnQk1WSDN4MUFBWUFDUUFNQUFFeEFBRXlBQUV6c0NKRE1Sa1VSREVZUklBU0ZSOThkUUFDQUFJQUJBQUhBQUV4QUFFeXNDSkRNUmtVUkRFWVJEWWFBWWdBRm9BRUZSOThkVXhRc0NKRE1SbEEvNVl4R0JSRUlrT0tBUUdMLzFjQ0FJQUhTR1ZzYkc4c0lFeFFTUlVXVndZQ1RGQ0pLcnhJS2lpL0s3eElLeW0vSndTOFNDY0VLTDhuQmJ4SUp3VXB2ekVBZ0JSdGVWOXNiMk5oYkhOMFlYUmxYM04wY25WamRDaG1NUUNBRzIxNVgyNWxjM1JsWkY5c2IyTmhiSE4wWVhSbFgzTjBjblZqZENsbWlRPT0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo3LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
