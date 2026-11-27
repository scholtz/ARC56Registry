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

namespace Arc56.Generated.akita_protocol.akita_sc.MockPrincipalComposer_e6e25817
{


    //
    // TEST-ONLY (E21/T37, V0.4). Opens a window by inner composition (pattern of
    //mocks/inner-wallet-caller), using a grant whose caller is this app:
    //[wallet.arc58_rekeyToPlugin(plugin), plugin.callProbe(hintInWindow, true, probe, hintInWindow),
    // wallet.arc58_verifyAuthAddress]. With `hintInWindow != wallet` the wallet's window pinning
    //rejects the plugin call (`errIsvl`). Never deploy outside tests.
    //
    public class MockPrincipalComposerProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MockPrincipalComposerProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Principal : AVMObjectType
            {
                public ulong Wallet { get; set; }

                public Algorand.Address Principal { get; set; }

                public Algorand.Address Origin { get; set; }

                public Algorand.Address Spender { get; set; }

                public Algorand.Address Referrer { get; set; }

                public bool ViaPlugin { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWallet = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vWallet.From(Wallet);
                    ret.AddRange(vWallet.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrincipal = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vPrincipal.From(Principal);
                    ret.AddRange(vPrincipal.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOrigin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vOrigin.From(Origin);
                    ret.AddRange(vOrigin.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpender = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vSpender.From(Spender);
                    ret.AddRange(vSpender.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReferrer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vReferrer.From(Referrer);
                    ret.AddRange(vReferrer.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vViaPlugin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vViaPlugin.From(ViaPlugin);
                    ret.AddRange(vViaPlugin.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Principal Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Principal();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWallet = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vWallet.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWallet = vWallet.ToValue();
                    if (valueWallet is ulong vWalletValue) { ret.Wallet = vWalletValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrincipal = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vPrincipal.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePrincipal = vPrincipal.ToValue();
                    if (valuePrincipal is Algorand.Address vPrincipalValue) { ret.Principal = vPrincipalValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOrigin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOrigin.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOrigin = vOrigin.ToValue();
                    if (valueOrigin is Algorand.Address vOriginValue) { ret.Origin = vOriginValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpender = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vSpender.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSpender = vSpender.ToValue();
                    if (valueSpender is Algorand.Address vSpenderValue) { ret.Spender = vSpenderValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReferrer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vReferrer.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueReferrer = vReferrer.ToValue();
                    if (valueReferrer is Algorand.Address vReferrerValue) { ret.Referrer = vReferrerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vViaPlugin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vViaPlugin.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueViaPlugin = vViaPlugin.ToValue();
                    if (valueViaPlugin is bool vViaPluginValue) { ret.ViaPlugin = vViaPluginValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Principal);
                }
                public bool Equals(Principal? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Principal left, Principal right)
                {
                    return EqualityComparer<Principal>.Default.Equals(left, right);
                }
                public static bool operator !=(Principal left, Principal right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="plugin"> </param>
        /// <param name="probe"> </param>
        /// <param name="hintInWindow"> </param>
        public async Task<Structs.Principal> Compose(ulong wallet, ulong plugin, ulong probe, ulong hintInWindow, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 125, 143, 245 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var pluginAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pluginAbi.From(plugin);
            var probeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); probeAbi.From(probe);
            var hintInWindowAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hintInWindowAbi.From(hintInWindow);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi, pluginAbi, probeAbi, hintInWindowAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Principal.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> Compose_Transactions(ulong wallet, ulong plugin, ulong probe, ulong hintInWindow, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 125, 143, 245 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var pluginAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pluginAbi.From(plugin);
            var probeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); probeAbi.From(probe);
            var hintInWindowAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hintInWindowAbi.From(hintInWindow);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, pluginAbi, probeAbi, hintInWindowAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTW9ja1ByaW5jaXBhbENvbXBvc2VyIiwiZGVzYyI6IlRFU1QtT05MWSAoRTIxL1QzNywgVjAuNCkuIE9wZW5zIGEgd2luZG93IGJ5IGlubmVyIGNvbXBvc2l0aW9uIChwYXR0ZXJuIG9mXG5tb2Nrcy9pbm5lci13YWxsZXQtY2FsbGVyKSwgdXNpbmcgYSBncmFudCB3aG9zZSBjYWxsZXIgaXMgdGhpcyBhcHA6XG5bd2FsbGV0LmFyYzU4X3Jla2V5VG9QbHVnaW4ocGx1Z2luKSwgcGx1Z2luLmNhbGxQcm9iZShoaW50SW5XaW5kb3csIHRydWUsIHByb2JlLCBoaW50SW5XaW5kb3cpLFxuIHdhbGxldC5hcmM1OF92ZXJpZnlBdXRoQWRkcmVzc10uIFdpdGggYGhpbnRJbldpbmRvdyAhPSB3YWxsZXRgIHRoZSB3YWxsZXQncyB3aW5kb3cgcGlubmluZ1xucmVqZWN0cyB0aGUgcGx1Z2luIGNhbGwgKGBlcnJJc3ZsYCkuIE5ldmVyIGRlcGxveSBvdXRzaWRlIHRlc3RzLiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJQcmluY2lwYWwiOlt7Im5hbWUiOiJ3YWxsZXQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicHJpbmNpcGFsIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJvcmlnaW4iLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InNwZW5kZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InJlZmVycmVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJ2aWFQbHVnaW4iLCJ0eXBlIjoiYm9vbCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjb21wb3NlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGx1Z2luIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcm9iZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaGludEluV2luZG93IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsYWRkcmVzcyxhZGRyZXNzLGFkZHJlc3MsYWRkcmVzcyxib29sKSIsInN0cnVjdCI6IlByaW5jaXBhbCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTg3XSwiZXJyb3JNZXNzYWdlIjoiQnl0ZXMgaGFzIHZhbGlkIHByZWZpeCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYwLDY5LDc5LDg3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dPQ0F3SURZS0lDQWdJR0o1ZEdWallteHZZMnNnTUhnd01EQXdJREI0TVRVeFpqZGpOelVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5d2NtbHVZMmx3WVd3dFkyOXRjRzl6WlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE53b2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRTF2WTJ0UWNtbHVZMmx3WVd4RGIyMXdiM05sY2lCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpVQTFDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3lNRGRrT0dabU5TQXZMeUJ0WlhSb2IyUWdJbU52YlhCdmMyVW9kV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBLU2gxYVc1ME5qUXNZV1JrY21WemN5eGhaR1J5WlhOekxHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4aWIyOXNLU0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZZMjl0Y0c5elpWOXliM1YwWlVBekNpQWdJQ0JsY25JS0NtMWhhVzVmWTI5dGNHOXpaVjl5YjNWMFpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDNCeWFXNWphWEJoYkMxamIyMXdiM05sY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNENpQWdJQ0F2THlCamIyMXdiM05sS0hkaGJHeGxkRG9nUVhCd2JHbGpZWFJwYjI0c0lIQnNkV2RwYmpvZ1FYQndiR2xqWVhScGIyNHNJSEJ5YjJKbE9pQkJjSEJzYVdOaGRHbHZiaXdnYUdsdWRFbHVWMmx1Wkc5M09pQjFhVzUwTmpRcE9pQlFjbWx1WTJsd1lXd2dld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ1ltQ2lBZ0lDQmhjM05sY25RS0lDQWdJR0lnWTI5dGNHOXpaUW9LYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl3Y21sdVkybHdZV3d0WTI5dGNHOXpaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TndvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFMXZZMnRRY21sdVkybHdZV3hEYjIxd2IzTmxjaUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQW1KZ29nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDNCeWFXNWphWEJoYkMxamIyMXdiM05sY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwTmIyTnJVSEpwYm1OcGNHRnNRMjl0Y0c5elpYSXVZMjl0Y0c5elpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU52YlhCdmMyVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Y0hKcGJtTnBjR0ZzTFdOdmJYQnZjMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRnS0lDQWdJQzh2SUdOdmJYQnZjMlVvZDJGc2JHVjBPaUJCY0hCc2FXTmhkR2x2Yml3Z2NHeDFaMmx1T2lCQmNIQnNhV05oZEdsdmJpd2djSEp2WW1VNklFRndjR3hwWTJGMGFXOXVMQ0JvYVc1MFNXNVhhVzVrYjNjNklIVnBiblEyTkNrNklGQnlhVzVqYVhCaGJDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JrZFhBS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5d2NtbHVZMmx3WVd3dFkyOXRjRzl6WlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9TMHlNZ29nSUNBZ0x5OGdhWFI0YmtOdmJYQnZjMlV1WW1WbmFXNDhkSGx3Wlc5bUlFRmljM1J5WVdOMFpXUkJZMk52ZFc1MExuQnliM1J2ZEhsd1pTNWhjbU0xT0Y5eVpXdGxlVlJ2VUd4MVoybHVQaWg3Q2lBZ0lDQXZMeUFnSUdGd2NFbGtPaUIzWVd4c1pYUXNDaUFnSUNBdkx5QWdJR0Z5WjNNNklGdHdiSFZuYVc0dWFXUXNJRU5oYkd4bGNsUjVjR1ZQZEdobGNpd2dKeWNzSUZ0ZExDQmJYVjBzQ2lBZ0lDQXZMeUI5S1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDNCeWFXNWphWEJoYkMxamIyMXdiM05sY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJeENpQWdJQ0F2THlCaGNtZHpPaUJiY0d4MVoybHVMbWxrTENCRFlXeHNaWEpVZVhCbFQzUm9aWElzSUNjbkxDQmJYU3dnVzExZExBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwYjJJS0lDQWdJR1JwWnlBMUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl3Y21sdVkybHdZV3d0WTI5dGNHOXpaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T1MweU1nb2dJQ0FnTHk4Z2FYUjRia052YlhCdmMyVXVZbVZuYVc0OGRIbHdaVzltSUVGaWMzUnlZV04wWldSQlkyTnZkVzUwTG5CeWIzUnZkSGx3WlM1aGNtTTFPRjl5Wld0bGVWUnZVR3gxWjJsdVBpaDdDaUFnSUNBdkx5QWdJR0Z3Y0Vsa09pQjNZV3hzWlhRc0NpQWdJQ0F2THlBZ0lHRnlaM002SUZ0d2JIVm5hVzR1YVdRc0lFTmhiR3hsY2xSNWNHVlBkR2hsY2l3Z0p5Y3NJRnRkTENCYlhWMHNDaUFnSUNBdkx5QjlLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjROV0ZrWmpNek9HWWdMeThnYldWMGFHOWtJQ0poY21NMU9GOXlaV3RsZVZSdlVHeDFaMmx1S0hWcGJuUTJOQ3gxYVc1ME5qUXNjM1J5YVc1bkxIVnBiblEyTkZ0ZExDaDFhVzUwTmpRc2RXbHVkRFkwS1Z0ZEtYWnZhV1FpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5d2NtbHVZMmx3WVd3dFkyOXRjRzl6WlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1Rb2dJQ0FnTHk4Z1lYSm5jem9nVzNCc2RXZHBiaTVwWkN3Z1EyRnNiR1Z5Vkhsd1pVOTBhR1Z5TENBbkp5d2dXMTBzSUZ0ZFhTd0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNREF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXdNREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1EQXdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXdjbWx1WTJsd1lXd3RZMjl0Y0c5elpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPUzB5TWdvZ0lDQWdMeThnYVhSNGJrTnZiWEJ2YzJVdVltVm5hVzQ4ZEhsd1pXOW1JRUZpYzNSeVlXTjBaV1JCWTJOdmRXNTBMbkJ5YjNSdmRIbHdaUzVoY21NMU9GOXlaV3RsZVZSdlVHeDFaMmx1UGloN0NpQWdJQ0F2THlBZ0lHRndjRWxrT2lCM1lXeHNaWFFzQ2lBZ0lDQXZMeUFnSUdGeVozTTZJRnR3YkhWbmFXNHVhV1FzSUVOaGJHeGxjbFI1Y0dWUGRHaGxjaXdnSnljc0lGdGRMQ0JiWFYwc0NpQWdJQ0F2THlCOUtRb2dJQ0FnYVc1MFkxOHlJQzh2SUdGd2NHd0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwzQnlhVzVqYVhCaGJDMWpiMjF3YjNObGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXpMVEkyQ2lBZ0lDQXZMeUJwZEhodVEyOXRjRzl6WlM1dVpYaDBQSFI1Y0dWdlppQlVaWE4wVUhKcGJtTnBjR0ZzVUd4MVoybHVMbkJ5YjNSdmRIbHdaUzVqWVd4c1VISnZZbVUrS0hzS0lDQWdJQzh2SUNBZ1lYQndTV1E2SUhCc2RXZHBiaXdLSUNBZ0lDOHZJQ0FnWVhKbmN6b2dXMEZ3Y0d4cFkyRjBhVzl1S0docGJuUkpibGRwYm1SdmR5a3NJSFJ5ZFdVc0lIQnliMkpsTENCb2FXNTBTVzVYYVc1a2IzZGRMQW9nSUNBZ0x5OGdmU2tLSUNBZ0lHbDBlRzVmYm1WNGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURaa1pqUXpOekUySUM4dklHMWxkR2h2WkNBaVkyRnNiRkJ5YjJKbEtIVnBiblEyTkN4aWIyOXNMSFZwYm5RMk5DeDFhVzUwTmpRcEtIVnBiblEyTkN4aFpHUnlaWE56TEdGa1pISmxjM01zWVdSa2NtVnpjeXhoWkdSeVpYTnpMR0p2YjJ3cElnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHUjFjQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXdjbWx1WTJsd1lXd3RZMjl0Y0c5elpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOUW9nSUNBZ0x5OGdZWEpuY3pvZ1cwRndjR3hwWTJGMGFXOXVLR2hwYm5SSmJsZHBibVJ2ZHlrc0lIUnlkV1VzSUhCeWIySmxMQ0JvYVc1MFNXNVhhVzVrYjNkZExBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE9EQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5d2NtbHVZMmx3WVd3dFkyOXRjRzl6WlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU15MHlOZ29nSUNBZ0x5OGdhWFI0YmtOdmJYQnZjMlV1Ym1WNGREeDBlWEJsYjJZZ1ZHVnpkRkJ5YVc1amFYQmhiRkJzZFdkcGJpNXdjbTkwYjNSNWNHVXVZMkZzYkZCeWIySmxQaWg3Q2lBZ0lDQXZMeUFnSUdGd2NFbGtPaUJ3YkhWbmFXNHNDaUFnSUNBdkx5QWdJR0Z5WjNNNklGdEJjSEJzYVdOaGRHbHZiaWhvYVc1MFNXNVhhVzVrYjNjcExDQjBjblZsTENCd2NtOWlaU3dnYUdsdWRFbHVWMmx1Wkc5M1hTd0tJQ0FnSUM4dklIMHBDaUFnSUNCcGJuUmpYeklnTHk4Z1lYQndiQW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZjSEpwYm1OcGNHRnNMV052YlhCdmMyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamN0TWprS0lDQWdJQzh2SUdsMGVHNURiMjF3YjNObExtNWxlSFE4ZEhsd1pXOW1JRUZpYzNSeVlXTjBaV1JCWTJOdmRXNTBMbkJ5YjNSdmRIbHdaUzVoY21NMU9GOTJaWEpwWm5sQmRYUm9RV1JrY21WemN6NG9ld29nSUNBZ0x5OGdJQ0JoY0hCSlpEb2dkMkZzYkdWMExBb2dJQ0FnTHk4Z2ZTa0tJQ0FnSUdsMGVHNWZibVY0ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnMlkyTXpaall3TmlBdkx5QnRaWFJvYjJRZ0ltRnlZelU0WDNabGNtbG1lVUYxZEdoQlpHUnlaWE56S0NsMmIybGtJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2x1ZEdOZk1pQXZMeUJoY0hCc0NpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5d2NtbHVZMmx3WVd3dFkyOXRjRzl6WlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1Bb2dJQ0FnTHk4Z2FYUjRia052YlhCdmMyVXVjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZjSEpwYm1OcGNHRnNMV052YlhCdmMyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNekVLSUNBZ0lDOHZJSEpsZEhWeWJpQmtaV052WkdWQmNtTTBQRkJ5YVc1amFYQmhiRDRvYjNBdVIwbFVlRzR1YkdGemRFeHZaeWd4S1N3Z0oyeHZaeWNwQ2lBZ0lDQm5hWFI0YmlBeElFeGhjM1JNYjJjS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQTBJREFLSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNRZ01DQTBDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnUW5sMFpYTWdhR0Z6SUhaaGJHbGtJSEJ5WldacGVBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMM0J5YVc1amFYQmhiQzFqYjIxd2IzTmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU0Q2lBZ0lDQXZMeUJqYjIxd2IzTmxLSGRoYkd4bGREb2dRWEJ3YkdsallYUnBiMjRzSUhCc2RXZHBiam9nUVhCd2JHbGpZWFJwYjI0c0lIQnliMkpsT2lCQmNIQnNhV05oZEdsdmJpd2dhR2x1ZEVsdVYybHVaRzkzT2lCMWFXNTBOalFwT2lCUWNtbHVZMmx3WVd3Z2V3b2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnY0hWemFHbHVkQ0F4Q2lBZ0lDQnlaWFIxY200SyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QURDQUFHSmdJQ0FBQUVGUjk4ZFRFYlFRQVlnQVFnZlkvMU5ob0FqZ0VBQVFBeEdSUXhHQkJFUWdBSU1Sa1VNUmdVRUVNMkdnRkpGU0lTUkJjMkdnSkpGU0lTUkVrWE5ob0RTUlVpRWtRMkdnUkpGU0lTUkxFakZrc0ZzaGlBQkZyZk00K3lHazhFc2hxeUdpaXlHaWl5R2lpeUdpU3lFQ095QWJaUEFySVlnQVJ0OURjV3NocEpzaHFBQVlDeUdreXlHcklhSkxJUUk3SUJ0cklZZ0FSc3cvWUdzaG9rc2hBanNnR3p0d0UrU1ZjRUFFeFhBQVFwRWtRcFRGQ3dnUUZEIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MTAsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
