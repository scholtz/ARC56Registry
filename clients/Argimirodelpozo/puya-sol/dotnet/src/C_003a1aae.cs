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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.C_003a1aae
{


    public class CProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Invoice : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Aid { get; set; }

                public bool Aboola { get; set; }

                public bool Aboolc { get; set; }

                public bool Exists { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vAid.From(Aid);
                    ret.AddRange(vAid.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAboola = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vAboola.From(Aboola);
                    ret.AddRange(vAboola.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAboolc = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vAboolc.From(Aboolc);
                    ret.AddRange(vAboolc.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExists = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vExists.From(Exists);
                    ret.AddRange(vExists.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Invoice Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Invoice();
                    uint count = 0;
                    var vAid = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vAid.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Aid = vAid;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAboola = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vAboola.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAboola = vAboola.ToValue();
                    if (valueAboola is bool vAboolaValue) { ret.Aboola = vAboolaValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAboolc = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vAboolc.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAboolc = vAboolc.ToValue();
                    if (valueAboolc is bool vAboolcValue) { ret.Aboolc = vAboolcValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExists = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vExists.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExists = vExists.ToValue();
                    if (valueExists is bool vExistsValue) { ret.Exists = vExistsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Invoice);
                }
                public bool Equals(Invoice? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Invoice left, Invoice right)
                {
                    return EqualityComparer<Invoice>.Default.Equals(left, right);
                }
                public static bool operator !=(Invoice left, Invoice right)
                {
                    return !(left == right);
                }

            }

            public class NreditReturn : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] CiDs { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] Dates { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] RiDs { get; set; }

                public bool[] Cboolas { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] Amounts { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCiDs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256[500]");
                    vCiDs.From(CiDs);
                    ret.AddRange(vCiDs.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDates = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256[500]");
                    vDates.From(Dates);
                    ret.AddRange(vDates.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRiDs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256[500]");
                    vRiDs.From(RiDs);
                    ret.AddRange(vRiDs.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCboolas = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool[500]");
                    vCboolas.From(Cboolas);
                    ret.AddRange(vCboolas.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmounts = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256[500]");
                    vAmounts.From(Amounts);
                    ret.AddRange(vAmounts.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static NreditReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new NreditReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCiDs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256[500]");
                    count = vCiDs.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCiDs = vCiDs.ToValue();
                    if (valueCiDs is AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] vCiDsValue) { ret.CiDs = vCiDsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDates = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256[500]");
                    count = vDates.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDates = vDates.ToValue();
                    if (valueDates is AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] vDatesValue) { ret.Dates = vDatesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRiDs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256[500]");
                    count = vRiDs.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRiDs = vRiDs.ToValue();
                    if (valueRiDs is AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] vRiDsValue) { ret.RiDs = vRiDsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCboolas = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool[500]");
                    count = vCboolas.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCboolas = vCboolas.ToValue();
                    if (valueCboolas is bool[] vCboolasValue) { ret.Cboolas = vCboolasValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmounts = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256[500]");
                    count = vAmounts.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmounts = vAmounts.ToValue();
                    if (valueAmounts is AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] vAmountsValue) { ret.Amounts = vAmountsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as NreditReturn);
                }
                public bool Equals(NreditReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(NreditReturn left, NreditReturn right)
                {
                    return EqualityComparer<NreditReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(NreditReturn left, NreditReturn right)
                {
                    return !(left == right);
                }

            }

            public class Return500InvoicesByDatesReturn : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] AiDs { get; set; }

                public bool[] Aboolas { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] Dates { get; set; }

                public byte[][][] Abytesas { get; set; }

                public byte[][][] Bytesbs { get; set; }

                public byte[][][] Bytescs { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] Amounts { get; set; }

                public bool[] Aboolbs { get; set; }

                public bool[] Aboolcs { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAiDs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256[500]");
                    vAiDs.From(AiDs);
                    ret.AddRange(vAiDs.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAboolas = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool[500]");
                    vAboolas.From(Aboolas);
                    ret.AddRange(vAboolas.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDates = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256[500]");
                    vDates.From(Dates);
                    ret.AddRange(vDates.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAbytesas = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32][3][500]");
                    vAbytesas.From(Abytesas);
                    ret.AddRange(vAbytesas.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBytesbs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32][3][500]");
                    vBytesbs.From(Bytesbs);
                    ret.AddRange(vBytesbs.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBytescs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32][2][500]");
                    vBytescs.From(Bytescs);
                    ret.AddRange(vBytescs.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmounts = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256[500]");
                    vAmounts.From(Amounts);
                    ret.AddRange(vAmounts.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAboolbs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool[500]");
                    vAboolbs.From(Aboolbs);
                    ret.AddRange(vAboolbs.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAboolcs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool[500]");
                    vAboolcs.From(Aboolcs);
                    ret.AddRange(vAboolcs.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Return500InvoicesByDatesReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Return500InvoicesByDatesReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAiDs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256[500]");
                    count = vAiDs.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAiDs = vAiDs.ToValue();
                    if (valueAiDs is AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] vAiDsValue) { ret.AiDs = vAiDsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAboolas = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool[500]");
                    count = vAboolas.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAboolas = vAboolas.ToValue();
                    if (valueAboolas is bool[] vAboolasValue) { ret.Aboolas = vAboolasValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDates = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256[500]");
                    count = vDates.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDates = vDates.ToValue();
                    if (valueDates is AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] vDatesValue) { ret.Dates = vDatesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAbytesas = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32][3][500]");
                    count = vAbytesas.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAbytesas = vAbytesas.ToValue();
                    if (valueAbytesas is byte[][][] vAbytesasValue) { ret.Abytesas = vAbytesasValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBytesbs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32][3][500]");
                    count = vBytesbs.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBytesbs = vBytesbs.ToValue();
                    if (valueBytesbs is byte[][][] vBytesbsValue) { ret.Bytesbs = vBytesbsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBytescs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32][2][500]");
                    count = vBytescs.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBytescs = vBytescs.ToValue();
                    if (valueBytescs is byte[][][] vBytescsValue) { ret.Bytescs = vBytescsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmounts = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256[500]");
                    count = vAmounts.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmounts = vAmounts.ToValue();
                    if (valueAmounts is AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] vAmountsValue) { ret.Amounts = vAmountsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAboolbs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool[500]");
                    count = vAboolbs.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAboolbs = vAboolbs.ToValue();
                    if (valueAboolbs is bool[] vAboolbsValue) { ret.Aboolbs = vAboolbsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAboolcs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool[500]");
                    count = vAboolcs.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAboolcs = vAboolcs.ToValue();
                    if (valueAboolcs is bool[] vAboolcsValue) { ret.Aboolcs = vAboolcsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Return500InvoicesByDatesReturn);
                }
                public bool Equals(Return500InvoicesByDatesReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Return500InvoicesByDatesReturn left, Return500InvoicesByDatesReturn right)
                {
                    return EqualityComparer<Return500InvoicesByDatesReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(Return500InvoicesByDatesReturn left, Return500InvoicesByDatesReturn right)
                {
                    return !(left == right);
                }

            }

            public class Return500PaymentsByDatesReturn : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] BiDs { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] Dates { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] RiDs { get; set; }

                public bool[] Bboolas { get; set; }

                public byte[][][] Bytesbs { get; set; }

                public byte[][][] Bytescs { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] Amounts { get; set; }

                public bool[] Bboolbs { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBiDs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256[500]");
                    vBiDs.From(BiDs);
                    ret.AddRange(vBiDs.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDates = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256[500]");
                    vDates.From(Dates);
                    ret.AddRange(vDates.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRiDs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256[500]");
                    vRiDs.From(RiDs);
                    ret.AddRange(vRiDs.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBboolas = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool[500]");
                    vBboolas.From(Bboolas);
                    ret.AddRange(vBboolas.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBytesbs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32][3][500]");
                    vBytesbs.From(Bytesbs);
                    ret.AddRange(vBytesbs.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBytescs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32][2][500]");
                    vBytescs.From(Bytescs);
                    ret.AddRange(vBytescs.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmounts = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256[500]");
                    vAmounts.From(Amounts);
                    ret.AddRange(vAmounts.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBboolbs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool[500]");
                    vBboolbs.From(Bboolbs);
                    ret.AddRange(vBboolbs.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Return500PaymentsByDatesReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Return500PaymentsByDatesReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBiDs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256[500]");
                    count = vBiDs.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBiDs = vBiDs.ToValue();
                    if (valueBiDs is AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] vBiDsValue) { ret.BiDs = vBiDsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDates = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256[500]");
                    count = vDates.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDates = vDates.ToValue();
                    if (valueDates is AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] vDatesValue) { ret.Dates = vDatesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRiDs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256[500]");
                    count = vRiDs.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRiDs = vRiDs.ToValue();
                    if (valueRiDs is AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] vRiDsValue) { ret.RiDs = vRiDsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBboolas = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool[500]");
                    count = vBboolas.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBboolas = vBboolas.ToValue();
                    if (valueBboolas is bool[] vBboolasValue) { ret.Bboolas = vBboolasValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBytesbs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32][3][500]");
                    count = vBytesbs.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBytesbs = vBytesbs.ToValue();
                    if (valueBytesbs is byte[][][] vBytesbsValue) { ret.Bytesbs = vBytesbsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBytescs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32][2][500]");
                    count = vBytescs.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBytescs = vBytescs.ToValue();
                    if (valueBytescs is byte[][][] vBytescsValue) { ret.Bytescs = vBytescsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmounts = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256[500]");
                    count = vAmounts.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmounts = vAmounts.ToValue();
                    if (valueAmounts is AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] vAmountsValue) { ret.Amounts = vAmountsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBboolbs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool[500]");
                    count = vBboolbs.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBboolbs = vBboolbs.ToValue();
                    if (valueBboolbs is bool[] vBboolbsValue) { ret.Bboolbs = vBboolbsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Return500PaymentsByDatesReturn);
                }
                public bool Equals(Return500PaymentsByDatesReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Return500PaymentsByDatesReturn left, Return500PaymentsByDatesReturn right)
                {
                    return EqualityComparer<Return500PaymentsByDatesReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(Return500PaymentsByDatesReturn left, Return500PaymentsByDatesReturn right)
                {
                    return !(left == right);
                }

            }

            public class Tuple : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Aid { get; set; }

                public bool Aboola { get; set; }

                public bool Aboolc { get; set; }

                public bool Exists { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vAid.From(Aid);
                    ret.AddRange(vAid.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAboola = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vAboola.From(Aboola);
                    ret.AddRange(vAboola.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAboolc = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vAboolc.From(Aboolc);
                    ret.AddRange(vAboolc.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExists = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vExists.From(Exists);
                    ret.AddRange(vExists.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Tuple Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Tuple();
                    uint count = 0;
                    var vAid = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vAid.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Aid = vAid;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAboola = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vAboola.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAboola = vAboola.ToValue();
                    if (valueAboola is bool vAboolaValue) { ret.Aboola = vAboolaValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAboolc = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vAboolc.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAboolc = vAboolc.ToValue();
                    if (valueAboolc is bool vAboolcValue) { ret.Aboolc = vAboolcValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExists = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vExists.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExists = vExists.ToValue();
                    if (valueExists is bool vExistsValue) { ret.Exists = vExistsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Tuple);
                }
                public bool Equals(Tuple? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Tuple left, Tuple right)
                {
                    return EqualityComparer<Tuple>.Default.Equals(left, right);
                }
                public static bool operator !=(Tuple left, Tuple right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task PostInit(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 204, 73, 227 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> PostInit_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 204, 73, 227 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="__arc4_startindex"> </param>
        public async Task<Structs.NreditReturn> Nredit(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_startindex, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 188, 103, 253, 18 };

            var result = await base.SimApp(new List<object> { abiHandle, __arc4_startindex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.NreditReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> Nredit_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_startindex, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 188, 103, 253, 18 };

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_startindex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="__arc4_begindate"> </param>
        /// <param name="__arc4_enddate"> </param>
        /// <param name="__arc4_startindex"> </param>
        public async Task<Structs.Return500InvoicesByDatesReturn> Return500InvoicesByDates(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_begindate, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_enddate, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_startindex, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 228, 126, 14, 200 };

            var result = await base.SimApp(new List<object> { abiHandle, __arc4_begindate, __arc4_enddate, __arc4_startindex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Return500InvoicesByDatesReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> Return500InvoicesByDates_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_begindate, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_enddate, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_startindex, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 228, 126, 14, 200 };

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_begindate, __arc4_enddate, __arc4_startindex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="__arc4_begindate"> </param>
        /// <param name="__arc4_enddate"> </param>
        /// <param name="__arc4_startindex"> </param>
        public async Task<Structs.Return500PaymentsByDatesReturn> Return500PaymentsByDates(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_begindate, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_enddate, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_startindex, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 100, 77, 179, 28 };

            var result = await base.SimApp(new List<object> { abiHandle, __arc4_begindate, __arc4_enddate, __arc4_startindex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Return500PaymentsByDatesReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> Return500PaymentsByDates_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_begindate, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_enddate, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_startindex, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 100, 77, 179, 28 };

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_begindate, __arc4_enddate, __arc4_startindex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="__arc4_key0"> </param>
        public async Task<Structs.Tuple> Invoices(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_key0, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 197, 253, 182, 37 };

            var result = await base.SimApp(new List<object> { abiHandle, __arc4_key0 }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Tuple.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> Invoices_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_key0, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 197, 253, 182, 37 };

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_key0 }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJJbnZvaWNlIjpbeyJuYW1lIjoiQUlEIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJBYm9vbGEiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6IkFib29sYyIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiZXhpc3RzIiwidHlwZSI6ImJvb2wifV0sIm5yZWRpdFJldHVybiI6W3sibmFtZSI6IkNJRHMiLCJ0eXBlIjoidWludDI1Nls1MDBdIn0seyJuYW1lIjoiZGF0ZXMiLCJ0eXBlIjoidWludDI1Nls1MDBdIn0seyJuYW1lIjoiUklEcyIsInR5cGUiOiJ1aW50MjU2WzUwMF0ifSx7Im5hbWUiOiJDYm9vbGFzIiwidHlwZSI6ImJvb2xbNTAwXSJ9LHsibmFtZSI6ImFtb3VudHMiLCJ0eXBlIjoidWludDI1Nls1MDBdIn1dLCJyZXR1cm41MDBJbnZvaWNlc0J5RGF0ZXNSZXR1cm4iOlt7Im5hbWUiOiJBSURzIiwidHlwZSI6InVpbnQyNTZbNTAwXSJ9LHsibmFtZSI6IkFib29sYXMiLCJ0eXBlIjoiYm9vbFs1MDBdIn0seyJuYW1lIjoiZGF0ZXMiLCJ0eXBlIjoidWludDI1Nls1MDBdIn0seyJuYW1lIjoiQWJ5dGVzYXMiLCJ0eXBlIjoidWludDhbMzJdWzNdWzUwMF0ifSx7Im5hbWUiOiJieXRlc2JzIiwidHlwZSI6InVpbnQ4WzMyXVszXVs1MDBdIn0seyJuYW1lIjoiYnl0ZXNjcyIsInR5cGUiOiJ1aW50OFszMl1bMl1bNTAwXSJ9LHsibmFtZSI6ImFtb3VudHMiLCJ0eXBlIjoidWludDI1Nls1MDBdIn0seyJuYW1lIjoiQWJvb2xicyIsInR5cGUiOiJib29sWzUwMF0ifSx7Im5hbWUiOiJBYm9vbGNzIiwidHlwZSI6ImJvb2xbNTAwXSJ9XSwicmV0dXJuNTAwUGF5bWVudHNCeURhdGVzUmV0dXJuIjpbeyJuYW1lIjoiQklEcyIsInR5cGUiOiJ1aW50MjU2WzUwMF0ifSx7Im5hbWUiOiJkYXRlcyIsInR5cGUiOiJ1aW50MjU2WzUwMF0ifSx7Im5hbWUiOiJSSURzIiwidHlwZSI6InVpbnQyNTZbNTAwXSJ9LHsibmFtZSI6IkJib29sYXMiLCJ0eXBlIjoiYm9vbFs1MDBdIn0seyJuYW1lIjoiYnl0ZXNicyIsInR5cGUiOiJ1aW50OFszMl1bM11bNTAwXSJ9LHsibmFtZSI6ImJ5dGVzY3MiLCJ0eXBlIjoidWludDhbMzJdWzJdWzUwMF0ifSx7Im5hbWUiOiJhbW91bnRzIiwidHlwZSI6InVpbnQyNTZbNTAwXSJ9LHsibmFtZSI6IkJib29sYnMiLCJ0eXBlIjoiYm9vbFs1MDBdIn1dLCJ0dXBsZSI6W3sibmFtZSI6IkFJRCIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoiQWJvb2xhIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJBYm9vbGMiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6ImV4aXN0cyIsInR5cGUiOiJib29sIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6Il9fcG9zdEluaXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibnJlZGl0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfX2FyYzRfc3RhcnRpbmRleCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDI1Nls1MDBdLHVpbnQyNTZbNTAwXSx1aW50MjU2WzUwMF0sYm9vbFs1MDBdLHVpbnQyNTZbNTAwXSkiLCJzdHJ1Y3QiOiJucmVkaXRSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJldHVybjUwMEludm9pY2VzQnlEYXRlcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X2JlZ2luZGF0ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9lbmRkYXRlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X3N0YXJ0aW5kZXgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQyNTZbNTAwXSxib29sWzUwMF0sdWludDI1Nls1MDBdLHVpbnQ4WzMyXVszXVs1MDBdLHVpbnQ4WzMyXVszXVs1MDBdLHVpbnQ4WzMyXVsyXVs1MDBdLHVpbnQyNTZbNTAwXSxib29sWzUwMF0sYm9vbFs1MDBdKSIsInN0cnVjdCI6InJldHVybjUwMEludm9pY2VzQnlEYXRlc1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmV0dXJuNTAwUGF5bWVudHNCeURhdGVzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfX2FyYzRfYmVnaW5kYXRlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X2VuZGRhdGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfX2FyYzRfc3RhcnRpbmRleCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDI1Nls1MDBdLHVpbnQyNTZbNTAwXSx1aW50MjU2WzUwMF0sYm9vbFs1MDBdLHVpbnQ4WzMyXVszXVs1MDBdLHVpbnQ4WzMyXVsyXVs1MDBdLHVpbnQyNTZbNTAwXSxib29sWzUwMF0pIiwic3RydWN0IjoicmV0dXJuNTAwUGF5bWVudHNCeURhdGVzUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpbnZvaWNlcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X2tleTAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ1MTIsYm9vbCxib29sLGJvb2wpIiwic3RydWN0IjoidHVwbGUiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNzc4XSwiZXJyb3JNZXNzYWdlIjoiX19wb3N0SW5pdCBhbHJlYWR5IGNhbGxlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2NywzMTksMzI3LDMzNSw0OTQsNTAyLDUxMCw2NzBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50MjU2IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTgwLDM0OCw1MjMsNjgzXSwiZXJyb3JNZXNzYWdlIjoibm90IHBheWFibGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dmRHVnpkSE12YzI5c2FXUnBkSGt0YzJWdFlXNTBhV010ZEdWemRITXZkR1Z6ZEhNdmRtRnlhVzkxY3k5dVpXZGhkR2wyWlY5emRHRmphMTlvWldsbmFIUXVjMjlzTGtNdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUE0T0NBeE5qQXdNQ0F3SURFZ05EZ3dNREFnTXpJd01EQUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ01IZ3dNQ0F3ZURFMU1XWTNZemMxSUNKZlgyTjBiM0pmY0dWdVpHbHVaeUlnSW1sdWRtOXBZMlZ6SWdvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lIQjFjMmhwYm5RZ05EQTVOZ29nSUNBZ1lucGxjbThLSUNBZ0lHUjFjQW9nSUNBZ2MzUnZjbVVnTlFvZ0lDQWdjM1J2Y21VZ01Bb2dJQ0FnYkc5aFpDQXdDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EZ3dDaUFnSUNCeVpYQnNZV05sTWlBMk5Bb2dJQ0FnYzNSdmNtVWdNQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVgxOWpkRzl5WDNCbGJtUnBibWNpQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHbHVkR05mTXlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNFltRmpZelE1WlRNZ01IaGlZelkzWm1ReE1pQXdlR1UwTjJVd1pXTTRJREI0TmpRMFpHSXpNV01nTUhoak5XWmtZall5TlNBdkx5QnRaWFJvYjJRZ0lsOWZjRzl6ZEVsdWFYUW9LWFp2YVdRaUxDQnRaWFJvYjJRZ0ltNXlaV1JwZENoMWFXNTBNalUyS1NoMWFXNTBNalUyV3pVd01GMHNkV2x1ZERJMU5sczFNREJkTEhWcGJuUXlOVFpiTlRBd1hTeGliMjlzV3pVd01GMHNkV2x1ZERJMU5sczFNREJkS1NJc0lHMWxkR2h2WkNBaWNtVjBkWEp1TlRBd1NXNTJiMmxqWlhOQ2VVUmhkR1Z6S0hWcGJuUXlOVFlzZFdsdWRESTFOaXgxYVc1ME1qVTJLU2gxYVc1ME1qVTJXelV3TUYwc1ltOXZiRnMxTURCZExIVnBiblF5TlRaYk5UQXdYU3gxYVc1ME9Gc3pNbDFiTTExYk5UQXdYU3gxYVc1ME9Gc3pNbDFiTTExYk5UQXdYU3gxYVc1ME9Gc3pNbDFiTWwxYk5UQXdYU3gxYVc1ME1qVTJXelV3TUYwc1ltOXZiRnMxTURCZExHSnZiMnhiTlRBd1hTa2lMQ0J0WlhSb2IyUWdJbkpsZEhWeWJqVXdNRkJoZVcxbGJuUnpRbmxFWVhSbGN5aDFhVzUwTWpVMkxIVnBiblF5TlRZc2RXbHVkREkxTmlrb2RXbHVkREkxTmxzMU1EQmRMSFZwYm5ReU5UWmJOVEF3WFN4MWFXNTBNalUyV3pVd01GMHNZbTl2YkZzMU1EQmRMSFZwYm5RNFd6TXlYVnN6WFZzMU1EQmRMSFZwYm5RNFd6TXlYVnN5WFZzMU1EQmRMSFZwYm5ReU5UWmJOVEF3WFN4aWIyOXNXelV3TUYwcElpd2diV1YwYUc5a0lDSnBiblp2YVdObGN5aDFhVzUwTWpVMktTaDFhVzUwTlRFeUxHSnZiMndzWW05dmJDeGliMjlzS1NJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmWDE5d2IzTjBTVzVwZEY5eWIzVjBaVUExSUcxaGFXNWZibkpsWkdsMFgzSnZkWFJsUURZZ2JXRnBibDl5WlhSMWNtNDFNREJKYm5admFXTmxjMEo1UkdGMFpYTmZjbTkxZEdWQU55QnRZV2x1WDNKbGRIVnlialV3TUZCaGVXMWxiblJ6UW5sRVlYUmxjMTl5YjNWMFpVQTRJRzFoYVc1ZmFXNTJiMmxqWlhOZmNtOTFkR1ZBT1FvZ0lDQWdaWEp5Q2dwdFlXbHVYMmx1ZG05cFkyVnpYM0p2ZFhSbFFEazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNZ29nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1UVUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYek1nTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2dwdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1UWTZDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm05MElIQmhlV0ZpYkdVS0lDQWdJSEIxYzJocGJuUWdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXpNZ29nSUNBZ0xRb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ1lubDBaV05mTXlBdkx5QWlhVzUyYjJsalpYTWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ01DQXpNZ29nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ01qVTJDaUFnSUNCblpYUmlhWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCa2FXY2dNZ29nSUNBZ2NIVnphR2x1ZENBeU5UY0tJQ0FnSUdkbGRHSnBkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdjSFZ6YUdsdWRDQXlOVGdLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBd0NpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lIQjFjMmhwYm5RZ05qUUtJQ0FnSUdKNlpYSnZDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR0o4Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURBS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUhObGRHSnBkQW9nSUNBZ2FXNTBZMTh6SUM4dklERUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdjMlYwWW1sMENpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYzJWMFltbDBDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTXlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE5Ub0tJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE5nb0tiV0ZwYmw5eVpYUjFjbTQxTURCUVlYbHRaVzUwYzBKNVJHRjBaWE5mY205MWRHVkFPRG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRESTFOZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1qQUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYek1nTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2dwdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1qRTZDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm05MElIQmhlV0ZpYkdVS0lDQWdJR2x1ZEdOZk1TQXZMeUF4TmpBd01Bb2dJQ0FnWW5wbGNtOEtJQ0FnSUdsdWRHTWdOQ0F2THlBME9EQXdNQW9nSUNBZ1lucGxjbThLSUNBZ0lHbHVkR01nTlNBdkx5QXpNakF3TUFvZ0lDQWdZbnBsY204S0lDQWdJR3h2WVdRZ01Bb2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdZbnBsY204S0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6QWdMeThnT0RnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6RWdMeThnTVRZd01EQUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR1JwWnlBeENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdjbVZ3YkdGalpUSWdOalFLSUNBZ0lITjBiM0psSURBS0lDQWdJR3h2WVdRZ01Bb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnT0RnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6RWdMeThnTVRZd01EQUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR1JwWnlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhKbGNHeGhZMlV5SURZMENpQWdJQ0J6ZEc5eVpTQXdDaUFnSUNCc2IyRmtJREFLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEZzRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2FXNTBZMTh4SUM4dklERTJNREF3Q2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnlaWEJzWVdObE1pQTJOQW9nSUNBZ2MzUnZjbVVnTUFvZ0lDQWdiRzloWkNBd0NpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUE0T0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdNZ05DQXZMeUEwT0RBd01Bb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdaR2xuSURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnY21Wd2JHRmpaVElnTmpRS0lDQWdJSE4wYjNKbElEQUtJQ0FnSUd4dllXUWdNQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z09EZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpJRFVnTHk4Z016SXdNREFLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUdScFp5QXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lISmxjR3hoWTJVeUlEWTBDaUFnSUNCemRHOXlaU0F3Q2lBZ0lDQnNiMkZrSURBS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJRGc0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4eElDOHZJREUyTURBd0NpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NtVndiR0ZqWlRJZ05qUUtJQ0FnSUhOMGIzSmxJREFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmthV2NnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTXlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeU1Eb0tJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeU1Rb0tiV0ZwYmw5eVpYUjFjbTQxTURCSmJuWnZhV05sYzBKNVJHRjBaWE5mY205MWRHVkFOem9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRESTFOZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1qVUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYek1nTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2dwdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1qWTZDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm05MElIQmhlV0ZpYkdVS0lDQWdJR2x1ZEdOZk1TQXZMeUF4TmpBd01Bb2dJQ0FnWW5wbGNtOEtJQ0FnSUdsdWRHTWdOQ0F2THlBME9EQXdNQW9nSUNBZ1lucGxjbThLSUNBZ0lHbHVkR01nTlNBdkx5QXpNakF3TUFvZ0lDQWdZbnBsY204S0lDQWdJR3h2WVdRZ01Bb2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdZbnBsY204S0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6QWdMeThnT0RnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6RWdMeThnTVRZd01EQUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR1JwWnlBeENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdjbVZ3YkdGalpUSWdOalFLSUNBZ0lITjBiM0psSURBS0lDQWdJR3h2WVdRZ01Bb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnT0RnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6RWdMeThnTVRZd01EQUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR1JwWnlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhKbGNHeGhZMlV5SURZMENpQWdJQ0J6ZEc5eVpTQXdDaUFnSUNCc2IyRmtJREFLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEZzRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2FXNTBZeUEwSUM4dklEUTRNREF3Q2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnlaWEJzWVdObE1pQTJOQW9nSUNBZ2MzUnZjbVVnTUFvZ0lDQWdiRzloWkNBd0NpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUE0T0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdNZ05DQXZMeUEwT0RBd01Bb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdaR2xuSURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnY21Wd2JHRmpaVElnTmpRS0lDQWdJSE4wYjNKbElEQUtJQ0FnSUd4dllXUWdNQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z09EZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpJRFVnTHk4Z016SXdNREFLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUdScFp5QXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lISmxjR3hoWTJVeUlEWTBDaUFnSUNCemRHOXlaU0F3Q2lBZ0lDQnNiMkZrSURBS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJRGc0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4eElDOHZJREUyTURBd0NpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NtVndiR0ZqWlRJZ05qUUtJQ0FnSUhOMGIzSmxJREFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmthV2NnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTXlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeU5Ub0tJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeU5nb0tiV0ZwYmw5dWNtVmthWFJmY205MWRHVkFOam9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnWW5vZ2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFETXdDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh6SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFETXhPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0JwYm5Salh6RWdMeThnTVRZd01EQUtJQ0FnSUdKNlpYSnZDaUFnSUNCc2IyRmtJREFLSUNBZ0lIQjFjMmhwYm5RZ01qUUtJQ0FnSUdKNlpYSnZDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh3SUM4dklEZzRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2FXNTBZMTh4SUM4dklERTJNREF3Q2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCa2FXY2dNUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUhKbGNHeGhZMlV5SURZMENpQWdJQ0J6ZEc5eVpTQXdDaUFnSUNCc2IyRmtJREFLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEZzRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2FXNTBZMTh4SUM4dklERTJNREF3Q2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnlaWEJzWVdObE1pQTJOQW9nSUNBZ2MzUnZjbVVnTUFvZ0lDQWdiRzloWkNBd0NpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUE0T0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4TmpBd01Bb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdaR2xuSURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnY21Wd2JHRmpaVElnTmpRS0lDQWdJSE4wYjNKbElEQUtJQ0FnSUd4dllXUWdNQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z09EZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYekVnTHk4Z01UWXdNREFLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J5WlhCc1lXTmxNaUEyTkFvZ0lDQWdjM1J2Y21VZ01Bb2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk15QXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQXpNRG9LSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQXpNUW9LYldGcGJsOWZYM0J2YzNSSmJtbDBYM0p2ZFhSbFFEVTZDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmZYMk4wYjNKZmNHVnVaR2x1WnlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnWDE5d2IzTjBTVzVwZENCaGJISmxZV1I1SUdOaGJHeGxaQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlYMTlqZEc5eVgzQmxibVJwYm1jaUNpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWalh6TWdMeThnSW1sdWRtOXBZMlZ6SWdvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNCaWIzaGZZM0psWVhSbENpQWdJQ0J3YjNBS0lDQWdJR2x1ZEdOZk15QXZMeUF4Q2lBZ0lDQnlaWFIxY200SyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2ZEdWemRITXZjMjlzYVdScGRIa3RjMlZ0WVc1MGFXTXRkR1Z6ZEhNdmRHVnpkSE12ZG1GeWFXOTFjeTl1WldkaGRHbDJaVjl6ZEdGamExOW9aV2xuYUhRdWMyOXNMa011WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUdXSUI5QUFHQTl3S0ErZ0VtQkFFQUJCVWZmSFVPWDE5amRHOXlYM0JsYm1ScGJtY0lhVzUyYjJsalpYTWtnWUFncjBrMUJUVUFOQUNBSUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQ0FYRUExQURFWVFBQUZLaVZuSlVNeEdSUkVNUmhFZ2dVRXVzeEo0d1M4Wi8wU0JPUitEc2dFWkUyekhBVEYvYllsTmhvQWpnVUNiQUg3QVVzQW5BQUJBRFlhQVVsRkFoV0JJQkpFTVJaQkFJY3hGaVVKT0FnVVJJRWdyMHNCVUVrVmdTQUpnU0JZQVN0TVVMNkFJUUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFFNENUVWxYQUNCTEFZR0FBbE1vSkU4Q1ZDUlRTd0tCZ1FKVEtDUlBBbFFrVTA4RGdZSUNVeWdrVHdKVUpGT0JRSzlQQktzb0pFOEZWQ1ZQQkZTQkFrOERWRkFwVEZDd0pVTWtRdjk3TmhvQkZZRWdFa1EyR2dJVmdTQVNSRFlhQXhXQklCSkVNUlpCQUk0eEZpVUpPQWdVUkNPdklRU3ZJUVd2TkFDQkdLOUxBU0piSXdnV1N3Rk1VRThDVEZ4QU5RQTBBRWtpV3lNSUZrc0NURkJjUURVQU5BQkpJbHNqQ0JaTEFreFFYRUExQURRQVNTSmJJUVFJRmtzQ1RGQmNRRFVBTkFCSklsc2hCUWdXU3dKTVVGeEFOUUEwQUVraVd5TUlGazhDVEZCY1FEVUFTd0pMQTFCTEExQlBBbEJNVUV4UUtVeFFzQ1ZESkVML2REWWFBUldCSUJKRU5ob0NGWUVnRWtRMkdnTVZnU0FTUkRFV1FRQ1BNUllsQ1RnSUZFUWpyeUVFcnlFRnJ6UUFnUml2U3dFaVd5TUlGa3NCVEZCUEFreGNRRFVBTkFCSklsc2pDQlpMQWt4UVhFQTFBRFFBU1NKYklRUUlGa3NDVEZCY1FEVUFOQUJKSWxzaEJBZ1dTd0pNVUZ4QU5RQTBBRWtpV3lFRkNCWkxBa3hRWEVBMUFEUUFTU0piSXdnV1R3Sk1VRnhBTlFCTEFrc0RVRXNDVUU4Q1VFeFFURkFwVEZDd0pVTWtRdjl6TmhvQkZZRWdFa1F4RmtFQVlERVdKUWs0Q0JSRUk2ODBBSUVZcjBzQklsc2pDQlpMQVV4UVR3Sk1YRUExQURRQVNTSmJJd2dXU3dKTVVGeEFOUUEwQUVraVd5TUlGa3NDVEZCY1FEVUFOQUJKSWxzakNCWlBBa3hRWEVBMUFFbExBVkJMQVZCTVVDbE1VTEFsUXlSQy82SXFaRVFxSkdjcmdRSzVTQ1ZEIiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
