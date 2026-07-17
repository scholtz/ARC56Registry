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

namespace Arc56.Generated.riagma.voto3.Voto3_abb9c5e8
{


    public class Voto3Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public Voto3Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class LeerDatosRaicesReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

                public string Field3 { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField3.From(Field3);
                    stringRef[ret.Count] = vField3.Encode();
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

                public static LeerDatosRaicesReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new LeerDatosRaicesReturn();
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
                    var indexField3 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField3.Decode(bytes.Skip(indexField3 + prefixOffset).ToArray());
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is string vField3Value) { ret.Field3 = vField3Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as LeerDatosRaicesReturn);
                }
                public bool Equals(LeerDatosRaicesReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(LeerDatosRaicesReturn left, LeerDatosRaicesReturn right)
                {
                    return EqualityComparer<LeerDatosRaicesReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(LeerDatosRaicesReturn left, LeerDatosRaicesReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset_name"> </param>
        /// <param name="unit_name"> </param>
        /// <param name="total"> </param>
        public async Task<ulong> InicializarEleccion(string asset_name, string unit_name, ulong total, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 119, 87, 221, 202 };
            var asset_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); asset_nameAbi.From(asset_name);
            var unit_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); unit_nameAbi.From(unit_name);
            var totalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); totalAbi.From(total);

            var result = await base.CallApp(new List<object> { abiHandle, asset_nameAbi, unit_nameAbi, totalAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> InicializarEleccion_Transactions(string asset_name, string unit_name, ulong total, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 119, 87, 221, 202 };
            var asset_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); asset_nameAbi.From(asset_name);
            var unit_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); unit_nameAbi.From(unit_name);
            var totalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); totalAbi.From(total);

            return await base.MakeTransactionList(new List<object> { abiHandle, asset_nameAbi, unit_nameAbi, totalAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> LeerEstadoContrato(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 58, 151, 120, 107 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> LeerEstadoContrato_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 58, 151, 120, 107 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="nuevo_estado"> </param>
        public async Task<ulong> EstablecerEstadoContrato(ulong nuevo_estado, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 75, 11, 158 };
            var nuevo_estadoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nuevo_estadoAbi.From(nuevo_estado);

            var result = await base.CallApp(new List<object> { abiHandle, nuevo_estadoAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> EstablecerEstadoContrato_Transactions(ulong nuevo_estado, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 75, 11, 158 };
            var nuevo_estadoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nuevo_estadoAbi.From(nuevo_estado);

            return await base.MakeTransactionList(new List<object> { abiHandle, nuevo_estadoAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task AbrirRegistroCompromisos(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 254, 147, 192 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AbrirRegistroCompromisos_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 254, 147, 192 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> RegistrarCompromiso(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 16, 155, 106, 97 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RegistrarCompromiso_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 16, 155, 106, 97 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> CerrarRegistroCompromisos(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 136, 2, 157, 210 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CerrarRegistroCompromisos_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 136, 2, 157, 210 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="num_bloques"> </param>
        /// <param name="tam_bloque"> </param>
        /// <param name="tam_resto"> </param>
        public async Task AbrirRegistroRaices(ulong num_bloques, ulong tam_bloque, ulong tam_resto, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 48, 253, 28 };
            var num_bloquesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); num_bloquesAbi.From(num_bloques);
            var tam_bloqueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tam_bloqueAbi.From(tam_bloque);
            var tam_restoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tam_restoAbi.From(tam_resto);

            var result = await base.CallApp(new List<object> { abiHandle, num_bloquesAbi, tam_bloqueAbi, tam_restoAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AbrirRegistroRaices_Transactions(ulong num_bloques, ulong tam_bloque, ulong tam_resto, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 48, 253, 28 };
            var num_bloquesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); num_bloquesAbi.From(num_bloques);
            var tam_bloqueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tam_bloqueAbi.From(tam_bloque);
            var tam_restoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tam_restoAbi.From(tam_resto);

            return await base.MakeTransactionList(new List<object> { abiHandle, num_bloquesAbi, tam_bloqueAbi, tam_restoAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> RegistrarRaiz(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 156, 23, 164, 48 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RegistrarRaiz_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 156, 23, 164, 48 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="txnId_raiz"> </param>
        public async Task<ulong> CerrarRegistroRaices(string txnId_raiz, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 162, 138, 213 };
            var txnId_raizAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); txnId_raizAbi.From(txnId_raiz);

            var result = await base.CallApp(new List<object> { abiHandle, txnId_raizAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CerrarRegistroRaices_Transactions(string txnId_raiz, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 162, 138, 213 };
            var txnId_raizAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); txnId_raizAbi.From(txnId_raiz);

            return await base.MakeTransactionList(new List<object> { abiHandle, txnId_raizAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.LeerDatosRaicesReturn> LeerDatosRaices(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 125, 155, 62, 88 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.LeerDatosRaicesReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> LeerDatosRaices_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 125, 155, 62, 88 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task AbrirRegistroAnuladores(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 78, 129, 44, 247 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AbrirRegistroAnuladores_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 78, 129, 44, 247 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> RegistrarAnulador(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 185, 189, 206, 193 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RegistrarAnulador_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 185, 189, 206, 193 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="destinatario"> </param>
        public async Task<ulong> EnviarPapeleta(byte[] destinatario, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 105, 237, 174, 117 };
            var destinatarioAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); destinatarioAbi.From(destinatario);

            var result = await base.CallApp(new List<object> { abiHandle, destinatarioAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> EnviarPapeleta_Transactions(byte[] destinatario, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 105, 237, 174, 117 };
            var destinatarioAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); destinatarioAbi.From(destinatario);

            return await base.MakeTransactionList(new List<object> { abiHandle, destinatarioAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> CerrarRegistroAnuladores(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 128, 6, 120, 236 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CerrarRegistroAnuladores_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 128, 6, 120, 236 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="cuenta"> </param>
        public async Task RecuperarPapeletas(byte[] cuenta, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 30, 213, 50, 67 };
            var cuentaAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); cuentaAbi.From(cuenta);

            var result = await base.CallApp(new List<object> { abiHandle, cuentaAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RecuperarPapeletas_Transactions(byte[] cuenta, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 30, 213, 50, 67 };
            var cuentaAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); cuentaAbi.From(cuenta);

            return await base.MakeTransactionList(new List<object> { abiHandle, cuentaAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task FinalizarEleccion(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 111, 22, 63, 201 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> FinalizarEleccion_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 111, 22, 63, 201 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVm90bzMiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiTGVlckRhdG9zUmFpY2VzUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQzIiwidHlwZSI6InN0cmluZyJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJpbmljaWFsaXphcl9lbGVjY2lvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldF9uYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1bml0X25hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibGVlcl9lc3RhZG9fY29udHJhdG8iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJlc3RhYmxlY2VyX2VzdGFkb19jb250cmF0byIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJudWV2b19lc3RhZG8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhYnJpcl9yZWdpc3Ryb19jb21wcm9taXNvcyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWdpc3RyYXJfY29tcHJvbWlzbyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNlcnJhcl9yZWdpc3Ryb19jb21wcm9taXNvcyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFicmlyX3JlZ2lzdHJvX3JhaWNlcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJudW1fYmxvcXVlcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFtX2Jsb3F1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFtX3Jlc3RvIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZ2lzdHJhcl9yYWl6IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2VycmFyX3JlZ2lzdHJvX3JhaWNlcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0eG5JZF9yYWl6IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibGVlcl9kYXRvc19yYWljZXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0LHN0cmluZykiLCJzdHJ1Y3QiOiJMZWVyRGF0b3NSYWljZXNSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhYnJpcl9yZWdpc3Ryb19hbnVsYWRvcmVzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZ2lzdHJhcl9hbnVsYWRvciIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImVudmlhcl9wYXBlbGV0YSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZXN0aW5hdGFyaW8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjZXJyYXJfcmVnaXN0cm9fYW51bGFkb3JlcyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlY3VwZXJhcl9wYXBlbGV0YXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY3VlbnRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImZpbmFsaXphcl9lbGVjY2lvbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6OSwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzEwMjgsMTExNl0sImVycm9yTWVzc2FnZSI6IkFkZHJlc3MgbGVuZ3RoIGlzIDMyIGJ5dGVzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzgwLDc5OSw4MjQsODQ4LDg4MCw5MDksOTMyLDk2Nyw5ODYsMTAxNiwxMDc1XSwiZXJyb3JNZXNzYWdlIjoiRWwgY29udHJhdG8gbm8gZXN0w6EgZW4gZWwgZXN0YWRvIGNvcnJlY3RvIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjg0XSwiZXJyb3JNZXNzYWdlIjoiRWwgY29udHJhdG8geWEgZXN0w6EgaW5pY2lhbGl6YWRvIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTEwMiwxMTUyXSwiZXJyb3JNZXNzYWdlIjoiTGEgZWxlY2Npw7NuIG5vIGhhIGFjYWJhZG8iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMzIsMzQ0LDM2MiwzNzksNDAyLDQxOSw0MzEsNDgxLDUwNCw1MjEsNTQ1LDU2Miw1NzksNTkxLDYxMiw2MjldLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NTldLCJlcnJvck1lc3NhZ2UiOiJTb2xvIGVsIGNyZWFkb3IgcHVlZGUgYWJyaXIgZWwgcmVnaXN0cm8gZGUgYW51bGFkb3JlcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc3M10sImVycm9yTWVzc2FnZSI6IlNvbG8gZWwgY3JlYWRvciBwdWVkZSBhYnJpciBlbCByZWdpc3RybyBkZSBjb21wcm9taXNvcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg0MV0sImVycm9yTWVzc2FnZSI6IlNvbG8gZWwgY3JlYWRvciBwdWVkZSBhYnJpciBlbCByZWdpc3RybyBkZSByYcOtY2VzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA2N10sImVycm9yTWVzc2FnZSI6IlNvbG8gZWwgY3JlYWRvciBwdWVkZSBjZXJyYXIgZWwgcmVnaXN0cm8gZGUgYW51bGFkb3JlcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgxNl0sImVycm9yTWVzc2FnZSI6IlNvbG8gZWwgY3JlYWRvciBwdWVkZSBjZXJyYXIgZWwgcmVnaXN0cm8gZGUgY29tcHJvbWlzb3MiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5MDJdLCJlcnJvck1lc3NhZ2UiOiJTb2xvIGVsIGNyZWFkb3IgcHVlZGUgY2VycmFyIGVsIHJlZ2lzdHJvIGRlIHJhw61jZXMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDA4XSwiZXJyb3JNZXNzYWdlIjoiU29sbyBlbCBjcmVhZG9yIHB1ZWRlIGVudmlhciBwYXBlbGV0YXMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NjBdLCJlcnJvck1lc3NhZ2UiOiJTb2xvIGVsIGNyZWFkb3IgcHVlZGUgZXN0YWJsZWNlciBlbCBlc3RhZG8gZGVsIGNvbnRyYXRvIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE0NF0sImVycm9yTWVzc2FnZSI6IlNvbG8gZWwgY3JlYWRvciBwdWVkZSBmaW5hbGl6YXIgbGEgZWxlY2Npw7NuIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjc4XSwiZXJyb3JNZXNzYWdlIjoiU29sbyBlbCBjcmVhZG9yIHB1ZWRlIGluaWNpYWxpemFyIGxhIGVsZWNjacOzbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc0Nl0sImVycm9yTWVzc2FnZSI6IlNvbG8gZWwgY3JlYWRvciBwdWVkZSBsZWVyIGVsIGVzdGFkbyBkZWwgY29udHJhdG8iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDk0XSwiZXJyb3JNZXNzYWdlIjoiU29sbyBlbCBjcmVhZG9yIHB1ZWRlIHJlY3VwZXJhciBwYXBlbGV0YXMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NzhdLCJlcnJvck1lc3NhZ2UiOiJTb2xvIGVsIGNyZWFkb3IgcHVlZGUgcmVnaXN0cmFyIGFudWxhZG9yZXMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3OTFdLCJlcnJvck1lc3NhZ2UiOiJTb2xvIGVsIGNyZWFkb3IgcHVlZGUgcmVnaXN0cmFyIGNvbXByb21pc29zIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODczXSwiZXJyb3JNZXNzYWdlIjoiU29sbyBlbCBjcmVhZG9yIHB1ZWRlIHJlZ2lzdHJhciByYcOtY2VzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE4MywxMTg4XSwiZXJyb3JNZXNzYWdlIjoiYWNjb3VudCBmdW5kZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2OTFdLCJlcnJvck1lc3NhZ2UiOiJhc3NldF9uYW1lIGRlbWFzaWFkbyBsYXJnbyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY2N10sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzNSwzNDcsMzY1LDM4Miw0MDUsNDIyLDQzNCw0ODQsNTA3LDUyNCw1NDgsNTY1LDU4Miw1OTQsNjE1LDYzMl0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5OTEsMTA4NF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuY29udGFkb3JfYW51bGFkb3JlcyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MDMsODMxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5jb250YWRvcl9jb21wcm9taXNvcyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4ODUsOTIzXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5jb250YWRvcl9yYWljZXMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjgyLDc1MCw3NzcsNzk1LDgyMCw4NDUsODc3LDkwNiw5MjgsOTYzLDk4MiwxMDEyLDEwNzEsMTA5OCwxMTQ4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5lc3RhZG9fY29udHJhdG8gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTM3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5udW1fYmxvcXVlcyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MzksMTAyMSwxMTA3LDExNTddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnBhcGVsZXRhcyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDUzXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5wYXBlbGV0YXNfZW52aWFkYXMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTQyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50YW1fYmxvcXVlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk0N10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudGFtX3Jlc3RvIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk1Ml0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudHhuSWRfcmFpeiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2OThdLCJlcnJvck1lc3NhZ2UiOiJ1bml0X25hbWUgZGVtYXNpYWRvIGxhcmdvIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVkbTkwYnpNdVkyOXVkSEpoWTNRdVZtOTBiek11WDE5aGJHZHZjSGxmWlc1MGNubHdiMmx1ZEY5M2FYUm9YMmx1YVhRb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElEUWdNd29nSUNBZ1lubDBaV05pYkc5amF5QWlaWE4wWVdSdlgyTnZiblJ5WVhSdklpQXdlREUxTVdZM1l6YzFJQ0p3WVhCbGJHVjBZWE1pSUNKamIyNTBZV1J2Y2w5amIyMXdjbTl0YVhOdmN5SWdJbU52Ym5SaFpHOXlYM0poYVdObGN5SWdJbU52Ym5SaFpHOXlYMkZ1ZFd4aFpHOXlaWE1pSUNKd1lYQmxiR1YwWVhOZlpXNTJhV0ZrWVhNaUlDSnVkVzFmWW14dmNYVmxjeUlnSW5SaGJWOWliRzl4ZFdVaUlDSjBZVzFmY21WemRHOGlJQ0owZUc1SlpGOXlZV2w2SWdvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzWnZkRzh6TDJOdmJuUnlZV04wTG5CNU9qTTRDaUFnSUNBdkx5QnpaV3htTG1WemRHRmtiMTlqYjI1MGNtRjBieUE5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWlhOMFlXUnZYMk52Ym5SeVlYUnZJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtOTBiek12WTI5dWRISmhZM1F1Y0hrNk5EQUtJQ0FnSUM4dklITmxiR1l1Y0dGd1pXeGxkR0Z6SUQwZ1FYTnpaWFFvTUNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5CaGNHVnNaWFJoY3lJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1p2ZEc4ekwyTnZiblJ5WVdOMExuQjVPalF4Q2lBZ0lDQXZMeUJ6Wld4bUxuQmhjR1ZzWlhSaGMxOWxiblpwWVdSaGN5QTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV01nTmlBdkx5QWljR0Z3Wld4bGRHRnpYMlZ1ZG1saFpHRnpJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtOTBiek12WTI5dWRISmhZM1F1Y0hrNk5ETUtJQ0FnSUM4dklITmxiR1l1WTI5dWRHRmtiM0pmWTI5dGNISnZiV2x6YjNNZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltTnZiblJoWkc5eVgyTnZiWEJ5YjIxcGMyOXpJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtOTBiek12WTI5dWRISmhZM1F1Y0hrNk5EUUtJQ0FnSUM4dklITmxiR1l1WTI5dWRHRmtiM0pmY21GcFkyVnpJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0pqYjI1MFlXUnZjbDl5WVdsalpYTWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MmIzUnZNeTlqYjI1MGNtRmpkQzV3ZVRvME5Rb2dJQ0FnTHk4Z2MyVnNaaTVqYjI1MFlXUnZjbDloYm5Wc1lXUnZjbVZ6SUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKamIyNTBZV1J2Y2w5aGJuVnNZV1J2Y21Weklnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZG05MGJ6TXZZMjl1ZEhKaFkzUXVjSGs2TkRjS0lDQWdJQzh2SUhObGJHWXViblZ0WDJKc2IzRjFaWE1nUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWaklEY2dMeThnSW01MWJWOWliRzl4ZFdWeklnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZG05MGJ6TXZZMjl1ZEhKaFkzUXVjSGs2TkRnS0lDQWdJQzh2SUhObGJHWXVkR0Z0WDJKc2IzRjFaU0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldNZ09DQXZMeUFpZEdGdFgySnNiM0YxWlNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1p2ZEc4ekwyTnZiblJ5WVdOMExuQjVPalE1Q2lBZ0lDQXZMeUJ6Wld4bUxuUmhiVjl5WlhOMGJ5QTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV01nT1NBdkx5QWlkR0Z0WDNKbGMzUnZJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtOTBiek12WTI5dWRISmhZM1F1Y0hrNk5URUtJQ0FnSUM4dklITmxiR1l1ZEhodVNXUmZjbUZwZWlBOUlGTjBjbWx1WnlnaUlpa0tJQ0FnSUdKNWRHVmpJREV3SUM4dklDSjBlRzVKWkY5eVlXbDZJZ29nSUNBZ2NIVnphR0o1ZEdWeklDSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZG05MGJ6TXZZMjl1ZEhKaFkzUXVjSGs2TVRnS0lDQWdJQzh2SUdOc1lYTnpJRlp2ZEc4ektFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWlZWEpsWDNKdmRYUnBibWRBTWpFS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnM056VTNaR1JqWVNBd2VETmhPVGMzT0RaaUlEQjRPRGswWWpCaU9XVWdNSGhqTjJabE9UTmpNQ0F3ZURFd09XSTJZVFl4SURCNE9EZ3dNamxrWkRJZ01IaGtNek13Wm1ReFl5QXdlRGxqTVRkaE5ETXdJREI0TURKaE1qaGhaRFVnTUhnM1pEbGlNMlUxT0NBd2VEUmxPREV5WTJZM0lEQjRZamxpWkdObFl6RWdNSGcyT1dWa1lXVTNOU0F3ZURnd01EWTNPR1ZqSURCNE1XVmtOVE15TkRNZ01IZzJaakUyTTJaak9TQXZMeUJ0WlhSb2IyUWdJbWx1YVdOcFlXeHBlbUZ5WDJWc1pXTmphVzl1S0hOMGNtbHVaeXh6ZEhKcGJtY3NkV2x1ZERZMEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaWJHVmxjbDlsYzNSaFpHOWZZMjl1ZEhKaGRHOG9LWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlaWE4wWVdKc1pXTmxjbDlsYzNSaFpHOWZZMjl1ZEhKaGRHOG9kV2x1ZERZMEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVlXSnlhWEpmY21WbmFYTjBjbTlmWTI5dGNISnZiV2x6YjNNb0tYWnZhV1FpTENCdFpYUm9iMlFnSW5KbFoybHpkSEpoY2w5amIyMXdjbTl0YVhOdktDbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltTmxjbkpoY2w5eVpXZHBjM1J5YjE5amIyMXdjbTl0YVhOdmN5Z3BkV2x1ZERZMElpd2diV1YwYUc5a0lDSmhZbkpwY2w5eVpXZHBjM1J5YjE5eVlXbGpaWE1vZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpY21WbmFYTjBjbUZ5WDNKaGFYb29LWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlZMlZ5Y21GeVgzSmxaMmx6ZEhKdlgzSmhhV05sY3loemRISnBibWNwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0pzWldWeVgyUmhkRzl6WDNKaGFXTmxjeWdwS0hWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExITjBjbWx1WnlraUxDQnRaWFJvYjJRZ0ltRmljbWx5WDNKbFoybHpkSEp2WDJGdWRXeGhaRzl5WlhNb0tYWnZhV1FpTENCdFpYUm9iMlFnSW5KbFoybHpkSEpoY2w5aGJuVnNZV1J2Y2lncGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKbGJuWnBZWEpmY0dGd1pXeGxkR0VvWW5sMFpWdGRLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlZMlZ5Y21GeVgzSmxaMmx6ZEhKdlgyRnVkV3hoWkc5eVpYTW9LWFZwYm5RMk5DSXNJRzFsZEdodlpDQWljbVZqZFhCbGNtRnlYM0JoY0dWc1pYUmhjeWhpZVhSbFcxMHBkbTlwWkNJc0lHMWxkR2h2WkNBaVptbHVZV3hwZW1GeVgyVnNaV05qYVc5dUtDbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JXRnBibDlwYm1samFXRnNhWHBoY2w5bGJHVmpZMmx2Ymw5eWIzVjBaVUExSUcxaGFXNWZiR1ZsY2w5bGMzUmhaRzlmWTI5dWRISmhkRzlmY205MWRHVkFOaUJ0WVdsdVgyVnpkR0ZpYkdWalpYSmZaWE4wWVdSdlgyTnZiblJ5WVhSdlgzSnZkWFJsUURjZ2JXRnBibDloWW5KcGNsOXlaV2RwYzNSeWIxOWpiMjF3Y205dGFYTnZjMTl5YjNWMFpVQTRJRzFoYVc1ZmNtVm5hWE4wY21GeVgyTnZiWEJ5YjIxcGMyOWZjbTkxZEdWQU9TQnRZV2x1WDJObGNuSmhjbDl5WldkcGMzUnliMTlqYjIxd2NtOXRhWE52YzE5eWIzVjBaVUF4TUNCdFlXbHVYMkZpY21seVgzSmxaMmx6ZEhKdlgzSmhhV05sYzE5eWIzVjBaVUF4TVNCdFlXbHVYM0psWjJsemRISmhjbDl5WVdsNlgzSnZkWFJsUURFeUlHMWhhVzVmWTJWeWNtRnlYM0psWjJsemRISnZYM0poYVdObGMxOXliM1YwWlVBeE15QnRZV2x1WDJ4bFpYSmZaR0YwYjNOZmNtRnBZMlZ6WDNKdmRYUmxRREUwSUcxaGFXNWZZV0p5YVhKZmNtVm5hWE4wY205ZllXNTFiR0ZrYjNKbGMxOXliM1YwWlVBeE5TQnRZV2x1WDNKbFoybHpkSEpoY2w5aGJuVnNZV1J2Y2w5eWIzVjBaVUF4TmlCdFlXbHVYMlZ1ZG1saGNsOXdZWEJsYkdWMFlWOXliM1YwWlVBeE55QnRZV2x1WDJObGNuSmhjbDl5WldkcGMzUnliMTloYm5Wc1lXUnZjbVZ6WDNKdmRYUmxRREU0SUcxaGFXNWZjbVZqZFhCbGNtRnlYM0JoY0dWc1pYUmhjMTl5YjNWMFpVQXhPU0J0WVdsdVgyWnBibUZzYVhwaGNsOWxiR1ZqWTJsdmJsOXliM1YwWlVBeU1Bb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREl6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1p2ZEc4ekwyTnZiblJ5WVdOMExuQjVPakU0Q2lBZ0lDQXZMeUJqYkdGemN5QldiM1J2TXloQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW1hVzVoYkdsNllYSmZaV3hsWTJOcGIyNWZjbTkxZEdWQU1qQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtOTBiek12WTI5dWRISmhZM1F1Y0hrNk1qWXdDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5Sk9iMDl3SWwwcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJR05oYkd4emRXSWdabWx1WVd4cGVtRnlYMlZzWldOamFXOXVDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzSmxZM1Z3WlhKaGNsOXdZWEJsYkdWMFlYTmZjbTkxZEdWQU1UazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtOTBiek12WTI5dWRISmhZM1F1Y0hrNk1qUTFDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5Sk9iMDl3SWwwcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyYjNSdk15OWpiMjUwY21GamRDNXdlVG94T0FvZ0lDQWdMeThnWTJ4aGMzTWdWbTkwYnpNb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtOTBiek12WTI5dWRISmhZM1F1Y0hrNk1qUTFDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5Sk9iMDl3SWwwcENpQWdJQ0JqWVd4c2MzVmlJSEpsWTNWd1pYSmhjbDl3WVhCbGJHVjBZWE1LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZMlZ5Y21GeVgzSmxaMmx6ZEhKdlgyRnVkV3hoWkc5eVpYTmZjbTkxZEdWQU1UZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtOTBiek12WTI5dWRISmhZM1F1Y0hrNk1qTXlDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCalpYSnlZWEpmY21WbmFYTjBjbTlmWVc1MWJHRmtiM0psY3dvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlsYm5acFlYSmZjR0Z3Wld4bGRHRmZjbTkxZEdWQU1UYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtOTBiek12WTI5dWRISmhZM1F1Y0hrNk1qRXhDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzWnZkRzh6TDJOdmJuUnlZV04wTG5CNU9qRTRDaUFnSUNBdkx5QmpiR0Z6Y3lCV2IzUnZNeWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyYjNSdk15OWpiMjUwY21GamRDNXdlVG95TVRFS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnWTJGc2JITjFZaUJsYm5acFlYSmZjR0Z3Wld4bGRHRUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmNtVm5hWE4wY21GeVgyRnVkV3hoWkc5eVgzSnZkWFJsUURFMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNadmRHOHpMMk52Ym5SeVlXTjBMbkI1T2pFNU9Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnY21WbmFYTjBjbUZ5WDJGdWRXeGhaRzl5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMkZpY21seVgzSmxaMmx6ZEhKdlgyRnVkV3hoWkc5eVpYTmZjbTkxZEdWQU1UVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtOTBiek12WTI5dWRISmhZM1F1Y0hrNk1UZzRMVEU0T1FvZ0lDQWdMeThnSXlCTnc2bDBiMlJ2Y3lCd1lYSmhJR0Z1ZFd4aFpHOXlaWE1LSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQmpZV3hzYzNWaUlHRmljbWx5WDNKbFoybHpkSEp2WDJGdWRXeGhaRzl5WlhNS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmYkdWbGNsOWtZWFJ2YzE5eVlXbGpaWE5mY205MWRHVkFNVFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbTkwYnpNdlkyOXVkSEpoWTNRdWNIazZNVGM1Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZMkZzYkhOMVlpQnNaV1Z5WDJSaGRHOXpYM0poYVdObGN3b2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdsMGIySUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdhWFJ2WWdvZ0lDQWdaR2xuSURNS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF4WVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlkyVnljbUZ5WDNKbFoybHpkSEp2WDNKaGFXTmxjMTl5YjNWMFpVQXhNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTJiM1J2TXk5amIyNTBjbUZqZEM1d2VUb3hOamNLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbTkwYnpNdlkyOXVkSEpoWTNRdWNIazZNVGdLSUNBZ0lDOHZJR05zWVhOeklGWnZkRzh6S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNadmRHOHpMMk52Ym5SeVlXTjBMbkI1T2pFMk53b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCallXeHNjM1ZpSUdObGNuSmhjbDl5WldkcGMzUnliMTl5WVdsalpYTUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmNtVm5hWE4wY21GeVgzSmhhWHBmY205MWRHVkFNVEk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbTkwYnpNdlkyOXVkSEpoWTNRdWNIazZNVFUxQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZMkZzYkhOMVlpQnlaV2RwYzNSeVlYSmZjbUZwZWdvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDloWW5KcGNsOXlaV2RwYzNSeWIxOXlZV2xqWlhOZmNtOTFkR1ZBTVRFNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZG05MGJ6TXZZMjl1ZEhKaFkzUXVjSGs2TVRRd0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNadmRHOHpMMk52Ym5SeVlXTjBMbkI1T2pFNENpQWdJQ0F2THlCamJHRnpjeUJXYjNSdk15aEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1p2ZEc4ekwyTnZiblJ5WVdOMExuQjVPakUwTUFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JqWVd4c2MzVmlJR0ZpY21seVgzSmxaMmx6ZEhKdlgzSmhhV05sY3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlqWlhKeVlYSmZjbVZuYVhOMGNtOWZZMjl0Y0hKdmJXbHpiM05mY205MWRHVkFNVEE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbTkwYnpNdlkyOXVkSEpoWTNRdWNIazZNVEkzQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZMkZzYkhOMVlpQmpaWEp5WVhKZmNtVm5hWE4wY205ZlkyOXRjSEp2YldsemIzTUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmNtVm5hWE4wY21GeVgyTnZiWEJ5YjIxcGMyOWZjbTkxZEdWQU9Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MmIzUnZNeTlqYjI1MGNtRmpkQzV3ZVRveE1UVUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUhKbFoybHpkSEpoY2w5amIyMXdjbTl0YVhOdkNpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJGaWNtbHlYM0psWjJsemRISnZYMk52YlhCeWIyMXBjMjl6WDNKdmRYUmxRRGc2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbTkwYnpNdlkyOXVkSEpoWTNRdWNIazZNVEExQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZMkZzYkhOMVlpQmhZbkpwY2w5eVpXZHBjM1J5YjE5amIyMXdjbTl0YVhOdmN3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5bGMzUmhZbXhsWTJWeVgyVnpkR0ZrYjE5amIyNTBjbUYwYjE5eWIzVjBaVUEzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1p2ZEc4ekwyTnZiblJ5WVdOMExuQjVPamsxQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0dGc2JHOTNYMkZqZEdsdmJuTTlXeUpPYjA5d0lsMHBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MmIzUnZNeTlqYjI1MGNtRmpkQzV3ZVRveE9Bb2dJQ0FnTHk4Z1kyeGhjM01nVm05MGJ6TW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyYjNSdk15OWpiMjUwY21GamRDNXdlVG81TlFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoaGJHeHZkMTloWTNScGIyNXpQVnNpVG05UGNDSmRLUW9nSUNBZ1kyRnNiSE4xWWlCbGMzUmhZbXhsWTJWeVgyVnpkR0ZrYjE5amIyNTBjbUYwYndvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlzWldWeVgyVnpkR0ZrYjE5amIyNTBjbUYwYjE5eWIzVjBaVUEyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1p2ZEc4ekwyTnZiblJ5WVdOMExuQjVPamc0Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0dGc2JHOTNYMkZqZEdsdmJuTTlXeUpPYjA5d0lsMHBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnYkdWbGNsOWxjM1JoWkc5ZlkyOXVkSEpoZEc4S0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmYVc1cFkybGhiR2w2WVhKZlpXeGxZMk5wYjI1ZmNtOTFkR1ZBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyYjNSdk15OWpiMjUwY21GamRDNXdlVG8xTlFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoaGJHeHZkMTloWTNScGIyNXpQVnNpVG05UGNDSmRLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtOTBiek12WTI5dWRISmhZM1F1Y0hrNk1UZ0tJQ0FnSUM4dklHTnNZWE56SUZadmRHOHpLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTJiM1J2TXk5amIyNTBjbUZqZEM1d2VUbzFOUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2hoYkd4dmQxOWhZM1JwYjI1elBWc2lUbTlQY0NKZEtRb2dJQ0FnWTJGc2JITjFZaUJwYm1samFXRnNhWHBoY2w5bGJHVmpZMmx2YmdvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlpWVhKbFgzSnZkWFJwYm1kQU1qRTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtOTBiek12WTI5dWRISmhZM1F1Y0hrNk1UZ0tJQ0FnSUM4dklHTnNZWE56SUZadmRHOHpLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREl6Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJqY21WaGRHbHVad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1MmIzUnZNeTVqYjI1MGNtRmpkQzVXYjNSdk15NXBibWxqYVdGc2FYcGhjbDlsYkdWalkybHZiaWhoYzNObGRGOXVZVzFsT2lCaWVYUmxjeXdnZFc1cGRGOXVZVzFsT2lCaWVYUmxjeXdnZEc5MFlXdzZJSFZwYm5RMk5Da2dMVDRnZFdsdWREWTBPZ3BwYm1samFXRnNhWHBoY2w5bGJHVmpZMmx2YmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyYjNSdk15OWpiMjUwY21GamRDNXdlVG8xTlMwMk1Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaGhiR3h2ZDE5aFkzUnBiMjV6UFZzaVRtOVBjQ0pkS1FvZ0lDQWdMeThnWkdWbUlHbHVhV05wWVd4cGVtRnlYMlZzWldOamFXOXVLQW9nSUNBZ0x5OGdJQ0FnSUhObGJHWXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZibUZ0WlRvZ1UzUnlhVzVuTEFvZ0lDQWdMeThnSUNBZ0lIVnVhWFJmYm1GdFpUb2dVM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQWdJSFJ2ZEdGc09pQlZTVzUwTmpRc0NpQWdJQ0F2THlBcElDMCtJRlZKYm5RMk5Eb0tJQ0FnSUhCeWIzUnZJRE1nTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1p2ZEc4ekwyTnZiblJ5WVdOMExuQjVPall6Q2lBZ0lDQXZMeUJVZUc0dWMyVnVaR1Z5SUQwOUlFZHNiMkpoYkM1amNtVmhkRzl5WDJGa1pISmxjM01LSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdkc2IySmhiQ0JEY21WaGRHOXlRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyYjNSdk15OWpiMjUwY21GamRDNXdlVG8yTWkwMk5Bb2dJQ0FnTHk4Z1lYTnpaWEowSUNnS0lDQWdJQzh2SUNBZ0lDQlVlRzR1YzJWdVpHVnlJRDA5SUVkc2IySmhiQzVqY21WaGRHOXlYMkZrWkhKbGMzTUtJQ0FnSUM4dklDa3NJQ0pUYjJ4dklHVnNJR055WldGa2IzSWdjSFZsWkdVZ2FXNXBZMmxoYkdsNllYSWdiR0VnWld4bFkyTnB3N051SWdvZ0lDQWdZWE56WlhKMElDOHZJRk52Ykc4Z1pXd2dZM0psWVdSdmNpQndkV1ZrWlNCcGJtbGphV0ZzYVhwaGNpQnNZU0JsYkdWalkybkRzMjRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTJiM1J2TXk5amIyNTBjbUZqZEM1d2VUbzJOUW9nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1WlhOMFlXUnZYMk52Ym5SeVlYUnZJRDA5SUZWSmJuUTJOQ2d3S1N3Z0lrVnNJR052Ym5SeVlYUnZJSGxoSUdWemRNT2hJR2x1YVdOcFlXeHBlbUZrYnlJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0psYzNSaFpHOWZZMjl1ZEhKaGRHOGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WlhOMFlXUnZYMk52Ym5SeVlYUnZJR1Y0YVhOMGN3b2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRVZzSUdOdmJuUnlZWFJ2SUhsaElHVnpkTU9oSUdsdWFXTnBZV3hwZW1Ga2J3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNadmRHOHpMMk52Ym5SeVlXTjBMbkI1T2pjd0NpQWdJQ0F2THlCaGMzTmxjblFnYm1GdFpWOWllWFJsY3k1c1pXNW5kR2dnUEQwZ016SXNJQ0poYzNObGRGOXVZVzFsSUdSbGJXRnphV0ZrYnlCc1lYSm5ieUlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURNeUlDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHRnpjMlYwWDI1aGJXVWdaR1Z0WVhOcFlXUnZJR3hoY21kdkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZG05MGJ6TXZZMjl1ZEhKaFkzUXVjSGs2TnpFS0lDQWdJQzh2SUdGemMyVnlkQ0IxYm1sMFgySjVkR1Z6TG14bGJtZDBhQ0E4UFNBNExDQWlkVzVwZEY5dVlXMWxJR1JsYldGemFXRmtieUJzWVhKbmJ5SUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRGdnTHk4Z09Bb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUIxYm1sMFgyNWhiV1VnWkdWdFlYTnBZV1J2SUd4aGNtZHZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtOTBiek12WTI5dWRISmhZM1F1Y0hrNk56TXRPREFLSUNBZ0lDOHZJR0Z6YzJWMFgzUjRiaUE5SUdsMGVHNHVRWE56WlhSRGIyNW1hV2NvQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmYm1GdFpUMXVZVzFsWDJKNWRHVnpMQW9nSUNBZ0x5OGdJQ0FnSUhWdWFYUmZibUZ0WlQxMWJtbDBYMko1ZEdWekxBb2dJQ0FnTHk4Z0lDQWdJSFJ2ZEdGc1BYUnZkR0ZzTEFvZ0lDQWdMeThnSUNBZ0lHUmxZMmx0WVd4elBUQXNDaUFnSUNBdkx5QWdJQ0FnYldGdVlXZGxjajFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdOc1lYZGlZV05yUFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtOTBiek12WTI5dWRISmhZM1F1Y0hrNk56Z0tJQ0FnSUM4dklHMWhibUZuWlhJOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZG05MGJ6TXZZMjl1ZEhKaFkzUXVjSGs2TnprS0lDQWdJQzh2SUdOc1lYZGlZV05yUFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQmtkWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJEYkdGM1ltRmphd29nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRTFoYm1GblpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MmIzUnZNeTlqYjI1MGNtRmpkQzV3ZVRvM053b2dJQ0FnTHk4Z1pHVmphVzFoYkhNOU1Dd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFJHVmphVzFoYkhNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEZSdmRHRnNDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUlZibWwwVG1GdFpRb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFRtRnRaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzWnZkRzh6TDJOdmJuUnlZV04wTG5CNU9qY3pDaUFnSUNBdkx5QmhjM05sZEY5MGVHNGdQU0JwZEhodUxrRnpjMlYwUTI5dVptbG5LQW9nSUNBZ2FXNTBZMTh6SUM4dklHRmpabWNLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNadmRHOHpMMk52Ym5SeVlXTjBMbkI1T2pjekxUZ3dDaUFnSUNBdkx5QmhjM05sZEY5MGVHNGdQU0JwZEhodUxrRnpjMlYwUTI5dVptbG5LQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMjVoYldVOWJtRnRaVjlpZVhSbGN5d0tJQ0FnSUM4dklDQWdJQ0IxYm1sMFgyNWhiV1U5ZFc1cGRGOWllWFJsY3l3S0lDQWdJQzh2SUNBZ0lDQjBiM1JoYkQxMGIzUmhiQ3dLSUNBZ0lDOHZJQ0FnSUNCa1pXTnBiV0ZzY3owd0xBb2dJQ0FnTHk4Z0lDQWdJRzFoYm1GblpYSTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JqYkdGM1ltRmphejFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MmIzUnZNeTlqYjI1MGNtRmpkQzV3ZVRvNE1nb2dJQ0FnTHk4Z2MyVnNaaTV3WVhCbGJHVjBZWE1nUFNCaGMzTmxkRjkwZUc0dVkzSmxZWFJsWkY5aGMzTmxkQW9nSUNBZ1lubDBaV05mTWlBdkx5QWljR0Z3Wld4bGRHRnpJZ29nSUNBZ2FYUjRiaUJEY21WaGRHVmtRWE56WlhSSlJBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MmIzUnZNeTlqYjI1MGNtRmpkQzV3ZVRvNE13b2dJQ0FnTHk4Z2MyVnNaaTVsYzNSaFpHOWZZMjl1ZEhKaGRHOGdQU0JWU1c1ME5qUW9NU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbVZ6ZEdGa2IxOWpiMjUwY21GMGJ5SUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNadmRHOHpMMk52Ym5SeVlXTjBMbkI1T2pnMENpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNXdZWEJsYkdWMFlYTXVhV1FLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSndZWEJsYkdWMFlYTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Y0dGd1pXeGxkR0Z6SUdWNGFYTjBjd29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuWnZkRzh6TG1OdmJuUnlZV04wTGxadmRHOHpMbXhsWlhKZlpYTjBZV1J2WDJOdmJuUnlZWFJ2S0NrZ0xUNGdkV2x1ZERZME9ncHNaV1Z5WDJWemRHRmtiMTlqYjI1MGNtRjBiem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTJiM1J2TXk5amIyNTBjbUZqZEM1d2VUbzVNUW9nSUNBZ0x5OGdWSGh1TG5ObGJtUmxjaUE5UFNCSGJHOWlZV3d1WTNKbFlYUnZjbDloWkdSeVpYTnpDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JuYkc5aVlXd2dRM0psWVhSdmNrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbTkwYnpNdlkyOXVkSEpoWTNRdWNIazZPVEF0T1RJS0lDQWdJQzh2SUdGemMyVnlkQ0FvQ2lBZ0lDQXZMeUFnSUNBZ1ZIaHVMbk5sYm1SbGNpQTlQU0JIYkc5aVlXd3VZM0psWVhSdmNsOWhaR1J5WlhOekNpQWdJQ0F2THlBcExDQWlVMjlzYnlCbGJDQmpjbVZoWkc5eUlIQjFaV1JsSUd4bFpYSWdaV3dnWlhOMFlXUnZJR1JsYkNCamIyNTBjbUYwYnlJS0lDQWdJR0Z6YzJWeWRDQXZMeUJUYjJ4dklHVnNJR055WldGa2IzSWdjSFZsWkdVZ2JHVmxjaUJsYkNCbGMzUmhaRzhnWkdWc0lHTnZiblJ5WVhSdkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZG05MGJ6TXZZMjl1ZEhKaFkzUXVjSGs2T1RNS0lDQWdJQzh2SUhKbGRIVnliaUJ6Wld4bUxtVnpkR0ZrYjE5amIyNTBjbUYwYndvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbVZ6ZEdGa2IxOWpiMjUwY21GMGJ5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVsYzNSaFpHOWZZMjl1ZEhKaGRHOGdaWGhwYzNSekNpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11ZG05MGJ6TXVZMjl1ZEhKaFkzUXVWbTkwYnpNdVpYTjBZV0pzWldObGNsOWxjM1JoWkc5ZlkyOXVkSEpoZEc4b2JuVmxkbTlmWlhOMFlXUnZPaUIxYVc1ME5qUXBJQzArSUhWcGJuUTJORG9LWlhOMFlXSnNaV05sY2w5bGMzUmhaRzlmWTI5dWRISmhkRzg2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbTkwYnpNdlkyOXVkSEpoWTNRdWNIazZPVFV0T1RZS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb1lXeHNiM2RmWVdOMGFXOXVjejFiSWs1dlQzQWlYU2tLSUNBZ0lDOHZJR1JsWmlCbGMzUmhZbXhsWTJWeVgyVnpkR0ZrYjE5amIyNTBjbUYwYnloelpXeG1MQ0J1ZFdWMmIxOWxjM1JoWkc4NklGVkpiblEyTkNrZ0xUNGdWVWx1ZERZME9nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbTkwYnpNdlkyOXVkSEpoWTNRdWNIazZPVGdLSUNBZ0lDOHZJRlI0Ymk1elpXNWtaWElnUFQwZ1IyeHZZbUZzTG1OeVpXRjBiM0pmWVdSa2NtVnpjd29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWjJ4dlltRnNJRU55WldGMGIzSkJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1p2ZEc4ekwyTnZiblJ5WVdOMExuQjVPamszTFRrNUNpQWdJQ0F2THlCaGMzTmxjblFnS0FvZ0lDQWdMeThnSUNBZ0lGUjRiaTV6Wlc1a1pYSWdQVDBnUjJ4dlltRnNMbU55WldGMGIzSmZZV1JrY21WemN3b2dJQ0FnTHk4Z0tTd2dJbE52Ykc4Z1pXd2dZM0psWVdSdmNpQndkV1ZrWlNCbGMzUmhZbXhsWTJWeUlHVnNJR1Z6ZEdGa2J5QmtaV3dnWTI5dWRISmhkRzhpQ2lBZ0lDQmhjM05sY25RZ0x5OGdVMjlzYnlCbGJDQmpjbVZoWkc5eUlIQjFaV1JsSUdWemRHRmliR1ZqWlhJZ1pXd2daWE4wWVdSdklHUmxiQ0JqYjI1MGNtRjBid29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzWnZkRzh6TDJOdmJuUnlZV04wTG5CNU9qRXdNQW9nSUNBZ0x5OGdjMlZzWmk1bGMzUmhaRzlmWTI5dWRISmhkRzhnUFNCdWRXVjJiMTlsYzNSaFpHOEtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltVnpkR0ZrYjE5amIyNTBjbUYwYnlJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyYjNSdk15OWpiMjUwY21GamRDNXdlVG94TURFS0lDQWdJQzh2SUhKbGRIVnliaUJ6Wld4bUxtVnpkR0ZrYjE5amIyNTBjbUYwYndvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVkbTkwYnpNdVkyOXVkSEpoWTNRdVZtOTBiek11WVdKeWFYSmZjbVZuYVhOMGNtOWZZMjl0Y0hKdmJXbHpiM01vS1NBdFBpQjJiMmxrT2dwaFluSnBjbDl5WldkcGMzUnliMTlqYjIxd2NtOXRhWE52Y3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyYjNSdk15OWpiMjUwY21GamRDNXdlVG94TURnS0lDQWdJQzh2SUZSNGJpNXpaVzVrWlhJZ1BUMGdSMnh2WW1Gc0xtTnlaV0YwYjNKZllXUmtjbVZ6Y3dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1oyeHZZbUZzSUVOeVpXRjBiM0pCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNadmRHOHpMMk52Ym5SeVlXTjBMbkI1T2pFd055MHhNRGtLSUNBZ0lDOHZJR0Z6YzJWeWRDQW9DaUFnSUNBdkx5QWdJQ0FnVkhodUxuTmxibVJsY2lBOVBTQkhiRzlpWVd3dVkzSmxZWFJ2Y2w5aFpHUnlaWE56Q2lBZ0lDQXZMeUFwTENBaVUyOXNieUJsYkNCamNtVmhaRzl5SUhCMVpXUmxJR0ZpY21seUlHVnNJSEpsWjJsemRISnZJR1JsSUdOdmJYQnliMjFwYzI5eklnb2dJQ0FnWVhOelpYSjBJQzh2SUZOdmJHOGdaV3dnWTNKbFlXUnZjaUJ3ZFdWa1pTQmhZbkpwY2lCbGJDQnlaV2RwYzNSeWJ5QmtaU0JqYjIxd2NtOXRhWE52Y3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1p2ZEc4ekwyTnZiblJ5WVdOMExuQjVPakV4TUFvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdVpYTjBZV1J2WDJOdmJuUnlZWFJ2SUQwOUlGVkpiblEyTkNnS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0psYzNSaFpHOWZZMjl1ZEhKaGRHOGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WlhOMFlXUnZYMk52Ym5SeVlYUnZJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNadmRHOHpMMk52Ym5SeVlXTjBMbkI1T2pFeE1DMHhNVElLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG1WemRHRmtiMTlqYjI1MGNtRjBieUE5UFNCVlNXNTBOalFvQ2lBZ0lDQXZMeUFnSUNBZ01Rb2dJQ0FnTHk4Z0tTd2dJa1ZzSUdOdmJuUnlZWFJ2SUc1dklHVnpkTU9oSUdWdUlHVnNJR1Z6ZEdGa2J5QmpiM0p5WldOMGJ5SUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRVZzSUdOdmJuUnlZWFJ2SUc1dklHVnpkTU9oSUdWdUlHVnNJR1Z6ZEdGa2J5QmpiM0p5WldOMGJ3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNadmRHOHpMMk52Ym5SeVlXTjBMbkI1T2pFeE13b2dJQ0FnTHk4Z2MyVnNaaTVsYzNSaFpHOWZZMjl1ZEhKaGRHOGdQU0JWU1c1ME5qUW9NaWtLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbVZ6ZEdGa2IxOWpiMjUwY21GMGJ5SUtJQ0FnSUhCMWMyaHBiblFnTWlBdkx5QXlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuWnZkRzh6TG1OdmJuUnlZV04wTGxadmRHOHpMbkpsWjJsemRISmhjbDlqYjIxd2NtOXRhWE52S0NrZ0xUNGdkV2x1ZERZME9ncHlaV2RwYzNSeVlYSmZZMjl0Y0hKdmJXbHpiem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTJiM1J2TXk5amIyNTBjbUZqZEM1d2VUb3hNVGdLSUNBZ0lDOHZJRlI0Ymk1elpXNWtaWElnUFQwZ1IyeHZZbUZzTG1OeVpXRjBiM0pmWVdSa2NtVnpjd29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWjJ4dlltRnNJRU55WldGMGIzSkJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1p2ZEc4ekwyTnZiblJ5WVdOMExuQjVPakV4TnkweE1Ua0tJQ0FnSUM4dklHRnpjMlZ5ZENBb0NpQWdJQ0F2THlBZ0lDQWdWSGh1TG5ObGJtUmxjaUE5UFNCSGJHOWlZV3d1WTNKbFlYUnZjbDloWkdSeVpYTnpDaUFnSUNBdkx5QXBMQ0FpVTI5c2J5QmxiQ0JqY21WaFpHOXlJSEIxWldSbElISmxaMmx6ZEhKaGNpQmpiMjF3Y205dGFYTnZjeUlLSUNBZ0lHRnpjMlZ5ZENBdkx5QlRiMnh2SUdWc0lHTnlaV0ZrYjNJZ2NIVmxaR1VnY21WbmFYTjBjbUZ5SUdOdmJYQnliMjFwYzI5ekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZG05MGJ6TXZZMjl1ZEhKaFkzUXVjSGs2TVRJd0NpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNWxjM1JoWkc5ZlkyOXVkSEpoZEc4Z1BUMGdWVWx1ZERZMEtBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1WemRHRmtiMTlqYjI1MGNtRjBieUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1bGMzUmhaRzlmWTI5dWRISmhkRzhnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtOTBiek12WTI5dWRISmhZM1F1Y0hrNk1USXdMVEV5TWdvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdVpYTjBZV1J2WDJOdmJuUnlZWFJ2SUQwOUlGVkpiblEyTkNnS0lDQWdJQzh2SUNBZ0lDQXlDaUFnSUNBdkx5QXBMQ0FpUld3Z1kyOXVkSEpoZEc4Z2JtOGdaWE4wdzZFZ1pXNGdaV3dnWlhOMFlXUnZJR052Y25KbFkzUnZJZ29nSUNBZ2NIVnphR2x1ZENBeUlDOHZJRElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1JXd2dZMjl1ZEhKaGRHOGdibThnWlhOMHc2RWdaVzRnWld3Z1pYTjBZV1J2SUdOdmNuSmxZM1J2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbTkwYnpNdlkyOXVkSEpoWTNRdWNIazZNVEl6Q2lBZ0lDQXZMeUIyWVd4dmNsOWhZM1IxWVd3Z1BTQnpaV3htTG1OdmJuUmhaRzl5WDJOdmJYQnliMjFwYzI5ekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk15QXZMeUFpWTI5dWRHRmtiM0pmWTI5dGNISnZiV2x6YjNNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZMjl1ZEdGa2IzSmZZMjl0Y0hKdmJXbHpiM01nWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtOTBiek12WTI5dWRISmhZM1F1Y0hrNk1USTBDaUFnSUNBdkx5QnpaV3htTG1OdmJuUmhaRzl5WDJOdmJYQnliMjFwYzI5eklEMGdkbUZzYjNKZllXTjBkV0ZzSUNzZ01Rb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbU52Ym5SaFpHOXlYMk52YlhCeWIyMXBjMjl6SWdvZ0lDQWdaR2xuSURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZG05MGJ6TXZZMjl1ZEhKaFkzUXVjSGs2TVRJMUNpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNWpiMjUwWVdSdmNsOWpiMjF3Y205dGFYTnZjd29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuWnZkRzh6TG1OdmJuUnlZV04wTGxadmRHOHpMbU5sY25KaGNsOXlaV2RwYzNSeWIxOWpiMjF3Y205dGFYTnZjeWdwSUMwK0lIVnBiblEyTkRvS1kyVnljbUZ5WDNKbFoybHpkSEp2WDJOdmJYQnliMjFwYzI5ek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNadmRHOHpMMk52Ym5SeVlXTjBMbkI1T2pFek1Bb2dJQ0FnTHk4Z1ZIaHVMbk5sYm1SbGNpQTlQU0JIYkc5aVlXd3VZM0psWVhSdmNsOWhaR1J5WlhOekNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQm5iRzlpWVd3Z1EzSmxZWFJ2Y2tGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtOTBiek12WTI5dWRISmhZM1F1Y0hrNk1USTVMVEV6TVFvZ0lDQWdMeThnWVhOelpYSjBJQ2dLSUNBZ0lDOHZJQ0FnSUNCVWVHNHVjMlZ1WkdWeUlEMDlJRWRzYjJKaGJDNWpjbVZoZEc5eVgyRmtaSEpsYzNNS0lDQWdJQzh2SUNrc0lDSlRiMnh2SUdWc0lHTnlaV0ZrYjNJZ2NIVmxaR1VnWTJWeWNtRnlJR1ZzSUhKbFoybHpkSEp2SUdSbElHTnZiWEJ5YjIxcGMyOXpJZ29nSUNBZ1lYTnpaWEowSUM4dklGTnZiRzhnWld3Z1kzSmxZV1J2Y2lCd2RXVmtaU0JqWlhKeVlYSWdaV3dnY21WbmFYTjBjbThnWkdVZ1kyOXRjSEp2YldsemIzTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MmIzUnZNeTlqYjI1MGNtRmpkQzV3ZVRveE16SUtJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MbVZ6ZEdGa2IxOWpiMjUwY21GMGJ5QTlQU0JWU1c1ME5qUW9DaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVpYTjBZV1J2WDJOdmJuUnlZWFJ2SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtVnpkR0ZrYjE5amIyNTBjbUYwYnlCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTJiM1J2TXk5amIyNTBjbUZqZEM1d2VUb3hNekl0TVRNMENpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNWxjM1JoWkc5ZlkyOXVkSEpoZEc4Z1BUMGdWVWx1ZERZMEtBb2dJQ0FnTHk4Z0lDQWdJRElLSUNBZ0lDOHZJQ2tzSUNKRmJDQmpiMjUwY21GMGJ5QnVieUJsYzNURG9TQmxiaUJsYkNCbGMzUmhaRzhnWTI5eWNtVmpkRzhpQ2lBZ0lDQndkWE5vYVc1MElESWdMeThnTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkZiQ0JqYjI1MGNtRjBieUJ1YnlCbGMzVERvU0JsYmlCbGJDQmxjM1JoWkc4Z1kyOXljbVZqZEc4S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyYjNSdk15OWpiMjUwY21GamRDNXdlVG94TXpVS0lDQWdJQzh2SUhObGJHWXVaWE4wWVdSdlgyTnZiblJ5WVhSdklEMGdWVWx1ZERZMEtETXBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmxjM1JoWkc5ZlkyOXVkSEpoZEc4aUNpQWdJQ0JwYm5Salh6TWdMeThnTXdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyYjNSdk15OWpiMjUwY21GamRDNXdlVG94TXpZS0lDQWdJQzh2SUhKbGRIVnliaUJ6Wld4bUxtTnZiblJoWkc5eVgyTnZiWEJ5YjIxcGMyOXpDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaVkyOXVkR0ZrYjNKZlkyOXRjSEp2YldsemIzTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WTI5dWRHRmtiM0pmWTI5dGNISnZiV2x6YjNNZ1pYaHBjM1J6Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVkbTkwYnpNdVkyOXVkSEpoWTNRdVZtOTBiek11WVdKeWFYSmZjbVZuYVhOMGNtOWZjbUZwWTJWektHNTFiVjlpYkc5eGRXVnpPaUIxYVc1ME5qUXNJSFJoYlY5aWJHOXhkV1U2SUhWcGJuUTJOQ3dnZEdGdFgzSmxjM1J2T2lCMWFXNTBOalFwSUMwK0lIWnZhV1E2Q21GaWNtbHlYM0psWjJsemRISnZYM0poYVdObGN6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MmIzUnZNeTlqYjI1MGNtRmpkQzV3ZVRveE5EQXRNVFF6Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJQzh2SUdSbFppQmhZbkpwY2w5eVpXZHBjM1J5YjE5eVlXbGpaWE1vQ2lBZ0lDQXZMeUFnSUNBZ2MyVnNaaXdnYm5WdFgySnNiM0YxWlhNNklGVkpiblEyTkN3Z2RHRnRYMkpzYjNGMVpUb2dWVWx1ZERZMExDQjBZVzFmY21WemRHODZJRlZKYm5RMk5Bb2dJQ0FnTHk4Z0tTQXRQaUJPYjI1bE9nb2dJQ0FnY0hKdmRHOGdNeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbTkwYnpNdlkyOXVkSEpoWTNRdWNIazZNVFExQ2lBZ0lDQXZMeUJVZUc0dWMyVnVaR1Z5SUQwOUlFZHNiMkpoYkM1amNtVmhkRzl5WDJGa1pISmxjM01LSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdkc2IySmhiQ0JEY21WaGRHOXlRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyYjNSdk15OWpiMjUwY21GamRDNXdlVG94TkRRdE1UUTJDaUFnSUNBdkx5QmhjM05sY25RZ0tBb2dJQ0FnTHk4Z0lDQWdJRlI0Ymk1elpXNWtaWElnUFQwZ1IyeHZZbUZzTG1OeVpXRjBiM0pmWVdSa2NtVnpjd29nSUNBZ0x5OGdLU3dnSWxOdmJHOGdaV3dnWTNKbFlXUnZjaUJ3ZFdWa1pTQmhZbkpwY2lCbGJDQnlaV2RwYzNSeWJ5QmtaU0J5WWNPdFkyVnpJZ29nSUNBZ1lYTnpaWEowSUM4dklGTnZiRzhnWld3Z1kzSmxZV1J2Y2lCd2RXVmtaU0JoWW5KcGNpQmxiQ0J5WldkcGMzUnlieUJrWlNCeVljT3RZMlZ6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbTkwYnpNdlkyOXVkSEpoWTNRdWNIazZNVFEzQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1bGMzUmhaRzlmWTI5dWRISmhkRzhnUFQwZ1ZVbHVkRFkwS0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbVZ6ZEdGa2IxOWpiMjUwY21GMGJ5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVsYzNSaFpHOWZZMjl1ZEhKaGRHOGdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZG05MGJ6TXZZMjl1ZEhKaFkzUXVjSGs2TVRRM0xURTBPUW9nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1WlhOMFlXUnZYMk52Ym5SeVlYUnZJRDA5SUZWSmJuUTJOQ2dLSUNBZ0lDOHZJQ0FnSUNBekNpQWdJQ0F2THlBcExDQWlSV3dnWTI5dWRISmhkRzhnYm04Z1pYTjB3NkVnWlc0Z1pXd2daWE4wWVdSdklHTnZjbkpsWTNSdklnb2dJQ0FnYVc1MFkxOHpJQzh2SURNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdSV3dnWTI5dWRISmhkRzhnYm04Z1pYTjB3NkVnWlc0Z1pXd2daWE4wWVdSdklHTnZjbkpsWTNSdkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZG05MGJ6TXZZMjl1ZEhKaFkzUXVjSGs2TVRVd0NpQWdJQ0F2THlCelpXeG1MbTUxYlY5aWJHOXhkV1Z6SUQwZ2JuVnRYMkpzYjNGMVpYTUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z0ltNTFiVjlpYkc5eGRXVnpJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzWnZkRzh6TDJOdmJuUnlZV04wTG5CNU9qRTFNUW9nSUNBZ0x5OGdjMlZzWmk1MFlXMWZZbXh2Y1hWbElEMGdkR0Z0WDJKc2IzRjFaUW9nSUNBZ1lubDBaV01nT0NBdkx5QWlkR0Z0WDJKc2IzRjFaU0lLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTJiM1J2TXk5amIyNTBjbUZqZEM1d2VUb3hOVElLSUNBZ0lDOHZJSE5sYkdZdWRHRnRYM0psYzNSdklEMGdkR0Z0WDNKbGMzUnZDaUFnSUNCaWVYUmxZeUE1SUM4dklDSjBZVzFmY21WemRHOGlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtOTBiek12WTI5dWRISmhZM1F1Y0hrNk1UVXpDaUFnSUNBdkx5QnpaV3htTG1WemRHRmtiMTlqYjI1MGNtRjBieUE5SUZWSmJuUTJOQ2cwS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWlhOMFlXUnZYMk52Ym5SeVlYUnZJZ29nSUNBZ2FXNTBZMTh5SUM4dklEUUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWRtOTBiek11WTI5dWRISmhZM1F1Vm05MGJ6TXVjbVZuYVhOMGNtRnlYM0poYVhvb0tTQXRQaUIxYVc1ME5qUTZDbkpsWjJsemRISmhjbDl5WVdsNk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNadmRHOHpMMk52Ym5SeVlXTjBMbkI1T2pFMU9Bb2dJQ0FnTHk4Z1ZIaHVMbk5sYm1SbGNpQTlQU0JIYkc5aVlXd3VZM0psWVhSdmNsOWhaR1J5WlhOekNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQm5iRzlpWVd3Z1EzSmxZWFJ2Y2tGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtOTBiek12WTI5dWRISmhZM1F1Y0hrNk1UVTNMVEUxT1FvZ0lDQWdMeThnWVhOelpYSjBJQ2dLSUNBZ0lDOHZJQ0FnSUNCVWVHNHVjMlZ1WkdWeUlEMDlJRWRzYjJKaGJDNWpjbVZoZEc5eVgyRmtaSEpsYzNNS0lDQWdJQzh2SUNrc0lDSlRiMnh2SUdWc0lHTnlaV0ZrYjNJZ2NIVmxaR1VnY21WbmFYTjBjbUZ5SUhKaHc2MWpaWE1pQ2lBZ0lDQmhjM05sY25RZ0x5OGdVMjlzYnlCbGJDQmpjbVZoWkc5eUlIQjFaV1JsSUhKbFoybHpkSEpoY2lCeVljT3RZMlZ6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbTkwYnpNdlkyOXVkSEpoWTNRdWNIazZNVFl3Q2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1bGMzUmhaRzlmWTI5dWRISmhkRzhnUFQwZ1ZVbHVkRFkwS0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbVZ6ZEdGa2IxOWpiMjUwY21GMGJ5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVsYzNSaFpHOWZZMjl1ZEhKaGRHOGdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZG05MGJ6TXZZMjl1ZEhKaFkzUXVjSGs2TVRZd0xURTJNZ29nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1WlhOMFlXUnZYMk52Ym5SeVlYUnZJRDA5SUZWSmJuUTJOQ2dLSUNBZ0lDOHZJQ0FnSUNBMENpQWdJQ0F2THlBcExDQWlSV3dnWTI5dWRISmhkRzhnYm04Z1pYTjB3NkVnWlc0Z1pXd2daWE4wWVdSdklHTnZjbkpsWTNSdklnb2dJQ0FnYVc1MFkxOHlJQzh2SURRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdSV3dnWTI5dWRISmhkRzhnYm04Z1pYTjB3NkVnWlc0Z1pXd2daWE4wWVdSdklHTnZjbkpsWTNSdkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZG05MGJ6TXZZMjl1ZEhKaFkzUXVjSGs2TVRZekNpQWdJQ0F2THlCMllXeHZjbDloWTNSMVlXd2dQU0J6Wld4bUxtTnZiblJoWkc5eVgzSmhhV05sY3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbU52Ym5SaFpHOXlYM0poYVdObGN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVqYjI1MFlXUnZjbDl5WVdsalpYTWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZG05MGJ6TXZZMjl1ZEhKaFkzUXVjSGs2TVRZMENpQWdJQ0F2THlCelpXeG1MbU52Ym5SaFpHOXlYM0poYVdObGN5QTlJSFpoYkc5eVgyRmpkSFZoYkNBcklERUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0pqYjI1MFlXUnZjbDl5WVdsalpYTWlDaUFnSUNCa2FXY2dNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTJiM1J2TXk5amIyNTBjbUZqZEM1d2VUb3hOalVLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG1OdmJuUmhaRzl5WDNKaGFXTmxjd29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuWnZkRzh6TG1OdmJuUnlZV04wTGxadmRHOHpMbU5sY25KaGNsOXlaV2RwYzNSeWIxOXlZV2xqWlhNb2RIaHVTV1JmY21GcGVqb2dZbmwwWlhNcElDMCtJSFZwYm5RMk5Eb0tZMlZ5Y21GeVgzSmxaMmx6ZEhKdlgzSmhhV05sY3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyYjNSdk15OWpiMjUwY21GamRDNXdlVG94TmpjdE1UWTRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lDOHZJR1JsWmlCalpYSnlZWEpmY21WbmFYTjBjbTlmY21GcFkyVnpLSE5sYkdZc0lIUjRia2xrWDNKaGFYbzZJRk4wY21sdVp5a2dMVDRnVlVsdWREWTBPZ29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZG05MGJ6TXZZMjl1ZEhKaFkzUXVjSGs2TVRjd0NpQWdJQ0F2THlCVWVHNHVjMlZ1WkdWeUlEMDlJRWRzYjJKaGJDNWpjbVZoZEc5eVgyRmtaSEpsYzNNS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHZHNiMkpoYkNCRGNtVmhkRzl5UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MmIzUnZNeTlqYjI1MGNtRmpkQzV3ZVRveE5qa3RNVGN4Q2lBZ0lDQXZMeUJoYzNObGNuUWdLQW9nSUNBZ0x5OGdJQ0FnSUZSNGJpNXpaVzVrWlhJZ1BUMGdSMnh2WW1Gc0xtTnlaV0YwYjNKZllXUmtjbVZ6Y3dvZ0lDQWdMeThnS1N3Z0lsTnZiRzhnWld3Z1kzSmxZV1J2Y2lCd2RXVmtaU0JqWlhKeVlYSWdaV3dnY21WbmFYTjBjbThnWkdVZ2NtSERyV05sY3lJS0lDQWdJR0Z6YzJWeWRDQXZMeUJUYjJ4dklHVnNJR055WldGa2IzSWdjSFZsWkdVZ1kyVnljbUZ5SUdWc0lISmxaMmx6ZEhKdklHUmxJSEpodzYxalpYTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MmIzUnZNeTlqYjI1MGNtRmpkQzV3ZVRveE56SUtJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MbVZ6ZEdGa2IxOWpiMjUwY21GMGJ5QTlQU0JWU1c1ME5qUW9DaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVpYTjBZV1J2WDJOdmJuUnlZWFJ2SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtVnpkR0ZrYjE5amIyNTBjbUYwYnlCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTJiM1J2TXk5amIyNTBjbUZqZEM1d2VUb3hOekl0TVRjMENpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNWxjM1JoWkc5ZlkyOXVkSEpoZEc4Z1BUMGdWVWx1ZERZMEtBb2dJQ0FnTHk4Z0lDQWdJRFFLSUNBZ0lDOHZJQ2tzSUNKRmJDQmpiMjUwY21GMGJ5QnVieUJsYzNURG9TQmxiaUJsYkNCbGMzUmhaRzhnWTI5eWNtVmpkRzhpQ2lBZ0lDQnBiblJqWHpJZ0x5OGdOQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCRmJDQmpiMjUwY21GMGJ5QnVieUJsYzNURG9TQmxiaUJsYkNCbGMzUmhaRzhnWTI5eWNtVmpkRzhLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTJiM1J2TXk5amIyNTBjbUZqZEM1d2VUb3hOelVLSUNBZ0lDOHZJSE5sYkdZdVpYTjBZV1J2WDJOdmJuUnlZWFJ2SUQwZ1ZVbHVkRFkwS0RVcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKbGMzUmhaRzlmWTI5dWRISmhkRzhpQ2lBZ0lDQndkWE5vYVc1MElEVWdMeThnTlFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyYjNSdk15OWpiMjUwY21GamRDNXdlVG94TnpZS0lDQWdJQzh2SUhObGJHWXVkSGh1U1dSZmNtRnBlaUE5SUhSNGJrbGtYM0poYVhvS0lDQWdJR0o1ZEdWaklERXdJQzh2SUNKMGVHNUpaRjl5WVdsNklnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNadmRHOHpMMk52Ym5SeVlXTjBMbkI1T2pFM053b2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVZMjl1ZEdGa2IzSmZjbUZwWTJWekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWTI5dWRHRmtiM0pmY21GcFkyVnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1OdmJuUmhaRzl5WDNKaGFXTmxjeUJsZUdsemRITUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1MmIzUnZNeTVqYjI1MGNtRmpkQzVXYjNSdk15NXNaV1Z5WDJSaGRHOXpYM0poYVdObGN5Z3BJQzArSUhWcGJuUTJOQ3dnZFdsdWREWTBMQ0IxYVc1ME5qUXNJR0o1ZEdWek9ncHNaV1Z5WDJSaGRHOXpYM0poYVdObGN6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MmIzUnZNeTlqYjI1MGNtRmpkQzV3ZVRveE9ERUtJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MbVZ6ZEdGa2IxOWpiMjUwY21GMGJ5QStQU0JWU1c1ME5qUW9DaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVpYTjBZV1J2WDJOdmJuUnlZWFJ2SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtVnpkR0ZrYjE5amIyNTBjbUYwYnlCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTJiM1J2TXk5amIyNTBjbUZqZEM1d2VUb3hPREV0TVRnekNpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNWxjM1JoWkc5ZlkyOXVkSEpoZEc4Z1BqMGdWVWx1ZERZMEtBb2dJQ0FnTHk4Z0lDQWdJRFVLSUNBZ0lDOHZJQ2tzSUNKRmJDQmpiMjUwY21GMGJ5QnVieUJsYzNURG9TQmxiaUJsYkNCbGMzUmhaRzhnWTI5eWNtVmpkRzhpQ2lBZ0lDQndkWE5vYVc1MElEVWdMeThnTlFvZ0lDQWdQajBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkZiQ0JqYjI1MGNtRjBieUJ1YnlCbGMzVERvU0JsYmlCbGJDQmxjM1JoWkc4Z1kyOXljbVZqZEc4S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyYjNSdk15OWpiMjUwY21GamRDNXdlVG94T0RRS0lDQWdJQzh2SUhKbGRIVnliaUFvYzJWc1ppNXVkVzFmWW14dmNYVmxjeXdnYzJWc1ppNTBZVzFmWW14dmNYVmxMQ0J6Wld4bUxuUmhiVjl5WlhOMGJ5d2djMlZzWmk1MGVHNUpaRjl5WVdsNktRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEY2dMeThnSW01MWJWOWliRzl4ZFdWeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbTUxYlY5aWJHOXhkV1Z6SUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z0luUmhiVjlpYkc5eGRXVWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEdGdFgySnNiM0YxWlNCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUE1SUM4dklDSjBZVzFmY21WemRHOGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEdGdFgzSmxjM1J2SUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREV3SUM4dklDSjBlRzVKWkY5eVlXbDZJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SNGJrbGtYM0poYVhvZ1pYaHBjM1J6Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVkbTkwYnpNdVkyOXVkSEpoWTNRdVZtOTBiek11WVdKeWFYSmZjbVZuYVhOMGNtOWZZVzUxYkdGa2IzSmxjeWdwSUMwK0lIWnZhV1E2Q21GaWNtbHlYM0psWjJsemRISnZYMkZ1ZFd4aFpHOXlaWE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbTkwYnpNdlkyOXVkSEpoWTNRdWNIazZNVGt5Q2lBZ0lDQXZMeUJVZUc0dWMyVnVaR1Z5SUQwOUlFZHNiMkpoYkM1amNtVmhkRzl5WDJGa1pISmxjM01LSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdkc2IySmhiQ0JEY21WaGRHOXlRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyYjNSdk15OWpiMjUwY21GamRDNXdlVG94T1RFdE1Ua3pDaUFnSUNBdkx5QmhjM05sY25RZ0tBb2dJQ0FnTHk4Z0lDQWdJRlI0Ymk1elpXNWtaWElnUFQwZ1IyeHZZbUZzTG1OeVpXRjBiM0pmWVdSa2NtVnpjd29nSUNBZ0x5OGdLU3dnSWxOdmJHOGdaV3dnWTNKbFlXUnZjaUJ3ZFdWa1pTQmhZbkpwY2lCbGJDQnlaV2RwYzNSeWJ5QmtaU0JoYm5Wc1lXUnZjbVZ6SWdvZ0lDQWdZWE56WlhKMElDOHZJRk52Ykc4Z1pXd2dZM0psWVdSdmNpQndkV1ZrWlNCaFluSnBjaUJsYkNCeVpXZHBjM1J5YnlCa1pTQmhiblZzWVdSdmNtVnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtOTBiek12WTI5dWRISmhZM1F1Y0hrNk1UazBDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTVsYzNSaFpHOWZZMjl1ZEhKaGRHOGdQVDBnVlVsdWREWTBLQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltVnpkR0ZrYjE5amIyNTBjbUYwYnlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWxjM1JoWkc5ZlkyOXVkSEpoZEc4Z1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbTkwYnpNdlkyOXVkSEpoWTNRdWNIazZNVGswTFRFNU5nb2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVaWE4wWVdSdlgyTnZiblJ5WVhSdklEMDlJRlZKYm5RMk5DZ0tJQ0FnSUM4dklDQWdJQ0ExQ2lBZ0lDQXZMeUFwTENBaVJXd2dZMjl1ZEhKaGRHOGdibThnWlhOMHc2RWdaVzRnWld3Z1pYTjBZV1J2SUdOdmNuSmxZM1J2SWdvZ0lDQWdjSFZ6YUdsdWRDQTFJQzh2SURVS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdSV3dnWTI5dWRISmhkRzhnYm04Z1pYTjB3NkVnWlc0Z1pXd2daWE4wWVdSdklHTnZjbkpsWTNSdkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZG05MGJ6TXZZMjl1ZEhKaFkzUXVjSGs2TVRrM0NpQWdJQ0F2THlCelpXeG1MbVZ6ZEdGa2IxOWpiMjUwY21GMGJ5QTlJRlZKYm5RMk5DZzJLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlaWE4wWVdSdlgyTnZiblJ5WVhSdklnb2dJQ0FnY0hWemFHbHVkQ0EySUM4dklEWUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWRtOTBiek11WTI5dWRISmhZM1F1Vm05MGJ6TXVjbVZuYVhOMGNtRnlYMkZ1ZFd4aFpHOXlLQ2tnTFQ0Z2RXbHVkRFkwT2dweVpXZHBjM1J5WVhKZllXNTFiR0ZrYjNJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZG05MGJ6TXZZMjl1ZEhKaFkzUXVjSGs2TWpBeUNpQWdJQ0F2THlCVWVHNHVjMlZ1WkdWeUlEMDlJRWRzYjJKaGJDNWpjbVZoZEc5eVgyRmtaSEpsYzNNS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHZHNiMkpoYkNCRGNtVmhkRzl5UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MmIzUnZNeTlqYjI1MGNtRmpkQzV3ZVRveU1ERXRNakF6Q2lBZ0lDQXZMeUJoYzNObGNuUWdLQW9nSUNBZ0x5OGdJQ0FnSUZSNGJpNXpaVzVrWlhJZ1BUMGdSMnh2WW1Gc0xtTnlaV0YwYjNKZllXUmtjbVZ6Y3dvZ0lDQWdMeThnS1N3Z0lsTnZiRzhnWld3Z1kzSmxZV1J2Y2lCd2RXVmtaU0J5WldkcGMzUnlZWElnWVc1MWJHRmtiM0psY3lJS0lDQWdJR0Z6YzJWeWRDQXZMeUJUYjJ4dklHVnNJR055WldGa2IzSWdjSFZsWkdVZ2NtVm5hWE4wY21GeUlHRnVkV3hoWkc5eVpYTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MmIzUnZNeTlqYjI1MGNtRmpkQzV3ZVRveU1EUUtJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MbVZ6ZEdGa2IxOWpiMjUwY21GMGJ5QTlQU0JWU1c1ME5qUW9DaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVpYTjBZV1J2WDJOdmJuUnlZWFJ2SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtVnpkR0ZrYjE5amIyNTBjbUYwYnlCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTJiM1J2TXk5amIyNTBjbUZqZEM1d2VUb3lNRFF0TWpBMkNpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNWxjM1JoWkc5ZlkyOXVkSEpoZEc4Z1BUMGdWVWx1ZERZMEtBb2dJQ0FnTHk4Z0lDQWdJRFlLSUNBZ0lDOHZJQ2tzSUNKRmJDQmpiMjUwY21GMGJ5QnVieUJsYzNURG9TQmxiaUJsYkNCbGMzUmhaRzhnWTI5eWNtVmpkRzhpQ2lBZ0lDQndkWE5vYVc1MElEWWdMeThnTmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkZiQ0JqYjI1MGNtRjBieUJ1YnlCbGMzVERvU0JsYmlCbGJDQmxjM1JoWkc4Z1kyOXljbVZqZEc4S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyYjNSdk15OWpiMjUwY21GamRDNXdlVG95TURjS0lDQWdJQzh2SUhaaGJHOXlYMkZqZEhWaGJDQTlJSE5sYkdZdVkyOXVkR0ZrYjNKZllXNTFiR0ZrYjNKbGN3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEVWdMeThnSW1OdmJuUmhaRzl5WDJGdWRXeGhaRzl5WlhNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZMjl1ZEdGa2IzSmZZVzUxYkdGa2IzSmxjeUJsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MmIzUnZNeTlqYjI1MGNtRmpkQzV3ZVRveU1EZ0tJQ0FnSUM4dklITmxiR1l1WTI5dWRHRmtiM0pmWVc1MWJHRmtiM0psY3lBOUlIWmhiRzl5WDJGamRIVmhiQ0FySURFS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZeUExSUM4dklDSmpiMjUwWVdSdmNsOWhiblZzWVdSdmNtVnpJZ29nSUNBZ1pHbG5JREVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbTkwYnpNdlkyOXVkSEpoWTNRdWNIazZNakE1Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1amIyNTBZV1J2Y2w5aGJuVnNZV1J2Y21WekNpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11ZG05MGJ6TXVZMjl1ZEhKaFkzUXVWbTkwYnpNdVpXNTJhV0Z5WDNCaGNHVnNaWFJoS0dSbGMzUnBibUYwWVhKcGJ6b2dZbmwwWlhNcElDMCtJSFZwYm5RMk5Eb0taVzUyYVdGeVgzQmhjR1ZzWlhSaE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNadmRHOHpMMk52Ym5SeVlXTjBMbkI1T2pJeE1TMHlNVElLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdMeThnWkdWbUlHVnVkbWxoY2w5d1lYQmxiR1YwWVNoelpXeG1MQ0JrWlhOMGFXNWhkR0Z5YVc4NklFSjVkR1Z6S1NBdFBpQlZTVzUwTmpRNkNpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTJiM1J2TXk5amIyNTBjbUZqZEM1d2VUb3lNVFFLSUNBZ0lDOHZJRlI0Ymk1elpXNWtaWElnUFQwZ1IyeHZZbUZzTG1OeVpXRjBiM0pmWVdSa2NtVnpjd29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWjJ4dlltRnNJRU55WldGMGIzSkJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1p2ZEc4ekwyTnZiblJ5WVdOMExuQjVPakl4TXkweU1UVUtJQ0FnSUM4dklHRnpjMlZ5ZENBb0NpQWdJQ0F2THlBZ0lDQWdWSGh1TG5ObGJtUmxjaUE5UFNCSGJHOWlZV3d1WTNKbFlYUnZjbDloWkdSeVpYTnpDaUFnSUNBdkx5QXBMQ0FpVTI5c2J5QmxiQ0JqY21WaFpHOXlJSEIxWldSbElHVnVkbWxoY2lCd1lYQmxiR1YwWVhNaUNpQWdJQ0JoYzNObGNuUWdMeThnVTI5c2J5QmxiQ0JqY21WaFpHOXlJSEIxWldSbElHVnVkbWxoY2lCd1lYQmxiR1YwWVhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyYjNSdk15OWpiMjUwY21GamRDNXdlVG95TVRZS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxtVnpkR0ZrYjE5amIyNTBjbUYwYnlBOVBTQlZTVzUwTmpRb0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWlhOMFlXUnZYMk52Ym5SeVlYUnZJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1WemRHRmtiMTlqYjI1MGNtRjBieUJsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MmIzUnZNeTlqYjI1MGNtRmpkQzV3ZVRveU1UWXRNakU0Q2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1bGMzUmhaRzlmWTI5dWRISmhkRzhnUFQwZ1ZVbHVkRFkwS0FvZ0lDQWdMeThnSUNBZ0lEWUtJQ0FnSUM4dklDa3NJQ0pGYkNCamIyNTBjbUYwYnlCdWJ5QmxjM1REb1NCbGJpQmxiQ0JsYzNSaFpHOGdZMjl5Y21WamRHOGlDaUFnSUNCd2RYTm9hVzUwSURZZ0x5OGdOZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCRmJDQmpiMjUwY21GMGJ5QnVieUJsYzNURG9TQmxiaUJsYkNCbGMzUmhaRzhnWTI5eWNtVmpkRzhLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTJiM1J2TXk5amIyNTBjbUZqZEM1d2VUb3lNakF0TWpJMkNpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFZISmhibk5tWlhJb0NpQWdJQ0F2THlBZ0lDQWdlR1psY2w5aGMzTmxkRDF6Wld4bUxuQmhjR1ZzWlhSaGN5NXBaQ3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjloYlc5MWJuUTlWVWx1ZERZMEtERXBMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYM0psWTJWcGRtVnlQVUZqWTI5MWJuUW9aR1Z6ZEdsdVlYUmhjbWx2S1N3S0lDQWdJQzh2SUNBZ0lDQnpaVzVrWlhJOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzWnZkRzh6TDJOdmJuUnlZV04wTG5CNU9qSXlNUW9nSUNBZ0x5OGdlR1psY2w5aGMzTmxkRDF6Wld4bUxuQmhjR1ZzWlhSaGN5NXBaQ3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSndZWEJsYkdWMFlYTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Y0dGd1pXeGxkR0Z6SUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzWnZkRzh6TDJOdmJuUnlZV04wTG5CNU9qSXlNd29nSUNBZ0x5OGdZWE56WlhSZmNtVmpaV2wyWlhJOVFXTmpiM1Z1ZENoa1pYTjBhVzVoZEdGeWFXOHBMQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1FXUmtjbVZ6Y3lCc1pXNW5kR2dnYVhNZ016SWdZbmwwWlhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyYjNSdk15OWpiMjUwY21GamRDNXdlVG95TWpRS0lDQWdJQzh2SUhObGJtUmxjajFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdVMlZ1WkdWeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUlNaV05sYVhabGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNadmRHOHpMMk52Ym5SeVlXTjBMbkI1T2pJeU1nb2dJQ0FnTHk4Z1lYTnpaWFJmWVcxdmRXNTBQVlZKYm5RMk5DZ3hLU3dLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwUVcxdmRXNTBDaUFnSUNCcGRIaHVYMlpwWld4a0lGaG1aWEpCYzNObGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNadmRHOHpMMk52Ym5SeVlXTjBMbkI1T2pJeU1Bb2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRGUnlZVzV6Wm1WeUtBb2dJQ0FnYVc1MFkxOHlJQzh2SUdGNFptVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZG05MGJ6TXZZMjl1ZEhKaFkzUXVjSGs2TWpJMUNpQWdJQ0F2THlCbVpXVTlWVWx1ZERZMEtEQXBMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtOTBiek12WTI5dWRISmhZM1F1Y0hrNk1qSXdMVEl5TmdvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdMeThnSUNBZ0lIaG1aWEpmWVhOelpYUTljMlZzWmk1d1lYQmxiR1YwWVhNdWFXUXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZZVzF2ZFc1MFBWVkpiblEyTkNneEtTd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXlaV05sYVhabGNqMUJZMk52ZFc1MEtHUmxjM1JwYm1GMFlYSnBieWtzQ2lBZ0lDQXZMeUFnSUNBZ2MyVnVaR1Z5UFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtOTBiek12WTI5dWRISmhZM1F1Y0hrNk1qSTRDaUFnSUNBdkx5QjJZV3h2Y2w5aFkzUjFZV3dnUFNCelpXeG1MbkJoY0dWc1pYUmhjMTlsYm5acFlXUmhjd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0luQmhjR1ZzWlhSaGMxOWxiblpwWVdSaGN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV3WVhCbGJHVjBZWE5mWlc1MmFXRmtZWE1nWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtOTBiek12WTI5dWRISmhZM1F1Y0hrNk1qSTVDaUFnSUNBdkx5QnpaV3htTG5CaGNHVnNaWFJoYzE5bGJuWnBZV1JoY3lBOUlIWmhiRzl5WDJGamRIVmhiQ0FySURFS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZeUEySUM4dklDSndZWEJsYkdWMFlYTmZaVzUyYVdGa1lYTWlDaUFnSUNCa2FXY2dNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTJiM1J2TXk5amIyNTBjbUZqZEM1d2VUb3lNekFLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG5CaGNHVnNaWFJoYzE5bGJuWnBZV1JoY3dvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMblp2ZEc4ekxtTnZiblJ5WVdOMExsWnZkRzh6TG1ObGNuSmhjbDl5WldkcGMzUnliMTloYm5Wc1lXUnZjbVZ6S0NrZ0xUNGdkV2x1ZERZME9ncGpaWEp5WVhKZmNtVm5hWE4wY205ZllXNTFiR0ZrYjNKbGN6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MmIzUnZNeTlqYjI1MGNtRmpkQzV3ZVRveU16VUtJQ0FnSUM4dklGUjRiaTV6Wlc1a1pYSWdQVDBnUjJ4dlltRnNMbU55WldGMGIzSmZZV1JrY21WemN3b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaMnh2WW1Gc0lFTnlaV0YwYjNKQlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzWnZkRzh6TDJOdmJuUnlZV04wTG5CNU9qSXpOQzB5TXpZS0lDQWdJQzh2SUdGemMyVnlkQ0FvQ2lBZ0lDQXZMeUFnSUNBZ1ZIaHVMbk5sYm1SbGNpQTlQU0JIYkc5aVlXd3VZM0psWVhSdmNsOWhaR1J5WlhOekNpQWdJQ0F2THlBcExDQWlVMjlzYnlCbGJDQmpjbVZoWkc5eUlIQjFaV1JsSUdObGNuSmhjaUJsYkNCeVpXZHBjM1J5YnlCa1pTQmhiblZzWVdSdmNtVnpJZ29nSUNBZ1lYTnpaWEowSUM4dklGTnZiRzhnWld3Z1kzSmxZV1J2Y2lCd2RXVmtaU0JqWlhKeVlYSWdaV3dnY21WbmFYTjBjbThnWkdVZ1lXNTFiR0ZrYjNKbGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNadmRHOHpMMk52Ym5SeVlXTjBMbkI1T2pJek53b2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVaWE4wWVdSdlgyTnZiblJ5WVhSdklEMDlJRlZKYm5RMk5DZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKbGMzUmhaRzlmWTI5dWRISmhkRzhpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVpYTjBZV1J2WDJOdmJuUnlZWFJ2SUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzWnZkRzh6TDJOdmJuUnlZV04wTG5CNU9qSXpOeTB5TXprS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxtVnpkR0ZrYjE5amIyNTBjbUYwYnlBOVBTQlZTVzUwTmpRb0NpQWdJQ0F2THlBZ0lDQWdOZ29nSUNBZ0x5OGdLU3dnSWtWc0lHTnZiblJ5WVhSdklHNXZJR1Z6ZE1PaElHVnVJR1ZzSUdWemRHRmtieUJqYjNKeVpXTjBieUlLSUNBZ0lIQjFjMmhwYm5RZ05pQXZMeUEyQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFVnNJR052Ym5SeVlYUnZJRzV2SUdWemRNT2hJR1Z1SUdWc0lHVnpkR0ZrYnlCamIzSnlaV04wYndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1p2ZEc4ekwyTnZiblJ5WVdOMExuQjVPakkwTUFvZ0lDQWdMeThnYzJWc1ppNWxjM1JoWkc5ZlkyOXVkSEpoZEc4Z1BTQlZTVzUwTmpRb055a0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltVnpkR0ZrYjE5amIyNTBjbUYwYnlJS0lDQWdJSEIxYzJocGJuUWdOeUF2THlBM0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNadmRHOHpMMk52Ym5SeVlXTjBMbkI1T2pJME1Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVZMjl1ZEdGa2IzSmZZVzUxYkdGa2IzSmxjd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltTnZiblJoWkc5eVgyRnVkV3hoWkc5eVpYTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WTI5dWRHRmtiM0pmWVc1MWJHRmtiM0psY3lCbGVHbHpkSE1LSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NTJiM1J2TXk1amIyNTBjbUZqZEM1V2IzUnZNeTV5WldOMWNHVnlZWEpmY0dGd1pXeGxkR0Z6S0dOMVpXNTBZVG9nWW5sMFpYTXBJQzArSUhadmFXUTZDbkpsWTNWd1pYSmhjbDl3WVhCbGJHVjBZWE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbTkwYnpNdlkyOXVkSEpoWTNRdWNIazZNalExTFRJME5nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaGhiR3h2ZDE5aFkzUnBiMjV6UFZzaVRtOVBjQ0pkS1FvZ0lDQWdMeThnWkdWbUlISmxZM1Z3WlhKaGNsOXdZWEJsYkdWMFlYTW9jMlZzWml3Z1kzVmxiblJoT2lCQ2VYUmxjeWtnTFQ0Z1RtOXVaVG9LSUNBZ0lIQnliM1J2SURFZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNadmRHOHpMMk52Ym5SeVlXTjBMbkI1T2pJME9Bb2dJQ0FnTHk4Z1ZIaHVMbk5sYm1SbGNpQTlQU0JIYkc5aVlXd3VZM0psWVhSdmNsOWhaR1J5WlhOekNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQm5iRzlpWVd3Z1EzSmxZWFJ2Y2tGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtOTBiek12WTI5dWRISmhZM1F1Y0hrNk1qUTNMVEkwT1FvZ0lDQWdMeThnWVhOelpYSjBJQ2dLSUNBZ0lDOHZJQ0FnSUNCVWVHNHVjMlZ1WkdWeUlEMDlJRWRzYjJKaGJDNWpjbVZoZEc5eVgyRmtaSEpsYzNNS0lDQWdJQzh2SUNrc0lDSlRiMnh2SUdWc0lHTnlaV0ZrYjNJZ2NIVmxaR1VnY21WamRYQmxjbUZ5SUhCaGNHVnNaWFJoY3lJS0lDQWdJR0Z6YzJWeWRDQXZMeUJUYjJ4dklHVnNJR055WldGa2IzSWdjSFZsWkdVZ2NtVmpkWEJsY21GeUlIQmhjR1ZzWlhSaGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNadmRHOHpMMk52Ym5SeVlXTjBMbkI1T2pJMU1Bb2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVaWE4wWVdSdlgyTnZiblJ5WVhSdklEMDlJRlZKYm5RMk5DZzNLU3dnSWt4aElHVnNaV05qYWNPemJpQnVieUJvWVNCaFkyRmlZV1J2SWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbVZ6ZEdGa2IxOWpiMjUwY21GMGJ5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVsYzNSaFpHOWZZMjl1ZEhKaGRHOGdaWGhwYzNSekNpQWdJQ0J3ZFhOb2FXNTBJRGNnTHk4Z053b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJNWVNCbGJHVmpZMm5EczI0Z2JtOGdhR0VnWVdOaFltRmtid29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzWnZkRzh6TDJOdmJuUnlZV04wTG5CNU9qSTFNaTB5TlRnS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJQzh2SUNBZ0lDQjRabVZ5WDJGemMyVjBQWE5sYkdZdWNHRndaV3hsZEdGekxtbGtMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMkZ0YjNWdWREMVZTVzUwTmpRb01Ta3NDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZjbVZqWldsMlpYSTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0J6Wlc1a1pYSTlRV05qYjNWdWRDaGpkV1Z1ZEdFcExBb2dJQ0FnTHk4Z0lDQWdJR1psWlQxVlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbTkwYnpNdlkyOXVkSEpoWTNRdWNIazZNalV6Q2lBZ0lDQXZMeUI0Wm1WeVgyRnpjMlYwUFhObGJHWXVjR0Z3Wld4bGRHRnpMbWxrTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbkJoY0dWc1pYUmhjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1d1lYQmxiR1YwWVhNZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbTkwYnpNdlkyOXVkSEpoWTNRdWNIazZNalUxQ2lBZ0lDQXZMeUJoYzNObGRGOXlaV05sYVhabGNqMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MmIzUnZNeTlqYjI1MGNtRmpkQzV3ZVRveU5UWUtJQ0FnSUM4dklITmxibVJsY2oxQlkyTnZkVzUwS0dOMVpXNTBZU2tzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJaR1J5WlhOeklHeGxibWQwYUNCcGN5QXpNaUJpZVhSbGN3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwZEhodVgyWnBaV3hrSUZObGJtUmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEZKbFkyVnBkbVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbTkwYnpNdlkyOXVkSEpoWTNRdWNIazZNalUwQ2lBZ0lDQXZMeUJoYzNObGRGOWhiVzkxYm5ROVZVbHVkRFkwS0RFcExBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUkJiVzkxYm5RS0lDQWdJR2wwZUc1ZlptbGxiR1FnV0dabGNrRnpjMlYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbTkwYnpNdlkyOXVkSEpoWTNRdWNIazZNalV5Q2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQnBiblJqWHpJZ0x5OGdZWGhtWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTJiM1J2TXk5amIyNTBjbUZqZEM1d2VUb3lOVGNLSUNBZ0lDOHZJR1psWlQxVlNXNTBOalFvTUNrc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyYjNSdk15OWpiMjUwY21GamRDNXdlVG95TlRJdE1qVTRDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNBdkx5QWdJQ0FnZUdabGNsOWhjM05sZEQxelpXeG1MbkJoY0dWc1pYUmhjeTVwWkN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5aGJXOTFiblE5VlVsdWREWTBLREVwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDNKbFkyVnBkbVZ5UFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ2MyVnVaR1Z5UFVGalkyOTFiblFvWTNWbGJuUmhLU3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1MmIzUnZNeTVqYjI1MGNtRmpkQzVXYjNSdk15NW1hVzVoYkdsNllYSmZaV3hsWTJOcGIyNG9LU0F0UGlCMmIybGtPZ3BtYVc1aGJHbDZZWEpmWld4bFkyTnBiMjQ2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbTkwYnpNdlkyOXVkSEpoWTNRdWNIazZNall3TFRJMk1Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaGhiR3h2ZDE5aFkzUnBiMjV6UFZzaVRtOVBjQ0pkS1FvZ0lDQWdMeThnWkdWbUlHWnBibUZzYVhwaGNsOWxiR1ZqWTJsdmJpaHpaV3htS1NBdFBpQk9iMjVsT2dvZ0lDQWdjSEp2ZEc4Z01DQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtOTBiek12WTI5dWRISmhZM1F1Y0hrNk1qWXpDaUFnSUNBdkx5QlVlRzR1YzJWdVpHVnlJRDA5SUVkc2IySmhiQzVqY21WaGRHOXlYMkZrWkhKbGMzTUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2RzYjJKaGJDQkRjbVZoZEc5eVFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTJiM1J2TXk5amIyNTBjbUZqZEM1d2VUb3lOakl0TWpZMENpQWdJQ0F2THlCaGMzTmxjblFnS0FvZ0lDQWdMeThnSUNBZ0lGUjRiaTV6Wlc1a1pYSWdQVDBnUjJ4dlltRnNMbU55WldGMGIzSmZZV1JrY21WemN3b2dJQ0FnTHk4Z0tTd2dJbE52Ykc4Z1pXd2dZM0psWVdSdmNpQndkV1ZrWlNCbWFXNWhiR2w2WVhJZ2JHRWdaV3hsWTJOcHc3TnVJZ29nSUNBZ1lYTnpaWEowSUM4dklGTnZiRzhnWld3Z1kzSmxZV1J2Y2lCd2RXVmtaU0JtYVc1aGJHbDZZWElnYkdFZ1pXeGxZMk5wdzdOdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZG05MGJ6TXZZMjl1ZEhKaFkzUXVjSGs2TWpZMUNpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNWxjM1JoWkc5ZlkyOXVkSEpoZEc4Z1BUMGdWVWx1ZERZMEtEY3BMQ0FpVEdFZ1pXeGxZMk5wdzdOdUlHNXZJR2hoSUdGallXSmhaRzhpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlaWE4wWVdSdlgyTnZiblJ5WVhSdklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbVZ6ZEdGa2IxOWpiMjUwY21GMGJ5QmxlR2x6ZEhNS0lDQWdJSEIxYzJocGJuUWdOeUF2THlBM0NpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRXhoSUdWc1pXTmphY096YmlCdWJ5Qm9ZU0JoWTJGaVlXUnZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtOTBiek12WTI5dWRISmhZM1F1Y0hrNk1qWTNMVEkzTlFvZ0lDQWdMeThnSXlCRVpYTjBjblZwY2lCbGJDQmhjM05sZENBb2NHRndaV3hsZEdGektRb2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRFTnZibVpwWnlnS0lDQWdJQzh2SUNBZ0lDQmpiMjVtYVdkZllYTnpaWFE5YzJWc1ppNXdZWEJsYkdWMFlYTXVhV1FzQ2lBZ0lDQXZMeUFnSUNBZ2JXRnVZV2RsY2oxSGJHOWlZV3d1ZW1WeWIxOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJSEpsYzJWeWRtVTlSMnh2WW1Gc0xucGxjbTlmWVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCbWNtVmxlbVU5UjJ4dlltRnNMbnBsY205ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQmpiR0YzWW1GamF6MUhiRzlpWVd3dWVtVnliMTloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZG05MGJ6TXZZMjl1ZEhKaFkzUXVjSGs2TWpZNUNpQWdJQ0F2THlCamIyNW1hV2RmWVhOelpYUTljMlZzWmk1d1lYQmxiR1YwWVhNdWFXUXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWNHRndaV3hsZEdGeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbkJoY0dWc1pYUmhjeUJsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MmIzUnZNeTlqYjI1MGNtRmpkQzV3ZVRveU56QUtJQ0FnSUM4dklHMWhibUZuWlhJOVIyeHZZbUZzTG5wbGNtOWZZV1JrY21WemN5d0tJQ0FnSUdkc2IySmhiQ0JhWlhKdlFXUmtjbVZ6Y3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1p2ZEc4ekwyTnZiblJ5WVdOMExuQjVPakkzTVMweU56TUtJQ0FnSUM4dklISmxjMlZ5ZG1VOVIyeHZZbUZzTG5wbGNtOWZZV1JrY21WemN5d0tJQ0FnSUM4dklHWnlaV1Y2WlQxSGJHOWlZV3d1ZW1WeWIxOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z1kyeGhkMkpoWTJzOVIyeHZZbUZzTG5wbGNtOWZZV1JrY21WemN5d0tJQ0FnSUdSMWNHNGdNd29nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRU5zWVhkaVlXTnJDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBSbkpsWlhwbENpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFVtVnpaWEoyWlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEUxaGJtRm5aWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTJiM1J2TXk5amIyNTBjbUZqZEM1d2VUb3lOamN0TWpZNENpQWdJQ0F2THlBaklFUmxjM1J5ZFdseUlHVnNJR0Z6YzJWMElDaHdZWEJsYkdWMFlYTXBDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBRMjl1Wm1sbktBb2dJQ0FnYVc1MFkxOHpJQzh2SUdGalptY0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyYjNSdk15OWpiMjUwY21GamRDNXdlVG95TnpRS0lDQWdJQzh2SUdabFpUMVZTVzUwTmpRb01Da3NDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MmIzUnZNeTlqYjI1MGNtRmpkQzV3ZVRveU5qY3RNamMxQ2lBZ0lDQXZMeUFqSUVSbGMzUnlkV2x5SUdWc0lHRnpjMlYwSUNod1lYQmxiR1YwWVhNcENpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFEyOXVabWxuS0FvZ0lDQWdMeThnSUNBZ0lHTnZibVpwWjE5aGMzTmxkRDF6Wld4bUxuQmhjR1ZzWlhSaGN5NXBaQ3dLSUNBZ0lDOHZJQ0FnSUNCdFlXNWhaMlZ5UFVkc2IySmhiQzU2WlhKdlgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdjbVZ6WlhKMlpUMUhiRzlpWVd3dWVtVnliMTloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdaeVpXVjZaVDFIYkc5aVlXd3VlbVZ5YjE5aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHTnNZWGRpWVdOclBVZHNiMkpoYkM1NlpYSnZYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBWVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZG05MGJ6TXZZMjl1ZEhKaFkzUXVjSGs2TWpjM0xUSTNPQW9nSUNBZ0x5OGdJeUJFWlhadmJIWmxjaUJsYkNCamNzT3BaR2wwYnlCemIySnlZVzUwWlNCaGJDQmpjbVZoWkc5eUlHUmxiQ0JqYjI1MGNtRjBid29nSUNBZ0x5OGdjMkZzWkc4Z1BTQkhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxtSmhiR0Z1WTJVS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0JoWTJOMFgzQmhjbUZ0YzE5blpYUWdRV05qZEVKaGJHRnVZMlVLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhZMk52ZFc1MElHWjFibVJsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1p2ZEc4ekwyTnZiblJ5WVdOMExuQjVPakkzT1FvZ0lDQWdMeThnYldsdVgySmhiR0Z1WTJVZ1BTQkhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxtMXBibDlpWVd4aGJtTmxDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1lXTmpkRjl3WVhKaGJYTmZaMlYwSUVGalkzUk5hVzVDWVd4aGJtTmxDaUFnSUNCaGMzTmxjblFnTHk4Z1lXTmpiM1Z1ZENCbWRXNWtaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTJiM1J2TXk5amIyNTBjbUZqZEM1d2VUb3lPREFLSUNBZ0lDOHZJR1Y0WTJWa1pXNTBaU0E5SUhOaGJHUnZJQzBnYldsdVgySmhiR0Z1WTJVS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzWnZkRzh6TDJOdmJuUnlZV04wTG5CNU9qSTRNUW9nSUNBZ0x5OGdhV1lnWlhoalpXUmxiblJsSUQ0Z1ZVbHVkRFkwS0RBcE9nb2dJQ0FnWW5vZ1ptbHVZV3hwZW1GeVgyVnNaV05qYVc5dVgyRm1kR1Z5WDJsbVgyVnNjMlZBTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1p2ZEc4ekwyTnZiblJ5WVdOMExuQjVPakk0TWkweU9EWUtJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2oxSGJHOWlZV3d1WTNKbFlYUnZjbDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRDFsZUdObFpHVnVkR1VzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MmIzUnZNeTlqYjI1MGNtRmpkQzV3ZVRveU9ETUtJQ0FnSUM4dklISmxZMlZwZG1WeVBVZHNiMkpoYkM1amNtVmhkRzl5WDJGa1pISmxjM01zQ2lBZ0lDQm5iRzlpWVd3Z1EzSmxZWFJ2Y2tGa1pISmxjM01LSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnRiM1Z1ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWldObGFYWmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzWnZkRzh6TDJOdmJuUnlZV04wTG5CNU9qSTRNZ29nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdhVzUwWTE4eElDOHZJSEJoZVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzWnZkRzh6TDJOdmJuUnlZV04wTG5CNU9qSTROUW9nSUNBZ0x5OGdabVZsUFZWSmJuUTJOQ2d3S1N3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1p2ZEc4ekwyTnZiblJ5WVdOMExuQjVPakk0TWkweU9EWUtJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2oxSGJHOWlZV3d1WTNKbFlYUnZjbDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRDFsZUdObFpHVnVkR1VzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDZ3BtYVc1aGJHbDZZWEpmWld4bFkyTnBiMjVmWVdaMFpYSmZhV1pmWld4elpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzWnZkRzh6TDJOdmJuUnlZV04wTG5CNU9qSTRPQW9nSUNBZ0x5OGdjMlZzWmk1bGMzUmhaRzlmWTI5dWRISmhkRzhnUFNCVlNXNTBOalFvT0NrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1WemRHRmtiMTlqYjI1MGNtRjBieUlLSUNBZ0lIQjFjMmhwYm5RZ09DQXZMeUE0Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdjbVYwYzNWaUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBRUFBRUVBeVlMRDJWemRHRmtiMTlqYjI1MGNtRjBid1FWSDN4MUNYQmhjR1ZzWlhSaGN4UmpiMjUwWVdSdmNsOWpiMjF3Y205dGFYTnZjdzlqYjI1MFlXUnZjbDl5WVdsalpYTVRZMjl1ZEdGa2IzSmZZVzUxYkdGa2IzSmxjeEp3WVhCbGJHVjBZWE5mWlc1MmFXRmtZWE1MYm5WdFgySnNiM0YxWlhNS2RHRnRYMkpzYjNGMVpRbDBZVzFmY21WemRHOEtkSGh1U1dSZmNtRnBlakVZUUFBbUtDSm5LaUpuSndZaVp5c2laeWNFSW1jbkJTSm5Kd2NpWnljSUltY25DU0puSndxQUFHY3hHMEVCdzRJUUJIZFgzY29FT3BkNGF3U0pTd3VlQk1mK2s4QUVFSnRxWVFTSUFwM1NCTk13L1J3RW5CZWtNQVFDb29yVkJIMmJQbGdFVG9Fczl3UzV2YzdCQkdudHJuVUVnQVo0N0FRZTFUSkRCRzhXUDhrMkdnQ09FQUVyQVJvQkJRRDVBT2dBMXdDL0FLNEFsd0JsQUZrQVNBQXhBQ0FBRGdBQ0lrTXhHUlJFTVJoRWlBTWRJME14R1JSRU1SaEVOaG9CVndJQWlBTFpJME14R1JSRU1SaEVpQUsxRmlsTVVMQWpRekVaRkVReEdFUTJHZ0ZYQWdDSUFtQVdLVXhRc0NORE1Sa1VSREVZUklnQ05CWXBURkN3STBNeEdSUkVNUmhFaUFJUUkwTXhHUlJFTVJoRWlBSG5Ud01XVHdNV1R3TVdTd01WRmxjR0FrOEVVRThEVHdOUVR3SlFnQUlBR2xCTVVDbE1VTEFqUXpFWkZFUXhHRVEyR2dGWEFnQ0lBWkFXS1V4UXNDTkRNUmtVUkRFWVJJZ0JaUllwVEZDd0kwTXhHUlJFTVJoRU5ob0JGellhQWhjMkdnTVhpQUVsSTBNeEdSUkVNUmhFaUFFREZpbE1VTEFqUXpFWkZFUXhHRVNJQU5rV0tVeFFzQ05ETVJrVVJERVlSSWdBdGlORE1Sa1VSREVZUkRZYUFSZUlBSllXS1V4UXNDTkRNUmtVUkRFWVJJZ0FlaFlwVEZDd0kwTXhHUlJFTVJoRU5ob0JWd0lBTmhvQ1Z3SUFOaG9ERjRnQUVoWXBURkN3STBNeEdVRCtyekVZRkVRalE0b0RBVEVBTWdrU1JDSW9aVVFVUkl2OUZZRWdEa1NML2hXQkNBNUVzVElLU2JJc3Npa2lzaU9MLzdJaWkvNnlKWXY5c2lZbHNoQWlzZ0d6S3JROFp5Z2paeUlxWlVTSk1RQXlDUkpFSWlobFJJbUtBUUV4QURJSkVrUW9pLzluaS8rSk1RQXlDUkpFSWlobFJDTVNSQ2lCQW1lSk1RQXlDUkpFSWlobFJJRUNFa1FpSzJWRUl3Z3JTd0ZuaVRFQU1na1NSQ0lvWlVTQkFoSkVLQ1ZuSWl0bFJJbUtBd0F4QURJSkVrUWlLR1ZFSlJKRUp3ZUwvV2NuQ0l2K1p5Y0ppLzluS0NSbmlURUFNZ2tTUkNJb1pVUWtFa1FpSndSbFJDTUlKd1JMQVdlSmlnRUJNUUF5Q1JKRUlpaGxSQ1FTUkNpQkJXY25Db3YvWnlJbkJHVkVpU0lvWlVTQkJROUVJaWNIWlVRaUp3aGxSQ0luQ1dWRUlpY0taVVNKTVFBeUNSSkVJaWhsUklFRkVrUW9nUVpuaVRFQU1na1NSQ0lvWlVTQkJoSkVJaWNGWlVRakNDY0ZTd0ZuaVlvQkFURUFNZ2tTUkNJb1pVU0JCaEpFc1NJcVpVU0wveFdCSUJKRU1ncXlBSXYvc2hRanNoS3lFU1N5RUNLeUFiTWlKd1psUkNNSUp3WkxBV2VKTVFBeUNSSkVJaWhsUklFR0VrUW9nUWRuSWljRlpVU0ppZ0VBTVFBeUNSSkVJaWhsUklFSEVrU3hJaXBsUkRJS2kvOFZnU0FTUkl2L3NnQ3lGQ095RXJJUkpMSVFJcklCczRtS0FBQXhBRElKRWtRaUtHVkVnUWNTUkxFaUttVkVNZ05IQTdJc3NpdXlLcklwc2lFbHNoQWlzZ0d6TWdwekFFUXlDbk1CUkFsSlFRQVFzVElKaXdDeUNMSUhJN0lRSXJJQnN5aUJDR2VKIiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
