# Modules to force-load during initramfs stage
# (no module autoloading on mount in Busybox)
force_load_vfat='vfat nls_cp437 nls_iso8859-1 nls_utf8'
force_load_iso9660='isofs nls_iso8859-1 nls_utf8'
force_load_ext2='ext4'
force_load_ext3='ext4'
force_load_ext4='ext4'
force_load_hfsplus='hfsplus nls_utf8'

force_load_auto="${force_load_vfat} ${force_load_iso9660} ${force_load_ext4}"
