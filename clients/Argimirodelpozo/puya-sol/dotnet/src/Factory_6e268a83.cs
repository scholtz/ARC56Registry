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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.Factory_6e268a83
{


    public class FactoryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public FactoryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        public class Events
        {
            public class DeployedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 70, 102, 181, 72 };
                public const string Signature = "Deployed(uint8[32],uint8[32])";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] 0 { get; set; }
            public byte[] 1 { get; set; }

        public static DeployedEvent Decode(byte[] log)
        {
            if (!Matches(log)) throw new Exception("Log does not match event selector");
            var ret = new DeployedEvent();
            var eventData = log.Skip(4).ToArray();
            var queue = new Queue<byte>(eventData);
            uint count = 0;
            AVM.ClientGenerator.ABI.ARC4.Types.WireType v0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
            count = v0.Decode(queue.ToArray());
            for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
            var value0 = v0.ToValue();
            if (value0 is byte[] v0Value) { ret.0 = v0Value; }
            AVM.ClientGenerator.ABI.ARC4.Types.WireType v1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
            count = v1.Decode(queue.ToArray());
            for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
            var value1 = v1.ToValue();
            if (value1 is byte[] v1Value) { ret.1 = v1Value; }
            return ret;

        }

    }

}

///<summary>
///
///</summary>
/// <param name="_salt"> </param>
public async Task<Algorand.Address> Deploy(byte[] _salt, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 83, 82, 169, 0 };
    var _saltAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); _saltAbi.From(_salt);

    var result = await base.CallApp(new List<object> { abiHandle, _saltAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
    var lastLogBytes = result.Last();
    if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
    var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
    var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
    returnValueObj.Decode(lastLogReturnData);
    return new Algorand.Address(returnValueObj.ToByteArray());

}

public async Task<List<Transaction>> Deploy_Transactions(byte[] _salt, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 83, 82, 169, 0 };
    var _saltAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); _saltAbi.From(_salt);

    return await base.MakeTransactionList(new List<object> { abiHandle, _saltAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRmFjdG9yeSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJkZXBsb3kiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfc2FsdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiRGVwbG95ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzAiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfMSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTQ1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2ZEdWemRITXZjMjlzYVdScGRIa3RjMlZ0WVc1MGFXTXRkR1Z6ZEhNdmRHVnpkSE12ZG1GeWFXOTFjeTl6Wld4bVpHVnpkSEoxWTNSZmNHOXpkRjlqWVc1amRXNWZjbVZrWlhCc2Iza3VjMjlzTGtaaFkzUnZjbmt1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXpNaUF4Q2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0TldGa09UTmpPV1F6WXpJNE1UWmpNelJpTXpVNE5UWTFaVGhtTldaalpEWmxaRFpoT0RFeU1HVTBZakEzTTJNNFpXVTNPREV5WlRNek1UZGxaakJtT0NBd2VHWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVlLSUNBZ0lIQjFjMmhwYm5RZ05EQTVOZ29nSUNBZ1lucGxjbThLSUNBZ0lHUjFjQW9nSUNBZ2MzUnZjbVVnTlFvZ0lDQWdjM1J2Y21VZ01Bb2dJQ0FnYkc5aFpDQXdDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EZ3dDaUFnSUNCeVpYQnNZV05sTWlBMk5Bb2dJQ0FnYzNSdmNtVWdNQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcxTXpVeVlUa3dNQ0F2THlCdFpYUm9iMlFnSW1SbGNHeHZlU2hpZVhSbFd6TXlYU2xoWkdSeVpYTnpJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOWtaWEJzYjNsZmNtOTFkR1ZBTkFvZ0lDQWdaWEp5Q2dwdFlXbHVYMlJsY0d4dmVWOXliM1YwWlVBME9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDWW1DaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lHUnBaeUF4Q2lBZ0lDQmthV2NnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE5XRmtPVE5qT1dRell6STRNVFpqTXpSaU16VTROVFkxWlRobU5XWmpaRFpsWkRaaE9ERXlNR1UwWWpBM00yTTRaV1UzT0RFeVpUTXpNVGRsWmpCbU9Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCclpXTmpZV3N5TlRZS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhobVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1DaUFnSUNCaUpnb2dJQ0FnWkdsbklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjROV0ZrT1ROak9XUXpZekk0TVRaak16UmlNelU0TlRZMVpUaG1OV1pqWkRabFpEWmhPREV5TUdVMFlqQTNNMk00WldVM09ERXlaVE16TVRkbFpqQm1PQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnJaV05qWVdzeU5UWUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IaG1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptQ2lBZ0lDQmlKZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JzYjJGa0lEQUtJQ0FnSUhOMGIzSmxJREFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFEyTmpaaU5UUTRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREUxTVdZM1l6YzFNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZkR1Z6ZEhNdmMyOXNhV1JwZEhrdGMyVnRZVzUwYVdNdGRHVnpkSE12ZEdWemRITXZkbUZ5YVc5MWN5OXpaV3htWkdWemRISjFZM1JmY0c5emRGOWpZVzVqZFc1ZmNtVmtaWEJzYjNrdWMyOXNMa1poWTNSdmNua3VZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBQ0lBRW1BaUJhMlR5ZFBDZ1d3MHMxaFdYbzlmelc3V3FCSU9Td2M4anVlQkxqTVg3dytCVC8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vNEdBSUs5Sk5RVTFBRFFBZ0NBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFnRnhBTlFBeEdFQUFBaU5EZ0FSVFVxa0FOaG9BamdFQUFRQXhHUlF4R0JCRU5ob0JTUlVpRWtRaXJ6SUtTd0ZMQTFCSkZTSUpJbGhNU3dGUUtGQUNLYXhMQWt4UU1ncFBBbEFvVUFJcHJFOENURkFWSWdraVdEUUFOUUNBSUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFFa1NBSkVabXRVZ0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUV4UXNJQWtGUjk4ZFFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFzQ05EIiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbeyJuYW1lIjoiRGVwbG95ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiXzAiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfMSIsImRlc2MiOm51bGx9XX1dLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
	}

}
