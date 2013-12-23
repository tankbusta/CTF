import string

message = """qngrZba Qrp 16 16:08:25 RFG 2013
hanzrQnejva
hanzr -nQnejva qho.ubzr 11.4.2 Qnejva Xreary Irefvba 11.4.2: Guh Nht 23 16:25:48 CQG 2012; ebbg:kah-1699.32.7~1/ERYRNFR_K86_64 k86_64
ubfganzrqho.ubzr
hcgvzr16:08  hc 30 qnlf,  7:22, 4 hfref, ybnq nirentrf: 1.30 1.03 1.00
yf /.QF_Fgber
.QbphzragErivfvbaf-I100
.Fcbgyvtug-I100
.Genfurf
.svyr
.sfriragfq
.ubgsvyrf.ogerr
.iby
Nccyvpngvbaf
Qrirybcre
Yvoenel
Argjbex
Flfgrz
Hfref
Ibyhzrf
ova
pberf
qri
rgp
ubzr
yvocrrepbaarpgvba.ybt
znpu_xreary
arg
bcg
cevingr
fova
gzc
hfe
ine
yf /gzc.VPR-havk
.K11-havk
.sbag-havk
006o452oo868o
IZjnerQaQ
synt
ynhapuq-86611.wqeTIK
png /gzc/syntQrne Fnagn, Gur orfg fbyhgvba vf nyjnlf gb perngr lbhe bja pelcgb synt{FFUJnaanOr}
!rkvg"""
mix = string.maketrans("NOPQRSTUVWXYZnopqrstuvwxyzABCDEFGHIJKLMabcdefghijklm", "ABCDEFGHIJKLMabcdefghijklmNOPQRSTUVWXYZnopqrstuvwxyz")
print string.translate(message, mix)