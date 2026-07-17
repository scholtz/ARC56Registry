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

namespace Arc56.Generated.JoseLili.registro_empresarial_blockchain.RegistroEmpresarial_a1e559cd
{


    public class RegistroEmpresarialProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public RegistroEmpresarialProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class DatosEmpresa : AVMObjectType
            {
                public string RazonSocial { get; set; }

                public string Rfc { get; set; }

                public string TipoSociedad { get; set; }

                public string Estatus { get; set; }

                public string RepresentanteLegal { get; set; }

                public string DomicilioFiscal { get; set; }

                public string RepartoAcciones { get; set; }

                public ulong NumeroNotaria { get; set; }

                public string PermisoUsoNombre { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRazonSocial = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vRazonSocial.From(RazonSocial);
                    stringRef[ret.Count] = vRazonSocial.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRfc = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vRfc.From(Rfc);
                    stringRef[ret.Count] = vRfc.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTipoSociedad = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vTipoSociedad.From(TipoSociedad);
                    stringRef[ret.Count] = vTipoSociedad.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEstatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vEstatus.From(Estatus);
                    stringRef[ret.Count] = vEstatus.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRepresentanteLegal = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vRepresentanteLegal.From(RepresentanteLegal);
                    stringRef[ret.Count] = vRepresentanteLegal.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDomicilioFiscal = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vDomicilioFiscal.From(DomicilioFiscal);
                    stringRef[ret.Count] = vDomicilioFiscal.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRepartoAcciones = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vRepartoAcciones.From(RepartoAcciones);
                    stringRef[ret.Count] = vRepartoAcciones.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNumeroNotaria = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vNumeroNotaria.From(NumeroNotaria);
                    ret.AddRange(vNumeroNotaria.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPermisoUsoNombre = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vPermisoUsoNombre.From(PermisoUsoNombre);
                    stringRef[ret.Count] = vPermisoUsoNombre.Encode();
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

                public static DatosEmpresa Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new DatosEmpresa();
                    uint count = 0;
                    var indexRazonSocial = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRazonSocial = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vRazonSocial.Decode(bytes.Skip(indexRazonSocial + prefixOffset).ToArray());
                    var valueRazonSocial = vRazonSocial.ToValue();
                    if (valueRazonSocial is string vRazonSocialValue) { ret.RazonSocial = vRazonSocialValue; }
                    var indexRfc = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRfc = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vRfc.Decode(bytes.Skip(indexRfc + prefixOffset).ToArray());
                    var valueRfc = vRfc.ToValue();
                    if (valueRfc is string vRfcValue) { ret.Rfc = vRfcValue; }
                    var indexTipoSociedad = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTipoSociedad = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vTipoSociedad.Decode(bytes.Skip(indexTipoSociedad + prefixOffset).ToArray());
                    var valueTipoSociedad = vTipoSociedad.ToValue();
                    if (valueTipoSociedad is string vTipoSociedadValue) { ret.TipoSociedad = vTipoSociedadValue; }
                    var indexEstatus = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEstatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vEstatus.Decode(bytes.Skip(indexEstatus + prefixOffset).ToArray());
                    var valueEstatus = vEstatus.ToValue();
                    if (valueEstatus is string vEstatusValue) { ret.Estatus = vEstatusValue; }
                    var indexRepresentanteLegal = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRepresentanteLegal = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vRepresentanteLegal.Decode(bytes.Skip(indexRepresentanteLegal + prefixOffset).ToArray());
                    var valueRepresentanteLegal = vRepresentanteLegal.ToValue();
                    if (valueRepresentanteLegal is string vRepresentanteLegalValue) { ret.RepresentanteLegal = vRepresentanteLegalValue; }
                    var indexDomicilioFiscal = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDomicilioFiscal = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vDomicilioFiscal.Decode(bytes.Skip(indexDomicilioFiscal + prefixOffset).ToArray());
                    var valueDomicilioFiscal = vDomicilioFiscal.ToValue();
                    if (valueDomicilioFiscal is string vDomicilioFiscalValue) { ret.DomicilioFiscal = vDomicilioFiscalValue; }
                    var indexRepartoAcciones = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRepartoAcciones = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vRepartoAcciones.Decode(bytes.Skip(indexRepartoAcciones + prefixOffset).ToArray());
                    var valueRepartoAcciones = vRepartoAcciones.ToValue();
                    if (valueRepartoAcciones is string vRepartoAccionesValue) { ret.RepartoAcciones = vRepartoAccionesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNumeroNotaria = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vNumeroNotaria.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNumeroNotaria = vNumeroNotaria.ToValue();
                    if (valueNumeroNotaria is ulong vNumeroNotariaValue) { ret.NumeroNotaria = vNumeroNotariaValue; }
                    var indexPermisoUsoNombre = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPermisoUsoNombre = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vPermisoUsoNombre.Decode(bytes.Skip(indexPermisoUsoNombre + prefixOffset).ToArray());
                    var valuePermisoUsoNombre = vPermisoUsoNombre.ToValue();
                    if (valuePermisoUsoNombre is string vPermisoUsoNombreValue) { ret.PermisoUsoNombre = vPermisoUsoNombreValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as DatosEmpresa);
                }
                public bool Equals(DatosEmpresa? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(DatosEmpresa left, DatosEmpresa right)
                {
                    return EqualityComparer<DatosEmpresa>.Default.Equals(left, right);
                }
                public static bool operator !=(DatosEmpresa left, DatosEmpresa right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class RegistradorAgregadoEvent
            {
                public static readonly byte[] Selector = new byte[4] { 42, 90, 5, 183 };
                public const string Signature = "RegistradorAgregado(address)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Cuenta { get; set; }

                public static RegistradorAgregadoEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new RegistradorAgregadoEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCuenta = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vCuenta.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCuenta = vCuenta.ToValue();
                    if (valueCuenta is Algorand.Address vCuentaValue) { ret.Cuenta = vCuentaValue; }
                    return ret;

                }

            }

            public class RegistradorRemovidoEvent
            {
                public static readonly byte[] Selector = new byte[4] { 50, 51, 65, 12 };
                public const string Signature = "RegistradorRemovido(address)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Cuenta { get; set; }

                public static RegistradorRemovidoEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new RegistradorRemovidoEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCuenta = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vCuenta.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCuenta = vCuenta.ToValue();
                    if (valueCuenta is Algorand.Address vCuentaValue) { ret.Cuenta = vCuentaValue; }
                    return ret;

                }

            }

            public class EmpresaRegistradaEvent
            {
                public static readonly byte[] Selector = new byte[4] { 2, 114, 138, 255 };
                public const string Signature = "EmpresaRegistrada(string,string,string,uint64,address)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public string Expediente { get; set; }
                public string RazonSocial { get; set; }
                public string TipoSociedad { get; set; }
                public ulong NumeroNotaria { get; set; }
                public Algorand.Address Registrador { get; set; }

                public static EmpresaRegistradaEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new EmpresaRegistradaEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    var indexExpediente = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpediente = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vExpediente.Decode(eventData.Skip(indexExpediente).ToArray());
                    var valueExpediente = vExpediente.ToValue();
                    if (valueExpediente is string vExpedienteValue) { ret.Expediente = vExpedienteValue; }
                    var indexRazonSocial = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRazonSocial = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vRazonSocial.Decode(eventData.Skip(indexRazonSocial).ToArray());
                    var valueRazonSocial = vRazonSocial.ToValue();
                    if (valueRazonSocial is string vRazonSocialValue) { ret.RazonSocial = vRazonSocialValue; }
                    var indexTipoSociedad = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTipoSociedad = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vTipoSociedad.Decode(eventData.Skip(indexTipoSociedad).ToArray());
                    var valueTipoSociedad = vTipoSociedad.ToValue();
                    if (valueTipoSociedad is string vTipoSociedadValue) { ret.TipoSociedad = vTipoSociedadValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNumeroNotaria = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vNumeroNotaria.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNumeroNotaria = vNumeroNotaria.ToValue();
                    if (valueNumeroNotaria is ulong vNumeroNotariaValue) { ret.NumeroNotaria = vNumeroNotariaValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRegistrador = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vRegistrador.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRegistrador = vRegistrador.ToValue();
                    if (valueRegistrador is Algorand.Address vRegistradorValue) { ret.Registrador = vRegistradorValue; }
                    return ret;

                }

            }

            public class RfcRegistradoEvent
            {
                public static readonly byte[] Selector = new byte[4] { 13, 172, 147, 210 };
                public const string Signature = "RFCRegistrado(string,string,address)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public string Expediente { get; set; }
                public string Rfc { get; set; }
                public Algorand.Address Registrador { get; set; }

                public static RfcRegistradoEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new RfcRegistradoEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    var indexExpediente = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpediente = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vExpediente.Decode(eventData.Skip(indexExpediente).ToArray());
                    var valueExpediente = vExpediente.ToValue();
                    if (valueExpediente is string vExpedienteValue) { ret.Expediente = vExpedienteValue; }
                    var indexRfc = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRfc = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vRfc.Decode(eventData.Skip(indexRfc).ToArray());
                    var valueRfc = vRfc.ToValue();
                    if (valueRfc is string vRfcValue) { ret.Rfc = vRfcValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRegistrador = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vRegistrador.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRegistrador = vRegistrador.ToValue();
                    if (valueRegistrador is Algorand.Address vRegistradorValue) { ret.Registrador = vRegistradorValue; }
                    return ret;

                }

            }

            public class CampoActualizadoEvent
            {
                public static readonly byte[] Selector = new byte[4] { 53, 194, 179, 120 };
                public const string Signature = "CampoActualizado(string,string,string,address)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public string Expediente { get; set; }
                public string Campo { get; set; }
                public string ValorNuevo { get; set; }
                public Algorand.Address Registrador { get; set; }

                public static CampoActualizadoEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new CampoActualizadoEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    var indexExpediente = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpediente = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vExpediente.Decode(eventData.Skip(indexExpediente).ToArray());
                    var valueExpediente = vExpediente.ToValue();
                    if (valueExpediente is string vExpedienteValue) { ret.Expediente = vExpedienteValue; }
                    var indexCampo = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCampo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vCampo.Decode(eventData.Skip(indexCampo).ToArray());
                    var valueCampo = vCampo.ToValue();
                    if (valueCampo is string vCampoValue) { ret.Campo = vCampoValue; }
                    var indexValorNuevo = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vValorNuevo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vValorNuevo.Decode(eventData.Skip(indexValorNuevo).ToArray());
                    var valueValorNuevo = vValorNuevo.ToValue();
                    if (valueValorNuevo is string vValorNuevoValue) { ret.ValorNuevo = vValorNuevoValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRegistrador = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vRegistrador.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRegistrador = vRegistrador.ToValue();
                    if (valueRegistrador is Algorand.Address vRegistradorValue) { ret.Registrador = vRegistradorValue; }
                    return ret;

                }

            }

            public class EstatusModificadoEvent
            {
                public static readonly byte[] Selector = new byte[4] { 123, 190, 61, 3 };
                public const string Signature = "EstatusModificado(string,string,string,address)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public string Expediente { get; set; }
                public string EstatusAnterior { get; set; }
                public string EstatusNuevo { get; set; }
                public Algorand.Address Registrador { get; set; }

                public static EstatusModificadoEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new EstatusModificadoEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    var indexExpediente = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpediente = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vExpediente.Decode(eventData.Skip(indexExpediente).ToArray());
                    var valueExpediente = vExpediente.ToValue();
                    if (valueExpediente is string vExpedienteValue) { ret.Expediente = vExpedienteValue; }
                    var indexEstatusAnterior = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEstatusAnterior = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vEstatusAnterior.Decode(eventData.Skip(indexEstatusAnterior).ToArray());
                    var valueEstatusAnterior = vEstatusAnterior.ToValue();
                    if (valueEstatusAnterior is string vEstatusAnteriorValue) { ret.EstatusAnterior = vEstatusAnteriorValue; }
                    var indexEstatusNuevo = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEstatusNuevo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vEstatusNuevo.Decode(eventData.Skip(indexEstatusNuevo).ToArray());
                    var valueEstatusNuevo = vEstatusNuevo.ToValue();
                    if (valueEstatusNuevo is string vEstatusNuevoValue) { ret.EstatusNuevo = vEstatusNuevoValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRegistrador = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vRegistrador.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRegistrador = vRegistrador.ToValue();
                    if (valueRegistrador is Algorand.Address vRegistradorValue) { ret.Registrador = vRegistradorValue; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///Se ejecuta una sola vez al desplegar. El deployer se vuelve admin.
        ///</summary>
        public async Task Crear(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 139, 193, 110, 189 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Crear_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 139, 193, 110, 189 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="cuenta"> </param>
        public async Task AgregarRegistrador(Algorand.Address cuenta, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 99, 210, 38 };
            var cuentaAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); cuentaAbi.From(cuenta);

            var result = await base.CallApp(new List<object> { abiHandle, cuentaAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AgregarRegistrador_Transactions(Algorand.Address cuenta, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 99, 210, 38 };
            var cuentaAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); cuentaAbi.From(cuenta);

            return await base.MakeTransactionList(new List<object> { abiHandle, cuentaAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="cuenta"> </param>
        public async Task RemoverRegistrador(Algorand.Address cuenta, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 188, 198, 20, 212 };
            var cuentaAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); cuentaAbi.From(cuenta);

            var result = await base.CallApp(new List<object> { abiHandle, cuentaAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RemoverRegistrador_Transactions(Algorand.Address cuenta, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 188, 198, 20, 212 };
            var cuentaAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); cuentaAbi.From(cuenta);

            return await base.MakeTransactionList(new List<object> { abiHandle, cuentaAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Da de alta una empresa. El expediente notarial es el identificador único.
        ///El RFC inicia vacío — se registra después con registrar_rfc().
        ///</summary>
        /// <param name="expediente"> </param>
        /// <param name="razon_social"> </param>
        /// <param name="tipo_sociedad"> </param>
        /// <param name="representante_legal"> </param>
        /// <param name="domicilio_fiscal"> </param>
        /// <param name="reparto_acciones"> </param>
        /// <param name="numero_notaria"> </param>
        /// <param name="permiso_uso_nombre"> </param>
        public async Task RegistrarEmpresa(string expediente, string razon_social, string tipo_sociedad, string representante_legal, string domicilio_fiscal, string reparto_acciones, ulong numero_notaria, string permiso_uso_nombre, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 83, 253, 9, 135 };
            var expedienteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); expedienteAbi.From(expediente);
            var razon_socialAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); razon_socialAbi.From(razon_social);
            var tipo_sociedadAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); tipo_sociedadAbi.From(tipo_sociedad);
            var representante_legalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); representante_legalAbi.From(representante_legal);
            var domicilio_fiscalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); domicilio_fiscalAbi.From(domicilio_fiscal);
            var reparto_accionesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); reparto_accionesAbi.From(reparto_acciones);
            var numero_notariaAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); numero_notariaAbi.From(numero_notaria);
            var permiso_uso_nombreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); permiso_uso_nombreAbi.From(permiso_uso_nombre);

            var result = await base.CallApp(new List<object> { abiHandle, expedienteAbi, razon_socialAbi, tipo_sociedadAbi, representante_legalAbi, domicilio_fiscalAbi, reparto_accionesAbi, numero_notariaAbi, permiso_uso_nombreAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RegistrarEmpresa_Transactions(string expediente, string razon_social, string tipo_sociedad, string representante_legal, string domicilio_fiscal, string reparto_acciones, ulong numero_notaria, string permiso_uso_nombre, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 83, 253, 9, 135 };
            var expedienteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); expedienteAbi.From(expediente);
            var razon_socialAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); razon_socialAbi.From(razon_social);
            var tipo_sociedadAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); tipo_sociedadAbi.From(tipo_sociedad);
            var representante_legalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); representante_legalAbi.From(representante_legal);
            var domicilio_fiscalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); domicilio_fiscalAbi.From(domicilio_fiscal);
            var reparto_accionesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); reparto_accionesAbi.From(reparto_acciones);
            var numero_notariaAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); numero_notariaAbi.From(numero_notaria);
            var permiso_uso_nombreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); permiso_uso_nombreAbi.From(permiso_uso_nombre);

            return await base.MakeTransactionList(new List<object> { abiHandle, expedienteAbi, razon_socialAbi, tipo_sociedadAbi, representante_legalAbi, domicilio_fiscalAbi, reparto_accionesAbi, numero_notariaAbi, permiso_uso_nombreAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Registra el RFC de una empresa. Solo puede hacerse una vez.
        ///El RFC llega después de la constitución — no al momento del alta.
        ///</summary>
        /// <param name="expediente"> </param>
        /// <param name="rfc"> </param>
        public async Task RegistrarRfc(string expediente, string rfc, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 181, 142, 157 };
            var expedienteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); expedienteAbi.From(expediente);
            var rfcAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); rfcAbi.From(rfc);

            var result = await base.CallApp(new List<object> { abiHandle, expedienteAbi, rfcAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RegistrarRfc_Transactions(string expediente, string rfc, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 181, 142, 157 };
            var expedienteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); expedienteAbi.From(expediente);
            var rfcAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); rfcAbi.From(rfc);

            return await base.MakeTransactionList(new List<object> { abiHandle, expedienteAbi, rfcAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="expediente"> </param>
        /// <param name="valor"> </param>
        public async Task ActualizarRazonSocial(string expediente, string valor, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 55, 199, 209, 19 };
            var expedienteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); expedienteAbi.From(expediente);
            var valorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valorAbi.From(valor);

            var result = await base.CallApp(new List<object> { abiHandle, expedienteAbi, valorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ActualizarRazonSocial_Transactions(string expediente, string valor, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 55, 199, 209, 19 };
            var expedienteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); expedienteAbi.From(expediente);
            var valorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valorAbi.From(valor);

            return await base.MakeTransactionList(new List<object> { abiHandle, expedienteAbi, valorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="expediente"> </param>
        /// <param name="valor"> </param>
        public async Task ActualizarRepresentanteLegal(string expediente, string valor, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 110, 41, 73, 147 };
            var expedienteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); expedienteAbi.From(expediente);
            var valorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valorAbi.From(valor);

            var result = await base.CallApp(new List<object> { abiHandle, expedienteAbi, valorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ActualizarRepresentanteLegal_Transactions(string expediente, string valor, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 110, 41, 73, 147 };
            var expedienteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); expedienteAbi.From(expediente);
            var valorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valorAbi.From(valor);

            return await base.MakeTransactionList(new List<object> { abiHandle, expedienteAbi, valorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="expediente"> </param>
        /// <param name="valor"> </param>
        public async Task ActualizarDomicilio(string expediente, string valor, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 156, 16, 219, 48 };
            var expedienteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); expedienteAbi.From(expediente);
            var valorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valorAbi.From(valor);

            var result = await base.CallApp(new List<object> { abiHandle, expedienteAbi, valorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ActualizarDomicilio_Transactions(string expediente, string valor, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 156, 16, 219, 48 };
            var expedienteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); expedienteAbi.From(expediente);
            var valorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valorAbi.From(valor);

            return await base.MakeTransactionList(new List<object> { abiHandle, expedienteAbi, valorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="expediente"> </param>
        /// <param name="valor"> </param>
        public async Task ActualizarRepartoAcciones(string expediente, string valor, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 76, 133, 232 };
            var expedienteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); expedienteAbi.From(expediente);
            var valorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valorAbi.From(valor);

            var result = await base.CallApp(new List<object> { abiHandle, expedienteAbi, valorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ActualizarRepartoAcciones_Transactions(string expediente, string valor, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 76, 133, 232 };
            var expedienteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); expedienteAbi.From(expediente);
            var valorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valorAbi.From(valor);

            return await base.MakeTransactionList(new List<object> { abiHandle, expedienteAbi, valorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="expediente"> </param>
        /// <param name="valor"> </param>
        public async Task ActualizarPermisoUsoNombre(string expediente, string valor, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 184, 248, 96 };
            var expedienteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); expedienteAbi.From(expediente);
            var valorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valorAbi.From(valor);

            var result = await base.CallApp(new List<object> { abiHandle, expedienteAbi, valorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ActualizarPermisoUsoNombre_Transactions(string expediente, string valor, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 184, 248, 96 };
            var expedienteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); expedienteAbi.From(expediente);
            var valorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valorAbi.From(valor);

            return await base.MakeTransactionList(new List<object> { abiHandle, expedienteAbi, valorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Valores válidos: activa, suspendida, disuelta
        ///</summary>
        /// <param name="expediente"> </param>
        /// <param name="nuevo_estatus"> </param>
        public async Task CambiarEstatus(string expediente, string nuevo_estatus, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 3, 220, 98, 127 };
            var expedienteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); expedienteAbi.From(expediente);
            var nuevo_estatusAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nuevo_estatusAbi.From(nuevo_estatus);

            var result = await base.CallApp(new List<object> { abiHandle, expedienteAbi, nuevo_estatusAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CambiarEstatus_Transactions(string expediente, string nuevo_estatus, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 3, 220, 98, 127 };
            var expedienteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); expedienteAbi.From(expediente);
            var nuevo_estatusAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nuevo_estatusAbi.From(nuevo_estatus);

            return await base.MakeTransactionList(new List<object> { abiHandle, expedienteAbi, nuevo_estatusAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Cualquiera puede consultar. No genera transacción ni costo.
        ///</summary>
        /// <param name="expediente"> </param>
        public async Task<Structs.DatosEmpresa> ConsultarEmpresa(string expediente, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 220, 163, 176, 247 };
            var expedienteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); expedienteAbi.From(expediente);

            var result = await base.SimApp(new List<object> { abiHandle, expedienteAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.DatosEmpresa.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ConsultarEmpresa_Transactions(string expediente, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 220, 163, 176, 247 };
            var expedienteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); expedienteAbi.From(expediente);

            return await base.MakeTransactionList(new List<object> { abiHandle, expedienteAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="cuenta"> </param>
        public async Task<bool> EsRegistrador(Algorand.Address cuenta, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 80, 133, 17, 117 };
            var cuentaAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); cuentaAbi.From(cuenta);

            var result = await base.SimApp(new List<object> { abiHandle, cuentaAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> EsRegistrador_Transactions(Algorand.Address cuenta, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 80, 133, 17, 117 };
            var cuentaAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); cuentaAbi.From(cuenta);

            return await base.MakeTransactionList(new List<object> { abiHandle, cuentaAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> ObtenerTotal(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 156, 187, 169, 70 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ObtenerTotal_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 156, 187, 169, 70 };

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

        protected override ulong? ExtraProgramPages { get; set; } = 1;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUmVnaXN0cm9FbXByZXNhcmlhbCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJEYXRvc0VtcHJlc2EiOlt7Im5hbWUiOiJyYXpvbl9zb2NpYWwiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoicmZjIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6InRpcG9fc29jaWVkYWQiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiZXN0YXR1cyIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJyZXByZXNlbnRhbnRlX2xlZ2FsIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImRvbWljaWxpb19maXNjYWwiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoicmVwYXJ0b19hY2Npb25lcyIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJudW1lcm9fbm90YXJpYSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJwZXJtaXNvX3Vzb19ub21icmUiLCJ0eXBlIjoic3RyaW5nIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWFyIiwiZGVzYyI6IlNlIGVqZWN1dGEgdW5hIHNvbGEgdmV6IGFsIGRlc3BsZWdhci4gRWwgZGVwbG95ZXIgc2UgdnVlbHZlIGFkbWluLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhZ3JlZ2FyX3JlZ2lzdHJhZG9yIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjdWVudGEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlJlZ2lzdHJhZG9yQWdyZWdhZG8iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImN1ZW50YSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlbW92ZXJfcmVnaXN0cmFkb3IiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImN1ZW50YSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiUmVnaXN0cmFkb3JSZW1vdmlkbyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY3VlbnRhIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVnaXN0cmFyX2VtcHJlc2EiLCJkZXNjIjoiRGEgZGUgYWx0YSB1bmEgZW1wcmVzYS4gRWwgZXhwZWRpZW50ZSBub3RhcmlhbCBlcyBlbCBpZGVudGlmaWNhZG9yIMO6bmljby5cbkVsIFJGQyBpbmljaWEgdmFjw61vIOKAlCBzZSByZWdpc3RyYSBkZXNwdcOpcyBjb24gcmVnaXN0cmFyX3JmYygpLiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJleHBlZGllbnRlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyYXpvbl9zb2NpYWwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRpcG9fc29jaWVkYWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlcHJlc2VudGFudGVfbGVnYWwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRvbWljaWxpb19maXNjYWwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlcGFydG9fYWNjaW9uZXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im51bWVyb19ub3RhcmlhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwZXJtaXNvX3Vzb19ub21icmUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkVtcHJlc2FSZWdpc3RyYWRhIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV4cGVkaWVudGUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyYXpvbl9zb2NpYWwiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0aXBvX3NvY2llZGFkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibnVtZXJvX25vdGFyaWEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVnaXN0cmFkb3IiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWdpc3RyYXJfcmZjIiwiZGVzYyI6IlJlZ2lzdHJhIGVsIFJGQyBkZSB1bmEgZW1wcmVzYS4gU29sbyBwdWVkZSBoYWNlcnNlIHVuYSB2ZXouXG5FbCBSRkMgbGxlZ2EgZGVzcHXDqXMgZGUgbGEgY29uc3RpdHVjacOzbiDigJQgbm8gYWwgbW9tZW50byBkZWwgYWx0YS4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXhwZWRpZW50ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmZjIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJSRkNSZWdpc3RyYWRvIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV4cGVkaWVudGUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZmMiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVnaXN0cmFkb3IiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhY3R1YWxpemFyX3Jhem9uX3NvY2lhbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJleHBlZGllbnRlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWxvciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQ2FtcG9BY3R1YWxpemFkbyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJleHBlZGllbnRlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FtcG8iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWxvcl9udWV2byIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWdpc3RyYWRvciIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFjdHVhbGl6YXJfcmVwcmVzZW50YW50ZV9sZWdhbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJleHBlZGllbnRlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWxvciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQ2FtcG9BY3R1YWxpemFkbyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJleHBlZGllbnRlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FtcG8iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWxvcl9udWV2byIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWdpc3RyYWRvciIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFjdHVhbGl6YXJfZG9taWNpbGlvIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV4cGVkaWVudGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbG9yIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJDYW1wb0FjdHVhbGl6YWRvIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV4cGVkaWVudGUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYW1wbyIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbG9yX251ZXZvIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZ2lzdHJhZG9yIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWN0dWFsaXphcl9yZXBhcnRvX2FjY2lvbmVzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV4cGVkaWVudGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbG9yIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJDYW1wb0FjdHVhbGl6YWRvIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV4cGVkaWVudGUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYW1wbyIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbG9yX251ZXZvIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZ2lzdHJhZG9yIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWN0dWFsaXphcl9wZXJtaXNvX3Vzb19ub21icmUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXhwZWRpZW50ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsb3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkNhbXBvQWN0dWFsaXphZG8iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXhwZWRpZW50ZSIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhbXBvIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsb3JfbnVldm8iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVnaXN0cmFkb3IiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYW1iaWFyX2VzdGF0dXMiLCJkZXNjIjoiVmFsb3JlcyB2w6FsaWRvczogYWN0aXZhLCBzdXNwZW5kaWRhLCBkaXN1ZWx0YSIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJleHBlZGllbnRlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJudWV2b19lc3RhdHVzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJFc3RhdHVzTW9kaWZpY2FkbyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJleHBlZGllbnRlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXN0YXR1c19hbnRlcmlvciIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImVzdGF0dXNfbnVldm8iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVnaXN0cmFkb3IiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjb25zdWx0YXJfZW1wcmVzYSIsImRlc2MiOiJDdWFscXVpZXJhIHB1ZWRlIGNvbnN1bHRhci4gTm8gZ2VuZXJhIHRyYW5zYWNjacOzbiBuaSBjb3N0by4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXhwZWRpZW50ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoc3RyaW5nLHN0cmluZyxzdHJpbmcsc3RyaW5nLHN0cmluZyxzdHJpbmcsc3RyaW5nLHVpbnQ2NCxzdHJpbmcpIiwic3RydWN0IjoiRGF0b3NFbXByZXNhIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJlc19yZWdpc3RyYWRvciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY3VlbnRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib2J0ZW5lcl90b3RhbCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls4NzJdLCJlcnJvck1lc3NhZ2UiOiJFbCBSRkMgeWEgZnVlIHJlZ2lzdHJhZG8geSBubyBwdWVkZSBtb2RpZmljYXJzZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQyNl0sImVycm9yTWVzc2FnZSI6IkVsIGV4cGVkaWVudGUgeWEgZXN0w6EgcmVnaXN0cmFkbyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg0NSwxMDk1LDEzNTUsMTU1NiwxNzM3LDE4OTQsMjAyMiwyMjg4XSwiZXJyb3JNZXNzYWdlIjoiRW1wcmVzYSBubyBlbmNvbnRyYWRhIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjA3Ml0sImVycm9yTWVzc2FnZSI6IkVzdGF0dXMgaW52w6FsaWRvLiBVc2U6IGFjdGl2YSwgc3VzcGVuZGlkYSBvIGRpc3VlbHRhIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjYzXSwiZXJyb3JNZXNzYWdlIjoiTGEgY3VlbnRhIG5vIGVzIHJlZ2lzdHJhZG9yYSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgzNiwxMDg2LDEzNDYsMTU0NywxNzI4LDE4ODUsMjAxMV0sImVycm9yTWVzc2FnZSI6Ik5vIGF1dG9yaXphZG8iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MTRdLCJlcnJvck1lc3NhZ2UiOiJObyBhdXRvcml6YWRvIHBhcmEgcmVnaXN0cmFyIGVtcHJlc2FzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjE1XSwiZXJyb3JNZXNzYWdlIjoiU29sbyBlbCBhZG1pbiBwdWVkZSBhZ3JlZ2FyIHJlZ2lzdHJhZG9yZXMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNTNdLCJlcnJvck1lc3NhZ2UiOiJTb2xvIGVsIGFkbWluIHB1ZWRlIHJlbW92ZXIgcmVnaXN0cmFkb3JlcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU4OV0sImVycm9yTWVzc2FnZSI6IlRpcG8gZGUgc29jaWVkYWQgbm8gdsOhbGlkbyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxMywyNTFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFkbWluIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwNzddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmVtcHJlc2FzIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzMjAsMjM2NF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYucmVnaXN0cmFkb3JlcyBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NDAsMjMzN10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfZW1wcmVzYXMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjgzLDMwMiwzMjAsMzM5LDM1NywzNzUsNDA0LDgwNiw4MjIsMTA1NiwxMDcyLDEzMTYsMTMzMiwxNTE3LDE1MzMsMTY5OCwxNzE0LDE4NTgsMTg3NCwxOTc4LDE5OTcsMjI3M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5MywzMTEsMzMwLDM0OCwzNjYsMzg0LDQxMCw4MTYsODMyLDEwNjYsMTA4MiwxMzI2LDEzNDIsMTUyNywxNTQzLDE3MDgsMTcyNCwxODY4LDE4ODEsMTk4OCwyMDA3LDIyODBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjA2LDI0NCwyMzA2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM5NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJRElnTVNBeU1nb2dJQ0FnWW5sMFpXTmliRzlqYXlBaVpXMXdjbVZ6WVhNaUlEQjRNREF5TmlBd2VETTFZekppTXpjNElDSjBiM1JoYkY5bGJYQnlaWE5oY3lJZ0luSmxaMmx6ZEhKaFpHOXlaWE1pSUNKaFpHMXBiaUlnTUhneE5URm1OMk0zTlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psWjJsemRISnZYMlZ0Y0hKbGMyRnlhV0ZzTDJOdmJuUnlZV04wTG5CNU9qVTVDaUFnSUNBdkx5QmpiR0Z6Y3lCU1pXZHBjM1J5YjBWdGNISmxjMkZ5YVdGc0tFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVpQnRZV2x1WDJOeVpXRjBaVjlPYjA5d1FERTVDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRaV00yTTJReU1qWWdNSGhpWTJNMk1UUmtOQ0F3ZURVelptUXdPVGczSURCNFpXTmlOVGhsT1dRZ01IZ3pOMk0zWkRFeE15QXdlRFpsTWprME9Ua3pJREI0T1dNeE1HUmlNekFnTUhnMFl6UmpPRFZsT0NBd2VHWXhZamhtT0RZd0lEQjRNRE5rWXpZeU4yWWdNSGhrWTJFellqQm1OeUF3ZURVd09EVXhNVGMxSURCNE9XTmlZbUU1TkRZZ0x5OGdiV1YwYUc5a0lDSmhaM0psWjJGeVgzSmxaMmx6ZEhKaFpHOXlLR0ZrWkhKbGMzTXBkbTlwWkNJc0lHMWxkR2h2WkNBaWNtVnRiM1psY2w5eVpXZHBjM1J5WVdSdmNpaGhaR1J5WlhOektYWnZhV1FpTENCdFpYUm9iMlFnSW5KbFoybHpkSEpoY2w5bGJYQnlaWE5oS0hOMGNtbHVaeXh6ZEhKcGJtY3NjM1J5YVc1bkxITjBjbWx1Wnl4emRISnBibWNzYzNSeWFXNW5MSFZwYm5RMk5DeHpkSEpwYm1jcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpY21WbmFYTjBjbUZ5WDNKbVl5aHpkSEpwYm1jc2MzUnlhVzVuS1hadmFXUWlMQ0J0WlhSb2IyUWdJbUZqZEhWaGJHbDZZWEpmY21GNmIyNWZjMjlqYVdGc0tITjBjbWx1Wnl4emRISnBibWNwZG05cFpDSXNJRzFsZEdodlpDQWlZV04wZFdGc2FYcGhjbDl5WlhCeVpYTmxiblJoYm5SbFgyeGxaMkZzS0hOMGNtbHVaeXh6ZEhKcGJtY3BkbTlwWkNJc0lHMWxkR2h2WkNBaVlXTjBkV0ZzYVhwaGNsOWtiMjFwWTJsc2FXOG9jM1J5YVc1bkxITjBjbWx1WnlsMmIybGtJaXdnYldWMGFHOWtJQ0poWTNSMVlXeHBlbUZ5WDNKbGNHRnlkRzlmWVdOamFXOXVaWE1vYzNSeWFXNW5MSE4wY21sdVp5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKaFkzUjFZV3hwZW1GeVgzQmxjbTFwYzI5ZmRYTnZYMjV2YldKeVpTaHpkSEpwYm1jc2MzUnlhVzVuS1hadmFXUWlMQ0J0WlhSb2IyUWdJbU5oYldKcFlYSmZaWE4wWVhSMWN5aHpkSEpwYm1jc2MzUnlhVzVuS1hadmFXUWlMQ0J0WlhSb2IyUWdJbU52Ym5OMWJIUmhjbDlsYlhCeVpYTmhLSE4wY21sdVp5a29jM1J5YVc1bkxITjBjbWx1Wnl4emRISnBibWNzYzNSeWFXNW5MSE4wY21sdVp5eHpkSEpwYm1jc2MzUnlhVzVuTEhWcGJuUTJOQ3h6ZEhKcGJtY3BJaXdnYldWMGFHOWtJQ0psYzE5eVpXZHBjM1J5WVdSdmNpaGhaR1J5WlhOektXSnZiMndpTENCdFpYUm9iMlFnSW05aWRHVnVaWEpmZEc5MFlXd29LWFZwYm5RMk5DSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JR0ZuY21WbllYSmZjbVZuYVhOMGNtRmtiM0lnY21WdGIzWmxjbDl5WldkcGMzUnlZV1J2Y2lCeVpXZHBjM1J5WVhKZlpXMXdjbVZ6WVNCeVpXZHBjM1J5WVhKZmNtWmpJR0ZqZEhWaGJHbDZZWEpmY21GNmIyNWZjMjlqYVdGc0lHRmpkSFZoYkdsNllYSmZjbVZ3Y21WelpXNTBZVzUwWlY5c1pXZGhiQ0JoWTNSMVlXeHBlbUZ5WDJSdmJXbGphV3hwYnlCaFkzUjFZV3hwZW1GeVgzSmxjR0Z5ZEc5ZllXTmphVzl1WlhNZ1lXTjBkV0ZzYVhwaGNsOXdaWEp0YVhOdlgzVnpiMTl1YjIxaWNtVWdZMkZ0WW1saGNsOWxjM1JoZEhWeklHTnZibk4xYkhSaGNsOWxiWEJ5WlhOaElHVnpYM0psWjJsemRISmhaRzl5SUc5aWRHVnVaWEpmZEc5MFlXd0tJQ0FnSUdWeWNnb0tiV0ZwYmw5amNtVmhkR1ZmVG05UGNFQXhPVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaV2RwYzNSeWIxOWxiWEJ5WlhOaGNtbGhiQzlqYjI1MGNtRmpkQzV3ZVRvMU9Rb2dJQ0FnTHk4Z1kyeGhjM01nVW1WbmFYTjBjbTlGYlhCeVpYTmhjbWxoYkNoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRPR0pqTVRabFltUWdMeThnYldWMGFHOWtJQ0pqY21WaGNpZ3BkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHTnlaV0Z5Q2lBZ0lDQmxjbklLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWNtVm5hWE4wY205ZlpXMXdjbVZ6WVhKcFlXd3VZMjl1ZEhKaFkzUXVVbVZuYVhOMGNtOUZiWEJ5WlhOaGNtbGhiQzVqY21WaGNsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU55WldGeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbFoybHpkSEp2WDJWdGNISmxjMkZ5YVdGc0wyTnZiblJ5WVdOMExuQjVPamN5Q2lBZ0lDQXZMeUJ6Wld4bUxtRmtiV2x1TG5aaGJIVmxJRDBnWVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBDaUFnSUNCaWVYUmxZeUExSUM4dklDSmhaRzFwYmlJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZuYVhOMGNtOWZaVzF3Y21WellYSnBZV3d2WTI5dWRISmhZM1F1Y0hrNk56TUtJQ0FnSUM4dklITmxiR1l1ZEc5MFlXeGZaVzF3Y21WellYTXVkbUZzZFdVZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0luUnZkR0ZzWDJWdGNISmxjMkZ6SWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZuYVhOMGNtOWZaVzF3Y21WellYSnBZV3d2WTI5dWRISmhZM1F1Y0hrNk5qa0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoamNtVmhkR1U5SW5KbGNYVnBjbVVpS1FvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXlaV2RwYzNSeWIxOWxiWEJ5WlhOaGNtbGhiQzVqYjI1MGNtRmpkQzVTWldkcGMzUnliMFZ0Y0hKbGMyRnlhV0ZzTG1GbmNtVm5ZWEpmY21WbmFYTjBjbUZrYjNKYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGhaM0psWjJGeVgzSmxaMmx6ZEhKaFpHOXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxaMmx6ZEhKdlgyVnRjSEpsYzJGeWFXRnNMMk52Ym5SeVlXTjBMbkI1T2pjM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxaMmx6ZEhKdlgyVnRjSEpsYzJGeWFXRnNMMk52Ym5SeVlXTjBMbkI1T2pnd0NpQWdJQ0F2THlCaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtnUFQwZ2MyVnNaaTVoWkcxcGJpNTJZV3gxWlFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRmtiV2x1SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpXZHBjM1J5YjE5bGJYQnlaWE5oY21saGJDOWpiMjUwY21GamRDNXdlVG8zT1MwNE1Rb2dJQ0FnTHk4Z1lYTnpaWEowSUNnS0lDQWdJQzh2SUNBZ0lDQmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrZ1BUMGdjMlZzWmk1aFpHMXBiaTUyWVd4MVpRb2dJQ0FnTHk4Z0tTd2dJbE52Ykc4Z1pXd2dZV1J0YVc0Z2NIVmxaR1VnWVdkeVpXZGhjaUJ5WldkcGMzUnlZV1J2Y21Weklnb2dJQ0FnWVhOelpYSjBJQzh2SUZOdmJHOGdaV3dnWVdSdGFXNGdjSFZsWkdVZ1lXZHlaV2RoY2lCeVpXZHBjM1J5WVdSdmNtVnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVm5hWE4wY205ZlpXMXdjbVZ6WVhKcFlXd3ZZMjl1ZEhKaFkzUXVjSGs2T0RJS0lDQWdJQzh2SUhObGJHWXVjbVZuYVhOMGNtRmtiM0psYzF0amRXVnVkR0ZkSUQwZ1lYSmpOQzVDYjI5c0tGUnlkV1VwQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0p5WldkcGMzUnlZV1J2Y21Weklnb2dJQ0FnWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRPREFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldkcGMzUnliMTlsYlhCeVpYTmhjbWxoYkM5amIyNTBjbUZqZEM1d2VUbzRNd29nSUNBZ0x5OGdZWEpqTkM1bGJXbDBLRkpsWjJsemRISmhaRzl5UVdkeVpXZGhaRzhvWTNWbGJuUmhQV04xWlc1MFlTa3BDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3lZVFZoTURWaU55QXZMeUJ0WlhSb2IyUWdJbEpsWjJsemRISmhaRzl5UVdkeVpXZGhaRzhvWVdSa2NtVnpjeWtpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psWjJsemRISnZYMlZ0Y0hKbGMyRnlhV0ZzTDJOdmJuUnlZV04wTG5CNU9qYzNDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV5WldkcGMzUnliMTlsYlhCeVpYTmhjbWxoYkM1amIyNTBjbUZqZEM1U1pXZHBjM1J5YjBWdGNISmxjMkZ5YVdGc0xuSmxiVzkyWlhKZmNtVm5hWE4wY21Ga2IzSmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5WlcxdmRtVnlYM0psWjJsemRISmhaRzl5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psWjJsemRISnZYMlZ0Y0hKbGMyRnlhV0ZzTDJOdmJuUnlZV04wTG5CNU9qZzFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psWjJsemRISnZYMlZ0Y0hKbGMyRnlhV0ZzTDJOdmJuUnlZV04wTG5CNU9qZzRDaUFnSUNBdkx5QmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrZ1BUMGdjMlZzWmk1aFpHMXBiaTUyWVd4MVpRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbUZrYldsdUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUZrYldsdUlHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaV2RwYzNSeWIxOWxiWEJ5WlhOaGNtbGhiQzlqYjI1MGNtRmpkQzV3ZVRvNE55MDRPUW9nSUNBZ0x5OGdZWE56WlhKMElDZ0tJQ0FnSUM4dklDQWdJQ0JoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa2dQVDBnYzJWc1ppNWhaRzFwYmk1MllXeDFaUW9nSUNBZ0x5OGdLU3dnSWxOdmJHOGdaV3dnWVdSdGFXNGdjSFZsWkdVZ2NtVnRiM1psY2lCeVpXZHBjM1J5WVdSdmNtVnpJZ29nSUNBZ1lYTnpaWEowSUM4dklGTnZiRzhnWld3Z1lXUnRhVzRnY0hWbFpHVWdjbVZ0YjNabGNpQnlaV2RwYzNSeVlXUnZjbVZ6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZuYVhOMGNtOWZaVzF3Y21WellYSnBZV3d2WTI5dWRISmhZM1F1Y0hrNk9UQUtJQ0FnSUM4dklHRnpjMlZ5ZENCamRXVnVkR0VnYVc0Z2MyVnNaaTV5WldkcGMzUnlZV1J2Y21WekxDQWlUR0VnWTNWbGJuUmhJRzV2SUdWeklISmxaMmx6ZEhKaFpHOXlZU0lLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbkpsWjJsemRISmhaRzl5WlhNaUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRXhoSUdOMVpXNTBZU0J1YnlCbGN5QnlaV2RwYzNSeVlXUnZjbUVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaV2RwYzNSeWIxOWxiWEJ5WlhOaGNtbGhiQzlqYjI1MGNtRmpkQzV3ZVRvNU1Rb2dJQ0FnTHk4Z1pHVnNJSE5sYkdZdWNtVm5hWE4wY21Ga2IzSmxjMXRqZFdWdWRHRmRDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaV2RwYzNSeWIxOWxiWEJ5WlhOaGNtbGhiQzlqYjI1MGNtRmpkQzV3ZVRvNU1nb2dJQ0FnTHk4Z1lYSmpOQzVsYldsMEtGSmxaMmx6ZEhKaFpHOXlVbVZ0YjNacFpHOG9ZM1ZsYm5SaFBXTjFaVzUwWVNrcENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnek1qTXpOREV3WXlBdkx5QnRaWFJvYjJRZ0lsSmxaMmx6ZEhKaFpHOXlVbVZ0YjNacFpHOG9ZV1JrY21WemN5a2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxaMmx6ZEhKdlgyVnRjSEpsYzJGeWFXRnNMMk52Ym5SeVlXTjBMbkI1T2pnMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXlaV2RwYzNSeWIxOWxiWEJ5WlhOaGNtbGhiQzVqYjI1MGNtRmpkQzVTWldkcGMzUnliMFZ0Y0hKbGMyRnlhV0ZzTG5KbFoybHpkSEpoY2w5bGJYQnlaWE5oVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NtVm5hWE4wY21GeVgyVnRjSEpsYzJFNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WbmFYTjBjbTlmWlcxd2NtVnpZWEpwWVd3dlkyOXVkSEpoWTNRdWNIazZPVFlLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQnVJRElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lITjNZWEFLSUNBZ0lHeGxiZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEwQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUExQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEyQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEzQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ09Bb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXpDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnYzNkaGNBb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldkcGMzUnliMTlsYlhCeVpYTmhjbWxoYkM5amIyNTBjbUZqZEM1d2VUb3hNVElLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTGw5bGMxOXlaV2RwYzNSeVlXUnZjaWdwTENBaVRtOGdZWFYwYjNKcGVtRmtieUJ3WVhKaElISmxaMmx6ZEhKaGNpQmxiWEJ5WlhOaGN5SUtJQ0FnSUdOaGJHeHpkV0lnWDJWelgzSmxaMmx6ZEhKaFpHOXlDaUFnSUNCaGMzTmxjblFnTHk4Z1RtOGdZWFYwYjNKcGVtRmtieUJ3WVhKaElISmxaMmx6ZEhKaGNpQmxiWEJ5WlhOaGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbFoybHpkSEp2WDJWdGNISmxjMkZ5YVdGc0wyTnZiblJ5WVdOMExuQjVPakV4TXdvZ0lDQWdMeThnWVhOelpYSjBJR1Y0Y0dWa2FXVnVkR1VnYm05MElHbHVJSE5sYkdZdVpXMXdjbVZ6WVhNc0lDSkZiQ0JsZUhCbFpHbGxiblJsSUhsaElHVnpkTU9oSUhKbFoybHpkSEpoWkc4aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKbGJYQnlaWE5oY3lJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUVWc0lHVjRjR1ZrYVdWdWRHVWdlV0VnWlhOMHc2RWdjbVZuYVhOMGNtRmtid29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxaMmx6ZEhKdlgyVnRjSEpsYzJGeWFXRnNMMk52Ym5SeVlXTjBMbkI1T2pJNE1Rb2dJQ0FnTHk4Z2RDQTlJSFJwY0c4dWJtRjBhWFpsQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVm5hWE4wY205ZlpXMXdjbVZ6WVhKcFlXd3ZZMjl1ZEhKaFkzUXVjSGs2TWpnekNpQWdJQ0F2THlCMElEMDlJRk4wY21sdVp5Z2lVeTVCTGlJcENpQWdJQ0J3ZFhOb1lubDBaWE1nSWxNdVFTNGlDaUFnSUNBOVBRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbFoybHpkSEp2WDJWdGNISmxjMkZ5YVdGc0wyTnZiblJ5WVdOMExuQjVPakk0TXkweU9UTUtJQ0FnSUM4dklIUWdQVDBnVTNSeWFXNW5LQ0pUTGtFdUlpa0tJQ0FnSUM4dklHOXlJSFFnUFQwZ1UzUnlhVzVuS0NKVExpQmtaU0JTTGt3dUlpa0tJQ0FnSUM4dklHOXlJSFFnUFQwZ1UzUnlhVzVuS0NKVExrRXVVeTRpS1FvZ0lDQWdMeThnYjNJZ2RDQTlQU0JUZEhKcGJtY29JbE11UXk1TUxpSXBDaUFnSUNBdkx5QnZjaUIwSUQwOUlGTjBjbWx1WnlnaVV5NURMbFl1SWlrS0lDQWdJQzh2SUc5eUlIUWdQVDBnVTNSeWFXNW5LQ0pUTGlCbGJpQk9Ma011SWlrS0lDQWdJQzh2SUc5eUlIUWdQVDBnVTNSeWFXNW5LQ0pUTGlCbGJpQkRMaUlwQ2lBZ0lDQXZMeUJ2Y2lCMElEMDlJRk4wY21sdVp5Z2lVeTRnWlc0Z1F5NGdjRzl5SUVFdUlpa0tJQ0FnSUM4dklHOXlJSFFnUFQwZ1UzUnlhVzVuS0NKVExrTXVJaWtLSUNBZ0lDOHZJRzl5SUhRZ1BUMGdVM1J5YVc1bktDSkJMa011SWlrS0lDQWdJQzh2SUc5eUlIUWdQVDBnVTNSeWFXNW5LQ0pUTGtFdVVDNUpMaUlwQ2lBZ0lDQmlibm9nY21WbmFYTjBjbUZ5WDJWdGNISmxjMkZmWW05dmJGOTBjblZsUURFeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WbmFYTjBjbTlmWlcxd2NtVnpZWEpwWVd3dlkyOXVkSEpoWTNRdWNIazZNamcwQ2lBZ0lDQXZMeUJ2Y2lCMElEMDlJRk4wY21sdVp5Z2lVeTRnWkdVZ1VpNU1MaUlwQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlVeTRnWkdVZ1VpNU1MaUlLSUNBZ0lEMDlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVm5hWE4wY205ZlpXMXdjbVZ6WVhKcFlXd3ZZMjl1ZEhKaFkzUXVjSGs2TWpnekxUSTVNd29nSUNBZ0x5OGdkQ0E5UFNCVGRISnBibWNvSWxNdVFTNGlLUW9nSUNBZ0x5OGdiM0lnZENBOVBTQlRkSEpwYm1jb0lsTXVJR1JsSUZJdVRDNGlLUW9nSUNBZ0x5OGdiM0lnZENBOVBTQlRkSEpwYm1jb0lsTXVRUzVUTGlJcENpQWdJQ0F2THlCdmNpQjBJRDA5SUZOMGNtbHVaeWdpVXk1RExrd3VJaWtLSUNBZ0lDOHZJRzl5SUhRZ1BUMGdVM1J5YVc1bktDSlRMa011Vmk0aUtRb2dJQ0FnTHk4Z2IzSWdkQ0E5UFNCVGRISnBibWNvSWxNdUlHVnVJRTR1UXk0aUtRb2dJQ0FnTHk4Z2IzSWdkQ0E5UFNCVGRISnBibWNvSWxNdUlHVnVJRU11SWlrS0lDQWdJQzh2SUc5eUlIUWdQVDBnVTNSeWFXNW5LQ0pUTGlCbGJpQkRMaUJ3YjNJZ1FTNGlLUW9nSUNBZ0x5OGdiM0lnZENBOVBTQlRkSEpwYm1jb0lsTXVReTRpS1FvZ0lDQWdMeThnYjNJZ2RDQTlQU0JUZEhKcGJtY29Ja0V1UXk0aUtRb2dJQ0FnTHk4Z2IzSWdkQ0E5UFNCVGRISnBibWNvSWxNdVFTNVFMa2t1SWlrS0lDQWdJR0p1ZWlCeVpXZHBjM1J5WVhKZlpXMXdjbVZ6WVY5aWIyOXNYM1J5ZFdWQU1USUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpXZHBjM1J5YjE5bGJYQnlaWE5oY21saGJDOWpiMjUwY21GamRDNXdlVG95T0RVS0lDQWdJQzh2SUc5eUlIUWdQVDBnVTNSeWFXNW5LQ0pUTGtFdVV5NGlLUW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lsTXVRUzVUTGlJS0lDQWdJRDA5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZuYVhOMGNtOWZaVzF3Y21WellYSnBZV3d2WTI5dWRISmhZM1F1Y0hrNk1qZ3pMVEk1TXdvZ0lDQWdMeThnZENBOVBTQlRkSEpwYm1jb0lsTXVRUzRpS1FvZ0lDQWdMeThnYjNJZ2RDQTlQU0JUZEhKcGJtY29JbE11SUdSbElGSXVUQzRpS1FvZ0lDQWdMeThnYjNJZ2RDQTlQU0JUZEhKcGJtY29JbE11UVM1VExpSXBDaUFnSUNBdkx5QnZjaUIwSUQwOUlGTjBjbWx1WnlnaVV5NURMa3d1SWlrS0lDQWdJQzh2SUc5eUlIUWdQVDBnVTNSeWFXNW5LQ0pUTGtNdVZpNGlLUW9nSUNBZ0x5OGdiM0lnZENBOVBTQlRkSEpwYm1jb0lsTXVJR1Z1SUU0dVF5NGlLUW9nSUNBZ0x5OGdiM0lnZENBOVBTQlRkSEpwYm1jb0lsTXVJR1Z1SUVNdUlpa0tJQ0FnSUM4dklHOXlJSFFnUFQwZ1UzUnlhVzVuS0NKVExpQmxiaUJETGlCd2IzSWdRUzRpS1FvZ0lDQWdMeThnYjNJZ2RDQTlQU0JUZEhKcGJtY29JbE11UXk0aUtRb2dJQ0FnTHk4Z2IzSWdkQ0E5UFNCVGRISnBibWNvSWtFdVF5NGlLUW9nSUNBZ0x5OGdiM0lnZENBOVBTQlRkSEpwYm1jb0lsTXVRUzVRTGtrdUlpa0tJQ0FnSUdKdWVpQnlaV2RwYzNSeVlYSmZaVzF3Y21WellWOWliMjlzWDNSeWRXVkFNVElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaV2RwYzNSeWIxOWxiWEJ5WlhOaGNtbGhiQzlqYjI1MGNtRmpkQzV3ZVRveU9EWUtJQ0FnSUM4dklHOXlJSFFnUFQwZ1UzUnlhVzVuS0NKVExrTXVUQzRpS1FvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vWW5sMFpYTWdJbE11UXk1TUxpSUtJQ0FnSUQwOUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WbmFYTjBjbTlmWlcxd2NtVnpZWEpwWVd3dlkyOXVkSEpoWTNRdWNIazZNamd6TFRJNU13b2dJQ0FnTHk4Z2RDQTlQU0JUZEhKcGJtY29JbE11UVM0aUtRb2dJQ0FnTHk4Z2IzSWdkQ0E5UFNCVGRISnBibWNvSWxNdUlHUmxJRkl1VEM0aUtRb2dJQ0FnTHk4Z2IzSWdkQ0E5UFNCVGRISnBibWNvSWxNdVFTNVRMaUlwQ2lBZ0lDQXZMeUJ2Y2lCMElEMDlJRk4wY21sdVp5Z2lVeTVETGt3dUlpa0tJQ0FnSUM4dklHOXlJSFFnUFQwZ1UzUnlhVzVuS0NKVExrTXVWaTRpS1FvZ0lDQWdMeThnYjNJZ2RDQTlQU0JUZEhKcGJtY29JbE11SUdWdUlFNHVReTRpS1FvZ0lDQWdMeThnYjNJZ2RDQTlQU0JUZEhKcGJtY29JbE11SUdWdUlFTXVJaWtLSUNBZ0lDOHZJRzl5SUhRZ1BUMGdVM1J5YVc1bktDSlRMaUJsYmlCRExpQndiM0lnUVM0aUtRb2dJQ0FnTHk4Z2IzSWdkQ0E5UFNCVGRISnBibWNvSWxNdVF5NGlLUW9nSUNBZ0x5OGdiM0lnZENBOVBTQlRkSEpwYm1jb0lrRXVReTRpS1FvZ0lDQWdMeThnYjNJZ2RDQTlQU0JUZEhKcGJtY29JbE11UVM1UUxra3VJaWtLSUNBZ0lHSnVlaUJ5WldkcGMzUnlZWEpmWlcxd2NtVnpZVjlpYjI5c1gzUnlkV1ZBTVRJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldkcGMzUnliMTlsYlhCeVpYTmhjbWxoYkM5amIyNTBjbUZqZEM1d2VUb3lPRGNLSUNBZ0lDOHZJRzl5SUhRZ1BUMGdVM1J5YVc1bktDSlRMa011Vmk0aUtRb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb1lubDBaWE1nSWxNdVF5NVdMaUlLSUNBZ0lEMDlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVm5hWE4wY205ZlpXMXdjbVZ6WVhKcFlXd3ZZMjl1ZEhKaFkzUXVjSGs2TWpnekxUSTVNd29nSUNBZ0x5OGdkQ0E5UFNCVGRISnBibWNvSWxNdVFTNGlLUW9nSUNBZ0x5OGdiM0lnZENBOVBTQlRkSEpwYm1jb0lsTXVJR1JsSUZJdVRDNGlLUW9nSUNBZ0x5OGdiM0lnZENBOVBTQlRkSEpwYm1jb0lsTXVRUzVUTGlJcENpQWdJQ0F2THlCdmNpQjBJRDA5SUZOMGNtbHVaeWdpVXk1RExrd3VJaWtLSUNBZ0lDOHZJRzl5SUhRZ1BUMGdVM1J5YVc1bktDSlRMa011Vmk0aUtRb2dJQ0FnTHk4Z2IzSWdkQ0E5UFNCVGRISnBibWNvSWxNdUlHVnVJRTR1UXk0aUtRb2dJQ0FnTHk4Z2IzSWdkQ0E5UFNCVGRISnBibWNvSWxNdUlHVnVJRU11SWlrS0lDQWdJQzh2SUc5eUlIUWdQVDBnVTNSeWFXNW5LQ0pUTGlCbGJpQkRMaUJ3YjNJZ1FTNGlLUW9nSUNBZ0x5OGdiM0lnZENBOVBTQlRkSEpwYm1jb0lsTXVReTRpS1FvZ0lDQWdMeThnYjNJZ2RDQTlQU0JUZEhKcGJtY29Ja0V1UXk0aUtRb2dJQ0FnTHk4Z2IzSWdkQ0E5UFNCVGRISnBibWNvSWxNdVFTNVFMa2t1SWlrS0lDQWdJR0p1ZWlCeVpXZHBjM1J5WVhKZlpXMXdjbVZ6WVY5aWIyOXNYM1J5ZFdWQU1USUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpXZHBjM1J5YjE5bGJYQnlaWE5oY21saGJDOWpiMjUwY21GamRDNXdlVG95T0RnS0lDQWdJQzh2SUc5eUlIUWdQVDBnVTNSeWFXNW5LQ0pUTGlCbGJpQk9Ma011SWlrS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pUTGlCbGJpQk9Ma011SWdvZ0lDQWdQVDBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaV2RwYzNSeWIxOWxiWEJ5WlhOaGNtbGhiQzlqYjI1MGNtRmpkQzV3ZVRveU9ETXRNamt6Q2lBZ0lDQXZMeUIwSUQwOUlGTjBjbWx1WnlnaVV5NUJMaUlwQ2lBZ0lDQXZMeUJ2Y2lCMElEMDlJRk4wY21sdVp5Z2lVeTRnWkdVZ1VpNU1MaUlwQ2lBZ0lDQXZMeUJ2Y2lCMElEMDlJRk4wY21sdVp5Z2lVeTVCTGxNdUlpa0tJQ0FnSUM4dklHOXlJSFFnUFQwZ1UzUnlhVzVuS0NKVExrTXVUQzRpS1FvZ0lDQWdMeThnYjNJZ2RDQTlQU0JUZEhKcGJtY29JbE11UXk1V0xpSXBDaUFnSUNBdkx5QnZjaUIwSUQwOUlGTjBjbWx1WnlnaVV5NGdaVzRnVGk1RExpSXBDaUFnSUNBdkx5QnZjaUIwSUQwOUlGTjBjbWx1WnlnaVV5NGdaVzRnUXk0aUtRb2dJQ0FnTHk4Z2IzSWdkQ0E5UFNCVGRISnBibWNvSWxNdUlHVnVJRU11SUhCdmNpQkJMaUlwQ2lBZ0lDQXZMeUJ2Y2lCMElEMDlJRk4wY21sdVp5Z2lVeTVETGlJcENpQWdJQ0F2THlCdmNpQjBJRDA5SUZOMGNtbHVaeWdpUVM1RExpSXBDaUFnSUNBdkx5QnZjaUIwSUQwOUlGTjBjbWx1WnlnaVV5NUJMbEF1U1M0aUtRb2dJQ0FnWW01NklISmxaMmx6ZEhKaGNsOWxiWEJ5WlhOaFgySnZiMnhmZEhKMVpVQXhNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxaMmx6ZEhKdlgyVnRjSEpsYzJGeWFXRnNMMk52Ym5SeVlXTjBMbkI1T2pJNE9Rb2dJQ0FnTHk4Z2IzSWdkQ0E5UFNCVGRISnBibWNvSWxNdUlHVnVJRU11SWlrS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pUTGlCbGJpQkRMaUlLSUNBZ0lEMDlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVm5hWE4wY205ZlpXMXdjbVZ6WVhKcFlXd3ZZMjl1ZEhKaFkzUXVjSGs2TWpnekxUSTVNd29nSUNBZ0x5OGdkQ0E5UFNCVGRISnBibWNvSWxNdVFTNGlLUW9nSUNBZ0x5OGdiM0lnZENBOVBTQlRkSEpwYm1jb0lsTXVJR1JsSUZJdVRDNGlLUW9nSUNBZ0x5OGdiM0lnZENBOVBTQlRkSEpwYm1jb0lsTXVRUzVUTGlJcENpQWdJQ0F2THlCdmNpQjBJRDA5SUZOMGNtbHVaeWdpVXk1RExrd3VJaWtLSUNBZ0lDOHZJRzl5SUhRZ1BUMGdVM1J5YVc1bktDSlRMa011Vmk0aUtRb2dJQ0FnTHk4Z2IzSWdkQ0E5UFNCVGRISnBibWNvSWxNdUlHVnVJRTR1UXk0aUtRb2dJQ0FnTHk4Z2IzSWdkQ0E5UFNCVGRISnBibWNvSWxNdUlHVnVJRU11SWlrS0lDQWdJQzh2SUc5eUlIUWdQVDBnVTNSeWFXNW5LQ0pUTGlCbGJpQkRMaUJ3YjNJZ1FTNGlLUW9nSUNBZ0x5OGdiM0lnZENBOVBTQlRkSEpwYm1jb0lsTXVReTRpS1FvZ0lDQWdMeThnYjNJZ2RDQTlQU0JUZEhKcGJtY29Ja0V1UXk0aUtRb2dJQ0FnTHk4Z2IzSWdkQ0E5UFNCVGRISnBibWNvSWxNdVFTNVFMa2t1SWlrS0lDQWdJR0p1ZWlCeVpXZHBjM1J5WVhKZlpXMXdjbVZ6WVY5aWIyOXNYM1J5ZFdWQU1USUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpXZHBjM1J5YjE5bGJYQnlaWE5oY21saGJDOWpiMjUwY21GamRDNXdlVG95T1RBS0lDQWdJQzh2SUc5eUlIUWdQVDBnVTNSeWFXNW5LQ0pUTGlCbGJpQkRMaUJ3YjNJZ1FTNGlLUW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lsTXVJR1Z1SUVNdUlIQnZjaUJCTGlJS0lDQWdJRDA5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZuYVhOMGNtOWZaVzF3Y21WellYSnBZV3d2WTI5dWRISmhZM1F1Y0hrNk1qZ3pMVEk1TXdvZ0lDQWdMeThnZENBOVBTQlRkSEpwYm1jb0lsTXVRUzRpS1FvZ0lDQWdMeThnYjNJZ2RDQTlQU0JUZEhKcGJtY29JbE11SUdSbElGSXVUQzRpS1FvZ0lDQWdMeThnYjNJZ2RDQTlQU0JUZEhKcGJtY29JbE11UVM1VExpSXBDaUFnSUNBdkx5QnZjaUIwSUQwOUlGTjBjbWx1WnlnaVV5NURMa3d1SWlrS0lDQWdJQzh2SUc5eUlIUWdQVDBnVTNSeWFXNW5LQ0pUTGtNdVZpNGlLUW9nSUNBZ0x5OGdiM0lnZENBOVBTQlRkSEpwYm1jb0lsTXVJR1Z1SUU0dVF5NGlLUW9nSUNBZ0x5OGdiM0lnZENBOVBTQlRkSEpwYm1jb0lsTXVJR1Z1SUVNdUlpa0tJQ0FnSUM4dklHOXlJSFFnUFQwZ1UzUnlhVzVuS0NKVExpQmxiaUJETGlCd2IzSWdRUzRpS1FvZ0lDQWdMeThnYjNJZ2RDQTlQU0JUZEhKcGJtY29JbE11UXk0aUtRb2dJQ0FnTHk4Z2IzSWdkQ0E5UFNCVGRISnBibWNvSWtFdVF5NGlLUW9nSUNBZ0x5OGdiM0lnZENBOVBTQlRkSEpwYm1jb0lsTXVRUzVRTGtrdUlpa0tJQ0FnSUdKdWVpQnlaV2RwYzNSeVlYSmZaVzF3Y21WellWOWliMjlzWDNSeWRXVkFNVElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaV2RwYzNSeWIxOWxiWEJ5WlhOaGNtbGhiQzlqYjI1MGNtRmpkQzV3ZVRveU9URUtJQ0FnSUM4dklHOXlJSFFnUFQwZ1UzUnlhVzVuS0NKVExrTXVJaWtLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR0o1ZEdWeklDSlRMa011SWdvZ0lDQWdQVDBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaV2RwYzNSeWIxOWxiWEJ5WlhOaGNtbGhiQzlqYjI1MGNtRmpkQzV3ZVRveU9ETXRNamt6Q2lBZ0lDQXZMeUIwSUQwOUlGTjBjbWx1WnlnaVV5NUJMaUlwQ2lBZ0lDQXZMeUJ2Y2lCMElEMDlJRk4wY21sdVp5Z2lVeTRnWkdVZ1VpNU1MaUlwQ2lBZ0lDQXZMeUJ2Y2lCMElEMDlJRk4wY21sdVp5Z2lVeTVCTGxNdUlpa0tJQ0FnSUM4dklHOXlJSFFnUFQwZ1UzUnlhVzVuS0NKVExrTXVUQzRpS1FvZ0lDQWdMeThnYjNJZ2RDQTlQU0JUZEhKcGJtY29JbE11UXk1V0xpSXBDaUFnSUNBdkx5QnZjaUIwSUQwOUlGTjBjbWx1WnlnaVV5NGdaVzRnVGk1RExpSXBDaUFnSUNBdkx5QnZjaUIwSUQwOUlGTjBjbWx1WnlnaVV5NGdaVzRnUXk0aUtRb2dJQ0FnTHk4Z2IzSWdkQ0E5UFNCVGRISnBibWNvSWxNdUlHVnVJRU11SUhCdmNpQkJMaUlwQ2lBZ0lDQXZMeUJ2Y2lCMElEMDlJRk4wY21sdVp5Z2lVeTVETGlJcENpQWdJQ0F2THlCdmNpQjBJRDA5SUZOMGNtbHVaeWdpUVM1RExpSXBDaUFnSUNBdkx5QnZjaUIwSUQwOUlGTjBjbWx1WnlnaVV5NUJMbEF1U1M0aUtRb2dJQ0FnWW01NklISmxaMmx6ZEhKaGNsOWxiWEJ5WlhOaFgySnZiMnhmZEhKMVpVQXhNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxaMmx6ZEhKdlgyVnRjSEpsYzJGeWFXRnNMMk52Ym5SeVlXTjBMbkI1T2pJNU1nb2dJQ0FnTHk4Z2IzSWdkQ0E5UFNCVGRISnBibWNvSWtFdVF5NGlLUW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lrRXVReTRpQ2lBZ0lDQTlQUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxaMmx6ZEhKdlgyVnRjSEpsYzJGeWFXRnNMMk52Ym5SeVlXTjBMbkI1T2pJNE15MHlPVE1LSUNBZ0lDOHZJSFFnUFQwZ1UzUnlhVzVuS0NKVExrRXVJaWtLSUNBZ0lDOHZJRzl5SUhRZ1BUMGdVM1J5YVc1bktDSlRMaUJrWlNCU0xrd3VJaWtLSUNBZ0lDOHZJRzl5SUhRZ1BUMGdVM1J5YVc1bktDSlRMa0V1VXk0aUtRb2dJQ0FnTHk4Z2IzSWdkQ0E5UFNCVGRISnBibWNvSWxNdVF5NU1MaUlwQ2lBZ0lDQXZMeUJ2Y2lCMElEMDlJRk4wY21sdVp5Z2lVeTVETGxZdUlpa0tJQ0FnSUM4dklHOXlJSFFnUFQwZ1UzUnlhVzVuS0NKVExpQmxiaUJPTGtNdUlpa0tJQ0FnSUM4dklHOXlJSFFnUFQwZ1UzUnlhVzVuS0NKVExpQmxiaUJETGlJcENpQWdJQ0F2THlCdmNpQjBJRDA5SUZOMGNtbHVaeWdpVXk0Z1pXNGdReTRnY0c5eUlFRXVJaWtLSUNBZ0lDOHZJRzl5SUhRZ1BUMGdVM1J5YVc1bktDSlRMa011SWlrS0lDQWdJQzh2SUc5eUlIUWdQVDBnVTNSeWFXNW5LQ0pCTGtNdUlpa0tJQ0FnSUM4dklHOXlJSFFnUFQwZ1UzUnlhVzVuS0NKVExrRXVVQzVKTGlJcENpQWdJQ0JpYm5vZ2NtVm5hWE4wY21GeVgyVnRjSEpsYzJGZlltOXZiRjkwY25WbFFERXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVm5hWE4wY205ZlpXMXdjbVZ6WVhKcFlXd3ZZMjl1ZEhKaFkzUXVjSGs2TWprekNpQWdJQ0F2THlCdmNpQjBJRDA5SUZOMGNtbHVaeWdpVXk1QkxsQXVTUzRpS1FvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vWW5sMFpYTWdJbE11UVM1UUxra3VJZ29nSUNBZ1BUMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpXZHBjM1J5YjE5bGJYQnlaWE5oY21saGJDOWpiMjUwY21GamRDNXdlVG95T0RNdE1qa3pDaUFnSUNBdkx5QjBJRDA5SUZOMGNtbHVaeWdpVXk1QkxpSXBDaUFnSUNBdkx5QnZjaUIwSUQwOUlGTjBjbWx1WnlnaVV5NGdaR1VnVWk1TUxpSXBDaUFnSUNBdkx5QnZjaUIwSUQwOUlGTjBjbWx1WnlnaVV5NUJMbE11SWlrS0lDQWdJQzh2SUc5eUlIUWdQVDBnVTNSeWFXNW5LQ0pUTGtNdVRDNGlLUW9nSUNBZ0x5OGdiM0lnZENBOVBTQlRkSEpwYm1jb0lsTXVReTVXTGlJcENpQWdJQ0F2THlCdmNpQjBJRDA5SUZOMGNtbHVaeWdpVXk0Z1pXNGdUaTVETGlJcENpQWdJQ0F2THlCdmNpQjBJRDA5SUZOMGNtbHVaeWdpVXk0Z1pXNGdReTRpS1FvZ0lDQWdMeThnYjNJZ2RDQTlQU0JUZEhKcGJtY29JbE11SUdWdUlFTXVJSEJ2Y2lCQkxpSXBDaUFnSUNBdkx5QnZjaUIwSUQwOUlGTjBjbWx1WnlnaVV5NURMaUlwQ2lBZ0lDQXZMeUJ2Y2lCMElEMDlJRk4wY21sdVp5Z2lRUzVETGlJcENpQWdJQ0F2THlCdmNpQjBJRDA5SUZOMGNtbHVaeWdpVXk1QkxsQXVTUzRpS1FvZ0lDQWdZbm9nY21WbmFYTjBjbUZ5WDJWdGNISmxjMkZmWW05dmJGOW1ZV3h6WlVBeE13b0tjbVZuYVhOMGNtRnlYMlZ0Y0hKbGMyRmZZbTl2YkY5MGNuVmxRREV5T2dvZ0lDQWdhVzUwWTE4eUlDOHZJREVLQ25KbFoybHpkSEpoY2w5bGJYQnlaWE5oWDJKdmIyeGZiV1Z5WjJWQU1UUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVm5hWE4wY205ZlpXMXdjbVZ6WVhKcFlXd3ZZMjl1ZEhKaFkzUXVjSGs2TVRFMENpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNWZkR2x3YjE5emIyTnBaV1JoWkY5MllXeHBaRzhvZEdsd2IxOXpiMk5wWldSaFpDa3NJQ0pVYVhCdklHUmxJSE52WTJsbFpHRmtJRzV2SUhiRG9XeHBaRzhpQ2lBZ0lDQmhjM05sY25RZ0x5OGdWR2x3YnlCa1pTQnpiMk5wWldSaFpDQnVieUIydzZGc2FXUnZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVm5hWE4wY205ZlpXMXdjbVZ6WVhKcFlXd3ZZMjl1ZEhKaFkzUXVjSGs2TVRFMkxURXlOZ29nSUNBZ0x5OGdjMlZzWmk1bGJYQnlaWE5oYzF0bGVIQmxaR2xsYm5SbFhTQTlJRVJoZEc5elJXMXdjbVZ6WVNnS0lDQWdJQzh2SUNBZ0lDQnlZWHB2Ymw5emIyTnBZV3c5Y21GNmIyNWZjMjlqYVdGc0xBb2dJQ0FnTHk4Z0lDQWdJSEptWXoxaGNtTTBMbE4wY21sdVp5Z2lJaWtzSUNBZ0lDQWdJQ0FnSUNNZ1ZtRmp3NjF2SUdoaGMzUmhJSFJ5WVcxcGRHRnlJRkpHUXlCaGJuUmxJR1ZzSUZOQlZBb2dJQ0FnTHk4Z0lDQWdJSFJwY0c5ZmMyOWphV1ZrWVdROWRHbHdiMTl6YjJOcFpXUmhaQ3dLSUNBZ0lDOHZJQ0FnSUNCbGMzUmhkSFZ6UFdGeVl6UXVVM1J5YVc1bktDSmhZM1JwZG1FaUtTd0tJQ0FnSUM4dklDQWdJQ0J5WlhCeVpYTmxiblJoYm5SbFgyeGxaMkZzUFhKbGNISmxjMlZ1ZEdGdWRHVmZiR1ZuWVd3c0NpQWdJQ0F2THlBZ0lDQWdaRzl0YVdOcGJHbHZYMlpwYzJOaGJEMWtiMjFwWTJsc2FXOWZabWx6WTJGc0xBb2dJQ0FnTHk4Z0lDQWdJSEpsY0dGeWRHOWZZV05qYVc5dVpYTTljbVZ3WVhKMGIxOWhZMk5wYjI1bGN5d0tJQ0FnSUM4dklDQWdJQ0J1ZFcxbGNtOWZibTkwWVhKcFlUMXVkVzFsY205ZmJtOTBZWEpwWVN3S0lDQWdJQzh2SUNBZ0lDQndaWEp0YVhOdlgzVnpiMTl1YjIxaWNtVTljR1Z5YldsemIxOTFjMjlmYm05dFluSmxMQW9nSUNBZ0x5OGdLUW9nSUNBZ2NIVnphR2x1ZENBeU5Bb2dJQ0FnWkdsbklERXpDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lDc0tJQ0FnSUdSMWNBb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01UZ0tJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUNzS0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNVE1LSUNBZ0lDc0tJQ0FnSUdSMWNBb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQndkWE5vYVc1MElEZ0tJQ0FnSUNzS0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNVEVLSUNBZ0lDc0tJQ0FnSUdSMWNBb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnT1FvZ0lDQWdLd29nSUNBZ1pIVndDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBM0NpQWdJQ0FyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTmdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhOZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldkcGMzUnliMTlsYlhCeVpYTmhjbWxoYkM5amIyNTBjbUZqZEM1d2VUb3hNVGdLSUNBZ0lDOHZJSEptWXoxaGNtTTBMbE4wY21sdVp5Z2lJaWtzSUNBZ0lDQWdJQ0FnSUNNZ1ZtRmp3NjF2SUdoaGMzUmhJSFJ5WVcxcGRHRnlJRkpHUXlCaGJuUmxJR1ZzSUZOQlZBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxaMmx6ZEhKdlgyVnRjSEpsYzJGeWFXRnNMMk52Ym5SeVlXTjBMbkI1T2pFeE5pMHhNallLSUNBZ0lDOHZJSE5sYkdZdVpXMXdjbVZ6WVhOYlpYaHdaV1JwWlc1MFpWMGdQU0JFWVhSdmMwVnRjSEpsYzJFb0NpQWdJQ0F2THlBZ0lDQWdjbUY2YjI1ZmMyOWphV0ZzUFhKaGVtOXVYM052WTJsaGJDd0tJQ0FnSUM4dklDQWdJQ0J5Wm1NOVlYSmpOQzVUZEhKcGJtY29JaUlwTENBZ0lDQWdJQ0FnSUNBaklGWmhZOE90YnlCb1lYTjBZU0IwY21GdGFYUmhjaUJTUmtNZ1lXNTBaU0JsYkNCVFFWUUtJQ0FnSUM4dklDQWdJQ0IwYVhCdlgzTnZZMmxsWkdGa1BYUnBjRzlmYzI5amFXVmtZV1FzQ2lBZ0lDQXZMeUFnSUNBZ1pYTjBZWFIxY3oxaGNtTTBMbE4wY21sdVp5Z2lZV04wYVhaaElpa3NDaUFnSUNBdkx5QWdJQ0FnY21Wd2NtVnpaVzUwWVc1MFpWOXNaV2RoYkQxeVpYQnlaWE5sYm5SaGJuUmxYMnhsWjJGc0xBb2dJQ0FnTHk4Z0lDQWdJR1J2YldsamFXeHBiMTltYVhOallXdzlaRzl0YVdOcGJHbHZYMlpwYzJOaGJDd0tJQ0FnSUM4dklDQWdJQ0J5WlhCaGNuUnZYMkZqWTJsdmJtVnpQWEpsY0dGeWRHOWZZV05qYVc5dVpYTXNDaUFnSUNBdkx5QWdJQ0FnYm5WdFpYSnZYMjV2ZEdGeWFXRTliblZ0WlhKdlgyNXZkR0Z5YVdFc0NpQWdJQ0F2THlBZ0lDQWdjR1Z5YldsemIxOTFjMjlmYm05dFluSmxQWEJsY20xcGMyOWZkWE52WDI1dmJXSnlaU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFMUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxaMmx6ZEhKdlgyVnRjSEpsYzJGeWFXRnNMMk52Ym5SeVlXTjBMbkI1T2pFeU1Bb2dJQ0FnTHk4Z1pYTjBZWFIxY3oxaGNtTTBMbE4wY21sdVp5Z2lZV04wYVhaaElpa3NDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREEyTmpFMk16YzBOamszTmpZeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WbmFYTjBjbTlmWlcxd2NtVnpZWEpwWVd3dlkyOXVkSEpoWTNRdWNIazZNVEUyTFRFeU5nb2dJQ0FnTHk4Z2MyVnNaaTVsYlhCeVpYTmhjMXRsZUhCbFpHbGxiblJsWFNBOUlFUmhkRzl6Ulcxd2NtVnpZU2dLSUNBZ0lDOHZJQ0FnSUNCeVlYcHZibDl6YjJOcFlXdzljbUY2YjI1ZmMyOWphV0ZzTEFvZ0lDQWdMeThnSUNBZ0lISm1ZejFoY21NMExsTjBjbWx1WnlnaUlpa3NJQ0FnSUNBZ0lDQWdJQ01nVm1Ganc2MXZJR2hoYzNSaElIUnlZVzFwZEdGeUlGSkdReUJoYm5SbElHVnNJRk5CVkFvZ0lDQWdMeThnSUNBZ0lIUnBjRzlmYzI5amFXVmtZV1E5ZEdsd2IxOXpiMk5wWldSaFpDd0tJQ0FnSUM4dklDQWdJQ0JsYzNSaGRIVnpQV0Z5WXpRdVUzUnlhVzVuS0NKaFkzUnBkbUVpS1N3S0lDQWdJQzh2SUNBZ0lDQnlaWEJ5WlhObGJuUmhiblJsWDJ4bFoyRnNQWEpsY0hKbGMyVnVkR0Z1ZEdWZmJHVm5ZV3dzQ2lBZ0lDQXZMeUFnSUNBZ1pHOXRhV05wYkdsdlgyWnBjMk5oYkQxa2IyMXBZMmxzYVc5ZlptbHpZMkZzTEFvZ0lDQWdMeThnSUNBZ0lISmxjR0Z5ZEc5ZllXTmphVzl1WlhNOWNtVndZWEowYjE5aFkyTnBiMjVsY3l3S0lDQWdJQzh2SUNBZ0lDQnVkVzFsY205ZmJtOTBZWEpwWVQxdWRXMWxjbTlmYm05MFlYSnBZU3dLSUNBZ0lDOHZJQ0FnSUNCd1pYSnRhWE52WDNWemIxOXViMjFpY21VOWNHVnliV2x6YjE5MWMyOWZibTl0WW5KbExBb2dJQ0FnTHk4Z0tRb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNVFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhNQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTndvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ05nb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaV2RwYzNSeWIxOWxiWEJ5WlhOaGNtbGhiQzlqYjI1MGNtRmpkQzV3ZVRveE1qY0tJQ0FnSUM4dklITmxiR1l1ZEc5MFlXeGZaVzF3Y21WellYTXVkbUZzZFdVZ1BTQnpaV3htTG5SdmRHRnNYMlZ0Y0hKbGMyRnpMblpoYkhWbElDc2dWVWx1ZERZMEtERXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWRHOTBZV3hmWlcxd2NtVnpZWE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOTBZV3hmWlcxd2NtVnpZWE1nWlhocGMzUnpDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZbmwwWldOZk15QXZMeUFpZEc5MFlXeGZaVzF3Y21WellYTWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxaMmx6ZEhKdlgyVnRjSEpsYzJGeWFXRnNMMk52Ym5SeVlXTjBMbkI1T2pFek5Bb2dJQ0FnTHk4Z2NtVm5hWE4wY21Ga2IzSTlZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcExBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psWjJsemRISnZYMlZ0Y0hKbGMyRnlhV0ZzTDJOdmJuUnlZV04wTG5CNU9qRXlPUzB4TXpVS0lDQWdJQzh2SUVWdGNISmxjMkZTWldkcGMzUnlZV1JoS0FvZ0lDQWdMeThnSUNBZ0lHVjRjR1ZrYVdWdWRHVTlaWGh3WldScFpXNTBaU3dLSUNBZ0lDOHZJQ0FnSUNCeVlYcHZibDl6YjJOcFlXdzljbUY2YjI1ZmMyOWphV0ZzTEFvZ0lDQWdMeThnSUNBZ0lIUnBjRzlmYzI5amFXVmtZV1E5ZEdsd2IxOXpiMk5wWldSaFpDd0tJQ0FnSUM4dklDQWdJQ0J1ZFcxbGNtOWZibTkwWVhKcFlUMXVkVzFsY205ZmJtOTBZWEpwWVN3S0lDQWdJQzh2SUNBZ0lDQnlaV2RwYzNSeVlXUnZjajFoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa3NDaUFnSUNBdkx5QXBDaUFnSUNCd2RYTm9hVzUwSURRMkNpQWdJQ0JrYVdjZ01qQUtJQ0FnSUNzS0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TW1VS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNVGdLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psWjJsemRISnZYMlZ0Y0hKbGMyRnlhV0ZzTDJOdmJuUnlZV04wTG5CNU9qRXlPQzB4TXpZS0lDQWdJQzh2SUdGeVl6UXVaVzFwZENnS0lDQWdJQzh2SUNBZ0lDQkZiWEJ5WlhOaFVtVm5hWE4wY21Ga1lTZ0tJQ0FnSUM4dklDQWdJQ0FnSUNBZ1pYaHdaV1JwWlc1MFpUMWxlSEJsWkdsbGJuUmxMQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQnlZWHB2Ymw5emIyTnBZV3c5Y21GNmIyNWZjMjlqYVdGc0xBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCMGFYQnZYM052WTJsbFpHRmtQWFJwY0c5ZmMyOWphV1ZrWVdRc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUc1MWJXVnliMTl1YjNSaGNtbGhQVzUxYldWeWIxOXViM1JoY21saExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCeVpXZHBjM1J5WVdSdmNqMWhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrc0NpQWdJQ0F2THlBZ0lDQWdLUW9nSUNBZ0x5OGdLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREkzTWpoaFptWWdMeThnYldWMGFHOWtJQ0pGYlhCeVpYTmhVbVZuYVhOMGNtRmtZU2h6ZEhKcGJtY3NjM1J5YVc1bkxITjBjbWx1Wnl4MWFXNTBOalFzWVdSa2NtVnpjeWtpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psWjJsemRISnZYMlZ0Y0hKbGMyRnlhV0ZzTDJOdmJuUnlZV04wTG5CNU9qazJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tjbVZuYVhOMGNtRnlYMlZ0Y0hKbGMyRmZZbTl2YkY5bVlXeHpaVUF4TXpvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlJSEpsWjJsemRISmhjbDlsYlhCeVpYTmhYMkp2YjJ4ZmJXVnlaMlZBTVRRS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjbVZuYVhOMGNtOWZaVzF3Y21WellYSnBZV3d1WTI5dWRISmhZM1F1VW1WbmFYTjBjbTlGYlhCeVpYTmhjbWxoYkM1eVpXZHBjM1J5WVhKZmNtWmpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY21WbmFYTjBjbUZ5WDNKbVl6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpXZHBjM1J5YjE5bGJYQnlaWE5oY21saGJDOWpiMjUwY21GamRDNXdlVG94TkRBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldkcGMzUnliMTlsYlhCeVpYTmhjbWxoYkM5amIyNTBjbUZqZEM1d2VUb3hORFlLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTGw5bGMxOXlaV2RwYzNSeVlXUnZjaWdwTENBaVRtOGdZWFYwYjNKcGVtRmtieUlLSUNBZ0lHTmhiR3h6ZFdJZ1gyVnpYM0psWjJsemRISmhaRzl5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUbThnWVhWMGIzSnBlbUZrYndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psWjJsemRISnZYMlZ0Y0hKbGMyRnlhV0ZzTDJOdmJuUnlZV04wTG5CNU9qRTBOd29nSUNBZ0x5OGdZWE56WlhKMElHVjRjR1ZrYVdWdWRHVWdhVzRnYzJWc1ppNWxiWEJ5WlhOaGN5d2dJa1Z0Y0hKbGMyRWdibThnWlc1amIyNTBjbUZrWVNJS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1WdGNISmxjMkZ6SWdvZ0lDQWdaR2xuSURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QkZiWEJ5WlhOaElHNXZJR1Z1WTI5dWRISmhaR0VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaV2RwYzNSeWIxOWxiWEJ5WlhOaGNtbGhiQzlqYjI1MGNtRmpkQzV3ZVRveE5EZ0tJQ0FnSUM4dklHVnRjSEpsYzJFZ1BTQnpaV3htTG1WdGNISmxjMkZ6VzJWNGNHVmthV1Z1ZEdWZExtTnZjSGtvS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldkcGMzUnliMTlsYlhCeVpYTmhjbWxoYkM5amIyNTBjbUZqZEM1d2VUb3hORGd0TVRRNUNpQWdJQ0F2THlCbGJYQnlaWE5oSUQwZ2MyVnNaaTVsYlhCeVpYTmhjMXRsZUhCbFpHbGxiblJsWFM1amIzQjVLQ2tLSUNBZ0lDOHZJR0Z6YzJWeWRDQmxiWEJ5WlhOaExuSm1ZeTV1WVhScGRtVWdQVDBnVTNSeWFXNW5LQ0lpS1N3Z0lrVnNJRkpHUXlCNVlTQm1kV1VnY21WbmFYTjBjbUZrYnlCNUlHNXZJSEIxWldSbElHMXZaR2xtYVdOaGNuTmxJZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdZblJ2YVFvZ0lDQWdaSFZ3TWdvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCaWRHOXBDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURJS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WbmFYTjBjbTlmWlcxd2NtVnpZWEpwWVd3dlkyOXVkSEpoWTNRdWNIazZNVFE1Q2lBZ0lDQXZMeUJoYzNObGNuUWdaVzF3Y21WellTNXlabU11Ym1GMGFYWmxJRDA5SUZOMGNtbHVaeWdpSWlrc0lDSkZiQ0JTUmtNZ2VXRWdablZsSUhKbFoybHpkSEpoWkc4Z2VTQnVieUJ3ZFdWa1pTQnRiMlJwWm1sallYSnpaU0lLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpSUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnUld3Z1VrWkRJSGxoSUdaMVpTQnlaV2RwYzNSeVlXUnZJSGtnYm04Z2NIVmxaR1VnYlc5a2FXWnBZMkZ5YzJVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldkcGMzUnliMTlsYlhCeVpYTmhjbWxoYkM5amIyNTBjbUZqZEM1d2VUb3hOVEFLSUNBZ0lDOHZJR1Z0Y0hKbGMyRXVjbVpqSUQwZ2NtWmpDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dNZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdScFp5QXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklETUtJQ0FnSUhCMWMyaHBiblFnTkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBMENpQWdJQ0JzWlc0S0lDQWdJR1JwWnlBMUNpQWdJQ0JrYVdjZ01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklERUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdMUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JrYVdjZ05Rb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJQzBLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJSEpsY0d4aFkyVXlJRFFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQndkWE5vYVc1MElEWUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dOUW9nSUNBZ0t3b2dJQ0FnWkdsbklESUtJQ0FnSUMwS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnlaWEJzWVdObE1pQTJDaUFnSUNCa2FXY2dNd29nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWkdsbklEVUtJQ0FnSUNzS0lDQWdJR1JwWnlBeUNpQWdJQ0F0Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2NtVndiR0ZqWlRJZ09Bb2dJQ0FnWkdsbklETUtJQ0FnSUhCMWMyaHBiblFnTVRBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ05Rb2dJQ0FnS3dvZ0lDQWdaR2xuSURJS0lDQWdJQzBLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCeVpYQnNZV05sTWlBeE1Bb2dJQ0FnWkdsbklETUtJQ0FnSUhCMWMyaHBiblFnTVRJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ05Rb2dJQ0FnS3dvZ0lDQWdaR2xuSURJS0lDQWdJQzBLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCeVpYQnNZV05sTWlBeE1nb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNaklLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUNzS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ0xRb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSEpsY0d4aFkyVXlJREl5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZuYVhOMGNtOWZaVzF3Y21WellYSnBZV3d2WTI5dWRISmhZM1F1Y0hrNk1UVXhDaUFnSUNBdkx5QnpaV3htTG1WdGNISmxjMkZ6VzJWNGNHVmthV1Z1ZEdWZElEMGdaVzF3Y21WellTNWpiM0I1S0NrS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaV2RwYzNSeWIxOWxiWEJ5WlhOaGNtbGhiQzlqYjI1MGNtRmpkQzV3ZVRveE5UVUtJQ0FnSUM4dklISmxaMmx6ZEhKaFpHOXlQV0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTd0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldkcGMzUnliMTlsYlhCeVpYTmhjbWxoYkM5amIyNTBjbUZqZEM1d2VUb3hOVEl0TVRVMkNpQWdJQ0F2THlCaGNtTTBMbVZ0YVhRb1VrWkRVbVZuYVhOMGNtRmtieWdLSUNBZ0lDOHZJQ0FnSUNCbGVIQmxaR2xsYm5SbFBXVjRjR1ZrYVdWdWRHVXNDaUFnSUNBdkx5QWdJQ0FnY21aalBYSm1ZeXdLSUNBZ0lDOHZJQ0FnSUNCeVpXZHBjM1J5WVdSdmNqMWhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrc0NpQWdJQ0F2THlBcEtRb2dJQ0FnY0hWemFHbHVkQ0F6TmdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBeU5Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREJrWVdNNU0yUXlJQzh2SUcxbGRHaHZaQ0FpVWtaRFVtVm5hWE4wY21Ga2J5aHpkSEpwYm1jc2MzUnlhVzVuTEdGa1pISmxjM01wSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldkcGMzUnliMTlsYlhCeVpYTmhjbWxoYkM5amIyNTBjbUZqZEM1d2VUb3hOREFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5KbFoybHpkSEp2WDJWdGNISmxjMkZ5YVdGc0xtTnZiblJ5WVdOMExsSmxaMmx6ZEhKdlJXMXdjbVZ6WVhKcFlXd3VZV04wZFdGc2FYcGhjbDl5WVhwdmJsOXpiMk5wWVd4YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGhZM1IxWVd4cGVtRnlYM0poZW05dVgzTnZZMmxoYkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldkcGMzUnliMTlsYlhCeVpYTmhjbWxoYkM5amIyNTBjbUZqZEM1d2VUb3hOakFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaV2RwYzNSeWIxOWxiWEJ5WlhOaGNtbGhiQzlqYjI1MGNtRmpkQzV3ZVRveE5qSUtJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MbDlsYzE5eVpXZHBjM1J5WVdSdmNpZ3BMQ0FpVG04Z1lYVjBiM0pwZW1Ga2J5SUtJQ0FnSUdOaGJHeHpkV0lnWDJWelgzSmxaMmx6ZEhKaFpHOXlDaUFnSUNCaGMzTmxjblFnTHk4Z1RtOGdZWFYwYjNKcGVtRmtid29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxaMmx6ZEhKdlgyVnRjSEpsYzJGeWFXRnNMMk52Ym5SeVlXTjBMbkI1T2pFMk13b2dJQ0FnTHk4Z1lYTnpaWEowSUdWNGNHVmthV1Z1ZEdVZ2FXNGdjMlZzWmk1bGJYQnlaWE5oY3l3Z0lrVnRjSEpsYzJFZ2JtOGdaVzVqYjI1MGNtRmtZU0lLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbVZ0Y0hKbGMyRnpJZ29nSUNBZ1pHbG5JRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCRmJYQnlaWE5oSUc1dklHVnVZMjl1ZEhKaFpHRUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpXZHBjM1J5YjE5bGJYQnlaWE5oY21saGJDOWpiMjUwY21GamRDNXdlVG94TmpRS0lDQWdJQzh2SUdWdGNISmxjMkVnUFNCelpXeG1MbVZ0Y0hKbGMyRnpXMlY0Y0dWa2FXVnVkR1ZkTG1OdmNIa29LUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaV2RwYzNSeWIxOWxiWEJ5WlhOaGNtbGhiQzlqYjI1MGNtRmpkQzV3ZVRveE5qVUtJQ0FnSUM4dklHVnRjSEpsYzJFdWNtRjZiMjVmYzI5amFXRnNJRDBnZG1Gc2IzSUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1JwWnlBeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURJS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaR2xuSURNS0lDQWdJR3hsYmdvZ0lDQWdaR2xuSURRS0lDQWdJR1JwWnlBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQXRDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR1JwWnlBMUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdMUW9nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdjbVZ3YkdGalpUSWdNZ29nSUNBZ1pHbG5JRElLSUNBZ0lIQjFjMmhwYm5RZ05Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdScFp5QTFDaUFnSUNBckNpQWdJQ0JrYVdjZ01nb2dJQ0FnTFFvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lISmxjR3hoWTJVeUlEUUtJQ0FnSUdScFp5QXlDaUFnSUNCd2RYTm9hVzUwSURZS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ05Rb2dJQ0FnS3dvZ0lDQWdaR2xuSURJS0lDQWdJQzBLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCeVpYQnNZV05sTWlBMkNpQWdJQ0JrYVdjZ01nb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaR2xuSURVS0lDQWdJQ3NLSUNBZ0lHUnBaeUF5Q2lBZ0lDQXRDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnY21Wd2JHRmpaVElnT0FvZ0lDQWdaR2xuSURJS0lDQWdJSEIxYzJocGJuUWdNVEFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmthV2NnTlFvZ0lDQWdLd29nSUNBZ1pHbG5JRElLSUNBZ0lDMEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J5WlhCc1lXTmxNaUF4TUFvZ0lDQWdaR2xuSURJS0lDQWdJSEIxYzJocGJuUWdNVElLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmthV2NnTlFvZ0lDQWdLd29nSUNBZ1pHbG5JRElLSUNBZ0lDMEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J5WlhCc1lXTmxNaUF4TWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGJuUmpYek1nTHk4Z01qSUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJQ3NLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnTFFvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lISmxjR3hoWTJVeUlESXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVm5hWE4wY205ZlpXMXdjbVZ6WVhKcFlXd3ZZMjl1ZEhKaFkzUXVjSGs2TVRZMkNpQWdJQ0F2THlCelpXeG1MbVZ0Y0hKbGMyRnpXMlY0Y0dWa2FXVnVkR1ZkSUQwZ1pXMXdjbVZ6WVM1amIzQjVLQ2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpXZHBjM1J5YjE5bGJYQnlaWE5oY21saGJDOWpiMjUwY21GamRDNXdlVG94TnpFS0lDQWdJQzh2SUhKbFoybHpkSEpoWkc5eVBXRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1N3S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaV2RwYzNSeWIxOWxiWEJ5WlhOaGNtbGhiQzlqYjI1MGNtRmpkQzV3ZVRveE5qY3RNVGN5Q2lBZ0lDQXZMeUJoY21NMExtVnRhWFFvUTJGdGNHOUJZM1IxWVd4cGVtRmtieWdLSUNBZ0lDOHZJQ0FnSUNCbGVIQmxaR2xsYm5SbFBXVjRjR1ZrYVdWdWRHVXNDaUFnSUNBdkx5QWdJQ0FnWTJGdGNHODlZWEpqTkM1VGRISnBibWNvSW5KaGVtOXVYM052WTJsaGJDSXBMQW9nSUNBZ0x5OGdJQ0FnSUhaaGJHOXlYMjUxWlhadlBYWmhiRzl5TEFvZ0lDQWdMeThnSUNBZ0lISmxaMmx6ZEhKaFpHOXlQV0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTd0tJQ0FnSUM4dklDa3BDaUFnSUNCd2RYTm9hVzUwSURNNENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lDc0tJQ0FnSUdSMWNBb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01ESTJDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lIQjFjMmhwYm5RZ01UUUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldkcGMzUnliMTlsYlhCeVpYTmhjbWxoYkM5amIyNTBjbUZqZEM1d2VUb3hOamtLSUNBZ0lDOHZJR05oYlhCdlBXRnlZelF1VTNSeWFXNW5LQ0p5WVhwdmJsOXpiMk5wWVd3aUtTd0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNR00zTWpZeE4yRTJaalpsTldZM016Wm1Oak0yT1RZeE5tTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpXZHBjM1J5YjE5bGJYQnlaWE5oY21saGJDOWpiMjUwY21GamRDNXdlVG94TmpjdE1UY3lDaUFnSUNBdkx5QmhjbU0wTG1WdGFYUW9RMkZ0Y0c5QlkzUjFZV3hwZW1Ga2J5Z0tJQ0FnSUM4dklDQWdJQ0JsZUhCbFpHbGxiblJsUFdWNGNHVmthV1Z1ZEdVc0NpQWdJQ0F2THlBZ0lDQWdZMkZ0Y0c4OVlYSmpOQzVUZEhKcGJtY29JbkpoZW05dVgzTnZZMmxoYkNJcExBb2dJQ0FnTHk4Z0lDQWdJSFpoYkc5eVgyNTFaWFp2UFhaaGJHOXlMQW9nSUNBZ0x5OGdJQ0FnSUhKbFoybHpkSEpoWkc5eVBXRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1N3S0lDQWdJQzh2SUNrcENpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTWlBdkx5QnRaWFJvYjJRZ0lrTmhiWEJ2UVdOMGRXRnNhWHBoWkc4b2MzUnlhVzVuTEhOMGNtbHVaeXh6ZEhKcGJtY3NZV1JrY21WemN5a2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxaMmx6ZEhKdlgyVnRjSEpsYzJGeWFXRnNMMk52Ym5SeVlXTjBMbkI1T2pFMk1Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjbVZuYVhOMGNtOWZaVzF3Y21WellYSnBZV3d1WTI5dWRISmhZM1F1VW1WbmFYTjBjbTlGYlhCeVpYTmhjbWxoYkM1aFkzUjFZV3hwZW1GeVgzSmxjSEpsYzJWdWRHRnVkR1ZmYkdWbllXeGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BoWTNSMVlXeHBlbUZ5WDNKbGNISmxjMlZ1ZEdGdWRHVmZiR1ZuWVd3NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WbmFYTjBjbTlmWlcxd2NtVnpZWEpwWVd3dlkyOXVkSEpoWTNRdWNIazZNVGMwQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZuYVhOMGNtOWZaVzF3Y21WellYSnBZV3d2WTI5dWRISmhZM1F1Y0hrNk1UYzJDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTVmWlhOZmNtVm5hWE4wY21Ga2IzSW9LU3dnSWs1dklHRjFkRzl5YVhwaFpHOGlDaUFnSUNCallXeHNjM1ZpSUY5bGMxOXlaV2RwYzNSeVlXUnZjZ29nSUNBZ1lYTnpaWEowSUM4dklFNXZJR0YxZEc5eWFYcGhaRzhLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaV2RwYzNSeWIxOWxiWEJ5WlhOaGNtbGhiQzlqYjI1MGNtRmpkQzV3ZVRveE56Y0tJQ0FnSUM4dklHRnpjMlZ5ZENCbGVIQmxaR2xsYm5SbElHbHVJSE5sYkdZdVpXMXdjbVZ6WVhNc0lDSkZiWEJ5WlhOaElHNXZJR1Z1WTI5dWRISmhaR0VpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0psYlhCeVpYTmhjeUlLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1JXMXdjbVZ6WVNCdWJ5QmxibU52Ym5SeVlXUmhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVm5hWE4wY205ZlpXMXdjbVZ6WVhKcFlXd3ZZMjl1ZEhKaFkzUXVjSGs2TVRjNENpQWdJQ0F2THlCbGJYQnlaWE5oSUQwZ2MyVnNaaTVsYlhCeVpYTmhjMXRsZUhCbFpHbGxiblJsWFM1amIzQjVLQ2tLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZuYVhOMGNtOWZaVzF3Y21WellYSnBZV3d2WTI5dWRISmhZM1F1Y0hrNk1UYzVDaUFnSUNBdkx5QmxiWEJ5WlhOaExuSmxjSEpsYzJWdWRHRnVkR1ZmYkdWbllXd2dQU0IyWVd4dmNnb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJRGdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRElLSUNBZ0lIQjFjMmhwYm5RZ01UQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dNd29nSUNBZ2JHVnVDaUFnSUNCa2FXY2dOQW9nSUNBZ1pHbG5JRElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUMwS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pHbG5JRFVLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNBdENpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCeVpYQnNZV05sTWlBeE1Bb2dJQ0FnWkdsbklESUtJQ0FnSUhCMWMyaHBiblFnTVRJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ05Rb2dJQ0FnS3dvZ0lDQWdaR2xuSURJS0lDQWdJQzBLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCeVpYQnNZV05sTWlBeE1nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNaklLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUNzS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ0xRb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSEpsY0d4aFkyVXlJREl5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZuYVhOMGNtOWZaVzF3Y21WellYSnBZV3d2WTI5dWRISmhZM1F1Y0hrNk1UZ3dDaUFnSUNBdkx5QnpaV3htTG1WdGNISmxjMkZ6VzJWNGNHVmthV1Z1ZEdWZElEMGdaVzF3Y21WellTNWpiM0I1S0NrS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaV2RwYzNSeWIxOWxiWEJ5WlhOaGNtbGhiQzlqYjI1MGNtRmpkQzV3ZVRveE9EVUtJQ0FnSUM4dklISmxaMmx6ZEhKaFpHOXlQV0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTd0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldkcGMzUnliMTlsYlhCeVpYTmhjbWxoYkM5amIyNTBjbUZqZEM1d2VUb3hPREV0TVRnMkNpQWdJQ0F2THlCaGNtTTBMbVZ0YVhRb1EyRnRjRzlCWTNSMVlXeHBlbUZrYnlnS0lDQWdJQzh2SUNBZ0lDQmxlSEJsWkdsbGJuUmxQV1Y0Y0dWa2FXVnVkR1VzQ2lBZ0lDQXZMeUFnSUNBZ1kyRnRjRzg5WVhKak5DNVRkSEpwYm1jb0luSmxjSEpsYzJWdWRHRnVkR1ZmYkdWbllXd2lLU3dLSUNBZ0lDOHZJQ0FnSUNCMllXeHZjbDl1ZFdWMmJ6MTJZV3h2Y2l3S0lDQWdJQzh2SUNBZ0lDQnlaV2RwYzNSeVlXUnZjajFoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa3NDaUFnSUNBdkx5QXBLUW9nSUNBZ2NIVnphR2x1ZENBek9Bb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQXJDaUFnSUNCa2RYQUtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1EQXlOZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQndkWE5vYVc1MElESXhDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WbmFYTjBjbTlmWlcxd2NtVnpZWEpwWVd3dlkyOXVkSEpoWTNRdWNIazZNVGd6Q2lBZ0lDQXZMeUJqWVcxd2J6MWhjbU0wTGxOMGNtbHVaeWdpY21Wd2NtVnpaVzUwWVc1MFpWOXNaV2RoYkNJcExBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXhNemN5TmpVM01EY3lOalUzTXpZMU5tVTNORFl4Tm1VM05EWTFOV1kyWXpZMU5qYzJNVFpqQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZuYVhOMGNtOWZaVzF3Y21WellYSnBZV3d2WTI5dWRISmhZM1F1Y0hrNk1UZ3hMVEU0TmdvZ0lDQWdMeThnWVhKak5DNWxiV2wwS0VOaGJYQnZRV04wZFdGc2FYcGhaRzhvQ2lBZ0lDQXZMeUFnSUNBZ1pYaHdaV1JwWlc1MFpUMWxlSEJsWkdsbGJuUmxMQW9nSUNBZ0x5OGdJQ0FnSUdOaGJYQnZQV0Z5WXpRdVUzUnlhVzVuS0NKeVpYQnlaWE5sYm5SaGJuUmxYMnhsWjJGc0lpa3NDaUFnSUNBdkx5QWdJQ0FnZG1Gc2IzSmZiblZsZG04OWRtRnNiM0lzQ2lBZ0lDQXZMeUFnSUNBZ2NtVm5hWE4wY21Ga2IzSTlZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcExBb2dJQ0FnTHk4Z0tTa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJRzFsZEdodlpDQWlRMkZ0Y0c5QlkzUjFZV3hwZW1Ga2J5aHpkSEpwYm1jc2MzUnlhVzVuTEhOMGNtbHVaeXhoWkdSeVpYTnpLU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZuYVhOMGNtOWZaVzF3Y21WellYSnBZV3d2WTI5dWRISmhZM1F1Y0hrNk1UYzBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV5WldkcGMzUnliMTlsYlhCeVpYTmhjbWxoYkM1amIyNTBjbUZqZEM1U1pXZHBjM1J5YjBWdGNISmxjMkZ5YVdGc0xtRmpkSFZoYkdsNllYSmZaRzl0YVdOcGJHbHZXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWVdOMGRXRnNhWHBoY2w5a2IyMXBZMmxzYVc4NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WbmFYTjBjbTlmWlcxd2NtVnpZWEpwWVd3dlkyOXVkSEpoWTNRdWNIazZNVGc0Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZuYVhOMGNtOWZaVzF3Y21WellYSnBZV3d2WTI5dWRISmhZM1F1Y0hrNk1Ua3dDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTVmWlhOZmNtVm5hWE4wY21Ga2IzSW9LU3dnSWs1dklHRjFkRzl5YVhwaFpHOGlDaUFnSUNCallXeHNjM1ZpSUY5bGMxOXlaV2RwYzNSeVlXUnZjZ29nSUNBZ1lYTnpaWEowSUM4dklFNXZJR0YxZEc5eWFYcGhaRzhLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaV2RwYzNSeWIxOWxiWEJ5WlhOaGNtbGhiQzlqYjI1MGNtRmpkQzV3ZVRveE9URUtJQ0FnSUM4dklHRnpjMlZ5ZENCbGVIQmxaR2xsYm5SbElHbHVJSE5sYkdZdVpXMXdjbVZ6WVhNc0lDSkZiWEJ5WlhOaElHNXZJR1Z1WTI5dWRISmhaR0VpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0psYlhCeVpYTmhjeUlLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1JXMXdjbVZ6WVNCdWJ5QmxibU52Ym5SeVlXUmhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVm5hWE4wY205ZlpXMXdjbVZ6WVhKcFlXd3ZZMjl1ZEhKaFkzUXVjSGs2TVRreUNpQWdJQ0F2THlCbGJYQnlaWE5oSUQwZ2MyVnNaaTVsYlhCeVpYTmhjMXRsZUhCbFpHbGxiblJsWFM1amIzQjVLQ2tLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZuYVhOMGNtOWZaVzF3Y21WellYSnBZV3d2WTI5dWRISmhZM1F1Y0hrNk1Ua3pDaUFnSUNBdkx5QmxiWEJ5WlhOaExtUnZiV2xqYVd4cGIxOW1hWE5qWVd3Z1BTQjJZV3h2Y2dvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElERXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCa2FXY2dNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXlDaUFnSUNCd2RYTm9hVzUwSURFeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWkdsbklETUtJQ0FnSUd4bGJnb2dJQ0FnWkdsbklEUUtJQ0FnSUdScFp5QXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNUW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0F0Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdScFp5QTFDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnTFFvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnY21Wd2JHRmpaVElnTVRJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh6SUM4dklESXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0FyQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUMwS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnlaWEJzWVdObE1pQXlNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxaMmx6ZEhKdlgyVnRjSEpsYzJGeWFXRnNMMk52Ym5SeVlXTjBMbkI1T2pFNU5Bb2dJQ0FnTHk4Z2MyVnNaaTVsYlhCeVpYTmhjMXRsZUhCbFpHbGxiblJsWFNBOUlHVnRjSEpsYzJFdVkyOXdlU2dwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVm5hWE4wY205ZlpXMXdjbVZ6WVhKcFlXd3ZZMjl1ZEhKaFkzUXVjSGs2TVRrNUNpQWdJQ0F2THlCeVpXZHBjM1J5WVdSdmNqMWhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrc0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZuYVhOMGNtOWZaVzF3Y21WellYSnBZV3d2WTI5dWRISmhZM1F1Y0hrNk1UazFMVEl3TUFvZ0lDQWdMeThnWVhKak5DNWxiV2wwS0VOaGJYQnZRV04wZFdGc2FYcGhaRzhvQ2lBZ0lDQXZMeUFnSUNBZ1pYaHdaV1JwWlc1MFpUMWxlSEJsWkdsbGJuUmxMQW9nSUNBZ0x5OGdJQ0FnSUdOaGJYQnZQV0Z5WXpRdVUzUnlhVzVuS0NKa2IyMXBZMmxzYVc5ZlptbHpZMkZzSWlrc0NpQWdJQ0F2THlBZ0lDQWdkbUZzYjNKZmJuVmxkbTg5ZG1Gc2IzSXNDaUFnSUNBdkx5QWdJQ0FnY21WbmFYTjBjbUZrYjNJOVlYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwTEFvZ0lDQWdMeThnS1NrS0lDQWdJSEIxYzJocGJuUWdNemdLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnS3dvZ0lDQWdaSFZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3TWpZS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnY0hWemFHbHVkQ0F4T0FvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxaMmx6ZEhKdlgyVnRjSEpsYzJGeWFXRnNMMk52Ym5SeVlXTjBMbkI1T2pFNU53b2dJQ0FnTHk4Z1kyRnRjRzg5WVhKak5DNVRkSEpwYm1jb0ltUnZiV2xqYVd4cGIxOW1hWE5qWVd3aUtTd0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNVEEyTkRabU5tUTJPVFl6TmprMll6WTVObVkxWmpZMk5qazNNell6TmpFMll3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbFoybHpkSEp2WDJWdGNISmxjMkZ5YVdGc0wyTnZiblJ5WVdOMExuQjVPakU1TlMweU1EQUtJQ0FnSUM4dklHRnlZelF1WlcxcGRDaERZVzF3YjBGamRIVmhiR2w2WVdSdktBb2dJQ0FnTHk4Z0lDQWdJR1Y0Y0dWa2FXVnVkR1U5Wlhod1pXUnBaVzUwWlN3S0lDQWdJQzh2SUNBZ0lDQmpZVzF3YnoxaGNtTTBMbE4wY21sdVp5Z2laRzl0YVdOcGJHbHZYMlpwYzJOaGJDSXBMQW9nSUNBZ0x5OGdJQ0FnSUhaaGJHOXlYMjUxWlhadlBYWmhiRzl5TEFvZ0lDQWdMeThnSUNBZ0lISmxaMmx6ZEhKaFpHOXlQV0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTd0tJQ0FnSUM4dklDa3BDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1pQXZMeUJ0WlhSb2IyUWdJa05oYlhCdlFXTjBkV0ZzYVhwaFpHOG9jM1J5YVc1bkxITjBjbWx1Wnl4emRISnBibWNzWVdSa2NtVnpjeWtpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psWjJsemRISnZYMlZ0Y0hKbGMyRnlhV0ZzTDJOdmJuUnlZV04wTG5CNU9qRTRPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Y21WbmFYTjBjbTlmWlcxd2NtVnpZWEpwWVd3dVkyOXVkSEpoWTNRdVVtVm5hWE4wY205RmJYQnlaWE5oY21saGJDNWhZM1IxWVd4cGVtRnlYM0psY0dGeWRHOWZZV05qYVc5dVpYTmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BoWTNSMVlXeHBlbUZ5WDNKbGNHRnlkRzlmWVdOamFXOXVaWE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZuYVhOMGNtOWZaVzF3Y21WellYSnBZV3d2WTI5dWRISmhZM1F1Y0hrNk1qQXlDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVm5hWE4wY205ZlpXMXdjbVZ6WVhKcFlXd3ZZMjl1ZEhKaFkzUXVjSGs2TWpBMENpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNWZaWE5mY21WbmFYTjBjbUZrYjNJb0tTd2dJazV2SUdGMWRHOXlhWHBoWkc4aUNpQWdJQ0JqWVd4c2MzVmlJRjlsYzE5eVpXZHBjM1J5WVdSdmNnb2dJQ0FnWVhOelpYSjBJQzh2SUU1dklHRjFkRzl5YVhwaFpHOEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpXZHBjM1J5YjE5bGJYQnlaWE5oY21saGJDOWpiMjUwY21GamRDNXdlVG95TURVS0lDQWdJQzh2SUdGemMyVnlkQ0JsZUhCbFpHbGxiblJsSUdsdUlITmxiR1l1Wlcxd2NtVnpZWE1zSUNKRmJYQnlaWE5oSUc1dklHVnVZMjl1ZEhKaFpHRWlDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmxiWEJ5WlhOaGN5SUtJQ0FnSUdScFp5QTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnUlcxd2NtVnpZU0J1YnlCbGJtTnZiblJ5WVdSaENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WbmFYTjBjbTlmWlcxd2NtVnpZWEpwWVd3dlkyOXVkSEpoWTNRdWNIazZNakEyQ2lBZ0lDQXZMeUJsYlhCeVpYTmhJRDBnYzJWc1ppNWxiWEJ5WlhOaGMxdGxlSEJsWkdsbGJuUmxYUzVqYjNCNUtDa0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVm5hWE4wY205ZlpXMXdjbVZ6WVhKcFlXd3ZZMjl1ZEhKaFkzUXVjSGs2TWpBM0NpQWdJQ0F2THlCbGJYQnlaWE5oTG5KbGNHRnlkRzlmWVdOamFXOXVaWE1nUFNCMllXeHZjZ29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURFeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JrYVdjZ01nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeUNpQWdJQ0JwYm5Salh6TWdMeThnTWpJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ013b2dJQ0FnYkdWdUNpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNBdENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdMUW9nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhKbGNHeGhZMlV5SURJeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WbmFYTjBjbTlmWlcxd2NtVnpZWEpwWVd3dlkyOXVkSEpoWTNRdWNIazZNakE0Q2lBZ0lDQXZMeUJ6Wld4bUxtVnRjSEpsYzJGelcyVjRjR1ZrYVdWdWRHVmRJRDBnWlcxd2NtVnpZUzVqYjNCNUtDa0tJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldkcGMzUnliMTlsYlhCeVpYTmhjbWxoYkM5amIyNTBjbUZqZEM1d2VUb3lNVE1LSUNBZ0lDOHZJSEpsWjJsemRISmhaRzl5UFdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU3dLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpXZHBjM1J5YjE5bGJYQnlaWE5oY21saGJDOWpiMjUwY21GamRDNXdlVG95TURrdE1qRTBDaUFnSUNBdkx5QmhjbU0wTG1WdGFYUW9RMkZ0Y0c5QlkzUjFZV3hwZW1Ga2J5Z0tJQ0FnSUM4dklDQWdJQ0JsZUhCbFpHbGxiblJsUFdWNGNHVmthV1Z1ZEdVc0NpQWdJQ0F2THlBZ0lDQWdZMkZ0Y0c4OVlYSmpOQzVUZEhKcGJtY29JbkpsY0dGeWRHOWZZV05qYVc5dVpYTWlLU3dLSUNBZ0lDOHZJQ0FnSUNCMllXeHZjbDl1ZFdWMmJ6MTJZV3h2Y2l3S0lDQWdJQzh2SUNBZ0lDQnlaV2RwYzNSeVlXUnZjajFoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa3NDaUFnSUNBdkx5QXBLUW9nSUNBZ2NIVnphR2x1ZENBek9Bb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQXJDaUFnSUNCa2RYQUtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1EQXlOZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQndkWE5vYVc1MElERTRDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WbmFYTjBjbTlmWlcxd2NtVnpZWEpwWVd3dlkyOXVkSEpoWTNRdWNIazZNakV4Q2lBZ0lDQXZMeUJqWVcxd2J6MWhjbU0wTGxOMGNtbHVaeWdpY21Wd1lYSjBiMTloWTJOcGIyNWxjeUlwTEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBeE1EY3lOalUzTURZeE56STNORFptTldZMk1UWXpOak0yT1RabU5tVTJOVGN6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZuYVhOMGNtOWZaVzF3Y21WellYSnBZV3d2WTI5dWRISmhZM1F1Y0hrNk1qQTVMVEl4TkFvZ0lDQWdMeThnWVhKak5DNWxiV2wwS0VOaGJYQnZRV04wZFdGc2FYcGhaRzhvQ2lBZ0lDQXZMeUFnSUNBZ1pYaHdaV1JwWlc1MFpUMWxlSEJsWkdsbGJuUmxMQW9nSUNBZ0x5OGdJQ0FnSUdOaGJYQnZQV0Z5WXpRdVUzUnlhVzVuS0NKeVpYQmhjblJ2WDJGalkybHZibVZ6SWlrc0NpQWdJQ0F2THlBZ0lDQWdkbUZzYjNKZmJuVmxkbTg5ZG1Gc2IzSXNDaUFnSUNBdkx5QWdJQ0FnY21WbmFYTjBjbUZrYjNJOVlYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwTEFvZ0lDQWdMeThnS1NrS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh5SUM4dklHMWxkR2h2WkNBaVEyRnRjRzlCWTNSMVlXeHBlbUZrYnloemRISnBibWNzYzNSeWFXNW5MSE4wY21sdVp5eGhaR1J5WlhOektTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVm5hWE4wY205ZlpXMXdjbVZ6WVhKcFlXd3ZZMjl1ZEhKaFkzUXVjSGs2TWpBeUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXlaV2RwYzNSeWIxOWxiWEJ5WlhOaGNtbGhiQzVqYjI1MGNtRmpkQzVTWldkcGMzUnliMFZ0Y0hKbGMyRnlhV0ZzTG1GamRIVmhiR2w2WVhKZmNHVnliV2x6YjE5MWMyOWZibTl0WW5KbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZV04wZFdGc2FYcGhjbDl3WlhKdGFYTnZYM1Z6YjE5dWIyMWljbVU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZuYVhOMGNtOWZaVzF3Y21WellYSnBZV3d2WTI5dWRISmhZM1F1Y0hrNk1qRTJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldkcGMzUnliMTlsYlhCeVpYTmhjbWxoYkM5amIyNTBjbUZqZEM1d2VUb3lNVGdLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTGw5bGMxOXlaV2RwYzNSeVlXUnZjaWdwTENBaVRtOGdZWFYwYjNKcGVtRmtieUlLSUNBZ0lHTmhiR3h6ZFdJZ1gyVnpYM0psWjJsemRISmhaRzl5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUbThnWVhWMGIzSnBlbUZrYndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psWjJsemRISnZYMlZ0Y0hKbGMyRnlhV0ZzTDJOdmJuUnlZV04wTG5CNU9qSXhPUW9nSUNBZ0x5OGdZWE56WlhKMElHVjRjR1ZrYVdWdWRHVWdhVzRnYzJWc1ppNWxiWEJ5WlhOaGN5d2dJa1Z0Y0hKbGMyRWdibThnWlc1amIyNTBjbUZrWVNJS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1WdGNISmxjMkZ6SWdvZ0lDQWdaR2xuSURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QkZiWEJ5WlhOaElHNXZJR1Z1WTI5dWRISmhaR0VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaV2RwYzNSeWIxOWxiWEJ5WlhOaGNtbGhiQzlqYjI1MGNtRmpkQzV3ZVRveU1qQUtJQ0FnSUM4dklHVnRjSEpsYzJFZ1BTQnpaV3htTG1WdGNISmxjMkZ6VzJWNGNHVmthV1Z1ZEdWZExtTnZjSGtvS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldkcGMzUnliMTlsYlhCeVpYTmhjbWxoYkM5amIyNTBjbUZqZEM1d2VUb3lNakVLSUNBZ0lDOHZJR1Z0Y0hKbGMyRXVjR1Z5YldsemIxOTFjMjlmYm05dFluSmxJRDBnZG1Gc2IzSUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHpJQzh2SURJeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZuYVhOMGNtOWZaVzF3Y21WellYSnBZV3d2WTI5dWRISmhZM1F1Y0hrNk1qSXlDaUFnSUNBdkx5QnpaV3htTG1WdGNISmxjMkZ6VzJWNGNHVmthV1Z1ZEdWZElEMGdaVzF3Y21WellTNWpiM0I1S0NrS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaV2RwYzNSeWIxOWxiWEJ5WlhOaGNtbGhiQzlqYjI1MGNtRmpkQzV3ZVRveU1qY0tJQ0FnSUM4dklISmxaMmx6ZEhKaFpHOXlQV0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTd0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldkcGMzUnliMTlsYlhCeVpYTmhjbWxoYkM5amIyNTBjbUZqZEM1d2VUb3lNak10TWpJNENpQWdJQ0F2THlCaGNtTTBMbVZ0YVhRb1EyRnRjRzlCWTNSMVlXeHBlbUZrYnlnS0lDQWdJQzh2SUNBZ0lDQmxlSEJsWkdsbGJuUmxQV1Y0Y0dWa2FXVnVkR1VzQ2lBZ0lDQXZMeUFnSUNBZ1kyRnRjRzg5WVhKak5DNVRkSEpwYm1jb0luQmxjbTFwYzI5ZmRYTnZYMjV2YldKeVpTSXBMQW9nSUNBZ0x5OGdJQ0FnSUhaaGJHOXlYMjUxWlhadlBYWmhiRzl5TEFvZ0lDQWdMeThnSUNBZ0lISmxaMmx6ZEhKaFpHOXlQV0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTd0tJQ0FnSUM4dklDa3BDaUFnSUNCd2RYTm9hVzUwSURNNENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lDc0tJQ0FnSUdSMWNBb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01ESTJDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lIQjFjMmhwYm5RZ01qQUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldkcGMzUnliMTlsYlhCeVpYTmhjbWxoYkM5amIyNTBjbUZqZEM1d2VUb3lNalVLSUNBZ0lDOHZJR05oYlhCdlBXRnlZelF1VTNSeWFXNW5LQ0p3WlhKdGFYTnZYM1Z6YjE5dWIyMWljbVVpS1N3S0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01USTNNRFkxTnpJMlpEWTVOek0yWmpWbU56VTNNelptTldZMlpUWm1ObVEyTWpjeU5qVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpXZHBjM1J5YjE5bGJYQnlaWE5oY21saGJDOWpiMjUwY21GamRDNXdlVG95TWpNdE1qSTRDaUFnSUNBdkx5QmhjbU0wTG1WdGFYUW9RMkZ0Y0c5QlkzUjFZV3hwZW1Ga2J5Z0tJQ0FnSUM4dklDQWdJQ0JsZUhCbFpHbGxiblJsUFdWNGNHVmthV1Z1ZEdVc0NpQWdJQ0F2THlBZ0lDQWdZMkZ0Y0c4OVlYSmpOQzVUZEhKcGJtY29JbkJsY20xcGMyOWZkWE52WDI1dmJXSnlaU0lwTEFvZ0lDQWdMeThnSUNBZ0lIWmhiRzl5WDI1MVpYWnZQWFpoYkc5eUxBb2dJQ0FnTHk4Z0lDQWdJSEpsWjJsemRISmhaRzl5UFdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU3dLSUNBZ0lDOHZJQ2twQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNaUF2THlCdFpYUm9iMlFnSWtOaGJYQnZRV04wZFdGc2FYcGhaRzhvYzNSeWFXNW5MSE4wY21sdVp5eHpkSEpwYm1jc1lXUmtjbVZ6Y3lraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbFoybHpkSEp2WDJWdGNISmxjMkZ5YVdGc0wyTnZiblJ5WVdOMExuQjVPakl4TmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWNtVm5hWE4wY205ZlpXMXdjbVZ6WVhKcFlXd3VZMjl1ZEhKaFkzUXVVbVZuYVhOMGNtOUZiWEJ5WlhOaGNtbGhiQzVqWVcxaWFXRnlYMlZ6ZEdGMGRYTmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqWVcxaWFXRnlYMlZ6ZEdGMGRYTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVm5hWE4wY205ZlpXMXdjbVZ6WVhKcFlXd3ZZMjl1ZEhKaFkzUXVjSGs2TWpNd0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlEUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbFoybHpkSEp2WDJWdGNISmxjMkZ5YVdGc0wyTnZiblJ5WVdOMExuQjVPakl6TXdvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdVgyVnpYM0psWjJsemRISmhaRzl5S0Nrc0lDSk9ieUJoZFhSdmNtbDZZV1J2SWdvZ0lDQWdZMkZzYkhOMVlpQmZaWE5mY21WbmFYTjBjbUZrYjNJS0lDQWdJR0Z6YzJWeWRDQXZMeUJPYnlCaGRYUnZjbWw2WVdSdkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WbmFYTjBjbTlmWlcxd2NtVnpZWEpwWVd3dlkyOXVkSEpoWTNRdWNIazZNak0wQ2lBZ0lDQXZMeUJoYzNObGNuUWdaWGh3WldScFpXNTBaU0JwYmlCelpXeG1MbVZ0Y0hKbGMyRnpMQ0FpUlcxd2NtVnpZU0J1YnlCbGJtTnZiblJ5WVdSaElnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVpXMXdjbVZ6WVhNaUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QkZiWEJ5WlhOaElHNXZJR1Z1WTI5dWRISmhaR0VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaV2RwYzNSeWIxOWxiWEJ5WlhOaGNtbGhiQzlqYjI1MGNtRmpkQzV3ZVRveU16WUtJQ0FnSUM4dklHNTFaWFp2WDJWemRHRjBkWE11Ym1GMGFYWmxJRDA5SUZOMGNtbHVaeWdpWVdOMGFYWmhJaWtLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaGllWFJsY3lBaVlXTjBhWFpoSWdvZ0lDQWdQVDBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaV2RwYzNSeWIxOWxiWEJ5WlhOaGNtbGhiQzlqYjI1MGNtRmpkQzV3ZVRveU16WXRNak00Q2lBZ0lDQXZMeUJ1ZFdWMmIxOWxjM1JoZEhWekxtNWhkR2wyWlNBOVBTQlRkSEpwYm1jb0ltRmpkR2wyWVNJcENpQWdJQ0F2THlCdmNpQnVkV1YyYjE5bGMzUmhkSFZ6TG01aGRHbDJaU0E5UFNCVGRISnBibWNvSW5OMWMzQmxibVJwWkdFaUtRb2dJQ0FnTHk4Z2IzSWdiblZsZG05ZlpYTjBZWFIxY3k1dVlYUnBkbVVnUFQwZ1UzUnlhVzVuS0NKa2FYTjFaV3gwWVNJcENpQWdJQ0JpYm5vZ1kyRnRZbWxoY2w5bGMzUmhkSFZ6WDJKdmIyeGZkSEoxWlVBMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WbmFYTjBjbTlmWlcxd2NtVnpZWEpwWVd3dlkyOXVkSEpoWTNRdWNIazZNak0zQ2lBZ0lDQXZMeUJ2Y2lCdWRXVjJiMTlsYzNSaGRIVnpMbTVoZEdsMlpTQTlQU0JUZEhKcGJtY29Jbk4xYzNCbGJtUnBaR0VpS1FvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vWW5sMFpYTWdJbk4xYzNCbGJtUnBaR0VpQ2lBZ0lDQTlQUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxaMmx6ZEhKdlgyVnRjSEpsYzJGeWFXRnNMMk52Ym5SeVlXTjBMbkI1T2pJek5pMHlNemdLSUNBZ0lDOHZJRzUxWlhadlgyVnpkR0YwZFhNdWJtRjBhWFpsSUQwOUlGTjBjbWx1WnlnaVlXTjBhWFpoSWlrS0lDQWdJQzh2SUc5eUlHNTFaWFp2WDJWemRHRjBkWE11Ym1GMGFYWmxJRDA5SUZOMGNtbHVaeWdpYzNWemNHVnVaR2xrWVNJcENpQWdJQ0F2THlCdmNpQnVkV1YyYjE5bGMzUmhkSFZ6TG01aGRHbDJaU0E5UFNCVGRISnBibWNvSW1ScGMzVmxiSFJoSWlrS0lDQWdJR0p1ZWlCallXMWlhV0Z5WDJWemRHRjBkWE5mWW05dmJGOTBjblZsUURRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldkcGMzUnliMTlsYlhCeVpYTmhjbWxoYkM5amIyNTBjbUZqZEM1d2VUb3lNemdLSUNBZ0lDOHZJRzl5SUc1MVpYWnZYMlZ6ZEdGMGRYTXVibUYwYVhabElEMDlJRk4wY21sdVp5Z2laR2x6ZFdWc2RHRWlLUW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9ZbmwwWlhNZ0ltUnBjM1ZsYkhSaElnb2dJQ0FnUFQwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldkcGMzUnliMTlsYlhCeVpYTmhjbWxoYkM5amIyNTBjbUZqZEM1d2VUb3lNell0TWpNNENpQWdJQ0F2THlCdWRXVjJiMTlsYzNSaGRIVnpMbTVoZEdsMlpTQTlQU0JUZEhKcGJtY29JbUZqZEdsMllTSXBDaUFnSUNBdkx5QnZjaUJ1ZFdWMmIxOWxjM1JoZEhWekxtNWhkR2wyWlNBOVBTQlRkSEpwYm1jb0luTjFjM0JsYm1ScFpHRWlLUW9nSUNBZ0x5OGdiM0lnYm5WbGRtOWZaWE4wWVhSMWN5NXVZWFJwZG1VZ1BUMGdVM1J5YVc1bktDSmthWE4xWld4MFlTSXBDaUFnSUNCaWVpQmpZVzFpYVdGeVgyVnpkR0YwZFhOZlltOXZiRjltWVd4elpVQTFDZ3BqWVcxaWFXRnlYMlZ6ZEdGMGRYTmZZbTl2YkY5MGNuVmxRRFE2Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9LWTJGdFltbGhjbDlsYzNSaGRIVnpYMkp2YjJ4ZmJXVnlaMlZBTmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldkcGMzUnliMTlsYlhCeVpYTmhjbWxoYkM5amIyNTBjbUZqZEM1d2VUb3lNelV0TWpNNUNpQWdJQ0F2THlCaGMzTmxjblFnS0FvZ0lDQWdMeThnSUNBZ0lHNTFaWFp2WDJWemRHRjBkWE11Ym1GMGFYWmxJRDA5SUZOMGNtbHVaeWdpWVdOMGFYWmhJaWtLSUNBZ0lDOHZJQ0FnSUNCdmNpQnVkV1YyYjE5bGMzUmhkSFZ6TG01aGRHbDJaU0E5UFNCVGRISnBibWNvSW5OMWMzQmxibVJwWkdFaUtRb2dJQ0FnTHk4Z0lDQWdJRzl5SUc1MVpYWnZYMlZ6ZEdGMGRYTXVibUYwYVhabElEMDlJRk4wY21sdVp5Z2laR2x6ZFdWc2RHRWlLUW9nSUNBZ0x5OGdLU3dnSWtWemRHRjBkWE1nYVc1Mnc2RnNhV1J2TGlCVmMyVTZJR0ZqZEdsMllTd2djM1Z6Y0dWdVpHbGtZU0J2SUdScGMzVmxiSFJoSWdvZ0lDQWdZWE56WlhKMElDOHZJRVZ6ZEdGMGRYTWdhVzUydzZGc2FXUnZMaUJWYzJVNklHRmpkR2wyWVN3Z2MzVnpjR1Z1Wkdsa1lTQnZJR1JwYzNWbGJIUmhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVm5hWE4wY205ZlpXMXdjbVZ6WVhKcFlXd3ZZMjl1ZEhKaFkzUXVjSGs2TWpRd0NpQWdJQ0F2THlCbGJYQnlaWE5oSUQwZ2MyVnNaaTVsYlhCeVpYTmhjMXRsZUhCbFpHbGxiblJsWFM1amIzQjVLQ2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1WdGNISmxjMkZ6SUdWdWRISjVJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbFoybHpkSEp2WDJWdGNISmxjMkZ5YVdGc0wyTnZiblJ5WVdOMExuQjVPakkwTUMweU5ERUtJQ0FnSUM4dklHVnRjSEpsYzJFZ1BTQnpaV3htTG1WdGNISmxjMkZ6VzJWNGNHVmthV1Z1ZEdWZExtTnZjSGtvS1FvZ0lDQWdMeThnWlhOMFlYUjFjMTloYm5SbGNtbHZjaUE5SUdWdGNISmxjMkV1WlhOMFlYUjFjd29nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ05nb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1luUnZhUW9nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBekNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbFoybHpkSEp2WDJWdGNISmxjMkZ5YVdGc0wyTnZiblJ5WVdOMExuQjVPakkwTWdvZ0lDQWdMeThnWlcxd2NtVnpZUzVsYzNSaGRIVnpJRDBnYm5WbGRtOWZaWE4wWVhSMWN3b2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaHBiblFnTmdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaR2xuSURJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dPQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBekNpQWdJQ0J3ZFhOb2FXNTBJRGdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmthV2NnTkFvZ0lDQWdiR1Z1Q2lBZ0lDQmthV2NnTlFvZ0lDQWdaR2xuSURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lDMEtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaR2xuSURrS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ05Bb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJQzBLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJSEpsY0d4aFkyVXlJRGdLSUNBZ0lHUnBaeUEwQ2lBZ0lDQndkWE5vYVc1MElERXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JRE1LSUNBZ0lDc0tJQ0FnSUdScFp5QXlDaUFnSUNBdENpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjbVZ3YkdGalpUSWdNVEFLSUNBZ0lHUnBaeUEwQ2lBZ0lDQndkWE5vYVc1MElERXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JRE1LSUNBZ0lDc0tJQ0FnSUdScFp5QXlDaUFnSUNBdENpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjbVZ3YkdGalpUSWdNVElLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnYVc1MFkxOHpJQzh2SURJeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQXJDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJQzBLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCeVpYQnNZV05sTWlBeU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbFoybHpkSEp2WDJWdGNISmxjMkZ5YVdGc0wyTnZiblJ5WVdOMExuQjVPakkwTXdvZ0lDQWdMeThnYzJWc1ppNWxiWEJ5WlhOaGMxdGxlSEJsWkdsbGJuUmxYU0E5SUdWdGNISmxjMkV1WTI5d2VTZ3BDaUFnSUNCa2FXY2dNZ29nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaV2RwYzNSeWIxOWxiWEJ5WlhOaGNtbGhiQzlqYjI1MGNtRmpkQzV3ZVRveU5EZ0tJQ0FnSUM4dklISmxaMmx6ZEhKaFpHOXlQV0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTd0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldkcGMzUnliMTlsYlhCeVpYTmhjbWxoYkM5amIyNTBjbUZqZEM1d2VUb3lORFF0TWpRNUNpQWdJQ0F2THlCaGNtTTBMbVZ0YVhRb1JYTjBZWFIxYzAxdlpHbG1hV05oWkc4b0NpQWdJQ0F2THlBZ0lDQWdaWGh3WldScFpXNTBaVDFsZUhCbFpHbGxiblJsTEFvZ0lDQWdMeThnSUNBZ0lHVnpkR0YwZFhOZllXNTBaWEpwYjNJOVpYTjBZWFIxYzE5aGJuUmxjbWx2Y2l3S0lDQWdJQzh2SUNBZ0lDQmxjM1JoZEhWelgyNTFaWFp2UFc1MVpYWnZYMlZ6ZEdGMGRYTXNDaUFnSUNBdkx5QWdJQ0FnY21WbmFYTjBjbUZrYjNJOVlYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwTEFvZ0lDQWdMeThnS1NrS0lDQWdJSEIxYzJocGJuUWdNemdLSUNBZ0lHUnBaeUE0Q2lBZ0lDQXJDaUFnSUNCa2RYQUtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1EQXlOZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTXdvZ0lDQWdiR1Z1Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklEZ0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURkaVltVXpaREF6SUM4dklHMWxkR2h2WkNBaVJYTjBZWFIxYzAxdlpHbG1hV05oWkc4b2MzUnlhVzVuTEhOMGNtbHVaeXh6ZEhKcGJtY3NZV1JrY21WemN5a2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxaMmx6ZEhKdlgyVnRjSEpsYzJGeWFXRnNMMk52Ym5SeVlXTjBMbkI1T2pJek1Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtTmhiV0pwWVhKZlpYTjBZWFIxYzE5aWIyOXNYMlpoYkhObFFEVTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWWlCallXMWlhV0Z5WDJWemRHRjBkWE5mWW05dmJGOXRaWEpuWlVBMkNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbkpsWjJsemRISnZYMlZ0Y0hKbGMyRnlhV0ZzTG1OdmJuUnlZV04wTGxKbFoybHpkSEp2Ulcxd2NtVnpZWEpwWVd3dVkyOXVjM1ZzZEdGeVgyVnRjSEpsYzJGYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpiMjV6ZFd4MFlYSmZaVzF3Y21WellUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpXZHBjM1J5YjE5bGJYQnlaWE5oY21saGJDOWpiMjUwY21GamRDNXdlVG95TlRNS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psWjJsemRISnZYMlZ0Y0hKbGMyRnlhV0ZzTDJOdmJuUnlZV04wTG5CNU9qSTFOZ29nSUNBZ0x5OGdZWE56WlhKMElHVjRjR1ZrYVdWdWRHVWdhVzRnYzJWc1ppNWxiWEJ5WlhOaGN5d2dJa1Z0Y0hKbGMyRWdibThnWlc1amIyNTBjbUZrWVNJS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1WdGNISmxjMkZ6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklFVnRjSEpsYzJFZ2JtOGdaVzVqYjI1MGNtRmtZUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxaMmx6ZEhKdlgyVnRjSEpsYzJGeWFXRnNMMk52Ym5SeVlXTjBMbkI1T2pJMU53b2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVaVzF3Y21WellYTmJaWGh3WldScFpXNTBaVjB1WTI5d2VTZ3BDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaV2RwYzNSeWIxOWxiWEJ5WlhOaGNtbGhiQzlqYjI1MGNtRmpkQzV3ZVRveU5UTUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1lubDBaV01nTmlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1eVpXZHBjM1J5YjE5bGJYQnlaWE5oY21saGJDNWpiMjUwY21GamRDNVNaV2RwYzNSeWIwVnRjSEpsYzJGeWFXRnNMbVZ6WDNKbFoybHpkSEpoWkc5eVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taWE5mY21WbmFYTjBjbUZrYjNJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WbmFYTjBjbTlmWlcxd2NtVnpZWEpwWVd3dlkyOXVkSEpoWTNRdWNIazZNalU1Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaV2RwYzNSeWIxOWxiWEJ5WlhOaGNtbGhiQzlqYjI1MGNtRmpkQzV3ZVRveU5qRUtJQ0FnSUM4dklHbG1JR04xWlc1MFlTQnBiaUJ6Wld4bUxuSmxaMmx6ZEhKaFpHOXlaWE02Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0p5WldkcGMzUnlZV1J2Y21Weklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbm9nWlhOZmNtVm5hWE4wY21Ga2IzSmZZV1owWlhKZmFXWmZaV3h6WlVBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WbmFYTjBjbTlmWlcxd2NtVnpZWEpwWVd3dlkyOXVkSEpoWTNRdWNIazZNall5Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1Q2IyOXNLSE5sYkdZdWNtVm5hWE4wY21Ga2IzSmxjMXRqZFdWdWRHRmRMbTVoZEdsMlpTa0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjbVZuYVhOMGNtRmtiM0psY3lCbGJuUnllU0JsZUdsemRITUtDbVZ6WDNKbFoybHpkSEpoWkc5eVgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbkpsWjJsemRISnZYMlZ0Y0hKbGMyRnlhV0ZzTG1OdmJuUnlZV04wTGxKbFoybHpkSEp2Ulcxd2NtVnpZWEpwWVd3dVpYTmZjbVZuYVhOMGNtRmtiM0pBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldkcGMzUnliMTlsYlhCeVpYTmhjbWxoYkM5amIyNTBjbUZqZEM1d2VUb3lOVGtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZbmwwWldNZ05pQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS1pYTmZjbVZuYVhOMGNtRmtiM0pmWVdaMFpYSmZhV1pmWld4elpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxaMmx6ZEhKdlgyVnRjSEpsYzJGeWFXRnNMMk52Ym5SeVlXTjBMbkI1T2pJMk13b2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVRbTl2YkNoR1lXeHpaU2tLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZuYVhOMGNtOWZaVzF3Y21WellYSnBZV3d2WTI5dWRISmhZM1F1Y0hrNk1qVTVDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHSWdaWE5mY21WbmFYTjBjbUZrYjNKZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXVjbVZuYVhOMGNtOWZaVzF3Y21WellYSnBZV3d1WTI5dWRISmhZM1F1VW1WbmFYTjBjbTlGYlhCeVpYTmhjbWxoYkM1bGMxOXlaV2RwYzNSeVlXUnZja0EwQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuSmxaMmx6ZEhKdlgyVnRjSEpsYzJGeWFXRnNMbU52Ym5SeVlXTjBMbEpsWjJsemRISnZSVzF3Y21WellYSnBZV3d1YjJKMFpXNWxjbDkwYjNSaGJGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbTlpZEdWdVpYSmZkRzkwWVd3NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WbmFYTjBjbTlmWlcxd2NtVnpZWEpwWVd3dlkyOXVkSEpoWTNRdWNIazZNalkzQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1MGIzUmhiRjlsYlhCeVpYTmhjeTUyWVd4MVpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5SdmRHRnNYMlZ0Y0hKbGMyRnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SdmRHRnNYMlZ0Y0hKbGMyRnpJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbFoybHpkSEp2WDJWdGNISmxjMkZ5YVdGc0wyTnZiblJ5WVdOMExuQjVPakkyTlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFl5QTJJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbkpsWjJsemRISnZYMlZ0Y0hKbGMyRnlhV0ZzTG1OdmJuUnlZV04wTGxKbFoybHpkSEp2Ulcxd2NtVnpZWEpwWVd3dVgyVnpYM0psWjJsemRISmhaRzl5S0NrZ0xUNGdkV2x1ZERZME9ncGZaWE5mY21WbmFYTjBjbUZrYjNJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WbmFYTjBjbTlmWlcxd2NtVnpZWEpwWVd3dlkyOXVkSEpoWTNRdWNIazZNamN4TFRJM01nb2dJQ0FnTHk4Z1FITjFZbkp2ZFhScGJtVUtJQ0FnSUM4dklHUmxaaUJmWlhOZmNtVm5hWE4wY21Ga2IzSW9jMlZzWmlrZ0xUNGdZbTl2YkRvS0lDQWdJSEJ5YjNSdklEQWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxaMmx6ZEhKdlgyVnRjSEpsYzJGeWFXRnNMMk52Ym5SeVlXTjBMbkI1T2pJM05Bb2dJQ0FnTHk4Z2FXWWdjMlZ1WkdWeUlHbHVJSE5sYkdZdWNtVm5hWE4wY21Ga2IzSmxjem9LSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbkpsWjJsemRISmhaRzl5WlhNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WbmFYTjBjbTlmWlcxd2NtVnpZWEpwWVd3dlkyOXVkSEpoWTNRdWNIazZNamN6Q2lBZ0lDQXZMeUJ6Wlc1a1pYSWdQU0JoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldkcGMzUnliMTlsYlhCeVpYTmhjbWxoYkM5amIyNTBjbUZqZEM1d2VUb3lOelFLSUNBZ0lDOHZJR2xtSUhObGJtUmxjaUJwYmlCelpXeG1MbkpsWjJsemRISmhaRzl5WlhNNkNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmllaUJmWlhOZmNtVm5hWE4wY21Ga2IzSmZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WbmFYTjBjbTlmWlcxd2NtVnpZWEpwWVd3dlkyOXVkSEpoWTNRdWNIazZNamMxQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1eVpXZHBjM1J5WVdSdmNtVnpXM05sYm1SbGNsMHVibUYwYVhabENpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNtVm5hWE4wY21Ga2IzSmxjeUJsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJSE4zWVhBS0lDQWdJSEpsZEhOMVlnb0tYMlZ6WDNKbFoybHpkSEpoWkc5eVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldkcGMzUnliMTlsYlhCeVpYTmhjbWxoYkM5amIyNTBjbUZqZEM1d2VUb3lOellLSUNBZ0lDOHZJSEpsZEhWeWJpQkdZV3h6WlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lITjNZWEFLSUNBZ0lISmxkSE4xWWdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQUlCRmlZSENHVnRjSEpsYzJGekFnQW1CRFhDczNnT2RHOTBZV3hmWlcxd2NtVnpZWE1OY21WbmFYTjBjbUZrYjNKbGN3VmhaRzFwYmdRVkgzeDFNUmtVUkRFWVFRQmpnZzBFN0dQU0pnUzh4aFRVQkZQOUNZY0U3TFdPblFRM3g5RVRCRzRwU1pNRW5CRGJNQVJNVElYb0JQRzQrR0FFQTl4aWZ3VGNvN0QzQkZDRkVYVUVuTHVwUmpZYUFJNE5BQmtBUHdCb0FuUURiZ1J5QlRzRjhBYVFCd2NJTHdoTkNIRUFnQVNMd1c2OU5ob0FqZ0VBQVFBbkJURUFaeXNpWnlSRE5ob0JTUldCSUJKRU1RQWlKd1ZsUkJKRUp3UkxBVkNBQVlDL2dBUXFXZ1czVEZDd0pFTTJHZ0ZKRllFZ0VrUXhBQ0luQldWRUVrUW5CRXNCVUVtOVJRRkV2RWlBQkRJelFReE1VTEFrUXpZYUFVY0NJbGtqQ0VzQkZVbE9BeEpFTmhvQ1NVNENTU0paSXdoTUZVbE9BeEpFTmhvRFNVNENTU0paSXdoTEFSVkpUZ1FTUkRZYUJFbE9BMGtpV1NNSVRCVkpUZ1FTUkRZYUJVbE9BMGtpV1NNSVRCVkpUZ1FTUkRZYUJrbE9BMGtpV1NNSVRCVkpUZ1FTUkRZYUIwbE9BeFdCQ0JKRU5ob0lTVTREU1NKWkl3aE1GUkpFaUFlTVJDaFBBbEJKVGdLOVJRRVVSRmNDQUVtQUJGTXVRUzRTUUFDVFNZQUtVeTRnWkdVZ1VpNU1MaEpBQUlKSmdBWlRMa0V1VXk0U1FBQjFTWUFHVXk1RExrd3VFa0FBYUVtQUJsTXVReTVXTGhKQUFGdEpnQXBUTGlCbGJpQk9Ma011RWtBQVNrbUFDRk11SUdWdUlFTXVFa0FBTzBtQUQxTXVJR1Z1SUVNdUlIQnZjaUJCTGhKQUFDVkpnQVJUTGtNdUVrQUFHa21BQkVFdVF5NFNRQUFQU1lBSVV5NUJMbEF1U1M0U1FRRFJKRVNCR0VzTlNVNENDRWtXVndZQ2dBSUFHRXhRVENNSVNSWlhCZ0pQQWt4UVRFc05DRWtXVndZQ1R3Sk1VRXlCQ0FoSkZsY0dBazhDVEZCTVN3c0lTUlpYQmdKUEFreFFURXNKQ0VrV1Z3WUNUd0pNVUV4TEJ3aE1Td1pKVGdOUVRCWlhCZ0pRU3hCSlRnSlFnQUlBQUZCTEQwbE9BbENBQ0FBR1lXTjBhWFpoVUVzT1VFc01VRXNLVUVzSFVFc0dTYnhJVEw4aUsyVkVKQWdyVEdjeEFJRXVTeFFJU1JaWEJnS0FBZ0F1VEZCTVR3WUlGbGNHQWxCUEJGQk1VRXNTVUU4Q1VFeFFnQVFDY29yL1RGQ3dKRU1pUXY4c05ob0JTU0paSXdoTEFSVkpUd0lTUkRZYUFra2lXU01JU3dFVlNVOENFa1NJQmVaRUtFc0VVRW05UlFGRVNiNUlURWtqU2JvWFNpTzZGeU1JU3dKT0FycFhBZ0NBQUJKRVN3RWpXVXNDSWtzQ1dFc0ZVRXNEZ1FSWlN3UVZTd1ZMQWs4Q1VrOENURkJMQVU4RENVOENTd1VJU3dFSkZsY0dBazhDVEZ3RVN3T0JCbGxMQlFoTEFna1dWd1lDWEFaTEE0RUlXVXNGQ0VzQ0NSWlhCZ0pjQ0VzRGdRcFpTd1VJU3dJSkZsY0dBbHdLU3dPQkRGbExCUWhMQWdrV1Z3WUNYQXhQQXlWWlR3UUlUd0lKRmxjR0Fsd1dTd0c4U0w4eEFJRWtUd01JRmxjR0FvQUNBQ1JNVUV4UVR3SlFURkNBQkEyc2s5Sk1VTEFrUXpZYUFVa2lXU01JU3dFVlNVOENFa1EyR2dKSklsa2pDRXNCRlVsUEFoSkVpQVRzUkNoTEJGQkp2VVVCUkVtK1NFa2lXVXNCSWtzQ1dFc0ZVRXNDSTFsTEF4VkxCRXNDVHdKU1R3Sk1VRXNCVHdNSlR3SkxCUWhMQVFrV1Z3WUNUd0pNWEFKTEFvRUVXVXNGQ0VzQ0NSWlhCZ0pjQkVzQ2dRWlpTd1VJU3dJSkZsY0dBbHdHU3dLQkNGbExCUWhMQWdrV1Z3WUNYQWhMQW9FS1dVc0ZDRXNDQ1JaWEJnSmNDa3NDZ1F4WlN3VUlTd0lKRmxjR0Fsd01Ud0lsV1U4RUNFOENDUlpYQmdKY0Zrc0J2RWkvTVFDQkprOERDRWtXVndZQ0tVeFFUSUVPQ0JaWEJnSlFURkJQQWxDQURnQU1jbUY2YjI1ZmMyOWphV0ZzVUV4UUtreFFzQ1JETmhvQlNTSlpJd2hMQVJWSlR3SVNSRFlhQWtraVdTTUlTd0VWU1U4Q0VrU0lBK2hFS0VzRVVFbTlSUUZFU2I1SVNZRUlXVXNCSWtzQ1dFc0ZVRXNDZ1FwWlN3TVZTd1JMQWs4Q1VrOENURkJMQVU4RENVOENTd1VJU3dFSkZsY0dBazhDVEZ3S1N3S0JERmxMQlFoTEFna1dWd1lDWEF4UEFpVlpUd1FJVHdJSkZsY0dBbHdXU3dHOFNMOHhBSUVtVHdNSVNSWlhCZ0lwVEZCTWdSVUlGbGNHQWxCTVVFOENVSUFWQUJOeVpYQnlaWE5sYm5SaGJuUmxYMnhsWjJGc1VFeFFLa3hRc0NSRE5ob0JTU0paSXdoTEFSVkpUd0lTUkRZYUFra2lXU01JU3dFVlNVOENFa1NJQXg5RUtFc0VVRW05UlFGRVNiNUlTWUVLV1VzQklrc0NXRXNGVUVzQ2dReFpTd01WU3dSTEFrOENVazhDVEZCTEFVOERDVThDU3dVSVN3RUpGbGNHQWs4Q1RGd01Ud0lsV1U4RUNFOENDUlpYQmdKY0Zrc0J2RWkvTVFDQkprOERDRWtXVndZQ0tVeFFUSUVTQ0JaWEJnSlFURkJQQWxDQUVnQVFaRzl0YVdOcGJHbHZYMlpwYzJOaGJGQk1VQ3BNVUxBa1F6WWFBVWtpV1NNSVN3RVZTVThDRWtRMkdnSkpJbGtqQ0VzQkZVbFBBaEpFaUFKcVJDaExCRkJKdlVVQlJFbStTRW1CREZsTEFTSkxBbGhMQlZCTEFpVlpTd01WVHdSTEFrOENVazhDVEZCTEFVOERDVThDVHdRSVRBa1dWd1lDWEJaTEFieEl2ekVBZ1NaUEF3aEpGbGNHQWlsTVVFeUJFZ2dXVndZQ1VFeFFUd0pRZ0JJQUVISmxjR0Z5ZEc5ZllXTmphVzl1WlhOUVRGQXFURkN3SkVNMkdnRkpJbGtqQ0VzQkZVbFBBaEpFTmhvQ1NTSlpJd2hMQVJVU1JJZ0J6VVFvU3dOUVNiMUZBVVJKdmtoSkpWa2lURmhMQWxCTEFieEl2ekVBZ1NaUEF3aEpGbGNHQWlsTVVFeUJGQWdXVndZQ1VFeFFUd0pRZ0JRQUVuQmxjbTFwYzI5ZmRYTnZYMjV2YldKeVpWQk1VQ3BNVUxBa1F6WWFBVWNDSWxrakNFc0JGVWxPQXhKRU5ob0NTVTRDU1NKWkl3aExBUlZKVGdRU1JJZ0JUMFFvVHdKUVNVNEN2VVVCUkZjQ0FFbUFCbUZqZEdsMllSSkFBQ0JKZ0FwemRYTndaVzVrYVdSaEVrQUFEMG1BQ0dScGMzVmxiSFJoRWtFQXdTUkVTd0ZKdmtSTEFZRUdJN29YU3dKTEFTTzZGeU1JU3dOT0FycExBWUVHV1VzQ0lrc0NXRXNJU1U0R1VFc0RnUWhaU3dRVlN3VkxBazhDVWs4Q1RGQkxBVThEQ1U4Q1N3bEpUZ1FJU3dFSkZsY0dBazhDVEZ3SVN3U0JDbGxMQXdoTEFna1dWd1lDWEFwTEJJRU1XVXNEQ0VzQ0NSWlhCZ0pjREU4RUpWbFBBd2hQQWdrV1Z3WUNYQlpMQXJ4SVR3Sk12ekVBZ1NaTENBaEpGbGNHQWlsTVVFc0RGVThDQ0JaWEJnSlFURkJMQ0ZCTVVFeFFnQVI3dmowRFRGQ3dKRU1pUXY4OE5ob0JTU0paSXdoTEFSVVNSQ2hNVUVtOVJRRkV2a2duQmt4UXNDUkROaG9CU1JXQklCSkVKd1JNVUVtOVJRRkJBQXBKdmtRbkJreFFzQ1JEZ0FFQVF2L3pJaXRsUkJZbkJreFFzQ1JEaWdBQkp3UXhBRkJKdlVVQlFRQUlpd0MrUkNKVFRJa2lUSWs9IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbeyJuYW1lIjoiUmVnaXN0cmFkb3JBZ3JlZ2FkbyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY3VlbnRhIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJSZWdpc3RyYWRvclJlbW92aWRvIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjdWVudGEiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkVtcHJlc2FSZWdpc3RyYWRhIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV4cGVkaWVudGUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyYXpvbl9zb2NpYWwiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0aXBvX3NvY2llZGFkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibnVtZXJvX25vdGFyaWEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVnaXN0cmFkb3IiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlJGQ1JlZ2lzdHJhZG8iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXhwZWRpZW50ZSIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJmYyIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWdpc3RyYWRvciIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiQ2FtcG9BY3R1YWxpemFkbyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJleHBlZGllbnRlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FtcG8iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWxvcl9udWV2byIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWdpc3RyYWRvciIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiRXN0YXR1c01vZGlmaWNhZG8iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXhwZWRpZW50ZSIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImVzdGF0dXNfYW50ZXJpb3IiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJlc3RhdHVzX251ZXZvIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZ2lzdHJhZG9yIiwiZGVzYyI6bnVsbH1dfV0sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
