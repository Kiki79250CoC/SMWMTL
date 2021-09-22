# SMWMTL Compatibility testing :
In this table, you can see if some versions of Windows are supported or not.

## Client Windows versions :

### Stable Releases
| SMWMTL Version | Windows XP¹  | Windows Vista | Windows 7 | Windows 8.x | Windows 10² | Windows 11 |
| -------------- | ------------ | ------------- | --------- | ----------- | ----------- | ---------- |
| SMWMTL 1.00³   | Yes (SP3)    | Yes (SP2)     | Yes (SP1) | Yes         | Yes         | No         |
| SMWMTL 1.10³   | Yes (SP3)    | Yes (SP2)     | Yes (SP1) | Yes         | Yes         | No         |
| SMWMTL 1.20³   | Yes (SP3)    | Yes (SP2)     | Yes (SP1) | Yes         | Yes         | No         |
| SMWMTL 2.00    | Yes (SP3)    | Yes (SP2)     | Yes (SP1) | Yes         | 1511-20H2   | No         |
| SMWMTL 2.01    | Yes (SP3)    | Yes (SP2)     | Yes (SP1) | Yes         | 1511-20H2   | No         |
| SMWMTL 2.02    | Yes (SP3)    | Yes (SP2)     | Yes (SP1) | Yes         | 1511-2004⁴  | No         |
| SMWMTL 2.03    | Yes (SP3)    | Yes (SP2)     | Yes (SP1) | Yes         | 1511-20H2   | No         |
| SMWMTL 2.04    | Yes (SP3)    | Yes (SP2)     | Yes (SP1) | Yes         | 1511-20H2   | No         |
| SMWMTL 2.05    | Yes (SP3)    | Yes (SP2)     | Yes (SP1) | Yes         | 1511-20H2   | No         |
| SMWMTL 2.06    | Yes (SP3)    | Yes (SP2)     | Yes (SP1) | Yes         | 1511-20H2   | No         |
| SMWMTL 2.07    | Yes (SP3)    | Yes (SP2)     | Yes (SP1) | Yes         | 1511-20H2   | No         |
| SMWMTL 2.10    | Yes (SP3)    | Yes (SP2)     | Yes (SP1) | Yes         | 1511-20H2   | No         |
| SMWMTL 2.11    | Yes (SP3)    | Yes (SP2)     | Yes (SP1) | Yes         | 1511-21H1   | No         |
| SMWMTL 2.12    | Yes (SP3)    | Yes (SP2)     | Yes (SP1) | Yes         | 1511-21H2   | Partial    |
| SMWMTL 2.13    | Yes (SP3)    | Yes (SP2)     | Yes (SP1) | Yes         | 1511-21H2   | Yes (RTM)  |
| -------------- | ------------ | ------------- | --------- | ----------- | ----------- | ---------- |
| SMWMTL 2.20 (Beta) | No       | Yes (SP2)     | Yes (SP1) | Yes         | 1511-21H2   | Yes (RTM)  |

### LTS Releases
| SMWMTL Version    | Windows XP¹  | Windows Vista | Windows 7 | Windows 8.x | Windows 10² | Windows 11 |
| ----------------- | ------------ | ------------- | --------- | ----------- | ----------- | ---------- |
| SMWMTL 2.10-LTS.1 | Yes (SP3)    | Yes (SP2)     | Yes (SP1) | Yes         | 1511-20H2   | No         |
| SMWMTL 2.10-LTS.2 | Yes (SP3)    | Yes (SP2)     | Yes (SP1) | Yes         | 1511-21H1   | No         |
| SMWMTL 2.10-LTS.3 | Yes (SP3)    | Yes (SP2)     | Yes (SP1) | Yes         | 1511-21H2   | Partial    |
| SMWMTL 2.10-LTS.4 | Yes (SP3)    | Yes (SP2)     | Yes (SP1) | Yes         | 1511-21H2   | Yes (RTM)  |

- ¹ : Windows XP can have some features missing like SMWMTL_Update or built-in application that don't support this OS.
- ² : Windows 10 1507 can have a broken compatibility with OS detection.
- ³ : SMWMTL 1.xx help file mentions only Windows 8+ as compatible. These versions can run on XP, Vista and 7 fine.
- ⁴ : Windows 10 20H2 detection is broken due to Registry Key changes.

## Server Windows versions :
*For who use Windows Server as main OS (yes, these people exists).*

### Stable Releases
| SMWMTL Version | Windows Server 2003¹  | 2008      | 2008 R2   | 2012  | 2012 R2  | 2016  | 2019  | 2022  |
| -------------- | --------------------- | ----------| --------- | ----- | -------- | ----- | ----- | ----- |
| SMWMTL 1.00²   | Yes (SP2)             | Yes (SP2) | Yes (SP1) | Yes   | Yes      | Yes   | Yes   | No    |
| SMWMTL 1.10²   | Yes (SP2)             | Yes (SP2) | Yes (SP1) | Yes   | Yes      | Yes   | Yes   | No    |
| SMWMTL 1.20²   | Yes (SP2)             | Yes (SP2) | Yes (SP1) | Yes   | Yes      | Yes   | Yes   | No    |
| SMWMTL 2.00    | Yes (SP2)             | Yes (SP2) | Yes (SP1) | Yes   | Yes      | Yes   | Yes   | No    |
| SMWMTL 2.01    | Yes (SP2)             | Yes (SP2) | Yes (SP1) | Yes   | Yes      | Yes   | Yes   | No    |
| SMWMTL 2.02    | Yes (SP2)             | Yes (SP2) | Yes (SP1) | Yes   | Yes      | Yes   | Yes   | No    |
| SMWMTL 2.03    | Yes (SP2)             | Yes (SP2) | Yes (SP1) | Yes   | Yes      | Yes   | Yes   | No    |
| SMWMTL 2.04    | Yes (SP2)             | Yes (SP2) | Yes (SP1) | Yes   | Yes      | Yes   | Yes   | No    |
| SMWMTL 2.05    | Yes (SP2)             | Yes (SP2) | Yes (SP1) | Yes   | Yes      | Yes   | Yes   | No    |
| SMWMTL 2.06    | Yes (SP2)             | Yes (SP2) | Yes (SP1) | Yes   | Yes      | Yes   | Yes   | No    |
| SMWMTL 2.07    | Yes (SP2)             | Yes (SP2) | Yes (SP1) | Yes   | Yes      | Yes   | Yes   | No    |
| SMWMTL 2.10    | Yes (SP2)             | Yes (SP2) | Yes (SP1) | Yes   | Yes      | Yes   | Yes   | No    |
| SMWMTL 2.11    | Yes (SP2)             | Yes (SP2) | Yes (SP1) | Yes   | Yes      | Yes   | Yes   | No    |
| SMWMTL 2.12    | Yes (SP2)             | Yes (SP2) | Yes (SP1) | Yes   | Yes      | Yes   | Yes   | Yes   |
| SMWMTL 2.13    | Yes (SP2)             | Yes (SP2) | Yes (SP1) | Yes   | Yes      | Yes   | Yes   | Yes   |
| -------------- | --------------------- | ----------| --------- | ----- | -------- | ----- | ----- | ----- |
| SMWMTL 2.20 (Beta) | No                | Yes (SP2) | Yes (SP1) | Yes   | Yes      | Yes   | Yes   | Yes   |

### LTS Releases
| SMWMTL Version    | Windows Server 2003¹  | 2008      | 2008 R2   | 2012  | 2012 R2  | 2016  | 2019  | 2022  |
| ----------------- | --------------------- | ----------| --------- | ----- | -------- | ----- | ----- | ----- |
| SMWMTL 2.10-LTS.1 | Yes (SP2)             | Yes (SP2) | Yes (SP1) | Yes   | Yes      | Yes   | Yes   | No    |
| SMWMTL 2.10-LTS.2 | Yes (SP2)             | Yes (SP2) | Yes (SP1) | Yes   | Yes      | Yes   | Yes   | No    |
| SMWMTL 2.10-LTS.3 | Yes (SP2)             | Yes (SP2) | Yes (SP1) | Yes   | Yes      | Yes   | Yes   | Yes   |
| SMWMTL 2.10-LTS.4 | Yes (SP2)             | Yes (SP2) | Yes (SP1) | Yes   | Yes      | Yes   | Yes   | Yes   |

- ¹ : Like Windows XP, Server 2003 can have some features missing like SMWMTL_Update or built-in application that don't support this OS.
