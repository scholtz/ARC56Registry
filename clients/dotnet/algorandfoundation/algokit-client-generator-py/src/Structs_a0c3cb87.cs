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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3RydWN0cyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJOZXN0ZWRTdHJ1Y3QiOlt7Im5hbWUiOiJjb250ZW50IiwidHlwZSI6IlZlY3RvciJ9XSwiUm9vdFN0cnVjdCI6W3sibmFtZSI6Im5lc3RlZCIsInR5cGUiOiJOZXN0ZWRTdHJ1Y3QifV0sIlN0cnVjdF9XaXRoTmFtZVZhcmlhdGlvbnMiOlt7Im5hbWUiOiJmaXJzdF9WYXJpYXRJb24iLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoic2Vjb25kVmFyaWF0aW9uIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6InRoaXJkX3ZhcmlhdGlvbiIsInR5cGUiOiJzdHJpbmcifV0sIlZlY3RvciI6W3sibmFtZSI6IngiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoieSIsInR5cGUiOiJzdHJpbmcifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiaGVsbG8iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdpdmVfbWVfcm9vdF9zdHJ1Y3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKCgoc3RyaW5nLHN0cmluZykpKSIsInN0cnVjdCI6IlJvb3RTdHJ1Y3QiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnaXZlX21lX3N0cnVjdF93aXRoX25hbWVfdmFyaWF0aW9ucyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIoc3RyaW5nLHN0cmluZyxzdHJpbmcpIiwic3RydWN0IjoiU3RydWN0X1dpdGhOYW1lVmFyaWF0aW9ucyIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im9wdF9pbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk9wdEluIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjozfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjJ9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyODhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBeENpQWdJQ0JpZVhSbFkySnNiMk5ySURCNE1EQXdOREF3TURjd01EQXhNekV3TURBeE16SWdNSGd3TURBeU1EQXdNakF3TURRd01EQTNNREF3TVRNeE1EQXdNVE15SUNKdGVWOWliM2hmYzNSeWRXTjBJaUFpYlhsZmJtVnpkR1ZrWDJKdmVGOXpkSEoxWTNRaUlEQjRObVEzT1RWbU5qSTJaamM0Tm1RMk1UY3dOV1kzTXpjME56STNOVFl6TnpRd01EQXdNREF3TURBd01EQXdNRGRpSURCNE5tUTNPVFZtTm1VMk5UY3pOelEyTlRZME5XWTJNalptTnpnMlpEWXhOekExWmpjek56UTNNamMxTmpNM05EQXdNREF3TURBd01EQXdNREF3TjJJS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJR1Y0WVcxd2JHVnpMM050WVhKMFgyTnZiblJ5WVdOMGN5OXpkSEoxWTNSekwyTnZiblJ5WVdOMExuQjVPakkzQ2lBZ0lDQXZMeUJ6Wld4bUxtMTVYM04wY25WamRDQTlJRWRzYjJKaGJGTjBZWFJsS0ZabFkzUnZjaWg0UFdGeVl6UXVVM1J5YVc1bktDSXhJaWtzSUhrOVlYSmpOQzVUZEhKcGJtY29JaklpS1NrcENpQWdJQ0J3ZFhOb1lubDBaWE1nSW0xNVgzTjBjblZqZENJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01EQTBNREF3TnpBd01ERXpNVEF3TURFek1nb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHVjRZVzF3YkdWekwzTnRZWEowWDJOdmJuUnlZV04wY3k5emRISjFZM1J6TDJOdmJuUnlZV04wTG5CNU9qSTRDaUFnSUNBdkx5QnpaV3htTG0xNVgyNWxjM1JsWkY5emRISjFZM1FnUFNCSGJHOWlZV3hUZEdGMFpTZ0tJQ0FnSUhCMWMyaGllWFJsY3lBaWJYbGZibVZ6ZEdWa1gzTjBjblZqZENJS0lDQWdJQzh2SUdWNFlXMXdiR1Z6TDNOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEhKMVkzUnpMMk52Ym5SeVlXTjBMbkI1T2pJNUNpQWdJQ0F2THlCU2IyOTBVM1J5ZFdOMEtHNWxjM1JsWkQxT1pYTjBaV1JUZEhKMVkzUW9ZMjl1ZEdWdWREMVdaV04wYjNJb2VEMWhjbU0wTGxOMGNtbHVaeWdpTVNJcExDQjVQV0Z5WXpRdVUzUnlhVzVuS0NJeUlpa3BLU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TURBeU1EQXdNakF3TURRd01EQTNNREF3TVRNeE1EQXdNVE15Q2lBZ0lDQXZMeUJsZUdGdGNHeGxjeTl6YldGeWRGOWpiMjUwY21GamRITXZjM1J5ZFdOMGN5OWpiMjUwY21GamRDNXdlVG95T0Mwek1Bb2dJQ0FnTHk4Z2MyVnNaaTV0ZVY5dVpYTjBaV1JmYzNSeWRXTjBJRDBnUjJ4dlltRnNVM1JoZEdVb0NpQWdJQ0F2THlBZ0lDQWdVbTl2ZEZOMGNuVmpkQ2h1WlhOMFpXUTlUbVZ6ZEdWa1UzUnlkV04wS0dOdmJuUmxiblE5Vm1WamRHOXlLSGc5WVhKak5DNVRkSEpwYm1jb0lqRWlLU3dnZVQxaGNtTTBMbE4wY21sdVp5Z2lNaUlwS1NrcENpQWdJQ0F2THlBcENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJsZUdGdGNHeGxjeTl6YldGeWRGOWpiMjUwY21GamRITXZjM1J5ZFdOMGN5OWpiMjUwY21GamRDNXdlVG95TlFvZ0lDQWdMeThnWTJ4aGMzTWdVM1J5ZFdOMGN5aEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU1UUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VETXdZelprTlRoaElDOHZJRzFsZEdodlpDQWliM0IwWDJsdUtDbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JXRnBibDl2Y0hSZmFXNWZjbTkxZEdWQU5Rb0tiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURZNkNpQWdJQ0F2THlCbGVHRnRjR3hsY3k5emJXRnlkRjlqYjI1MGNtRmpkSE12YzNSeWRXTjBjeTlqYjI1MGNtRmpkQzV3ZVRveU5Rb2dJQ0FnTHk4Z1kyeGhjM01nVTNSeWRXTjBjeWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE1ESmlaV05sTVRFZ01IaGhOR0V6WTJVNVlTQXdlR0ZqTWpBM05qSXhJQzh2SUcxbGRHaHZaQ0FpYUdWc2JHOG9jM1J5YVc1bktYTjBjbWx1WnlJc0lHMWxkR2h2WkNBaVoybDJaVjl0WlY5eWIyOTBYM04wY25WamRDZ3BLQ2dvYzNSeWFXNW5MSE4wY21sdVp5a3BLU0lzSUcxbGRHaHZaQ0FpWjJsMlpWOXRaVjl6ZEhKMVkzUmZkMmwwYUY5dVlXMWxYM1poY21saGRHbHZibk1vS1NoemRISnBibWNzYzNSeWFXNW5MSE4wY21sdVp5a2lDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0JvWld4c2J5QnRZV2x1WDJkcGRtVmZiV1ZmY205dmRGOXpkSEoxWTNSZmNtOTFkR1ZBT1NCdFlXbHVYMmRwZG1WZmJXVmZjM1J5ZFdOMFgzZHBkR2hmYm1GdFpWOTJZWEpwWVhScGIyNXpYM0p2ZFhSbFFERXdDaUFnSUNCbGNuSUtDbTFoYVc1ZloybDJaVjl0WlY5emRISjFZM1JmZDJsMGFGOXVZVzFsWDNaaGNtbGhkR2x2Ym5OZmNtOTFkR1ZBTVRBNkNpQWdJQ0F2THlCbGVHRnRjR3hsY3k5emJXRnlkRjlqYjI1MGNtRmpkSE12YzNSeWRXTjBjeTlqYjI1MGNtRmpkQzV3ZVRvME53b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxTURBd05qQXdNRGt3TURCak1EQXdNVE14TURBd01UTXlNREF3TVRNekNpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWjJsMlpWOXRaVjl5YjI5MFgzTjBjblZqZEY5eWIzVjBaVUE1T2dvZ0lDQWdMeThnWlhoaGJYQnNaWE12YzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wY25WamRITXZZMjl1ZEhKaFkzUXVjSGs2TkRNS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOVEF3TURJd01EQXlNREF3TkRBd01EY3dNREF4TXpFd01EQXhNeklLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXZjSFJmYVc1ZmNtOTFkR1ZBTlRvS0lDQWdJQzh2SUdWNFlXMXdiR1Z6TDNOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEhKMVkzUnpMMk52Ym5SeVlXTjBMbkI1T2pVekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvWVd4c2IzZGZZV04wYVc5dWN6MWJJazl3ZEVsdUlsMHBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdUM0IwU1c0S0lDQWdJRDA5Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnWWlCdmNIUmZhVzRLQ20xaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU1UUTZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHVjRZVzF3YkdWekxuTnRZWEowWDJOdmJuUnlZV04wY3k1emRISjFZM1J6TG1OdmJuUnlZV04wTGxOMGNuVmpkSE11YUdWc2JHOWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BvWld4c2J6b0tJQ0FnSUM4dklHVjRZVzF3YkdWekwzTnRZWEowWDJOdmJuUnlZV04wY3k5emRISjFZM1J6TDJOdmJuUnlZV04wTG5CNU9qTTVDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNZ29nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUM4dklHVjRZVzF3YkdWekwzTnRZWEowWDJOdmJuUnlZV04wY3k5emRISjFZM1J6TDJOdmJuUnlZV04wTG5CNU9qUXhDaUFnSUNBdkx5QnlaWFIxY200Z0lraGxiR3h2TENBaUlDc2dibUZ0WlFvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIQjFjMmhwYm5RZ053b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01Bb2dJQ0FnTHk4Z1pYaGhiWEJzWlhNdmMyMWhjblJmWTI5dWRISmhZM1J6TDNOMGNuVmpkSE12WTI5dWRISmhZM1F1Y0hrNk5ERUtJQ0FnSUM4dklISmxkSFZ5YmlBaVNHVnNiRzhzSUNJZ0t5QnVZVzFsQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURBM05EZzJOVFpqTm1NMlpqSmpNakFLSUNBZ0lITjNZWEFLSUNBZ0lISmxjR3hoWTJVeUlEQUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdaWGhoYlhCc1pYTXZjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBjblZqZEhNdlkyOXVkSEpoWTNRdWNIazZNemtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCbGVHRnRjR3hsY3k1emJXRnlkRjlqYjI1MGNtRmpkSE11YzNSeWRXTjBjeTVqYjI1MGNtRmpkQzVUZEhKMVkzUnpMbTl3ZEY5cGJsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbTl3ZEY5cGJqb0tJQ0FnSUM4dklHVjRZVzF3YkdWekwzTnRZWEowWDJOdmJuUnlZV04wY3k5emRISjFZM1J6TDJOdmJuUnlZV04wTG5CNU9qVTFDaUFnSUNBdkx5QnpaV3htTG0xNVgySnZlRjl6ZEhKMVkzUXVkbUZzZFdVZ1BTQldaV04wYjNJb2VEMWhjbU0wTGxOMGNtbHVaeWdpTVNJcExDQjVQV0Z5WXpRdVUzUnlhVzVuS0NJeUlpa3BDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnRlVjlpYjNoZmMzUnlkV04wSWdvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKdGVWOWliM2hmYzNSeWRXTjBJZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF3TURRd01EQTNNREF3TVRNeE1EQXdNVE15Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCbGVHRnRjR3hsY3k5emJXRnlkRjlqYjI1MGNtRmpkSE12YzNSeWRXTjBjeTlqYjI1MGNtRmpkQzV3ZVRvMU5nb2dJQ0FnTHk4Z2MyVnNaaTV0ZVY5dVpYTjBaV1JmWW05NFgzTjBjblZqZEM1MllXeDFaU0E5SUZKdmIzUlRkSEoxWTNRb0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKdGVWOXVaWE4wWldSZlltOTRYM04wY25WamRDSUtJQ0FnSUM4dklHVjRZVzF3YkdWekwzTnRZWEowWDJOdmJuUnlZV04wY3k5emRISjFZM1J6TDJOdmJuUnlZV04wTG5CNU9qVTJMVFU0Q2lBZ0lDQXZMeUJ6Wld4bUxtMTVYMjVsYzNSbFpGOWliM2hmYzNSeWRXTjBMblpoYkhWbElEMGdVbTl2ZEZOMGNuVmpkQ2dLSUNBZ0lDOHZJQ0FnSUNCdVpYTjBaV1E5VG1WemRHVmtVM1J5ZFdOMEtHTnZiblJsYm5ROVZtVmpkRzl5S0hnOVlYSmpOQzVUZEhKcGJtY29JakVpS1N3Z2VUMWhjbU0wTGxOMGNtbHVaeWdpTWlJcEtTa0tJQ0FnSUM4dklDa0tJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdaWGhoYlhCc1pYTXZjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBjblZqZEhNdlkyOXVkSEpoWTNRdWNIazZOVFlLSUNBZ0lDOHZJSE5sYkdZdWJYbGZibVZ6ZEdWa1gySnZlRjl6ZEhKMVkzUXVkbUZzZFdVZ1BTQlNiMjkwVTNSeWRXTjBLQW9nSUNBZ1lubDBaV05mTXlBdkx5QWliWGxmYm1WemRHVmtYMkp2ZUY5emRISjFZM1FpQ2lBZ0lDQXZMeUJsZUdGdGNHeGxjeTl6YldGeWRGOWpiMjUwY21GamRITXZjM1J5ZFdOMGN5OWpiMjUwY21GamRDNXdlVG8xTmkwMU9Bb2dJQ0FnTHk4Z2MyVnNaaTV0ZVY5dVpYTjBaV1JmWW05NFgzTjBjblZqZEM1MllXeDFaU0E5SUZKdmIzUlRkSEoxWTNRb0NpQWdJQ0F2THlBZ0lDQWdibVZ6ZEdWa1BVNWxjM1JsWkZOMGNuVmpkQ2hqYjI1MFpXNTBQVlpsWTNSdmNpaDRQV0Z5WXpRdVUzUnlhVzVuS0NJeElpa3NJSGs5WVhKak5DNVRkSEpwYm1jb0lqSWlLU2twQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURBd01qQXdNREl3TURBME1EQXdOekF3TURFek1UQXdNREV6TWdvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z1pYaGhiWEJzWlhNdmMyMWhjblJmWTI5dWRISmhZM1J6TDNOMGNuVmpkSE12WTI5dWRISmhZM1F1Y0hrNk5Ua0tJQ0FnSUM4dklITmxiR1l1YlhsZlltOTRiV0Z3WDNOMGNuVmpkRnRoY21NMExsVkpiblEyTkNneE1qTXBYU0E5SUZabFkzUnZjaWg0UFdGeVl6UXVVM1J5YVc1bktDSXhJaWtzSUhrOVlYSmpOQzVUZEhKcGJtY29JaklpS1NrS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhnMlpEYzVOV1kyTWpabU56ZzJaRFl4TnpBMVpqY3pOelEzTWpjMU5qTTNOREF3TURBd01EQXdNREF3TURBd04ySUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ1lubDBaV01nTkNBdkx5QXdlRFprTnprMVpqWXlObVkzT0Raa05qRTNNRFZtTnpNM05EY3lOelUyTXpjME1EQXdNREF3TURBd01EQXdNREEzWWdvZ0lDQWdMeThnWlhoaGJYQnNaWE12YzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wY25WamRITXZZMjl1ZEhKaFkzUXVjSGs2TlRVS0lDQWdJQzh2SUhObGJHWXViWGxmWW05NFgzTjBjblZqZEM1MllXeDFaU0E5SUZabFkzUnZjaWg0UFdGeVl6UXVVM1J5YVc1bktDSXhJaWtzSUhrOVlYSmpOQzVUZEhKcGJtY29JaklpS1NrS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01EQTBNREF3TnpBd01ERXpNVEF3TURFek1nb2dJQ0FnTHk4Z1pYaGhiWEJzWlhNdmMyMWhjblJmWTI5dWRISmhZM1J6TDNOMGNuVmpkSE12WTI5dWRISmhZM1F1Y0hrNk5Ua0tJQ0FnSUM4dklITmxiR1l1YlhsZlltOTRiV0Z3WDNOMGNuVmpkRnRoY21NMExsVkpiblEyTkNneE1qTXBYU0E5SUZabFkzUnZjaWg0UFdGeVl6UXVVM1J5YVc1bktDSXhJaWtzSUhrOVlYSmpOQzVUZEhKcGJtY29JaklpS1NrS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklHVjRZVzF3YkdWekwzTnRZWEowWDJOdmJuUnlZV04wY3k5emRISjFZM1J6TDJOdmJuUnlZV04wTG5CNU9qWXdDaUFnSUNBdkx5QnpaV3htTG0xNVgyNWxjM1JsWkY5aWIzaHRZWEJmYzNSeWRXTjBXMkZ5WXpRdVZVbHVkRFkwS0RFeU15bGRJRDBnVW05dmRGTjBjblZqZENnS0lDQWdJR0o1ZEdWaklEVWdMeThnTUhnMlpEYzVOV1kyWlRZMU56TTNORFkxTmpRMVpqWXlObVkzT0Raa05qRTNNRFZtTnpNM05EY3lOelUyTXpjME1EQXdNREF3TURBd01EQXdNREEzWWdvZ0lDQWdMeThnWlhoaGJYQnNaWE12YzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wY25WamRITXZZMjl1ZEhKaFkzUXVjSGs2TmpBdE5qSUtJQ0FnSUM4dklITmxiR1l1YlhsZmJtVnpkR1ZrWDJKdmVHMWhjRjl6ZEhKMVkzUmJZWEpqTkM1VlNXNTBOalFvTVRJektWMGdQU0JTYjI5MFUzUnlkV04wS0FvZ0lDQWdMeThnSUNBZ0lHNWxjM1JsWkQxT1pYTjBaV1JUZEhKMVkzUW9ZMjl1ZEdWdWREMVdaV04wYjNJb2VEMWhjbU0wTGxOMGNtbHVaeWdpTVNJcExDQjVQV0Z5WXpRdVUzUnlhVzVuS0NJeUlpa3BLUW9nSUNBZ0x5OGdLUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJsZUdGdGNHeGxjeTl6YldGeWRGOWpiMjUwY21GamRITXZjM1J5ZFdOMGN5OWpiMjUwY21GamRDNXdlVG8yTUFvZ0lDQWdMeThnYzJWc1ppNXRlVjl1WlhOMFpXUmZZbTk0YldGd1gzTjBjblZqZEZ0aGNtTTBMbFZKYm5RMk5DZ3hNak1wWFNBOUlGSnZiM1JUZEhKMVkzUW9DaUFnSUNCaWVYUmxZeUExSUM4dklEQjRObVEzT1RWbU5tVTJOVGN6TnpRMk5UWTBOV1kyTWpabU56ZzJaRFl4TnpBMVpqY3pOelEzTWpjMU5qTTNOREF3TURBd01EQXdNREF3TURBd04ySUtJQ0FnSUM4dklHVjRZVzF3YkdWekwzTnRZWEowWDJOdmJuUnlZV04wY3k5emRISjFZM1J6TDJOdmJuUnlZV04wTG5CNU9qVTJMVFU0Q2lBZ0lDQXZMeUJ6Wld4bUxtMTVYMjVsYzNSbFpGOWliM2hmYzNSeWRXTjBMblpoYkhWbElEMGdVbTl2ZEZOMGNuVmpkQ2dLSUNBZ0lDOHZJQ0FnSUNCdVpYTjBaV1E5VG1WemRHVmtVM1J5ZFdOMEtHTnZiblJsYm5ROVZtVmpkRzl5S0hnOVlYSmpOQzVUZEhKcGJtY29JakVpS1N3Z2VUMWhjbU0wTGxOMGNtbHVaeWdpTWlJcEtTa0tJQ0FnSUM4dklDa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNREF5TURBd01qQXdNRFF3TURBM01EQXdNVE14TURBd01UTXlDaUFnSUNBdkx5QmxlR0Z0Y0d4bGN5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUnlkV04wY3k5amIyNTBjbUZqZEM1d2VUbzJNQzAyTWdvZ0lDQWdMeThnYzJWc1ppNXRlVjl1WlhOMFpXUmZZbTk0YldGd1gzTjBjblZqZEZ0aGNtTTBMbFZKYm5RMk5DZ3hNak1wWFNBOUlGSnZiM1JUZEhKMVkzUW9DaUFnSUNBdkx5QWdJQ0FnYm1WemRHVmtQVTVsYzNSbFpGTjBjblZqZENoamIyNTBaVzUwUFZabFkzUnZjaWg0UFdGeVl6UXVVM1J5YVc1bktDSXhJaWtzSUhrOVlYSmpOQzVUZEhKcGJtY29JaklpS1NrcENpQWdJQ0F2THlBcENpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QmxlR0Z0Y0d4bGN5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUnlkV04wY3k5amIyNTBjbUZqZEM1d2VUbzJNd29nSUNBZ0x5OGdjMlZzWmk1dGVWOXNiMk5oYkhOMFlYUmxYM04wY25WamRGdFVlRzR1YzJWdVpHVnlYU0E5SUZabFkzUnZjaWg0UFdGeVl6UXVVM1J5YVc1bktDSXhJaWtzSUhrOVlYSmpOQzVUZEhKcGJtY29JaklpS1NrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lIQjFjMmhpZVhSbGN5QWliWGxmYkc5allXeHpkR0YwWlY5emRISjFZM1FpQ2lBZ0lDQXZMeUJsZUdGdGNHeGxjeTl6YldGeWRGOWpiMjUwY21GamRITXZjM1J5ZFdOMGN5OWpiMjUwY21GamRDNXdlVG8xTlFvZ0lDQWdMeThnYzJWc1ppNXRlVjlpYjNoZmMzUnlkV04wTG5aaGJIVmxJRDBnVm1WamRHOXlLSGc5WVhKak5DNVRkSEpwYm1jb0lqRWlLU3dnZVQxaGNtTTBMbE4wY21sdVp5Z2lNaUlwS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBd01EUXdNREEzTURBd01UTXhNREF3TVRNeUNpQWdJQ0F2THlCbGVHRnRjR3hsY3k5emJXRnlkRjlqYjI1MGNtRmpkSE12YzNSeWRXTjBjeTlqYjI1MGNtRmpkQzV3ZVRvMk13b2dJQ0FnTHk4Z2MyVnNaaTV0ZVY5c2IyTmhiSE4wWVhSbFgzTjBjblZqZEZ0VWVHNHVjMlZ1WkdWeVhTQTlJRlpsWTNSdmNpaDRQV0Z5WXpRdVUzUnlhVzVuS0NJeElpa3NJSGs5WVhKak5DNVRkSEpwYm1jb0lqSWlLU2tLSUNBZ0lHRndjRjlzYjJOaGJGOXdkWFFLSUNBZ0lDOHZJR1Y0WVcxd2JHVnpMM050WVhKMFgyTnZiblJ5WVdOMGN5OXpkSEoxWTNSekwyTnZiblJ5WVdOMExuQjVPalkwQ2lBZ0lDQXZMeUJ6Wld4bUxtMTVYMjVsYzNSbFpGOXNiMk5oYkhOMFlYUmxYM04wY25WamRGdFVlRzR1YzJWdVpHVnlYU0E5SUZKdmIzUlRkSEoxWTNRb0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQndkWE5vWW5sMFpYTWdJbTE1WDI1bGMzUmxaRjlzYjJOaGJITjBZWFJsWDNOMGNuVmpkQ0lLSUNBZ0lDOHZJR1Y0WVcxd2JHVnpMM050WVhKMFgyTnZiblJ5WVdOMGN5OXpkSEoxWTNSekwyTnZiblJ5WVdOMExuQjVPalUyTFRVNENpQWdJQ0F2THlCelpXeG1MbTE1WDI1bGMzUmxaRjlpYjNoZmMzUnlkV04wTG5aaGJIVmxJRDBnVW05dmRGTjBjblZqZENnS0lDQWdJQzh2SUNBZ0lDQnVaWE4wWldROVRtVnpkR1ZrVTNSeWRXTjBLR052Ym5SbGJuUTlWbVZqZEc5eUtIZzlZWEpqTkM1VGRISnBibWNvSWpFaUtTd2dlVDFoY21NMExsTjBjbWx1WnlnaU1pSXBLU2tLSUNBZ0lDOHZJQ2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TURBeU1EQXdNakF3TURRd01EQTNNREF3TVRNeE1EQXdNVE15Q2lBZ0lDQXZMeUJsZUdGdGNHeGxjeTl6YldGeWRGOWpiMjUwY21GamRITXZjM1J5ZFdOMGN5OWpiMjUwY21GamRDNXdlVG8yTkMwMk5nb2dJQ0FnTHk4Z2MyVnNaaTV0ZVY5dVpYTjBaV1JmYkc5allXeHpkR0YwWlY5emRISjFZM1JiVkhodUxuTmxibVJsY2wwZ1BTQlNiMjkwVTNSeWRXTjBLQW9nSUNBZ0x5OGdJQ0FnSUc1bGMzUmxaRDFPWlhOMFpXUlRkSEoxWTNRb1kyOXVkR1Z1ZEQxV1pXTjBiM0lvZUQxaGNtTTBMbE4wY21sdVp5Z2lNU0lwTENCNVBXRnlZelF1VTNSeWFXNW5LQ0l5SWlrcEtRb2dJQ0FnTHk4Z0tRb2dJQ0FnWVhCd1gyeHZZMkZzWDNCMWRBb2dJQ0FnTHk4Z1pYaGhiWEJzWlhNdmMyMWhjblJmWTI5dWRISmhZM1J6TDNOMGNuVmpkSE12WTI5dWRISmhZM1F1Y0hrNk5UTUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoaGJHeHZkMTloWTNScGIyNXpQVnNpVDNCMFNXNGlYU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBQkFTWUdDZ0FFQUFjQUFURUFBVElPQUFJQUFnQUVBQWNBQVRFQUFUSU5iWGxmWW05NFgzTjBjblZqZEJSdGVWOXVaWE4wWldSZlltOTRYM04wY25WamRCaHRlVjlpYjNodFlYQmZjM1J5ZFdOMEFBQUFBQUFBQUhzZmJYbGZibVZ6ZEdWa1gySnZlRzFoY0Y5emRISjFZM1FBQUFBQUFBQUFlekVZUUFBaGdBbHRlVjl6ZEhKMVkzUW9aNEFRYlhsZmJtVnpkR1ZrWDNOMGNuVmpkQ2xuTVJ0QkFHdUFCRERHMVlvMkdnQ09BUUJUTVJrVVJERVlSSUlEQkFLK3poRUVwS1BPbWdTc0lIWWhOaG9BamdNQVF3QVpBQUVBZ0JNVkgzeDFBQVlBQ1FBTUFBRXhBQUV5QUFFenNDSkRnQklWSDN4MUFBSUFBZ0FFQUFjQUFURUFBVEt3SWtNeEdTSVNNUmdRUkVJQVFERVpGREVZRkJCRE5ob0JTWUVBV1VtQkFnaExBaFVTUkV4WEFnQ0JCMDhDQ0JaWEJnQ0FDUUFIU0dWc2JHOHNJRXhjQUV4UWdBUVZIM3gxVEZDd0lrTXF2RWdxS0w4cnZFZ3JLYjhuQkx4SUp3UW92eWNGdkVnbkJTbS9NUUNBRkcxNVgyeHZZMkZzYzNSaGRHVmZjM1J5ZFdOMEtHWXhBSUFiYlhsZmJtVnpkR1ZrWDJ4dlkyRnNjM1JoZEdWZmMzUnlkV04wS1dZaVF3PT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo4LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
