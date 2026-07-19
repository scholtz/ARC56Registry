# Generated code fails to compile: NativeTokenGateway_61476130 (TypeScript)

- **Repo**: [Argimirodelpozo/puya-sol](https://github.com/Argimirodelpozo/puya-sol)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/aave-v4/out/NativeTokenGateway/NativeTokenGateway.arc56.json](https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/aave-v4/out/NativeTokenGateway/NativeTokenGateway.arc56.json)
- **Detected**: 2026-07-19T19:02:53.989992+00:00
- **Generator package**: `@algorandfoundation/algokit-client-generator@6.0.1`

## Reproduce

```bash
npx --yes @algorandfoundation/algokit-client-generator generate \
  -a <(curl -sL https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/aave-v4/out/NativeTokenGateway/NativeTokenGateway.arc56.json) -o client.generated.ts
```

## Error

```
src/NativeTokenGateway_61476130.ts(910,5): error TS1136: Property assignment expected.
src/NativeTokenGateway_61476130.ts(910,7): error TS1136: Property assignment expected.
src/NativeTokenGateway_61476130.ts(910,14): error TS1005: ',' expected.
src/NativeTokenGateway_61476130.ts(910,158): error TS1005: ',' expected.
src/NativeTokenGateway_61476130.ts(910,172): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(910,175): error TS1068: Unexpected token. A constructor, method, accessor, or property was expected.
src/NativeTokenGateway_61476130.ts(912,6): error TS1128: Declaration or statement expected.
src/NativeTokenGateway_61476130.ts(934,29): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(946,19): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(958,17): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(970,16): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(982,18): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(994,40): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1006,28): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1018,32): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1030,14): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1044,22): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1056,16): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1068,17): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1082,19): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1096,20): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1110,17): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1122,13): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1136,11): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1150,17): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1165,22): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1177,20): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1191,10): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1207,22): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1211,3): error TS1109: Expression expected.
src/NativeTokenGateway_61476130.ts(1216,3): error TS1128: Declaration or statement expected.
src/NativeTokenGateway_61476130.ts(1235,5): error TS1136: Property assignment expected.
src/NativeTokenGateway_61476130.ts(1235,7): error TS1136: Property assignment expected.
src/NativeTokenGateway_61476130.ts(1235,14): error TS1005: ',' expected.
src/NativeTokenGateway_61476130.ts(1235,158): error TS1005: ',' expected.
src/NativeTokenGateway_61476130.ts(1235,172): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1237,6): error TS1128: Declaration or statement expected.
src/NativeTokenGateway_61476130.ts(1259,29): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1271,19): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1283,17): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1295,16): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1307,18): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1319,40): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1331,28): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1343,32): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1355,14): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1369,22): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1381,16): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1393,17): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1407,19): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1421,20): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1435,17): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1447,13): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1461,11): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1475,17): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1490,22): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1502,20): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1516,10): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1532,22): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1536,3): error TS1109: Expression expected.
src/NativeTokenGateway_61476130.ts(1541,3): error TS1128: Declaration or statement expected.
src/NativeTokenGateway_61476130.ts(1560,5): error TS1136: Property assignment expected.
src/NativeTokenGateway_61476130.ts(1560,191): error TS1005: '{' expected.
src/NativeTokenGateway_61476130.ts(1560,194): error TS1136: Property assignment expected.
src/NativeTokenGateway_61476130.ts(1563,6): error TS1128: Declaration or statement expected.
src/NativeTokenGateway_61476130.ts(1586,29): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1599,19): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1612,17): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1625,16): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1638,18): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1651,40): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1664,28): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1677,32): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1690,14): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1705,22): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1718,16): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1731,17): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1746,19): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1761,20): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1776,17): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1789,13): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1804,11): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1819,17): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1835,22): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1848,20): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1863,10): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1880,22): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1885,3): error TS1109: Expression expected.
src/NativeTokenGateway_61476130.ts(1893,3): error TS1128: Declaration or statement expected.
src/NativeTokenGateway_61476130.ts(1893,22): error TS1005: ',' expected.
src/NativeTokenGateway_61476130.ts(1893,46): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1907,3): error TS1434: Unexpected keyword or identifier.
src/NativeTokenGateway_61476130.ts(1907,33): error TS1005: ',' expected.
src/NativeTokenGateway_61476130.ts(1907,180): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1922,3): error TS1434: Unexpected keyword or identifier.
src/NativeTokenGateway_61476130.ts(1922,30): error TS1005: ',' expected.
src/NativeTokenGateway_61476130.ts(1922,176): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1937,3): error TS1434: Unexpected keyword or identifier.
src/NativeTokenGateway_61476130.ts(1937,31): error TS1005: ',' expected.
src/NativeTokenGateway_61476130.ts(1937,183): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1952,3): error TS1434: Unexpected keyword or identifier.
src/NativeTokenGateway_61476130.ts(1952,28): error TS1005: ',' expected.
src/NativeTokenGateway_61476130.ts(1952,272): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1967,3): error TS1434: Unexpected keyword or identifier.
src/NativeTokenGateway_61476130.ts(1967,22): error TS1005: ',' expected.
src/NativeTokenGateway_61476130.ts(1967,169): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1982,3): error TS1434: Unexpected keyword or identifier.
src/NativeTokenGateway_61476130.ts(1982,28): error TS1005: ',' expected.
src/NativeTokenGateway_61476130.ts(1982,170): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(1997,3): error TS1434: Unexpected keyword or identifier.
src/NativeTokenGateway_61476130.ts(1997,21): error TS1005: ',' expected.
src/NativeTokenGateway_61476130.ts(1997,149): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(2087,3): error TS1128: Declaration or statement expected.
src/NativeTokenGateway_61476130.ts(2087,20): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(2087,22): error TS1434: Unexpected keyword or identifier.
src/NativeTokenGateway_61476130.ts(2096,7): error TS1136: Property assignment expected.
src/NativeTokenGateway_61476130.ts(2096,14): error TS1005: ',' expected.
src/NativeTokenGateway_61476130.ts(2096,159): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(2100,8): error TS1128: Declaration or statement expected.
src/NativeTokenGateway_61476130.ts(2104,26): error TS1005: ',' expected.
src/NativeTokenGateway_61476130.ts(2104,267): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(2108,8): error TS1128: Declaration or statement expected.
src/NativeTokenGateway_61476130.ts(2112,38): error TS1005: ',' expected.
src/NativeTokenGateway_61476130.ts(2112,303): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(2116,8): error TS1128: Declaration or statement expected.
src/NativeTokenGateway_61476130.ts(2120,28): error TS1005: ',' expected.
src/NativeTokenGateway_61476130.ts(2120,273): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(2124,8): error TS1128: Declaration or statement expected.
src/NativeTokenGateway_61476130.ts(2128,26): error TS1005: ',' expected.
src/NativeTokenGateway_61476130.ts(2128,267): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(2132,8): error TS1128: Declaration or statement expected.
src/NativeTokenGateway_61476130.ts(2136,25): error TS1005: ',' expected.
src/NativeTokenGateway_61476130.ts(2136,264): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(2140,8): error TS1128: Declaration or statement expected.
src/NativeTokenGateway_61476130.ts(2144,27): error TS1005: ',' expected.
src/NativeTokenGateway_61476130.ts(2144,222): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(2148,8): error TS1128: Declaration or statement expected.
src/NativeTokenGateway_61476130.ts(2152,49): error TS1005: ',' expected.
src/NativeTokenGateway_61476130.ts(2152,350): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(2156,8): error TS1128: Declaration or statement expected.
src/NativeTokenGateway_61476130.ts(2160,37): error TS1005: ',' expected.
src/NativeTokenGateway_61476130.ts(2160,356): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(2164,8): error TS1128: Declaration or statement expected.
src/NativeTokenGateway_61476130.ts(2168,41): error TS1005: ',' expected.
src/NativeTokenGateway_61476130.ts(2168,270): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(2172,8): error TS1128: Declaration or statement expected.
src/NativeTokenGateway_61476130.ts(2176,23): error TS1005: ',' expected.
src/NativeTokenGateway_61476130.ts(2176,202): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(2180,8): error TS1128: Declaration or statement expected.
src/NativeTokenGateway_61476130.ts(2184,31): error TS1005: ',' expected.
src/NativeTokenGateway_61476130.ts(2184,224): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(2188,8): error TS1128: Declaration or statement expected.
src/NativeTokenGateway_61476130.ts(2192,25): error TS1005: ',' expected.
src/NativeTokenGateway_61476130.ts(2192,238): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(2196,8): error TS1128: Declaration or statement expected.
src/NativeTokenGateway_61476130.ts(2200,26): error TS1005: ',' expected.
src/NativeTokenGateway_61476130.ts(2200,225): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(2204,8): error TS1128: Declaration or statement expected.
src/NativeTokenGateway_61476130.ts(2208,28): error TS1005: ',' expected.
src/NativeTokenGateway_61476130.ts(2208,207): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(2212,8): error TS1128: Declaration or statement expected.
src/NativeTokenGateway_61476130.ts(2216,29): error TS1005: ',' expected.
src/NativeTokenGateway_61476130.ts(2216,214): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(2220,8): error TS1128: Declaration or statement expected.
src/NativeTokenGateway_61476130.ts(2224,26): error TS1005: ',' expected.
src/NativeTokenGateway_61476130.ts(2224,303): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(2228,8): error TS1128: Declaration or statement expected.
src/NativeTokenGateway_61476130.ts(2232,22): error TS1005: ',' expected.
src/NativeTokenGateway_61476130.ts(2232,203): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(2236,8): error TS1128: Declaration or statement expected.
src/NativeTokenGateway_61476130.ts(2240,20): error TS1005: ',' expected.
src/NativeTokenGateway_61476130.ts(2240,213): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(2244,8): error TS1128: Declaration or statement expected.
src/NativeTokenGateway_61476130.ts(2248,26): error TS1005: ',' expected.
src/NativeTokenGateway_61476130.ts(2248,201): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(2252,8): error TS1128: Declaration or statement expected.
src/NativeTokenGateway_61476130.ts(2256,31): error TS1005: ',' expected.
src/NativeTokenGateway_61476130.ts(2256,224): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(2260,8): error TS1128: Declaration or statement expected.
src/NativeTokenGateway_61476130.ts(2264,29): error TS1005: ',' expected.
src/NativeTokenGateway_61476130.ts(2264,204): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(2268,8): error TS1128: Declaration or statement expected.
src/NativeTokenGateway_61476130.ts(2272,19): error TS1005: ',' expected.
src/NativeTokenGateway_61476130.ts(2272,180): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(2276,8): error TS1128: Declaration or statement expected.
src/NativeTokenGateway_61476130.ts(2280,31): error TS1005: ',' expected.
src/NativeTokenGateway_61476130.ts(2280,210): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(2284,8): error TS1128: Declaration or statement expected.
src/NativeTokenGateway_61476130.ts(2288,24): error TS1005: ',' expected.
src/NativeTokenGateway_61476130.ts(2288,51): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(2291,8): error TS1128: Declaration or statement expected.
src/NativeTokenGateway_61476130.ts(2292,25): error TS1005: ',' expected.
src/NativeTokenGateway_61476130.ts(2292,47): error TS1109: Expression expected.
src/NativeTokenGateway_61476130.ts(2292,68): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(2295,8): error TS1128: Declaration or statement expected.
src/NativeTokenGateway_61476130.ts(2296,7): error TS1434: Unexpected keyword or identifier.
src/NativeTokenGateway_61476130.ts(2296,24): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(2299,8): error TS1128: Declaration or statement expected.
src/NativeTokenGateway_61476130.ts(2300,7): error TS1434: Unexpected keyword or identifier.
src/NativeTokenGateway_61476130.ts(2300,30): error TS1109: Expression expected.
src/NativeTokenGateway_61476130.ts(2300,49): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(2307,8): error TS1128: Declaration or statement expected.
src/NativeTokenGateway_61476130.ts(2308,7): error TS1434: Unexpected keyword or identifier.
src/NativeTokenGateway_61476130.ts(2308,25): error TS1109: Expression expected.
src/NativeTokenGateway_61476130.ts(2308,39): error TS1005: ';' expected.
src/NativeTokenGateway_61476130.ts(2316,7): error TS1434: Unexpected keyword or identifier.
src/NativeTokenGateway_61476130.ts(2317,3): error TS1128: Declaration or statement expected.
src/NativeTokenGateway_61476130.ts(2318,1): error TS1128: Declaration or statement expected.
```
