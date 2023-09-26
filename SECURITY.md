# SMWMTL • Security and Support Policy

As SMWMTL is not a critical application and never touches at critical Windows features, security risk will (normally) always be minimal. However, if you found something that can compromize the security of your system (if it not touches to .NET Framework itself), you can send an Issue report with the "[URG-SECURITY]" tag in the begin of the issue title.

Remember that if the problem you wants to report is from .NET Framework itself, I probably can't fix it except by changing the .NET Framework version used, which will leads to end support for Windows Vista and 8 (which don't support .NET Framework versions above 4.6) unplannedly.

<sup>*See [Supported Operating Systems](../Dev/SystemComp.md) for more details about supported operating systems.*</sup>

## Versions support policy

When a new version is released, the previous one remains supported for 13 months. The end of support date for a version is always at the Patch Tuesday of the 13th month.

However, there's an exception for the last release of a codebase (like 1.20 and 2.07) which all have an end of support date 4 years after the release date.

## Supported Versions

### Published versions

| Version            | Release Date       | End of Support date | Support state            |
| ------------------ | ------------------ | ------------------- | ------------------------ |
| 2.28               | 24 September 2023  | -                   | Supported                |
| 2.27               | 16 April 2023      | 12 November 2024    | Supported                |
| 2.26               | 13 December 2022   | 14 May 2024         | Supported                |
| 2.25               | 07 November 2022   | 09 January 2024     | Supported                |
| 2.24               | 25 September 2022  | 12 December 2023    | Supported                |
| 2.23               | 04 September 2022  | 14 November 2023    | Supported                |
| 2.22               | 02 July 2022       | 10 October 2023     | Supported                |
| 2.21               | 15 May 2022        | 08 August 2023      | Support Ended            |
| 2.20               | 10 May 2022        | 08 August 2023      | Support Ended            |
||
|        2.10-LTS.16 | 24 September 2023  | -                   | Supported                |
|        2.10-LTS.15 | 16 April 2023      | 12 November 2024    | Supported                |
|        2.10-LTS.14 | 13 December 2022   | 14 May 2024         | Supported                |
|        2.10-LTS.13 | 07 November 2022   | 09 January 2024     | Supported                |
|        2.10-LTS.12 | 25 September 2022  | 12 December 2023    | Supported                |
|        2.10-LTS.11 | 04 September 2022  | 14 November 2023    | Supported                |
|        2.10-LTS.10 | 02 July 2022       | 10 October 2023     | Supported                |
|        2.10-LTS.9  | 10 May 2022        | 08 August 2023      | Support Ended            |
| 2.18 • 2.10-LTS.8  | 21 April 2022      | 13 June 2023        | Support Ended            |
| 2.17 • 2.10-LTS.7  | 08 March 2022      | 09 May 2023         | Support Ended            |
| 2.16               | 15 January 2022    | 11 April 2023       | Support Ended            |
| 2.15 • 2.10-LTS.6  | 11 January 2022    | 11 April 2023       | Support Ended            |
| 2.14 • 2.10-LTS.5  | 10 November 2021   | 14 February 2023    | Support Ended            |
| 2.13 • 2.10-LTS.4  | 19 September 2021  | 13 December 2022    | Support Ended            |
| 2.12 • 2.10-LTS.3  | 10 August 2021     | 11 October 2022     | Support Ended            |
| 2.11 • 2.10-LTS.2  | 16 June 2021       | 13 September 2022   | Support Ended            |
| 2.10 • 2.10-LTS.1  | 13 April 2021      | 12 July 2022        | Support Ended            |
||
| 2.07               | 09 March 2021      | 11 March 2025       | Supported (Last Release) |
| 2.06               | 09 February 2021   | 12 April 2022       | Support Ended            |
| 2.05               | 07 January 2021    | 08 March 2022       | Support Ended            |
| 2.04               | 04 November 2020   | 08 February 2022    | Support Ended            |
| 2.03               | 29 October 2020    | 14 December 2021    | Support Ended            |
| 2.02               | 29 September 2020  | 14 December 2021    | Support Ended            |
| 2.01               | 02 September 2020  | 09 November 2021    | Support Ended            |
| 2.00               | 11 June 2020       | 12 October 2021     | Support Ended            |
||
| 1.20               | 11 October 2019    | 10 October 2023     | Supported (Last Release) |
| 1.10               | 01 July 2019       | 05 March 2021       | Support Ended            |
| 1.00               | 28 December 2018   | 05 March 2021       | Support Ended            |

### Beta releases

| Version            | Release Date       | End of Support date | Support state            |
| ------------------ | ------------------ | ------------------- | ------------------------ |
| 2.20 RC4           | 24 April 2022      | 17 May 2022         | Support Ended            |
| 2.20 RC3           | 17 April 2022      | 17 May 2022         | Support Ended            |
| 2.20 RC2           | 17 March 2022      | 17 May 2022         | Support Ended            |
| 2.20 RC1           | 17 February 2022   | 17 May 2022         | Support Ended            |
||
| 2.10 RC2           | 20 March 2021      | 20 April 2021       | Support Ended            |
| 2.10 RC1           | 24 February 2021   | 20 April 2021       | Support Ended            |
| 2.10 Public Beta   | 28 December 2020   | 05 March 2021       | Support Ended            |

## Reporting a Vulnerability

See the first part of this document for how create an Issue ticket.

If a Security-related issue is opened since more than 24h and I still not responded to it, you can ping me on Twitter ([@Kiki79250CoC](https://twitter.com/Kiki79250CoC)), and normally I will see it (except if my Internet connection is down).
